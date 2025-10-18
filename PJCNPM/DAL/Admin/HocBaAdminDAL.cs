using System;
using System.Data;
using System.Data.SqlClient;

namespace PJCNPM.DAL.Admin
{
    internal class HocBaAdminDAL
    {
        private readonly DBConnection db = new DBConnection();

        // 🔹 Lấy danh sách năm học mà học sinh đã học
        public DataTable LayNamHocTheoHocSinh(int hocSinhID)
        {
            string sql = @"
                SELECT DISTINCT l.NamHoc
                FROM HocSinh_Lop hl
                JOIN Lop l ON hl.LopID = l.LopID
                WHERE hl.HocSinhID = @HocSinhID
                ORDER BY l.NamHoc DESC";
            SqlParameter[] prms = { new SqlParameter("@HocSinhID", hocSinhID) };
            return db.GetData(sql, prms);
        }

        // 🔹 Lấy danh sách học kỳ của năm học đó
        public DataTable LayHocKyTheoNam(int hocSinhID, int namHoc)
        {
            string sql = @"
                SELECT DISTINCT l.HocKi
                FROM HocSinh_Lop hl
                JOIN Lop l ON hl.LopID = l.LopID
                WHERE hl.HocSinhID = @HocSinhID AND l.NamHoc = @NamHoc
                ORDER BY l.HocKi";
            SqlParameter[] prms =
            {
                new SqlParameter("@HocSinhID", hocSinhID),
                new SqlParameter("@NamHoc", namHoc)
            };
            return db.GetData(sql, prms);
        }

        // 🔹 Lấy bảng điểm chi tiết (điểm TB làm tròn 2 chữ số)
        public DataTable LayDiemTheoHocKy(int hocSinhID, int namHoc, int hocKy)
        {
            string sql = @"
                SELECT 
                    mh.TenMon AS [Môn học],
                    d.TX1, d.TX2, d.TX3, d.TX4,
                    d.GiuaKy AS [Giữa kỳ],
                    d.CuoiKy AS [Cuối kỳ],
                    ROUND(
                        (
                            (ISNULL(d.TX1,0)+ISNULL(d.TX2,0)+ISNULL(d.TX3,0)+ISNULL(d.TX4,0))/4 * 0.3 +
                            ISNULL(d.GiuaKy,0)*0.3 +
                            ISNULL(d.CuoiKy,0)*0.4
                        ), 2
                    ) AS [Điểm TB]
                FROM Diem d
                JOIN MonHoc mh ON d.MonHocID = mh.MonHocID
                JOIN Lop l ON d.LopID = l.LopID
                WHERE d.HocSinhID = @HocSinhID AND l.NamHoc = @NamHoc AND l.HocKi = @HocKi
                ORDER BY mh.TenMon";

            SqlParameter[] prms =
            {
                new SqlParameter("@HocSinhID", hocSinhID),
                new SqlParameter("@NamHoc", namHoc),
                new SqlParameter("@HocKi", hocKy)
            };

            return db.GetData(sql, prms);
        }

        // 🔹 Tính điểm trung bình học kỳ & lấy hạnh kiểm
        public DataRow LayThongTinHocKy(int hocSinhID, int namHoc, int hocKy)
        {
            string sql = @"
                SELECT 
                    ROUND(AVG(
                        (ISNULL(d.TX1,0)+ISNULL(d.TX2,0)+ISNULL(d.TX3,0)+ISNULL(d.TX4,0))/4 * 0.3 +
                        ISNULL(d.GiuaKy,0)*0.3 +
                        ISNULL(d.CuoiKy,0)*0.4
                    ), 2) AS DiemTrungBinhHK,
                    hl.HanhKiem
                FROM Diem d
                JOIN Lop l ON d.LopID = l.LopID
                JOIN HocSinh_Lop hl ON hl.LopID = l.LopID AND hl.HocSinhID = d.HocSinhID
                WHERE d.HocSinhID = @HocSinhID AND l.NamHoc = @NamHoc AND l.HocKi = @HocKi
                GROUP BY hl.HanhKiem";

            SqlParameter[] prms =
            {
                new SqlParameter("@HocSinhID", hocSinhID),
                new SqlParameter("@NamHoc", namHoc),
                new SqlParameter("@HocKi", hocKy)
            };

            DataTable dt = db.GetData(sql, prms);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
    }
}
