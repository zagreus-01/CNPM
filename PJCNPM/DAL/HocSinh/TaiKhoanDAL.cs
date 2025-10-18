using System;
using System.Data;

namespace PJCNPM.DAL.HocSinh
{
    internal class TaiKhoanDAL
    {
        private readonly DBConnection db = new DBConnection();

        // 🔹 Lấy thông tin tài khoản học sinh theo ID học sinh
        public DataTable LayTaiKhoanHocSinh(int hocSinhID)
        {
            string query = $@"
                SELECT hs.HoTen, tk.TenTK, tk.MatKhau
                FROM HocSinh hs
                JOIN TaiKhoan tk ON hs.TenTK = tk.TenTK
                WHERE hs.HocSinhID = {hocSinhID}";
            return db.GetData(query);
        }

        // 🔹 Đổi mật khẩu
        public bool DoiMatKhau(string tenTK, string matKhauMoi)
        {
            string query = $@"
                UPDATE TaiKhoan
                SET MatKhau = N'{matKhauMoi}'
                WHERE TenTK = N'{tenTK}'";
            return db.ExecuteNonQuery(query);
        }
    }
}
