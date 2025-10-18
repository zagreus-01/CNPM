using System;
using System.Data;
using System.Data.SqlClient;
using PJCNPM.DAL;

namespace PJCNPM.BLL.GiaoVien
{
    public class GiaoVienBLL
    {
        private readonly DBConnection db;

        public GiaoVienBLL()
        {
            db = new DBConnection();
        }

        // Lớp DTO chứa thông tin giáo viên
        public class GiaoVienInfo
        {
            public int GiaoVienID { get; set; }
            public string HoTen { get; set; }
            public bool? GioiTinh { get; set; } // false: Nam, true: Nữ
            public string CCCD { get; set; }
            public string Email { get; set; }
            public string DienThoai { get; set; }
            public string DanToc { get; set; }
            public string TonGiao { get; set; }
            public bool? LaDangVien { get; set; } // Thay thế LaDoanVien, LoaiDoanVien
            public string NoiThuongTru { get; set; }
            public string QueQuan { get; set; }
            public DateTime? NgaySinh { get; set; }
            public byte? TrangThai { get; set; }
            public string TenTK { get; set; }
        }

        // 🔹 Lấy thông tin giáo viên theo tên tài khoản
        public GiaoVienInfo GetThongTinGiaoVienByTenTK(string tenTK)
        {
            string sql = @"
                SELECT GiaoVienID, HoTen, GioiTinh, CCCD, Email, DienThoai,
                       DanToc, TonGiao, LaDangVien, NoiThuongTru,
                       QueQuan, NgaySinh, TrangThai, TenTK
                FROM GiaoVien
                WHERE TenTK = @TenTK";

            var param = new SqlParameter("@TenTK", tenTK ?? (object)DBNull.Value);
            DataTable dt = db.GetData(sql, new SqlParameter[] { param });

            if (dt == null || dt.Rows.Count == 0)
                return null;

            var row = dt.Rows[0];
            return new GiaoVienInfo
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
                TrangThai = row["TrangThai"] == DBNull.Value ? (byte?)null : Convert.ToByte(row["TrangThai"]),
                TenTK = row["TenTK"] as string
            };
        }
        // 🔹 Lấy thông tin giáo viên theo ID
        public GiaoVienInfo GetThongTinGiaoVienByID(int giaoVienID)
        {
            string sql = @"
                SELECT GiaoVienID, HoTen, GioiTinh, CCCD, Email, DienThoai,
                       DanToc, TonGiao, LaDangVien, NoiThuongTru,
                       QueQuan, NgaySinh, TrangThai, TenTK
                FROM GiaoVien
                WHERE GiaoVienID = @GiaoVienID";

            var param = new SqlParameter("@GiaoVienID", giaoVienID);
            DataTable dt = db.GetData(sql, new SqlParameter[] { param });

            if (dt == null || dt.Rows.Count == 0)
                return null;

            var row = dt.Rows[0];
            return new GiaoVienInfo
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
                TrangThai = row["TrangThai"] == DBNull.Value ? (byte?)null : Convert.ToByte(row["TrangThai"]),
                TenTK = row["TenTK"] as string
            };
        }
    }
}
