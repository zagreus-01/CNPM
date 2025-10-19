namespace PJCNPM.UI.Controls.GiaoVienControls
{
    partial class ThoiKhoaBieuGiaoVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTenGiaoVien = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkHienThiLop = new System.Windows.Forms.CheckBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dgvTKB = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.lblTenGiaoVien);
            this.panel1.Controls.Add(this.lblTieuDe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 80);
            this.panel1.TabIndex = 0;
            // 
            // lblTenGiaoVien
            // 
            this.lblTenGiaoVien.AutoSize = true;
            this.lblTenGiaoVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGiaoVien.ForeColor = System.Drawing.Color.White;
            this.lblTenGiaoVien.Location = new System.Drawing.Point(20, 45);
            this.lblTenGiaoVien.Name = "lblTenGiaoVien";
            this.lblTenGiaoVien.Size = new System.Drawing.Size(150, 21);
            this.lblTenGiaoVien.TabIndex = 1;
            this.lblTenGiaoVien.Text = "Giáo viên: Nguyễn A";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(20, 10);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(200, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "THỜI KHÓA BIỂU";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.chkHienThiLop);
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 50);
            this.panel2.TabIndex = 1;
            // 
            // chkHienThiLop
            // 
            this.chkHienThiLop.AutoSize = true;
            this.chkHienThiLop.Checked = true;
            this.chkHienThiLop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHienThiLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHienThiLop.Location = new System.Drawing.Point(20, 15);
            this.chkHienThiLop.Name = "chkHienThiLop";
            this.chkHienThiLop.Size = new System.Drawing.Size(120, 19);
            this.chkHienThiLop.TabIndex = 1;
            this.chkHienThiLop.Text = "Hiển thị tên lớp";
            this.chkHienThiLop.UseVisualStyleBackColor = true;
            this.chkHienThiLop.CheckedChanged += new System.EventHandler(this.chkHienThiLop_CheckedChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(1100, 10);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 30);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // dgvTKB
            // 
            this.dgvTKB.AllowUserToAddRows = false;
            this.dgvTKB.AllowUserToDeleteRows = false;
            this.dgvTKB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTKB.BackgroundColor = System.Drawing.Color.White;
            this.dgvTKB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTKB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTKB.GridColor = System.Drawing.Color.LightGray;
            this.dgvTKB.Location = new System.Drawing.Point(0, 130);
            this.dgvTKB.MultiSelect = false;
            this.dgvTKB.Name = "dgvTKB";
            this.dgvTKB.ReadOnly = true;
            this.dgvTKB.RowHeadersVisible = false;
            this.dgvTKB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTKB.Size = new System.Drawing.Size(1200, 470);
            this.dgvTKB.TabIndex = 2;
            // 
            // ThoiKhoaBieuGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvTKB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ThoiKhoaBieuGiaoVien";
            this.Size = new System.Drawing.Size(1200, 600);
            this.Load += new System.EventHandler(this.ThoiKhoaBieuGiaoVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTenGiaoVien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.CheckBox chkHienThiLop;
        private System.Windows.Forms.DataGridView dgvTKB;
    }
}
