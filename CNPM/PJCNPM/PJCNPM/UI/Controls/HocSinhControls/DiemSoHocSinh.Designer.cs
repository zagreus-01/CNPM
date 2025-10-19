using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.Controls.HocSinhControls
{
    partial class DiemSoHocSinh
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2HtmlLabel lblNamHoc;
        private Guna2HtmlLabel lblHocKy;
        private Guna2ComboBox cboNamHoc;
        private Guna2ComboBox cboHocKy;
        private Guna2DataGridView dgvDiemSo;
        private Guna2Panel panelBottom;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNamHoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHocKy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboNamHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboHocKy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvDiemSo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHanhKiem = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDiemTB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemSo)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblNamHoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblNamHoc.Location = new System.Drawing.Point(60, 90);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(84, 27);
            this.lblNamHoc.TabIndex = 5;
            this.lblNamHoc.Text = "Năm học:";
            // 
            // lblHocKy
            // 
            this.lblHocKy.BackColor = System.Drawing.Color.Transparent;
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblHocKy.Location = new System.Drawing.Point(360, 90);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(67, 27);
            this.lblHocKy.TabIndex = 4;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboNamHoc.BorderRadius = 8;
            this.cboNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.FocusedColor = System.Drawing.Color.Empty;
            this.cboNamHoc.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cboNamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNamHoc.ItemHeight = 30;
            this.cboNamHoc.Location = new System.Drawing.Point(160, 85);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(150, 36);
            this.cboNamHoc.TabIndex = 3;
            // 
            // cboHocKy
            // 
            this.cboHocKy.BackColor = System.Drawing.Color.Transparent;
            this.cboHocKy.BorderRadius = 8;
            this.cboHocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocKy.FocusedColor = System.Drawing.Color.Empty;
            this.cboHocKy.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cboHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboHocKy.ItemHeight = 30;
            this.cboHocKy.Location = new System.Drawing.Point(440, 85);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(150, 36);
            this.cboHocKy.TabIndex = 2;
            // 
            // dgvDiemSo
            // 
            this.dgvDiemSo.AllowUserToAddRows = false;
            this.dgvDiemSo.AllowUserToDeleteRows = false;
            this.dgvDiemSo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDiemSo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiemSo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDiemSo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDiemSo.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiemSo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDiemSo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvDiemSo.Location = new System.Drawing.Point(60, 140);
            this.dgvDiemSo.Name = "dgvDiemSo";
            this.dgvDiemSo.ReadOnly = true;
            this.dgvDiemSo.RowHeadersVisible = false;
            this.dgvDiemSo.RowHeadersWidth = 51;
            this.dgvDiemSo.Size = new System.Drawing.Size(820, 320);
            this.dgvDiemSo.TabIndex = 1;
            this.dgvDiemSo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiemSo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDiemSo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDiemSo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDiemSo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDiemSo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiemSo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvDiemSo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDiemSo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDiemSo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiemSo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDiemSo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDiemSo.ThemeStyle.HeaderStyle.Height = 40;
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
            this.panelBottom.Controls.Add(this.lblHanhKiem);
            this.panelBottom.Controls.Add(this.lblDiemTB);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.FillColor = System.Drawing.Color.Transparent;
            this.panelBottom.Location = new System.Drawing.Point(0, 495);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(60, 10, 0, 10);
            this.panelBottom.Size = new System.Drawing.Size(950, 55);
            this.panelBottom.TabIndex = 0;
            // 
            // lblHanhKiem
            // 
            this.lblHanhKiem.BackColor = System.Drawing.Color.Transparent;
            this.lblHanhKiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHanhKiem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHanhKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.lblHanhKiem.Location = new System.Drawing.Point(808, 10);
            this.lblHanhKiem.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblHanhKiem.Name = "lblHanhKiem";
            this.lblHanhKiem.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lblHanhKiem.Size = new System.Drawing.Size(142, 27);
            this.lblHanhKiem.TabIndex = 0;
            this.lblHanhKiem.Text = "Hạnh kiểm: -";
            this.lblHanhKiem.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.BackColor = System.Drawing.Color.Transparent;
            this.lblDiemTB.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDiemTB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDiemTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.lblDiemTB.Location = new System.Drawing.Point(60, 10);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(159, 27);
            this.lblDiemTB.TabIndex = 1;
            this.lblDiemTB.Text = "Điểm trung bình: -";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(40, 15, 0, 15);
            this.lblTitle.Size = new System.Drawing.Size(950, 69);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "KẾT QUẢ HỌC TẬP";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiemSoHocSinh
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.dgvDiemSo);
            this.Controls.Add(this.cboHocKy);
            this.Controls.Add(this.cboNamHoc);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.lblNamHoc);
            this.Controls.Add(this.lblTitle);
            this.Name = "DiemSoHocSinh";
            this.Size = new System.Drawing.Size(950, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemSo)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna2HtmlLabel lblHanhKiem;
        private Guna2HtmlLabel lblDiemTB;
        private Guna2HtmlLabel lblTitle;
    }
}
