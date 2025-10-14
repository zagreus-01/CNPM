namespace PJCNPM.UI.MainFrm
{
    partial class Admin
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel sidebar;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Panel header;

        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;

        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnHocSinh;
        private Guna.UI2.WinForms.Guna2Button btnGiaoVien;
        private Guna.UI2.WinForms.Guna2Button btnLopHoc;
        private Guna.UI2.WinForms.Guna2Button btnMonHoc;
        private Guna.UI2.WinForms.Guna2Button btnPhanCong;
        private Guna.UI2.WinForms.Guna2Button btnDiemSo;
        private Guna.UI2.WinForms.Guna2Button btnThongBao;
        private Guna.UI2.WinForms.Guna2Button btnXetDuyet;
        private Guna.UI2.WinForms.Guna2Button btnDanhSachTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btnTaiKhoanCaNhan;
        private Guna.UI2.WinForms.Guna2Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.sidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaiKhoanCaNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnDanhSachTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnXetDuyet = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongBao = new Guna.UI2.WinForms.Guna2Button();
            this.btnPhanCong = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonHoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnLopHoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnGiaoVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnDiemSo = new Guna.UI2.WinForms.Guna2Button();
            this.btnHocSinh = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();

            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.header = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();

            this.sidebar.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();

            // =========================
            // SIDEBAR
            // =========================
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.sidebar.Controls.Add(this.btnTaiKhoanCaNhan);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Controls.Add(this.btnDanhSachTaiKhoan);
            this.sidebar.Controls.Add(this.btnXetDuyet);
            this.sidebar.Controls.Add(this.btnThongBao);
            this.sidebar.Controls.Add(this.btnPhanCong);
            this.sidebar.Controls.Add(this.btnMonHoc);
            this.sidebar.Controls.Add(this.btnLopHoc);
            this.sidebar.Controls.Add(this.btnGiaoVien);
            this.sidebar.Controls.Add(this.btnDiemSo);
            this.sidebar.Controls.Add(this.btnHocSinh);
            this.sidebar.Controls.Add(this.btnHome);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 60);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(220, 681);
            this.sidebar.TabIndex = 0;

            // =========================
            // BUTTON STYLE TEMPLATE
            // =========================
            System.Drawing.Font btnFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Color btnColor = System.Drawing.Color.FromArgb(64, 64, 64);
            System.Drawing.Color textColor = System.Drawing.Color.White;

            // Trang chủ
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FillColor = btnColor;
            this.btnHome.Font = btnFont;
            this.btnHome.ForeColor = textColor;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.Size = new System.Drawing.Size(220, 45);
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);

            // Học sinh
            this.btnHocSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHocSinh.FillColor = btnColor;
            this.btnHocSinh.Font = btnFont;
            this.btnHocSinh.ForeColor = textColor;
            this.btnHocSinh.Text = "Học sinh";
            this.btnHocSinh.Size = new System.Drawing.Size(220, 45);
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);

            // Điểm số
            this.btnDiemSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiemSo.FillColor = btnColor;
            this.btnDiemSo.Font = btnFont;
            this.btnDiemSo.ForeColor = textColor;
            this.btnDiemSo.Text = "Điểm số";
            this.btnDiemSo.Size = new System.Drawing.Size(220, 45);
            this.btnDiemSo.Click += new System.EventHandler(this.btnDiemSo_Click);

            // Giáo viên
            this.btnGiaoVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGiaoVien.FillColor = btnColor;
            this.btnGiaoVien.Font = btnFont;
            this.btnGiaoVien.ForeColor = textColor;
            this.btnGiaoVien.Text = "Giáo viên";
            this.btnGiaoVien.Size = new System.Drawing.Size(220, 45);
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);

            // Lớp học
            this.btnLopHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLopHoc.FillColor = btnColor;
            this.btnLopHoc.Font = btnFont;
            this.btnLopHoc.ForeColor = textColor;
            this.btnLopHoc.Text = "Lớp học";
            this.btnLopHoc.Size = new System.Drawing.Size(220, 45);
            this.btnLopHoc.Click += new System.EventHandler(this.btnLopHoc_Click);

            // Môn học
            this.btnMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonHoc.FillColor = btnColor;
            this.btnMonHoc.Font = btnFont;
            this.btnMonHoc.ForeColor = textColor;
            this.btnMonHoc.Text = "Môn học";
            this.btnMonHoc.Size = new System.Drawing.Size(220, 45);
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);

            // Phân công
            this.btnPhanCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhanCong.FillColor = btnColor;
            this.btnPhanCong.Font = btnFont;
            this.btnPhanCong.ForeColor = textColor;
            this.btnPhanCong.Text = "Phân công";
            this.btnPhanCong.Size = new System.Drawing.Size(220, 45);
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);

            // Thông báo
            this.btnThongBao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongBao.FillColor = btnColor;
            this.btnThongBao.Font = btnFont;
            this.btnThongBao.ForeColor = textColor;
            this.btnThongBao.Text = "Thông báo";
            this.btnThongBao.Size = new System.Drawing.Size(220, 45);
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);

            // Xét duyệt
            this.btnXetDuyet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXetDuyet.FillColor = btnColor;
            this.btnXetDuyet.Font = btnFont;
            this.btnXetDuyet.ForeColor = textColor;
            this.btnXetDuyet.Text = "Xét duyệt yêu cầu";
            this.btnXetDuyet.Size = new System.Drawing.Size(220, 45);
            this.btnXetDuyet.Click += new System.EventHandler(this.btnXetDuyet_Click);

            // Danh sách tài khoản
            this.btnDanhSachTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhSachTaiKhoan.FillColor = btnColor;
            this.btnDanhSachTaiKhoan.Font = btnFont;
            this.btnDanhSachTaiKhoan.ForeColor = textColor;
            this.btnDanhSachTaiKhoan.Text = "Danh sách tài khoản";
            this.btnDanhSachTaiKhoan.Size = new System.Drawing.Size(220, 45);
            this.btnDanhSachTaiKhoan.Click += new System.EventHandler(this.btnDanhSachTaiKhoan_Click);

            // Tài khoản cá nhân
            this.btnTaiKhoanCaNhan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTaiKhoanCaNhan.FillColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnTaiKhoanCaNhan.Font = btnFont;
            this.btnTaiKhoanCaNhan.ForeColor = textColor;
            this.btnTaiKhoanCaNhan.Text = "Tài khoản cá nhân";
            this.btnTaiKhoanCaNhan.Size = new System.Drawing.Size(220, 45);
            this.btnTaiKhoanCaNhan.Click += new System.EventHandler(this.btnTaiKhoanCaNhan_Click);

            // Đăng xuất
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnLogout.Font = btnFont;
            this.btnLogout.ForeColor = textColor;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.Size = new System.Drawing.Size(220, 45);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // =========================
            // MAIN PANEL
            // =========================
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(220, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1106, 681);
            this.mainPanel.TabIndex = 1;

            // =========================
            // HEADER
            // =========================
            this.header.BackColor = System.Drawing.Color.FromArgb(30, 30, 35);
            this.header.Controls.Add(this.btnMenu);
            this.header.Controls.Add(this.lblTitle);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1326, 60);
            this.header.TabIndex = 2;

            // lblTitle
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(75, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(386, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ TRƯỜNG HỌC";

            // btnMenu
            this.btnMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::PJCNPM.Properties.Resources.icons8_menu_48;
            this.btnMenu.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMenu.Location = new System.Drawing.Point(12, 10);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(50, 40);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);

            // =========================
            // FORM
            // =========================
            this.ClientSize = new System.Drawing.Size(1326, 741);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.header);
            this.Name = "Admin";
            this.Text = "HỆ THỐNG QUẢN LÝ TRƯỜNG HỌC";

            this.sidebar.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
    }
}
