using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.Controls.AdminControls
{
    partial class PhanCongControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBoChon = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaGV = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuuGV = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaPhanCong = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemPhanCong = new Guna.UI2.WinForms.Guna2Button();
            this.dgvNghiepVuGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvPhanCong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cboMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMonHoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboLop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblLop = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboLopChuNhiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chkChuNhiem = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtGioiHanTiet = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGioiHanTiet = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTenGiaoVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboGiaoVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSoTiet = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSoTiet = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chkShowInactiveClasses = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cboNamHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNamHoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblHocKy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnXemTheoKy = new Guna.UI2.WinForms.Guna2Button();
            this.panelBottom.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNghiepVuGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).BeginInit();
            this.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(1454, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ PHÂN CÔNG GIẢNG DẠY";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panelButtons);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.FillColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Location = new System.Drawing.Point(0, 420);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1454, 69);
            this.panelBottom.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnBoChon);
            this.panelButtons.Controls.Add(this.btnXoaGV);
            this.panelButtons.Controls.Add(this.btnLuuGV);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(60, 10, 0, 0);
            this.panelButtons.Size = new System.Drawing.Size(1454, 69);
            this.panelButtons.TabIndex = 0;
            this.panelButtons.WrapContents = false;
            // 
            // btnBoChon
            // 
            this.btnBoChon.BorderRadius = 8;
            this.btnBoChon.FillColor = System.Drawing.Color.Gray;
            this.btnBoChon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBoChon.ForeColor = System.Drawing.Color.White;
            this.btnBoChon.Location = new System.Drawing.Point(1249, 10);
            this.btnBoChon.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.Size = new System.Drawing.Size(130, 38);
            this.btnBoChon.TabIndex = 4;
            this.btnBoChon.Text = "Bỏ chọn";
            this.btnBoChon.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.BorderRadius = 8;
            this.btnXoaGV.FillColor = System.Drawing.Color.IndianRed;
            this.btnXoaGV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaGV.ForeColor = System.Drawing.Color.White;
            this.btnXoaGV.Location = new System.Drawing.Point(1104, 10);
            this.btnXoaGV.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(130, 38);
            this.btnXoaGV.TabIndex = 3;
            this.btnXoaGV.Text = "Xóa GV";
            this.btnXoaGV.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnLuuGV
            // 
            this.btnLuuGV.BorderRadius = 8;
            this.btnLuuGV.FillColor = System.Drawing.Color.SeaGreen;
            this.btnLuuGV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuuGV.ForeColor = System.Drawing.Color.White;
            this.btnLuuGV.Location = new System.Drawing.Point(959, 10);
            this.btnLuuGV.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnLuuGV.Name = "btnLuuGV";
            this.btnLuuGV.Size = new System.Drawing.Size(130, 38);
            this.btnLuuGV.TabIndex = 2;
            this.btnLuuGV.Text = "Lưu/Sửa GV";
            this.btnLuuGV.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnXoaPhanCong
            // 
            this.btnXoaPhanCong.BorderRadius = 8;
            this.btnXoaPhanCong.FillColor = System.Drawing.Color.OrangeRed;
            this.btnXoaPhanCong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaPhanCong.ForeColor = System.Drawing.Color.White;
            this.btnXoaPhanCong.Location = new System.Drawing.Point(1242, 148);
            this.btnXoaPhanCong.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnXoaPhanCong.Name = "btnXoaPhanCong";
            this.btnXoaPhanCong.Size = new System.Drawing.Size(181, 38);
            this.btnXoaPhanCong.TabIndex = 1;
            this.btnXoaPhanCong.Text = "Xóa phân công";
            this.btnXoaPhanCong.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnThemPhanCong
            // 
            this.btnThemPhanCong.BorderRadius = 8;
            this.btnThemPhanCong.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnThemPhanCong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemPhanCong.ForeColor = System.Drawing.Color.White;
            this.btnThemPhanCong.Location = new System.Drawing.Point(1046, 151);
            this.btnThemPhanCong.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnThemPhanCong.Name = "btnThemPhanCong";
            this.btnThemPhanCong.Size = new System.Drawing.Size(171, 38);
            this.btnThemPhanCong.TabIndex = 0;
            this.btnThemPhanCong.Text = "Thêm phân công";
            this.btnThemPhanCong.Click += new System.EventHandler(this.button7_Click);
            // 
            // dgvNghiepVuGV
            // 
            this.dgvNghiepVuGV.AllowUserToAddRows = false;
            this.dgvNghiepVuGV.AllowUserToDeleteRows = false;
            this.dgvNghiepVuGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvNghiepVuGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNghiepVuGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNghiepVuGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNghiepVuGV.ColumnHeadersHeight = 40;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNghiepVuGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNghiepVuGV.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvNghiepVuGV.Location = new System.Drawing.Point(38, 278);
            this.dgvNghiepVuGV.Name = "dgvNghiepVuGV";
            this.dgvNghiepVuGV.ReadOnly = true;
            this.dgvNghiepVuGV.RowHeadersVisible = false;
            this.dgvNghiepVuGV.RowHeadersWidth = 51;
            this.dgvNghiepVuGV.Size = new System.Drawing.Size(1373, 136);
            this.dgvNghiepVuGV.TabIndex = 2;
            this.dgvNghiepVuGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNghiepVuGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNghiepVuGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNghiepVuGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNghiepVuGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNghiepVuGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNghiepVuGV.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvNghiepVuGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNghiepVuGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNghiepVuGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNghiepVuGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNghiepVuGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNghiepVuGV.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvNghiepVuGV.ThemeStyle.ReadOnly = true;
            this.dgvNghiepVuGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNghiepVuGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNghiepVuGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNghiepVuGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNghiepVuGV.ThemeStyle.RowsStyle.Height = 22;
            this.dgvNghiepVuGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNghiepVuGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNghiepVuGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNghiepVuGV_CellClick);
            // 
            // dgvPhanCong
            // 
            this.dgvPhanCong.AllowUserToAddRows = false;
            this.dgvPhanCong.AllowUserToDeleteRows = false;
            this.dgvPhanCong.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvPhanCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPhanCong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPhanCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPhanCong.ColumnHeadersHeight = 40;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhanCong.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPhanCong.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvPhanCong.Location = new System.Drawing.Point(38, 192);
            this.dgvPhanCong.Name = "dgvPhanCong";
            this.dgvPhanCong.ReadOnly = true;
            this.dgvPhanCong.RowHeadersVisible = false;
            this.dgvPhanCong.RowHeadersWidth = 51;
            this.dgvPhanCong.Size = new System.Drawing.Size(1385, 140);
            this.dgvPhanCong.TabIndex = 3;
            this.dgvPhanCong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhanCong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPhanCong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPhanCong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPhanCong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPhanCong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhanCong.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvPhanCong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPhanCong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPhanCong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhanCong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPhanCong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhanCong.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvPhanCong.ThemeStyle.ReadOnly = true;
            this.dgvPhanCong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhanCong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhanCong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhanCong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPhanCong.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPhanCong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhanCong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPhanCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhanCong_CellClick);
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboMonHoc.BorderRadius = 6;
            this.cboMonHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.FocusedColor = System.Drawing.Color.Empty;
            this.cboMonHoc.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cboMonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboMonHoc.ItemHeight = 30;
            this.cboMonHoc.Location = new System.Drawing.Point(519, 148);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(186, 36);
            this.cboMonHoc.TabIndex = 6;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblMonHoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMonHoc.Location = new System.Drawing.Point(365, 158);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(83, 27);
            this.lblMonHoc.TabIndex = 7;
            this.lblMonHoc.Text = "Môn học:";
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
            this.cboLop.Location = new System.Drawing.Point(116, 148);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(102, 36);
            this.cboLop.TabIndex = 8;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // lblLop
            // 
            this.lblLop.BackColor = System.Drawing.Color.Transparent;
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLop.Location = new System.Drawing.Point(38, 158);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(39, 27);
            this.lblLop.TabIndex = 9;
            this.lblLop.Text = "Lớp:";
            // 
            // cboLopChuNhiem
            // 
            this.cboLopChuNhiem.BackColor = System.Drawing.Color.Transparent;
            this.cboLopChuNhiem.BorderRadius = 6;
            this.cboLopChuNhiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLopChuNhiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopChuNhiem.FocusedColor = System.Drawing.Color.Empty;
            this.cboLopChuNhiem.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cboLopChuNhiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLopChuNhiem.ItemHeight = 30;
            this.cboLopChuNhiem.Location = new System.Drawing.Point(871, 104);
            this.cboLopChuNhiem.Name = "cboLopChuNhiem";
            this.cboLopChuNhiem.Size = new System.Drawing.Size(101, 36);
            this.cboLopChuNhiem.TabIndex = 10;
            // 
            // chkChuNhiem
            // 
            this.chkChuNhiem.AutoSize = true;
            this.chkChuNhiem.CheckedState.BorderRadius = 0;
            this.chkChuNhiem.CheckedState.BorderThickness = 0;
            this.chkChuNhiem.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkChuNhiem.Location = new System.Drawing.Point(746, 111);
            this.chkChuNhiem.Name = "chkChuNhiem";
            this.chkChuNhiem.Size = new System.Drawing.Size(119, 29);
            this.chkChuNhiem.TabIndex = 11;
            this.chkChuNhiem.Text = "Chủ nhiệm";
            this.chkChuNhiem.UncheckedState.BorderRadius = 0;
            this.chkChuNhiem.UncheckedState.BorderThickness = 0;
            // 
            // txtGioiHanTiet
            // 
            this.txtGioiHanTiet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGioiHanTiet.DefaultText = "";
            this.txtGioiHanTiet.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtGioiHanTiet.Location = new System.Drawing.Point(519, 113);
            this.txtGioiHanTiet.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtGioiHanTiet.Name = "txtGioiHanTiet";
            this.txtGioiHanTiet.PlaceholderText = "Nhập giới hạn...";
            this.txtGioiHanTiet.SelectedText = "";
            this.txtGioiHanTiet.Size = new System.Drawing.Size(142, 27);
            this.txtGioiHanTiet.TabIndex = 12;
            // 
            // lblGioiHanTiet
            // 
            this.lblGioiHanTiet.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiHanTiet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGioiHanTiet.Location = new System.Drawing.Point(365, 118);
            this.lblGioiHanTiet.Name = "lblGioiHanTiet";
            this.lblGioiHanTiet.Size = new System.Drawing.Size(160, 27);
            this.lblGioiHanTiet.TabIndex = 13;
            this.lblGioiHanTiet.Text = "Giới hạn tiết/tuần:";
            // 
            // lblTenGiaoVien
            // 
            this.lblTenGiaoVien.BackColor = System.Drawing.Color.Transparent;
            this.lblTenGiaoVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTenGiaoVien.Location = new System.Drawing.Point(38, 118);
            this.lblTenGiaoVien.Name = "lblTenGiaoVien";
            this.lblTenGiaoVien.Size = new System.Drawing.Size(88, 27);
            this.lblTenGiaoVien.TabIndex = 14;
            this.lblTenGiaoVien.Text = "Giáo viên:";
            // 
            // cboGiaoVien
            // 
            this.cboGiaoVien.BackColor = System.Drawing.Color.Transparent;
            this.cboGiaoVien.BorderRadius = 6;
            this.cboGiaoVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiaoVien.FocusedColor = System.Drawing.Color.Empty;
            this.cboGiaoVien.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cboGiaoVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGiaoVien.ItemHeight = 30;
            this.cboGiaoVien.Location = new System.Drawing.Point(116, 111);
            this.cboGiaoVien.Name = "cboGiaoVien";
            this.cboGiaoVien.Size = new System.Drawing.Size(243, 36);
            this.cboGiaoVien.TabIndex = 15;
            // 
            // txtSoTiet
            // 
            this.txtSoTiet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoTiet.DefaultText = "";
            this.txtSoTiet.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtSoTiet.Location = new System.Drawing.Point(864, 153);
            this.txtSoTiet.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSoTiet.Name = "txtSoTiet";
            this.txtSoTiet.PlaceholderText = "Nhập số tiết...";
            this.txtSoTiet.SelectedText = "";
            this.txtSoTiet.Size = new System.Drawing.Size(134, 36);
            this.txtSoTiet.TabIndex = 16;
            // 
            // lblSoTiet
            // 
            this.lblSoTiet.BackColor = System.Drawing.Color.Transparent;
            this.lblSoTiet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSoTiet.Location = new System.Drawing.Point(746, 157);
            this.lblSoTiet.Name = "lblSoTiet";
            this.lblSoTiet.Size = new System.Drawing.Size(63, 27);
            this.lblSoTiet.TabIndex = 17;
            this.lblSoTiet.Text = "Số tiết:";
            // 
            // chkShowInactiveClasses
            // 
            this.chkShowInactiveClasses.AutoSize = true;
            this.chkShowInactiveClasses.CheckedState.BorderRadius = 0;
            this.chkShowInactiveClasses.CheckedState.BorderThickness = 0;
            this.chkShowInactiveClasses.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkShowInactiveClasses.Location = new System.Drawing.Point(38, 62);
            this.chkShowInactiveClasses.Name = "chkShowInactiveClasses";
            this.chkShowInactiveClasses.Size = new System.Drawing.Size(219, 29);
            this.chkShowInactiveClasses.TabIndex = 18;
            this.chkShowInactiveClasses.Text = "Hiển thị lớp đã kết thúc";
            this.chkShowInactiveClasses.UncheckedState.BorderRadius = 0;
            this.chkShowInactiveClasses.UncheckedState.BorderThickness = 0;
            this.chkShowInactiveClasses.CheckedChanged += new System.EventHandler(this.chkShowInactiveClasses_CheckedChanged);
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboNamHoc.BorderRadius = 6;
            this.cboNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.FocusedColor = System.Drawing.Color.Empty;
            this.cboNamHoc.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cboNamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNamHoc.ItemHeight = 30;
            this.cboNamHoc.Location = new System.Drawing.Point(519, 62);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(120, 36);
            this.cboNamHoc.TabIndex = 19;
            this.cboNamHoc.SelectedIndexChanged += new System.EventHandler(this.cboNamHoc_SelectedIndexChanged);
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblNamHoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNamHoc.Location = new System.Drawing.Point(365, 64);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(84, 27);
            this.lblNamHoc.TabIndex = 20;
            this.lblNamHoc.Text = "Năm học:";
            // 
            // cboHocKy
            // 
            this.cboHocKy.BackColor = System.Drawing.Color.Transparent;
            this.cboHocKy.BorderRadius = 6;
            this.cboHocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocKy.FocusedColor = System.Drawing.Color.Empty;
            this.cboHocKy.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cboHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboHocKy.ItemHeight = 30;
            this.cboHocKy.Location = new System.Drawing.Point(872, 64);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(100, 36);
            this.cboHocKy.TabIndex = 21;
            // 
            // lblHocKy
            // 
            this.lblHocKy.BackColor = System.Drawing.Color.Transparent;
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHocKy.Location = new System.Drawing.Point(742, 62);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(67, 27);
            this.lblHocKy.TabIndex = 22;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // btnXemTheoKy
            // 
            this.btnXemTheoKy.BorderRadius = 8;
            this.btnXemTheoKy.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXemTheoKy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXemTheoKy.ForeColor = System.Drawing.Color.White;
            this.btnXemTheoKy.Location = new System.Drawing.Point(1046, 62);
            this.btnXemTheoKy.Name = "btnXemTheoKy";
            this.btnXemTheoKy.Size = new System.Drawing.Size(120, 36);
            this.btnXemTheoKy.TabIndex = 23;
            this.btnXemTheoKy.Text = "Xem theo kỳ";
            this.btnXemTheoKy.Click += new System.EventHandler(this.btnXemTheoKy_Click);
            // 
            // PhanCongControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblSoTiet);
            this.Controls.Add(this.txtSoTiet);
            this.Controls.Add(this.cboGiaoVien);
            this.Controls.Add(this.btnXemTheoKy);
            this.Controls.Add(this.lblTenGiaoVien);
            this.Controls.Add(this.cboHocKy);
            this.Controls.Add(this.lblGioiHanTiet);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.btnXoaPhanCong);
            this.Controls.Add(this.cboNamHoc);
            this.Controls.Add(this.txtGioiHanTiet);
            this.Controls.Add(this.lblNamHoc);
            this.Controls.Add(this.btnThemPhanCong);
            this.Controls.Add(this.chkShowInactiveClasses);
            this.Controls.Add(this.chkChuNhiem);
            this.Controls.Add(this.cboLopChuNhiem);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.cboMonHoc);
            this.Controls.Add(this.dgvPhanCong);
            this.Controls.Add(this.dgvNghiepVuGV);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.lblTitle);
            this.Name = "PhanCongControl";
            this.Size = new System.Drawing.Size(1454, 489);
            this.panelBottom.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNghiepVuGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Panel panelBottom;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private Guna.UI2.WinForms.Guna2Button btnBoChon;
        private Guna.UI2.WinForms.Guna2Button btnXoaGV;
        private Guna.UI2.WinForms.Guna2Button btnLuuGV;
        private Guna.UI2.WinForms.Guna2Button btnXoaPhanCong;
        private Guna.UI2.WinForms.Guna2Button btnThemPhanCong;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNghiepVuGV;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhanCong;
        private Guna.UI2.WinForms.Guna2ComboBox cboMonHoc;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMonHoc;
        private Guna.UI2.WinForms.Guna2ComboBox cboLop;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLop;
        private Guna.UI2.WinForms.Guna2ComboBox cboLopChuNhiem;
        private Guna.UI2.WinForms.Guna2CheckBox chkChuNhiem;
        private Guna.UI2.WinForms.Guna2TextBox txtGioiHanTiet;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGioiHanTiet;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenGiaoVien;
        private Guna.UI2.WinForms.Guna2ComboBox cboGiaoVien;
        private Guna.UI2.WinForms.Guna2TextBox txtSoTiet;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoTiet;
        private Guna.UI2.WinForms.Guna2CheckBox chkShowInactiveClasses;
        private Guna.UI2.WinForms.Guna2ComboBox cboNamHoc;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNamHoc;
        private Guna.UI2.WinForms.Guna2ComboBox cboHocKy;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHocKy;
        private Guna.UI2.WinForms.Guna2Button btnXemTheoKy;
    }
}