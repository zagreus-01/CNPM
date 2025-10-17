using System.Data;
using System.Data.SqlClient;
using PJCNPM.DAL;

namespace PJCNPM.BLL.GiaoVien
{
    public class TaiKhoanBLL
    {
        private readonly DBConnection db;

        public TaiKhoanBLL()
        {
            db = new DBConnection();
        }

        /// <summary>
        /// Lấy mật khẩu đã được mã hóa của một tài khoản từ CSDL.
        /// </summary>
        private string GetHashedPassword(string tenTK)
        {
            string sql = "SELECT MatKhau FROM dbo.TaiKhoan WHERE TenTK = @TenTK";
            object result = db.ExecuteScalar(sql, new SqlParameter("@TenTK", tenTK));
            return result?.ToString();
        }

        /// <summary>
        /// Đổi mật khẩu cho một tài khoản.
        /// </summary>
        public string DoiMatKhau(string tenTK, string matKhauCu, string matKhauMoi)
        {
            // Lấy mật khẩu hiện tại
            string hashedMatKhauCu_DB = GetHashedPassword(tenTK);

            if (string.IsNullOrEmpty(hashedMatKhauCu_DB))
                return "Tài khoản không tồn tại.";

            // So sánh mật khẩu (chưa mã hóa)
            if (matKhauCu != hashedMatKhauCu_DB)
                return "Mật khẩu hiện tại không chính xác.";

            if (matKhauCu == matKhauMoi)
                return "Mật khẩu mới không được trùng với mật khẩu cũ.";

            // Cập nhật mật khẩu mới
            string sql = "UPDATE dbo.TaiKhoan SET MatKhau = @MatKhauMoi WHERE TenTK = @TenTK";

            bool success = db.ExecuteNonQuery(sql, new SqlParameter[]
            {
                new SqlParameter("@MatKhauMoi", matKhauMoi),
                new SqlParameter("@TenTK", tenTK)
            });

            return success ? "Đổi mật khẩu thành công!"
                           : "Đã xảy ra lỗi trong quá trình cập nhật. Vui lòng thử lại.";
        }
    }
}
