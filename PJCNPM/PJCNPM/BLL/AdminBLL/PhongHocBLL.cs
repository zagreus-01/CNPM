using PJCNPM.DAL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace PJCNPM.BLL.NhanVienBLL
{
    public class PhongHocBLL
    {
        private DBConnection db = new DBConnection();

        public DataTable GetAllPhongHoc()
        {
            return db.GetData("SELECT * FROM v_PhongHoc");
        }

        public bool InsertPhongHoc(string ten, int loai, int succhua, int trangthai)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@Ten", ten),
                new SqlParameter("@LoaiPhong", loai),
                new SqlParameter("@SucChua", succhua),
                new SqlParameter("@TrangThai", trangthai)
            };
            return db.ExecuteNonQuery("sp_InsertPhongHoc", CommandType.StoredProcedure, p);
        }

        public bool UpdatePhongHoc(int id, string ten, int loai, int succhua, int trangthai)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@ID", id),
                new SqlParameter("@Ten", ten),
                new SqlParameter("@LoaiPhong", loai),
                new SqlParameter("@SucChua", succhua),
                new SqlParameter("@TrangThai", trangthai)
            };
            return db.ExecuteNonQuery("sp_UpdatePhongHoc", CommandType.StoredProcedure, p);
        }

        public bool DeletePhongHoc(int id)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@ID", id)
            };
            return db.ExecuteNonQuery("sp_DeletePhongHoc", CommandType.StoredProcedure, p);
        }

        public DataTable SearchPhongHoc(string keyword, int? loaiPhong, int? trangThai, int? sucChua)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@Keyword", string.IsNullOrWhiteSpace(keyword) ? (object)DBNull.Value : keyword),
                new SqlParameter("@LoaiPhong", loaiPhong.HasValue ? (object)loaiPhong.Value : DBNull.Value),
                new SqlParameter("@TrangThai", trangThai.HasValue ? (object)trangThai.Value : DBNull.Value),
                new SqlParameter("@SucChua", sucChua.HasValue ? (object)sucChua.Value : DBNull.Value)

            };

            return db.GetData("sp_SearchPhongHoc", CommandType.StoredProcedure, p);
        }

    }
}
