using System;
using System.Windows.Forms;
using PJCNPM.UI.PopUpFrm.HocSinhPopUp;

namespace PJCNPM.UI.Controls.HocSinhControls
{
    public partial class TaiKhoanHocSinh : UserControl
    {
        public TaiKhoanHocSinh()
        {
            InitializeComponent();
            LoadTaiKhoan();
        }

        private void LoadTaiKhoan()
        {
            valHoTen.Text = "Nguyễn Văn A";
            valTenDangNhap.Text = "hs_23110358";
            txtMatKhau.Text = "12345678";
        }

        private void swShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = swShowPassword.Checked ? '\0' : '●';
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            // Lấy tên đăng nhập từ control hiện tại
            string tenDangNhap = valTenDangNhap.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim(); // Giả lập lấy mật khẩu hiện tại
            using (var frm = new FrmDoiMatKhauHocSinh(tenDangNhap, matkhau))
            {
                frm.ShowDialog();
            }
        }
    }
}
