namespace PJCNPM.UI.Controls.GiaoVienControls
{
    partial class ThongBaoGiaoVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label label1;
            this.btnHopThuDen = new Guna.UI2.WinForms.Guna2Button();
            this.btnDaGui = new Guna.UI2.WinForms.Guna2Button();
            this.btnSoanThongBao = new Guna.UI2.WinForms.Guna2Button();
            this.dgvThongBao = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblEmptyMessage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHopThuDen
            // 
            this.btnHopThuDen.BorderRadius = 6;
            this.btnHopThuDen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnHopThuDen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHopThuDen.ForeColor = System.Drawing.Color.White;
            this.btnHopThuDen.Location = new System.Drawing.Point(40, 90);
            this.btnHopThuDen.Name = "btnHopThuDen";
            this.btnHopThuDen.Size = new System.Drawing.Size(160, 45);
            this.btnHopThuDen.TabIndex = 5;
            this.btnHopThuDen.Text = "Hộp thư đến";
            this.btnHopThuDen.Click += new System.EventHandler(this.btnHopThuDen_Click);
            // 
            // btnDaGui
            // 
            this.btnDaGui.BorderRadius = 6;
            this.btnDaGui.FillColor = System.Drawing.Color.Gainsboro;
            this.btnDaGui.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDaGui.ForeColor = System.Drawing.Color.Black;
            this.btnDaGui.Location = new System.Drawing.Point(210, 90);
            this.btnDaGui.Name = "btnDaGui";
            this.btnDaGui.Size = new System.Drawing.Size(160, 45);
            this.btnDaGui.TabIndex = 6;
            this.btnDaGui.Text = "Đã gửi";
            this.btnDaGui.Click += new System.EventHandler(this.btnDaGui_Click);
            // 
            // btnSoanThongBao
            // 
            this.btnSoanThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSoanThongBao.BorderRadius = 6;
            this.btnSoanThongBao.FillColor = System.Drawing.Color.SeaGreen;
            this.btnSoanThongBao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSoanThongBao.ForeColor = System.Drawing.Color.White;
            this.btnSoanThongBao.Location = new System.Drawing.Point(750, 90);
            this.btnSoanThongBao.Name = "btnSoanThongBao";
            this.btnSoanThongBao.Size = new System.Drawing.Size(160, 45);
            this.btnSoanThongBao.TabIndex = 7;
            this.btnSoanThongBao.Text = "Soạn thông báo";
            this.btnSoanThongBao.Click += new System.EventHandler(this.btnSoanThongBao_Click);
            // 
            // dgvThongBao
            // 
            this.dgvThongBao.AllowUserToAddRows = false;
            this.dgvThongBao.AllowUserToDeleteRows = false;
            this.dgvThongBao.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.dgvThongBao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongBao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongBao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvThongBao.ColumnHeadersHeight = 35;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongBao.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvThongBao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongBao.Location = new System.Drawing.Point(40, 155);
            this.dgvThongBao.MultiSelect = false;
            this.dgvThongBao.Name = "dgvThongBao";
            this.dgvThongBao.ReadOnly = true;
            this.dgvThongBao.RowHeadersVisible = false;
            this.dgvThongBao.RowHeadersWidth = 51;
            this.dgvThongBao.RowTemplate.Height = 28;
            this.dgvThongBao.Size = new System.Drawing.Size(870, 342);
            this.dgvThongBao.TabIndex = 8;
            this.dgvThongBao.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongBao.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongBao.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongBao.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongBao.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongBao.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongBao.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongBao.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dgvThongBao.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongBao.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThongBao.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongBao.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvThongBao.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvThongBao.ThemeStyle.ReadOnly = true;
            this.dgvThongBao.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongBao.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongBao.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvThongBao.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongBao.ThemeStyle.RowsStyle.Height = 28;
            this.dgvThongBao.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvThongBao.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongBao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongBao_CellDoubleClick);
            // 
            // lblEmptyMessage
            // 
            this.lblEmptyMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmptyMessage.AutoSize = false;
            this.lblEmptyMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblEmptyMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyMessage.ForeColor = System.Drawing.Color.Gray;
            this.lblEmptyMessage.Location = new System.Drawing.Point(300, 306);
            this.lblEmptyMessage.Name = "lblEmptyMessage";
            this.lblEmptyMessage.Size = new System.Drawing.Size(350, 40);
            this.lblEmptyMessage.TabIndex = 9;
            this.lblEmptyMessage.Text = "Chưa có thông báo nào";
            this.lblEmptyMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmptyMessage.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(345, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(269, 46);
            label1.TabIndex = 10;
            label1.Text = "THÔNG BÁO";
            // 
            // ThongBaoGiaoVien
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(label1);
            this.Controls.Add(this.lblEmptyMessage);
            this.Controls.Add(this.dgvThongBao);
            this.Controls.Add(this.btnSoanThongBao);
            this.Controls.Add(this.btnDaGui);
            this.Controls.Add(this.btnHopThuDen);
            this.Name = "ThongBaoGiaoVien";
            this.Size = new System.Drawing.Size(950, 520);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnHopThuDen;
        private Guna.UI2.WinForms.Guna2Button btnDaGui;
        private Guna.UI2.WinForms.Guna2Button btnSoanThongBao;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongBao;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmptyMessage;
    }
}