using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace PJCNPM.UI.PopUpFrm.HocSinhPopUp
{
    partial class FrmThongBaoHocSinh
    {
        private Guna2Panel panelHeader;
        private Guna2HtmlLabel lblTieuDe;
        private Guna2Panel panelContent;
        private Guna2HtmlLabel lblNoiDung;
        private Guna2HtmlLabel lblNguoiGui;
        private Guna2HtmlLabel lblNgayGui;
        private Guna2Button btnDong;

        private void InitializeComponent()
        {
            this.panelHeader = new Guna2Panel();
            this.lblTieuDe = new Guna2HtmlLabel();
            this.panelContent = new Guna2Panel();
            this.lblNoiDung = new Guna2HtmlLabel();
            this.lblNguoiGui = new Guna2HtmlLabel();
            this.lblNgayGui = new Guna2HtmlLabel();
            this.btnDong = new Guna2Button();

            this.SuspendLayout();

            // 
            // FrmThongBaoHocSinh
            // 
            this.ClientSize = new System.Drawing.Size(550, 420);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Text = "Chi tiết thông báo";
            this.BackColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Load += new System.EventHandler(this.FrmThongBaoHocSinh_Load);

            // 
            // panelHeader
            // 
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.FromArgb(0, 90, 160);
            this.panelHeader.Size = new System.Drawing.Size(550, 60);
            this.panelHeader.Controls.Add(this.lblTieuDe);

            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Text = "Tiêu đề thông báo";
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.AutoSize = false;
            this.lblTieuDe.Dock = DockStyle.Fill;
            this.lblTieuDe.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(25, 80);
            this.panelContent.Size = new System.Drawing.Size(500, 200);
            this.panelContent.FillColor = System.Drawing.Color.White;
            this.panelContent.AutoScroll = true;
            this.panelContent.BorderRadius = 5;
            this.panelContent.BorderThickness = 1;
            this.panelContent.BorderColor = System.Drawing.Color.Gainsboro;
            this.panelContent.Controls.Add(this.lblNoiDung);

            // 
            // lblNoiDung
            // 
            this.lblNoiDung.BackColor = System.Drawing.Color.White;
            this.lblNoiDung.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNoiDung.ForeColor = System.Drawing.Color.Black;
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.MaximumSize = new System.Drawing.Size(480, 0);
            this.lblNoiDung.Location = new System.Drawing.Point(10, 10);
            this.lblNoiDung.Text = "Nội dung thông báo ở đây...";
            this.lblNoiDung.TextAlignment = System.Drawing.ContentAlignment.TopLeft;

            // 
            // lblNguoiGui
            // 
            this.lblNguoiGui.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblNguoiGui.ForeColor = System.Drawing.Color.DimGray;
            this.lblNguoiGui.Location = new System.Drawing.Point(30, 295);
            this.lblNguoiGui.Size = new System.Drawing.Size(250, 25);
            this.lblNguoiGui.Text = "Người gửi: ...";

            // 
            // lblNgayGui
            // 
            this.lblNgayGui.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblNgayGui.ForeColor = System.Drawing.Color.DimGray;
            this.lblNgayGui.Location = new System.Drawing.Point(350, 295);
            this.lblNgayGui.Size = new System.Drawing.Size(170, 25);
            this.lblNgayGui.Text = "Ngày gửi: ...";

            // 
            // btnDong
            // 
            this.btnDong.Text = "Đóng";
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDong.FillColor = System.Drawing.Color.FromArgb(0, 90, 160);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.BorderRadius = 8;
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.Location = new System.Drawing.Point(225, 340);
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // 
            // Add Controls
            // 
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.lblNguoiGui);
            this.Controls.Add(this.lblNgayGui);
            this.Controls.Add(this.btnDong);

            this.ResumeLayout(false);
        }
    }
}
