using System;
using System.Data;
using PJCNPM.DAL.Admin;

namespace PJCNPM.BLL.Admin
{
    public class SaveHocSinhBLL
    {
        private readonly SaveHocSinhDAL dal = new SaveHocSinhDAL();

        // 🔹 Lấy 1 học sinh theo ID
        public DataRow LayHocSinhTheoID(int id)
        {
            DataTable dt = dal.LayHocSinhTheoID(id);
            return dt != null && dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        // 🔹 Lấy danh sách lớp đang hoạt động
        public DataTable LayDanhSachLop()
        {
            return dal.LayDanhSachLop();
        }

        // 🔹 Thêm học sinh mới
        public bool ThemHocSinh(string hoTen, DateTime ngaySinh, bool gioiTinh,
            string danToc, string tonGiao, string queQuan, int namNhapHoc, byte trangThai, int lopId)
        {
            return dal.ThemHocSinh(hoTen, ngaySinh, gioiTinh, danToc, tonGiao, queQuan, namNhapHoc, trangThai, lopId);
        }

        // 🔹 Cập nhật thông tin học sinh
        public bool CapNhatHocSinh(int id, string hoTen, DateTime ngaySinh, bool gioiTinh,
            string danToc, string tonGiao, string queQuan, int namNhapHoc, byte trangThai)
        {
            return dal.CapNhatHocSinh(id, hoTen, ngaySinh, gioiTinh, danToc, tonGiao, queQuan, namNhapHoc, trangThai);
        }

        // 🔹 Hỗ trợ đổi trạng thái text → byte (cho ComboBox)
        public static byte TrangThaiToByte(string text)
        {
            switch (text.Trim().ToLower())
            {
                case "đang học":
                    return 0;
                case "nghỉ học":
                    return 1;
                case "đã tốt nghiệp":
                    return 2;
                default:
                    return 0;
            }
        }

        // 🔹 Ngược lại: byte → text
        public static string TrangThaiToText(byte value)
        {
            switch (value)
            {
                case 0:
                    return "Đang học";
                case 1:
                    return "Nghỉ học";
                case 2:
                    return "Đã tốt nghiệp";
                default:
                    return "Không xác định";
            }
        }
    }
}
