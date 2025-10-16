using System.Data;
using System.Data.SqlClient;

namespace PJCNPM.DAL.Admin
{
    internal class DocXoaHocSinhDAL
    {
        private readonly DBConnection db = new DBConnection();

        // 🔹 Lấy toàn bộ học sinh (luôn hiển thị tất cả — không lọc theo trạng thái học sinh)
        public DataTable LayTatCaHocSinh(bool baoGomLopKetThuc = false)
        {
            string sql = @"
                SELECT 
                    hs.HocSinhID, 
                    hs.HoTen,
                    ISNULL(l.TenLop, N'(Chưa có lớp)') AS TenLop,
                    ISNULL(l.NamHoc, 0) AS NamHoc,
                    CASE 
                        WHEN hs.TrangThai = 0 THEN N'Nghỉ học'
                        WHEN hs.TrangThai = 1 THEN 
                            CASE WHEN l.DaKetThuc = 1 THEN N'Đã kết thúc lớp' ELSE N'Đang học' END
                        WHEN hs.TrangThai = 2 THEN N'Tạm dừng'
                        ELSE N'Không xác định'
                    END AS TrangThai
                FROM HocSinh hs
                OUTER APPLY (
                    SELECT TOP 1 l.TenLop, l.NamHoc, l.DaKetThuc
                    FROM HocSinh_Lop hl
                    JOIN Lop l ON hl.LopID = l.LopID
                    WHERE hl.HocSinhID = hs.HocSinhID
                    ORDER BY 
                        CASE WHEN l.DaKetThuc = 0 THEN 0 ELSE 1 END,  
                        l.NamHoc DESC
                ) AS l";
            if (!baoGomLopKetThuc)
                sql += " WHERE (l.DaKetThuc = 0 OR l.DaKetThuc IS NULL)";

            return db.GetData(sql);
        }


        // 🔹 Lấy danh sách lớp (ẩn hoặc hiện lớp đã kết thúc)
        public DataTable LayDanhSachLop(bool baoGomDaKetThuc = false)
        {
            string sql = @"
                SELECT LopID, TenLop, NamHoc, HocKi, 
                       CASE WHEN DaKetThuc = 1 THEN N'Đã kết thúc' ELSE N'Đang học' END AS TrangThai
                FROM Lop";

            if (!baoGomDaKetThuc)
                sql += " WHERE DaKetThuc = 0";

            sql += " ORDER BY TenLop";
            return db.GetData(sql);
        }

        // 🔹 Xóa học sinh hoàn toàn (có transaction bảo vệ)
        public bool XoaHocSinh(int hocSinhID)
        {
            string sql = @"
            BEGIN TRY
                BEGIN TRANSACTION;

                -- 1️⃣ Xóa yêu cầu chỉnh sửa (nếu có)
                DELETE FROM ChinhSuaHocSinh WHERE HocSinhID = @HocSinhID;

                -- 2️⃣ Xóa điểm 
                DELETE FROM Diem WHERE HocSinhID = @HocSinhID;

                -- 3️⃣ Xóa bản ghi lớp của học sinh
                DELETE FROM HocSinh_Lop WHERE HocSinhID = @HocSinhID;

                -- 4️⃣ Lấy tài khoản học sinh (nếu có)
                DECLARE @TenTK NVARCHAR(50);
                SELECT @TenTK = TenTK FROM HocSinh WHERE HocSinhID = @HocSinhID;

                -- 5️⃣ Xóa học sinh
                DELETE FROM HocSinh WHERE HocSinhID = @HocSinhID;

                -- 6️⃣ Xóa tài khoản tương ứng (nếu tồn tại)
                IF (@TenTK IS NOT NULL)
                    DELETE FROM TaiKhoan WHERE TenTK = @TenTK;

                COMMIT TRANSACTION;
                SELECT 1 AS Result;
            END TRY
            BEGIN CATCH
                ROLLBACK TRANSACTION;
                SELECT 0 AS Result;
            END CATCH";

            SqlParameter[] parameters =
            {
                new SqlParameter("@HocSinhID", hocSinhID)
            };

            return db.ExecuteNonQuery(sql, parameters);
        }
    }
}
