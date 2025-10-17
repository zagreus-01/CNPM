using PJCNPM.DAL.Admin;
using System;
using System.Collections.Generic;
using System.Data;

namespace PJCNPM.BLL.Admin
{
    internal class LopHocBLL
    {
        private readonly LopHocDAL dal = new LopHocDAL();

        public DataTable LayDanhSachLop(int? namHoc, int? hocKi, bool hienKetThuc, string keyword)
        {
            return dal.LayDanhSachLop(namHoc, hocKi, hienKetThuc, keyword);
        }

        public List<int> LayDanhSachNamHoc()
        {
            
            DataTable dt = dal.LayDanhSachNamHoc(); 
            List<int> list = new List<int>();
            foreach (DataRow row in dt.Rows)
                list.Add(Convert.ToInt32(row["NamHoc"]));
            return list;
        }

        public bool ThemLop(string tenLop, int namHoc, int hocKi, int khoiHoc, int giaoVienID)
        {
            return dal.ThemLop(tenLop, namHoc, hocKi, khoiHoc, giaoVienID);
        }

        public bool CapNhatLop(int lopId, string tenLop, int namHoc, int hocKi, int khoiHoc, bool daKetThuc, int giaoVienID)
        {
            return dal.CapNhatLop(lopId, tenLop, namHoc, hocKi, khoiHoc, daKetThuc, giaoVienID);
        }

        public bool XoaLop(int lopId)
        {
            return dal.XoaLop(lopId);
        }
    }
}
