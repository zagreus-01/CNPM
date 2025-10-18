using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.Controls.AdminControls
{
    partial class TKBTheoLopControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLopHoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboLopHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chkHienThiGiaoVien = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnTaoTKB = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaoTKBAll = new Guna.UI2.WinForms.Guna2Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelTKB = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTKB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvTKB = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelThongKe = new Guna.UI2.WinForms.Guna2Panel();
            this.lblThongKe = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvThongKe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelTKB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).BeginInit();
            this.panelThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lblTitle.Size = new System.Drawing.Size(1200, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THỜI KHÓA BIỂU THEO LỚP";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblLopHoc);
            this.panelTop.Controls.Add(this.cboLopHoc);
            this.panelTop.Controls.Add(this.chkHienThiGiaoVien);
            this.panelTop.Controls.Add(this.btnTaoTKB);
            this.panelTop.Controls.Add(this.btnTaoTKBAll);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.FillColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Location = new System.Drawing.Point(0, 69);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelTop.Size = new System.Drawing.Size(1200, 70);
            this.panelTop.TabIndex = 1;
            // 
            // lblLopHoc
            // 
            this.lblLopHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblLopHoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLopHoc.Location = new System.Drawing.Point(20, 20);
            this.lblLopHoc.Name = "lblLopHoc";
            this.lblLopHoc.Size = new System.Drawing.Size(75, 27);
            this.lblLopHoc.TabIndex = 0;
            this.lblLopHoc.Text = "Lớp học:";
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboLopHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLopHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLopHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLopHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLopHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLopHoc.ItemHeight = 30;
            this.cboLopHoc.Location = new System.Drawing.Point(110, 15);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(250, 36);
            this.cboLopHoc.TabIndex = 1;
            this.cboLopHoc.SelectedIndexChanged += new System.EventHandler(this.cboLopHoc_SelectedIndexChanged);
            // 
            // chkHienThiGiaoVien
            // 
            this.chkHienThiGiaoVien.AutoSize = true;
            this.chkHienThiGiaoVien.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.chkHienThiGiaoVien.CheckedState.BorderRadius = 2;
            this.chkHienThiGiaoVien.CheckedState.BorderThickness = 2;
            this.chkHienThiGiaoVien.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.chkHienThiGiaoVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkHienThiGiaoVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.chkHienThiGiaoVien.Location = new System.Drawing.Point(380, 20);
            this.chkHienThiGiaoVien.Name = "chkHienThiGiaoVien";
            this.chkHienThiGiaoVien.Size = new System.Drawing.Size(193, 27);
            this.chkHienThiGiaoVien.TabIndex = 2;
            this.chkHienThiGiaoVien.Text = "Hiển thị tên giáo viên";
            this.chkHienThiGiaoVien.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkHienThiGiaoVien.UncheckedState.BorderRadius = 2;
            this.chkHienThiGiaoVien.UncheckedState.BorderThickness = 2;
            this.chkHienThiGiaoVien.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkHienThiGiaoVien.CheckedChanged += new System.EventHandler(this.chkHienThiGiaoVien_CheckedChanged);
            // 
            // btnTaoTKB
            // 
            this.btnTaoTKB.BorderRadius = 8;
            this.btnTaoTKB.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnTaoTKB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaoTKB.ForeColor = System.Drawing.Color.White;
            this.btnTaoTKB.Location = new System.Drawing.Point(600, 15);
            this.btnTaoTKB.Name = "btnTaoTKB";
            this.btnTaoTKB.Size = new System.Drawing.Size(134, 36);
            this.btnTaoTKB.TabIndex = 3;
            this.btnTaoTKB.Text = "Tạo TKB";
            this.btnTaoTKB.Click += new System.EventHandler(this.btnTaoTKB_Click);
            // 
            // btnTaoTKBAll
            // 
            this.btnTaoTKBAll.BorderRadius = 8;
            this.btnTaoTKBAll.FillColor = System.Drawing.Color.ForestGreen;
            this.btnTaoTKBAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaoTKBAll.ForeColor = System.Drawing.Color.White;
            this.btnTaoTKBAll.Location = new System.Drawing.Point(750, 15);
            this.btnTaoTKBAll.Name = "btnTaoTKBAll";
            this.btnTaoTKBAll.Size = new System.Drawing.Size(163, 36);
            this.btnTaoTKBAll.TabIndex = 3;
            this.btnTaoTKBAll.Text = "Tạo TKB Tất Cả";
            this.btnTaoTKBAll.Click += new System.EventHandler(this.btnTaoTKBAll_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 139);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelTKB);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelThongKe);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 461);
            this.splitContainer1.SplitterDistance = 275;
            this.splitContainer1.TabIndex = 2;
            // 
            // panelTKB
            // 
            this.panelTKB.Controls.Add(this.lblTKB);
            this.panelTKB.Controls.Add(this.dgvTKB);
            this.panelTKB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTKB.FillColor = System.Drawing.Color.White;
            this.panelTKB.Location = new System.Drawing.Point(0, 0);
            this.panelTKB.Name = "panelTKB";
            this.panelTKB.Padding = new System.Windows.Forms.Padding(20);
            this.panelTKB.Size = new System.Drawing.Size(1200, 275);
            this.panelTKB.TabIndex = 0;
            // 
            // lblTKB
            // 
            this.lblTKB.BackColor = System.Drawing.Color.Transparent;
            this.lblTKB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTKB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.lblTKB.Location = new System.Drawing.Point(20, 10);
            this.lblTKB.Name = "lblTKB";
            this.lblTKB.Size = new System.Drawing.Size(222, 30);
            this.lblTKB.TabIndex = 1;
            this.lblTKB.Text = "Thời khóa biểu lớp học";
            // 
            // dgvTKB
            // 
            this.dgvTKB.AllowUserToAddRows = false;
            this.dgvTKB.AllowUserToDeleteRows = false;
            this.dgvTKB.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTKB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTKB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTKB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvTKB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTKB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTKB.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTKB.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTKB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvTKB.Location = new System.Drawing.Point(20, 40);
            this.dgvTKB.Name = "dgvTKB";
            this.dgvTKB.ReadOnly = true;
            this.dgvTKB.RowHeadersVisible = false;
            this.dgvTKB.RowHeadersWidth = 51;
            this.dgvTKB.RowTemplate.Height = 30;
            this.dgvTKB.Size = new System.Drawing.Size(1160, 232);
            this.dgvTKB.TabIndex = 0;
            this.dgvTKB.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvTKB.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvTKB.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTKB.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dgvTKB.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.dgvTKB.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTKB.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvTKB.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.dgvTKB.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTKB.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvTKB.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTKB.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTKB.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvTKB.ThemeStyle.ReadOnly = true;
            this.dgvTKB.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTKB.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvTKB.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvTKB.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTKB.ThemeStyle.RowsStyle.Height = 30;
            this.dgvTKB.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dgvTKB.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.dgvTKB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTKB_CellDoubleClick);
            // 
            // panelThongKe
            // 
            this.panelThongKe.Controls.Add(this.lblThongKe);
            this.panelThongKe.Controls.Add(this.dgvThongKe);
            this.panelThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThongKe.FillColor = System.Drawing.Color.White;
            this.panelThongKe.Location = new System.Drawing.Point(0, 0);
            this.panelThongKe.Name = "panelThongKe";
            this.panelThongKe.Padding = new System.Windows.Forms.Padding(20);
            this.panelThongKe.Size = new System.Drawing.Size(1200, 182);
            this.panelThongKe.TabIndex = 0;
            // 
            // lblThongKe
            // 
            this.lblThongKe.BackColor = System.Drawing.Color.Transparent;
            this.lblThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.lblThongKe.Location = new System.Drawing.Point(20, 23);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(261, 30);
            this.lblThongKe.TabIndex = 1;
            this.lblThongKe.Text = "Thống kê giáo viên dạy lớp";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvThongKe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvThongKe.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongKe.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvThongKe.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvThongKe.Location = new System.Drawing.Point(20, 69);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersVisible = false;
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.Size = new System.Drawing.Size(1160, 93);
            this.dgvThongKe.TabIndex = 0;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongKe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongKe.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvThongKe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvThongKe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongKe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThongKe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongKe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvThongKe.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvThongKe.ThemeStyle.ReadOnly = true;
            this.dgvThongKe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongKe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongKe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThongKe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongKe.ThemeStyle.RowsStyle.Height = 22;
            this.dgvThongKe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongKe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TKBTheoLopControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lblTitle);
            this.Name = "TKBTheoLopControl";
            this.Size = new System.Drawing.Size(1200, 600);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelTKB.ResumeLayout(false);
            this.panelTKB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).EndInit();
            this.panelThongKe.ResumeLayout(false);
            this.panelThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLopHoc;
        private Guna.UI2.WinForms.Guna2ComboBox cboLopHoc;
        private Guna.UI2.WinForms.Guna2CheckBox chkHienThiGiaoVien;
        private Guna.UI2.WinForms.Guna2Button btnTaoTKB;
        private Guna.UI2.WinForms.Guna2Button btnTaoTKBAll;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2Panel panelTKB;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTKB;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTKB;
        private Guna.UI2.WinForms.Guna2Panel panelThongKe;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblThongKe;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongKe;
    }
}