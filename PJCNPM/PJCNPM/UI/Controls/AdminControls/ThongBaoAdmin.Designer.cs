using Guna.UI2.WinForms;

namespace PJCNPM.UI.Controls.AdminControls
{
    partial class ThongBaoAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2HtmlLabel lblTitle;
        private Guna2DataGridView dgvThongBao;
        private Guna2Button btnGuiThongBao;
        private Guna2Button btnTaiLai;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvThongBao = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnGuiThongBao = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaiLai = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(950, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH SÁCH THÔNG BÁO";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvThongBao
            // 
            this.dgvThongBao.AllowUserToAddRows = false;
            this.dgvThongBao.AllowUserToDeleteRows = false;
            this.dgvThongBao.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvThongBao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongBao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvThongBao.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongBao.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvThongBao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongBao.Location = new System.Drawing.Point(40, 120);
            this.dgvThongBao.Name = "dgvThongBao";
            this.dgvThongBao.ReadOnly = true;
            this.dgvThongBao.RowHeadersVisible = false;
            this.dgvThongBao.RowHeadersWidth = 51;
            this.dgvThongBao.RowTemplate.Height = 30;
            this.dgvThongBao.Size = new System.Drawing.Size(870, 380);
            this.dgvThongBao.TabIndex = 3;
            this.dgvThongBao.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongBao.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongBao.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongBao.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongBao.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongBao.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongBao.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongBao.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgvThongBao.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongBao.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvThongBao.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongBao.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvThongBao.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvThongBao.ThemeStyle.ReadOnly = true;
            this.dgvThongBao.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongBao.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongBao.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvThongBao.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongBao.ThemeStyle.RowsStyle.Height = 30;
            this.dgvThongBao.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.dgvThongBao.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btnGuiThongBao
            // 
            this.btnGuiThongBao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuiThongBao.ForeColor = System.Drawing.Color.White;
            this.btnGuiThongBao.Location = new System.Drawing.Point(40, 70);
            this.btnGuiThongBao.Name = "btnGuiThongBao";
            this.btnGuiThongBao.Size = new System.Drawing.Size(185, 40);
            this.btnGuiThongBao.TabIndex = 1;
            this.btnGuiThongBao.Text = "GỬI THÔNG BÁO";
            this.btnGuiThongBao.Click += new System.EventHandler(this.btnGuiThongBao_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.FillColor = System.Drawing.Color.Gray;
            this.btnTaiLai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaiLai.ForeColor = System.Drawing.Color.White;
            this.btnTaiLai.Location = new System.Drawing.Point(252, 70);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(100, 40);
            this.btnTaiLai.TabIndex = 2;
            this.btnTaiLai.Text = "TẢI LẠI";
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // ThongBaoAdmin
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnGuiThongBao);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.dgvThongBao);
            this.Name = "ThongBaoAdmin";
            this.Size = new System.Drawing.Size(950, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
