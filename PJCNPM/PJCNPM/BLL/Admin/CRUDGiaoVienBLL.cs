using PJCNPM.DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace PJCNPM.BLL.Admin
{
    public class CRUDGiaoVienBLL
    {
        private readonly DBConnection db;

        public CRUDGiaoVienBLL()
        {
            db = new DBConnection();
        }

        // 🔹 Lấy tất cả giáo viên
        public DataTable GetAllGiaoVien()
        {
            string sql = @"
                SELECT 
                    G.GiaoVienID, G.HoTen, G.NgaySinh, G.TenTK, G.Email, G.DienThoai, G.CCCD,
                    CASE WHEN G.GioiTinh = 0 THEN N'Nam' ELSE N'Nữ' END AS GioiTinhText,
                    G.GioiTinh, G.DanToc, G.TonGiao, G.LaDangVien, G.NoiThuongTru, G.QueQuan
                FROM dbo.GiaoVien G
                ORDER BY G.HoTen;";
            return db.GetData(sql);
        }

        // 🔹 Tìm kiếm giáo viên theo từ khóa
        public DataTable SearchGiaoVien(string keyword)
        {
            string sql = @"
                SELECT 
                    G.GiaoVienID, G.HoTen, G.NgaySinh, G.TenTK, G.Email, G.DienThoai, G.CCCD,
                    CASE WHEN G.GioiTinh = 0 THEN N'Nam' ELSE N'Nữ' END AS GioiTinhText,
                    G.GioiTinh, G.DanToc, G.TonGiao, G.LaDangVien, G.NoiThuongTru, G.QueQuan
                FROM dbo.GiaoVien G
                WHERE G.HoTen LIKE @keyword 
                   OR G.Email LIKE @keyword 
                   OR G.DienThoai LIKE @keyword
                   OR G.TenTK LIKE @keyword
                   OR G.CCCD LIKE @keyword
                ORDER BY G.HoTen;";

            SqlParameter[] prms =
            {
                new SqlParameter("@keyword", "%" + keyword + "%")
            };

            return db.GetData(sql, prms);
        }

        // 🔹 Thêm giáo viên + tài khoản tương ứng (RoleID = 2)
        public bool AddGiaoVien(
            string hoTen, bool gioiTinh, DateTime ngaySinh, string cccd,
            string email, string dienThoai, string danToc, string tonGiao,
            bool laDangVien, string noiThuongTru, string queQuan,
            string tenTK, string matKhau)
        {
            try
            {
                // B1: Thêm tài khoản
                string sqlAddTK = @"
                    INSERT INTO dbo.TaiKhoan (TenTK, MatKhau, RoleID, TrangThai)
                    VALUES (@TenTK, @MatKhau, 2, 1);";

                SqlParameter[] prmsTK =
                {
                    new SqlParameter("@TenTK", tenTK),
                    new SqlParameter("@MatKhau", matKhau)
                };

                if (!db.ExecuteNonQuery(sqlAddTK, prmsTK))
                    throw new Exception("Không thể thêm tài khoản.");

                // B2: Thêm giáo viên
                string sqlAddGV = @"
                    INSERT INTO dbo.GiaoVien
                    (HoTen, GioiTinh, NgaySinh, CCCD, Email, DienThoai, DanToc, TonGiao,
                     LaDangVien, NoiThuongTru, QueQuan, TenTK, TrangThai)
                    VALUES
                    (@HoTen, @GioiTinh, @NgaySinh, @CCCD, @Email, @DienThoai, @DanToc,
                     @TonGiao, @LaDangVien, @NoiThuongTru, @QueQuan, @TenTK, 1);";

                SqlParameter[] prmsGV =
                {
                    new SqlParameter("@HoTen", hoTen),
                    new SqlParameter("@GioiTinh", gioiTinh),
                    new SqlParameter("@NgaySinh", ngaySinh),
                    new SqlParameter("@CCCD", string.IsNullOrEmpty(cccd) ? (object)DBNull.Value : cccd),
                    new SqlParameter("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email),
                    new SqlParameter("@DienThoai", string.IsNullOrEmpty(dienThoai) ? (object)DBNull.Value : dienThoai),
                    new SqlParameter("@DanToc", string.IsNullOrEmpty(danToc) ? (object)DBNull.Value : danToc),
                    new SqlParameter("@TonGiao", string.IsNullOrEmpty(tonGiao) ? (object)DBNull.Value : tonGiao),
                    new SqlParameter("@LaDangVien", laDangVien),
                    new SqlParameter("@NoiThuongTru", string.IsNullOrEmpty(noiThuongTru) ? (object)DBNull.Value : noiThuongTru),
                    new SqlParameter("@QueQuan", string.IsNullOrEmpty(queQuan) ? (object)DBNull.Value : queQuan),
                    new SqlParameter("@TenTK", tenTK)
                };

                if (!db.ExecuteNonQuery(sqlAddGV, prmsGV))
                    throw new Exception("Không thể thêm giáo viên.");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi thêm giáo viên: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // 🔹 Cập nhật giáo viên
        public bool UpdateGiaoVien(int giaoVienID, string hoTen, bool gioiTinh, DateTime ngaySinh,
            string cccd, string email, string dienThoai, string danToc, string tonGiao,
            bool laDangVien, string noiThuongTru, string queQuan)
        {
            string sql = @"
                UPDATE dbo.GiaoVien 
                SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh,
                    CCCD = @CCCD, Email = @Email, DienThoai = @DienThoai,
                    DanToc = @DanToc, TonGiao = @TonGiao, LaDangVien = @LaDangVien,
                    NoiThuongTru = @NoiThuongTru, QueQuan = @QueQuan
                WHERE GiaoVienID = @GiaoVienID;";

            SqlParameter[] prms =
            {
                new SqlParameter("@GiaoVienID", giaoVienID),
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@GioiTinh", gioiTinh),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@CCCD", string.IsNullOrEmpty(cccd) ? (object)DBNull.Value : cccd),
                new SqlParameter("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email),
                new SqlParameter("@DienThoai", string.IsNullOrEmpty(dienThoai) ? (object)DBNull.Value : dienThoai),
                new SqlParameter("@DanToc", string.IsNullOrEmpty(danToc) ? (object)DBNull.Value : danToc),
                new SqlParameter("@TonGiao", string.IsNullOrEmpty(tonGiao) ? (object)DBNull.Value : tonGiao),
                new SqlParameter("@LaDangVien", laDangVien),
                new SqlParameter("@NoiThuongTru", string.IsNullOrEmpty(noiThuongTru) ? (object)DBNull.Value : noiThuongTru),
                new SqlParameter("@QueQuan", string.IsNullOrEmpty(queQuan) ? (object)DBNull.Value : queQuan)
            };

            return db.ExecuteNonQuery(sql, prms);
        }

        // 🔹 Xóa giáo viên + dữ liệu liên quan
        public string DeleteGiaoVien(int giaoVienID)
        {
            StringBuilder report = new StringBuilder("--- BÁO CÁO XÓA GIÁO VIÊN ---\n");

            try
            {
                // Lấy TenTK
                string sqlGetTK = "SELECT TenTK FROM dbo.GiaoVien WHERE GiaoVienID = @id;";
                string tenTK = db.ExecuteScalar(sqlGetTK, new SqlParameter("@id", giaoVienID))?.ToString();

                // Xóa liên quan
                report.Append(DeleteRelatedData("PhanCong", "GiaoVienID", giaoVienID));
                report.Append(DeleteRelatedData("LichDangKiPhong", "GiaoVienID", giaoVienID));
                report.Append(DeleteRelatedData("ChinhSuaGiaoVien", "GiaoVienID", giaoVienID));

                // Gỡ vai trò chủ nhiệm
                string sqlUnsetCN = "UPDATE dbo.Lop SET GiaoVienID = NULL WHERE GiaoVienID = @id;";
                int affected = db.ExecuteNonQuery_ReturnRowsAffected(sqlUnsetCN, new SqlParameter("@id", giaoVienID));
                if (affected > 0)
                    report.AppendLine($"- Gỡ vai trò chủ nhiệm khỏi {affected} lớp.");

                // Xóa giáo viên
                string sqlDelGV = "DELETE FROM dbo.GiaoVien WHERE GiaoVienID = @id;";
                if (db.ExecuteNonQuery(sqlDelGV, new SqlParameter[] { new SqlParameter("@id", giaoVienID) }))
                    report.AppendLine("- Đã xóa bản ghi giáo viên chính.");

                // Xóa tài khoản
                if (!string.IsNullOrEmpty(tenTK))
                    report.Append(DeleteRelatedData("TaiKhoan", "TenTK", tenTK));

                report.AppendLine("\n>>> XÓA THÀNH CÔNG! <<<");
                return report.ToString();
            }
            catch (Exception ex)
            {
                return $"--- XÓA THẤT BẠI ---\nChi tiết lỗi: {ex.Message}";
            }
        }

        // 🔹 Hàm phụ trợ: xóa dữ liệu liên quan
        private string DeleteRelatedData(string table, string column, object value)
        {
            string sql = $"DELETE FROM dbo.{table} WHERE {column} = @value;";
            int rows = db.ExecuteNonQuery_ReturnRowsAffected(sql, new SqlParameter("@value", value));

            if (rows > 0)
            {
                if (table == "TaiKhoan") return $"- Đã xóa tài khoản '{value}'.\n";
                return $"- Đã xóa {rows} bản ghi trong bảng [{table}].\n";
            }
            return string.Empty;
        }

        // 🔹 Kiểm tra tên tài khoản đã tồn tại chưa
        public bool IsTenTKExists(string tenTK)
        {
            string sql = "SELECT COUNT(1) FROM dbo.TaiKhoan WHERE TenTK = @TenTK;";
            object result = db.ExecuteScalar(sql, new SqlParameter("@TenTK", tenTK));
            return Convert.ToInt32(result) > 0;
        }
    }
}
