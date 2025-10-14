namespace PJCNPM.UI.PopUpFrm.HocSinhPopUp
{
    partial class FrmYeuCauChinhSuaHocSinh
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHoTen;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgaySinh;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGioiTinh;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDanToc;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTonGiao;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQueQuan;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtNgaySinh;
        private Guna.UI2.WinForms.Guna2CheckBox chkNam;
        private Guna.UI2.WinForms.Guna2CheckBox chkNu;
        private Guna.UI2.WinForms.Guna2TextBox txtDanToc;
        private Guna.UI2.WinForms.Guna2TextBox txtTonGiao;
        private Guna.UI2.WinForms.Guna2TextBox txtQueQuan;
        private Guna.UI2.WinForms.Guna2Button btnGui;
        private Guna.UI2.WinForms.Guna2Button btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHoTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNgaySinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGioiTinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDanToc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTonGiao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblQueQuan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.chkNam = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkNu = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtDanToc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTonGiao = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQueQuan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGui = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.AutoSize = false;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(30, 15, 0, 15);
            this.lblTitle.Size = new System.Drawing.Size(500, 63);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CHỈNH SỬA THÔNG TIN HỌC SINH";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            // txtHoTen
            // 
            this.txtHoTen.BorderRadius = 6;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(150, 75);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(300, 36);
            this.txtHoTen.TabIndex = 2;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.BorderRadius = 6;
            this.dtNgaySinh.Checked = true;
            this.dtNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(150, 130);
            this.dtNgaySinh.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtNgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(300, 36);
            this.dtNgaySinh.TabIndex = 4;
            this.dtNgaySinh.Value = new System.DateTime(2025, 10, 13, 18, 40, 10, 310);
            // 
            // chkNam
            // 
            this.chkNam.AutoSize = true;
            this.chkNam.CheckedState.BorderRadius = 0;
            this.chkNam.CheckedState.BorderThickness = 0;
            this.chkNam.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkNam.Location = new System.Drawing.Point(150, 190);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(72, 29);
            this.chkNam.TabIndex = 6;
            this.chkNam.Text = "Nam";
            this.chkNam.UncheckedState.BorderRadius = 0;
            this.chkNam.UncheckedState.BorderThickness = 0;
            // 
            // chkNu
            // 
            this.chkNu.AutoSize = true;
            this.chkNu.CheckedState.BorderRadius = 0;
            this.chkNu.CheckedState.BorderThickness = 0;
            this.chkNu.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkNu.Location = new System.Drawing.Point(250, 190);
            this.chkNu.Name = "chkNu";
            this.chkNu.Size = new System.Drawing.Size(58, 29);
            this.chkNu.TabIndex = 7;
            this.chkNu.Text = "Nữ";
            this.chkNu.UncheckedState.BorderRadius = 0;
            this.chkNu.UncheckedState.BorderThickness = 0;
            // 
            // txtDanToc
            // 
            this.txtDanToc.BorderRadius = 6;
            this.txtDanToc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDanToc.DefaultText = "";
            this.txtDanToc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDanToc.ForeColor = System.Drawing.Color.Black;
            this.txtDanToc.Location = new System.Drawing.Point(150, 240);
            this.txtDanToc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.PlaceholderText = "";
            this.txtDanToc.SelectedText = "";
            this.txtDanToc.Size = new System.Drawing.Size(300, 36);
            this.txtDanToc.TabIndex = 9;
            // 
            // txtTonGiao
            // 
            this.txtTonGiao.BorderRadius = 6;
            this.txtTonGiao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTonGiao.DefaultText = "";
            this.txtTonGiao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTonGiao.ForeColor = System.Drawing.Color.Black;
            this.txtTonGiao.Location = new System.Drawing.Point(150, 295);
            this.txtTonGiao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTonGiao.Name = "txtTonGiao";
            this.txtTonGiao.PlaceholderText = "";
            this.txtTonGiao.SelectedText = "";
            this.txtTonGiao.Size = new System.Drawing.Size(300, 36);
            this.txtTonGiao.TabIndex = 11;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.BorderRadius = 6;
            this.txtQueQuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQueQuan.DefaultText = "";
            this.txtQueQuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQueQuan.ForeColor = System.Drawing.Color.Black;
            this.txtQueQuan.Location = new System.Drawing.Point(150, 350);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.PlaceholderText = "";
            this.txtQueQuan.SelectedText = "";
            this.txtQueQuan.Size = new System.Drawing.Size(300, 36);
            this.txtQueQuan.TabIndex = 13;
            // 
            // btnGui
            // 
            this.btnGui.BorderRadius = 8;
            this.btnGui.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.Location = new System.Drawing.Point(90, 440);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(150, 40);
            this.btnGui.TabIndex = 14;
            this.btnGui.Text = "Gửi yêu cầu";
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.FillColor = System.Drawing.Color.Gray;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(260, 440);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 40);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy";
            // 
            // YeuCauChinhSuaHocSinh
            // 
            this.ClientSize = new System.Drawing.Size(500, 520);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnGui);
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
            this.Name = "YeuCauChinhSuaHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}