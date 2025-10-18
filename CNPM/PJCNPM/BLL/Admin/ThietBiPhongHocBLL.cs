using PJCNPM.DAL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace PJCNPM.BLL.Admin
{
    public class ThietBiPhongHocBLL
    {
        private DBConnection db = new DBConnection();

        public DataTable GetAll()
        {
            return db.GetData("SELECT * FROM v_ThietBiPhongHoc");
        }

        public bool Insert(int phongHocID, int thietBiID, int soLuong)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@PhongHocID", phongHocID),
                new SqlParameter("@ThietBiID", thietBiID),
                new SqlParameter("@SoLuong", soLuong)
            };
            return db.ExecuteNonQuery("sp_InsertThietBiPhongHoc", CommandType.StoredProcedure, p);
        }

        public bool Update(int phongHocID, int thietBiID, int soLuong)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@PhongHocID", phongHocID),
                new SqlParameter("@ThietBiID", thietBiID),
                new SqlParameter("@SoLuong", soLuong)
            };
            return db.ExecuteNonQuery("sp_UpdateThietBiPhongHoc", CommandType.StoredProcedure, p);
        }

        public bool Delete(int phongHocID, int thietBiID)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@PhongHocID", phongHocID),
                new SqlParameter("@ThietBiID", thietBiID)
            };
            return db.ExecuteNonQuery("sp_DeleteThietBiPhongHoc", CommandType.StoredProcedure, p);
        }


        // Tìm theo Tên phòng, Thiết bị hoặc Đơn vị tính
        public DataTable Search(string tenThietBi, string tenPhong, int? soLuong)
        {
            SqlParameter[] p = new SqlParameter[]
            {
        new SqlParameter("@TenThietBi", string.IsNullOrWhiteSpace(tenThietBi) ? (object)DBNull.Value : tenThietBi),
        new SqlParameter("@TenPhong", string.IsNullOrWhiteSpace(tenPhong) ? (object)DBNull.Value : tenPhong),
        new SqlParameter("@SoLuong", soLuong.HasValue ? (object)soLuong.Value : DBNull.Value)
            };

            return db.GetData("sp_SearchThietBiPhongHoc", CommandType.StoredProcedure, p);
        }
        public DataTable GetTonKhoThietBi()
        {
            string sql = "SELECT TenThietBi, TongSoLuong, DaPhanBo, ConLai, DonViTinh FROM v_TonKhoThietBi ORDER BY TenThietBi";
            return db.GetData(sql);
        }


        public DataTable GetPhongList()
        {
            return db.GetData("SELECT PhongHocID, TenPhong FROM PhongHoc");
        }

        public DataTable GetThietBiList()
        {
            return db.GetData("SELECT ThietBiID, TenThietBi FROM ThietBi");
        }
    }
}
