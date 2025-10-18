using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PJCNPM.DAL;

namespace PJCNPM.BLL.GiaoVien
{
    public class ThongBaoBLL
    {
        private readonly DBConnection db;

        public ThongBaoBLL()
        {
            db = new DBConnection();
        }

        // DTO hiển thị lớp mà giáo viên dạy
        public class LopDayInfo
        {
            public int LopID { get; set; }
            public string TenLopHienThi { get; set; }
        }

        // 🔹 Lấy thông báo nhận từ Admin
        public DataTable GetThongBaoNhanTuAdmin(int giaoVienID)
        {
            string sql = @"
                SELECT 
                    tb.ThongBaoID, 
                    tb.TieuDe, 
                    tb.NoiDung, 
                    tb.NgayGui,
                    N'Quản trị viên' AS TenNguoiGui
                FROM dbo.ThongBao tb
                INNER JOIN dbo.ThongBao_NguoiNhan nn ON tb.ThongBaoID = nn.ThongBaoID
                WHERE nn.LoaiNguoiNhan = 3  -- 3 = GIAOVIEN
                  AND nn.NguoiNhanID = @GiaoVienID
                  AND tb.LoaiNguoiGui = 1  -- 1 = ADMIN
                ORDER BY tb.NgayGui DESC;";

            return db.GetData(sql, new SqlParameter[]
            {
                new SqlParameter("@GiaoVienID", giaoVienID.ToString())
            });
        }

        // 🔹 Lấy danh sách thông báo đã gửi bởi giáo viên
        public DataTable GetThongBaoDaGui(string tenTK)
        {
            string sql = @"
                SELECT 
                    tb.ThongBaoID, 
                    tb.TieuDe, 
                    tb.NoiDung, 
                    tb.NgayGui,
                    STRING_AGG(l.TenLop, ', ') AS DanhSachLopNhan
                FROM dbo.ThongBao tb
                INNER JOIN dbo.ThongBao_NguoiNhan nn ON tb.ThongBaoID = nn.ThongBaoID
                INNER JOIN dbo.Lop l ON CAST(l.LopID AS NVARCHAR) = nn.NguoiNhanID
                WHERE tb.NguoiGuiID = @TenTK
                  AND nn.LoaiNguoiNhan = 1   -- ✅ 1 = LỚP (theo mapping mới)
                GROUP BY tb.ThongBaoID, tb.TieuDe, tb.NoiDung, tb.NgayGui
                ORDER BY tb.NgayGui DESC;";

            return db.GetData(sql, new SqlParameter[]
            {
                new SqlParameter("@TenTK", tenTK)
            });
        }

        // 🔹 Lấy danh sách lớp mà giáo viên đang dạy
        public List<LopDayInfo> GetCacLopGiaoVienDay(int giaoVienID)
        {
            var listLop = new List<LopDayInfo>();

            string sql = @"
                SELECT DISTINCT LopID, TenLopHienThi FROM (
                    SELECT 
                        l.LopID, 
                        l.TenLop + N' (Bộ môn - Năm ' + CAST(l.NamHoc AS NVARCHAR) + N')' AS TenLopHienThi
                    FROM dbo.Lop l
                    INNER JOIN dbo.PhanCong pc ON l.LopID = pc.LopID
                    WHERE pc.GiaoVienID = @GiaoVienID 
                        AND ISNULL(l.DaKetThuc, 0) = 0
                    UNION
                    SELECT 
                        l.LopID, 
                        l.TenLop + N' (Chủ nhiệm - Năm ' + CAST(l.NamHoc AS NVARCHAR) + N')' AS TenLopHienThi
                    FROM dbo.Lop l
                    WHERE l.GiaoVienID = @GiaoVienID 
                        AND ISNULL(l.DaKetThuc, 0) = 0
                ) AS LopDay
                ORDER BY TenLopHienThi;";

            DataTable dt = db.GetData(sql, new SqlParameter[]
            {
                new SqlParameter("@GiaoVienID", giaoVienID)
            });

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    listLop.Add(new LopDayInfo
                    {
                        LopID = Convert.ToInt32(row["LopID"]),
                        TenLopHienThi = row["TenLopHienThi"].ToString()
                    });
                }
            }

            return listLop;
        }

        // 🔹 Gửi thông báo đến nhiều lớp
        public bool GuiThongBao(string tieuDe, string noiDung, string tenTkGui, List<int> dsLopID)
        {
            DBConnection dbConn = new DBConnection();
            using (SqlConnection conn = dbConn.GetSqlConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 🟢 Thêm bản ghi Thông báo
                    string sqlInsertThongBao = @"
                        INSERT INTO dbo.ThongBao (NguoiGuiID, LoaiNguoiGui, TieuDe, NoiDung, NgayGui)
                        OUTPUT INSERTED.ThongBaoID
                        VALUES (@NguoiGuiID, 3, @TieuDe, @NoiDung, GETDATE());";

                    int thongBaoID;
                    using (SqlCommand cmd1 = new SqlCommand(sqlInsertThongBao, conn, transaction))
                    {
                        cmd1.Parameters.AddWithValue("@NguoiGuiID", tenTkGui);
                        cmd1.Parameters.AddWithValue("@TieuDe", tieuDe);
                        cmd1.Parameters.AddWithValue("@NoiDung", noiDung);
                        thongBaoID = Convert.ToInt32(cmd1.ExecuteScalar());
                    }

                    // 🟢 Gắn người nhận (Lớp)
                    string sqlInsertNguoiNhan = @"
                        INSERT INTO dbo.ThongBao_NguoiNhan 
                            (LoaiNguoiNhan, NguoiNhanID, ThongBaoID)
                        VALUES (1, @NguoiNhanID, @ThongBaoID);";   // ✅ 1 = LỚP theo mapping mới

                    foreach (int lopID in dsLopID)
                    {
                        using (SqlCommand cmd2 = new SqlCommand(sqlInsertNguoiNhan, conn, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@NguoiNhanID", lopID.ToString());
                            cmd2.Parameters.AddWithValue("@ThongBaoID", thongBaoID);
                            cmd2.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("❌ Lỗi gửi thông báo: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
