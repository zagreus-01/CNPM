using System;
using System.Data;
using PJCNPM.DAL.HocSinh;
using PJCNPM.Utils;

namespace PJCNPM.BLL.HocSinh
{
    public class ThongTinHocSinhBLL
    {
        private readonly ThongTinHocSinhDAL dal = new ThongTinHocSinhDAL();

        // 🔹 Lấy thông tin học sinh
        public HocSinhDTO GetHocSinhById(int id)
        {
            var row = dal.GetHocSinhById(id);
            if (row == null)
                return null;

            // 🔹 Chuyển dữ liệu từ DB sang DTO, có dùng EnumHelper
            return new HocSinhDTO
            {
                HocSinhID = Convert.ToInt32(row["HocSinhID"]),
                HoTen = row["HoTen"].ToString(),
                NgaySinh = Convert.ToDateTime(row["NgaySinh"]),

                // ✅ Dùng helper để chuyển bool → “Nam/Nữ”
                GioiTinh = EnumHelper.GioiTinhToText(Convert.ToBoolean(row["GioiTinh"])),

                DanToc = row["DanToc"].ToString(),
                TonGiao = row["TonGiao"].ToString(),
                QueQuan = row["QueQuan"].ToString(),

                // ✅ Dùng helper để chuyển byte → “Đang học/Nghỉ học/Tạm dừng”
                TrangThai = EnumHelper.TrangThaiHocSinhToText(Convert.ToByte(row["TrangThai"])),

                NamNhapHoc = row["NamNhapHoc"] != DBNull.Value
                    ? Convert.ToInt32(row["NamNhapHoc"])
                    : 0
            };
        }

        // 🔹 Gửi yêu cầu chỉnh sửa thông tin
        public bool GuiYeuCauChinhSua(
            int hocSinhID,
            string hoTenMoi,
            DateTime ngaySinhMoi,
            string gioiTinhText,
            string danTocMoi,
            string tonGiaoMoi,
            string queQuanMoi)
        {
            // Chuyển "Nam"/"Nữ" → bool để gửi xuống DB
            bool gioiTinhMoi = EnumHelper.GioiTinhToValue(gioiTinhText);
            return dal.GuiYeuCauChinhSua(
                hocSinhID, hoTenMoi, ngaySinhMoi, gioiTinhMoi, danTocMoi, tonGiaoMoi, queQuanMoi);
        }
    }

    // DTO tách riêng dữ liệu học sinh
    public class HocSinhDTO
    {
        public int HocSinhID { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }   // dạng "Nam"/"Nữ" để hiển thị UI
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public string QueQuan { get; set; }
        public string TrangThai { get; set; }  // "Đang học", "Nghỉ học"
        public int NamNhapHoc { get; set; }
    }
}
