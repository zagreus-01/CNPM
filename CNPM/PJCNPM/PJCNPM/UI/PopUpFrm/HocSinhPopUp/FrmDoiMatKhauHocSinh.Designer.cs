using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace PJCNPM.UI.PopUpFrm.HocSinhPopUp
{
    partial class FrmDoiMatKhauHocSinh
    {
        private Guna2Panel panelHeader;
        private Guna2HtmlLabel lblHeader;
        private Guna2HtmlLabel lblTenDangNhap;
        private Guna2TextBox txtMatKhauCu;
        private Guna2TextBox txtMatKhauMoi;
        private Guna2TextBox txtXacNhanMK;
        private Guna2Button btnXacNhan;
        private Guna2Button btnDong;

        private void InitializeComponent()
        {
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTenDangNhap = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMatKhauCu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatKhauMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtXacNhanMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnDong = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(430, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.AutoSize = false;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(173, 33);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "ĐỔI MẬT KHẨU";
            this.lblHeader.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTenDangNhap.Location = new System.Drawing.Point(30, 80);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(128, 25);
            this.lblTenDangNhap.TabIndex = 1;
            this.lblTenDangNhap.Text = "Tên đăng nhập: ";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.BorderRadius = 8;
            this.txtMatKhauCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhauCu.DefaultText = "";
            this.txtMatKhauCu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhauCu.Location = new System.Drawing.Point(30, 120);
            this.txtMatKhauCu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '●';
            this.txtMatKhauCu.PlaceholderText = "Nhập mật khẩu hiện tại";
            this.txtMatKhauCu.SelectedText = "";
            this.txtMatKhauCu.Size = new System.Drawing.Size(370, 40);
            this.txtMatKhauCu.TabIndex = 2;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.BorderRadius = 8;
            this.txtMatKhauMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhauMoi.DefaultText = "";
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhauMoi.Location = new System.Drawing.Point(30, 180);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '●';
            this.txtMatKhauMoi.PlaceholderText = "Nhập mật khẩu mới";
            this.txtMatKhauMoi.SelectedText = "";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(370, 40);
            this.txtMatKhauMoi.TabIndex = 3;
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.BorderRadius = 8;
            this.txtXacNhanMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXacNhanMK.DefaultText = "";
            this.txtXacNhanMK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtXacNhanMK.Location = new System.Drawing.Point(30, 240);
            this.txtXacNhanMK.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.PasswordChar = '●';
            this.txtXacNhanMK.PlaceholderText = "Xác nhận mật khẩu mới";
            this.txtXacNhanMK.SelectedText = "";
            this.txtXacNhanMK.Size = new System.Drawing.Size(370, 40);
            this.txtXacNhanMK.TabIndex = 4;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BorderRadius = 8;
            this.btnXacNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(60, 310);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(150, 40);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnDong
            // 
            this.btnDong.BorderRadius = 8;
            this.btnDong.FillColor = System.Drawing.Color.Gray;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(230, 310);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(150, 40);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDoiMatKhauHocSinh
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 400);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtXacNhanMK);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoiMatKhauHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu học sinh";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
