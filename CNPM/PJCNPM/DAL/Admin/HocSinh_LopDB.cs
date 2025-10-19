using System;
using System.Data.SqlClient;

namespace PJCNPM.DAL.Admin
{
    internal class HocSinh_LopDB
    {
        private readonly DBconnection db;
        public HocSinh_LopDB()
        {
            db = new DBconnection();
        }

        // Lấy LopID mới nhất của HS (nếu cần)
        public int? GetLatestLopOfHocSinh(int hocSinhID)
        {
            const string sql = @"
SELECT TOP 1 LopID 
FROM dbo.HocSinh_Lop 
WHERE HocSinhID=@id 
ORDER BY LopID DESC";
            using (var conn = db.GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", hocSinhID);
                conn.Open();
                var o = cmd.ExecuteScalar();
                return (o == null || o is DBNull) ? (int?)null : Convert.ToInt32(o);
            }
        }
    }
}
