using System;
using System.Data;
using System.Data.SqlClient;

namespace PJCNPM.DAL.Admin
{
    internal class LopHocDAL
    {
        private readonly DBConnection db = new DBConnection();

        // 📘 Lấy danh sách lớp theo điều kiện
        public DataTable LayDanhSachLop(int? namHoc, int? hocKi, bool hienKetThuc, string keyword)
        {
            string sql = @"
                SELECT LopID, TenLop, NamHoc, HocKi, KhoiHoc,
                       CASE WHEN DaKetThuc = 1 THEN N'Đã kết thúc' ELSE N'Đang học' END AS TrangThai
                FROM Lop
                WHERE (NamHoc = @NamHoc OR @NamHoc IS NULL)
                  AND (HocKi = @HocKi OR @HocKi IS NULL)
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

        // 📗 Lấy danh sách năm học có trong bảng Lop
        public DataTable LayDanhSachNamHoc()
        {
            string sql = "SELECT DISTINCT NamHoc FROM Lop WHERE NamHoc IS NOT NULL ORDER BY NamHoc DESC";
            return db.GetData(sql);
        }

        // 📙 Thêm lớp
        public bool ThemLop(string tenLop, int namHoc, int hocKi, int khoiHoc, int giaoVienID)
        {
            string sql = @"
                INSERT INTO Lop (TenLop, NamHoc, HocKi, KhoiHoc, GiaoVienID, DaKetThuc)
                VALUES (@TenLop, @NamHoc, @HocKi, @KhoiHoc, @GiaoVienID, 0)";

            SqlParameter[] prms =
            {
                new SqlParameter("@TenLop", tenLop),
                new SqlParameter("@NamHoc", namHoc),
                new SqlParameter("@HocKi", hocKi),
                new SqlParameter("@KhoiHoc", khoiHoc),
                new SqlParameter("@GiaoVienID", giaoVienID)
            };

            return db.ExecuteNonQuery(sql, prms);
        }

        // 📒 Cập nhật lớp
        public bool CapNhatLop(int lopId, string tenLop, int namHoc, int hocKi, int khoiHoc, bool daKetThuc, int giaoVienID)
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
                new SqlParameter("@GiaoVienID", giaoVienID),
                new SqlParameter("@LopID", lopId)
            };

            return db.ExecuteNonQuery(sql, prms);
        }

        // 📕 Xóa lớp
        public bool XoaLop(int lopId)
        {
            string sql = "DELETE FROM Lop WHERE LopID = @id";
            SqlParameter[] prms = { new SqlParameter("@id", lopId) };
            return db.ExecuteNonQuery(sql, prms);
        }
    }
}
