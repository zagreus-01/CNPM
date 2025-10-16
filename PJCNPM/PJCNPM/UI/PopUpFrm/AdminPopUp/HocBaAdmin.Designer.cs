using Guna.UI2.WinForms;

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    partial class HocBaAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2HtmlLabel lblTitle;
        private Guna2HtmlLabel lblTenHocSinh;
        private Guna2HtmlLabel lblNamHoc;
        private Guna2HtmlLabel lblHocKy;
        private Guna2ComboBox cboNamHoc;
        private Guna2ComboBox cboHocKy;
        private Guna2Button btnXem;
        private Guna2DataGridView dgvDiemSo;
        private Guna2Panel panelBottom;
        private Guna2HtmlLabel lblDiemTB;
        private Guna2HtmlLabel lblHanhKiem;

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
            this.lblTenHocSinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNamHoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHocKy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboNamHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnXem = new Guna.UI2.WinForms.Guna2Button();
            this.dgvDiemSo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDiemTB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHanhKiem = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemSo)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(900, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỌC BẠ HỌC SINH";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenHocSinh
            // 
            this.lblTenHocSinh.BackColor = System.Drawing.Color.Transparent;
            this.lblTenHocSinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTenHocSinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.lblTenHocSinh.Location = new System.Drawing.Point(40, 75);
            this.lblTenHocSinh.Name = "lblTenHocSinh";
            this.lblTenHocSinh.Size = new System.Drawing.Size(90, 30);
            this.lblTenHocSinh.TabIndex = 1;
            this.lblTenHocSinh.Text = "Học sinh:";
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblNamHoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNamHoc.Location = new System.Drawing.Point(40, 130);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(84, 27);
            this.lblNamHoc.TabIndex = 2;
            this.lblNamHoc.Text = "Năm học:";
            // 
            // lblHocKy
            // 
            this.lblHocKy.BackColor = System.Drawing.Color.Transparent;
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHocKy.Location = new System.Drawing.Point(280, 130);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(67, 27);
            this.lblHocKy.TabIndex = 3;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.FocusedColor = System.Drawing.Color.Empty;
            this.cboNamHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNamHoc.ItemHeight = 30;
            this.cboNamHoc.Location = new System.Drawing.Point(130, 125);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(120, 36);
            this.cboNamHoc.TabIndex = 4;
            // 
            // cboHocKy
            // 
            this.cboHocKy.BackColor = System.Drawing.Color.Transparent;
            this.cboHocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocKy.FocusedColor = System.Drawing.Color.Empty;
            this.cboHocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboHocKy.ItemHeight = 30;
            this.cboHocKy.Location = new System.Drawing.Point(350, 125);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(90, 36);
            this.cboHocKy.TabIndex = 5;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(470, 125);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(140, 36);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "XEM HỌC BẠ";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dgvDiemSo
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvDiemSo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiemSo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDiemSo.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiemSo.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDiemSo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDiemSo.Location = new System.Drawing.Point(40, 180);
            this.dgvDiemSo.Name = "dgvDiemSo";
            this.dgvDiemSo.ReadOnly = true;
            this.dgvDiemSo.RowHeadersVisible = false;
            this.dgvDiemSo.RowHeadersWidth = 51;
            this.dgvDiemSo.Size = new System.Drawing.Size(820, 300);
            this.dgvDiemSo.TabIndex = 7;
            this.dgvDiemSo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiemSo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDiemSo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDiemSo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDiemSo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDiemSo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiemSo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDiemSo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDiemSo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDiemSo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiemSo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDiemSo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDiemSo.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvDiemSo.ThemeStyle.ReadOnly = true;
            this.dgvDiemSo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiemSo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiemSo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiemSo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDiemSo.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDiemSo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDiemSo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lblDiemTB);
            this.panelBottom.Controls.Add(this.lblHanhKiem);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 500);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(40, 10, 40, 10);
            this.panelBottom.Size = new System.Drawing.Size(900, 60);
            this.panelBottom.TabIndex = 8;
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.BackColor = System.Drawing.Color.Transparent;
            this.lblDiemTB.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDiemTB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDiemTB.Location = new System.Drawing.Point(40, 10);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(159, 27);
            this.lblDiemTB.TabIndex = 0;
            this.lblDiemTB.Text = "Điểm trung bình: ";
            // 
            // lblHanhKiem
            // 
            this.lblHanhKiem.BackColor = System.Drawing.Color.Transparent;
            this.lblHanhKiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHanhKiem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHanhKiem.Location = new System.Drawing.Point(748, 10);
            this.lblHanhKiem.Name = "lblHanhKiem";
            this.lblHanhKiem.Size = new System.Drawing.Size(112, 27);
            this.lblHanhKiem.TabIndex = 1;
            this.lblHanhKiem.Text = "Hạnh kiểm:";
            // 
            // HocBaAdmin
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTenHocSinh);
            this.Controls.Add(this.lblNamHoc);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.cboNamHoc);
            this.Controls.Add(this.cboHocKy);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dgvDiemSo);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "HocBaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.HocBaAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemSo)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
