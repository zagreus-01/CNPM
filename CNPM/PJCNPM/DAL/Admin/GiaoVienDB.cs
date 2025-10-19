using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJCNPM.DAL.Admin
{
    internal class GiaoVienDB
    {
        private readonly DBconnection dbConnection;
        public GiaoVienDB()
        {
            dbConnection = new DBconnection();
        }
        public List<Mod.GiaoVien> GetAllGiaoVien()
        {
            var list = new List<Mod.GiaoVien>();

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"SELECT GiaoVienID, HoTen FROM dbo.GiaoVien ORDER BY HoTen";

                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var gv = new Mod.GiaoVien
                        {
                            GiaoVienID = reader.GetInt32(reader.GetOrdinal("GiaoVienID")),
                            HoTen = reader["HoTen"] as string ?? string.Empty
                            // Các trường khác để mặc định (null)
                        };
                        list.Add(gv);
                    }
                }
            }
            return list;
        }
        public Mod.GiaoVien GetGiaoVienByID(int id)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"SELECT GiaoVienID, HoTen FROM dbo.GiaoVien WHERE GiaoVienID = @ID";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Mod.GiaoVien
                            {
                                GiaoVienID = reader.GetInt32(reader.GetOrdinal("GiaoVienID")),
                                HoTen = reader["HoTen"] as string ?? string.Empty,
                             };
                        }
                    }
                }
            }
            return null; // Trả về null nếu không tìm thấy
        }
    }
}
