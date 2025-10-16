using System;
using System.Windows.Forms;
using PJCNPM.BLL.HocSinh; // 👈 Thêm namespace chứa BLL

namespace PJCNPM.UI.PopUpFrm.HocSinhPopUp
{
    public partial class FrmDoiMatKhauHocSinh : Form
    {
        private readonly string tenDangNhap;
        private readonly string matKhauCuTrongDB;
        private readonly TaiKhoanHocSinhBLL taiKhoanBLL = new TaiKhoanHocSinhBLL();

        public FrmDoiMatKhauHocSinh(string tenDangNhap, string matKhauHienTai)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
            this.matKhauCuTrongDB = matKhauHienTai;

            lblTenDangNhap.Text = $"Tên đăng nhập: {tenDangNhap}";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                string matKhauCu = txtMatKhauCu.Text.Trim();
                string matKhauMoi = txtMatKhauMoi.Text.Trim();
                string matKhauNhapLai = txtXacNhanMK.Text.Trim();

                // ===== Kiểm tra hợp lệ =====
                if (string.IsNullOrWhiteSpace(matKhauCu) ||
                    string.IsNullOrWhiteSpace(matKhauMoi) ||
                    string.IsNullOrWhiteSpace(matKhauNhapLai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (matKhauMoi.Length < 6)
                {
                    MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (matKhauMoi != matKhauNhapLai)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ===== Kiểm tra mật khẩu cũ =====
                if (matKhauCu != matKhauCuTrongDB)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ===== Cập nhật mật khẩu =====
                bool success = taiKhoanBLL.DoiMatKhau(tenDangNhap, matKhauMoi);
                if (success)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật mật khẩu. Vui lòng thử lại.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
