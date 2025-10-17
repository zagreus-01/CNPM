using System.Windows.Media;

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
        private Guna.UI2.WinForms.Guna2Button btnThietBiPhong;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyPhongHoc;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyThietBi;
        private Guna.UI2.WinForms.Guna2Button btnTKB;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.btnThietBiPhong = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLyPhongHoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLyThietBi = new Guna.UI2.WinForms.Guna2Button();
            this.sidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTaiKhoanCaNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnDanhSachTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnXetDuyet = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongBao = new Guna.UI2.WinForms.Guna2Button();
            this.btnTKB = new Guna.UI2.WinForms.Guna2Button();
            this.btnPhanCong = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonHoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnLopHoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnGiaoVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnDiemSo = new Guna.UI2.WinForms.Guna2Button();
            this.btnHocSinh = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.header = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sidebar.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThietBiPhong
            // 
            this.btnThietBiPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThietBiPhong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThietBiPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThietBiPhong.ForeColor = System.Drawing.Color.White;
            this.btnThietBiPhong.Location = new System.Drawing.Point(0, 450);
            this.btnThietBiPhong.Name = "btnThietBiPhong";
            this.btnThietBiPhong.Size = new System.Drawing.Size(220, 45);
            this.btnThietBiPhong.TabIndex = 1;
            this.btnThietBiPhong.Text = "Thiết bị theo phòng";
            this.btnThietBiPhong.Click += new System.EventHandler(this.btnThietBiPhong_Click);
            // 
            // btnQuanLyPhongHoc
            // 
            this.btnQuanLyPhongHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyPhongHoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQuanLyPhongHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuanLyPhongHoc.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyPhongHoc.Location = new System.Drawing.Point(0, 405);
            this.btnQuanLyPhongHoc.Name = "btnQuanLyPhongHoc";
            this.btnQuanLyPhongHoc.Size = new System.Drawing.Size(220, 45);
            this.btnQuanLyPhongHoc.TabIndex = 3;
            this.btnQuanLyPhongHoc.Text = "Quản lý phòng học";
            this.btnQuanLyPhongHoc.Click += new System.EventHandler(this.btnQuanLyPhongHoc_Click);
            // 
            // btnQuanLyThietBi
            // 
            this.btnQuanLyThietBi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyThietBi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQuanLyThietBi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuanLyThietBi.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyThietBi.Location = new System.Drawing.Point(0, 360);
            this.btnQuanLyThietBi.Name = "btnQuanLyThietBi";
            this.btnQuanLyThietBi.Size = new System.Drawing.Size(220, 45);
            this.btnQuanLyThietBi.TabIndex = 4;
            this.btnQuanLyThietBi.Text = "Quản lý thiết bị";
            this.btnQuanLyThietBi.Click += new System.EventHandler(this.btnQuanLyThietBi_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.sidebar.Controls.Add(this.btnTaiKhoanCaNhan);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Controls.Add(this.btnDanhSachTaiKhoan);
            this.sidebar.Controls.Add(this.btnXetDuyet);
            this.sidebar.Controls.Add(this.btnThongBao);
            this.sidebar.Controls.Add(this.btnThietBiPhong);
            this.sidebar.Controls.Add(this.btnQuanLyPhongHoc);
            this.sidebar.Controls.Add(this.btnQuanLyThietBi);
            this.sidebar.Controls.Add(this.btnTKB);
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
            // 
            // btnTaiKhoanCaNhan
            // 
            this.btnTaiKhoanCaNhan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTaiKhoanCaNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnTaiKhoanCaNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaiKhoanCaNhan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoanCaNhan.Location = new System.Drawing.Point(0, 591);
            this.btnTaiKhoanCaNhan.Name = "btnTaiKhoanCaNhan";
            this.btnTaiKhoanCaNhan.Size = new System.Drawing.Size(220, 45);
            this.btnTaiKhoanCaNhan.TabIndex = 0;
            this.btnTaiKhoanCaNhan.Text = "Tài khoản cá nhân";
            this.btnTaiKhoanCaNhan.Click += new System.EventHandler(this.btnTaiKhoanCaNhan_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 636);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 45);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDanhSachTaiKhoan
            // 
            this.btnDanhSachTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhSachTaiKhoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDanhSachTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDanhSachTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnDanhSachTaiKhoan.Location = new System.Drawing.Point(0, 585);
            this.btnDanhSachTaiKhoan.Name = "btnDanhSachTaiKhoan";
            this.btnDanhSachTaiKhoan.Size = new System.Drawing.Size(220, 45);
            this.btnDanhSachTaiKhoan.TabIndex = 2;
            this.btnDanhSachTaiKhoan.Text = "Danh sách tài khoản";
            this.btnDanhSachTaiKhoan.Click += new System.EventHandler(this.btnDanhSachTaiKhoan_Click);
            // 
            // btnXetDuyet
            // 
            this.btnXetDuyet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXetDuyet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXetDuyet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXetDuyet.ForeColor = System.Drawing.Color.White;
            this.btnXetDuyet.Location = new System.Drawing.Point(0, 540);
            this.btnXetDuyet.Name = "btnXetDuyet";
            this.btnXetDuyet.Size = new System.Drawing.Size(220, 45);
            this.btnXetDuyet.TabIndex = 3;
            this.btnXetDuyet.Text = "Xét duyệt yêu cầu";
            this.btnXetDuyet.Click += new System.EventHandler(this.btnXetDuyet_Click);
            // 
            // btnThongBao
            // 
            this.btnThongBao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongBao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThongBao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThongBao.ForeColor = System.Drawing.Color.White;
            this.btnThongBao.Location = new System.Drawing.Point(0, 495);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(220, 45);
            this.btnThongBao.TabIndex = 4;
            this.btnThongBao.Text = "Thông báo";
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
            // 
            // btnTKB
            // 
            this.btnTKB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTKB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTKB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTKB.ForeColor = System.Drawing.Color.White;
            this.btnTKB.Location = new System.Drawing.Point(0, 315);
            this.btnTKB.Name = "btnTKB";
            this.btnTKB.Size = new System.Drawing.Size(220, 45);
            this.btnTKB.TabIndex = 5;
            this.btnTKB.Text = "Thời khóa biểu";
            this.btnTKB.Click += new System.EventHandler(this.btnTKB_Click);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhanCong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPhanCong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPhanCong.ForeColor = System.Drawing.Color.White;
            this.btnPhanCong.Location = new System.Drawing.Point(0, 270);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(220, 45);
            this.btnPhanCong.TabIndex = 5;
            this.btnPhanCong.Text = "Phân công";
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonHoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMonHoc.ForeColor = System.Drawing.Color.White;
            this.btnMonHoc.Location = new System.Drawing.Point(0, 225);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Size = new System.Drawing.Size(220, 45);
            this.btnMonHoc.TabIndex = 6;
            this.btnMonHoc.Text = "Môn học";
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLopHoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLopHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLopHoc.ForeColor = System.Drawing.Color.White;
            this.btnLopHoc.Location = new System.Drawing.Point(0, 180);
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.Size = new System.Drawing.Size(220, 45);
            this.btnLopHoc.TabIndex = 7;
            this.btnLopHoc.Text = "Lớp học";
            this.btnLopHoc.Click += new System.EventHandler(this.btnLopHoc_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGiaoVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGiaoVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGiaoVien.ForeColor = System.Drawing.Color.White;
            this.btnGiaoVien.Location = new System.Drawing.Point(0, 135);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(220, 45);
            this.btnGiaoVien.TabIndex = 8;
            this.btnGiaoVien.Text = "Giáo viên";
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // btnDiemSo
            // 
            this.btnDiemSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiemSo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDiemSo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDiemSo.ForeColor = System.Drawing.Color.White;
            this.btnDiemSo.Location = new System.Drawing.Point(0, 90);
            this.btnDiemSo.Name = "btnDiemSo";
            this.btnDiemSo.Size = new System.Drawing.Size(220, 45);
            this.btnDiemSo.TabIndex = 9;
            this.btnDiemSo.Text = "Điểm số";
            this.btnDiemSo.Click += new System.EventHandler(this.btnDiemSo_Click);
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHocSinh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHocSinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHocSinh.ForeColor = System.Drawing.Color.White;
            this.btnHocSinh.Location = new System.Drawing.Point(0, 45);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(220, 45);
            this.btnHocSinh.TabIndex = 10;
            this.btnHocSinh.Text = "Học sinh";
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(220, 45);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(220, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1106, 681);
            this.mainPanel.TabIndex = 1;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.header.Controls.Add(this.btnMenu);
            this.header.Controls.Add(this.lblTitle);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1326, 60);
            this.header.TabIndex = 2;
            // 
            // btnMenu
            // 
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
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(75, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(386, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ TRƯỜNG HỌC";
            // 
            // Admin
            // 
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
