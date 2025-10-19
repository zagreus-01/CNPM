using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PJCNPM.DAL.Admin
{
    internal class RoleDB
    {
        private readonly DBconnection db;
        public RoleDB()
        {
            db = new DBconnection();
        }

        public List<(int RoleID, string Ten)> GetAll()
        {
            var list = new List<(int, string)>();
            const string sql = @"SELECT RoleID, Ten FROM dbo.Role WHERE TrangThai=1 ORDER BY Ten";
            using (var conn = db.GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add((Convert.ToInt32(r["RoleID"]), r["Ten"] as string ?? ""));
                    }
                }
            }
            return list;
        }
    }
}
