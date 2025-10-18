namespace PJCNPM.UI.Controls.GiaoVienControls
{
    partial class NhapDiemGiaoVien
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
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblChonLop = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboLop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblChonMon = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvDiemSo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnLuuDiem = new Guna.UI2.WinForms.Guna2Button();
            this.lblEmptyMessage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemSo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(950, 69);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "NHẬP ĐIỂM HỌC SINH";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChonLop
            // 
            this.lblChonLop.BackColor = System.Drawing.Color.Transparent;
            this.lblChonLop.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChonLop.Location = new System.Drawing.Point(40, 90);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new System.Drawing.Size(86, 27);
            this.lblChonLop.TabIndex = 6;
            this.lblChonLop.Text = "Chọn lớp:";
            // 
            // cboLop
            // 
            this.cboLop.BackColor = System.Drawing.Color.Transparent;
            this.cboLop.BorderRadius = 6;
            this.cboLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLop.ItemHeight = 30;
            this.cboLop.Location = new System.Drawing.Point(140, 85);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(280, 36);
            this.cboLop.TabIndex = 7;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // lblChonMon
            // 
            this.lblChonMon.BackColor = System.Drawing.Color.Transparent;
            this.lblChonMon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChonMon.Location = new System.Drawing.Point(450, 90);
            this.lblChonMon.Name = "lblChonMon";
            this.lblChonMon.Size = new System.Drawing.Size(127, 27);
            this.lblChonMon.TabIndex = 8;
            this.lblChonMon.Text = "Chọn môn học:";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboMonHoc.BorderRadius = 6;
            this.cboMonHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboMonHoc.ItemHeight = 30;
            this.cboMonHoc.Location = new System.Drawing.Point(590, 85);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(220, 36);
            this.cboMonHoc.TabIndex = 9;
            this.cboMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboMonHoc_SelectedIndexChanged);
            // 
            // dgvDiemSo
            // 
            this.dgvDiemSo.AllowUserToAddRows = false;
            this.dgvDiemSo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDiemSo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiemSo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiemSo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDiemSo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDiemSo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiemSo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiemSo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDiemSo.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiemSo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDiemSo.EnableHeadersVisualStyles = false;
            this.dgvDiemSo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDiemSo.Location = new System.Drawing.Point(40, 140);
            this.dgvDiemSo.Name = "dgvDiemSo";
            this.dgvDiemSo.RowHeadersVisible = false;
            this.dgvDiemSo.RowTemplate.Height = 28;
            this.dgvDiemSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDiemSo.Size = new System.Drawing.Size(870, 310);
            this.dgvDiemSo.TabIndex = 10;
            this.dgvDiemSo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiemSo.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDiemSo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDiemSo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dgvDiemSo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDiemSo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiemSo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDiemSo.ThemeStyle.ReadOnly = false;
            this.dgvDiemSo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiemSo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiemSo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiemSo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDiemSo.ThemeStyle.RowsStyle.Height = 28;
            this.dgvDiemSo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDiemSo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDiemSo.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDiemSo_CellValidating);
            this.dgvDiemSo.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDiemSo_DataError);
            // 
            // btnLuuDiem
            // 
            this.btnLuuDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuDiem.BorderRadius = 6;
            this.btnLuuDiem.FillColor = System.Drawing.Color.SeaGreen;
            this.btnLuuDiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuuDiem.ForeColor = System.Drawing.Color.White;
            this.btnLuuDiem.Location = new System.Drawing.Point(750, 465);
            this.btnLuuDiem.Name = "btnLuuDiem";
            this.btnLuuDiem.Size = new System.Drawing.Size(160, 45);
            this.btnLuuDiem.TabIndex = 11;
            this.btnLuuDiem.Text = "Lưu điểm";
            this.btnLuuDiem.Click += new System.EventHandler(this.btnLuuDiem_Click);
            // 
            // lblEmptyMessage
            // 
            this.lblEmptyMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmptyMessage.AutoSize = false;
            this.lblEmptyMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblEmptyMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyMessage.ForeColor = System.Drawing.Color.Gray;
            this.lblEmptyMessage.Location = new System.Drawing.Point(280, 270);
            this.lblEmptyMessage.Name = "lblEmptyMessage";
            this.lblEmptyMessage.Size = new System.Drawing.Size(390, 40);
            this.lblEmptyMessage.TabIndex = 12;
            this.lblEmptyMessage.Text = "Bạn chưa được phân công dạy lớp nào.";
            this.lblEmptyMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmptyMessage.Visible = false;
            // 
            // NhapDiemGiaoVien
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblEmptyMessage);
            this.Controls.Add(this.btnLuuDiem);
            this.Controls.Add(this.dgvDiemSo);
            this.Controls.Add(this.cboMonHoc);
            this.Controls.Add(this.lblChonMon);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.lblChonLop);
            this.Controls.Add(this.lblTitle);
            this.Name = "NhapDiemGiaoVien";
            this.Size = new System.Drawing.Size(950, 520);
            this.Load += new System.EventHandler(this.NhapDiemGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblChonLop;
        private Guna.UI2.WinForms.Guna2ComboBox cboLop;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblChonMon;
        private Guna.UI2.WinForms.Guna2ComboBox cboMonHoc;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDiemSo;
        private Guna.UI2.WinForms.Guna2Button btnLuuDiem;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmptyMessage;
    }
}