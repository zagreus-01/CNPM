using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PJCNPM.DAL.Admin
{
    internal class HocSinhDB
    {
        private readonly DBconnection db;
        public HocSinhDB()
        {
            db = new DBconnection();
        }

        // Lấy TenTK hiện tại của HS (để ánh xạ khi sửa nhanh)
        public string GetTenTK_ByHocSinhID(int hocSinhID)
        {
            const string sql = @"SELECT TenTK FROM dbo.HocSinh WHERE HocSinhID=@id";
            using (var conn = db.GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", hocSinhID);
                conn.Open();
                var o = cmd.ExecuteScalar();
                return o == null || o is DBNull ? null : Convert.ToString(o);
            }
        }

        // Gán lại TenTK cho HS (khi đổi username)
        public bool UpdateTenTK_ForHocSinh(int hocSinhID, string newTenTK)
        {
            const string sql = @"UPDATE dbo.HocSinh SET TenTK=@u WHERE HocSinhID=@id";
            using (var conn = db.GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@u", (object)newTenTK ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id", hocSinhID);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
