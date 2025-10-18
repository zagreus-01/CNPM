namespace PJCNPM.UI.Controls.AdminControls
{
    partial class DangKyPhongHocAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabDangKy = new System.Windows.Forms.TabPage();
            this.panelLichBieu = new Guna.UI2.WinForms.Guna2Panel();
            this.tblLichBieu = new System.Windows.Forms.TableLayoutPanel();
            this.panelDangKyHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpNgayChon = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblTieuDe = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tabLichSu = new System.Windows.Forms.TabPage();
            this.dgvLichSu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelLichSuHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearchLichSu = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabControl.SuspendLayout();
            this.tabDangKy.SuspendLayout();
            this.panelLichBieu.SuspendLayout();
            this.panelDangKyHeader.SuspendLayout();
            this.tabLichSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.panelLichSuHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Top;
            this.tabControl.Controls.Add(this.tabDangKy);
            this.tabControl.Controls.Add(this.tabLichSu);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.ItemSize = new System.Drawing.Size(180, 45);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1200, 700);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.White;
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.Gray;
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.tabControl.TabButtonSize = new System.Drawing.Size(180, 45);
            this.tabControl.TabIndex = 10;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.White;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabDangKy
            // 
            this.tabDangKy.BackColor = System.Drawing.Color.White;
            this.tabDangKy.Controls.Add(this.panelLichBieu);
            this.tabDangKy.Controls.Add(this.panelDangKyHeader);
            this.tabDangKy.Location = new System.Drawing.Point(4, 49);
            this.tabDangKy.Name = "tabDangKy";
            this.tabDangKy.Padding = new System.Windows.Forms.Padding(10);
            this.tabDangKy.Size = new System.Drawing.Size(1192, 647);
            this.tabDangKy.TabIndex = 0;
            this.tabDangKy.Text = "Quản lý đăng ký";
            // 
            // panelLichBieu
            // 
            this.panelLichBieu.AutoScroll = true;
            this.panelLichBieu.BorderColor = System.Drawing.Color.Gainsboro;
            this.panelLichBieu.BorderThickness = 1;
            this.panelLichBieu.Controls.Add(this.tblLichBieu);
            this.panelLichBieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLichBieu.Location = new System.Drawing.Point(10, 70);
            this.panelLichBieu.Name = "panelLichBieu";
            this.panelLichBieu.Size = new System.Drawing.Size(1172, 567);
            this.panelLichBieu.TabIndex = 1;
            // 
            // tblLichBieu
            // 
            this.tblLichBieu.AutoSize = true;
            this.tblLichBieu.BackColor = System.Drawing.Color.White;
            this.tblLichBieu.ColumnCount = 1;
            this.tblLichBieu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLichBieu.Location = new System.Drawing.Point(0, 0);
            this.tblLichBieu.Name = "tblLichBieu";
            this.tblLichBieu.RowCount = 1;
            this.tblLichBieu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLichBieu.Size = new System.Drawing.Size(200, 100);
            this.tblLichBieu.TabIndex = 0;
            // 
            // panelDangKyHeader
            // 
            this.panelDangKyHeader.Controls.Add(this.dtpNgayChon);
            this.panelDangKyHeader.Controls.Add(this.lblTieuDe);
            this.panelDangKyHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDangKyHeader.Location = new System.Drawing.Point(10, 10);
            this.panelDangKyHeader.Name = "panelDangKyHeader";
            this.panelDangKyHeader.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelDangKyHeader.Size = new System.Drawing.Size(1172, 60);
            this.panelDangKyHeader.TabIndex = 0;
            // 
            // dtpNgayChon
            // 
            this.dtpNgayChon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayChon.BorderRadius = 6;
            this.dtpNgayChon.Checked = true;
            this.dtpNgayChon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.dtpNgayChon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayChon.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayChon.Location = new System.Drawing.Point(899, 8);
            this.dtpNgayChon.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayChon.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayChon.Name = "dtpNgayChon";
            this.dtpNgayChon.Size = new System.Drawing.Size(270, 40);
            this.dtpNgayChon.TabIndex = 1;
            this.dtpNgayChon.Value = new System.DateTime(2023, 11, 2, 21, 3, 21, 350);
            this.dtpNgayChon.ValueChanged += new System.EventHandler(this.dtpNgayChon_ValueChanged);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(370, 50);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "LỊCH BIỂU SỬ DỤNG PHÒNG HỌC";
            this.lblTieuDe.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabLichSu
            // 
            this.tabLichSu.BackColor = System.Drawing.Color.White;
            this.tabLichSu.Controls.Add(this.dgvLichSu);
            this.tabLichSu.Controls.Add(this.panelLichSuHeader);
            this.tabLichSu.Location = new System.Drawing.Point(4, 49);
            this.tabLichSu.Name = "tabLichSu";
            this.tabLichSu.Padding = new System.Windows.Forms.Padding(10);
            this.tabLichSu.Size = new System.Drawing.Size(1192, 647);
            this.tabLichSu.TabIndex = 1;
            this.tabLichSu.Text = "Lịch sử toàn hệ thống";
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AllowUserToDeleteRows = false;
            this.dgvLichSu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLichSu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLichSu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLichSu.ColumnHeadersHeight = 40;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichSu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLichSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichSu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLichSu.Location = new System.Drawing.Point(10, 65);
            this.dgvLichSu.MultiSelect = false;
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersVisible = false;
            this.dgvLichSu.RowHeadersWidth = 51;
            this.dgvLichSu.RowTemplate.Height = 35;
            this.dgvLichSu.Size = new System.Drawing.Size(1172, 572);
            this.dgvLichSu.TabIndex = 2;
            this.dgvLichSu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLichSu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLichSu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLichSu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLichSu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLichSu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLichSu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLichSu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLichSu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLichSu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvLichSu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLichSu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLichSu.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvLichSu.ThemeStyle.ReadOnly = true;
            this.dgvLichSu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLichSu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLichSu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvLichSu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLichSu.ThemeStyle.RowsStyle.Height = 35;
            this.dgvLichSu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLichSu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLichSu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichSu_CellContentClick);
            // 
            // panelLichSuHeader
            // 
            this.panelLichSuHeader.Controls.Add(this.txtSearchLichSu);
            this.panelLichSuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLichSuHeader.Location = new System.Drawing.Point(10, 10);
            this.panelLichSuHeader.Name = "panelLichSuHeader";
            this.panelLichSuHeader.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelLichSuHeader.Size = new System.Drawing.Size(1172, 55);
            this.panelLichSuHeader.TabIndex = 1;
            // 
            // txtSearchLichSu
            // 
            this.txtSearchLichSu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchLichSu.BorderRadius = 8;
            this.txtSearchLichSu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchLichSu.DefaultText = "";
            this.txtSearchLichSu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchLichSu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchLichSu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchLichSu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchLichSu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchLichSu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchLichSu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchLichSu.Location = new System.Drawing.Point(769, 5);
            this.txtSearchLichSu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchLichSu.Name = "txtSearchLichSu";
            this.txtSearchLichSu.PasswordChar = '\0';
            this.txtSearchLichSu.PlaceholderText = "Tìm kiếm theo tên giáo viên, phòng, lớp...";
            this.txtSearchLichSu.SelectedText = "";
            this.txtSearchLichSu.Size = new System.Drawing.Size(400, 40);
            this.txtSearchLichSu.TabIndex = 0;
            this.txtSearchLichSu.TextChanged += new System.EventHandler(this.txtSearchLichSu_TextChanged);
            // 
            // DangKyPhongHocAdmin
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl);
            this.Name = "DangKyPhongHocAdmin";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.DangKyPhongHocAdmin_Load);
            this.tabControl.ResumeLayout(false);
            this.tabDangKy.ResumeLayout(false);
            this.panelLichBieu.ResumeLayout(false);
            this.panelLichBieu.PerformLayout();
            this.panelDangKyHeader.ResumeLayout(false);
            this.panelDangKyHeader.PerformLayout();
            this.tabLichSu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.panelLichSuHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabControl;
        private System.Windows.Forms.TabPage tabDangKy;
        private System.Windows.Forms.TabPage tabLichSu;
        private Guna.UI2.WinForms.Guna2Panel panelLichBieu;
        private System.Windows.Forms.TableLayoutPanel tblLichBieu;
        private Guna.UI2.WinForms.Guna2Panel panelDangKyHeader;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayChon;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTieuDe;
        private Guna.UI2.WinForms.Guna2Panel panelLichSuHeader;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchLichSu;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLichSu;
    }
}