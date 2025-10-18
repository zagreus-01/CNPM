using PJCNPM.DAL.HocSinh;
using System;
using System.Data;

namespace PJCNPM.BLL.HocSinh
{
    public class TaiKhoanHocSinhBLL
    {
        private readonly TaiKhoanDAL dal = new TaiKhoanDAL();

        // 🔹 Lấy thông tin tài khoản học sinh
        public (string HoTen, string TenDangNhap, string MatKhau) GetTaiKhoanHocSinh(int hocSinhID)
        {
            DataTable dt = dal.LayTaiKhoanHocSinh(hocSinhID);
            if (dt.Rows.Count == 0)
                return ("", "", "");
            DataRow r = dt.Rows[0];
            return (r["HoTen"].ToString(), r["TenTK"].ToString(), r["MatKhau"].ToString());
        }

        // 🔹 Cập nhật mật khẩu
        public bool DoiMatKhau(string tenTK, string matKhauMoi)
        {
            return dal.DoiMatKhau(tenTK, matKhauMoi);
        }
    }
}
