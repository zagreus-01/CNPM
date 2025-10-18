using System;
using System.Data;
using PJCNPM.Utils; // Dùng EnumHelper và các enum

namespace PJCNPM.DAL.HocSinh
{
    internal class ThongTinHocSinhDAL
    {
        private readonly DBConnection db = new DBConnection();

        // 🔹 Lấy thông tin học sinh theo ID (dùng EnumHelper để hiển thị text)
        public DataRow GetHocSinhById(int hocSinhID)
        {
            string query = $@"
                SELECT 
                    HocSinhID, 
                    HoTen, 
                    NgaySinh, 
                    GioiTinh, 
                    DanToc, 
                    TonGiao, 
                    QueQuan, 
                    TrangThai, 
                    NamNhapHoc
                FROM HocSinh
                WHERE HocSinhID = {hocSinhID}";

            DataTable dt = db.GetData(query);
            if (dt.Rows.Count == 0) return null;

            // ⚙️ Thêm cột hiển thị text cho UI
            dt.Columns.Add("GioiTinhText", typeof(string));
            dt.Columns.Add("TrangThaiText", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                // 🔸 Giới tính: bool → "Nam"/"Nữ"
                bool gioiTinh = false;
                if (bool.TryParse(row["GioiTinh"]?.ToString(), out bool gt))
                    gioiTinh = gt;
                else if (row["GioiTinh"]?.ToString() == "1")
                    gioiTinh = true;

                row["GioiTinhText"] = EnumHelper.GioiTinhToText(gioiTinh);

                // 🔸 Trạng thái: byte → text (dùng enum)
                if (byte.TryParse(row["TrangThai"]?.ToString(), out byte tt))
                    row["TrangThaiText"] = EnumHelper.TrangThaiHocSinhToText(tt);
                else
                    row["TrangThaiText"] = "Không xác định";
            }

            return dt.Rows[0];
        }

        // 🔹 Gửi yêu cầu chỉnh sửa thông tin học sinh (có giới tính)
        public bool GuiYeuCauChinhSua(
            int hocSinhID,
            string hoTenMoi,
            DateTime ngaySinhMoi,
            bool gioiTinhMoi,
            string danTocMoi,
            string tonGiaoMoi,
            string queQuanMoi)
        {
            string query = $@"
                INSERT INTO ChinhSuaHocSinh
                    (HocSinhID, HoTen, NgaySinh, GioiTinh, DanToc, TonGiao, QueQuan, TrangThaiYeuCau)
                VALUES
                    ({hocSinhID},
                    N'{hoTenMoi.Replace("'", "''")}',
                    '{ngaySinhMoi:yyyy-MM-dd}',
                    {(gioiTinhMoi ? 1 : 0)},
                    N'{danTocMoi.Replace("'", "''")}',
                    N'{tonGiaoMoi.Replace("'", "''")}',
                    N'{queQuanMoi.Replace("'", "''")}',
                    N'Chờ duyệt')";

            return db.ExecuteNonQuery(query);
        }
    }
}
