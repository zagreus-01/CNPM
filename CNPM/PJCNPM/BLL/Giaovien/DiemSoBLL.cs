using System;
using System.Data;
using System.Data.SqlClient;
using PJCNPM.DAL;

namespace PJCNPM.BLL.GiaoVien
{
    public class DiemSoBLL
    {
        private readonly DBConnection db;

        public DiemSoBLL()
        {
            db = new DBConnection();
        }

        // 🔹 Lấy danh sách lớp mà giáo viên được phân công dạy
        public DataTable GetLopDayCuaGiaoVien(int giaoVienID)
        {
            string sql = @"
                SELECT DISTINCT 
                    l.LopID, 
                    l.TenLop + N' - Năm ' + CAST(l.NamHoc AS VARCHAR) AS TenLopHienThi
                FROM dbo.PhanCong pc
                JOIN dbo.Lop l ON pc.LopID = l.LopID
                WHERE pc.GiaoVienID = @GiaoVienID 
                  AND (l.DaKetThuc IS NULL OR l.DaKetThuc = 0)
                ORDER BY TenLopHienThi;";

            return db.GetData(sql, new SqlParameter[]
            {
                new SqlParameter("@GiaoVienID", giaoVienID)
            });
        }

        // 🔹 Lấy danh sách môn mà giáo viên dạy trong lớp cụ thể
        public DataTable GetMonHocDayCuaGiaoVienTrongLop(int giaoVienID, int lopID)
        {
            string sql = @"
                SELECT DISTINCT 
                    mh.MonHocID, 
                    mh.TenMon
                FROM dbo.PhanCong pc
                JOIN dbo.MonHoc mh ON pc.MonHocID = mh.MonHocID
                WHERE pc.GiaoVienID = @GiaoVienID 
                  AND pc.LopID = @LopID;";

            return db.GetData(sql, new SqlParameter[]
            {
                new SqlParameter("@GiaoVienID", giaoVienID),
                new SqlParameter("@LopID", lopID)
            });
        }

        // 🔹 Lấy danh sách học sinh và điểm số của một lớp cho một môn học cụ thể
        public DataTable GetDanhSachDiemCuaLop(int lopID, int monHocID)
        {
            string sql = @"
                SELECT 
                    hs.HocSinhID,
                    hs.HoTen,
                    d.TX1,
                    d.TX2,
                    d.TX3,
                    d.TX4,
                    d.GiuaKy,
                    d.CuoiKy
                FROM dbo.HocSinh hs
                JOIN dbo.HocSinh_Lop hsl ON hs.HocSinhID = hsl.HocSinhID
                LEFT JOIN dbo.Diem d 
                    ON hs.HocSinhID = d.HocSinhID 
                    AND d.LopID = hsl.LopID 
                    AND d.MonHocID = @MonHocID
                WHERE hsl.LopID = @LopID
                ORDER BY hs.HoTen;";

            return db.GetData(sql, new SqlParameter[]
            {
                new SqlParameter("@LopID", lopID),
                new SqlParameter("@MonHocID", monHocID)
            });
        }

        // 🔹 Lưu bảng điểm (sử dụng transaction đảm bảo toàn vẹn dữ liệu)
        public bool LuuBangDiem(DataTable dtDiem, int lopID, int monHocID)
        {
            using (SqlConnection conn = db.GetSqlConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    foreach (DataRow row in dtDiem.Rows)
                    {
                        int hocSinhID = Convert.ToInt32(row["HocSinhID"]);

                        // Kiểm tra xem bản ghi đã tồn tại chưa
                        string sqlCheckExist = @"
                            SELECT COUNT(1) 
                            FROM dbo.Diem 
                            WHERE HocSinhID = @HocSinhID 
                              AND LopID = @LopID 
                              AND MonHocID = @MonHocID";

                        using (SqlCommand cmdCheck = new SqlCommand(sqlCheckExist, conn, transaction))
                        {
                            cmdCheck.Parameters.AddWithValue("@HocSinhID", hocSinhID);
                            cmdCheck.Parameters.AddWithValue("@LopID", lopID);
                            cmdCheck.Parameters.AddWithValue("@MonHocID", monHocID);

                            bool recordExists = Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0;

                            string sqlUpsert = recordExists
                                ? @"UPDATE dbo.Diem 
                                    SET TX1 = @TX1, TX2 = @TX2, TX3 = @TX3, TX4 = @TX4, 
                                        GiuaKy = @GiuaKy, CuoiKy = @CuoiKy
                                    WHERE HocSinhID = @HocSinhID 
                                      AND LopID = @LopID 
                                      AND MonHocID = @MonHocID;"
                                : @"INSERT INTO dbo.Diem 
                                    (HocSinhID, LopID, MonHocID, TX1, TX2, TX3, TX4, GiuaKy, CuoiKy)
                                    VALUES 
                                    (@HocSinhID, @LopID, @MonHocID, @TX1, @TX2, @TX3, @TX4, @GiuaKy, @CuoiKy);";

                            using (SqlCommand cmdUpsert = new SqlCommand(sqlUpsert, conn, transaction))
                            {
                                cmdUpsert.Parameters.AddWithValue("@HocSinhID", hocSinhID);
                                cmdUpsert.Parameters.AddWithValue("@LopID", lopID);
                                cmdUpsert.Parameters.AddWithValue("@MonHocID", monHocID);

                                cmdUpsert.Parameters.AddWithValue("@TX1", row["TX1"] == DBNull.Value ? (object)DBNull.Value : Convert.ToDecimal(row["TX1"]));
                                cmdUpsert.Parameters.AddWithValue("@TX2", row["TX2"] == DBNull.Value ? (object)DBNull.Value : Convert.ToDecimal(row["TX2"]));
                                cmdUpsert.Parameters.AddWithValue("@TX3", row["TX3"] == DBNull.Value ? (object)DBNull.Value : Convert.ToDecimal(row["TX3"]));
                                cmdUpsert.Parameters.AddWithValue("@TX4", row["TX4"] == DBNull.Value ? (object)DBNull.Value : Convert.ToDecimal(row["TX4"]));
                                cmdUpsert.Parameters.AddWithValue("@GiuaKy", row["GiuaKy"] == DBNull.Value ? (object)DBNull.Value : Convert.ToDecimal(row["GiuaKy"]));
                                cmdUpsert.Parameters.AddWithValue("@CuoiKy", row["CuoiKy"] == DBNull.Value ? (object)DBNull.Value : Convert.ToDecimal(row["CuoiKy"]));

                                cmdUpsert.ExecuteNonQuery();
                            }
                        }
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("❌ Lỗi khi lưu bảng điểm: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
