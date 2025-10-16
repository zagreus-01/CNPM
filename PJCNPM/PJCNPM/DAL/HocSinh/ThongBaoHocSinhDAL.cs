using System;
using System.Data;
using System.Data.SqlClient;

namespace PJCNPM.DAL.HocSinh
{
    internal class ThongBaoHocSinhDAL
    {
        private readonly DBConnection db = new DBConnection();

        // 🔹 Lấy danh sách thông báo cho học sinh
        public DataTable LayDanhSachThongBao(int hocSinhID)
        {
            string sql = @"
                DECLARE @LopID NVARCHAR(10);

                -- ✅ Lấy lớp hiện tại của học sinh (chưa kết thúc)
                SELECT TOP 1 
                    @LopID = CAST(l.LopID AS NVARCHAR(10))
                FROM dbo.HocSinh_Lop AS hl
                INNER JOIN dbo.Lop AS l ON hl.LopID = l.LopID
                WHERE hl.HocSinhID = @HocSinhID 
                  AND l.DaKetThuc = 0;

                -- ✅ Lấy danh sách thông báo liên quan
                SELECT 
                    tb.ThongBaoID,
                    tb.TieuDe,
                    tb.NoiDung,
                    tb.NgayGui,
                    CASE 
                        WHEN tb.LoaiNguoiGui = 1 THEN N'Nhà trường'
                        WHEN tb.LoaiNguoiGui = 2 THEN gv.HoTen
                        ELSE N'Không xác định'
                    END AS NguoiGui
                FROM dbo.ThongBao AS tb
                INNER JOIN dbo.ThongBao_NguoiNhan AS tbn 
                    ON tb.ThongBaoID = tbn.ThongBaoID
                LEFT JOIN dbo.GiaoVien AS gv 
                    ON TRY_CAST(tb.NguoiGuiID AS INT) = gv.GiaoVienID
                WHERE
                    (tbn.LoaiNguoiNhan = -1 AND tbn.NguoiNhanID = 'ALL')
                    OR (tbn.LoaiNguoiNhan = 1 AND tbn.NguoiNhanID = @LopID)
                    OR (tbn.LoaiNguoiNhan = 2 AND tbn.NguoiNhanID = CAST(@HocSinhID AS NVARCHAR(10)))
                ORDER BY tb.NgayGui DESC;";

            SqlParameter[] prms = { new SqlParameter("@HocSinhID", hocSinhID) };
            return db.GetData(sql, prms);
        }
        
    }
}