using System;
using System.Data;
using PJCNPM.DAL.Admin;

namespace PJCNPM.BLL.Admin
{
    internal class ThongBaoBLL
    {
        private readonly ThongBaoDAL dal = new ThongBaoDAL();

        // 🔹 Lấy danh sách thông báo
        public DataTable LayTatCaThongBao()
        {
            return dal.LayTatCaThongBao();
        }

        // 🔹 Gửi thông báo
        public bool GuiThongBao(
            string nguoiGuiID,
            int loaiNguoiGui,
            int loaiNguoiNhan,
            string nguoiNhanID,
            string tieuDe,
            string noiDung)
        {
            if (string.IsNullOrWhiteSpace(tieuDe) || string.IsNullOrWhiteSpace(noiDung))
                throw new ArgumentException("Tiêu đề và nội dung không được để trống.");

            return dal.GuiThongBao(nguoiGuiID, loaiNguoiGui, tieuDe, noiDung, loaiNguoiNhan, nguoiNhanID);
        }
    }
}
