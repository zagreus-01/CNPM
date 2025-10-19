using System;
using System.Data;
using PJCNPM.DAL.Admin;

namespace PJCNPM.BLL.Admin
{
    public class ChuyenToanBoLopBLL
    {
        private readonly ChuyenToanBoLopDAL dal = new ChuyenToanBoLopDAL();

        public DataTable LayDanhSachLopHoatDong()
        {
            return dal.LayDanhSachLopHoatDong();
        }

        public DataTable LayTatCaLop()
        {
            return dal.LayTatCaLop();
        }

        public bool ChuyenToanBoHocSinh(int lopCuID, int lopMoiID, bool xoaDiem)
        {
            if (lopCuID <= 0 || lopMoiID <= 0)
                throw new ArgumentException("Lớp không hợp lệ!");

            if (lopCuID == lopMoiID)
                throw new ArgumentException("Lớp mới phải khác lớp cũ!");

            return dal.ChuyenToanBoHocSinh(lopCuID, lopMoiID, xoaDiem);
        }
    }
}
