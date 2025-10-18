using System;
using System.Data;
using System.Data.SqlClient;

namespace PJCNPM.DAL.Admin
{
    internal class SaveLopDAL
    {
        private readonly DBConnection db = new DBConnection();

        public DataTable LayDanhSachLop(int? namHoc, int? hocKi, bool hienKetThuc, string keyword)
        {
            string sql = @"
                SELECT LopID, TenLop, NamHoc, HocKi, KhoiHoc,
                       CASE WHEN DaKetThuc = 1 THEN N'Đã kết thúc' ELSE N'Đang học' END AS TrangThai
                FROM Lop
                WHERE (@NamHoc IS NULL OR NamHoc = @NamHoc)
                  AND (@HocKi IS NULL OR HocKi = @HocKi)
                  AND (@HienKetThuc = 1 OR DaKetThuc = 0)
                  AND (@Keyword = '' OR TenLop LIKE N'%' + @Keyword + N'%')
                ORDER BY NamHoc DESC, KhoiHoc, TenLop";

            SqlParameter[] prms =
            {
                new SqlParameter("@NamHoc", (object)namHoc ?? DBNull.Value),
                new SqlParameter("@HocKi", (object)hocKi ?? DBNull.Value),
                new SqlParameter("@HienKetThuc", hienKetThuc),
                new SqlParameter("@Keyword", keyword ?? "")
            };

            return db.GetData(sql, prms);
        }

        public DataRow LayThongTinLop(int lopId)
        {
            string sql = "SELECT * FROM Lop WHERE LopID = @id";
            SqlParameter prm = new SqlParameter("@id", lopId);
            DataTable dt = db.GetData(sql, new SqlParameter[] { prm });
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public bool ThemLop(string tenLop, int namHoc, int hocKi, int khoiHoc, int? giaoVienId)
        {
            string sql = @"
                INSERT INTO Lop (TenLop, NamHoc, HocKi, KhoiHoc, DaKetThuc, GiaoVienID)
                VALUES (@TenLop, @NamHoc, @HocKi, @KhoiHoc, 0, @GiaoVienID)";

            SqlParameter[] prms =
            {
                new SqlParameter("@TenLop", tenLop),
                new SqlParameter("@NamHoc", namHoc),
                new SqlParameter("@HocKi", hocKi),
                new SqlParameter("@KhoiHoc", khoiHoc),
                new SqlParameter("@GiaoVienID", (object)giaoVienId ?? DBNull.Value)
            };

            return db.ExecuteNonQuery(sql, prms);
        }

        public bool CapNhatLop(int lopId, string tenLop, int namHoc, int hocKi, int khoiHoc, bool daKetThuc, int? giaoVienId)
        {
            string sql = @"
                UPDATE Lop
                SET TenLop = @TenLop,
                    NamHoc = @NamHoc,
                    HocKi = @HocKi,
                    KhoiHoc = @KhoiHoc,
                    DaKetThuc = @DaKetThuc,
                    GiaoVienID = @GiaoVienID
                WHERE LopID = @LopID";

            SqlParameter[] prms =
            {
                new SqlParameter("@TenLop", tenLop),
                new SqlParameter("@NamHoc", namHoc),
                new SqlParameter("@HocKi", hocKi),
                new SqlParameter("@KhoiHoc", khoiHoc),
                new SqlParameter("@DaKetThuc", daKetThuc),
                new SqlParameter("@GiaoVienID", (object)giaoVienId ?? DBNull.Value),
                new SqlParameter("@LopID", lopId)
            };

            return db.ExecuteNonQuery(sql, prms);
        }

        public bool XoaLop(int lopId)
        {
            string sql = "DELETE FROM Lop WHERE LopID = @id";
            SqlParameter prm = new SqlParameter("@id", lopId);
            return db.ExecuteNonQuery(sql, new SqlParameter[] { prm });
        }

        public DataTable LayDanhSachGiaoVienChuaChuNhiem()
        {
            string sql = @"
                SELECT GiaoVienID, HoTen
                FROM GiaoVien
                WHERE TrangThai != 0
                  AND GiaoVienID NOT IN (
                      SELECT GiaoVienID FROM Lop WHERE GiaoVienID IS NOT NULL
                  )
                ORDER BY HoTen";
            return db.GetData(sql);
        }

        public DataTable LayDanhSachGiaoVienToanBo()
        {
            string sql = @"
                SELECT GiaoVienID, HoTen
                FROM GiaoVien
                WHERE TrangThai != 0
                ORDER BY HoTen";
            return db.GetData(sql);
        }
    }
}
