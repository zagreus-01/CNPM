namespace PJCNPM.UI.Controls.NhanVienControls
{
    partial class QuanLyPhongHoc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TenPhongtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SucChuatxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoaiPhongcbo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TrangThaicbo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTenPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSucChua = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLoaiPhong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTrangThai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlInput.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1106, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ PHÒNG HỌC";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TenPhongtxt
            // 
            this.TenPhongtxt.BorderRadius = 8;
            this.TenPhongtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TenPhongtxt.DefaultText = "";
            this.TenPhongtxt.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TenPhongtxt.Location = new System.Drawing.Point(275, 27);
            this.TenPhongtxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TenPhongtxt.Name = "TenPhongtxt";
            this.TenPhongtxt.PlaceholderText = "";
            this.TenPhongtxt.SelectedText = "";
            this.TenPhongtxt.Size = new System.Drawing.Size(220, 36);
            this.TenPhongtxt.TabIndex = 2;
            // 
            // SucChuatxt
            // 
            this.SucChuatxt.BorderRadius = 8;
            this.SucChuatxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SucChuatxt.DefaultText = "";
            this.SucChuatxt.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.SucChuatxt.Location = new System.Drawing.Point(683, 27);
            this.SucChuatxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SucChuatxt.Name = "SucChuatxt";
            this.SucChuatxt.PlaceholderText = "";
            this.SucChuatxt.SelectedText = "";
            this.SucChuatxt.Size = new System.Drawing.Size(220, 36);
            this.SucChuatxt.TabIndex = 4;
            // 
            // LoaiPhongcbo
            // 
            this.LoaiPhongcbo.BackColor = System.Drawing.Color.Transparent;
            this.LoaiPhongcbo.BorderRadius = 8;
            this.LoaiPhongcbo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LoaiPhongcbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoaiPhongcbo.FocusedColor = System.Drawing.Color.Empty;
            this.LoaiPhongcbo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LoaiPhongcbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.LoaiPhongcbo.ItemHeight = 30;
            this.LoaiPhongcbo.Location = new System.Drawing.Point(275, 82);
            this.LoaiPhongcbo.Name = "LoaiPhongcbo";
            this.LoaiPhongcbo.Size = new System.Drawing.Size(220, 36);
            this.LoaiPhongcbo.TabIndex = 6;
            // 
            // TrangThaicbo
            // 
            this.TrangThaicbo.BackColor = System.Drawing.Color.Transparent;
            this.TrangThaicbo.BorderRadius = 8;
            this.TrangThaicbo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TrangThaicbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrangThaicbo.FocusedColor = System.Drawing.Color.Empty;
            this.TrangThaicbo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TrangThaicbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TrangThaicbo.ItemHeight = 30;
            this.TrangThaicbo.Location = new System.Drawing.Point(683, 82);
            this.TrangThaicbo.Name = "TrangThaicbo";
            this.TrangThaicbo.Size = new System.Drawing.Size(220, 36);
            this.TrangThaicbo.TabIndex = 8;
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblTenPhong.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTenPhong.Location = new System.Drawing.Point(155, 32);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(94, 25);
            this.lblTenPhong.TabIndex = 1;
            this.lblTenPhong.Text = "Tên phòng:";
            // 
            // lblSucChua
            // 
            this.lblSucChua.BackColor = System.Drawing.Color.Transparent;
            this.lblSucChua.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblSucChua.Location = new System.Drawing.Point(583, 32);
            this.lblSucChua.Name = "lblSucChua";
            this.lblSucChua.Size = new System.Drawing.Size(80, 25);
            this.lblSucChua.TabIndex = 3;
            this.lblSucChua.Text = "Sức chứa:";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblLoaiPhong.Location = new System.Drawing.Point(155, 87);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(98, 25);
            this.lblLoaiPhong.TabIndex = 5;
            this.lblLoaiPhong.Text = "Loại phòng:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.Location = new System.Drawing.Point(583, 87);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(91, 25);
            this.lblTrangThai.TabIndex = 7;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.TrangThaicbo);
            this.pnlInput.Controls.Add(this.lblTrangThai);
            this.pnlInput.Controls.Add(this.lblTenPhong);
            this.pnlInput.Controls.Add(this.LoaiPhongcbo);
            this.pnlInput.Controls.Add(this.TenPhongtxt);
            this.pnlInput.Controls.Add(this.lblLoaiPhong);
            this.pnlInput.Controls.Add(this.lblSucChua);
            this.pnlInput.Controls.Add(this.SucChuatxt);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 43);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Padding = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.pnlInput.Size = new System.Drawing.Size(1106, 155);
            this.pnlInput.TabIndex = 15;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.AddBtn);
            this.pnlButtons.Controls.Add(this.UpdateBtn);
            this.pnlButtons.Controls.Add(this.DelBtn);
            this.pnlButtons.Controls.Add(this.ClearBtn);
            this.pnlButtons.Controls.Add(this.SearchBtn);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 198);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(50, 5, 50, 5);
            this.pnlButtons.Size = new System.Drawing.Size(1106, 60);
            this.pnlButtons.TabIndex = 16;
            // 
            // AddBtn
            // 
            this.AddBtn.BorderRadius = 8;
            this.AddBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(60, 10);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(108, 36);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Thêm";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BorderRadius = 8;
            this.UpdateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(180, 10);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(108, 36);
            this.UpdateBtn.TabIndex = 1;
            this.UpdateBtn.Text = "Sửa";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.BorderRadius = 8;
            this.DelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.DelBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.DelBtn.ForeColor = System.Drawing.Color.White;
            this.DelBtn.Location = new System.Drawing.Point(300, 10);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(108, 36);
            this.DelBtn.TabIndex = 2;
            this.DelBtn.Text = "Xóa";
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BorderRadius = 8;
            this.ClearBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(420, 10);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(108, 36);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BorderRadius = 8;
            this.SearchBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(540, 10);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(108, 36);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Tìm";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1106, 493);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 29;
            this.dataGridView1.ThemeStyle.ReadOnly = false;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // QuanLyPhongHoc
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "QuanLyPhongHoc";
            this.Size = new System.Drawing.Size(1106, 681);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox TenPhongtxt;
        private Guna.UI2.WinForms.Guna2TextBox SucChuatxt;
        private Guna.UI2.WinForms.Guna2ComboBox LoaiPhongcbo;
        private Guna.UI2.WinForms.Guna2ComboBox TrangThaicbo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenPhong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSucChua;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLoaiPhong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTrangThai;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlButtons;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateBtn;
        private Guna.UI2.WinForms.Guna2Button DelBtn;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
    }
}
