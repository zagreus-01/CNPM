using PJCNPM.DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PJCNPM.BLL.Admin
{
    internal class DiemSoAdminBLL
    {
        private readonly DBConnection db;

        public DiemSoAdminBLL()
        {
            db = new DBConnection();
        }

        /// <summary>
        /// 🔹 Lấy danh sách tất cả lớp học chưa kết thúc.
        /// </summary>
        public DataTable GetAllLop()
        {
            string sql = @"
                SELECT 
                    LopID, 
                    TenLop + N' - Năm ' + CAST(NamHoc AS NVARCHAR(10)) AS TenLopHienThi
                FROM dbo.Lop
                WHERE ISNULL(DaKetThuc, 0) = 0
                ORDER BY NamHoc DESC, TenLop;";
            return db.GetData(sql);
        }

        /// <summary>
        /// 🔹 Lấy danh sách tất cả môn học.
        /// </summary>
        public DataTable GetAllMonHoc()
        {
            string sql = "SELECT MonHocID, TenMon FROM dbo.MonHoc ORDER BY TenMon;";
            return db.GetData(sql);
        }

        /// <summary>
        /// 🔹 Lấy danh sách học sinh và điểm số theo lớp và môn học.
        /// </summary>
        public DataTable GetDanhSachDiemCuaLop(int lopID, int monHocID)
        {
            string sql = @"
                SELECT 
                    hs.HocSinhID,
                    hs.HoTen,
                    d.TX1, d.TX2, d.TX3, d.TX4, d.GiuaKy, d.CuoiKy
                FROM dbo.HocSinh hs
                INNER JOIN dbo.HocSinh_Lop hsl ON hs.HocSinhID = hsl.HocSinhID
                LEFT JOIN dbo.Diem d 
                    ON hs.HocSinhID = d.HocSinhID 
                    AND d.LopID = hsl.LopID 
                    AND d.MonHocID = @MonHocID
                WHERE hsl.LopID = @LopID
                ORDER BY hs.HoTen;";

            SqlParameter[] prms =
            {
                new SqlParameter("@LopID", lopID),
                new SqlParameter("@MonHocID", monHocID)
            };

            return db.GetData(sql, prms);
        }

        /// <summary>
        /// 🔹 Lưu bảng điểm (UPDATE hoặc INSERT nếu chưa tồn tại).
        /// </summary>
        public bool LuuBangDiem(DataTable dtDiem, int lopID, int monHocID)
        {
            try
            {
                foreach (DataRow row in dtDiem.Rows)
                {
                    int hocSinhID = Convert.ToInt32(row["HocSinhID"]);

                    // 🔹 Kiểm tra xem đã có điểm chưa
                    string sqlCheck = @"
                        SELECT COUNT(*) 
                        FROM dbo.Diem 
                        WHERE HocSinhID = @HocSinhID AND LopID = @LopID AND MonHocID = @MonHocID;";

                    int count = Convert.ToInt32(db.ExecuteScalar(sqlCheck,
                        new SqlParameter("@HocSinhID", hocSinhID),
                        new SqlParameter("@LopID", lopID),
                        new SqlParameter("@MonHocID", monHocID)
                    ));

                    // 🔹 Nếu đã có → UPDATE, nếu chưa → INSERT
                    string sql;
                    if (count > 0)
                    {
                        sql = @"
                            UPDATE dbo.Diem SET
                                TX1 = @TX1, TX2 = @TX2, TX3 = @TX3, TX4 = @TX4,
                                GiuaKy = @GiuaKy, CuoiKy = @CuoiKy
                            WHERE HocSinhID = @HocSinhID AND LopID = @LopID AND MonHocID = @MonHocID;";
                    }
                    else
                    {
                        sql = @"
                            INSERT INTO dbo.Diem
                                (HocSinhID, LopID, MonHocID, TX1, TX2, TX3, TX4, GiuaKy, CuoiKy)
                            VALUES
                                (@HocSinhID, @LopID, @MonHocID, @TX1, @TX2, @TX3, @TX4, @GiuaKy, @CuoiKy);";
                    }

                    SqlParameter[] prms =
                    {
                        new SqlParameter("@HocSinhID", hocSinhID),
                        new SqlParameter("@LopID", lopID),
                        new SqlParameter("@MonHocID", monHocID),
                        new SqlParameter("@TX1", row["TX1"] ?? (object)DBNull.Value),
                        new SqlParameter("@TX2", row["TX2"] ?? (object)DBNull.Value),
                        new SqlParameter("@TX3", row["TX3"] ?? (object)DBNull.Value),
                        new SqlParameter("@TX4", row["TX4"] ?? (object)DBNull.Value),
                        new SqlParameter("@GiuaKy", row["GiuaKy"] ?? (object)DBNull.Value),
                        new SqlParameter("@CuoiKy", row["CuoiKy"] ?? (object)DBNull.Value)
                    };

                    db.ExecuteNonQuery(sql, prms);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi lưu bảng điểm: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
