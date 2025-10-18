using PJCNPM.DAL.Admin;
using System.Data;

namespace PJCNPM.BLL.Admin
{
    internal class SaveLopBLL
    {
        private readonly SaveLopDAL dal = new SaveLopDAL();

        public DataTable LayDanhSachLop(int? namHoc, int? hocKi, bool hienKetThuc, string keyword)
        {
            return dal.LayDanhSachLop(namHoc, hocKi, hienKetThuc, keyword);
        }

        public DataRow LayThongTinLop(int lopId)
        {
            return dal.LayThongTinLop(lopId);
        }

        public bool ThemLop(string tenLop, int namHoc, int hocKi, int khoiHoc, int? giaoVienId)
        {
            return dal.ThemLop(tenLop, namHoc, hocKi, khoiHoc, giaoVienId);
        }

        public bool CapNhatLop(int lopId, string tenLop, int namHoc, int hocKi, int khoiHoc, bool daKetThuc, int? giaoVienId)
        {
            return dal.CapNhatLop(lopId, tenLop, namHoc, hocKi, khoiHoc, daKetThuc, giaoVienId);
        }

        public bool XoaLop(int lopId)
        {
            return dal.XoaLop(lopId);
        }

        public DataTable LayDanhSachGiaoVienChuaChuNhiem()
        {
            return dal.LayDanhSachGiaoVienChuaChuNhiem();
        }

        public DataTable LayDanhSachGiaoVienToanBo()
        {
            return dal.LayDanhSachGiaoVienToanBo();
        }
    }
}
