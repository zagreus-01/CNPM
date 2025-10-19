using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PJCNPM.DAL.Admin
{
    internal class TaiKhoanDB
    {
        private readonly DBconnection db;
        public TaiKhoanDB()
        {
            db = new DBconnection();
        }
        public DataTable SearchHocSinhAccounts(string keyword)
        {
            keyword = (keyword ?? "").Trim();

            // Dùng OUTER APPLY để lấy 1 bản ghi lớp "gần nhất" cho HS
            string sql = @"
SELECT 
    CAST(0 AS bit) AS Chon,
    hs.HocSinhID,
    hs.HoTen,
    hs.NamNhapHoc,
    ISNULL(l.TenLop, N'') AS Lop,
    ISNULL(CASE WHEN tk.TrangThai = 1 THEN N'Hoạt động' ELSE N'Khoá' END, N'Chưa có') AS TrangThai,
    ISNULL(tk.TenTK, N'') AS TenTK,
    ISNULL(tk.MatKhau, N'') AS MatKhau,
    tk.RoleID
FROM dbo.HocSinh hs
OUTER APPLY (
    SELECT TOP 1 hsl.LopID
    FROM dbo.HocSinh_Lop hsl
    WHERE hsl.HocSinhID = hs.HocSinhID
    ORDER BY hsl.LopID DESC
) x
LEFT JOIN dbo.Lop l ON l.LopID = x.LopID
LEFT JOIN dbo.TaiKhoan tk ON tk.TenTK = hs.TenTK
WHERE
    (@q = N'')
    OR (hs.HoTen LIKE N'%' + @q + N'%')
    OR (l.TenLop LIKE N'%' + @q + N'%')
    OR (CAST(hs.HocSinhID AS NVARCHAR(50)) = @q)
    OR (CAST(hs.NamNhapHoc AS NVARCHAR(50)) = @q)
    OR (tk.TenTK LIKE N'%' + @q + N'%')
    OR (
        (@q = N'1' OR @q LIKE N'%hoạt%' OR @q LIKE N'%hoat%')
        AND tk.TrangThai = 1
    )
    OR (
        (@q = N'0' OR @q LIKE N'%khoá%' OR @q LIKE N'%khoa%')
        AND tk.TrangThai = 0
    )
ORDER BY hs.HoTen;";

            using (var conn = db.GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@q", keyword);
                var dt = new DataTable();
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    dt.Load(r);
                }
                return dt;
            }
        }

        // GV: Search theo comboBox5 (tên GV / id GV / ten tk / trạng thái)
        // Trả về DataTable có cột: [Chon](bool), GiaoVienID, HoTen, TrangThai, TenTK, MatKhau, RoleID
        public DataTable SearchGiaoVienAccounts(string keyword)
        {
            keyword = (keyword ?? "").Trim();
            string sql = @"
SELECT 
    CAST(0 AS bit) AS Chon,
    gv.GiaoVienID,
    gv.HoTen,
    ISNULL(CASE WHEN tk.TrangThai = 1 THEN N'Hoạt động' ELSE N'Khoá' END, N'Chưa có') AS TrangThai,
    ISNULL(tk.TenTK, N'') AS TenTK,
    ISNULL(tk.MatKhau, N'') AS MatKhau,
    tk.RoleID
FROM dbo.GiaoVien gv
LEFT JOIN dbo.TaiKhoan tk ON tk.TenTK = gv.TenTK
WHERE
    (@q = N'')
    OR (gv.HoTen LIKE N'%' + @q + N'%')
    OR (CAST(gv.GiaoVienID AS NVARCHAR(50)) = @q)
    OR (tk.TenTK LIKE N'%' + @q + N'%')
    OR (
        (@q = N'1' OR @q LIKE N'%hoạt%' OR @q LIKE N'%hoat%')
        AND tk.TrangThai = 1
    )
    OR (
        (@q = N'0' OR @q LIKE N'%khoá%' OR @q LIKE N'%khoa%')
        AND tk.TrangThai = 0
    )
ORDER BY gv.HoTen;";

            using (var conn = db.GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@q", keyword);
                var dt = new DataTable();
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    dt.Load(r);
                }
                return dt;
            }
        }

        // ===================== TÀI KHOẢN: LẤY – UPSERT – CẬP NHẬT =====================
        public (string TenTK, string MatKhau, bool? TrangThai, int? RoleID)? GetByTenTK(string tenTK)
        {
            const string sql = @"SELECT TenTK, MatKhau, TrangThai, RoleID FROM dbo.TaiKhoan WHERE TenTK=@u";
            using (var conn = db.GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@u", tenTK ?? (object)DBNull.Value);
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        return (
                            r["TenTK"] as string,
                            r["MatKhau"] as string,
                            r["TrangThai"] as bool? ?? null,
                            r["RoleID"] as int? ?? (r.IsDBNull(r.GetOrdinal("RoleID")) ? (int?)null : Convert.ToInt32(r["RoleID"]))
                        );
                    }
                }
            }
            return null;
        }

        // Upsert TK (tạo mới nếu chưa có, ngược lại cập nhật)
        public bool UpsertAccount(string tenTK, string matKhau, bool? trangThai, int? roleID)
        {
            // Nếu chưa có thì INSERT, có rồi thì UPDATE
            var exist = GetByTenTK(tenTK);
            if (exist == null)
            {
                // Kiểm tra roleID có giá trị hợp lệ không
                if (!roleID.HasValue)
                {
                    throw new ArgumentException("RoleID không được để trống khi tạo tài khoản mới");
                }

                const string ins = @"INSERT INTO dbo.TaiKhoan(TenTK, MatKhau, TrangThai, RoleID)
                                     VALUES(@u, @p, ISNULL(@t,1), @r)";
                using (var conn = db.GetConnection())
                using (var cmd = new SqlCommand(ins, conn))
                {
                    cmd.Parameters.AddWithValue("@u", tenTK);
                    cmd.Parameters.AddWithValue("@p", (object)matKhau ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@t", (object)trangThai ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@r", roleID.Value);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            else
            {
                const string upd = @"UPDATE dbo.TaiKhoan 
                                     SET MatKhau=@p, TrangThai=ISNULL(@t,TrangThai), RoleID=@r 
                                     WHERE TenTK=@u";
                using (var conn = db.GetConnection())
                using (var cmd = new SqlCommand(upd, conn))
                {
                    cmd.Parameters.AddWithValue("@u", tenTK);
                    cmd.Parameters.AddWithValue("@p", (object)matKhau ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@t", (object)trangThai ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@r", roleID ?? exist.Value.RoleID ?? 1); // Sử dụng giá trị cũ nếu roleID mới là null
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateCredentials(string tenTK, string newPassword, int? roleID)
        {
            const string sql = @"UPDATE dbo.TaiKhoan SET MatKhau=@p, RoleID=@r WHERE TenTK=@u";
            using (var conn = db.GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@u", tenTK);
                cmd.Parameters.AddWithValue("@p", (object)newPassword ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@r", (object)roleID ?? DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateRole(string tenTK, int? roleID)
        {
            const string sql = @"UPDATE dbo.TaiKhoan SET RoleID=@r WHERE TenTK=@u";
            using (var conn = db.GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@u", tenTK);
                cmd.Parameters.AddWithValue("@r", (object)roleID ?? DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ===================== BULK ROLE THEO DANH SÁCH USERNAME =====================
        public int BulkUpdateRole(IEnumerable<string> userNames, int? roleID)
        {
            int count = 0;
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        foreach (var u in userNames)
                        {
                            using (var cmd = new SqlCommand(@"UPDATE dbo.TaiKhoan SET RoleID=@r WHERE TenTK=@u", conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@u", u);
                                cmd.Parameters.AddWithValue("@r", (object)roleID ?? DBNull.Value);
                                count += cmd.ExecuteNonQuery();
                            }
                        }
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
            return count;
        }
        public bool UpdateTrangThaiByTenTK(string tenTK, bool trangThai)
        {
            const string sql = "UPDATE dbo.TaiKhoan SET TrangThai=@tt WHERE TenTK=@tk";
            using (var conn = db.GetConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@tt", trangThai ? 1 : 0);
                cmd.Parameters.AddWithValue("@tk", tenTK);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
