using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    partial class FrmHocSinhEditAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2HtmlLabel lblHoTen;
        private Guna2HtmlLabel lblNgaySinh;
        private Guna2HtmlLabel lblGioiTinh;
        private Guna2HtmlLabel lblDanToc;
        private Guna2HtmlLabel lblTonGiao;
        private Guna2HtmlLabel lblQueQuan;
        private Guna2HtmlLabel lblNamNhapHoc;
        private Guna2HtmlLabel lblTrangThai;
        private Guna2HtmlLabel lblLop;
        private Guna2TextBox txtHoTen;
        private Guna2DateTimePicker dtNgaySinh;
        private Guna2CheckBox chkNam;
        private Guna2CheckBox chkNu;
        private Guna2TextBox txtDanToc;
        private Guna2TextBox txtTonGiao;
        private Guna2TextBox txtQueQuan;
        private NumericUpDown numNamNhapHoc;
        private Guna2ComboBox cboTrangThai;
        private Guna2ComboBox cboLop;
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
            this.lblHoTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNgaySinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGioiTinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDanToc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTonGiao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblQueQuan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNamNhapHoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTrangThai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLop = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.chkNam = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkNu = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtDanToc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTonGiao = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQueQuan = new Guna.UI2.WinForms.Guna2TextBox();
            this.numNamNhapHoc = new System.Windows.Forms.NumericUpDown();
            this.cboTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboLop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numNamNhapHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.Location = new System.Drawing.Point(40, 80);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(62, 25);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblNgaySinh.Location = new System.Drawing.Point(40, 135);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(87, 25);
            this.lblNgaySinh.TabIndex = 3;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblGioiTinh.Location = new System.Drawing.Point(40, 190);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(78, 25);
            this.lblGioiTinh.TabIndex = 5;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // lblDanToc
            // 
            this.lblDanToc.BackColor = System.Drawing.Color.Transparent;
            this.lblDanToc.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblDanToc.Location = new System.Drawing.Point(40, 245);
            this.lblDanToc.Name = "lblDanToc";
            this.lblDanToc.Size = new System.Drawing.Size(70, 25);
            this.lblDanToc.TabIndex = 8;
            this.lblDanToc.Text = "Dân tộc:";
            // 
            // lblTonGiao
            // 
            this.lblTonGiao.BackColor = System.Drawing.Color.Transparent;
            this.lblTonGiao.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTonGiao.Location = new System.Drawing.Point(40, 300);
            this.lblTonGiao.Name = "lblTonGiao";
            this.lblTonGiao.Size = new System.Drawing.Size(78, 25);
            this.lblTonGiao.TabIndex = 10;
            this.lblTonGiao.Text = "Tôn giáo:";
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.BackColor = System.Drawing.Color.Transparent;
            this.lblQueQuan.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblQueQuan.Location = new System.Drawing.Point(40, 355);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(85, 25);
            this.lblQueQuan.TabIndex = 12;
            this.lblQueQuan.Text = "Quê quán:";
            // 
            // lblNamNhapHoc
            // 
            this.lblNamNhapHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblNamNhapHoc.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblNamNhapHoc.Location = new System.Drawing.Point(40, 410);
            this.lblNamNhapHoc.Name = "lblNamNhapHoc";
            this.lblNamNhapHoc.Size = new System.Drawing.Size(124, 25);
            this.lblNamNhapHoc.TabIndex = 14;
            this.lblNamNhapHoc.Text = "Năm nhập học:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.Location = new System.Drawing.Point(40, 460);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(91, 25);
            this.lblTrangThai.TabIndex = 15;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // lblLop
            // 
            this.lblLop.BackColor = System.Drawing.Color.Transparent;
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblLop.Location = new System.Drawing.Point(40, 515);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(39, 25);
            this.lblLop.TabIndex = 17;
            this.lblLop.Text = "Lớp:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderRadius = 6;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(170, 75);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(320, 36);
            this.txtHoTen.TabIndex = 2;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.BorderRadius = 6;
            this.dtNgaySinh.Checked = true;
            this.dtNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(170, 130);
            this.dtNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(320, 36);
            this.dtNgaySinh.TabIndex = 4;
            this.dtNgaySinh.Value = new System.DateTime(2025, 10, 14, 10, 3, 38, 899);
            // 
            // chkNam
            // 
            this.chkNam.AutoSize = true;
            this.chkNam.CheckedState.BorderRadius = 0;
            this.chkNam.CheckedState.BorderThickness = 0;
            this.chkNam.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkNam.Location = new System.Drawing.Point(170, 190);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(72, 29);
            this.chkNam.TabIndex = 6;
            this.chkNam.Text = "Nam";
            this.chkNam.UncheckedState.BorderRadius = 0;
            this.chkNam.UncheckedState.BorderThickness = 0;
            this.chkNam.CheckedChanged += new System.EventHandler(this.chkNam_CheckedChanged);
            // 
            // chkNu
            // 
            this.chkNu.AutoSize = true;
            this.chkNu.CheckedState.BorderRadius = 0;
            this.chkNu.CheckedState.BorderThickness = 0;
            this.chkNu.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkNu.Location = new System.Drawing.Point(260, 190);
            this.chkNu.Name = "chkNu";
            this.chkNu.Size = new System.Drawing.Size(58, 29);
            this.chkNu.TabIndex = 7;
            this.chkNu.Text = "Nữ";
            this.chkNu.UncheckedState.BorderRadius = 0;
            this.chkNu.UncheckedState.BorderThickness = 0;
            this.chkNu.CheckedChanged += new System.EventHandler(this.chkNu_CheckedChanged);
            // 
            // txtDanToc
            // 
            this.txtDanToc.BorderRadius = 6;
            this.txtDanToc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDanToc.DefaultText = "";
            this.txtDanToc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDanToc.ForeColor = System.Drawing.Color.Black;
            this.txtDanToc.Location = new System.Drawing.Point(170, 240);
            this.txtDanToc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.PlaceholderText = "";
            this.txtDanToc.SelectedText = "";
            this.txtDanToc.Size = new System.Drawing.Size(320, 36);
            this.txtDanToc.TabIndex = 9;
            // 
            // txtTonGiao
            // 
            this.txtTonGiao.BorderRadius = 6;
            this.txtTonGiao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTonGiao.DefaultText = "";
            this.txtTonGiao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTonGiao.ForeColor = System.Drawing.Color.Black;
            this.txtTonGiao.Location = new System.Drawing.Point(170, 295);
            this.txtTonGiao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTonGiao.Name = "txtTonGiao";
            this.txtTonGiao.PlaceholderText = "";
            this.txtTonGiao.SelectedText = "";
            this.txtTonGiao.Size = new System.Drawing.Size(320, 36);
            this.txtTonGiao.TabIndex = 11;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.BorderRadius = 6;
            this.txtQueQuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQueQuan.DefaultText = "";
            this.txtQueQuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQueQuan.ForeColor = System.Drawing.Color.Black;
            this.txtQueQuan.Location = new System.Drawing.Point(170, 350);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.PlaceholderText = "";
            this.txtQueQuan.SelectedText = "";
            this.txtQueQuan.Size = new System.Drawing.Size(320, 36);
            this.txtQueQuan.TabIndex = 13;
            // 
            // numNamNhapHoc
            // 
            this.numNamNhapHoc.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.numNamNhapHoc.Location = new System.Drawing.Point(180, 410);
            this.numNamNhapHoc.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numNamNhapHoc.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numNamNhapHoc.Name = "numNamNhapHoc";
            this.numNamNhapHoc.Size = new System.Drawing.Size(120, 31);
            this.numNamNhapHoc.TabIndex = 21;
            this.numNamNhapHoc.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cboTrangThai.BorderRadius = 6;
            this.cboTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FocusedColor = System.Drawing.Color.Empty;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.Black;
            this.cboTrangThai.ItemHeight = 30;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Đang học",
            "Bảo lưu",
            "Kết thúc",
            "Đuổi học"});
            this.cboTrangThai.Location = new System.Drawing.Point(170, 455);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(320, 36);
            this.cboTrangThai.StartIndex = 0;
            this.cboTrangThai.TabIndex = 16;
            // 
            // cboLop
            // 
            this.cboLop.BackColor = System.Drawing.Color.Transparent;
            this.cboLop.BorderRadius = 6;
            this.cboLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FocusedColor = System.Drawing.Color.Empty;
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLop.ForeColor = System.Drawing.Color.Black;
            this.cboLop.ItemHeight = 30;
            this.cboLop.Items.AddRange(new object[] {
            "10A1",
            "10A2",
            "11A1",
            "12A1"});
            this.cboLop.Location = new System.Drawing.Point(170, 510);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(320, 36);
            this.cboLop.StartIndex = 0;
            this.cboLop.TabIndex = 18;
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.FillColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(170, 570);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 40);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.FillColor = System.Drawing.Color.Gray;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(340, 570);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 40);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lblTitle.Size = new System.Drawing.Size(550, 63);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM / SỬA HỌC SINH";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmHocSinhEditAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(550, 640);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.numNamNhapHoc);
            this.Controls.Add(this.lblNamNhapHoc);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.lblQueQuan);
            this.Controls.Add(this.txtTonGiao);
            this.Controls.Add(this.lblTonGiao);
            this.Controls.Add(this.txtDanToc);
            this.Controls.Add(this.lblDanToc);
            this.Controls.Add(this.chkNu);
            this.Controls.Add(this.chkNam);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmHocSinhEditAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm / Sửa học sinh";
            ((System.ComponentModel.ISupportInitialize)(this.numNamNhapHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna2HtmlLabel lblTitle;
    }
}
