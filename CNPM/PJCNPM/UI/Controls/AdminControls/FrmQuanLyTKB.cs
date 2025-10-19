using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PJCNPM.UI.Controls.AdminControls;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.Controls.AdminControls
{
    public partial class FrmQuanLyTKB : UserControl
    {
        private TKBTheoLopControl tkbTheoLopControl;
        private TKBGVControl tkbGVControl;
        private UserControl currentControl;

        public FrmQuanLyTKB()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            // Tạo các control
            tkbTheoLopControl = new TKBTheoLopControl();
            tkbTheoLopControl.Dock = DockStyle.Fill;
            
            tkbGVControl = new TKBGVControl();
            tkbGVControl.Dock = DockStyle.Fill;

            // Mặc định hiển thị tab TKB theo lớp
            ShowTab(btnTKBTheoLop);
        }

        private void ShowTab(Guna2Button selectedButton)
        {
            // Nếu đã chọn tab hiện tại thì không làm gì
            if (selectedButton.Checked) return;

            // Reset tất cả button về trạng thái không được chọn
            btnTKBTheoLop.Checked = false;
            btnTKBGV.Checked = false;

            // Đặt button được chọn
            selectedButton.Checked = true;

            // Xóa control hiện tại với hiệu ứng fade out
            if (currentControl != null)
            {
                panelContent.Controls.Remove(currentControl);
            }

            // Hiển thị control tương ứng
            if (selectedButton == btnTKBTheoLop)
            {
                currentControl = tkbTheoLopControl;
            }
            else if (selectedButton == btnTKBGV)
            {
                currentControl = tkbGVControl;
            }

            if (currentControl != null)
            {
                // Thêm control mới với hiệu ứng fade in
                currentControl.Visible = false;
                panelContent.Controls.Add(currentControl);
                
                // Hiệu ứng fade in
                var timer = new Timer();
                timer.Interval = 10;
                int opacity = 0;
                timer.Tick += (s, e) =>
                {
                    opacity += 25;
                    if (opacity >= 255)
                    {
                        opacity = 255;
                        timer.Stop();
                        timer.Dispose();
                    }
                    currentControl.Visible = true;
                };
                timer.Start();
            }
        }

        private void btnTKBTheoLop_Click(object sender, EventArgs e)
        {
            ShowTab(btnTKBTheoLop);
        }

        private void btnTKBGV_Click(object sender, EventArgs e)
        {
            ShowTab(btnTKBGV);
        }
    }
}
