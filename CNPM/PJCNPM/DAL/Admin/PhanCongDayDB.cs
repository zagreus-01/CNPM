using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PJCNPM.DAL.Admin
{
    internal class PhanCongDayDB
    {
        private readonly DBconnection dbConnection;
        public PhanCongDayDB()
        {
            dbConnection = new DBconnection();
        }

        public List<Mod.PhanCongDay> GetAllPhanCongDay()
        {
            var list = new List<Mod.PhanCongDay>();
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"SELECT MonHocID, GiaoVienID, LopID, SoTiet 
                                     FROM dbo.PhanCong 
                                     ORDER BY GiaoVienID, LopID, MonHocID";
                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new Mod.PhanCongDay
                        {
                            MonHocID = reader.GetInt32(reader.GetOrdinal("MonHocID")),
                            GiaoVienID = reader.GetInt32(reader.GetOrdinal("GiaoVienID")),
                            LopID = reader.GetInt32(reader.GetOrdinal("LopID")),
                            SoTiet = reader.IsDBNull(reader.GetOrdinal("SoTiet")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("SoTiet"))
                        };
                        list.Add(item);
                    }
                }
            }
            return list;
        }

        // Lọc theo giáo viên
        public List<Mod.PhanCongDay> GetByGiaoVienID(int giaoVienID)
        {
            var list = new List<Mod.PhanCongDay>();
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"SELECT MonHocID, GiaoVienID, LopID, SoTiet
                                     FROM dbo.PhanCong
                                     WHERE GiaoVienID = @GVID
                                     ORDER BY LopID, MonHocID";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@GVID", SqlDbType.Int) { Value = giaoVienID });
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(new Mod.PhanCongDay
                            {
                                MonHocID = r.GetInt32(r.GetOrdinal("MonHocID")),
                                GiaoVienID = r.GetInt32(r.GetOrdinal("GiaoVienID")),
                                LopID = r.GetInt32(r.GetOrdinal("LopID")),
                                SoTiet = r.IsDBNull(r.GetOrdinal("SoTiet")) ? (int?)null : r.GetInt32(r.GetOrdinal("SoTiet"))
                            });
                        }
                    }
                }
            }
            return list;
        }

        public bool Insert(Mod.PhanCongDay p)
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"INSERT INTO dbo.PhanCong(MonHocID, GiaoVienID, LopID, SoTiet)
                                     VALUES(@MonHocID, @GiaoVienID, @LopID, @SoTiet)";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MonHocID", p.MonHocID);
                    cmd.Parameters.AddWithValue("@GiaoVienID", p.GiaoVienID);
                    cmd.Parameters.AddWithValue("@LopID", p.LopID);
                    cmd.Parameters.AddWithValue("@SoTiet", p.SoTiet ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(Mod.PhanCongDay oldP, Mod.PhanCongDay newP)
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"UPDATE dbo.PhanCong
                                     SET MonHocID = @NewMonHocID,
                                         GiaoVienID = @NewGiaoVienID,
                                         LopID = @NewLopID,
                                         SoTiet = @NewSoTiet
                                     WHERE MonHocID = @OldMonHocID 
                                       AND GiaoVienID = @OldGiaoVienID 
                                       AND LopID = @OldLopID";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@OldMonHocID", oldP.MonHocID);
                    cmd.Parameters.AddWithValue("@OldGiaoVienID", oldP.GiaoVienID);
                    cmd.Parameters.AddWithValue("@OldLopID", oldP.LopID);
                    cmd.Parameters.AddWithValue("@NewMonHocID", newP.MonHocID);
                    cmd.Parameters.AddWithValue("@NewGiaoVienID", newP.GiaoVienID);
                    cmd.Parameters.AddWithValue("@NewLopID", newP.LopID);
                    cmd.Parameters.AddWithValue("@NewSoTiet", newP.SoTiet ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(Mod.PhanCongDay p)
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"DELETE FROM dbo.PhanCong 
                                     WHERE MonHocID = @MonHocID 
                                       AND GiaoVienID = @GiaoVienID 
                                       AND LopID = @LopID";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MonHocID", p.MonHocID);
                    cmd.Parameters.AddWithValue("@GiaoVienID", p.GiaoVienID);
                    cmd.Parameters.AddWithValue("@LopID", p.LopID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Xoá tất cả phân công của 1 giáo viên
        public bool DeleteByGiaoVienID(int giaoVienID)
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"DELETE FROM dbo.PhanCong WHERE GiaoVienID = @GVID";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@GVID", giaoVienID);
                    return cmd.ExecuteNonQuery() >= 0; // không có bản ghi cũng coi là OK
                }
            }
        }

        // Lấy phân công theo lớp
        public List<Mod.PhanCongDay> GetPhanCongByLop(int lopID)
        {
            var list = new List<Mod.PhanCongDay>();
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"SELECT MonHocID, GiaoVienID, LopID, SoTiet
                                     FROM dbo.PhanCong
                                     WHERE LopID = @LopID
                                     ORDER BY MonHocID";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@LopID", lopID);
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(new Mod.PhanCongDay
                            {
                                MonHocID = r.GetInt32(r.GetOrdinal("MonHocID")),
                                GiaoVienID = r.GetInt32(r.GetOrdinal("GiaoVienID")),
                                LopID = r.GetInt32(r.GetOrdinal("LopID")),
                                SoTiet = r.IsDBNull(r.GetOrdinal("SoTiet")) ? (int?)null : r.GetInt32(r.GetOrdinal("SoTiet"))
                            });
                        }
                    }
                }
            }
            return list;
        }

        // Lấy phân công theo lớp và môn học
        public List<Mod.PhanCongDay> GetByLopAndMon(int lopID, int monHocID)
        {
            var list = new List<Mod.PhanCongDay>();
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"SELECT MonHocID, GiaoVienID, LopID, SoTiet
                                     FROM dbo.PhanCong
                                     WHERE LopID = @LopID AND MonHocID = @MonHocID
                                     ORDER BY GiaoVienID";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@LopID", lopID);
                    cmd.Parameters.AddWithValue("@MonHocID", monHocID);
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(new Mod.PhanCongDay
                            {
                                MonHocID = r.GetInt32(r.GetOrdinal("MonHocID")),
                                GiaoVienID = r.GetInt32(r.GetOrdinal("GiaoVienID")),
                                LopID = r.GetInt32(r.GetOrdinal("LopID")),
                                SoTiet = r.IsDBNull(r.GetOrdinal("SoTiet")) ? (int?)null : r.GetInt32(r.GetOrdinal("SoTiet"))
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}
