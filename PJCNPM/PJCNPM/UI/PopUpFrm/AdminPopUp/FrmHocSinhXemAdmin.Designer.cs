using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    partial class FrmHocSinhXemAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2HtmlLabel lblTitle, lblHoTen, lblNgaySinh, lblGioiTinh, lblDanToc, lblTonGiao, lblQueQuan, lblNamNhapHoc, lblTrangThai, lblLop;
        private Guna2TextBox txtHoTen, txtDanToc, txtTonGiao, txtQueQuan;
        private Guna2DateTimePicker dtNgaySinh;
        private Guna2CheckBox chkNam, chkNu;
        private NumericUpDown numNamNhapHoc;
        private Guna2ComboBox cboTrangThai, cboLop;
        private Guna2Button btnHocBa, btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new Guna2HtmlLabel();
            this.lblHoTen = new Guna2HtmlLabel();
            this.lblNgaySinh = new Guna2HtmlLabel();
            this.lblGioiTinh = new Guna2HtmlLabel();
            this.lblDanToc = new Guna2HtmlLabel();
            this.lblTonGiao = new Guna2HtmlLabel();
            this.lblQueQuan = new Guna2HtmlLabel();
            this.lblNamNhapHoc = new Guna2HtmlLabel();
            this.lblTrangThai = new Guna2HtmlLabel();
            this.lblLop = new Guna2HtmlLabel();
            this.txtHoTen = new Guna2TextBox();
            this.txtDanToc = new Guna2TextBox();
            this.txtTonGiao = new Guna2TextBox();
            this.txtQueQuan = new Guna2TextBox();
            this.dtNgaySinh = new Guna2DateTimePicker();
            this.chkNam = new Guna2CheckBox();
            this.chkNu = new Guna2CheckBox();
            this.numNamNhapHoc = new NumericUpDown();
            this.cboTrangThai = new Guna2ComboBox();
            this.cboLop = new Guna2ComboBox();
            this.btnHocBa = new Guna2Button();
            this.btnDong = new Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNamNhapHoc)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTitle.Text = "THÔNG TIN HỌC SINH";
            this.lblTitle.Size = new Size(550, 60);
            this.lblTitle.TextAlignment = ContentAlignment.MiddleCenter;

            // lblHoTen
            this.lblHoTen.Text = "Họ tên:";
            this.lblHoTen.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.lblHoTen.Location = new Point(40, 80);

            // txtHoTen
            this.txtHoTen.Location = new Point(170, 75);
            this.txtHoTen.Size = new Size(320, 36);
            this.txtHoTen.BorderRadius = 6;

            // lblNgaySinh
            this.lblNgaySinh.Text = "Ngày sinh:";
            this.lblNgaySinh.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.lblNgaySinh.Location = new Point(40, 135);

            // dtNgaySinh
            this.dtNgaySinh.Location = new Point(170, 130);
            this.dtNgaySinh.Size = new Size(320, 36);
            this.dtNgaySinh.Format = DateTimePickerFormat.Short;
            this.dtNgaySinh.BorderRadius = 6;

            // lblGioiTinh
            this.lblGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.lblGioiTinh.Location = new Point(40, 190);

            // chkNam
            this.chkNam.Text = "Nam";
            this.chkNam.Font = new Font("Segoe UI", 10.5F);
            this.chkNam.Location = new Point(170, 190);

            // chkNu
            this.chkNu.Text = "Nữ";
            this.chkNu.Font = new Font("Segoe UI", 10.5F);
            this.chkNu.Location = new Point(260, 190);

            // lblDanToc
            this.lblDanToc.Text = "Dân tộc:";
            this.lblDanToc.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.lblDanToc.Location = new Point(40, 245);

            // txtDanToc
            this.txtDanToc.Location = new Point(170, 240);
            this.txtDanToc.Size = new Size(320, 36);
            this.txtDanToc.BorderRadius = 6;

            // lblTonGiao
            this.lblTonGiao.Text = "Tôn giáo:";
            this.lblTonGiao.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.lblTonGiao.Location = new Point(40, 300);

            // txtTonGiao
            this.txtTonGiao.Location = new Point(170, 295);
            this.txtTonGiao.Size = new Size(320, 36);
            this.txtTonGiao.BorderRadius = 6;

            // lblQueQuan
            this.lblQueQuan.Text = "Quê quán:";
            this.lblQueQuan.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.lblQueQuan.Location = new Point(40, 355);

            // txtQueQuan
            this.txtQueQuan.Location = new Point(170, 350);
            this.txtQueQuan.Size = new Size(320, 36);
            this.txtQueQuan.BorderRadius = 6;

            // lblNamNhapHoc
            this.lblNamNhapHoc.Text = "Năm nhập học:";
            this.lblNamNhapHoc.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.lblNamNhapHoc.Location = new Point(40, 410);

            // numNamNhapHoc
            this.numNamNhapHoc.Location = new Point(180, 410);
            this.numNamNhapHoc.Font = new Font("Segoe UI", 10.5F);
            this.numNamNhapHoc.Minimum = 2000;
            this.numNamNhapHoc.Maximum = 2100;
            this.numNamNhapHoc.Value = 2025;

            // lblTrangThai
            this.lblTrangThai.Text = "Trạng thái:";
            this.lblTrangThai.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.lblTrangThai.Location = new Point(40, 460);

            // cboTrangThai
            this.cboTrangThai.Location = new Point(170, 455);
            this.cboTrangThai.Size = new Size(320, 36);
            this.cboTrangThai.BorderRadius = 6;

            // lblLop
            this.lblLop.Text = "Lớp:";
            this.lblLop.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.lblLop.Location = new Point(40, 515);

            // cboLop
            this.cboLop.Location = new Point(170, 510);
            this.cboLop.Size = new Size(320, 36);
            this.cboLop.BorderRadius = 6;

            // btnHocBa
            this.btnHocBa.Text = "Xem học bạ";
            this.btnHocBa.Location = new Point(170, 570);
            this.btnHocBa.Size = new Size(150, 40);
            this.btnHocBa.BorderRadius = 8;
            this.btnHocBa.FillColor = Color.RoyalBlue;
            this.btnHocBa.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.btnHocBa.ForeColor = Color.White;

            // btnDong
            this.btnDong.Text = "Đóng";
            this.btnDong.Location = new Point(340, 570);
            this.btnDong.Size = new Size(150, 40);
            this.btnDong.BorderRadius = 8;
            this.btnDong.FillColor = Color.Gray;
            this.btnDong.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.btnDong.ForeColor = Color.White;

            // Form settings
            this.ClientSize = new Size(550, 650);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Xem thông tin học sinh";
            this.Controls.AddRange(new Control[]
            {
                lblTitle, lblHoTen, txtHoTen, lblNgaySinh, dtNgaySinh, lblGioiTinh, chkNam, chkNu,
                lblDanToc, txtDanToc, lblTonGiao, txtTonGiao, lblQueQuan, txtQueQuan,
                lblNamNhapHoc, numNamNhapHoc, lblTrangThai, cboTrangThai,
                lblLop, cboLop, btnHocBa, btnDong
            });

            ((System.ComponentModel.ISupportInitialize)(this.numNamNhapHoc)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
