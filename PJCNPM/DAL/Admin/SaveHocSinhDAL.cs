using System;
using System.Data;
using System.Data.SqlClient;

namespace PJCNPM.DAL.Admin
{
    internal class SaveHocSinhDAL
    {
        private readonly DBConnection db = new DBConnection();

        // 🔹 Lấy thông tin 1 học sinh theo ID
        public DataTable LayHocSinhTheoID(int id)
        {
            string sql = "SELECT * FROM HocSinh WHERE HocSinhID = @ID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID", id)
            };
            return db.GetData(sql, parameters);
        }

        // 🔹 Lấy danh sách lớp đang hoạt động
        public DataTable LayDanhSachLop()
        {
            string sql = "SELECT LopID, TenLop FROM Lop WHERE DaKetThuc = 0 ORDER BY TenLop";
            return db.GetData(sql);
        }

        // 🔹 Thêm học sinh mới
        public bool ThemHocSinh(string hoTen, DateTime ngaySinh, bool gioiTinh,
            string danToc, string tonGiao, string queQuan, int namNhapHoc, byte trangThai, int lopId)
        {
            string sql = @"
                BEGIN TRY
                    BEGIN TRANSACTION;

                    INSERT INTO HocSinh (HoTen, NgaySinh, GioiTinh, DanToc, TonGiao, QueQuan, NamNhapHoc, TrangThai)
                    VALUES (@HoTen, @NgaySinh, @GioiTinh, @DanToc, @TonGiao, @QueQuan, @NamNhapHoc, @TrangThai);

                    DECLARE @NewID INT = SCOPE_IDENTITY();

                    DECLARE @TenTK NVARCHAR(50) = CONCAT('HS', @NewID);
                    DECLARE @MatKhau NVARCHAR(100) = CONCAT('HS', @NewID);

                    INSERT INTO TaiKhoan (TenTK, MatKhau, TrangThai, RoleID)
                    VALUES (@TenTK, @MatKhau, 1, 3);

                    UPDATE HocSinh SET TenTK = @TenTK WHERE HocSinhID = @NewID;

                    INSERT INTO HocSinh_Lop (HocSinhID, LopID)
                    VALUES (@NewID, @LopID);

                    INSERT INTO Diem (HocSinhID, LopID, MonHocID)
                    SELECT @NewID, p.LopID, p.MonHocID
                    FROM PhanCong p
                    WHERE p.LopID = @LopID;

                    COMMIT TRANSACTION;
                    SELECT 1 AS Result;
                END TRY
                BEGIN CATCH
                    ROLLBACK TRANSACTION;
                    SELECT 0 AS Result;
                END CATCH
                ";


            SqlParameter[] parameters =
            {
        new SqlParameter("@HoTen", hoTen),
        new SqlParameter("@NgaySinh", ngaySinh),
        new SqlParameter("@GioiTinh", gioiTinh),
        new SqlParameter("@DanToc", danToc),
        new SqlParameter("@TonGiao", tonGiao),
        new SqlParameter("@QueQuan", queQuan),
        new SqlParameter("@NamNhapHoc", namNhapHoc),
        new SqlParameter("@TrangThai", trangThai),
        new SqlParameter("@LopID", lopId)
    };

            return db.ExecuteNonQuery(sql, parameters);
        }


        // 🔹 Cập nhật thông tin học sinh
        public bool CapNhatHocSinh(int id, string hoTen, DateTime ngaySinh, bool gioiTinh,
            string danToc, string tonGiao, string queQuan, int namNhapHoc, byte trangThai)
        {
            string sql = @"
                UPDATE HocSinh 
                SET HoTen = @HoTen, 
                    NgaySinh = @NgaySinh, 
                    GioiTinh = @GioiTinh, 
                    DanToc = @DanToc, 
                    TonGiao = @TonGiao, 
                    QueQuan = @QueQuan, 
                    NamNhapHoc = @NamNhapHoc, 
                    TrangThai = @TrangThai
                WHERE HocSinhID = @HocSinhID;
            ";

            SqlParameter[] parameters =
            {
                new SqlParameter("@HocSinhID", id),
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@GioiTinh", gioiTinh),
                new SqlParameter("@DanToc", danToc),
                new SqlParameter("@TonGiao", tonGiao),
                new SqlParameter("@QueQuan", queQuan),
                new SqlParameter("@NamNhapHoc", namNhapHoc),
                new SqlParameter("@TrangThai", trangThai)
            };

            return db.ExecuteNonQuery(sql, parameters);
        }
    }
}
