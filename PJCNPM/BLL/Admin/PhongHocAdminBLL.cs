using System;
using System.Data;
using System.Data.SqlClient;
using PJCNPM.DAL;

namespace PJCNPM.BLL.Admin
{
    public class PhongHocAdminBLL
    {
        private readonly DBConnection db;

        public PhongHocAdminBLL()
        {
            db = new DBConnection();
        }

        // Lấy lịch phòng theo ngày (giữ nguyên)
        public DataTable GetLichPhongTheoNgay(DateTime ngay)
        {
            string sql = @"
                SELECT 
                    ph.PhongHocID, ph.TenPhong, ph.LoaiPhong, ph.SucChua,
                    ldk.DKPhongID AS LichDangKiPhongID, ldk.GiaoVienID AS BookingGiaoVienID, 
                    gv.HoTen AS GiaoVienDangKy, ldk.TietBatDau, ldk.TietKetThuc,
                    l.TenLop, ldk.MucDich
                FROM dbo.PhongHoc ph
                LEFT JOIN dbo.LichDangKiPhong ldk ON ph.PhongHocID = ldk.PhongHocID AND ldk.Ngay = @Ngay
                LEFT JOIN dbo.GiaoVien gv ON ldk.GiaoVienID = gv.GiaoVienID
                LEFT JOIN dbo.Lop l ON ldk.LopID = l.LopID
                ORDER BY ph.TenPhong;";
            return db.GetData(sql, new SqlParameter[] { new SqlParameter("@Ngay", ngay.Date) });
        }

        // 🔹 Lấy TOÀN BỘ lịch sử đăng ký, có hỗ trợ tìm kiếm
        public DataTable GetLichSuDangKy(string searchTerm = "")
        {
            string sql = @"
                SELECT 
                    ldk.DKPhongID AS LichDangKiPhongID, ldk.Ngay, ph.TenPhong,
                    gv.HoTen AS GiaoVienDangKy, ldk.TietBatDau, ldk.TietKetThuc,
                    l.TenLop, ldk.MucDich
                FROM dbo.LichDangKiPhong ldk
                JOIN dbo.PhongHoc ph ON ldk.PhongHocID = ph.PhongHocID
                JOIN dbo.GiaoVien gv ON ldk.GiaoVienID = gv.GiaoVienID
                LEFT JOIN dbo.Lop l ON ldk.LopID = l.LopID
                WHERE (@SearchTerm = '' OR gv.HoTen LIKE @SearchPattern OR ph.TenPhong LIKE @SearchPattern OR l.TenLop LIKE @SearchPattern)
                ORDER BY ldk.Ngay DESC, ldk.TietBatDau ASC;";

            SqlParameter[] parameters = {
                new SqlParameter("@SearchTerm", searchTerm),
                new SqlParameter("@SearchPattern", $"%{searchTerm}%")
            };

            return db.GetData(sql, parameters);
        }

        // Lấy danh sách tất cả giáo viên
        public DataTable GetAllGiaoVien()
        {
            string sql = "SELECT GiaoVienID, HoTen FROM dbo.GiaoVien ORDER BY HoTen;";
            return db.GetData(sql);
        }

        // Lấy danh sách lớp của một giáo viên cụ thể (giữ nguyên)
        public DataTable GetLopCuaGiaoVien(int giaoVienID)
        {
            string sql = @"
                SELECT DISTINCT l.LopID, l.TenLop + N' - Năm ' + CAST(l.NamHoc AS VARCHAR) AS TenLopHienThi
                FROM dbo.PhanCong pc JOIN dbo.Lop l ON pc.LopID = l.LopID
                WHERE pc.GiaoVienID = @GiaoVienID AND (l.DaKetThuc IS NULL OR l.DaKetThuc = 0)
                UNION
                SELECT l.LopID, l.TenLop + N' - Năm ' + CAST(l.NamHoc AS VARCHAR)
                FROM dbo.Lop l
                WHERE l.GiaoVienID = @GiaoVienID AND (l.DaKetThuc IS NULL OR l.DaKetThuc = 0)
                ORDER BY TenLopHienThi;";
            return db.GetData(sql, new SqlParameter[] { new SqlParameter("@GiaoVienID", giaoVienID) });
        }

        // Đăng ký phòng học (giữ nguyên, vì đã nhận GiaoVienID từ tham số)
        public string DangKyPhong(DateTime ngay, int tietBatDau, int tietKetThuc, int phongHocID, int lopID, int giaoVienID, string mucDich)
        {
            // (Code phương thức này giữ nguyên như trong file cũ, không cần thay đổi)
            if (ngay.Date < DateTime.Today)
                return "Không thể đăng ký cho một ngày trong quá khứ.";

            string sqlCheck = @"
                SELECT COUNT(*) FROM dbo.LichDangKiPhong 
                WHERE PhongHocID = @PhongHocID AND Ngay = @Ngay 
                  AND ((@TietBatDau BETWEEN TietBatDau AND TietKetThuc) 
                       OR (@TietKetThuc BETWEEN TietBatDau AND TietKetThuc)
                       OR (TietBatDau BETWEEN @TietBatDau AND @TietKetThuc))";

            SqlParameter[] checkParams = {
                new SqlParameter("@PhongHocID", phongHocID), new SqlParameter("@Ngay", ngay.Date),
                new SqlParameter("@TietBatDau", tietBatDau), new SqlParameter("@TietKetThuc", tietKetThuc)
            };
            object result = db.ExecuteScalar(sqlCheck, checkParams);
            if (Convert.ToInt32(result) > 0)
                return "Phòng đã được đăng ký trong khung giờ này. Vui lòng chọn thời gian khác.";

            string sqlInsert = @"
                INSERT INTO dbo.LichDangKiPhong (Ngay, TietBatDau, TietKetThuc, MucDich, PhongHocID, LopID, GiaoVienID)
                VALUES (@Ngay, @TietBatDau, @TietKetThuc, @MucDich, @PhongHocID, @LopID, @GiaoVienID);";

            SqlParameter[] insertParams = {
                new SqlParameter("@Ngay", ngay.Date), new SqlParameter("@TietBatDau", tietBatDau),
                new SqlParameter("@TietKetThuc", tietKetThuc), new SqlParameter("@MucDich", mucDich),
                new SqlParameter("@PhongHocID", phongHocID), new SqlParameter("@LopID", lopID),
                new SqlParameter("@GiaoVienID", giaoVienID)
            };
            return db.ExecuteNonQuery(sqlInsert, insertParams) ? "Đăng ký phòng thành công!" : "Đã xảy ra lỗi trong quá trình đăng ký.";
        }

        // 🔹 Hủy đăng ký phòng học (Phiên bản Admin)
        public string HuyDangKy(int lichDangKiPhongID)
        {
            // Admin có quyền hủy bất kỳ lịch nào, không cần check GiaoVienID
            string sql = @"DELETE FROM dbo.LichDangKiPhong WHERE DKPhongID = @LichDangKiPhongID";
            int rowsAffected = db.ExecuteNonQuery_ReturnRowsAffected(sql, new SqlParameter("@LichDangKiPhongID", lichDangKiPhongID));

            if (rowsAffected > 0) return "Hủy lịch đăng ký thành công!";
            if (rowsAffected == 0) return "Không tìm thấy lịch đăng ký để hủy.";
            return "Đã xảy ra lỗi trong quá trình hủy.";
        }
    }
}