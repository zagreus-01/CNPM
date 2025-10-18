using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.Controls.GiaoVienControls
{
    partial class ThongTinGiaoVien
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel panelRoot;
        private Guna2HtmlLabel lblTitle;
        private Guna2Panel panelLeft;
        private Guna2Panel panelRight;
        private Guna2Button btnYeuCauChinhSua;
        private Guna2HtmlLabel lblTrangThaiYeuCau;
        private Guna2HtmlLabel lblHoTen;
        private Guna2HtmlLabel lblGioiTinh;
        private Guna2HtmlLabel lblCCCD;
        private Guna2HtmlLabel lblEmail;
        private Guna2HtmlLabel lblDienThoai;
        private Guna2HtmlLabel lblDanToc;
        private Guna2HtmlLabel lblTonGiao;
        private Guna2HtmlLabel lblLaDangVien; // Sửa đổi: Đổi tên
        private Guna2HtmlLabel lblNoiThuongTru;
        private Guna2HtmlLabel lblQueQuan;
        private Guna2HtmlLabel lblNgaySinh;
        private Guna2HtmlLabel lblTenTK;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelRoot = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTrangThaiYeuCau = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnYeuCauChinhSua = new Guna.UI2.WinForms.Guna2Button();
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTenTK = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNgaySinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblQueQuan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNoiThuongTru = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLaDangVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTonGiao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDanToc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDienThoai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCCCD = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGioiTinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHoTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelRoot.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRoot
            // 
            this.panelRoot.Controls.Add(this.lblTrangThaiYeuCau);
            this.panelRoot.Controls.Add(this.btnYeuCauChinhSua);
            this.panelRoot.Controls.Add(this.panelRight);
            this.panelRoot.Controls.Add(this.panelLeft);
            this.panelRoot.Controls.Add(this.lblTitle);
            this.panelRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoot.Location = new System.Drawing.Point(0, 0);
            this.panelRoot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelRoot.Name = "panelRoot";
            this.panelRoot.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panelRoot.Size = new System.Drawing.Size(1312, 752);
            this.panelRoot.TabIndex = 0;
            // 
            // lblTrangThaiYeuCau
            // 
            this.lblTrangThaiYeuCau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTrangThaiYeuCau.AutoSize = false;
            this.lblTrangThaiYeuCau.BackColor = System.Drawing.Color.Transparent;
            this.lblTrangThaiYeuCau.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThaiYeuCau.ForeColor = System.Drawing.Color.Gray;
            this.lblTrangThaiYeuCau.Location = new System.Drawing.Point(31, 687);
            this.lblTrangThaiYeuCau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTrangThaiYeuCau.Name = "lblTrangThaiYeuCau";
            this.lblTrangThaiYeuCau.Size = new System.Drawing.Size(613, 27);
            this.lblTrangThaiYeuCau.TabIndex = 5;
            this.lblTrangThaiYeuCau.Text = "Trạng thái yêu cầu: Chưa có";
            // 
            // btnYeuCauChinhSua
            // 
            this.btnYeuCauChinhSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYeuCauChinhSua.BorderRadius = 6;
            this.btnYeuCauChinhSua.FillColor = System.Drawing.Color.SeaGreen;
            this.btnYeuCauChinhSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnYeuCauChinhSua.ForeColor = System.Drawing.Color.White;
            this.btnYeuCauChinhSua.Location = new System.Drawing.Point(890, 674);
            this.btnYeuCauChinhSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYeuCauChinhSua.Name = "btnYeuCauChinhSua";
            this.btnYeuCauChinhSua.Size = new System.Drawing.Size(240, 49);
            this.btnYeuCauChinhSua.TabIndex = 3;
            this.btnYeuCauChinhSua.Text = "Yêu cầu chỉnh sửa";
            this.btnYeuCauChinhSua.Click += new System.EventHandler(this.btnYeuCauChinhSua_Click);
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.BorderColor = System.Drawing.Color.Gainsboro;
            this.panelRight.BorderRadius = 8;
            this.panelRight.BorderThickness = 1;
            this.panelRight.Controls.Add(this.lblTenTK);
            this.panelRight.Controls.Add(this.lblNgaySinh);
            this.panelRight.Controls.Add(this.lblQueQuan);
            this.panelRight.Controls.Add(this.lblNoiThuongTru);
            this.panelRight.Controls.Add(this.lblLaDangVien);
            this.panelRight.Controls.Add(this.lblTonGiao);
            this.panelRight.Location = new System.Drawing.Point(668, 91);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panelRight.Size = new System.Drawing.Size(613, 554);
            this.panelRight.TabIndex = 2;
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = false;
            this.lblTenTK.BackColor = System.Drawing.Color.Transparent;
            this.lblTenTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenTK.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTK.Location = new System.Drawing.Point(27, 395);
            this.lblTenTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(559, 74);
            this.lblTenTK.TabIndex = 6;
            this.lblTenTK.Text = "Tên tài khoản: ";
            this.lblTenTK.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = false;
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(27, 321);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(559, 74);
            this.lblNgaySinh.TabIndex = 5;
            this.lblNgaySinh.Text = "Ngày sinh: ";
            this.lblNgaySinh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = false;
            this.lblQueQuan.BackColor = System.Drawing.Color.Transparent;
            this.lblQueQuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQueQuan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueQuan.Location = new System.Drawing.Point(27, 247);
            this.lblQueQuan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(559, 74);
            this.lblQueQuan.TabIndex = 4;
            this.lblQueQuan.Text = "Quê quán: ";
            this.lblQueQuan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNoiThuongTru
            // 
            this.lblNoiThuongTru.AutoSize = false;
            this.lblNoiThuongTru.BackColor = System.Drawing.Color.Transparent;
            this.lblNoiThuongTru.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNoiThuongTru.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiThuongTru.Location = new System.Drawing.Point(27, 173);
            this.lblNoiThuongTru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblNoiThuongTru.Name = "lblNoiThuongTru";
            this.lblNoiThuongTru.Size = new System.Drawing.Size(559, 74);
            this.lblNoiThuongTru.TabIndex = 3;
            this.lblNoiThuongTru.Text = "Nơi thường trú: ";
            this.lblNoiThuongTru.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLaDangVien
            // 
            this.lblLaDangVien.AutoSize = false;
            this.lblLaDangVien.BackColor = System.Drawing.Color.Transparent;
            this.lblLaDangVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLaDangVien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaDangVien.Location = new System.Drawing.Point(27, 99);
            this.lblLaDangVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblLaDangVien.Name = "lblLaDangVien";
            this.lblLaDangVien.Size = new System.Drawing.Size(559, 74);
            this.lblLaDangVien.TabIndex = 2;
            this.lblLaDangVien.Text = "Là Đảng viên: ";
            this.lblLaDangVien.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTonGiao
            // 
            this.lblTonGiao.AutoSize = false;
            this.lblTonGiao.BackColor = System.Drawing.Color.Transparent;
            this.lblTonGiao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTonGiao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTonGiao.Location = new System.Drawing.Point(27, 25);
            this.lblTonGiao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTonGiao.Name = "lblTonGiao";
            this.lblTonGiao.Size = new System.Drawing.Size(559, 74);
            this.lblTonGiao.TabIndex = 0;
            this.lblTonGiao.Text = "Tôn giáo: ";
            this.lblTonGiao.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.BorderColor = System.Drawing.Color.Gainsboro;
            this.panelLeft.BorderRadius = 8;
            this.panelLeft.BorderThickness = 1;
            this.panelLeft.Controls.Add(this.lblDanToc);
            this.panelLeft.Controls.Add(this.lblDienThoai);
            this.panelLeft.Controls.Add(this.lblEmail);
            this.panelLeft.Controls.Add(this.lblCCCD);
            this.panelLeft.Controls.Add(this.lblGioiTinh);
            this.panelLeft.Controls.Add(this.lblHoTen);
            this.panelLeft.Location = new System.Drawing.Point(31, 91);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panelLeft.Size = new System.Drawing.Size(613, 554);
            this.panelLeft.TabIndex = 1;
            // 
            // lblDanToc
            // 
            this.lblDanToc.AutoSize = false;
            this.lblDanToc.BackColor = System.Drawing.Color.Transparent;
            this.lblDanToc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDanToc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanToc.Location = new System.Drawing.Point(27, 395);
            this.lblDanToc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDanToc.Name = "lblDanToc";
            this.lblDanToc.Size = new System.Drawing.Size(559, 74);
            this.lblDanToc.TabIndex = 5;
            this.lblDanToc.Text = "Dân tộc: ";
            this.lblDanToc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = false;
            this.lblDienThoai.BackColor = System.Drawing.Color.Transparent;
            this.lblDienThoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDienThoai.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.Location = new System.Drawing.Point(27, 321);
            this.lblDienThoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(559, 74);
            this.lblDienThoai.TabIndex = 4;
            this.lblDienThoai.Text = "Điện thoại: ";
            this.lblDienThoai.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = false;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(27, 247);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(559, 74);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email: ";
            this.lblEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = false;
            this.lblCCCD.BackColor = System.Drawing.Color.Transparent;
            this.lblCCCD.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCCCD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD.Location = new System.Drawing.Point(27, 173);
            this.lblCCCD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(559, 74);
            this.lblCCCD.TabIndex = 2;
            this.lblCCCD.Text = "CCCD: ";
            this.lblCCCD.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = false;
            this.lblGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiTinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(27, 99);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(559, 74);
            this.lblGioiTinh.TabIndex = 1;
            this.lblGioiTinh.Text = "Giới tính: ";
            this.lblGioiTinh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = false;
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(27, 25);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(559, 74);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên: ";
            this.lblHoTen.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(31, 28);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(394, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thông tin cá nhân giáo viên";
            // 
            // ThongTinGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelRoot);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThongTinGiaoVien";
            this.Size = new System.Drawing.Size(1312, 752);
            this.panelRoot.ResumeLayout(false);
            this.panelRoot.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}