using PJCNPM.UI.Controls; // Thư mục chứa các UserControl chức năng
using PJCNPM.UI.Controls.HocSinhControls;
using System;
using System.Drawing;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;
using PJCNPM.UI.Controls.AdminControls;

namespace PJCNPM.UI.MainFrm
{
    public partial class Admin : Form
    {
        private bool isSidebarCollapsed = false;
        private Guna.UI2.WinForms.Guna2Button currentButton = null;
        private UserControl currentControl = null;

        public Admin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            HighlightButton(btnHome);
        }

        // ============================================
        // 🔹 Helper: Load UserControl vào mainPanel
        // ============================================
        private void LoadControl(UserControl control)
        {
            try
            {
                mainPanel.Controls.Clear();
                control.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(control);
                currentControl = control;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chức năng: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================
        // 🎨 Reset màu tất cả nút trong sidebar
        // ============================================
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

        // ============================================
        // 🎨 Làm nổi bật nút đang chọn
        // ============================================
        private void HighlightButton(Guna.UI2.WinForms.Guna2Button button)
        {
            ResetSidebarButtons();
            button.FillColor = Color.FromArgb(0, 120, 215); // xanh lam nổi bật
            button.ForeColor = Color.White;
            currentButton = button;
        }

        // ============================================
        // 📘 Sự kiện click từng nút
        // ============================================
        private void btnHome_Click(object sender, EventArgs e)
        {
            HighlightButton(btnHome);
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            HighlightButton(btnHocSinh);
            LoadControl(new HocSinhAdmin());
        }

        private void btnDiemSo_Click(object sender, EventArgs e)
        {
            HighlightButton(btnDiemSo);
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            HighlightButton(btnGiaoVien);
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            HighlightButton(btnLopHoc);
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            HighlightButton(btnMonHoc);
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            HighlightButton(btnPhanCong);
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            HighlightButton(btnThongBao);
            LoadControl(new ThongBaoAdmin());
        }

        private void btnXetDuyet_Click(object sender, EventArgs e)
        {
            HighlightButton(btnXetDuyet);
            LoadControl(new XetDuyetAdmin());
        }

        private void btnDanhSachTaiKhoan_Click(object sender, EventArgs e)
        {
            HighlightButton(btnDanhSachTaiKhoan);
        }

        private void btnTaiKhoanCaNhan_Click(object sender, EventArgs e)
        {
            HighlightButton(btnTaiKhoanCaNhan);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // ============================================
        // 📁 Nút thu gọn sidebar
        // ============================================
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (isSidebarCollapsed)
            {
                sidebar.Width = 220;
                isSidebarCollapsed = false;
            }
            else
            {
                sidebar.Width = 0;
                isSidebarCollapsed = true;
            }
        }
    }
}
