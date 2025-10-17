using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    partial class FrmSaveLop
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2HtmlLabel lblTitle;
        private Guna2HtmlLabel lblTenLop;
        private Guna2HtmlLabel lblNamHoc;
        private Guna2HtmlLabel lblHocKi;
        private Guna2HtmlLabel lblKhoiHoc;
        private Guna2HtmlLabel lblGiaoVien;
        private Guna2HtmlLabel lblTrangThai;
        private Guna2TextBox txtTenLop;
        private Guna2ComboBox cboNamHoc;
        private Guna2ComboBox cboHocKi;
        private Guna2ComboBox cboKhoiHoc;
        private Guna2ComboBox cboGiaoVien;
        private Guna2CheckBox chkDaKetThuc;
        private Guna2Button btnLuu;
        private Guna2Button btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTenLop = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNamHoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHocKi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblKhoiHoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGiaoVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTrangThai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTenLop = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboNamHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboHocKi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboKhoiHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboGiaoVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chkDaKetThuc = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM / SỬA LỚP HỌC";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenLop
            // 
            this.lblTenLop.BackColor = System.Drawing.Color.Transparent;
            this.lblTenLop.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTenLop.Location = new System.Drawing.Point(40, 80);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(70, 25);
            this.lblTenLop.TabIndex = 1;
            this.lblTenLop.Text = "Tên lớp:";
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblNamHoc.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblNamHoc.Location = new System.Drawing.Point(40, 135);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(87, 25);
            this.lblNamHoc.TabIndex = 2;
            this.lblNamHoc.Text = "Năm học:";
            // 
            // lblHocKi
            // 
            this.lblHocKi.BackColor = System.Drawing.Color.Transparent;
            this.lblHocKi.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblHocKi.Location = new System.Drawing.Point(40, 190);
            this.lblHocKi.Name = "lblHocKi";
            this.lblHocKi.Size = new System.Drawing.Size(66, 25);
            this.lblHocKi.TabIndex = 3;
            this.lblHocKi.Text = "Học kỳ:";
            // 
            // lblKhoiHoc
            // 
            this.lblKhoiHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblKhoiHoc.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblKhoiHoc.Location = new System.Drawing.Point(40, 245);
            this.lblKhoiHoc.Name = "lblKhoiHoc";
            this.lblKhoiHoc.Size = new System.Drawing.Size(82, 25);
            this.lblKhoiHoc.TabIndex = 4;
            this.lblKhoiHoc.Text = "Khối học:";
            // 
            // lblGiaoVien
            // 
            this.lblGiaoVien.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaoVien.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblGiaoVien.Location = new System.Drawing.Point(40, 300);
            this.lblGiaoVien.Name = "lblGiaoVien";
            this.lblGiaoVien.Size = new System.Drawing.Size(95, 25);
            this.lblGiaoVien.TabIndex = 5;
            this.lblGiaoVien.Text = "Giáo viên:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.Location = new System.Drawing.Point(40, 355);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(93, 25);
            this.lblTrangThai.TabIndex = 6;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLop.DefaultText = "";
            this.txtTenLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenLop.Location = new System.Drawing.Point(170, 75);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(280, 36);
            this.txtTenLop.TabIndex = 7;
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboNamHoc.ForeColor = System.Drawing.Color.Black;
            this.cboNamHoc.ItemHeight = 30;
            this.cboNamHoc.Location = new System.Drawing.Point(170, 130);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(280, 36);
            this.cboNamHoc.TabIndex = 8;
            // 
            // cboHocKi
            // 
            this.cboHocKi.BackColor = System.Drawing.Color.Transparent;
            this.cboHocKi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHocKi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocKi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboHocKi.ForeColor = System.Drawing.Color.Black;
            this.cboHocKi.ItemHeight = 30;
            this.cboHocKi.Location = new System.Drawing.Point(170, 185);
            this.cboHocKi.Name = "cboHocKi";
            this.cboHocKi.Size = new System.Drawing.Size(280, 36);
            this.cboHocKi.TabIndex = 9;
            // 
            // cboKhoiHoc
            // 
            this.cboKhoiHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboKhoiHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhoiHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoiHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboKhoiHoc.ForeColor = System.Drawing.Color.Black;
            this.cboKhoiHoc.ItemHeight = 30;
            this.cboKhoiHoc.Location = new System.Drawing.Point(170, 240);
            this.cboKhoiHoc.Name = "cboKhoiHoc";
            this.cboKhoiHoc.Size = new System.Drawing.Size(280, 36);
            this.cboKhoiHoc.TabIndex = 10;
            // 
            // cboGiaoVien
            // 
            this.cboGiaoVien.BackColor = System.Drawing.Color.Transparent;
            this.cboGiaoVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiaoVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboGiaoVien.ForeColor = System.Drawing.Color.Black;
            this.cboGiaoVien.ItemHeight = 30;
            this.cboGiaoVien.Location = new System.Drawing.Point(170, 295);
            this.cboGiaoVien.Name = "cboGiaoVien";
            this.cboGiaoVien.Size = new System.Drawing.Size(280, 36);
            this.cboGiaoVien.TabIndex = 11;
            // 
            // chkDaKetThuc
            // 
            this.chkDaKetThuc.AutoSize = true;
            this.chkDaKetThuc.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkDaKetThuc.Location = new System.Drawing.Point(170, 355);
            this.chkDaKetThuc.Name = "chkDaKetThuc";
            this.chkDaKetThuc.Size = new System.Drawing.Size(120, 29);
            this.chkDaKetThuc.TabIndex = 12;
            this.chkDaKetThuc.Text = "Đã kết thúc";
            // 
            // btnLuu
            // 
            this.btnLuu.FillColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(130, 420);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 40);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.FillColor = System.Drawing.Color.Gray;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(280, 420);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FrmSaveLop
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.chkDaKetThuc);
            this.Controls.Add(this.cboGiaoVien);
            this.Controls.Add(this.cboKhoiHoc);
            this.Controls.Add(this.cboHocKi);
            this.Controls.Add(this.cboNamHoc);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblGiaoVien);
            this.Controls.Add(this.lblKhoiHoc);
            this.Controls.Add(this.lblHocKi);
            this.Controls.Add(this.lblNamHoc);
            this.Controls.Add(this.lblTenLop);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmSaveLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm / Sửa Lớp";
            this.Load += new System.EventHandler(this.FrmSaveLop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
