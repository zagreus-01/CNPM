namespace PJCNPM.UI.Controls.AdminControls
{
    partial class QuanLyThietBi
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
            this.pnlInput = new System.Windows.Forms.Panel();
            this.MoTatxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ThietBitxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SoLuongtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.DonVicbo = new System.Windows.Forms.ComboBox();
            this.lblTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSoLuong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDonVi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMoTa = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lblTitle.Size = new System.Drawing.Size(1263, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ THIẾT BỊ";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.MoTatxt);
            this.pnlInput.Controls.Add(this.ThietBitxt);
            this.pnlInput.Controls.Add(this.SoLuongtxt);
            this.pnlInput.Controls.Add(this.DonVicbo);
            this.pnlInput.Controls.Add(this.lblTen);
            this.pnlInput.Controls.Add(this.lblSoLuong);
            this.pnlInput.Controls.Add(this.lblDonVi);
            this.pnlInput.Controls.Add(this.lblMoTa);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 69);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Padding = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.pnlInput.Size = new System.Drawing.Size(1263, 180);
            this.pnlInput.TabIndex = 2;
            // 
            // MoTatxt
            // 
            this.MoTatxt.BorderRadius = 8;
            this.MoTatxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MoTatxt.DefaultText = "";
            this.MoTatxt.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.MoTatxt.Location = new System.Drawing.Point(580, 15);
            this.MoTatxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MoTatxt.Multiline = true;
            this.MoTatxt.Name = "MoTatxt";
            this.MoTatxt.PlaceholderText = "";
            this.MoTatxt.SelectedText = "";
            this.MoTatxt.Size = new System.Drawing.Size(400, 136);
            this.MoTatxt.TabIndex = 0;
            // 
            // ThietBitxt
            // 
            this.ThietBitxt.BorderRadius = 8;
            this.ThietBitxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ThietBitxt.DefaultText = "";
            this.ThietBitxt.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ThietBitxt.Location = new System.Drawing.Point(180, 15);
            this.ThietBitxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ThietBitxt.Name = "ThietBitxt";
            this.ThietBitxt.PlaceholderText = "";
            this.ThietBitxt.SelectedText = "";
            this.ThietBitxt.Size = new System.Drawing.Size(250, 36);
            this.ThietBitxt.TabIndex = 1;
            // 
            // SoLuongtxt
            // 
            this.SoLuongtxt.BorderRadius = 8;
            this.SoLuongtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SoLuongtxt.DefaultText = "";
            this.SoLuongtxt.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.SoLuongtxt.Location = new System.Drawing.Point(180, 65);
            this.SoLuongtxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SoLuongtxt.Name = "SoLuongtxt";
            this.SoLuongtxt.PlaceholderText = "";
            this.SoLuongtxt.SelectedText = "";
            this.SoLuongtxt.Size = new System.Drawing.Size(250, 36);
            this.SoLuongtxt.TabIndex = 2;
            // 
            // DonVicbo
            // 
            this.DonVicbo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DonVicbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.DonVicbo.Location = new System.Drawing.Point(180, 120);
            this.DonVicbo.Name = "DonVicbo";
            this.DonVicbo.Size = new System.Drawing.Size(250, 31);
            this.DonVicbo.TabIndex = 3;
            // 
            // lblTen
            // 
            this.lblTen.BackColor = System.Drawing.Color.Transparent;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTen.Location = new System.Drawing.Point(60, 20);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(106, 27);
            this.lblTen.TabIndex = 4;
            this.lblTen.Text = "Tên thiết bị:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSoLuong.Location = new System.Drawing.Point(60, 70);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(84, 27);
            this.lblSoLuong.TabIndex = 5;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblDonVi
            // 
            this.lblDonVi.BackColor = System.Drawing.Color.Transparent;
            this.lblDonVi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDonVi.Location = new System.Drawing.Point(60, 120);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(63, 27);
            this.lblDonVi.TabIndex = 6;
            this.lblDonVi.Text = "Đơn vị:";
            // 
            // lblMoTa
            // 
            this.lblMoTa.BackColor = System.Drawing.Color.Transparent;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMoTa.Location = new System.Drawing.Point(500, 20);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(58, 27);
            this.lblMoTa.TabIndex = 7;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.AddBtn);
            this.pnlButtons.Controls.Add(this.UpdateBtn);
            this.pnlButtons.Controls.Add(this.DelBtn);
            this.pnlButtons.Controls.Add(this.ClearBtn);
            this.pnlButtons.Controls.Add(this.SearchBtn);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 249);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(50, 5, 50, 5);
            this.pnlButtons.Size = new System.Drawing.Size(1263, 60);
            this.pnlButtons.TabIndex = 1;
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
            this.SearchBtn.Text = "Tìm kiếm";
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1263, 264);
            this.dataGridView1.TabIndex = 0;
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
            this.dataGridView1.ThemeStyle.ReadOnly = true;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // QuanLyThietBi
            // 
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.lblTitle);
            this.Name = "QuanLyThietBi";
            this.Size = new System.Drawing.Size(1263, 573);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlButtons;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTen, lblSoLuong, lblDonVi, lblMoTa;
        private Guna.UI2.WinForms.Guna2TextBox MoTatxt, ThietBitxt, SoLuongtxt;
        private System.Windows.Forms.ComboBox DonVicbo;
        private Guna.UI2.WinForms.Guna2Button AddBtn, UpdateBtn, DelBtn, ClearBtn, SearchBtn;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
    }
}

