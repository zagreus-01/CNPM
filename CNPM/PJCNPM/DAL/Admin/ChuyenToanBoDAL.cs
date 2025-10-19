using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PJCNPM.DAL.Admin
{
    internal class ChuyenToanBoLopDAL
    {
        private readonly DBConnection db = new DBConnection();

        // 🔹 Lấy danh sách lớp đang hoạt động (chưa kết thúc)
        public DataTable LayDanhSachLopHoatDong()
        {
            string sql = "SELECT LopID, TenLop, NamHoc, HocKi FROM Lop WHERE DaKetThuc = 0 ORDER BY NamHoc DESC, HocKi";
            return db.GetData(sql);
        }

        // 🔹 Lấy danh sách tất cả lớp (dùng để chọn lớp cũ)
        public DataTable LayTatCaLop()
        {
            string sql = "SELECT LopID, TenLop, NamHoc, HocKi, DaKetThuc FROM Lop ORDER BY NamHoc DESC, HocKi";
            return db.GetData(sql);
        }

        // 🔹 Thực hiện chuyển toàn bộ học sinh sang lớp khác
        public bool ChuyenToanBoHocSinh(int lopCuID, int lopMoiID, bool xoaDiem)
        {
            string sql = @"
            BEGIN TRY
                BEGIN TRANSACTION;

                -- Kiểm tra lớp mới có đang hoạt động không
                IF EXISTS (SELECT 1 FROM Lop WHERE LopID = @LopMoiID AND DaKetThuc = 1)
                BEGIN
                    RAISERROR(N'Lớp mới đã kết thúc, không thể chuyển học sinh!', 16, 1);
                    ROLLBACK TRANSACTION;
                    RETURN;
                END;

                -- Xóa điểm lớp cũ nếu chọn
                IF (@XoaDiem = 1)
                BEGIN
                    DELETE FROM Diem WHERE LopID = @LopCuID;
                END;

                -- Thêm học sinh vào lớp mới nếu chưa có
                INSERT INTO HocSinh_Lop (HocSinhID, LopID)
                SELECT HocSinhID, @LopMoiID
                FROM HocSinh_Lop
                WHERE LopID = @LopCuID
                  AND HocSinhID NOT IN (SELECT HocSinhID FROM HocSinh_Lop WHERE LopID = @LopMoiID);

                -- Thêm điểm trống theo phân công lớp mới
                INSERT INTO Diem (HocSinhID, LopID, MonHocID)
                SELECT hs.HocSinhID, @LopMoiID, pc.MonHocID
                FROM HocSinh_Lop hs
                JOIN PhanCong pc ON pc.LopID = @LopMoiID
                WHERE hs.LopID = @LopMoiID
                  AND NOT EXISTS (
                      SELECT 1 FROM Diem d 
                      WHERE d.HocSinhID = hs.HocSinhID 
                        AND d.LopID = @LopMoiID 
                        AND d.MonHocID = pc.MonHocID
                  );

                COMMIT TRANSACTION;
            END TRY
            BEGIN CATCH
                ROLLBACK TRANSACTION;
                THROW;
            END CATCH";

            try
            {
                SqlParameter[] prms =
                {
                    new SqlParameter("@LopCuID", lopCuID),
                    new SqlParameter("@LopMoiID", lopMoiID),
                    new SqlParameter("@XoaDiem", xoaDiem)
                };

                return db.ExecuteNonQuery(sql, prms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi chuyển lớp: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
