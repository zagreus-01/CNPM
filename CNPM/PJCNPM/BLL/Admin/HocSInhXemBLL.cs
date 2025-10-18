using System.Data;
using PJCNPM.DAL.Admin;

namespace PJCNPM.BLL.Admin
{
    internal class HocSinhXemBLL
    {
        private readonly HocSinhXemDAL dal = new HocSinhXemDAL();

        public DataRow LayThongTinHocSinh(int hocSinhID)
        {
            return dal.LayThongTinHocSinh(hocSinhID);
        }
    }
}
