using System;
using System.Data;
using System.Data.SqlClient;
using PJCNPM.DAL;

namespace PJCNPM.BLL.GiaoVien
{
    public class PhongHocBLL
    {
        private readonly DBConnection db;

        public PhongHocBLL()
        {
            db = new DBConnection();
        }

        // 🔹 Lấy lịch phòng theo ngày
        public DataTable GetLichPhongTheoNgay(DateTime ngay)
        {
            string sql = @"
                SELECT 
                    ph.PhongHocID,
                    ph.TenPhong,
                    ph.LoaiPhong,
                    ph.SucChua,
                    ldk.DKPhongID AS LichDangKiPhongID,
                    ldk.GiaoVienID AS BookingGiaoVienID, 
                    gv.HoTen AS GiaoVienDangKy,
                    ldk.TietBatDau,
                    ldk.TietKetThuc,
                    l.TenLop,
                    ldk.MucDich
                FROM dbo.PhongHoc ph
                LEFT JOIN dbo.LichDangKiPhong ldk 
                    ON ph.PhongHocID = ldk.PhongHocID AND ldk.Ngay = @Ngay
                LEFT JOIN dbo.GiaoVien gv ON ldk.GiaoVienID = gv.GiaoVienID
                LEFT JOIN dbo.Lop l ON ldk.LopID = l.LopID
                ORDER BY ph.TenPhong;";

            return db.GetData(sql, new SqlParameter[]
            {
                new SqlParameter("@Ngay", ngay.Date)
            });
        }

        // 🔹 Lấy lịch sử đăng ký của giáo viên
        public DataTable GetLichSuDangKy(int giaoVienID)
        {
            string sql = @"
                SELECT 
                    ldk.DKPhongID AS LichDangKiPhongID,
                    ldk.Ngay,
                    ph.TenPhong,
                    ldk.TietBatDau,
                    ldk.TietKetThuc,
                    l.TenLop,
                    ldk.MucDich
                FROM dbo.LichDangKiPhong ldk
                JOIN dbo.PhongHoc ph ON ldk.PhongHocID = ph.PhongHocID
                LEFT JOIN dbo.Lop l ON ldk.LopID = l.LopID
                WHERE ldk.GiaoVienID = @GiaoVienID
                ORDER BY ldk.Ngay DESC, ldk.TietBatDau ASC;";

            return db.GetData(sql, new SqlParameter[]
            {
                new SqlParameter("@GiaoVienID", giaoVienID)
            });
        }

        // 🔹 Lấy danh sách lớp mà giáo viên dạy
        public DataTable GetLopCuaGiaoVien(int giaoVienID)
        {
            string sql = @"
                SELECT DISTINCT 
                    l.LopID, 
                    l.TenLop + N' - Năm ' + CAST(l.NamHoc AS VARCHAR) AS TenLopHienThi
                FROM dbo.PhanCong pc 
                    JOIN dbo.Lop l ON pc.LopID = l.LopID
                WHERE pc.GiaoVienID = @GiaoVienID 
                    AND (l.DaKetThuc IS NULL OR l.DaKetThuc = 0)
                UNION
                SELECT l.LopID, l.TenLop + N' - Năm ' + CAST(l.NamHoc AS VARCHAR)
                FROM dbo.Lop l
                WHERE l.GiaoVienID = @GiaoVienID 
                    AND (l.DaKetThuc IS NULL OR l.DaKetThuc = 0)
                ORDER BY TenLopHienThi;";

            return db.GetData(sql, new SqlParameter[]
            {
                new SqlParameter("@GiaoVienID", giaoVienID)
            });
        }

        // 🔹 Đăng ký phòng học
        public string DangKyPhong(DateTime ngay, int tietBatDau, int tietKetThuc, int phongHocID, int lopID, int giaoVienID, string mucDich)
        {
            if (ngay.Date < DateTime.Today)
                return "Không thể đăng ký cho một ngày trong quá khứ.";

            // Kiểm tra trùng lịch
            string sqlCheck = @"
                SELECT COUNT(*) 
                FROM dbo.LichDangKiPhong 
                WHERE PhongHocID = @PhongHocID AND Ngay = @Ngay 
                  AND ((@TietBatDau BETWEEN TietBatDau AND TietKetThuc) 
                       OR (@TietKetThuc BETWEEN TietBatDau AND TietKetThuc)
                       OR (TietBatDau BETWEEN @TietBatDau AND @TietKetThuc))";

            SqlParameter[] checkParams = {
                new SqlParameter("@PhongHocID", phongHocID),
                new SqlParameter("@Ngay", ngay.Date),
                new SqlParameter("@TietBatDau", tietBatDau),
                new SqlParameter("@TietKetThuc", tietKetThuc)
            };

            object result = db.ExecuteScalar(sqlCheck, checkParams);
            int count = (result == null || result == DBNull.Value) ? 0 : Convert.ToInt32(result);

            if (count > 0)
                return "Phòng đã được đăng ký trong khung giờ này. Vui lòng chọn thời gian khác.";

            // Thực hiện đăng ký
            string sqlInsert = @"
                INSERT INTO dbo.LichDangKiPhong (Ngay, TietBatDau, TietKetThuc, MucDich, PhongHocID, LopID, GiaoVienID)
                VALUES (@Ngay, @TietBatDau, @TietKetThuc, @MucDich, @PhongHocID, @LopID, @GiaoVienID);";

            SqlParameter[] insertParams = {
                new SqlParameter("@Ngay", ngay.Date),
                new SqlParameter("@TietBatDau", tietBatDau),
                new SqlParameter("@TietKetThuc", tietKetThuc),
                new SqlParameter("@MucDich", mucDich),
                new SqlParameter("@PhongHocID", phongHocID),
                new SqlParameter("@LopID", lopID),
                new SqlParameter("@GiaoVienID", giaoVienID)
            };

            bool success = db.ExecuteNonQuery(sqlInsert, insertParams);
            return success ? "Đăng ký phòng thành công!" : "Đã xảy ra lỗi trong quá trình đăng ký.";
        }

        // 🔹 Hủy đăng ký phòng học
        public string HuyDangKy(int lichDangKiPhongID, int giaoVienID)
        {
            string sql = @"
                DELETE FROM dbo.LichDangKiPhong 
                WHERE DKPhongID = @LichDangKiPhongID AND GiaoVienID = @GiaoVienID";

            SqlParameter[] parameters = {
                new SqlParameter("@LichDangKiPhongID", lichDangKiPhongID),
                new SqlParameter("@GiaoVienID", giaoVienID)
            };

            int rowsAffected = db.ExecuteNonQuery_ReturnRowsAffected(sql, parameters);

            if (rowsAffected > 0)
                return "Hủy lịch đăng ký thành công!";
            if (rowsAffected == 0)
                return "Không tìm thấy lịch đăng ký hoặc bạn không có quyền hủy lịch này.";
            return "Đã xảy ra lỗi trong quá trình hủy.";
        }
    }
}
