using System;
using System.Data;
using System.Data.SqlClient;

namespace PJCNPM.DAL.Admin
{
    internal class ChuyenLopHocSinhDAL
    {
        private readonly DBConnection db = new DBConnection();

        public DataRow LayThongTinHocSinh(int hocSinhID)
        {
            string sql = "SELECT HocSinhID, HoTen FROM HocSinh WHERE HocSinhID = @ID";
            SqlParameter[] prms = { new SqlParameter("@ID", hocSinhID) };
            DataTable dt = db.GetData(sql, prms);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public DataRow LayLopHienTai(int hocSinhID)
        {
            string sql = @"
                SELECT TOP 1 l.LopID, l.TenLop, l.NamHoc, l.HocKi
                FROM HocSinh_Lop hl
                JOIN Lop l ON hl.LopID = l.LopID
                WHERE hl.HocSinhID = @HocSinhID AND l.DaKetThuc = 0";
            SqlParameter[] prms = { new SqlParameter("@HocSinhID", hocSinhID) };
            DataTable dt = db.GetData(sql, prms);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public DataTable LayDanhSachLopHoatDong()
        {
            string sql = "SELECT LopID, TenLop, NamHoc, HocKi FROM Lop WHERE DaKetThuc = 0";
            return db.GetData(sql);
        }

        public DataRow LayLopTheoID(int lopID)
        {
            string sql = "SELECT LopID, TenLop, NamHoc, HocKi FROM Lop WHERE LopID = @LopID";
            SqlParameter[] prms = { new SqlParameter("@LopID", lopID) };
            DataTable dt = db.GetData(sql, prms);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        /// <summary>
        /// Thực hiện chuyển lớp với rollback an toàn.
        /// </summary>
        public bool ChuyenLop(int hocSinhID, int lopCuID, int lopMoiID, bool xoaDiem)
        {
            string sql = @"
            DECLARE @Result BIT = 0;
            BEGIN TRY
                BEGIN TRANSACTION;

                -- ✅ Nếu cần xóa điểm lớp cũ
                IF (@xoaDiem = 1)
                BEGIN
                    DELETE FROM Diem WHERE HocSinhID = @HocSinhID AND LopID = @LopCuID;
                    DELETE FROM HocSinh_Lop WHERE HocSinhID = @HocSinhID AND LopID = @LopCuID;
                END

                -- ✅ Nếu học sinh chưa có lớp này thì thêm mới
                IF NOT EXISTS (SELECT 1 FROM HocSinh_Lop WHERE HocSinhID = @HocSinhID AND LopID = @LopMoiID)
                    INSERT INTO HocSinh_Lop (HocSinhID, LopID) VALUES (@HocSinhID, @LopMoiID);

                -- ✅ Thêm điểm trống cho các môn học của lớp mới (nếu chưa có)
                INSERT INTO Diem (HocSinhID, LopID, MonHocID)
                SELECT @HocSinhID, @LopMoiID, MonHocID
                FROM PhanCong
                WHERE LopID = @LopMoiID
                AND MonHocID NOT IN (
                    SELECT MonHocID FROM Diem WHERE HocSinhID = @HocSinhID AND LopID = @LopMoiID
                );

                COMMIT TRANSACTION;
                SET @Result = 1;
            END TRY
            BEGIN CATCH
                ROLLBACK TRANSACTION;
                PRINT ERROR_MESSAGE();
                SET @Result = 0;
            END CATCH

            SELECT @Result AS Success;
            ";

            SqlParameter[] prms =
            {
                new SqlParameter("@HocSinhID", hocSinhID),
                new SqlParameter("@LopCuID", lopCuID),
                new SqlParameter("@LopMoiID", lopMoiID),
                new SqlParameter("@xoaDiem", xoaDiem)
            };

            DataTable dt = db.GetData(sql, prms);
            return dt.Rows.Count > 0 && Convert.ToBoolean(dt.Rows[0]["Success"]);
        }
    }
}
