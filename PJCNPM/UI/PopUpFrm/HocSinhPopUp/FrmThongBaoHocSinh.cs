using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.PopUpFrm.HocSinhPopUp
{
    public partial class FrmThongBaoHocSinh : Form
    {
        public FrmThongBaoHocSinh(string tieuDe, string noiDung, string nguoiGui, DateTime ngayGui)
        {
            InitializeComponent();

            // Gán dữ liệu
            lblTieuDe.Text = tieuDe;
            lblNoiDung.Text = noiDung.Replace("\n", "<br>");
            lblNguoiGui.Text = $"Người gửi: {nguoiGui}";
            lblNgayGui.Text = $"Ngày gửi: {ngayGui:dd/MM/yyyy}";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hiệu ứng fade-in khi mở form
        private void FrmThongBaoHocSinh_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Timer fadeTimer = new Timer();
            fadeTimer.Interval = 15;
            fadeTimer.Tick += (s, ev) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.05;
                else
                    fadeTimer.Stop();
            };
            fadeTimer.Start();
        }
    }
}
