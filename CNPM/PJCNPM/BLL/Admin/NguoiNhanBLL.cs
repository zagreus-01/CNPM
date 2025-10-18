using System.Data;
using PJCNPM.DAL.Admin;

namespace PJCNPM.BLL.Admin
{
    internal class NguoiNhanBLL
    {
        private readonly NguoiNhanDAL dal = new NguoiNhanDAL();

        public DataTable LayHocSinh() => dal.LayDanhSachHocSinh();
        public DataTable LayGiaoVien() => dal.LayDanhSachGiaoVien();
        public DataTable LayLop() => dal.LayDanhSachLop();
    }
}
