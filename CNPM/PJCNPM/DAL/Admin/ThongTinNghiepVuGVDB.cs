using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PJCNPM.DAL.Admin
{
    internal class ThongTinNghiepVuGVDB
    {
        private readonly DBconnection dbConnection;
        public ThongTinNghiepVuGVDB()
        {
            dbConnection = new DBconnection();
        }

        // Lấy tất cả
        public List<Mod.ThongTinNghiepVuGV> GetAllThongTinNghiepVuGV()
        {
            var list = new List<Mod.ThongTinNghiepVuGV>();
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"SELECT NghiepVuID, GiaoVienID, SoTietToiDa, LaChuNhiem, LopChuNhiemID
                                     FROM dbo.ThongTinNghiepVuGV
                                     ORDER BY GiaoVienID";
                using (var cmd = new SqlCommand(sql, conn))
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(Map(r));
                    }
                }
            }
            return list;
        }

        // Lấy 1 bản ghi theo PK
        public Mod.ThongTinNghiepVuGV GetThongTinNghiepVuGVByID(int nghiepVuID)
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"SELECT NghiepVuID, GiaoVienID, SoTietToiDa, LaChuNhiem, LopChuNhiemID
                                     FROM dbo.ThongTinNghiepVuGV
                                     WHERE NghiepVuID = @ID";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", nghiepVuID);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read()) return Map(r);
                    }
                }
            }
            return null;
        }

        // Lấy theo giáo viên
        public Mod.ThongTinNghiepVuGV GetByGiaoVienID(int giaoVienID)
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"SELECT TOP 1 NghiepVuID, GiaoVienID, SoTietToiDa, LaChuNhiem, LopChuNhiemID
                                     FROM dbo.ThongTinNghiepVuGV
                                     WHERE GiaoVienID = @GVID
                                     ORDER BY NghiepVuID DESC";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@GVID", giaoVienID);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read()) return Map(r);
                    }
                }
            }
            return null;
        }

        public int Insert(Mod.ThongTinNghiepVuGV info)
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"
INSERT INTO dbo.ThongTinNghiepVuGV(GiaoVienID, SoTietToiDa, LaChuNhiem, LopChuNhiemID)
VALUES(@GiaoVienID, @SoTietToiDa, @LaChuNhiem, @LopChuNhiemID);
SELECT SCOPE_IDENTITY();";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@GiaoVienID", info.GiaoVienID);
                    cmd.Parameters.AddWithValue("@SoTietToiDa", (object)info.SoTietToiDa ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@LaChuNhiem", (object)info.LaChuNhiem ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@LopChuNhiemID", (object)info.LopChuNhiemID ?? DBNull.Value);

                    object obj = cmd.ExecuteScalar();
                    return obj != null && int.TryParse(obj.ToString(), out int id) ? id : 0;
                }
            }
        }

        public bool Update(Mod.ThongTinNghiepVuGV info)
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"
UPDATE dbo.ThongTinNghiepVuGV
SET SoTietToiDa = @SoTietToiDa,
    LaChuNhiem  = @LaChuNhiem,
    LopChuNhiemID = @LopChuNhiemID
WHERE NghiepVuID = @NghiepVuID";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NghiepVuID", info.NghiepVuID);
                    cmd.Parameters.AddWithValue("@SoTietToiDa", (object)info.SoTietToiDa ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@LaChuNhiem", (object)info.LaChuNhiem ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@LopChuNhiemID", (object)info.LopChuNhiemID ?? DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteThongTinNghiepVuGV(int nghiepVuID)
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                const string sql = @"DELETE FROM dbo.ThongTinNghiepVuGV WHERE NghiepVuID = @ID";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", nghiepVuID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Upsert theo GiaoVienID
        public bool Upsert(Mod.ThongTinNghiepVuGV info)
        {
            var current = GetByGiaoVienID(info.GiaoVienID);
            if (current == null)
            {
                return Insert(info) > 0;
            }
            info.NghiepVuID = current.NghiepVuID;
            return Update(info);
        }

        // === XOÁ NGHIỆP VỤ + TOÀN BỘ PHÂN CÔNG DẠY CỦA GV (Transactional) ===
        public bool DeleteNghiepVuAndAssignmentsByGV(int giaoVienID)
        {
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // 1) Xoá toàn bộ Phân công dạy của GV
                        using (var cmd1 = new SqlCommand(
                            @"DELETE FROM dbo.PhanCong WHERE GiaoVienID = @GVID", conn, tran))
                        {
                            cmd1.Parameters.AddWithValue("@GVID", giaoVienID);
                            cmd1.ExecuteNonQuery(); // 0 dòng cũng OK
                        }

                        // 2) Xoá Nghiệp vụ GV
                        using (var cmd2 = new SqlCommand(
                            @"DELETE FROM dbo.ThongTinNghiepVuGV WHERE GiaoVienID = @GVID", conn, tran))
                        {
                            cmd2.Parameters.AddWithValue("@GVID", giaoVienID);
                            cmd2.ExecuteNonQuery(); // 0 hoặc 1 dòng tuỳ dữ liệu
                        }

                        tran.Commit();
                        return true;
                    }
                    catch
                    {
                        try { tran.Rollback(); } catch { /* ignore */ }
                        return false;
                    }
                }
            }
        }

        private Mod.ThongTinNghiepVuGV Map(SqlDataReader r)
        {
            return new Mod.ThongTinNghiepVuGV
            {
                NghiepVuID = r.GetInt32(r.GetOrdinal("NghiepVuID")),
                GiaoVienID = r.GetInt32(r.GetOrdinal("GiaoVienID")),
                SoTietToiDa = r.IsDBNull(r.GetOrdinal("SoTietToiDa")) ? (int?)null : r.GetInt32(r.GetOrdinal("SoTietToiDa")),
                LaChuNhiem = r.IsDBNull(r.GetOrdinal("LaChuNhiem")) ? (bool?)null : r.GetBoolean(r.GetOrdinal("LaChuNhiem")),
                LopChuNhiemID = r.IsDBNull(r.GetOrdinal("LopChuNhiemID")) ? (int?)null : r.GetInt32(r.GetOrdinal("LopChuNhiemID"))
            };
        }
    }
}
