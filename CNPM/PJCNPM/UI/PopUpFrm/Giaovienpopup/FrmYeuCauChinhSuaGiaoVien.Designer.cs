using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace PJCNPM.UI.PopUpFrm.GiaoVienPopUp
{
    partial class FrmYeuCauChinhSuaGiaoVien
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel panelMain;
        private Guna2Panel panelHeader;
        private Guna2HtmlLabel lblTitle;
        private Guna2ControlBox btnClose;
        private Guna2Panel panelContent;
        private TableLayoutPanel table;
        private Guna2HtmlLabel lbHoTen;
        private Guna2TextBox txtHoTen;
        private Guna2HtmlLabel lbGioiTinh;
        private Guna2ComboBox cboGioiTinh;
        private Guna2HtmlLabel lbNgaySinh;
        private Guna2DateTimePicker dtpNgaySinh;
        private Guna2HtmlLabel lbCCCD;
        private Guna2TextBox txtCCCD;
        private Guna2HtmlLabel lbEmail;
        private Guna2TextBox txtEmail;
        private Guna2HtmlLabel lbDienThoai;
        private Guna2TextBox txtDienThoai;
        private Guna2HtmlLabel lbDanToc;
        private Guna2TextBox txtDanToc;
        private Guna2HtmlLabel lbTonGiao;
        private Guna2TextBox txtTonGiao;
        private Guna2HtmlLabel lbQueQuan;
        private Guna2TextBox txtQueQuan;
        private Guna2HtmlLabel lbNoiThuongTru;
        private Guna2TextBox txtNoiThuongTru;
        private Guna2HtmlLabel lbLaDangVien;
        private Guna2CheckBox chkLaDangVien;
        private Guna2Panel panelFooter;
        private Guna2HtmlLabel lblTrangThai;
        private Guna2Button btnLuu;
        private Guna2Button btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.lbHoTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbGioiTinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbNgaySinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbCCCD = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbDienThoai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbDanToc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDanToc = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTonGiao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTonGiao = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbQueQuan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtQueQuan = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbNoiThuongTru = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNoiThuongTru = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbLaDangVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chkLaDangVien = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panelFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTrangThai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelMain.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.table.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderColor = System.Drawing.Color.LightGray;
            this.panelMain.BorderThickness = 1;
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Controls.Add(this.panelFooter);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(950, 550);
            this.panelMain.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.table);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelContent.Size = new System.Drawing.Size(950, 420);
            this.panelContent.TabIndex = 1;
            // 
            // table
            // 
            this.table.ColumnCount = 4;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.Controls.Add(this.lbHoTen, 0, 0);
            this.table.Controls.Add(this.txtHoTen, 1, 0);
            this.table.Controls.Add(this.lbGioiTinh, 2, 0);
            this.table.Controls.Add(this.cboGioiTinh, 3, 0);
            this.table.Controls.Add(this.lbNgaySinh, 0, 1);
            this.table.Controls.Add(this.dtpNgaySinh, 1, 1);
            this.table.Controls.Add(this.lbCCCD, 2, 1);
            this.table.Controls.Add(this.txtCCCD, 3, 1);
            this.table.Controls.Add(this.lbEmail, 0, 2);
            this.table.Controls.Add(this.txtEmail, 1, 2);
            this.table.Controls.Add(this.lbDienThoai, 2, 2);
            this.table.Controls.Add(this.txtDienThoai, 3, 2);
            this.table.Controls.Add(this.lbDanToc, 0, 3);
            this.table.Controls.Add(this.txtDanToc, 1, 3);
            this.table.Controls.Add(this.lbTonGiao, 2, 3);
            this.table.Controls.Add(this.txtTonGiao, 3, 3);
            this.table.Controls.Add(this.lbQueQuan, 0, 4);
            this.table.Controls.Add(this.txtQueQuan, 1, 4);
            this.table.Controls.Add(this.lbNoiThuongTru, 0, 5);
            this.table.Controls.Add(this.txtNoiThuongTru, 1, 5);
            this.table.Controls.Add(this.lbLaDangVien, 0, 6);
            this.table.Controls.Add(this.chkLaDangVien, 1, 6);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(20, 20);
            this.table.Name = "table";
            this.table.RowCount = 7;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.table.Size = new System.Drawing.Size(910, 380);
            this.table.TabIndex = 0;
            // 
            // lbHoTen
            // 
            this.lbHoTen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lbHoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbHoTen.Location = new System.Drawing.Point(3, 17);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(61, 19);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Họ tên (*)";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.BorderRadius = 5;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Location = new System.Drawing.Point(123, 8);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.PlaceholderText = "Nhập họ và tên";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(329, 36);
            this.txtHoTen.TabIndex = 0;
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.lbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbGioiTinh.Location = new System.Drawing.Point(458, 17);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(54, 19);
            this.lbGioiTinh.TabIndex = 2;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cboGioiTinh.BorderRadius = 5;
            this.cboGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGioiTinh.ItemHeight = 30;
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cboGioiTinh.Location = new System.Drawing.Point(578, 8);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(329, 36);
            this.cboGioiTinh.TabIndex = 1;
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lbNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbNgaySinh.Location = new System.Drawing.Point(3, 69);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(63, 19);
            this.lbNgaySinh.TabIndex = 4;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgaySinh.BorderRadius = 5;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(123, 60);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(329, 36);
            this.dtpNgaySinh.TabIndex = 2;
            this.dtpNgaySinh.Value = new System.DateTime(2023, 10, 27, 0, 0, 0, 0);
            // 
            // lbCCCD
            // 
            this.lbCCCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCCCD.BackColor = System.Drawing.Color.Transparent;
            this.lbCCCD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbCCCD.Location = new System.Drawing.Point(458, 69);
            this.lbCCCD.Name = "lbCCCD";
            this.lbCCCD.Size = new System.Drawing.Size(37, 19);
            this.lbCCCD.TabIndex = 6;
            this.lbCCCD.Text = "CCCD";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCCCD.BorderRadius = 5;
            this.txtCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCCD.DefaultText = "";
            this.txtCCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Location = new System.Drawing.Point(578, 60);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.PasswordChar = '\0';
            this.txtCCCD.PlaceholderText = "12 chữ số";
            this.txtCCCD.SelectedText = "";
            this.txtCCCD.Size = new System.Drawing.Size(329, 36);
            this.txtCCCD.TabIndex = 3;
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbEmail.Location = new System.Drawing.Point(3, 121);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(34, 19);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BorderRadius = 5;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(123, 112);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "example@email.com";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(329, 36);
            this.txtEmail.TabIndex = 4;
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDienThoai.BackColor = System.Drawing.Color.Transparent;
            this.lbDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbDienThoai.Location = new System.Drawing.Point(458, 121);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(65, 19);
            this.lbDienThoai.TabIndex = 10;
            this.lbDienThoai.Text = "Điện thoại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDienThoai.BorderRadius = 5;
            this.txtDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDienThoai.DefaultText = "";
            this.txtDienThoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDienThoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDienThoai.Location = new System.Drawing.Point(578, 112);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.PasswordChar = '\0';
            this.txtDienThoai.PlaceholderText = "Số điện thoại";
            this.txtDienThoai.SelectedText = "";
            this.txtDienThoai.Size = new System.Drawing.Size(329, 36);
            this.txtDienThoai.TabIndex = 5;
            // 
            // lbDanToc
            // 
            this.lbDanToc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDanToc.BackColor = System.Drawing.Color.Transparent;
            this.lbDanToc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbDanToc.Location = new System.Drawing.Point(3, 173);
            this.lbDanToc.Name = "lbDanToc";
            this.lbDanToc.Size = new System.Drawing.Size(51, 19);
            this.lbDanToc.TabIndex = 12;
            this.lbDanToc.Text = "Dân tộc";
            // 
            // txtDanToc
            // 
            this.txtDanToc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDanToc.BorderRadius = 5;
            this.txtDanToc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDanToc.DefaultText = "";
            this.txtDanToc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDanToc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDanToc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDanToc.Location = new System.Drawing.Point(123, 164);
            this.txtDanToc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.PasswordChar = '\0';
            this.txtDanToc.PlaceholderText = "";
            this.txtDanToc.SelectedText = "";
            this.txtDanToc.Size = new System.Drawing.Size(329, 36);
            this.txtDanToc.TabIndex = 6;
            // 
            // lbTonGiao
            // 
            this.lbTonGiao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTonGiao.BackColor = System.Drawing.Color.Transparent;
            this.lbTonGiao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbTonGiao.Location = new System.Drawing.Point(458, 173);
            this.lbTonGiao.Name = "lbTonGiao";
            this.lbTonGiao.Size = new System.Drawing.Size(56, 19);
            this.lbTonGiao.TabIndex = 14;
            this.lbTonGiao.Text = "Tôn giáo";
            // 
            // txtTonGiao
            // 
            this.txtTonGiao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTonGiao.BorderRadius = 5;
            this.txtTonGiao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTonGiao.DefaultText = "";
            this.txtTonGiao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTonGiao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTonGiao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTonGiao.Location = new System.Drawing.Point(578, 164);
            this.txtTonGiao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTonGiao.Name = "txtTonGiao";
            this.txtTonGiao.PasswordChar = '\0';
            this.txtTonGiao.PlaceholderText = "";
            this.txtTonGiao.SelectedText = "";
            this.txtTonGiao.Size = new System.Drawing.Size(329, 36);
            this.txtTonGiao.TabIndex = 7;
            // 
            // lbQueQuan
            // 
            this.lbQueQuan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbQueQuan.BackColor = System.Drawing.Color.Transparent;
            this.lbQueQuan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbQueQuan.Location = new System.Drawing.Point(3, 225);
            this.lbQueQuan.Name = "lbQueQuan";
            this.lbQueQuan.Size = new System.Drawing.Size(62, 19);
            this.lbQueQuan.TabIndex = 16;
            this.lbQueQuan.Text = "Quê quán";
            // 
            // txtQueQuan
            // 
            this.table.SetColumnSpan(this.txtQueQuan, 3);
            this.txtQueQuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueQuan.BorderRadius = 5;
            this.txtQueQuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQueQuan.DefaultText = "";
            this.txtQueQuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQueQuan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtQueQuan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQueQuan.Location = new System.Drawing.Point(123, 216);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.PasswordChar = '\0';
            this.txtQueQuan.PlaceholderText = "";
            this.txtQueQuan.SelectedText = "";
            this.txtQueQuan.Size = new System.Drawing.Size(784, 36);
            this.txtQueQuan.TabIndex = 8;
            // 
            // lbNoiThuongTru
            // 
            this.lbNoiThuongTru.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNoiThuongTru.BackColor = System.Drawing.Color.Transparent;
            this.lbNoiThuongTru.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbNoiThuongTru.Location = new System.Drawing.Point(3, 277);
            this.lbNoiThuongTru.Name = "lbNoiThuongTru";
            this.lbNoiThuongTru.Size = new System.Drawing.Size(91, 19);
            this.lbNoiThuongTru.TabIndex = 18;
            this.lbNoiThuongTru.Text = "Nơi thường trú";
            // 
            // txtNoiThuongTru
            // 
            this.table.SetColumnSpan(this.txtNoiThuongTru, 3);
            this.txtNoiThuongTru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiThuongTru.BorderRadius = 5;
            this.txtNoiThuongTru.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoiThuongTru.DefaultText = "";
            this.txtNoiThuongTru.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiThuongTru.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNoiThuongTru.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiThuongTru.Location = new System.Drawing.Point(123, 268);
            this.txtNoiThuongTru.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoiThuongTru.Name = "txtNoiThuongTru";
            this.txtNoiThuongTru.PasswordChar = '\0';
            this.txtNoiThuongTru.PlaceholderText = "";
            this.txtNoiThuongTru.SelectedText = "";
            this.txtNoiThuongTru.Size = new System.Drawing.Size(784, 36);
            this.txtNoiThuongTru.TabIndex = 9;
            // 
            // lbLaDangVien
            // 
            this.lbLaDangVien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbLaDangVien.BackColor = System.Drawing.Color.Transparent;
            this.lbLaDangVien.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbLaDangVien.Location = new System.Drawing.Point(3, 333);
            this.lbLaDangVien.Name = "lbLaDangVien";
            this.lbLaDangVien.Size = new System.Drawing.Size(81, 19);
            this.lbLaDangVien.TabIndex = 22;
            this.lbLaDangVien.Text = "Là Đảng viên";
            // 
            // chkLaDangVien
            // 
            this.chkLaDangVien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkLaDangVien.AutoSize = true;
            this.chkLaDangVien.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkLaDangVien.CheckedState.BorderRadius = 2;
            this.chkLaDangVien.CheckedState.BorderThickness = 0;
            this.chkLaDangVien.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkLaDangVien.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkLaDangVien.Location = new System.Drawing.Point(123, 331);
            this.chkLaDangVien.Name = "chkLaDangVien";
            this.chkLaDangVien.Size = new System.Drawing.Size(15, 23);
            this.chkLaDangVien.TabIndex = 10;
            this.chkLaDangVien.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkLaDangVien.UncheckedState.BorderRadius = 2;
            this.chkLaDangVien.UncheckedState.BorderThickness = 0;
            this.chkLaDangVien.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.lblTrangThai);
            this.panelFooter.Controls.Add(this.btnLuu);
            this.panelFooter.Controls.Add(this.btnHuy);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelFooter.Location = new System.Drawing.Point(0, 470);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(20);
            this.panelFooter.Size = new System.Drawing.Size(950, 80);
            this.panelFooter.TabIndex = 2;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.Gray;
            this.lblTrangThai.Location = new System.Drawing.Point(23, 29);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(209, 22);
            this.lblTrangThai.TabIndex = 2;
            this.lblTrangThai.Text = "Trạng thái: Chưa có yêu cầu";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(647, 20);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 40);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Gửi Yêu Cầu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(803, 20);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Đóng";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(950, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(359, 27);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Yêu Cầu Chỉnh Sửa Thông Tin Cá Nhân";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(905, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 0;
            // 
            // FrmYeuCauChinhSuaGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmYeuCauChinhSuaGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yêu cầu chỉnh sửa";
            this.Load += new System.EventHandler(this.FrmYeuCauChinhSuaGiaoVien_Load);
            this.panelMain.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);           
        }
    }
}

