using PJCNPM.UI.Controls.HocSinhControls;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PJCNPM.UI.MainFrm
{
    public partial class HocSinh : Form
    {
        private bool isSidebarCollapsed = false;
        int maHS;
        public HocSinh(int maHS)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoadContent(new ThongBaoHocSinh(maHS)); // Mặc định load Thông tin cá nhân
            this.maHS = maHS;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebar.Width = isSidebarCollapsed ? 220 : 0;
            isSidebarCollapsed = !isSidebarCollapsed;
        }

        private void ResetSidebarButtons()
        {
            foreach (Control control in sidebar.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2Button btn && btn != btnLogout)
                {
                    btn.FillColor = Color.FromArgb(64, 64, 64);
                    btn.ForeColor = Color.White;
                }
            }

        }
        // 🧱 Hàm load 1 UserControl vào mainPanel
        private void LoadContent(UserControl control)
        {
            // Xóa control cũ
            mainPanel.Controls.Clear();

            // Căn chỉnh fill toàn panel
            control.Dock = DockStyle.Fill;

            // Thêm control mới vào panel
            mainPanel.Controls.Add(control);
        }


        private void HighlightButton(Guna.UI2.WinForms.Guna2Button button)
        {
            ResetSidebarButtons();
            button.FillColor = Color.FromArgb(0, 120, 215);
            button.ForeColor = Color.White;
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            HighlightButton(btnThongTinCaNhan);
            LoadContent(new ThongTinHocSinh(maHS));
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            HighlightButton(btnThongBao);
            LoadContent(new ThongBaoHocSinh(maHS));
        }
        private void btnDiemSo_Click(object sender, EventArgs e)
        {
            HighlightButton(btnDiemSo);
            LoadContent(new DiemSoHocSinh(maHS));
        }

        private void btnChinhSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            HighlightButton(btnChinhSuaTaiKhoan);
            LoadContent(new TaiKhoanHocSinh(maHS));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
