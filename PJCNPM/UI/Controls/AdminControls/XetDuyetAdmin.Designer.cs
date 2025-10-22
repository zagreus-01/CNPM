using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.Controls.AdminControls
{
    partial class XetDuyetAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2HtmlLabel lblTitle;
        private Guna2HtmlLabel lblLoai;
        private Guna2ComboBox cboLoaiNguoiGui;
        private Guna2DataGridView dgvYeuCau;
        private Guna2Button btnChiTiet;
        private Guna2Button btnDuyet;
        private Guna2Button btnTuChoi;
        private Guna2Button btnTaiLai;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Guna2HtmlLabel();
            this.lblLoai = new Guna2HtmlLabel();
            this.cboLoaiNguoiGui = new Guna2ComboBox();
            this.dgvYeuCau = new Guna2DataGridView();
            this.btnChiTiet = new Guna2Button();
            this.btnDuyet = new Guna2Button();
            this.btnTuChoi = new Guna2Button();
            this.btnTaiLai = new Guna2Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCau)).BeginInit();
            this.SuspendLayout();

            // === lblTitle ===
            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 90, 160);
            this.lblTitle.Text = "XÉT DUYỆT CHỈNH SỬA THÔNG TIN";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Height = 60;

            // === lblLoai ===
            this.lblLoai.Text = "Loại yêu cầu:";
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLoai.Location = new System.Drawing.Point(40, 80);

            // === cboLoaiNguoiGui ===
            this.cboLoaiNguoiGui.DrawMode = DrawMode.OwnerDrawFixed;
            this.cboLoaiNguoiGui.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboLoaiNguoiGui.ItemHeight = 30;
            this.cboLoaiNguoiGui.Items.AddRange(new object[] { "Học sinh", "Giáo viên" });
            this.cboLoaiNguoiGui.Location = new System.Drawing.Point(170, 75);
            this.cboLoaiNguoiGui.Size = new System.Drawing.Size(200, 36);
            this.cboLoaiNguoiGui.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.cboLoaiNguoiGui.SelectedIndexChanged += new EventHandler(this.cboLoaiNguoiGui_SelectedIndexChanged);

            // === dgvYeuCau ===
            this.dgvYeuCau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvYeuCau.Location = new System.Drawing.Point(40, 140);
            this.dgvYeuCau.Size = new System.Drawing.Size(870, 360);
            this.dgvYeuCau.ReadOnly = true;
            this.dgvYeuCau.RowHeadersVisible = false;
            this.dgvYeuCau.AllowUserToAddRows = false;
            this.dgvYeuCau.AllowUserToDeleteRows = false;
            this.dgvYeuCau.AllowUserToResizeRows = false;
            this.dgvYeuCau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYeuCau.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.dgvYeuCau.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvYeuCau.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvYeuCau.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvYeuCau.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(225, 235, 255);
            this.dgvYeuCau.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;

            // === btnChiTiet ===
            this.btnChiTiet.Text = "CHI TIẾT";
            this.btnChiTiet.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.btnChiTiet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnChiTiet.Size = new System.Drawing.Size(100, 40);
            this.btnChiTiet.Location = new System.Drawing.Point(400, 75);
            this.btnChiTiet.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.btnChiTiet.Click += new EventHandler(this.btnChiTiet_Click);

            // === btnDuyet ===
            this.btnDuyet.Text = "DUYỆT";
            this.btnDuyet.FillColor = System.Drawing.Color.SeaGreen;
            this.btnDuyet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDuyet.ForeColor = System.Drawing.Color.White;
            this.btnDuyet.Size = new System.Drawing.Size(100, 40);
            this.btnDuyet.Location = new System.Drawing.Point(520, 75);
            this.btnDuyet.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.btnDuyet.Click += new EventHandler(this.btnDuyet_Click);

            // === btnTuChoi ===
            this.btnTuChoi.Text = "TỪ CHỐI";
            this.btnTuChoi.FillColor = System.Drawing.Color.IndianRed;
            this.btnTuChoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTuChoi.ForeColor = System.Drawing.Color.White;
            this.btnTuChoi.Size = new System.Drawing.Size(100, 40);
            this.btnTuChoi.Location = new System.Drawing.Point(640, 75);
            this.btnTuChoi.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.btnTuChoi.Click += new EventHandler(this.btnTuChoi_Click);

            // === btnTaiLai ===
            this.btnTaiLai.Text = "TẢI LẠI";
            this.btnTaiLai.FillColor = System.Drawing.Color.Gray;
            this.btnTaiLai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTaiLai.ForeColor = System.Drawing.Color.White;
            this.btnTaiLai.Size = new System.Drawing.Size(100, 40);
            this.btnTaiLai.Location = new System.Drawing.Point(760, 75);
            this.btnTaiLai.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.btnTaiLai.Click += new EventHandler(this.btnTaiLai_Click);

            // === XetDuyetAdmin (UserControl) ===
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.cboLoaiNguoiGui);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.btnTuChoi);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.dgvYeuCau);
            this.Size = new System.Drawing.Size(950, 550);

            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCau)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
