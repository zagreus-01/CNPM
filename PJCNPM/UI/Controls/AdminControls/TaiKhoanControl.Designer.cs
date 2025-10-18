using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.Controls.AdminControls
{
    partial class TaiKhoanControl
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
            this.tabControl2 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnTrangThaiHS = new Guna.UI2.WinForms.Guna2Button();
            this.dgvHocSinh = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnVaiTroHS = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKiemHS = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiemHS = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnTrangThaiGV = new Guna.UI2.WinForms.Guna2Button();
            this.dgvGiaoVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnVaiTroGV = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKiemGV = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiemGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(1277, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ TÀI KHOẢN";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl2.Location = new System.Drawing.Point(0, 69);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1277, 419);
            this.tabControl2.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl2.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl2.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl2.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl2.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl2.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl2.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl2.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl2.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControl2.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl2.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl2.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabControl2.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl2.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControl2.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabControl2.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabControl2.TabIndex = 1;
            this.tabControl2.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.btnTrangThaiHS);
            this.tabPage3.Controls.Add(this.dgvHocSinh);
            this.tabPage3.Controls.Add(this.btnVaiTroHS);
            this.tabPage3.Controls.Add(this.btnTimKiemHS);
            this.tabPage3.Controls.Add(this.txtTimKiemHS);
            this.tabPage3.Location = new System.Drawing.Point(184, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1089, 411);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Tài khoản học sinh";
            // 
            // btnTrangThaiHS
            // 
            this.btnTrangThaiHS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrangThaiHS.BorderRadius = 8;
            this.btnTrangThaiHS.FillColor = System.Drawing.Color.Orange;
            this.btnTrangThaiHS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTrangThaiHS.ForeColor = System.Drawing.Color.White;
            this.btnTrangThaiHS.Location = new System.Drawing.Point(755, 18);
            this.btnTrangThaiHS.Name = "btnTrangThaiHS";
            this.btnTrangThaiHS.Size = new System.Drawing.Size(276, 36);
            this.btnTrangThaiHS.TabIndex = 4;
            this.btnTrangThaiHS.Text = "Cấu hình trạng thái nhiều đối tượng";
            this.btnTrangThaiHS.Click += new System.EventHandler(this.button13_Click);
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
            this.dgvHocSinh.Location = new System.Drawing.Point(3, 69);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.RowHeadersVisible = false;
            this.dgvHocSinh.RowHeadersWidth = 51;
            this.dgvHocSinh.Size = new System.Drawing.Size(1059, 339);
            this.dgvHocSinh.TabIndex = 3;
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
            this.dgvHocSinh.ThemeStyle.ReadOnly = false;
            this.dgvHocSinh.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHocSinh.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHocSinh.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHocSinh.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHocSinh.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHocSinh.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHocSinh.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHocSinh.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellDoubleClick);
            this.dgvHocSinh.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvHocSinh_CurrentCellDirtyStateChanged);
            // 
            // btnVaiTroHS
            // 
            this.btnVaiTroHS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVaiTroHS.BorderRadius = 8;
            this.btnVaiTroHS.FillColor = System.Drawing.Color.SeaGreen;
            this.btnVaiTroHS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVaiTroHS.ForeColor = System.Drawing.Color.White;
            this.btnVaiTroHS.Location = new System.Drawing.Point(461, 18);
            this.btnVaiTroHS.Name = "btnVaiTroHS";
            this.btnVaiTroHS.Size = new System.Drawing.Size(268, 36);
            this.btnVaiTroHS.TabIndex = 2;
            this.btnVaiTroHS.Text = "Cấu hình vai trò nhiều đối tượng";
            this.btnVaiTroHS.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnTimKiemHS
            // 
            this.btnTimKiemHS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemHS.BorderRadius = 8;
            this.btnTimKiemHS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnTimKiemHS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemHS.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemHS.Location = new System.Drawing.Point(307, 18);
            this.btnTimKiemHS.Name = "btnTimKiemHS";
            this.btnTimKiemHS.Size = new System.Drawing.Size(128, 36);
            this.btnTimKiemHS.TabIndex = 1;
            this.btnTimKiemHS.Text = "Tìm kiếm";
            this.btnTimKiemHS.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtTimKiemHS
            // 
            this.txtTimKiemHS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemHS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemHS.DefaultText = "";
            this.txtTimKiemHS.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTimKiemHS.Location = new System.Drawing.Point(15, 15);
            this.txtTimKiemHS.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTimKiemHS.Name = "txtTimKiemHS";
            this.txtTimKiemHS.PlaceholderText = "Tìm kiếm học sinh...";
            this.txtTimKiemHS.SelectedText = "";
            this.txtTimKiemHS.Size = new System.Drawing.Size(275, 36);
            this.txtTimKiemHS.TabIndex = 0;
            this.txtTimKiemHS.TextChanged += new System.EventHandler(this.txtTimKiemHS_TextChanged);
            this.txtTimKiemHS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiemHS_KeyDown);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.btnTrangThaiGV);
            this.tabPage4.Controls.Add(this.dgvGiaoVien);
            this.tabPage4.Controls.Add(this.btnVaiTroGV);
            this.tabPage4.Controls.Add(this.btnTimKiemGV);
            this.tabPage4.Controls.Add(this.txtTimKiemGV);
            this.tabPage4.Location = new System.Drawing.Point(184, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1089, 411);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Tài khoản giáo viên";
            // 
            // btnTrangThaiGV
            // 
            this.btnTrangThaiGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrangThaiGV.BorderRadius = 8;
            this.btnTrangThaiGV.FillColor = System.Drawing.Color.Orange;
            this.btnTrangThaiGV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTrangThaiGV.ForeColor = System.Drawing.Color.White;
            this.btnTrangThaiGV.Location = new System.Drawing.Point(792, 17);
            this.btnTrangThaiGV.Name = "btnTrangThaiGV";
            this.btnTrangThaiGV.Size = new System.Drawing.Size(271, 36);
            this.btnTrangThaiGV.TabIndex = 7;
            this.btnTrangThaiGV.Text = "Cấu hình trạng thái nhiều đối tượng";
            this.btnTrangThaiGV.Click += new System.EventHandler(this.button14_Click);
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.AllowUserToAddRows = false;
            this.dgvGiaoVien.AllowUserToDeleteRows = false;
            this.dgvGiaoVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvGiaoVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGiaoVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGiaoVien.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiaoVien.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGiaoVien.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvGiaoVien.Location = new System.Drawing.Point(3, 59);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.RowHeadersVisible = false;
            this.dgvGiaoVien.RowHeadersWidth = 51;
            this.dgvGiaoVien.Size = new System.Drawing.Size(1006, 339);
            this.dgvGiaoVien.TabIndex = 6;
            this.dgvGiaoVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiaoVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGiaoVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGiaoVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGiaoVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGiaoVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiaoVien.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGiaoVien.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvGiaoVien.ThemeStyle.ReadOnly = false;
            this.dgvGiaoVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGiaoVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGiaoVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGiaoVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvGiaoVien.ThemeStyle.RowsStyle.Height = 22;
            this.dgvGiaoVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGiaoVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvGiaoVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellDoubleClick);
            this.dgvGiaoVien.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvGiaoVien_CurrentCellDirtyStateChanged);
            // 
            // btnVaiTroGV
            // 
            this.btnVaiTroGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVaiTroGV.BorderRadius = 8;
            this.btnVaiTroGV.FillColor = System.Drawing.Color.SeaGreen;
            this.btnVaiTroGV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVaiTroGV.ForeColor = System.Drawing.Color.White;
            this.btnVaiTroGV.Location = new System.Drawing.Point(505, 17);
            this.btnVaiTroGV.Name = "btnVaiTroGV";
            this.btnVaiTroGV.Size = new System.Drawing.Size(265, 36);
            this.btnVaiTroGV.TabIndex = 5;
            this.btnVaiTroGV.Text = "Cấu hình vai trò nhiều đối tượng";
            this.btnVaiTroGV.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnTimKiemGV
            // 
            this.btnTimKiemGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemGV.BorderRadius = 8;
            this.btnTimKiemGV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnTimKiemGV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemGV.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemGV.Location = new System.Drawing.Point(371, 17);
            this.btnTimKiemGV.Name = "btnTimKiemGV";
            this.btnTimKiemGV.Size = new System.Drawing.Size(128, 36);
            this.btnTimKiemGV.TabIndex = 4;
            this.btnTimKiemGV.Text = "Tìm kiếm";
            this.btnTimKiemGV.Click += new System.EventHandler(this.button12_Click);
            // 
            // txtTimKiemGV
            // 
            this.txtTimKiemGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemGV.DefaultText = "";
            this.txtTimKiemGV.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTimKiemGV.Location = new System.Drawing.Point(3, 15);
            this.txtTimKiemGV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTimKiemGV.Name = "txtTimKiemGV";
            this.txtTimKiemGV.PlaceholderText = "Tìm kiếm giáo viên...";
            this.txtTimKiemGV.SelectedText = "";
            this.txtTimKiemGV.Size = new System.Drawing.Size(343, 36);
            this.txtTimKiemGV.TabIndex = 3;
            this.txtTimKiemGV.TextChanged += new System.EventHandler(this.txtTimKiemGV_TextChanged);
            this.txtTimKiemGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiemGV_KeyDown);
            // 
            // TaiKhoanControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.lblTitle);
            this.Name = "TaiKhoanControl";
            this.Size = new System.Drawing.Size(1277, 488);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemHS;
        private Guna.UI2.WinForms.Guna2Button btnVaiTroHS;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemHS;
        private Guna.UI2.WinForms.Guna2Button btnVaiTroGV;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemGV;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemGV;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHocSinh;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGiaoVien;
        private Guna.UI2.WinForms.Guna2Button btnTrangThaiHS;
        private Guna.UI2.WinForms.Guna2Button btnTrangThaiGV;
    }
}