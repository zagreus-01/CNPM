namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    partial class FrmChuyenLopAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHocSinh;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLopCu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLopMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtHocSinh;
        private Guna.UI2.WinForms.Guna2TextBox txtLopCu;
        private Guna.UI2.WinForms.Guna2ComboBox cboLopMoi;
        private Guna.UI2.WinForms.Guna2CheckBox chkXoaDiem;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblKetQua;
        private Guna.UI2.WinForms.Guna2Button btnXacNhan;
        private Guna.UI2.WinForms.Guna2Button btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHocSinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLopCu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLopMoi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtHocSinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLopCu = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboLopMoi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chkXoaDiem = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblKetQua = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // lblHocSinh
            // 
            this.lblHocSinh.BackColor = System.Drawing.Color.Transparent;
            this.lblHocSinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHocSinh.Location = new System.Drawing.Point(30, 80);
            this.lblHocSinh.Name = "lblHocSinh";
            this.lblHocSinh.Size = new System.Drawing.Size(73, 25);
            this.lblHocSinh.TabIndex = 1;
            this.lblHocSinh.Text = "Học sinh:";
            // 
            // lblLopCu
            // 
            this.lblLopCu.BackColor = System.Drawing.Color.Transparent;
            this.lblLopCu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLopCu.Location = new System.Drawing.Point(30, 148);
            this.lblLopCu.Name = "lblLopCu";
            this.lblLopCu.Size = new System.Drawing.Size(97, 25);
            this.lblLopCu.TabIndex = 3;
            this.lblLopCu.Text = "Lớp hiện tại:";
            // 
            // lblLopMoi
            // 
            this.lblLopMoi.BackColor = System.Drawing.Color.Transparent;
            this.lblLopMoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLopMoi.Location = new System.Drawing.Point(30, 220);
            this.lblLopMoi.Name = "lblLopMoi";
            this.lblLopMoi.Size = new System.Drawing.Size(69, 25);
            this.lblLopMoi.TabIndex = 5;
            this.lblLopMoi.Text = "Lớp mới:";
            // 
            // txtHocSinh
            // 
            this.txtHocSinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHocSinh.DefaultText = "";
            this.txtHocSinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHocSinh.Location = new System.Drawing.Point(120, 75);
            this.txtHocSinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHocSinh.Name = "txtHocSinh";
            this.txtHocSinh.PlaceholderText = "";
            this.txtHocSinh.ReadOnly = true;
            this.txtHocSinh.SelectedText = "";
            this.txtHocSinh.Size = new System.Drawing.Size(220, 35);
            this.txtHocSinh.TabIndex = 2;
            // 
            // txtLopCu
            // 
            this.txtLopCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLopCu.DefaultText = "";
            this.txtLopCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLopCu.Location = new System.Drawing.Point(120, 143);
            this.txtLopCu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLopCu.Name = "txtLopCu";
            this.txtLopCu.PlaceholderText = "";
            this.txtLopCu.ReadOnly = true;
            this.txtLopCu.SelectedText = "";
            this.txtLopCu.Size = new System.Drawing.Size(220, 35);
            this.txtLopCu.TabIndex = 4;
            // 
            // cboLopMoi
            // 
            this.cboLopMoi.BackColor = System.Drawing.Color.Transparent;
            this.cboLopMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLopMoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopMoi.FocusedColor = System.Drawing.Color.Empty;
            this.cboLopMoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLopMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLopMoi.ItemHeight = 30;
            this.cboLopMoi.Location = new System.Drawing.Point(120, 215);
            this.cboLopMoi.Name = "cboLopMoi";
            this.cboLopMoi.Size = new System.Drawing.Size(220, 36);
            this.cboLopMoi.TabIndex = 6;
            // 
            // chkXoaDiem
            // 
            this.chkXoaDiem.CheckedState.BorderRadius = 0;
            this.chkXoaDiem.CheckedState.BorderThickness = 0;
            this.chkXoaDiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkXoaDiem.Location = new System.Drawing.Point(30, 275);
            this.chkXoaDiem.Name = "chkXoaDiem";
            this.chkXoaDiem.Size = new System.Drawing.Size(169, 24);
            this.chkXoaDiem.TabIndex = 11;
            this.chkXoaDiem.Text = "Xóa toàn bộ điểm hiện tại";
            this.chkXoaDiem.UncheckedState.BorderRadius = 0;
            this.chkXoaDiem.UncheckedState.BorderThickness = 0;
            // 
            // lblKetQua
            // 
            this.lblKetQua.BackColor = System.Drawing.Color.Transparent;
            this.lblKetQua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblKetQua.ForeColor = System.Drawing.Color.Gray;
            this.lblKetQua.Location = new System.Drawing.Point(30, 305);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(3, 2);
            this.lblKetQua.TabIndex = 12;
            this.lblKetQua.Text = null;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(50, 350);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(120, 45);
            this.btnXacNhan.TabIndex = 13;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.FillColor = System.Drawing.Color.Gray;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(210, 350);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 45);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "HỦY";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(380, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CHUYỂN LỚP HỌC SINH";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmChuyenLopAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 420);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblHocSinh);
            this.Controls.Add(this.txtHocSinh);
            this.Controls.Add(this.lblLopCu);
            this.Controls.Add(this.txtLopCu);
            this.Controls.Add(this.lblLopMoi);
            this.Controls.Add(this.cboLopMoi);
            this.Controls.Add(this.chkXoaDiem);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnHuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmChuyenLopAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmChuyenLopAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
    }
}
