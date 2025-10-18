using System;
using System.Data;

namespace PJCNPM.DAL.HocSinh
{
    internal class DiemDAL
    {
        private readonly DBConnection db = new DBConnection();

        // 🔹 Lấy danh sách năm học mà học sinh đã học
        public DataTable LayNamHocHocSinh(int hocSinhID)
        {
            string query = $@"
                SELECT DISTINCT l.NamHoc
                FROM Lop l
                JOIN HocSinh_Lop hl ON hl.LopID = l.LopID
                WHERE hl.HocSinhID = {hocSinhID}
                ORDER BY l.NamHoc DESC";
            return db.GetData(query);
        }

        // 🔹 Lấy điểm học sinh theo năm học và học kỳ (nếu null thì cả năm)
        public DataTable LayBangDiemHocSinh(int hocSinhID, short namHoc, int? hocKy)
        {
            string query;

            if (hocKy == null)
            {
                // ===== CẢ NĂM =====
                query = $@"
                    SELECT 
                        mh.TenMon AS [Môn học],
                        ROUND(AVG(CASE WHEN l.HocKi = 1 THEN 
                            (ISNULL(d.TX1,0)+ISNULL(d.TX2,0)+ISNULL(d.TX3,0)+ISNULL(d.TX4,0)
                            +ISNULL(d.GiuaKy,0)*2+ISNULL(d.CuoiKy,0)*3)/9 END),2) AS [Trung bình HK1],
                        ROUND(AVG(CASE WHEN l.HocKi = 2 THEN 
                            (ISNULL(d.TX1,0)+ISNULL(d.TX2,0)+ISNULL(d.TX3,0)+ISNULL(d.TX4,0)
                            +ISNULL(d.GiuaKy,0)*2+ISNULL(d.CuoiKy,0)*3)/9 END),2) AS [Trung bình HK2],
                        ROUND(AVG(
                            (ISNULL(d.TX1,0)+ISNULL(d.TX2,0)+ISNULL(d.TX3,0)+ISNULL(d.TX4,0)
                            +ISNULL(d.GiuaKy,0)*2+ISNULL(d.CuoiKy,0)*3)/9),2) AS [Trung bình cả năm]
                    FROM Diem d
                    JOIN MonHoc mh ON mh.MonHocID = d.MonHocID
                    JOIN Lop l ON l.LopID = d.LopID
                    WHERE d.HocSinhID = {hocSinhID} AND l.NamHoc = {namHoc}
                    GROUP BY mh.TenMon
                    ORDER BY mh.TenMon";
            }
            else
            {
                // ===== HỌC KỲ CỤ THỂ =====
                query = $@"
                    SELECT 
                        mh.TenMon AS [Môn học],
                        ISNULL(d.TX1, 0) AS [TX1],
                        ISNULL(d.TX2, 0) AS [TX2],
                        ISNULL(d.TX3, 0) AS [TX3],
                        ISNULL(d.TX4, 0) AS [TX4],
                        ISNULL(d.GiuaKy, 0) AS [Giữa kỳ],
                        ISNULL(d.CuoiKy, 0) AS [Cuối kỳ],
                        ROUND((ISNULL(d.TX1,0)+ISNULL(d.TX2,0)+ISNULL(d.TX3,0)+ISNULL(d.TX4,0)
                            +ISNULL(d.GiuaKy,0)*2+ISNULL(d.CuoiKy,0)*3)/9,2) AS [Trung bình môn]
                    FROM Diem d
                    JOIN MonHoc mh ON mh.MonHocID = d.MonHocID
                    JOIN Lop l ON l.LopID = d.LopID
                    WHERE d.HocSinhID = {hocSinhID} AND l.NamHoc = {namHoc} AND l.HocKi = {hocKy}
                    ORDER BY mh.TenMon";
            }

            return db.GetData(query);
        }

        // 🔹 Lấy hạnh kiểm theo năm học hoặc học kỳ
        public string LayHanhKiem(int hocSinhID, short namHoc, int? hocKy)
        {
            string query = hocKy == null
                ? $@"SELECT TOP 1 HanhKiem FROM HocSinh_Lop hl
                     JOIN Lop l ON l.LopID = hl.LopID
                     WHERE hl.HocSinhID = {hocSinhID} AND l.NamHoc = {namHoc}"
                : $@"SELECT TOP 1 HanhKiem FROM HocSinh_Lop hl
                     JOIN Lop l ON l.LopID = hl.LopID
                     WHERE hl.HocSinhID = {hocSinhID} AND l.NamHoc = {namHoc} AND l.HocKi = {hocKy}";

            DataTable dt = db.GetData(query);
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["HanhKiem"].ToString();
            return "-";
        }
    }
}
