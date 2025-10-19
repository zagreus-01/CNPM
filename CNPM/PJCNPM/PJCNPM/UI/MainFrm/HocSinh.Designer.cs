namespace PJCNPM.UI.MainFrm
{
    partial class HocSinh
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel sidebar;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Panel header;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;

        private Guna.UI2.WinForms.Guna2Button btnThongTinCaNhan;
        private Guna.UI2.WinForms.Guna2Button btnThongBao;
        private Guna.UI2.WinForms.Guna2Button btnDiemSo;
        private Guna.UI2.WinForms.Guna2Button btnChinhSuaTaiKhoan;
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
            this.btnChinhSuaTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnDiemSo = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongBao = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongTinCaNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.header = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.sidebar.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.sidebar.Controls.Add(this.btnChinhSuaTaiKhoan);
            this.sidebar.Controls.Add(this.btnDiemSo);
            this.sidebar.Controls.Add(this.btnThongBao);
            this.sidebar.Controls.Add(this.btnThongTinCaNhan);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 60);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(220, 681);
            this.sidebar.TabIndex = 0;
            // 
            // btnChinhSuaTaiKhoan
            // 
            this.btnChinhSuaTaiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChinhSuaTaiKhoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChinhSuaTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChinhSuaTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnChinhSuaTaiKhoan.Location = new System.Drawing.Point(0, 135);
            this.btnChinhSuaTaiKhoan.Name = "btnChinhSuaTaiKhoan";
            this.btnChinhSuaTaiKhoan.Size = new System.Drawing.Size(220, 45);
            this.btnChinhSuaTaiKhoan.TabIndex = 0;
            this.btnChinhSuaTaiKhoan.Text = "Tài khoản";
            this.btnChinhSuaTaiKhoan.Click += new System.EventHandler(this.btnChinhSuaTaiKhoan_Click);
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
            this.btnDiemSo.TabIndex = 1;
            this.btnDiemSo.Text = "Điểm số";
            this.btnDiemSo.Click += new System.EventHandler(this.btnDiemSo_Click);
            // 
            // btnThongBao
            // 
            this.btnThongBao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongBao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThongBao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThongBao.ForeColor = System.Drawing.Color.White;
            this.btnThongBao.Location = new System.Drawing.Point(0, 45);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(220, 45);
            this.btnThongBao.TabIndex = 3;
            this.btnThongBao.Text = "Thông báo";
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongTinCaNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThongTinCaNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThongTinCaNhan.ForeColor = System.Drawing.Color.White;
            this.btnThongTinCaNhan.Location = new System.Drawing.Point(0, 0);
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.Size = new System.Drawing.Size(220, 45);
            this.btnThongTinCaNhan.TabIndex = 4;
            this.btnThongTinCaNhan.Text = "Thông tin cá nhân";
            this.btnThongTinCaNhan.Click += new System.EventHandler(this.btnThongTinCaNhan_Click);
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
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
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
            this.btnMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.btnMenu.Image = global::PJCNPM.Properties.Resources.icons8_menu_48;
            this.btnMenu.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(45, 35);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(75, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(198, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "TRANG HỌC SINH";
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(220, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1106, 681);
            this.mainPanel.TabIndex = 1;
            // 
            // HocSinh
            // 
            this.ClientSize = new System.Drawing.Size(1326, 741);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.header);
            this.Name = "HocSinh";
            this.Text = "Trang học sinh";
            this.sidebar.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
    }
}
