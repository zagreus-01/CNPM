using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.PopUpFrm.HocSinhPopUp
{
    public partial class FrmDoiMatKhauHocSinh : Form
    {
        private readonly string tenDangNhap;
        private readonly string matkhau; // Giả lập mật khẩu cũ
        public FrmDoiMatKhauHocSinh(string tenDangNhap, string matkhau)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
            this.matkhau = matkhau; 
            lblTenDangNhap.Text = $"Tên đăng nhập: {tenDangNhap}";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Kiểm tra hợp lệ
            if (string.IsNullOrWhiteSpace(txtMatKhauCu.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhauMoi.Text) ||
                string.IsNullOrWhiteSpace(txtXacNhanMK.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMatKhauMoi.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMatKhauMoi.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ⚙️ Giả lập kiểm tra mật khẩu cũ đúng (thực tế sẽ gọi DAL kiểm tra trong DB)
            if (txtMatKhauCu.Text != matkhau)
            {
                MessageBox.Show("Mật khẩu cũ không đúng.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ⚙️ Giả lập cập nhật mật khẩu thành công
            MessageBox.Show("Đổi mật khẩu thành công!",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
