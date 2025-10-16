using System.Data;
using System.Data.SqlClient;

namespace PJCNPM.DAL
{
    internal class TaiKhoanDAL
    {
        private readonly DBConnection db = new DBConnection();

        // ✅ Kiểm tra đăng nhập
        public DataTable KiemTraDangNhap(string username, string password)
        {
            string sql = @"
                SELECT tk.TenTK, tk.RoleID, r.Ten AS RoleName
                FROM TaiKhoan tk
                INNER JOIN Role r ON tk.RoleID = r.RoleID
                WHERE tk.TenTK = @u AND tk.MatKhau = @p AND tk.TrangThai = 1";

            SqlParameter[] prms =
            {
                new SqlParameter("@u", username),
                new SqlParameter("@p", password)
            };

            return db.GetData(sql, prms);
        }

        // ✅ Lấy thông tin giáo viên
        public DataRow LayThongTinGiaoVien(string tenTK)
        {
            string sql = @"
                SELECT GiaoVienID, HoTen, Email, DienThoai, QueQuan
                FROM GiaoVien
                WHERE TenTK = @tk";
            SqlParameter[] prms = { new SqlParameter("@tk", tenTK) };
            DataTable dt = db.GetData(sql, prms);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        // ✅ Lấy thông tin học sinh
        public DataRow LayThongTinHocSinh(string tenTK)
        {
            string sql = @"
                SELECT HocSinhID, HoTen, NgaySinh, GioiTinh, QueQuan
                FROM HocSinh
                WHERE TenTK = @tk";
            SqlParameter[] prms = { new SqlParameter("@tk", tenTK) };
            DataTable dt = db.GetData(sql, prms);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
    }
}
