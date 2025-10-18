using System;
using System.Windows.Forms;
using PJCNPM.BLL.GiaoVien;

namespace PJCNPM.UI.PopUpFrm.GiaoVienPopUp
{
    public partial class FrmDoiMatKhauGiaoVien : Form
    {
        private readonly string _tenTK;
        private readonly TaiKhoanBLL _bll;

        public FrmDoiMatKhauGiaoVien(string tenTK)
        {
            InitializeComponent();
            _tenTK = tenTK;
            _bll = new TaiKhoanBLL();
            lblTenDangNhap.Text += _tenTK;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string matKhauCu = txtMatKhauCu.Text.Trim();
            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            string xacNhanMK = txtXacNhanMK.Text.Trim();

            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(matKhauCu) || string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(xacNhanMK))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhauMoi.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhauMoi != xacNhanMK)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gọi BLL để xử lý
            string ketQua = _bll.DoiMatKhau(_tenTK, matKhauCu, matKhauMoi);

            // Hiển thị kết quả
            if (ketQua == "Đổi mật khẩu thành công!")
            {
                MessageBox.Show(ketQua, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}