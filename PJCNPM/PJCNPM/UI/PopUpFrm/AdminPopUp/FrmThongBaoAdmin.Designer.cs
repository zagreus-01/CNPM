using Guna.UI2.WinForms;

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    partial class FrmThongBaoAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2HtmlLabel lblTitle;
        private Guna2HtmlLabel lblLoaiNguoiNhan;
        private Guna2ComboBox cboLoaiNguoiNhan;
        private Guna2HtmlLabel lblNguoiNhan;
        private Guna2ComboBox cboNguoiNhan;
        private Guna2HtmlLabel lblTieuDe;
        private Guna2TextBox txtTieuDe;
        private Guna2HtmlLabel lblNoiDung;
        private Guna2TextBox txtNoiDung;
        private Guna2Button btnGui;
        private Guna2Button btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLoaiNguoiNhan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboLoaiNguoiNhan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNguoiNhan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboNguoiNhan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTieuDe = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTieuDe = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNoiDung = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGui = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.lblTitle.Text = "GỬI THÔNG BÁO";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Size = new System.Drawing.Size(650, 60);
            // 
            // lblLoaiNguoiNhan
            // 
            this.lblLoaiNguoiNhan.Text = "Loại người nhận:";
            this.lblLoaiNguoiNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLoaiNguoiNhan.Location = new System.Drawing.Point(40, 90);
            // 
            // cboLoaiNguoiNhan
            // 
            this.cboLoaiNguoiNhan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiNguoiNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiNguoiNhan.ItemHeight = 30;
            this.cboLoaiNguoiNhan.Location = new System.Drawing.Point(190, 85);
            this.cboLoaiNguoiNhan.Size = new System.Drawing.Size(380, 36);
            this.cboLoaiNguoiNhan.SelectedIndexChanged += new System.EventHandler(this.cboLoaiNguoiNhan_SelectedIndexChanged);
            // 
            // lblNguoiNhan
            // 
            this.lblNguoiNhan.Text = "Người nhận:";
            this.lblNguoiNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNguoiNhan.Location = new System.Drawing.Point(40, 145);
            // 
            // cboNguoiNhan
            // 
            this.cboNguoiNhan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNguoiNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNguoiNhan.ItemHeight = 30;
            this.cboNguoiNhan.Location = new System.Drawing.Point(190, 140);
            this.cboNguoiNhan.Size = new System.Drawing.Size(380, 36);
            this.cboNguoiNhan.Enabled = false;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Text = "Tiêu đề:";
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(40, 200);
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(190, 195);
            this.txtTieuDe.Size = new System.Drawing.Size(380, 40);
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.Text = "Nội dung:";
            this.lblNoiDung.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNoiDung.Location = new System.Drawing.Point(40, 255);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(190, 250);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Size = new System.Drawing.Size(380, 180);
            // 
            // btnGui
            // 
            this.btnGui.Text = "GỬI";
            this.btnGui.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.Location = new System.Drawing.Point(190, 450);
            this.btnGui.Size = new System.Drawing.Size(120, 40);
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Text = "HỦY";
            this.btnHuy.FillColor = System.Drawing.Color.Gray;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(330, 450);
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FrmThongBaoAdmin
            // 
            this.ClientSize = new System.Drawing.Size(650, 520);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLoaiNguoiNhan);
            this.Controls.Add(this.cboLoaiNguoiNhan);
            this.Controls.Add(this.lblNguoiNhan);
            this.Controls.Add(this.cboNguoiNhan);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.btnHuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "FrmThongBaoAdmin";
            this.Load += new System.EventHandler(this.FrmThongBaoAdmin_Load);
            this.ResumeLayout(false);
        }
    }
}
