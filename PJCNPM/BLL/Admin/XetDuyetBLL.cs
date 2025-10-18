using System.Data;
using PJCNPM.DAL.Admin;

namespace PJCNPM.BLL.Admin
{
    internal class XetDuyetBLL
    {
        private readonly XetDuyetDAL dal = new XetDuyetDAL();

        public DataTable LayBangYeuCau(string loai)
        {
            return loai == "Học sinh"
                ? dal.LayYeuCauChinhSuaHocSinh()
                : dal.LayYeuCauChinhSuaGiaoVien();
        }

        public bool CapNhatTrangThai(string loai, int id, string trangThai)
        {
            return dal.CapNhatTrangThai(loai, id, trangThai);
        }
    }
}
