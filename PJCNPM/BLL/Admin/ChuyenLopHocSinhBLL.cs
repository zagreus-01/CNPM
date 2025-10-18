using System;
using System.Data;
using PJCNPM.DAL.Admin;

namespace PJCNPM.BLL.Admin
{
    internal class ChuyenLopHocSinhBLL
    {
        private readonly ChuyenLopHocSinhDAL dal = new ChuyenLopHocSinhDAL();

        public (DataRow hs, DataRow lopCu) LayThongTinHienTai(int hocSinhID)
        {
            return (dal.LayThongTinHocSinh(hocSinhID), dal.LayLopHienTai(hocSinhID));
        }

        public DataTable LayDanhSachLopHoatDong()
        {
            return dal.LayDanhSachLopHoatDong();
        }

        public DataRow LayLopTheoID(int lopID)
        {
            return dal.LayLopTheoID(lopID);
        }

        public string KiemTraQuyTac(DataRow lopCu, DataRow lopMoi)
        {
            if (lopCu == null || lopMoi == null)
                return string.Empty;

            int lopCuID = Convert.ToInt32(lopCu["LopID"]);
            int lopMoiID = Convert.ToInt32(lopMoi["LopID"]);
            int namCu = Convert.ToInt32(lopCu["NamHoc"]);
            int hkCu = Convert.ToInt32(lopCu["HocKi"]);
            int namMoi = Convert.ToInt32(lopMoi["NamHoc"]);
            int hkMoi = Convert.ToInt32(lopMoi["HocKi"]);

            if (lopCuID == lopMoiID)
                return "Không thể chuyển sang chính lớp hiện tại.";
            if (namMoi == namCu && hkMoi == hkCu)
                return "Cùng năm, cùng học kỳ, khác lớp → bắt buộc xóa điểm.";
            return "Khác học kỳ hoặc năm học → có thể giữ điểm.";
        }

        public bool ChuyenLop(int hocSinhID, int lopMoiID, bool xoaDiem)
        {
            var (_, lopCu) = LayThongTinHienTai(hocSinhID);
            if (lopCu == null)
                return dal.ChuyenLop(hocSinhID, 0, lopMoiID, xoaDiem); // Nếu học sinh chưa có lớp cũ

            int lopCuID = Convert.ToInt32(lopCu["LopID"]);
            return dal.ChuyenLop(hocSinhID, lopCuID, lopMoiID, xoaDiem);
        }
    }
}
