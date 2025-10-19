using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.Controls.AdminControls
{
    partial class TKBGVControl
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
            this.lblGiaoVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboGiaoVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chkHienThiLop = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
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
            this.lblTitle.Text = "THỜI KHÓA BIỂU GIÁO VIÊN";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblGiaoVien);
            this.panelTop.Controls.Add(this.cboGiaoVien);
            this.panelTop.Controls.Add(this.chkHienThiLop);
            this.panelTop.Controls.Add(this.btnCapNhat);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.FillColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Location = new System.Drawing.Point(0, 69);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelTop.Size = new System.Drawing.Size(1200, 70);
            this.panelTop.TabIndex = 1;
            // 
            // lblGiaoVien
            // 
            this.lblGiaoVien.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaoVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGiaoVien.Location = new System.Drawing.Point(20, 20);
            this.lblGiaoVien.Name = "lblGiaoVien";
            this.lblGiaoVien.Size = new System.Drawing.Size(88, 27);
            this.lblGiaoVien.TabIndex = 0;
            this.lblGiaoVien.Text = "Giáo viên:";
            // 
            // cboGiaoVien
            // 
            this.cboGiaoVien.BackColor = System.Drawing.Color.Transparent;
            this.cboGiaoVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiaoVien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGiaoVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGiaoVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGiaoVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGiaoVien.ItemHeight = 30;
            this.cboGiaoVien.Location = new System.Drawing.Point(130, 15);
            this.cboGiaoVien.Name = "cboGiaoVien";
            this.cboGiaoVien.Size = new System.Drawing.Size(250, 36);
            this.cboGiaoVien.TabIndex = 1;
            this.cboGiaoVien.SelectedIndexChanged += new System.EventHandler(this.cboGiaoVien_SelectedIndexChanged);
            // 
            // chkHienThiLop
            // 
            this.chkHienThiLop.AutoSize = true;
            this.chkHienThiLop.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.chkHienThiLop.CheckedState.BorderRadius = 2;
            this.chkHienThiLop.CheckedState.BorderThickness = 2;
            this.chkHienThiLop.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.chkHienThiLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkHienThiLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.chkHienThiLop.Location = new System.Drawing.Point(400, 20);
            this.chkHienThiLop.Name = "chkHienThiLop";
            this.chkHienThiLop.Size = new System.Drawing.Size(192, 27);
            this.chkHienThiLop.TabIndex = 2;
            this.chkHienThiLop.Text = "Hiển thị tên môn học";
            this.chkHienThiLop.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkHienThiLop.UncheckedState.BorderRadius = 2;
            this.chkHienThiLop.UncheckedState.BorderThickness = 2;
            this.chkHienThiLop.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkHienThiLop.CheckedChanged += new System.EventHandler(this.chkHienThiLop_CheckedChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BorderRadius = 8;
            this.btnCapNhat.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(624, 15);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(120, 36);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
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
            this.splitContainer1.SplitterDistance = 279;
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
            this.panelTKB.Size = new System.Drawing.Size(1200, 279);
            this.panelTKB.TabIndex = 0;
            // 
            // lblTKB
            // 
            this.lblTKB.BackColor = System.Drawing.Color.Transparent;
            this.lblTKB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTKB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.lblTKB.Location = new System.Drawing.Point(20, 10);
            this.lblTKB.Name = "lblTKB";
            this.lblTKB.Size = new System.Drawing.Size(244, 30);
            this.lblTKB.TabIndex = 1;
            this.lblTKB.Text = "Thời khóa biểu giảng dạy";
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
            this.dgvTKB.Size = new System.Drawing.Size(1160, 219);
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
            this.panelThongKe.Size = new System.Drawing.Size(1200, 178);
            this.panelThongKe.TabIndex = 0;
            // 
            // lblThongKe
            // 
            this.lblThongKe.BackColor = System.Drawing.Color.Transparent;
            this.lblThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.lblThongKe.Location = new System.Drawing.Point(20, 23);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(227, 30);
            this.lblThongKe.TabIndex = 1;
            this.lblThongKe.Text = "Thống kê tiết theo môn";
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
            this.dgvThongKe.Location = new System.Drawing.Point(20, 63);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersVisible = false;
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.Size = new System.Drawing.Size(1160, 95);
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
            // TKBGVControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lblTitle);
            this.Name = "TKBGVControl";
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
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGiaoVien;
        private Guna.UI2.WinForms.Guna2ComboBox cboGiaoVien;
        private Guna.UI2.WinForms.Guna2CheckBox chkHienThiLop;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2Panel panelTKB;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTKB;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTKB;
        private Guna.UI2.WinForms.Guna2Panel panelThongKe;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblThongKe;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongKe;
    }
}