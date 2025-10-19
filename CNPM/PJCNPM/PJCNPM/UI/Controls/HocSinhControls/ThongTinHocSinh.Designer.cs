using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.Controls.HocSinhControls
{
    partial class ThongTinHocSinh
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel layoutMain;
        private Guna2Button btnYeuCauChinhSua;

        private Guna2HtmlLabel lblMaHS, lblHoTen, lblNgaySinh, lblGioiTinh;
        private Guna2HtmlLabel lblTonGiao, lblQueQuan, lblTrangThai, lblNamNhapHoc;

        private Label valMaHS, valHoTen, valNgaySinh, valGioiTinh, valDanToc;
        private Label valTonGiao, valQueQuan, valTrangThai, valNamNhapHoc;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaHS = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.valMaHS = new System.Windows.Forms.Label();
            this.lblTonGiao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.valTonGiao = new System.Windows.Forms.Label();
            this.lblHoTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.valHoTen = new System.Windows.Forms.Label();
            this.lblQueQuan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.valQueQuan = new System.Windows.Forms.Label();
            this.lblNgaySinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.valNgaySinh = new System.Windows.Forms.Label();
            this.lblTrangThai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.valTrangThai = new System.Windows.Forms.Label();
            this.lblGioiTinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.valGioiTinh = new System.Windows.Forms.Label();
            this.lblNamNhapHoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.valNamNhapHoc = new System.Windows.Forms.Label();
            this.lblDanToc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.valDanToc = new System.Windows.Forms.Label();
            this.btnYeuCauChinhSua = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.layoutMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.AutoSize = true;
            this.layoutMain.ColumnCount = 4;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutMain.Controls.Add(this.lblMaHS, 0, 0);
            this.layoutMain.Controls.Add(this.valMaHS, 1, 0);
            this.layoutMain.Controls.Add(this.lblTonGiao, 2, 0);
            this.layoutMain.Controls.Add(this.valTonGiao, 3, 0);
            this.layoutMain.Controls.Add(this.lblHoTen, 0, 1);
            this.layoutMain.Controls.Add(this.valHoTen, 1, 1);
            this.layoutMain.Controls.Add(this.lblQueQuan, 2, 1);
            this.layoutMain.Controls.Add(this.valQueQuan, 3, 1);
            this.layoutMain.Controls.Add(this.lblNgaySinh, 0, 2);
            this.layoutMain.Controls.Add(this.valNgaySinh, 1, 2);
            this.layoutMain.Controls.Add(this.lblTrangThai, 2, 2);
            this.layoutMain.Controls.Add(this.valTrangThai, 3, 2);
            this.layoutMain.Controls.Add(this.lblGioiTinh, 0, 3);
            this.layoutMain.Controls.Add(this.valGioiTinh, 1, 3);
            this.layoutMain.Controls.Add(this.lblNamNhapHoc, 2, 3);
            this.layoutMain.Controls.Add(this.valNamNhapHoc, 3, 3);
            this.layoutMain.Controls.Add(this.lblDanToc, 0, 4);
            this.layoutMain.Controls.Add(this.valDanToc, 1, 4);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutMain.Location = new System.Drawing.Point(0, 69);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.Padding = new System.Windows.Forms.Padding(80, 40, 80, 40);
            this.layoutMain.RowCount = 5;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutMain.Size = new System.Drawing.Size(950, 330);
            this.layoutMain.TabIndex = 0;
            // 
            // lblMaHS
            // 
            this.lblMaHS.BackColor = System.Drawing.Color.Transparent;
            this.lblMaHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaHS.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMaHS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblMaHS.Location = new System.Drawing.Point(83, 43);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(111, 27);
            this.lblMaHS.TabIndex = 0;
            this.lblMaHS.Text = "Mã học sinh:";
            this.lblMaHS.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valMaHS
            // 
            this.valMaHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valMaHS.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.valMaHS.ForeColor = System.Drawing.Color.Black;
            this.valMaHS.Location = new System.Drawing.Point(280, 40);
            this.valMaHS.Name = "valMaHS";
            this.valMaHS.Size = new System.Drawing.Size(191, 50);
            this.valMaHS.TabIndex = 1;
            // 
            // lblTonGiao
            // 
            this.lblTonGiao.BackColor = System.Drawing.Color.Transparent;
            this.lblTonGiao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTonGiao.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTonGiao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTonGiao.Location = new System.Drawing.Point(477, 43);
            this.lblTonGiao.Name = "lblTonGiao";
            this.lblTonGiao.Size = new System.Drawing.Size(83, 27);
            this.lblTonGiao.TabIndex = 2;
            this.lblTonGiao.Text = "Tôn giáo:";
            this.lblTonGiao.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valTonGiao
            // 
            this.valTonGiao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valTonGiao.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.valTonGiao.ForeColor = System.Drawing.Color.Black;
            this.valTonGiao.Location = new System.Drawing.Point(674, 40);
            this.valTonGiao.Name = "valTonGiao";
            this.valTonGiao.Size = new System.Drawing.Size(193, 50);
            this.valTonGiao.TabIndex = 3;
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblHoTen.Location = new System.Drawing.Point(83, 93);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(91, 27);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ và tên:";
            this.lblHoTen.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valHoTen
            // 
            this.valHoTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valHoTen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.valHoTen.ForeColor = System.Drawing.Color.Black;
            this.valHoTen.Location = new System.Drawing.Point(280, 90);
            this.valHoTen.Name = "valHoTen";
            this.valHoTen.Size = new System.Drawing.Size(191, 50);
            this.valHoTen.TabIndex = 5;
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.BackColor = System.Drawing.Color.Transparent;
            this.lblQueQuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueQuan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblQueQuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblQueQuan.Location = new System.Drawing.Point(477, 93);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(91, 27);
            this.lblQueQuan.TabIndex = 6;
            this.lblQueQuan.Text = "Quê quán:";
            this.lblQueQuan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valQueQuan
            // 
            this.valQueQuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valQueQuan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.valQueQuan.ForeColor = System.Drawing.Color.Black;
            this.valQueQuan.Location = new System.Drawing.Point(674, 90);
            this.valQueQuan.Name = "valQueQuan";
            this.valQueQuan.Size = new System.Drawing.Size(193, 50);
            this.valQueQuan.TabIndex = 7;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblNgaySinh.Location = new System.Drawing.Point(83, 143);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(93, 27);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "Ngày sinh:";
            this.lblNgaySinh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valNgaySinh
            // 
            this.valNgaySinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valNgaySinh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.valNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.valNgaySinh.Location = new System.Drawing.Point(280, 140);
            this.valNgaySinh.Name = "valNgaySinh";
            this.valNgaySinh.Size = new System.Drawing.Size(191, 50);
            this.valNgaySinh.TabIndex = 9;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lblTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTrangThai.Location = new System.Drawing.Point(477, 143);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(96, 27);
            this.lblTrangThai.TabIndex = 10;
            this.lblTrangThai.Text = "Trạng thái:";
            this.lblTrangThai.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valTrangThai
            // 
            this.valTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valTrangThai.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.valTrangThai.ForeColor = System.Drawing.Color.Black;
            this.valTrangThai.Location = new System.Drawing.Point(674, 140);
            this.valTrangThai.Name = "valTrangThai";
            this.valTrangThai.Size = new System.Drawing.Size(193, 50);
            this.valTrangThai.TabIndex = 11;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblGioiTinh.Location = new System.Drawing.Point(83, 193);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(81, 27);
            this.lblGioiTinh.TabIndex = 12;
            this.lblGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valGioiTinh
            // 
            this.valGioiTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valGioiTinh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.valGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.valGioiTinh.Location = new System.Drawing.Point(280, 190);
            this.valGioiTinh.Name = "valGioiTinh";
            this.valGioiTinh.Size = new System.Drawing.Size(191, 50);
            this.valGioiTinh.TabIndex = 13;
            // 
            // lblNamNhapHoc
            // 
            this.lblNamNhapHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblNamNhapHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNamNhapHoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNamNhapHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblNamNhapHoc.Location = new System.Drawing.Point(477, 193);
            this.lblNamNhapHoc.Name = "lblNamNhapHoc";
            this.lblNamNhapHoc.Size = new System.Drawing.Size(132, 27);
            this.lblNamNhapHoc.TabIndex = 14;
            this.lblNamNhapHoc.Text = "Năm nhập học:";
            this.lblNamNhapHoc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valNamNhapHoc
            // 
            this.valNamNhapHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valNamNhapHoc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.valNamNhapHoc.ForeColor = System.Drawing.Color.Black;
            this.valNamNhapHoc.Location = new System.Drawing.Point(674, 190);
            this.valNamNhapHoc.Name = "valNamNhapHoc";
            this.valNamNhapHoc.Size = new System.Drawing.Size(193, 50);
            this.valNamNhapHoc.TabIndex = 15;
            // 
            // lblDanToc
            // 
            this.lblDanToc.BackColor = System.Drawing.Color.Transparent;
            this.lblDanToc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDanToc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDanToc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblDanToc.Location = new System.Drawing.Point(83, 243);
            this.lblDanToc.Name = "lblDanToc";
            this.lblDanToc.Size = new System.Drawing.Size(74, 27);
            this.lblDanToc.TabIndex = 16;
            this.lblDanToc.Text = "Dân tộc:";
            this.lblDanToc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valDanToc
            // 
            this.valDanToc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valDanToc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.valDanToc.ForeColor = System.Drawing.Color.Black;
            this.valDanToc.Location = new System.Drawing.Point(280, 240);
            this.valDanToc.Name = "valDanToc";
            this.valDanToc.Size = new System.Drawing.Size(191, 50);
            this.valDanToc.TabIndex = 17;
            // 
            // btnYeuCauChinhSua
            // 
            this.btnYeuCauChinhSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYeuCauChinhSua.BorderRadius = 8;
            this.btnYeuCauChinhSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnYeuCauChinhSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYeuCauChinhSua.ForeColor = System.Drawing.Color.White;
            this.btnYeuCauChinhSua.Location = new System.Drawing.Point(724, 422);
            this.btnYeuCauChinhSua.Name = "btnYeuCauChinhSua";
            this.btnYeuCauChinhSua.Size = new System.Drawing.Size(180, 45);
            this.btnYeuCauChinhSua.TabIndex = 2;
            this.btnYeuCauChinhSua.Text = "Yêu cầu chỉnh sửa";
            this.btnYeuCauChinhSua.Click += new System.EventHandler(this.btnYeuCauChinhSua_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(20, 15, 0, 15);
            this.lblTitle.Size = new System.Drawing.Size(950, 69);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "THÔNG TIN HỌC SINH";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThongTinHocSinh
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.layoutMain);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnYeuCauChinhSua);
            this.Name = "ThongTinHocSinh";
            this.Size = new System.Drawing.Size(950, 500);
            this.layoutMain.ResumeLayout(false);
            this.layoutMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna2HtmlLabel lblDanToc;
        private Guna2HtmlLabel lblTitle;
    }
}
