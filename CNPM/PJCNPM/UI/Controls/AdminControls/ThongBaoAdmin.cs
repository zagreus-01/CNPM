using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using PJCNPM.BLL.Admin;
using PJCNPM.UI.PopUpFrm.AdminPopUp;

namespace PJCNPM.UI.Controls.AdminControls
{
    public partial class ThongBaoAdmin : UserControl
    {
        private readonly ThongBaoBLL bll = new ThongBaoBLL();

        public ThongBaoAdmin()
        {
            InitializeComponent();
            LoadThongBao();
        }

        private void LoadThongBao()
        {
            DataTable dt = bll.LayTatCaThongBao();
            dgvThongBao.DataSource = dt;

            if (dgvThongBao.Columns.Contains("ThongBaoID"))
                dgvThongBao.Columns["ThongBaoID"].Visible = false;

            dgvThongBao.Columns["TieuDe"].HeaderText = "Tiêu đề";
            dgvThongBao.Columns["NoiDung"].HeaderText = "Nội dung";
            dgvThongBao.Columns["NguoiNhan"].HeaderText = "Người nhận";
            dgvThongBao.Columns["NgayGui"].HeaderText = "Ngày gửi";
            dgvThongBao.Columns["NgayGui"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }

        private void btnGuiThongBao_Click(object sender, EventArgs e)
        {
            FrmThongBaoAdmin frm = new FrmThongBaoAdmin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                bool ok = bll.GuiThongBao(
                    nguoiGuiID: "admin01",
                    loaiNguoiGui: 1, // Admin
                    loaiNguoiNhan: frm.LoaiNguoiNhanInt,
                    nguoiNhanID: frm.NguoiNhanID,
                    tieuDe: frm.TieuDe,
                    noiDung: frm.NoiDung
                );

                if (ok)
                {
                    MessageBox.Show("✅ Gửi thông báo thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThongBao();
                }
                else
                {
                    MessageBox.Show("❌ Gửi thông báo thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadThongBao();
        }
    }
}
