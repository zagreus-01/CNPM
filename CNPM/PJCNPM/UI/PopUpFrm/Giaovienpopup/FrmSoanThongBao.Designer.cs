namespace PJCNPM.UI.PopUpFrm.GiaoVienPopUp
{
    partial class FrmSoanThongBao
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbLop;
        // THAY ĐỔI: Sử dụng CheckedListBox thay cho Guna2ComboBox
        private System.Windows.Forms.CheckedListBox clbLop;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTieuDe;
        private Guna.UI2.WinForms.Guna2TextBox txtTieuDe;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbNoiDung;
        private Guna.UI2.WinForms.Guna2TextBox txtNoiDung;
        private Guna.UI2.WinForms.Guna2Panel panelFooter;
        private Guna.UI2.WinForms.Guna2Button btnGui;
        private Guna.UI2.WinForms.Guna2Button btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.txtNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbNoiDung = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTieuDe = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTieuDe = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.clbLop = new System.Windows.Forms.CheckedListBox();
            this.lbLop = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGui = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelMain.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Controls.Add(this.panelFooter);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(700, 600);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.txtNoiDung);
            this.panelContent.Controls.Add(this.lbNoiDung);
            this.panelContent.Controls.Add(this.txtTieuDe);
            this.panelContent.Controls.Add(this.lbTieuDe);
            this.panelContent.Controls.Add(this.clbLop);
            this.panelContent.Controls.Add(this.lbLop);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelContent.Size = new System.Drawing.Size(700, 470);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoiDung.DefaultText = "";
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNoiDung.Location = new System.Drawing.Point(23, 275);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.PasswordChar = '\0';
            this.txtNoiDung.PlaceholderText = "Nhập nội dung chi tiết...";
            this.txtNoiDung.SelectedText = "";
            this.txtNoiDung.Size = new System.Drawing.Size(654, 172);
            this.txtNoiDung.TabIndex = 5;
            // 
            // lbNoiDung
            // 
            this.lbNoiDung.BackColor = System.Drawing.Color.Transparent;
            this.lbNoiDung.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiDung.Location = new System.Drawing.Point(23, 250);
            this.lbNoiDung.Name = "lbNoiDung";
            this.lbNoiDung.Size = new System.Drawing.Size(76, 19);
            this.lbNoiDung.Text = "Nội dung (*)";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTieuDe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTieuDe.DefaultText = "";
            this.txtTieuDe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTieuDe.Location = new System.Drawing.Point(23, 204);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.PasswordChar = '\0';
            this.txtTieuDe.PlaceholderText = "Nhập tiêu đề thông báo";
            this.txtTieuDe.SelectedText = "";
            this.txtTieuDe.Size = new System.Drawing.Size(654, 36);
            this.txtTieuDe.TabIndex = 3;
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lbTieuDe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(23, 179);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(66, 19);
            this.lbTieuDe.Text = "Tiêu đề (*)";
            // 
            // clbLop
            // 
            this.clbLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbLop.CheckOnClick = true;
            this.clbLop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbLop.FormattingEnabled = true;
            this.clbLop.Location = new System.Drawing.Point(23, 37);
            this.clbLop.Name = "clbLop";
            this.clbLop.Size = new System.Drawing.Size(654, 124);
            this.clbLop.TabIndex = 1;
            // 
            // lbLop
            // 
            this.lbLop.BackColor = System.Drawing.Color.Transparent;
            this.lbLop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.Location = new System.Drawing.Point(23, 12);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(100, 19);
            this.lbLop.Text = "Gửi đến các lớp (*)";
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.btnGui);
            this.panelFooter.Controls.Add(this.btnHuy);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelFooter.Location = new System.Drawing.Point(0, 520);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(20);
            this.panelFooter.Size = new System.Drawing.Size(700, 80);
            // 
            // btnGui
            // 
            this.btnGui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGui.BorderRadius = 8;
            this.btnGui.FillColor = System.Drawing.Color.SeaGreen;
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.Location = new System.Drawing.Point(417, 20);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(130, 40);
            this.btnGui.TabIndex = 1;
            this.btnGui.Text = "Gửi thông báo";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.FillColor = System.Drawing.Color.DimGray;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(553, 20);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(700, 50);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 27);
            this.lblTitle.Text = "Soạn Thông Báo Mới";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(655, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            // 
            // FrmSoanThongBao
            // 
            this.AcceptButton = this.btnGui;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSoanThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Soạn Thông Báo Mới";
            this.Load += new System.EventHandler(this.FrmSoanThongBao_Load);
            this.panelMain.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}