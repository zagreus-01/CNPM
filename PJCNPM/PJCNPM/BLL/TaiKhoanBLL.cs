using System.Data;
using PJCNPM.DAL;

namespace PJCNPM.BLL
{
    internal class TaiKhoanBLL
    {
        private readonly TaiKhoanDAL dal = new TaiKhoanDAL();

        public (int RoleID, string RoleName, DataRow Info) DangNhap(string username, string password)
        {
            DataTable dt = dal.KiemTraDangNhap(username, password);
            if (dt == null || dt.Rows.Count == 0)
                return (0, null, null);

            DataRow tk = dt.Rows[0];
            int roleID = (int)tk["RoleID"];
            string roleName = tk["RoleName"].ToString();
            DataRow info = null;

            switch (roleID)
            {
                case 2: // Giáo viên
                    info = dal.LayThongTinGiaoVien(username);
                    break;
                case 3: // Học sinh
                    info = dal.LayThongTinHocSinh(username);
                    break;
                default:
                    info = tk; // Admin
                    break;
            }

            return (roleID, roleName, info);
        }
    }
}
