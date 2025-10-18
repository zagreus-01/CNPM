using System;
using System.Windows.Forms;
using PJCNPM.UI.PopUpFrm.HocSinhPopUp;
using PJCNPM.BLL.HocSinh;

namespace PJCNPM.UI.Controls.HocSinhControls
{
    public partial class TaiKhoanHocSinh : UserControl
    {
        private readonly TaiKhoanHocSinhBLL taiKhoanBLL = new TaiKhoanHocSinhBLL();
        private readonly int maHS;

        public TaiKhoanHocSinh(int hocSinhID)
        {
            InitializeComponent();
            maHS = hocSinhID;
            LoadTaiKhoan();
        }

        private void LoadTaiKhoan()
        {
            try
            {
                var info = taiKhoanBLL.GetTaiKhoanHocSinh(maHS);
                if (string.IsNullOrEmpty(info.TenDangNhap))
                {
                    MessageBox.Show("Không tìm thấy tài khoản!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                valHoTen.Text = info.HoTen;
                valTenDangNhap.Text = info.TenDangNhap;
                txtMatKhau.Text = info.MatKhau;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải tài khoản: " + ex.Message);
            }
        }

        private void swShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = swShowPassword.Checked ? '\0' : '●';
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string tenDangNhap = valTenDangNhap.Text.Trim();
            string matKhauCu = txtMatKhau.Text.Trim();

            using (var frm = new FrmDoiMatKhauHocSinh(tenDangNhap, matKhauCu))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadTaiKhoan(); // Cập nhật lại mật khẩu mới
                }
            }
        }
    }
}
