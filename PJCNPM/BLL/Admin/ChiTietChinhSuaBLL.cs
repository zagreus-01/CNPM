using System.Data;
using PJCNPM.DAL.Admin;

namespace PJCNPM.BLL.Admin
{
    internal class ChiTietChinhSuaBLL
    {
        private readonly ChiTietChinhSuaDAL dal = new ChiTietChinhSuaDAL();

        public DataTable LayChiTietYeuCau(string loai, int id)
        {
            return dal.LayChiTietYeuCau(loai, id);
        }
    }
}
