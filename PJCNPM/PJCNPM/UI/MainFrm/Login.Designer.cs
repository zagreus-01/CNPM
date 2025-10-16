using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace PJCNPM.UI.MainFrm
{
    public partial class Login : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2Panel pnlMain;
        private Guna2TextBox txtUsername;
        private Guna2TextBox txtPassword;
        private Guna2Button btnLogin;
        private Guna2HtmlLabel lblTitle;
        private Guna2HtmlLabel lblError;
        private Guna2Button btnExit;
        private Guna2CheckBox chkShowPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlMain = new Guna2Panel();
            this.lblTitle = new Guna2HtmlLabel();
            this.txtUsername = new Guna2TextBox();
            this.txtPassword = new Guna2TextBox();
            this.btnLogin = new Guna2Button();
            this.lblError = new Guna2HtmlLabel();
            this.btnExit = new Guna2Button();
            this.chkShowPassword = new Guna2CheckBox();

            this.pnlMain.SuspendLayout();
            this.SuspendLayout();

            // 🔹 Panel
            this.pnlMain.Dock = DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.txtUsername);
            this.pnlMain.Controls.Add(this.txtPassword);
            this.pnlMain.Controls.Add(this.chkShowPassword);
            this.pnlMain.Controls.Add(this.btnLogin);
            this.pnlMain.Controls.Add(this.lblError);
            this.pnlMain.Controls.Add(this.btnExit);

            // 🔹 Tiêu đề
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.lblTitle.Location = new System.Drawing.Point(45, 50);

            // 🔹 Username
            this.txtUsername.BorderRadius = 8;
            this.txtUsername.PlaceholderText = "Tên đăng nhập";
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(45, 120);
            this.txtUsername.Size = new System.Drawing.Size(350, 45);

            // 🔹 Password
            this.txtPassword.BorderRadius = 8;
            this.txtPassword.PlaceholderText = "Mật khẩu";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Location = new System.Drawing.Point(45, 180);
            this.txtPassword.Size = new System.Drawing.Size(350, 45);

            // 🔹 Checkbox hiển thị mật khẩu
            this.chkShowPassword.Text = "Hiện mật khẩu";
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShowPassword.Location = new System.Drawing.Point(45, 230);
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);

            // 🔹 Nút Đăng nhập
            this.btnLogin.BorderRadius = 8;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.Location = new System.Drawing.Point(45, 270);
            this.btnLogin.Size = new System.Drawing.Size(350, 45);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // 🔹 Label lỗi
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblError.Location = new System.Drawing.Point(45, 325);

            // 🔹 Nút Thoát
            this.btnExit.FillColor = System.Drawing.Color.Gray;
            this.btnExit.BorderRadius = 8;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Text = "THOÁT";
            this.btnExit.Location = new System.Drawing.Point(45, 360);
            this.btnExit.Size = new System.Drawing.Size(350, 40);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 🔹 Form
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.Text = "Đăng nhập";

            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
