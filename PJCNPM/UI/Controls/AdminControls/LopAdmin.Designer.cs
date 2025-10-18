using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.Controls.AdminControls
{
    partial class LopAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2HtmlLabel lblNamHoc;
        private Guna2HtmlLabel lblHocKi;
        private Guna2ComboBox cboNamHoc;
        private Guna2ComboBox cboHocKi;
        private Guna2CheckBox chkDaKetThuc;
        private Guna2TextBox txtTimKiem;
        private Guna2Button btnLoc;
        private Guna2DataGridView dgvLop;
        private Guna2Panel panelBottom;
        private FlowLayoutPanel panelButtons;
        private Guna2Button btnThem;
        private Guna2Button btnSua;
        private Guna2Button btnXoa;
        private Guna2Button btnChuyenHocSinh;
        private Guna2HtmlLabel lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle altRowStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.lblNamHoc = new Guna2HtmlLabel();
            this.lblHocKi = new Guna2HtmlLabel();
            this.cboNamHoc = new Guna2ComboBox();
            this.cboHocKi = new Guna2ComboBox();
            this.chkDaKetThuc = new Guna2CheckBox();
            this.txtTimKiem = new Guna2TextBox();
            this.btnLoc = new Guna2Button();
            this.dgvLop = new Guna2DataGridView();
            this.panelBottom = new Guna2Panel();
            this.panelButtons = new FlowLayoutPanel();
            this.btnXoa = new Guna2Button();
            this.btnChuyenHocSinh = new Guna2Button();
            this.btnSua = new Guna2Button();
            this.btnThem = new Guna2Button();
            this.lblTitle = new Guna2HtmlLabel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // ===== Label Năm học =====
            this.lblNamHoc.BackColor = Color.Transparent;
            this.lblNamHoc.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblNamHoc.Location = new Point(40, 75);
            this.lblNamHoc.Text = "Năm học:";

            // ===== Label Học kỳ =====
            this.lblHocKi.BackColor = Color.Transparent;
            this.lblHocKi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblHocKi.Location = new Point(290, 75);
            this.lblHocKi.Text = "Học kỳ:";

            // ===== ComboBox Năm học =====
            this.cboNamHoc.BackColor = Color.Transparent;
            this.cboNamHoc.BorderRadius = 6;
            this.cboNamHoc.DrawMode = DrawMode.OwnerDrawFixed;
            this.cboNamHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboNamHoc.Font = new Font("Segoe UI", 10.5F);
            this.cboNamHoc.ForeColor = Color.Black;
            this.cboNamHoc.ItemHeight = 30;
            this.cboNamHoc.Location = new Point(130, 70);
            this.cboNamHoc.Size = new Size(140, 36);
            this.cboNamHoc.SelectedIndexChanged += new System.EventHandler(this.cboNamHoc_SelectedIndexChanged);

            // ===== ComboBox Học kỳ =====
            this.cboHocKi.BackColor = Color.Transparent;
            this.cboHocKi.BorderRadius = 6;
            this.cboHocKi.DrawMode = DrawMode.OwnerDrawFixed;
            this.cboHocKi.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboHocKi.Font = new Font("Segoe UI", 10.5F);
            this.cboHocKi.ForeColor = Color.Black;
            this.cboHocKi.ItemHeight = 30;
            this.cboHocKi.Location = new Point(360, 70);
            this.cboHocKi.Size = new Size(100, 36);
            this.cboHocKi.SelectedIndexChanged += new System.EventHandler(this.cboHocKi_SelectedIndexChanged);

            // ===== CheckBox Hiển thị lớp đã kết thúc =====
            this.chkDaKetThuc.AutoSize = true;
            this.chkDaKetThuc.Font = new Font("Segoe UI", 10.5F);
            this.chkDaKetThuc.ForeColor = Color.Black;
            this.chkDaKetThuc.Location = new Point(480, 75);
            this.chkDaKetThuc.Text = "Hiển thị lớp đã kết thúc";
            this.chkDaKetThuc.CheckedChanged += new System.EventHandler(this.chkDaKetThuc_CheckedChanged);

            // ===== TextBox Tìm kiếm =====
            this.txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.txtTimKiem.Font = new Font("Segoe UI", 10.5F);
            this.txtTimKiem.PlaceholderText = "Tìm kiếm theo tên lớp...";
            this.txtTimKiem.Location = new Point(630, 70);
            this.txtTimKiem.Size = new Size(310, 36);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);

            // ===== Button Lọc =====
            this.btnLoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnLoc.BorderRadius = 6;
            this.btnLoc.FillColor = Color.FromArgb(0, 120, 215);
            this.btnLoc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLoc.ForeColor = Color.White;
            this.btnLoc.Location = new Point(955, 70);
            this.btnLoc.Size = new Size(70, 36);
            this.btnLoc.Text = "Lọc";
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);

            // ===== DataGridView =====
            this.dgvLop.AllowUserToAddRows = false;
            this.dgvLop.AllowUserToDeleteRows = false;
            this.dgvLop.AllowUserToResizeRows = false;
            this.dgvLop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvLop.Location = new Point(40, 120);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.ReadOnly = true;
            this.dgvLop.RowHeadersVisible = false;
            this.dgvLop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvLop.GridColor = Color.Gainsboro;

            // --- Header style ---
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.FromArgb(0, 120, 215);
            headerStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            headerStyle.ForeColor = Color.White;
            headerStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            headerStyle.SelectionForeColor = Color.White;
            this.dgvLop.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvLop.ColumnHeadersHeight = 40;

            // --- Default rows style ---
            rowStyle.BackColor = Color.White;
            rowStyle.ForeColor = Color.Black; // ✅ chữ đen
            rowStyle.Font = new Font("Segoe UI", 10.5F);
            rowStyle.SelectionBackColor = Color.FromArgb(230, 240, 255);
            rowStyle.SelectionForeColor = Color.Black; // ✅ vẫn chữ đen khi chọn
            this.dgvLop.DefaultCellStyle = rowStyle;

            // --- Alternating rows style ---
            altRowStyle.BackColor = Color.WhiteSmoke;
            altRowStyle.ForeColor = Color.Black;
            altRowStyle.SelectionBackColor = Color.FromArgb(230, 240, 255);
            altRowStyle.SelectionForeColor = Color.Black;
            this.dgvLop.AlternatingRowsDefaultCellStyle = altRowStyle;

            // --- Theme style reset (để đảm bảo Guna2 không override) ---
            this.dgvLop.ThemeStyle.AlternatingRowsStyle.BackColor = Color.WhiteSmoke;
            this.dgvLop.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Black;
            this.dgvLop.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(230, 240, 255);
            this.dgvLop.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            this.dgvLop.ThemeStyle.BackColor = Color.White;
            this.dgvLop.ThemeStyle.GridColor = Color.Gainsboro;
            this.dgvLop.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(0, 120, 215);
            this.dgvLop.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            this.dgvLop.ThemeStyle.RowsStyle.BackColor = Color.White;
            this.dgvLop.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            this.dgvLop.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(230, 240, 255);
            this.dgvLop.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            this.dgvLop.ThemeStyle.ReadOnly = true;

            this.dgvLop.Size = new Size(1040, 364);
            this.dgvLop.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvLop_CellDoubleClick);

            // ===== Panel Bottom =====
            this.panelBottom.Controls.Add(this.panelButtons);
            this.panelBottom.Dock = DockStyle.Bottom;
            this.panelBottom.FillColor = Color.WhiteSmoke;
            this.panelBottom.Size = new Size(1166, 65);

            // ===== Panel Buttons =====
            this.panelButtons.Controls.Add(this.btnXoa);
            this.panelButtons.Controls.Add(this.btnChuyenHocSinh);
            this.panelButtons.Controls.Add(this.btnSua);
            this.panelButtons.Controls.Add(this.btnThem);
            this.panelButtons.Dock = DockStyle.Fill;
            this.panelButtons.FlowDirection = FlowDirection.RightToLeft;
            this.panelButtons.Padding = new Padding(60, 10, 0, 0);

            // ===== Buttons CRUD =====
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.FillColor = Color.IndianRed;
            this.btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnXoa.ForeColor = Color.White;
            this.btnXoa.Size = new Size(130, 38);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnChuyenHocSinh.BorderRadius = 8;
            this.btnChuyenHocSinh.FillColor = Color.MediumPurple;
            this.btnChuyenHocSinh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnChuyenHocSinh.ForeColor = Color.White;
            this.btnChuyenHocSinh.Size = new Size(160, 38);
            this.btnChuyenHocSinh.Text = "Chuyển học sinh";
            this.btnChuyenHocSinh.Click += new System.EventHandler(this.btnChuyenHocSinh_Click);

            this.btnSua.BorderRadius = 8;
            this.btnSua.FillColor = Color.SteelBlue;
            this.btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSua.ForeColor = Color.White;
            this.btnSua.Size = new Size(130, 38);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnThem.BorderRadius = 8;
            this.btnThem.FillColor = Color.DodgerBlue;
            this.btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnThem.ForeColor = Color.White;
            this.btnThem.Size = new Size(130, 38);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // ===== Label Title =====
            this.lblTitle.BackColor = Color.Transparent;
            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.Black;
            this.lblTitle.Padding = new Padding(0, 15, 0, 15);
            this.lblTitle.Text = "DANH SÁCH LỚP HỌC";
            this.lblTitle.TextAlignment = ContentAlignment.MiddleCenter;
            this.lblTitle.Size = new Size(1166, 69);

            // ===== UserControl Layout =====
            this.BackColor = Color.White;
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.chkDaKetThuc);
            this.Controls.Add(this.cboHocKi);
            this.Controls.Add(this.lblHocKi);
            this.Controls.Add(this.cboNamHoc);
            this.Controls.Add(this.lblNamHoc);
            this.Controls.Add(this.lblTitle);
            this.Name = "LopAdmin";
            this.Size = new Size(1166, 584);
            this.Load += new System.EventHandler(this.LopAdmin_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
