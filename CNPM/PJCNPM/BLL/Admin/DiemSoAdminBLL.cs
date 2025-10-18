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
        /// 🔹 Lấy danh sách lớp học (cho phép chọn hiển thị cả lớp đã kết thúc)
        /// </summary>
        public DataTable GetAllLop(bool hienLopKetThuc)
        {
            string sql = @"
                SELECT 
                    LopID, 
                    TenLop + N' - Năm ' + CAST(NamHoc AS NVARCHAR(10)) 
                        + N' - Học kỳ ' + CAST(HocKi AS NVARCHAR(5)) AS TenLopHienThi,
                    DaKetThuc
                FROM dbo.Lop
                WHERE (@HienKetThuc = 1 OR ISNULL(DaKetThuc, 0) = 0)
                ORDER BY NamHoc DESC, KhoiHoc, TenLop;";

            SqlParameter prm = new SqlParameter("@HienKetThuc", hienLopKetThuc);
            return db.GetData(sql, new SqlParameter[] { prm });
        }

        /// <summary>
        /// 🔹 Lấy danh sách môn học được phân công cho lớp
        /// </summary>
        public DataTable GetMonHocTheoLop(int lopID)
        {
            string sql = @"
                SELECT DISTINCT mh.MonHocID, mh.TenMon
                FROM dbo.PhanCong pc
                INNER JOIN dbo.MonHoc mh ON pc.MonHocID = mh.MonHocID
                WHERE pc.LopID = @LopID
                ORDER BY mh.TenMon;";

            SqlParameter prm = new SqlParameter("@LopID", lopID);
            return db.GetData(sql, new SqlParameter[] { prm });
        }

        /// <summary>
        /// 🔹 Lấy danh sách điểm học sinh trong lớp cho 1 môn học
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
        /// 🔹 Lưu bảng điểm (INSERT hoặc UPDATE nếu đã có)
        /// </summary>
        public bool LuuBangDiem(DataTable dt, int lopID, int monHocID)
        {
            try
            {
                using (SqlConnection conn = db.GetSqlConnection())
                {
                    conn.Open();

                    foreach (DataRow row in dt.Rows)
                    {
                        int hocSinhID = Convert.ToInt32(row["HocSinhID"]);

                        // 🔍 Kiểm tra tồn tại điểm
                        string sqlCheck = @"
                            SELECT COUNT(*) 
                            FROM dbo.Diem 
                            WHERE HocSinhID = @HocSinhID AND LopID = @LopID AND MonHocID = @MonHocID;";

                        int exists = Convert.ToInt32(new SqlCommand(sqlCheck, conn)
                        {
                            Parameters =
                            {
                                new SqlParameter("@HocSinhID", hocSinhID),
                                new SqlParameter("@LopID", lopID),
                                new SqlParameter("@MonHocID", monHocID)
                            }
                        }.ExecuteScalar());

                        // 🔄 INSERT hoặc UPDATE
                        string sql;
                        if (exists > 0)
                        {
                            sql = @"
                                UPDATE dbo.Diem
                                SET TX1=@TX1, TX2=@TX2, TX3=@TX3, TX4=@TX4,
                                    GiuaKy=@GiuaKy, CuoiKy=@CuoiKy
                                WHERE HocSinhID=@HocSinhID AND LopID=@LopID AND MonHocID=@MonHocID;";
                        }
                        else
                        {
                            sql = @"
                                INSERT INTO dbo.Diem(HocSinhID, LopID, MonHocID, TX1, TX2, TX3, TX4, GiuaKy, CuoiKy)
                                VALUES(@HocSinhID, @LopID, @MonHocID, @TX1, @TX2, @TX3, @TX4, @GiuaKy, @CuoiKy);";
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

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddRange(prms);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi lưu bảng điểm: " + ex.Message,
                    "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
