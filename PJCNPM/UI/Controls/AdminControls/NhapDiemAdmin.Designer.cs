namespace PJCNPM.UI.Controls.AdminControls
{
    partial class NhapDiemAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboLop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboMonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvDiemSo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnLuuDiem = new Guna.UI2.WinForms.Guna2Button();
            this.lblEmptyMessage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkHienLopKetThuc = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemSo)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLop
            // 
            this.cboLop.BackColor = System.Drawing.Color.Transparent;
            this.cboLop.BorderRadius = 6;
            this.cboLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLop.ItemHeight = 30;
            this.cboLop.Location = new System.Drawing.Point(140, 85);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(396, 36);
            this.cboLop.TabIndex = 8;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboMonHoc.BorderRadius = 6;
            this.cboMonHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMonHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboMonHoc.ItemHeight = 30;
            this.cboMonHoc.Location = new System.Drawing.Point(769, 85);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(220, 36);
            this.cboMonHoc.TabIndex = 10;
            this.cboMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboMonHoc_SelectedIndexChanged);
            // 
            // dgvDiemSo
            // 
            this.dgvDiemSo.AllowUserToAddRows = false;
            this.dgvDiemSo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvDiemSo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDiemSo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiemSo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDiemSo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiemSo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDiemSo.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiemSo.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDiemSo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDiemSo.Location = new System.Drawing.Point(40, 140);
            this.dgvDiemSo.Name = "dgvDiemSo";
            this.dgvDiemSo.RowHeadersVisible = false;
            this.dgvDiemSo.RowHeadersWidth = 51;
            this.dgvDiemSo.RowTemplate.Height = 28;
            this.dgvDiemSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDiemSo.Size = new System.Drawing.Size(1282, 446);
            this.dgvDiemSo.TabIndex = 11;
            this.dgvDiemSo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiemSo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDiemSo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDiemSo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDiemSo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDiemSo.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDiemSo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDiemSo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDiemSo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDiemSo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiemSo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDiemSo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDiemSo.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvDiemSo.ThemeStyle.ReadOnly = false;
            this.dgvDiemSo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiemSo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiemSo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiemSo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDiemSo.ThemeStyle.RowsStyle.Height = 28;
            this.dgvDiemSo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDiemSo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDiemSo.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDiemSo_CellValidating);
            this.dgvDiemSo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiemSo_CellValueChanged);
            this.dgvDiemSo.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDiemSo_DataError);
            // 
            // btnLuuDiem
            // 
            this.btnLuuDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuDiem.BorderRadius = 6;
            this.btnLuuDiem.FillColor = System.Drawing.Color.SeaGreen;
            this.btnLuuDiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuuDiem.ForeColor = System.Drawing.Color.White;
            this.btnLuuDiem.Location = new System.Drawing.Point(1162, 601);
            this.btnLuuDiem.Name = "btnLuuDiem";
            this.btnLuuDiem.Size = new System.Drawing.Size(160, 45);
            this.btnLuuDiem.TabIndex = 12;
            this.btnLuuDiem.Text = "Lưu điểm";
            this.btnLuuDiem.Click += new System.EventHandler(this.btnLuuDiem_Click);
            // 
            // lblEmptyMessage
            // 
            this.lblEmptyMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmptyMessage.AutoSize = false;
            this.lblEmptyMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblEmptyMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEmptyMessage.ForeColor = System.Drawing.Color.Gray;
            this.lblEmptyMessage.Location = new System.Drawing.Point(486, 338);
            this.lblEmptyMessage.Name = "lblEmptyMessage";
            this.lblEmptyMessage.Size = new System.Drawing.Size(390, 40);
            this.lblEmptyMessage.TabIndex = 13;
            this.lblEmptyMessage.Text = "Chưa có dữ liệu lớp học hoặc môn học.";
            this.lblEmptyMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmptyMessage.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.Location = new System.Drawing.Point(211, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "NHẬP ĐIỂM CHO HỌC SINH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Chọn lớp: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(597, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Chọn môn học";
            // 
            // chkHienLopKetThuc
            // 
            this.chkHienLopKetThuc.AutoSize = true;
            this.chkHienLopKetThuc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkHienLopKetThuc.CheckedState.BorderRadius = 0;
            this.chkHienLopKetThuc.CheckedState.BorderThickness = 0;
            this.chkHienLopKetThuc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkHienLopKetThuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkHienLopKetThuc.Location = new System.Drawing.Point(1029, 85);
            this.chkHienLopKetThuc.Name = "chkHienLopKetThuc";
            this.chkHienLopKetThuc.Size = new System.Drawing.Size(187, 27);
            this.chkHienLopKetThuc.TabIndex = 17;
            this.chkHienLopKetThuc.Text = "Hiện lớp đã kết thúc";
            this.chkHienLopKetThuc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkHienLopKetThuc.UncheckedState.BorderRadius = 0;
            this.chkHienLopKetThuc.UncheckedState.BorderThickness = 0;
            this.chkHienLopKetThuc.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // NhapDiemAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.chkHienLopKetThuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmptyMessage);
            this.Controls.Add(this.btnLuuDiem);
            this.Controls.Add(this.dgvDiemSo);
            this.Controls.Add(this.cboMonHoc);
            this.Controls.Add(this.cboLop);
            this.Name = "NhapDiemAdmin";
            this.Size = new System.Drawing.Size(1362, 656);
            this.Load += new System.EventHandler(this.NhapDiemAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cboLop;
        private Guna.UI2.WinForms.Guna2ComboBox cboMonHoc;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDiemSo;
        private Guna.UI2.WinForms.Guna2Button btnLuuDiem;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmptyMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CheckBox chkHienLopKetThuc;
    }
}
