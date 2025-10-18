namespace PJCNPM.UI.Controls.GiaoVienControls
{
    partial class TaiKhoanGiaoVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDoiMatKhau = new Guna.UI2.WinForms.Guna2Button();
            this.lblTenDangNhapValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderColor = System.Drawing.Color.LightGray;
            this.panelMain.BorderRadius = 10;
            this.panelMain.BorderThickness = 1;
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.btnDoiMatKhau);
            this.panelMain.Controls.Add(this.lblTenDangNhapValue);
            this.panelMain.Location = new System.Drawing.Point(127, 55);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(626, 400);
            this.panelMain.TabIndex = 7;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BorderRadius = 8;
            this.btnDoiMatKhau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(195, 256);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(201, 45);
            this.btnDoiMatKhau.TabIndex = 2;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // lblTenDangNhapValue
            // 
            this.lblTenDangNhapValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTenDangNhapValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTenDangNhapValue.Location = new System.Drawing.Point(405, 114);
            this.lblTenDangNhapValue.Name = "lblTenDangNhapValue";
            this.lblTenDangNhapValue.Size = new System.Drawing.Size(15, 27);
            this.lblTenDangNhapValue.TabIndex = 1;
            this.lblTenDangNhapValue.Text = "...";
            this.lblTenDangNhapValue.Click += new System.EventHandler(this.lblTenDangNhapValue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập";
            // 
            // TaiKhoanGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelMain);
            this.Name = "TaiKhoanGiaoVien";
            this.Size = new System.Drawing.Size(901, 520);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2Button btnDoiMatKhau;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenDangNhapValue;
        private System.Windows.Forms.Label label1;
    }
}