using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using PJCNPM.Mod;

namespace PJCNPM.DAL.Admin
{
    internal class MonHocDB
    {
        private readonly DBconnection dbConnection;

        public MonHocDB()
        {
            dbConnection = new DBconnection();
        }

        public List<MonHoc> GetAllMonHoc()
        {
            var list = new List<MonHoc>();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string sql = "SELECT MonHocID, TenMon, LaMonDoi, LaMonNangKhieu, TrangThai FROM MonHoc ORDER BY TenMon";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MonHoc
                        {
                            MonHocID = reader["MonHocID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["MonHocID"]),
                            TenMon = reader["TenMon"] == DBNull.Value ? string.Empty : reader["TenMon"].ToString(),
                            LaMonDoi = reader["LaMonDoi"] == DBNull.Value ? false : Convert.ToBoolean(reader["LaMonDoi"]),
                            LaMonNangKhieu = reader["LaMonNangKhieu"] == DBNull.Value ? false : Convert.ToBoolean(reader["LaMonNangKhieu"]),
                            TrangThai = reader["TrangThai"] == DBNull.Value ? false : Convert.ToBoolean(reader["TrangThai"])
                        });
                    }
                }
            }
            return list;
        }

        public List<MonHoc> GetAllMonHocActive()
        {
            var list = new List<MonHoc>();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string sql = "SELECT MonHocID, TenMon, LaMonDoi, LaMonNangKhieu, TrangThai FROM MonHoc WHERE TrangThai = 1 ORDER BY TenMon";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MonHoc
                        {
                            MonHocID = reader["MonHocID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["MonHocID"]),
                            TenMon = reader["TenMon"] == DBNull.Value ? string.Empty : reader["TenMon"].ToString(),
                            LaMonDoi = reader["LaMonDoi"] == DBNull.Value ? false : Convert.ToBoolean(reader["LaMonDoi"]),
                            LaMonNangKhieu = reader["LaMonNangKhieu"] == DBNull.Value ? false : Convert.ToBoolean(reader["LaMonNangKhieu"]),
                            TrangThai = reader["TrangThai"] == DBNull.Value ? false : Convert.ToBoolean(reader["TrangThai"])
                        });
                    }
                }
            }
            return list;
        }

        public MonHoc GetMonHocByID(int id)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM MonHoc WHERE MonHocID = @ID";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new MonHoc
                            {
                                MonHocID = reader["MonHocID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["MonHocID"]),
                                TenMon = reader["TenMon"] == DBNull.Value ? string.Empty : reader["TenMon"].ToString(),
                                LaMonDoi = reader["LaMonDoi"] == DBNull.Value ? false : Convert.ToBoolean(reader["LaMonDoi"]),
                                LaMonNangKhieu = reader["LaMonNangKhieu"] == DBNull.Value ? false : Convert.ToBoolean(reader["LaMonNangKhieu"]),
                                TrangThai = reader["TrangThai"] == DBNull.Value ? false : Convert.ToBoolean(reader["TrangThai"])
                            };
                        }
                    }
                }
            }
            return null;
        }

        public bool InsertMonHoc(MonHoc mh)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO MonHoc (TenMon, LaMonDoi, LaMonNangKhieu, TrangThai)
                       VALUES (@TenMon, @LaMonDoi, @LaMonNangKhieu, @TrangThai)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@TenMon", mh.TenMon);
                    cmd.Parameters.AddWithValue("@LaMonDoi", mh.LaMonDoi);
                    cmd.Parameters.AddWithValue("@LaMonNangKhieu", mh.LaMonNangKhieu);
                    cmd.Parameters.AddWithValue("@TrangThai", mh.TrangThai); // <—
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }



        public bool UpdateMonHoc(MonHoc mh)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string sql = @"UPDATE MonHoc
                       SET TenMon=@TenMon,
                           LaMonDoi=@LaMonDoi,
                           LaMonNangKhieu=@LaMonNangKhieu,
                           TrangThai=@TrangThai          -- <—
                       WHERE MonHocID=@MonHocID";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MonHocID", mh.MonHocID);
                    cmd.Parameters.AddWithValue("@TenMon", mh.TenMon);
                    cmd.Parameters.AddWithValue("@LaMonDoi", mh.LaMonDoi);
                    cmd.Parameters.AddWithValue("@LaMonNangKhieu", mh.LaMonNangKhieu);
                    cmd.Parameters.AddWithValue("@TrangThai", mh.TrangThai); // <—
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


        public bool DeleteMonHoc(int id)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                // Chỉ khoá môn (TrangThai = 0), không xoá dữ liệu liên quan
                string sql = "UPDATE MonHoc SET TrangThai = 0 WHERE MonHocID = @ID";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool PermanentlyDeleteMonHoc(int id)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Xóa các bản ghi liên quan trước
                        // Xóa phân công dạy
                        string deletePhanCong = "DELETE FROM PhanCong WHERE MonHocID = @ID";
                        using (SqlCommand cmd = new SqlCommand(deletePhanCong, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ID", id);
                            cmd.ExecuteNonQuery();
                        }

                        // Xóa thời khóa biểu
                        string deleteTKB = "DELETE FROM ThoiKhoaBieu WHERE MonHocID = @ID";
                        using (SqlCommand cmd = new SqlCommand(deleteTKB, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ID", id);
                            cmd.ExecuteNonQuery();
                        }

                        // Xóa điểm số
                        string deleteDiem = "DELETE FROM Diem WHERE MonHocID = @ID";
                        using (SqlCommand cmd = new SqlCommand(deleteDiem, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ID", id);
                            cmd.ExecuteNonQuery();
                        }

                        // Cuối cùng xóa môn học
                        string deleteMonHoc = "DELETE FROM MonHoc WHERE MonHocID = @ID";
                        using (SqlCommand cmd = new SqlCommand(deleteMonHoc, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ID", id);
                            int result = cmd.ExecuteNonQuery();
                            
                            if (result > 0)
                            {
                                transaction.Commit();
                                return true;
                            }
                            else
                            {
                                transaction.Rollback();
                                return false;
                            }
                        }
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
        public List<MonHoc> GetAllMonHocLocked()
        {
            var list = new List<MonHoc>();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string sql = "SELECT MonHocID, TenMon, LaMonDoi, LaMonNangKhieu, TrangThai FROM MonHoc WHERE TrangThai = 0 ORDER BY TenMon";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MonHoc
                        {
                            MonHocID = reader["MonHocID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["MonHocID"]),
                            TenMon = reader["TenMon"] == DBNull.Value ? string.Empty : reader["TenMon"].ToString(),
                            LaMonDoi = reader["LaMonDoi"] == DBNull.Value ? false : Convert.ToBoolean(reader["LaMonDoi"]),
                            LaMonNangKhieu = reader["LaMonNangKhieu"] == DBNull.Value ? false : Convert.ToBoolean(reader["LaMonNangKhieu"]),
                            TrangThai = reader["TrangThai"] == DBNull.Value ? false : Convert.ToBoolean(reader["TrangThai"])
                        });
                    }
                }
            }
            return list;
        }
    }
}
