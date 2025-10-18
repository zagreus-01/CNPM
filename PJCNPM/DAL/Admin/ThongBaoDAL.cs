using System;
using System.Data;
using System.Data.SqlClient;

namespace PJCNPM.DAL.Admin
{
    internal class ThongBaoDAL
    {
        private readonly DBConnection db = new DBConnection();

        // 🔹 Lấy tất cả thông báo (mới nhất -> cũ nhất)
        public DataTable LayTatCaThongBao()
        {
            string sql = @"
                SELECT tb.ThongBaoID, 
                       tb.TieuDe, 
                       tb.NoiDung, 
                       tb.NgayGui, 
                       tb.NguoiGuiID, 
                       tb.LoaiNguoiGui,
                       STRING_AGG(tbn.NguoiNhanID, ', ') AS NguoiNhan
                FROM ThongBao tb
                LEFT JOIN ThongBao_NguoiNhan tbn ON tb.ThongBaoID = tbn.ThongBaoID
                GROUP BY tb.ThongBaoID, tb.TieuDe, tb.NoiDung, tb.NgayGui, tb.NguoiGuiID, tb.LoaiNguoiGui
                ORDER BY tb.NgayGui DESC";
            return db.GetData(sql);
        }

        // 🔹 Gửi thông báo mới
        public bool GuiThongBao(
            string nguoiGuiID,
            int loaiNguoiGui,
            string tieuDe,
            string noiDung,
            int loaiNguoiNhan,
            string nguoiNhanID)
        {
            string sql = @"
                BEGIN TRY
                    BEGIN TRANSACTION;

                    INSERT INTO ThongBao (NguoiGuiID, LoaiNguoiGui, TieuDe, NoiDung)
                    VALUES (@NguoiGuiID, @LoaiNguoiGui, @TieuDe, @NoiDung);

                    DECLARE @ThongBaoID INT = SCOPE_IDENTITY();

                    INSERT INTO ThongBao_NguoiNhan (LoaiNguoiNhan, NguoiNhanID, ThongBaoID)
                    VALUES (@LoaiNguoiNhan, @NguoiNhanID, @ThongBaoID);

                    COMMIT TRANSACTION;
                    SELECT 1 AS Result;
                END TRY
                BEGIN CATCH
                    ROLLBACK TRANSACTION;
                    SELECT 0 AS Result;
                END CATCH";

            SqlParameter[] prms = new SqlParameter[]
            {
                new SqlParameter("@NguoiGuiID", nguoiGuiID),
                new SqlParameter("@LoaiNguoiGui", loaiNguoiGui),
                new SqlParameter("@TieuDe", tieuDe),
                new SqlParameter("@NoiDung", noiDung),
                new SqlParameter("@LoaiNguoiNhan", loaiNguoiNhan),
                new SqlParameter("@NguoiNhanID", nguoiNhanID)
            };

            return db.ExecuteNonQuery(sql, prms);
        }
    }
}
