using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.Controls.AdminControls
{
    partial class HocSinhAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2HtmlLabel lblLop;
        private Guna2ComboBox cboLop;
        private Guna2TextBox txtTimKiem;
        private Guna2CheckBox chkDaKetThuc;
        private Guna2Button btnLoc;
        private Guna2Panel panelBottom;
        private FlowLayoutPanel panelButtons;
        private Guna2Button btnThem;
        private Guna2Button btnSua;
        private Guna2Button btnChuyenLop;
        private Guna2Button btnHocBa;
        private Guna2Button btnXoa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblLop = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboLop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkDaKetThuc = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnLoc = new Guna.UI2.WinForms.Guna2Button();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnHocBa = new Guna.UI2.WinForms.Guna2Button();
            this.btnChuyenLop = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvHocSinh = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelBottom.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLop
            // 
            this.lblLop.BackColor = System.Drawing.Color.Transparent;
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLop.Location = new System.Drawing.Point(40, 75);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(39, 27);
            this.lblLop.TabIndex = 6;
            this.lblLop.Text = "Lớp:";
            // 
            // cboLop
            // 
            this.cboLop.BackColor = System.Drawing.Color.Transparent;
            this.cboLop.BorderRadius = 6;
            this.cboLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FocusedColor = System.Drawing.Color.Empty;
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cboLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLop.ItemHeight = 30;
            this.cboLop.Location = new System.Drawing.Point(90, 70);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(211, 36);
            this.cboLop.TabIndex = 5;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTimKiem.Location = new System.Drawing.Point(618, 70);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "Tìm kiếm học sinh...";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(328, 36);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // chkDaKetThuc
            // 
            this.chkDaKetThuc.AutoSize = true;
            this.chkDaKetThuc.CheckedState.BorderRadius = 0;
            this.chkDaKetThuc.CheckedState.BorderThickness = 0;
            this.chkDaKetThuc.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkDaKetThuc.Location = new System.Drawing.Point(362, 75);
            this.chkDaKetThuc.Name = "chkDaKetThuc";
            this.chkDaKetThuc.Size = new System.Drawing.Size(219, 29);
            this.chkDaKetThuc.TabIndex = 4;
            this.chkDaKetThuc.Text = "Hiển thị lớp đã kết thúc";
            this.chkDaKetThuc.UncheckedState.BorderRadius = 0;
            this.chkDaKetThuc.UncheckedState.BorderThickness = 0;
            this.chkDaKetThuc.CheckedChanged += new System.EventHandler(this.chkDaKetThuc_CheckedChanged);
            // 
            // btnLoc
            // 
            this.btnLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoc.BorderRadius = 6;
            this.btnLoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(956, 70);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(70, 36);
            this.btnLoc.TabIndex = 2;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panelButtons);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.FillColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Location = new System.Drawing.Point(0, 519);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1166, 65);
            this.panelBottom.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnXoa);
            this.panelButtons.Controls.Add(this.btnHocBa);
            this.panelButtons.Controls.Add(this.btnChuyenLop);
            this.panelButtons.Controls.Add(this.btnSua);
            this.panelButtons.Controls.Add(this.btnThem);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(60, 10, 0, 0);
            this.panelButtons.Size = new System.Drawing.Size(1166, 65);
            this.panelButtons.TabIndex = 0;
            this.panelButtons.WrapContents = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.FillColor = System.Drawing.Color.IndianRed;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(961, 10);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 38);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHocBa
            // 
            this.btnHocBa.BorderRadius = 8;
            this.btnHocBa.FillColor = System.Drawing.Color.SeaGreen;
            this.btnHocBa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHocBa.ForeColor = System.Drawing.Color.White;
            this.btnHocBa.Location = new System.Drawing.Point(816, 10);
            this.btnHocBa.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnHocBa.Name = "btnHocBa";
            this.btnHocBa.Size = new System.Drawing.Size(130, 38);
            this.btnHocBa.TabIndex = 3;
            this.btnHocBa.Text = "Học bạ";
            this.btnHocBa.Click += new System.EventHandler(this.btnHocBa_Click);
            // 
            // btnChuyenLop
            // 
            this.btnChuyenLop.BorderRadius = 8;
            this.btnChuyenLop.FillColor = System.Drawing.Color.MediumPurple;
            this.btnChuyenLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChuyenLop.ForeColor = System.Drawing.Color.White;
            this.btnChuyenLop.Location = new System.Drawing.Point(671, 10);
            this.btnChuyenLop.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnChuyenLop.Name = "btnChuyenLop";
            this.btnChuyenLop.Size = new System.Drawing.Size(130, 38);
            this.btnChuyenLop.TabIndex = 2;
            this.btnChuyenLop.Text = "Chuyển lớp";
            this.btnChuyenLop.Click += new System.EventHandler(this.btnChuyenLop_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 8;
            this.btnSua.FillColor = System.Drawing.Color.SteelBlue;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(526, 10);
            this.btnSua.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(130, 38);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 8;
            this.btnThem.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(381, 10);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 38);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lblTitle.Size = new System.Drawing.Size(1166, 69);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "DANH SÁCH HỌC SINH";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.AllowUserToAddRows = false;
            this.dgvHocSinh.AllowUserToDeleteRows = false;
            this.dgvHocSinh.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHocSinh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvHocSinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHocSinh.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHocSinh.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHocSinh.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvHocSinh.Location = new System.Drawing.Point(40, 120);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.ReadOnly = true;
            this.dgvHocSinh.RowHeadersVisible = false;
            this.dgvHocSinh.RowHeadersWidth = 51;
            this.dgvHocSinh.Size = new System.Drawing.Size(1040, 364);
            this.dgvHocSinh.TabIndex = 1;
            this.dgvHocSinh.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHocSinh.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHocSinh.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHocSinh.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHocSinh.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHocSinh.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHocSinh.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvHocSinh.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHocSinh.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHocSinh.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHocSinh.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHocSinh.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHocSinh.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvHocSinh.ThemeStyle.ReadOnly = true;
            this.dgvHocSinh.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHocSinh.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHocSinh.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHocSinh.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHocSinh.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHocSinh.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHocSinh.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHocSinh.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellContentClick);
            // 
            // HocSinhAdmin
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.dgvHocSinh);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.chkDaKetThuc);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.lblTitle);
            this.Name = "HocSinhAdmin";
            this.Size = new System.Drawing.Size(1166, 584);
            this.panelBottom.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna2HtmlLabel lblTitle;
        private Guna2DataGridView dgvHocSinh;
    }
}
