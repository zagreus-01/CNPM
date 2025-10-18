using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.Controls.HocSinhControls
{
    partial class TaiKhoanHocSinh
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel layoutMain;
        private Guna2HtmlLabel lblTenDangNhap;
        private Guna2HtmlLabel lblMatKhau;
        private Label valHoTen;
        private Label valTenDangNhap;
        private Guna2TextBox txtMatKhau;
        private Guna2ToggleSwitch swShowPassword;
        private Guna2HtmlLabel lblShowPassword;
        private FlowLayoutPanel pnlShow;
        private Guna2Button btnDoiMatKhau;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblHoTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.valHoTen = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.valTenDangNhap = new System.Windows.Forms.Label();
            this.lblMatKhau = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlShow = new System.Windows.Forms.FlowLayoutPanel();
            this.swShowPassword = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblShowPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnDoiMatKhau = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.layoutMain.SuspendLayout();
            this.pnlShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.AutoSize = true;
            this.layoutMain.ColumnCount = 3;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layoutMain.Controls.Add(this.lblHoTen, 0, 0);
            this.layoutMain.Controls.Add(this.valHoTen, 1, 0);
            this.layoutMain.Controls.Add(this.lblTenDangNhap, 0, 1);
            this.layoutMain.Controls.Add(this.valTenDangNhap, 1, 1);
            this.layoutMain.Controls.Add(this.lblMatKhau, 0, 2);
            this.layoutMain.Controls.Add(this.txtMatKhau, 1, 2);
            this.layoutMain.Controls.Add(this.pnlShow, 2, 2);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutMain.Location = new System.Drawing.Point(0, 69);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.Padding = new System.Windows.Forms.Padding(100, 80, 100, 0);
            this.layoutMain.RowCount = 3;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layoutMain.Size = new System.Drawing.Size(950, 260);
            this.layoutMain.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblHoTen.Location = new System.Drawing.Point(103, 83);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(91, 27);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ và tên:";
            this.lblHoTen.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valHoTen
            // 
            this.valHoTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valHoTen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.valHoTen.ForeColor = System.Drawing.Color.Black;
            this.valHoTen.Location = new System.Drawing.Point(328, 80);
            this.valHoTen.Name = "valHoTen";
            this.valHoTen.Size = new System.Drawing.Size(444, 60);
            this.valHoTen.TabIndex = 1;
            this.valHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblTenDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTenDangNhap.Location = new System.Drawing.Point(103, 143);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(136, 27);
            this.lblTenDangNhap.TabIndex = 2;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            this.lblTenDangNhap.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valTenDangNhap
            // 
            this.valTenDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.valTenDangNhap.ForeColor = System.Drawing.Color.Black;
            this.valTenDangNhap.Location = new System.Drawing.Point(328, 140);
            this.valTenDangNhap.Name = "valTenDangNhap";
            this.valTenDangNhap.Size = new System.Drawing.Size(444, 60);
            this.valTenDangNhap.TabIndex = 3;
            this.valTenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblMatKhau.Location = new System.Drawing.Point(103, 203);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(89, 27);
            this.lblMatKhau.TabIndex = 4;
            this.lblMatKhau.Text = "Mật khẩu:";
            this.lblMatKhau.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderRadius = 8;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtMatKhau.Location = new System.Drawing.Point(328, 205);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '●';
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.ReadOnly = true;
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(444, 50);
            this.txtMatKhau.TabIndex = 5;
            // 
            // pnlShow
            // 
            this.pnlShow.AutoSize = true;
            this.pnlShow.Controls.Add(this.swShowPassword);
            this.pnlShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShow.Location = new System.Drawing.Point(778, 203);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(69, 54);
            this.pnlShow.TabIndex = 6;
            // 
            // swShowPassword
            // 
            this.swShowPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.swShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.swShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.swShowPassword.CheckedState.InnerColor = System.Drawing.Color.White;
            this.swShowPassword.Location = new System.Drawing.Point(3, 3);
            this.swShowPassword.Name = "swShowPassword";
            this.swShowPassword.Size = new System.Drawing.Size(45, 22);
            this.swShowPassword.TabIndex = 0;
            this.swShowPassword.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.swShowPassword.UncheckedState.FillColor = System.Drawing.Color.LightGray;
            this.swShowPassword.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.swShowPassword.CheckedChanged += new System.EventHandler(this.swShowPassword_CheckedChanged);
            // 
            // lblShowPassword
            // 
            this.lblShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblShowPassword.Location = new System.Drawing.Point(0, 0);
            this.lblShowPassword.Name = "lblShowPassword";
            this.lblShowPassword.Size = new System.Drawing.Size(3, 2);
            this.lblShowPassword.TabIndex = 0;
            this.lblShowPassword.Text = null;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoiMatKhau.BorderRadius = 8;
            this.btnDoiMatKhau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(700, 380);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(180, 45);
            this.btnDoiMatKhau.TabIndex = 0;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(40, 15, 0, 15);
            this.lblTitle.Size = new System.Drawing.Size(950, 69);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "THÔNG TIN TÀI KHOẢN";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaiKhoanHocSinh
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.layoutMain);
            this.Controls.Add(this.lblTitle);
            this.Name = "TaiKhoanHocSinh";
            this.Size = new System.Drawing.Size(950, 480);
            this.layoutMain.ResumeLayout(false);
            this.layoutMain.PerformLayout();
            this.pnlShow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna2HtmlLabel lblHoTen;
        private Guna2HtmlLabel lblTitle;
    }
}
