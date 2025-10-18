using System;
using System.Data;
using System.Data.SqlClient;
using PJCNPM.DAL;

namespace PJCNPM.DAL.Admin
{
    internal class ChiTietChinhSuaDAL
    {
        private readonly DBConnection db = new DBConnection();

        public DataTable LayChiTietYeuCau(string loai, int id)
        {
            string sql;
            if (loai == "Học sinh")
            {
                sql = @"
                    SELECT TOP 1
                        hs.HoTen AS HoTenCu, cs.HoTen AS HoTenMoi,
                        hs.NgaySinh AS NgaySinhCu, cs.NgaySinh AS NgaySinhMoi,
                        hs.GioiTinh AS GioiTinhCu, cs.GioiTinh AS GioiTinhMoi,
                        hs.DanToc AS DanTocCu, cs.DanToc AS DanTocMoi,
                        hs.TonGiao AS TonGiaoCu, cs.TonGiao AS TonGiaoMoi,
                        hs.QueQuan AS QueQuanCu, cs.QueQuan AS QueQuanMoi
                    FROM dbo.HocSinh hs
                    INNER JOIN dbo.ChinhSuaHocSinh cs ON hs.HocSinhID = cs.HocSinhID
                    WHERE cs.HocSinhID = @ID;";
            }
            else
            {
                sql = @"
                    SELECT TOP 1
                        gv.HoTen AS HoTenCu, cs.HoTen AS HoTenMoi,
                        gv.NgaySinh AS NgaySinhCu, cs.NgaySinh AS NgaySinhMoi,
                        gv.GioiTinh AS GioiTinhCu, cs.GioiTinh AS GioiTinhMoi,
                        gv.CCCD AS CCCDCu, cs.CCCD AS CCCDMoi,
                        gv.Email AS EmailCu, cs.Email AS EmailMoi,
                        gv.DienThoai AS DienThoaiCu, cs.DienThoai AS DienThoaiMoi,
                        gv.QueQuan AS QueQuanCu, cs.QueQuan AS QueQuanMoi
                    FROM dbo.GiaoVien gv
                    INNER JOIN dbo.ChinhSuaGiaoVien cs ON gv.GiaoVienID = cs.GiaoVienID
                    WHERE cs.GiaoVienID = @ID;";
            }

            return db.GetData(sql, new SqlParameter[] { new SqlParameter("@ID", id) });
        }
    }
}
