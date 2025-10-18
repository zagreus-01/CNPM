using System.Data;
using PJCNPM.DAL.Admin;

namespace PJCNPM.BLL.Admin
{
    internal class HocBaAdminBLL
    {
        private readonly HocBaAdminDAL dal = new HocBaAdminDAL();

        public DataTable LayNamHocTheoHocSinh(int hocSinhID)
            => dal.LayNamHocTheoHocSinh(hocSinhID);

        public DataTable LayDiemTheoHocKy(int hocSinhID, int namHoc, int hocKy)
            => dal.LayDiemTheoHocKy(hocSinhID, namHoc, hocKy);

        public DataRow LayThongTinHocKy(int hocSinhID, int namHoc, int hocKy)
            => dal.LayThongTinHocKy(hocSinhID, namHoc, hocKy);
    }
}
