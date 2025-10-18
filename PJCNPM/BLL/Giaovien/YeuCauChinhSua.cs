using System;
using System.Data;
using System.Data.SqlClient;
using PJCNPM.DAL;

namespace PJCNPM.BLL.GiaoVien
{
    public class YeuCauChinhSua
    {
        private readonly DBConnection db;

        public YeuCauChinhSua()
        {
            db = new DBConnection();
        }

        // DTO chứa thông tin yêu cầu chỉnh sửa
        public class YeuCauChinhSuaInfo
        {
            public int GiaoVienID { get; set; }
            public string HoTen { get; set; }
            public bool? GioiTinh { get; set; }
            public string CCCD { get; set; }
            public string Email { get; set; }
            public string DienThoai { get; set; }
            public string DanToc { get; set; }
            public string TonGiao { get; set; }
            public bool? LaDangVien { get; set; } // Giữ tên cho UI đồng bộ
            public string NoiThuongTru { get; set; }
            public string QueQuan { get; set; }
            public DateTime? NgaySinh { get; set; }
            public string TrangThaiYeuCau { get; set; }
        }

        // 🔹 Lấy yêu cầu chỉnh sửa của giáo viên
        public YeuCauChinhSuaInfo GetYeuCauChinhSuaByGiaoVienID(int giaoVienID)
        {
            string sql = @"
                SELECT GiaoVienID, HoTen, GioiTinh, CCCD, Email, DienThoai, 
                       DanToc, TonGiao, LaDoanVien AS LaDangVien, NoiThuongTru, 
                       QueQuan, NgaySinh, TrangThaiYeuCau
                FROM ChinhSuaGiaoVien 
                WHERE GiaoVienID = @GiaoVienID";

            DataTable dt = db.GetData(sql, new SqlParameter[]
            {
                new SqlParameter("@GiaoVienID", giaoVienID)
            });

            if (dt == null || dt.Rows.Count == 0)
                return null;

            var row = dt.Rows[0];
            return new YeuCauChinhSuaInfo
            {
                GiaoVienID = Convert.ToInt32(row["GiaoVienID"]),
                HoTen = row["HoTen"] as string,
                GioiTinh = row["GioiTinh"] == DBNull.Value ? (bool?)null : Convert.ToBoolean(row["GioiTinh"]),
                CCCD = row["CCCD"] as string,
                Email = row["Email"] as string,
                DienThoai = row["DienThoai"] as string,
                DanToc = row["DanToc"] as string,
                TonGiao = row["TonGiao"] as string,
                LaDangVien = row["LaDangVien"] == DBNull.Value ? (bool?)null : Convert.ToBoolean(row["LaDangVien"]),
                NoiThuongTru = row["NoiThuongTru"] as string,
                QueQuan = row["QueQuan"] as string,
                NgaySinh = row["NgaySinh"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["NgaySinh"]),
                TrangThaiYeuCau = row["TrangThaiYeuCau"] as string
            };
        }

        // 🔹 Lưu yêu cầu chỉnh sửa (Thêm mới hoặc cập nhật)
        public bool LuuYeuCauChinhSua(YeuCauChinhSuaInfo yeuCau)
        {
            if (yeuCau == null) return false;

            string checkSql = "SELECT COUNT(*) FROM ChinhSuaGiaoVien WHERE GiaoVienID = @GiaoVienID";
            object obj = db.ExecuteScalar(checkSql, new SqlParameter[]
            {
                new SqlParameter("@GiaoVienID", yeuCau.GiaoVienID)
            });

            int count = (obj == null || obj == DBNull.Value) ? 0 : Convert.ToInt32(obj);

            SqlParameter[] p = {
                new SqlParameter("@GiaoVienID", yeuCau.GiaoVienID),
                new SqlParameter("@HoTen", (object)yeuCau.HoTen ?? DBNull.Value),
                new SqlParameter("@GioiTinh", (object)yeuCau.GioiTinh ?? DBNull.Value),
                new SqlParameter("@CCCD", (object)yeuCau.CCCD ?? DBNull.Value),
                new SqlParameter("@Email", (object)yeuCau.Email ?? DBNull.Value),
                new SqlParameter("@DienThoai", (object)yeuCau.DienThoai ?? DBNull.Value),
                new SqlParameter("@DanToc", (object)yeuCau.DanToc ?? DBNull.Value),
                new SqlParameter("@TonGiao", (object)yeuCau.TonGiao ?? DBNull.Value),
                new SqlParameter("@LaDangVien", (object)yeuCau.LaDangVien ?? DBNull.Value),
                new SqlParameter("@NoiThuongTru", (object)yeuCau.NoiThuongTru ?? DBNull.Value),
                new SqlParameter("@QueQuan", (object)yeuCau.QueQuan ?? DBNull.Value),
                new SqlParameter("@NgaySinh", (object)yeuCau.NgaySinh ?? DBNull.Value),
                new SqlParameter("@TrangThaiYeuCau", (object)yeuCau.TrangThaiYeuCau ?? "Chờ duyệt")
            };

            if (count > 0)
            {
                string updateSql = @"
                    UPDATE ChinhSuaGiaoVien SET
                        HoTen = @HoTen, GioiTinh = @GioiTinh, CCCD = @CCCD, Email = @Email,
                        DienThoai = @DienThoai, DanToc = @DanToc, TonGiao = @TonGiao,
                        LaDoanVien = @LaDangVien, NoiThuongTru = @NoiThuongTru, 
                        QueQuan = @QueQuan, NgaySinh = @NgaySinh,
                        TrangThaiYeuCau = @TrangThaiYeuCau
                    WHERE GiaoVienID = @GiaoVienID";
                return db.ExecuteNonQuery(updateSql, p);
            }
            else
            {
                string insertSql = @"
                    INSERT INTO ChinhSuaGiaoVien
                    (GiaoVienID, HoTen, GioiTinh, CCCD, Email, DienThoai, DanToc, TonGiao, 
                     LaDoanVien, NoiThuongTru, QueQuan, NgaySinh, TrangThaiYeuCau)
                    VALUES
                    (@GiaoVienID, @HoTen, @GioiTinh, @CCCD, @Email, @DienThoai, @DanToc, @TonGiao, 
                     @LaDangVien, @NoiThuongTru, @QueQuan, @NgaySinh, @TrangThaiYeuCau)";
                return db.ExecuteNonQuery(insertSql, p);
            }
        }
    }
}
