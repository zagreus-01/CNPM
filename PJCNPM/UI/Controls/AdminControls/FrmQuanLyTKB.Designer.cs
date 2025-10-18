namespace PJCNPM.UI.Controls.AdminControls
{
    partial class FrmQuanLyTKB
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTabContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTabButtons = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTKBTheoLop = new Guna.UI2.WinForms.Guna2Button();
            this.btnTKBGV = new Guna.UI2.WinForms.Guna2Button();
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTabContainer.SuspendLayout();
            this.panelTabButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTabContainer
            // 
            this.panelTabContainer.Controls.Add(this.panelContent);
            this.panelTabContainer.Controls.Add(this.panelTabButtons);
            this.panelTabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabContainer.FillColor = System.Drawing.Color.White;
            this.panelTabContainer.Location = new System.Drawing.Point(0, 0);
            this.panelTabContainer.Name = "panelTabContainer";
            this.panelTabContainer.Size = new System.Drawing.Size(1200, 600);
            this.panelTabContainer.TabIndex = 0;
            // 
            // panelTabButtons
            // 
            this.panelTabButtons.Controls.Add(this.btnTKBTheoLop);
            this.panelTabButtons.Controls.Add(this.btnTKBGV);
            this.panelTabButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabButtons.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelTabButtons.Location = new System.Drawing.Point(0, 0);
            this.panelTabButtons.Name = "panelTabButtons";
            this.panelTabButtons.Padding = new System.Windows.Forms.Padding(20, 15, 20, 5);
            this.panelTabButtons.ShadowDecoration.BorderRadius = 0;
            this.panelTabButtons.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.panelTabButtons.ShadowDecoration.Depth = 3;
            this.panelTabButtons.ShadowDecoration.Enabled = true;
            this.panelTabButtons.Size = new System.Drawing.Size(1200, 65);
            this.panelTabButtons.TabIndex = 0;
            // 
            // btnTKBTheoLop
            // 
            this.btnTKBTheoLop.Animated = true;
            this.btnTKBTheoLop.BorderRadius = 12;
            this.btnTKBTheoLop.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnTKBTheoLop.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTKBTheoLop.CheckedState.Image = null;
            this.btnTKBTheoLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTKBTheoLop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTKBTheoLop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTKBTheoLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTKBTheoLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTKBTheoLop.FillColor = System.Drawing.Color.White;
            this.btnTKBTheoLop.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTKBTheoLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnTKBTheoLop.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnTKBTheoLop.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnTKBTheoLop.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTKBTheoLop.Location = new System.Drawing.Point(20, 10);
            this.btnTKBTheoLop.Name = "btnTKBTheoLop";
            this.btnTKBTheoLop.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btnTKBTheoLop.ShadowDecoration.BorderRadius = 12;
            this.btnTKBTheoLop.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))), ((int)(((byte)(30)))));
            this.btnTKBTheoLop.ShadowDecoration.Depth = 5;
            this.btnTKBTheoLop.ShadowDecoration.Enabled = true;
            this.btnTKBTheoLop.Size = new System.Drawing.Size(160, 45);
            this.btnTKBTheoLop.TabIndex = 0;
            this.btnTKBTheoLop.Text = "TKB theo lớp";
            this.btnTKBTheoLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTKBTheoLop.Click += new System.EventHandler(this.btnTKBTheoLop_Click);
            // 
            // btnTKBGV
            // 
            this.btnTKBGV.Animated = true;
            this.btnTKBGV.BorderRadius = 12;
            this.btnTKBGV.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnTKBGV.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTKBGV.CheckedState.Image = null;
            this.btnTKBGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTKBGV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTKBGV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTKBGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTKBGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTKBGV.FillColor = System.Drawing.Color.White;
            this.btnTKBGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTKBGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnTKBGV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnTKBGV.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnTKBGV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTKBGV.Location = new System.Drawing.Point(190, 10);
            this.btnTKBGV.Name = "btnTKBGV";
            this.btnTKBGV.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.btnTKBGV.ShadowDecoration.BorderRadius = 12;
            this.btnTKBGV.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))), ((int)(((byte)(30)))));
            this.btnTKBGV.ShadowDecoration.Depth = 5;
            this.btnTKBGV.ShadowDecoration.Enabled = true;
            this.btnTKBGV.Size = new System.Drawing.Size(160, 45);
            this.btnTKBGV.TabIndex = 1;
            this.btnTKBGV.Text = "TKB GV";
            this.btnTKBGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTKBGV.Click += new System.EventHandler(this.btnTKBGV_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.FillColor = System.Drawing.Color.White;
            this.panelContent.Location = new System.Drawing.Point(0, 65);
            this.panelContent.Name = "panelContent";
            this.panelContent.ShadowDecoration.BorderRadius = 0;
            this.panelContent.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.panelContent.ShadowDecoration.Depth = 2;
            this.panelContent.ShadowDecoration.Enabled = true;
            this.panelContent.Size = new System.Drawing.Size(1200, 535);
            this.panelContent.TabIndex = 1;
            // 
            // FrmQuanLyTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTabContainer);
            this.Name = "FrmQuanLyTKB";
            this.Size = new System.Drawing.Size(1200, 600);
            this.panelTabContainer.ResumeLayout(false);
            this.panelTabButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTabContainer;
        private Guna.UI2.WinForms.Guna2Panel panelTabButtons;
        private Guna.UI2.WinForms.Guna2Button btnTKBTheoLop;
        private Guna.UI2.WinForms.Guna2Button btnTKBGV;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
    }
}
