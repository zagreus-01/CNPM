using PJCNPM.UI.Control.ControlNhanVien;
using PJCNPM.UI.Controls.NhanVienControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsControl = System.Windows.Forms.Control;

namespace PJCNPM.UI.MainFrm
{
    public partial class Admin : Form
    {
        private bool isSidebarCollapsed = false;

        public Admin()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.AllPaintingInWmPaint |
              ControlStyles.UserPaint, true);
            this.UpdateStyles();
            this.WindowState = FormWindowState.Maximized;
            LoadContent(new QuanLyThietBi());

        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebar.Width = isSidebarCollapsed ? 220 : 0;
            isSidebarCollapsed = !isSidebarCollapsed;
        }

        private void ResetSidebarButtons()
        {
            foreach (WinFormsControl control in sidebar.Controls)
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
            foreach (WinFormsControl c in mainPanel.Controls)
                c.Dispose();

            mainPanel.Controls.Clear();

            control.Dock = DockStyle.Fill;

            // ✅ Bật double buffering an toàn cho mọi loại control
            EnableDoubleBuffering(control);

            mainPanel.Controls.Add(control);
            control.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void HighlightButton(Guna.UI2.WinForms.Guna2Button button)
        {
            ResetSidebarButtons();
            button.FillColor = Color.FromArgb(0, 120, 215);
            button.ForeColor = Color.White;
        }

        private void btnQuanLyThietBi_Click(object sender, EventArgs e)
        {
            HighlightButton(btnQuanLyThietBi);
            LoadContent(new QuanLyThietBi());
        }

        private void btnQuanLyPhongHoc_Click(object sender, EventArgs e)
        {
            HighlightButton(btnQuanLyPhongHoc);
            LoadContent(new QuanLyPhongHoc());
        }
        private void btnThietBiPhong_Click(object sender, EventArgs e)
        {
            HighlightButton(btnThietBiPhong);
            LoadContent(new ThietBiPhong());
        }
        private void EnableDoubleBuffering(WinFormsControl control)
        {
            System.Reflection.PropertyInfo prop =
                typeof(WinFormsControl).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            prop.SetValue(control, true, null);
        }

    }
}
