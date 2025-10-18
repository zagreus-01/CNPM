using System.Data;
using PJCNPM.DAL.HocSinh;

namespace PJCNPM.BLL.HocSinh
{
    internal class ThongBaoHocSinhBLL
    {
        private readonly ThongBaoHocSinhDAL dal = new ThongBaoHocSinhDAL();
        private readonly int hocSinhID;

        public ThongBaoHocSinhBLL(int maHocSinh)
        {
            hocSinhID = maHocSinh;
        }

        // 🔹 Lấy danh sách thông báo
        public DataTable LayDanhSachThongBao()
        {
            return dal.LayDanhSachThongBao(hocSinhID);
        }
    }
}
