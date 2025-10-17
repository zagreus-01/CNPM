using System.Data;
using System.Data.SqlClient;

namespace PJCNPM.DAL.Admin
{
    internal class HocSinhXemDAL
    {
        private readonly DBConnection db = new DBConnection();

        /// <summary>
        /// Lấy thông tin chi tiết học sinh (bao gồm lớp)
        /// </summary>
        public DataRow LayThongTinHocSinh(int hocSinhID)
        {
            string sql = @"
                SELECT 
                    hs.HocSinhID,
                    hs.HoTen,
                    hs.NgaySinh,
                    hs.GioiTinh,
                    hs.DanToc,
                    hs.TonGiao,
                    hs.QueQuan,
                    hs.NamNhapHoc,
                    hs.TrangThai,
                    l.LopID,
                    l.TenLop,
                    l.NamHoc,
                    l.HocKi,
                    l.KhoiHoc
                FROM HocSinh hs
                LEFT JOIN HocSinh_Lop hl ON hl.HocSinhID = hs.HocSinhID
                LEFT JOIN Lop l ON l.LopID = hl.LopID
                WHERE hs.HocSinhID = @HocSinhID";

            SqlParameter[] prms = { new SqlParameter("@HocSinhID", hocSinhID) };

            DataTable dt = db.GetData(sql, prms);
            return (dt != null && dt.Rows.Count > 0) ? dt.Rows[0] : null;
        }
    }
}
