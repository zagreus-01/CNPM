namespace PJCNPM.UI.MainFrm
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.sidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThietBiPhong = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLyPhongHoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLyThietBi = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.header = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sidebar.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(220, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1106, 681);
            this.mainPanel.TabIndex = 4;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.sidebar.Controls.Add(this.btnThietBiPhong);
            this.sidebar.Controls.Add(this.btnQuanLyPhongHoc);
            this.sidebar.Controls.Add(this.btnQuanLyThietBi);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 60);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(220, 681);
            this.sidebar.TabIndex = 3;
            // 
            // btnThietBiPhong
            // 
            this.btnThietBiPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThietBiPhong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThietBiPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThietBiPhong.ForeColor = System.Drawing.Color.White;
            this.btnThietBiPhong.Location = new System.Drawing.Point(0, 90);
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
            this.btnQuanLyPhongHoc.Location = new System.Drawing.Point(0, 45);
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
            this.btnQuanLyThietBi.Location = new System.Drawing.Point(0, 0);
            this.btnQuanLyThietBi.Name = "btnQuanLyThietBi";
            this.btnQuanLyThietBi.Size = new System.Drawing.Size(220, 45);
            this.btnQuanLyThietBi.TabIndex = 4;
            this.btnQuanLyThietBi.Text = "Quản lý thiết bị";
            this.btnQuanLyThietBi.Click += new System.EventHandler(this.btnQuanLyThietBi_Click);
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
            this.header.TabIndex = 5;
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
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(75, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "TRANG ADMIN";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 741);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.header);
            this.Name = "Admin";
            this.Text = "Trang admin";
            this.sidebar.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Panel sidebar;
        private Guna.UI2.WinForms.Guna2Button btnThietBiPhong;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyPhongHoc;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyThietBi;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Panel header;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
    }
}