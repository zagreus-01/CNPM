using PJCNPM.Mod;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PJCNPM.DAL.Admin
{
    internal class LopDB
    {
        private readonly DBconnection dbConnection;
        public LopDB()
        {
            dbConnection = new DBconnection();
        }

        // Lấy danh sách lớp: chỉ ID + Tên (dùng cho combobox)
        public List<Mod.Lop> GetAllLopBasic()
        {
            var list = new List<Mod.Lop>();
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"SELECT LopID, TenLop FROM dbo.Lop ORDER BY TenLop";
                using (var cmd = new SqlCommand(sql, conn))
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new Mod.Lop
                        {
                            LopID = r.GetInt32(r.GetOrdinal("LopID")),
                            TenLop = r["TenLop"] as string ?? string.Empty
                        });
                    }
                }
            }
            return list;
        }

        // Lấy 1 lớp theo ID (ID + Tên)
        public Mod.Lop GetLopByID(int id)
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"SELECT LopID, TenLop FROM dbo.Lop WHERE LopID = @ID";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            return new Mod.Lop
                            {
                                LopID = r.GetInt32(r.GetOrdinal("LopID")),
                                TenLop = r["TenLop"] as string ?? string.Empty
                            };
                        }
                    }
                }
            }
            return null;
        }

        // Lấy tất cả lớp (để tương thích với BLL)
        public List<Mod.Lop> GetAllLop()
        {
            var list = new List<Mod.Lop>();
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"SELECT LopID, TenLop, NamHoc, HocKi, KhoiHoc, DaKetThuc, GiaoVienID 
                                   FROM dbo.Lop 
                                   ORDER BY TenLop";
                using (var cmd = new SqlCommand(sql, conn))
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new Mod.Lop
                        {
                            LopID = r.GetInt32(r.GetOrdinal("LopID")),
                            TenLop = r["TenLop"] as string ?? string.Empty,
                            NamHoc = r["NamHoc"] as string,
                            HocKi = r["HocKi"] as int?,
                            KhoiHoc = r["KhoiHoc"] as int?,
                            DaKetThuc = r["DaKetThuc"] as bool?,
                            GiaoVienID = r["GiaoVienID"] as int?
                        });
                    }
                }
            }
            return list;
        }

        // Lấy danh sách lớp đang hoạt động (DaKetThuc = 0 hoặc NULL)
        public List<Mod.Lop> GetAllLopActive()
        {
            var list = new List<Mod.Lop>();
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"SELECT LopID, TenLop, NamHoc, HocKi, KhoiHoc, DaKetThuc, GiaoVienID 
                                   FROM dbo.Lop 
                                   WHERE (DaKetThuc = 0 OR DaKetThuc IS NULL)
                                   ORDER BY TenLop";
                using (var cmd = new SqlCommand(sql, conn))
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new Mod.Lop
                        {
                            LopID = r.GetInt32(r.GetOrdinal("LopID")),
                            TenLop = r["TenLop"] as string ?? string.Empty,
                            NamHoc = r["NamHoc"] as string,
                            HocKi = r["HocKi"] as int?,
                            KhoiHoc = r["KhoiHoc"] as int?,
                            DaKetThuc = r["DaKetThuc"] as bool?,
                            GiaoVienID = r["GiaoVienID"] as int?
                        });
                    }
                }
            }
            return list;
        }
    }
}
