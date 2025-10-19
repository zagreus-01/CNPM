using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.Controls.AdminControls
{
    partial class MonHocControl
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
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBoChon = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaVinhVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.dgvMonHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.chkMo = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkTatCaMon = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkMonKhoa = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkMonNangKhieu = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkTietDoi = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtTenMon = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenMon = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelBottom.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(1101, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ MÔN HỌC";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panelButtons);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.FillColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Location = new System.Drawing.Point(0, 419);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1101, 69);
            this.panelBottom.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnXoaVinhVien);
            this.panelButtons.Controls.Add(this.btnXoa);
            this.panelButtons.Controls.Add(this.btnBoChon);
            this.panelButtons.Controls.Add(this.btnLuu);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(60, 10, 0, 0);
            this.panelButtons.Size = new System.Drawing.Size(1101, 69);
            this.panelButtons.TabIndex = 0;
            this.panelButtons.WrapContents = false;
            // 
            // btnBoChon
            // 
            this.btnBoChon.BorderRadius = 8;
            this.btnBoChon.FillColor = System.Drawing.Color.Gray;
            this.btnBoChon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBoChon.ForeColor = System.Drawing.Color.White;
            this.btnBoChon.Location = new System.Drawing.Point(572, 10);
            this.btnBoChon.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.Size = new System.Drawing.Size(130, 38);
            this.btnBoChon.TabIndex = 3;
            this.btnBoChon.Text = "Bỏ chọn";
            this.btnBoChon.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnXoaVinhVien
            // 
            this.btnXoaVinhVien.BorderRadius = 8;
            this.btnXoaVinhVien.FillColor = System.Drawing.Color.DarkRed;
            this.btnXoaVinhVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaVinhVien.ForeColor = System.Drawing.Color.White;
            this.btnXoaVinhVien.Location = new System.Drawing.Point(862, 10);
            this.btnXoaVinhVien.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnXoaVinhVien.Name = "btnXoaVinhVien";
            this.btnXoaVinhVien.Size = new System.Drawing.Size(164, 38);
            this.btnXoaVinhVien.TabIndex = 2;
            this.btnXoaVinhVien.Text = "Xóa vĩnh viễn";
            this.btnXoaVinhVien.Click += new System.EventHandler(this.btnXoaVinhVien_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.FillColor = System.Drawing.Color.IndianRed;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(717, 10);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 38);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Khóa môn";
            this.btnXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(382, 10);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(175, 38);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Thêm/Sửa/Lưu";
            this.btnLuu.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.AllowUserToAddRows = false;
            this.dgvMonHoc.AllowUserToDeleteRows = false;
            this.dgvMonHoc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMonHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMonHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonHoc.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonHoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMonHoc.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvMonHoc.Location = new System.Drawing.Point(40, 169);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.ReadOnly = true;
            this.dgvMonHoc.RowHeadersVisible = false;
            this.dgvMonHoc.RowHeadersWidth = 51;
            this.dgvMonHoc.Size = new System.Drawing.Size(1020, 244);
            this.dgvMonHoc.TabIndex = 2;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMonHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMonHoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonHoc.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvMonHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMonHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMonHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMonHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMonHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMonHoc.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvMonHoc.ThemeStyle.ReadOnly = true;
            this.dgvMonHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMonHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMonHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMonHoc.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMonHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // chkMo
            // 
            this.chkMo.AutoSize = true;
            this.chkMo.Checked = true;
            this.chkMo.CheckedState.BorderRadius = 0;
            this.chkMo.CheckedState.BorderThickness = 0;
            this.chkMo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkMo.Location = new System.Drawing.Point(723, 129);
            this.chkMo.Name = "chkMo";
            this.chkMo.Size = new System.Drawing.Size(58, 29);
            this.chkMo.TabIndex = 3;
            this.chkMo.Text = "Mở";
            this.chkMo.UncheckedState.BorderRadius = 0;
            this.chkMo.UncheckedState.BorderThickness = 0;
            // 
            // chkTatCaMon
            // 
            this.chkTatCaMon.AutoSize = true;
            this.chkTatCaMon.CheckedState.BorderRadius = 0;
            this.chkTatCaMon.CheckedState.BorderThickness = 0;
            this.chkTatCaMon.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkTatCaMon.Location = new System.Drawing.Point(941, 129);
            this.chkTatCaMon.Name = "chkTatCaMon";
            this.chkTatCaMon.Size = new System.Drawing.Size(149, 29);
            this.chkTatCaMon.TabIndex = 4;
            this.chkTatCaMon.Text = "Tất cả các môn";
            this.chkTatCaMon.UncheckedState.BorderRadius = 0;
            this.chkTatCaMon.UncheckedState.BorderThickness = 0;
            this.chkTatCaMon.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // chkMonKhoa
            // 
            this.chkMonKhoa.AutoSize = true;
            this.chkMonKhoa.CheckedState.BorderRadius = 0;
            this.chkMonKhoa.CheckedState.BorderThickness = 0;
            this.chkMonKhoa.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkMonKhoa.Location = new System.Drawing.Point(799, 129);
            this.chkMonKhoa.Name = "chkMonKhoa";
            this.chkMonKhoa.Size = new System.Drawing.Size(112, 29);
            this.chkMonKhoa.TabIndex = 5;
            this.chkMonKhoa.Text = "Môn khóa";
            this.chkMonKhoa.UncheckedState.BorderRadius = 0;
            this.chkMonKhoa.UncheckedState.BorderThickness = 0;
            this.chkMonKhoa.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkMonNangKhieu
            // 
            this.chkMonNangKhieu.AutoSize = true;
            this.chkMonNangKhieu.CheckedState.BorderRadius = 0;
            this.chkMonNangKhieu.CheckedState.BorderThickness = 0;
            this.chkMonNangKhieu.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkMonNangKhieu.Location = new System.Drawing.Point(526, 129);
            this.chkMonNangKhieu.Name = "chkMonNangKhieu";
            this.chkMonNangKhieu.Size = new System.Drawing.Size(160, 29);
            this.chkMonNangKhieu.TabIndex = 6;
            this.chkMonNangKhieu.Text = "Môn năng khiếu";
            this.chkMonNangKhieu.UncheckedState.BorderRadius = 0;
            this.chkMonNangKhieu.UncheckedState.BorderThickness = 0;
            // 
            // chkTietDoi
            // 
            this.chkTietDoi.AutoSize = true;
            this.chkTietDoi.CheckedState.BorderRadius = 0;
            this.chkTietDoi.CheckedState.BorderThickness = 0;
            this.chkTietDoi.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkTietDoi.Location = new System.Drawing.Point(376, 129);
            this.chkTietDoi.Name = "chkTietDoi";
            this.chkTietDoi.Size = new System.Drawing.Size(90, 29);
            this.chkTietDoi.TabIndex = 7;
            this.chkTietDoi.Text = "Tiết đôi";
            this.chkTietDoi.UncheckedState.BorderRadius = 0;
            this.chkTietDoi.UncheckedState.BorderThickness = 0;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenMon.DefaultText = "";
            this.txtTenMon.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTenMon.Location = new System.Drawing.Point(124, 125);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.PlaceholderText = "Nhập tên môn học...";
            this.txtTenMon.SelectedText = "";
            this.txtTenMon.Size = new System.Drawing.Size(228, 36);
            this.txtTenMon.TabIndex = 8;
            // 
            // lblTenMon
            // 
            this.lblTenMon.BackColor = System.Drawing.Color.Transparent;
            this.lblTenMon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTenMon.Location = new System.Drawing.Point(49, 129);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(83, 27);
            this.lblTenMon.TabIndex = 9;
            this.lblTenMon.Text = "Tên môn:";
            // 
            // MonHocControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTenMon);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.chkTietDoi);
            this.Controls.Add(this.chkMonNangKhieu);
            this.Controls.Add(this.chkMonKhoa);
            this.Controls.Add(this.chkTatCaMon);
            this.Controls.Add(this.chkMo);
            this.Controls.Add(this.dgvMonHoc);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.lblTitle);
            this.Name = "MonHocControl";
            this.Size = new System.Drawing.Size(1101, 488);
            this.panelBottom.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Panel panelBottom;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private Guna.UI2.WinForms.Guna2Button btnBoChon;
        private Guna.UI2.WinForms.Guna2Button btnXoaVinhVien;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMonHoc;
        private Guna.UI2.WinForms.Guna2CheckBox chkMo;
        private Guna.UI2.WinForms.Guna2CheckBox chkTatCaMon;
        private Guna.UI2.WinForms.Guna2CheckBox chkMonKhoa;
        private Guna.UI2.WinForms.Guna2CheckBox chkMonNangKhieu;
        private Guna.UI2.WinForms.Guna2CheckBox chkTietDoi;
        private Guna.UI2.WinForms.Guna2TextBox txtTenMon;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenMon;
    }
}