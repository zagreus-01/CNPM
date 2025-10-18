using System.Data;
using System.Data.SqlClient;

namespace PJCNPM.DAL.Admin
{
    internal class NguoiNhanDAL
    {
        private readonly DBConnection db = new DBConnection();

        // 🔹 Lấy danh sách tất cả học sinh (đang học)
        public DataTable LayDanhSachHocSinh()
        {
            string sql = @"
                SELECT HocSinhID AS Ma, HoTen + N' - ' + CAST(NamNhapHoc AS NVARCHAR(4)) AS Ten
                FROM HocSinh
                ORDER BY HoTen";
            return db.GetData(sql);
        }

        // 🔹 Lấy danh sách giáo viên
        public DataTable LayDanhSachGiaoVien()
        {
            string sql = @"
                SELECT GiaoVienID AS Ma, HoTen AS Ten
                FROM GiaoVien
                ORDER BY HoTen";
            return db.GetData(sql);
        }

        // 🔹 Lấy danh sách lớp đang hoạt động
        public DataTable LayDanhSachLop()
        {
            string sql = @"
                SELECT LopID AS Ma, TenLop AS Ten
                FROM Lop
                ORDER BY TenLop";
            return db.GetData(sql);
        }
    }
}
