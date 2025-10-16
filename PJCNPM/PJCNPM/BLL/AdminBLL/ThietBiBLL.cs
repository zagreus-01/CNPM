using PJCNPM.DAL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace PJCNPM.BLL.NhanVienBLL
{
    public class ThietBiBLL
    {
        private DBConnection db = new DBConnection();

        public DataTable GetAllThietBi()
        {
            return db.GetData("SELECT * FROM v_ThietBi");
        }
        public DataTable GetAllDonViTinh() 
        {
            string sql = @" SELECT DISTINCT DonViTinh FROM ThietBi WHERE DonViTinh IS NOT NULL AND DonViTinh <> ''"; 
            return db.GetData(sql); 
        }
        public bool InsertThietBi(string ten, string mota, int soluong, string donvi)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@Ten", ten),
                new SqlParameter("@MoTa", mota),
                new SqlParameter("@SoLuong", soluong),
                new SqlParameter("@DonViTinh", donvi)
            };
            return db.ExecuteNonQuery("sp_InsertThietBi", CommandType.StoredProcedure, p);
        }

        public bool UpdateThietBi(int id, string ten, string mota, int soluong, string donvi)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@ID", id),
                new SqlParameter("@Ten", ten),
                new SqlParameter("@MoTa", mota),
                new SqlParameter("@SoLuong", soluong),
                new SqlParameter("@DonViTinh", donvi)
            };
            return db.ExecuteNonQuery("sp_UpdateThietBi", CommandType.StoredProcedure, p);
        }

        public bool DeleteThietBi(int id)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@ID", id)
            };
            return db.ExecuteNonQuery("sp_DeleteThietBi", CommandType.StoredProcedure, p);
        }

        public DataTable SearchThietBi(string tenThietBi, string moTa, int? soLuong, string donViTinh)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@TenThietBi", string.IsNullOrWhiteSpace(tenThietBi) ? (object)DBNull.Value : tenThietBi),
                new SqlParameter("@MoTa", string.IsNullOrWhiteSpace(moTa) ? (object)DBNull.Value : moTa),
                new SqlParameter("@SoLuong", soLuong.HasValue ? (object)soLuong.Value : DBNull.Value),
                new SqlParameter("@DonViTinh", string.IsNullOrWhiteSpace(donViTinh) ? (object)DBNull.Value : donViTinh)
            };

            return db.GetData("sp_SearchThietBi", CommandType.StoredProcedure, p);
        }
    }
}
