// PJCNPM.UI.PopUpFrm.AdminPopUp.FrmGiaoVienEditAdmin.cs

using PJCNPM.BLL.Admin;
using System;
using System.Data;
using System.Windows.Forms;

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    public partial class FrmGiaoVienEditAdmin : Form
    {
        private readonly bool _isEditMode;
        private readonly int? _giaoVienID;
        private readonly CRUDGiaoVienBLL _bll;
        private readonly DataRow _dataRow;

        // Constructor for ADD mode
        public FrmGiaoVienEditAdmin()
        {
            InitializeComponent();
            _isEditMode = false;
            _bll = new CRUDGiaoVienBLL();
        }

        // Constructor for EDIT mode
        public FrmGiaoVienEditAdmin(DataRow row)
        {
            InitializeComponent();
            _isEditMode = true;
            _bll = new CRUDGiaoVienBLL();
            _dataRow = row;
            _giaoVienID = Convert.ToInt32(row["GiaoVienID"]);
        }

        private void FrmGiaoVienEditAdmin_Load(object sender, EventArgs e)
        {
            // Gán sự kiện cho CheckBox hiển thị mật khẩu
            // Đảm bảo bạn đã thêm chkShowPassword từ designer
            if (this.Controls.Find("chkShowPassword", true).Length > 0)
            {
                (this.Controls.Find("chkShowPassword", true)[0] as CheckBox).CheckedChanged += ChkShowPassword_CheckedChanged;
            }

            if (_isEditMode)
            {
                SetupForEditMode();
                LoadDataForEdit();
            }
            else
            {
                SetupForAddMode();
            }
        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtMatKhau.PasswordChar = '●';
            }
        }

        private void SetupForAddMode()
        {
            lblTitle.Text = "Thêm Mới Giáo Viên";
            btnLuu.Text = "Thêm Mới";
            cboGioiTinh.SelectedIndex = 0; // 0: Nam, 1: Nữ
            dtpNgaySinh.Value = DateTime.Now.AddYears(-23);
            txtMatKhau.Text = "123456"; // Default password
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.PasswordChar = '●';
        }

        private void SetupForEditMode()
        {
            lblTitle.Text = "Cập Nhật Thông Tin Giáo Viên";
            btnLuu.Text = "Lưu Thay Đổi";

            // Ẩn các trường tài khoản và checkbox mật khẩu vì không cho phép sửa
            lbTenTK.Visible = false;
            txtTenTK.Visible = false;
            lbMatKhau.Visible = false;
            txtMatKhau.Visible = false;
            if (this.Controls.Find("chkShowPassword", true).Length > 0)
            {
                this.Controls.Find("chkShowPassword", true)[0].Visible = false;
            }

            // Thu nhỏ form lại bằng cách ẩn dòng cuối
            table.RowStyles[7].Height = 0;
            table.RowCount = 7;
            this.Height -= 55; // Điều chỉnh chiều cao form
        }

        private void LoadDataForEdit()
        {
            if (_dataRow != null)
            {
                txtHoTen.Text = _dataRow["HoTen"].ToString();
                cboGioiTinh.SelectedIndex = Convert.ToBoolean(_dataRow["GioiTinh"]) ? 1 : 0;
                dtpNgaySinh.Value = Convert.ToDateTime(_dataRow["NgaySinh"]);
                txtCCCD.Text = _dataRow["CCCD"].ToString();
                txtEmail.Text = _dataRow["Email"].ToString();
                txtDienThoai.Text = _dataRow["DienThoai"].ToString();
                txtDanToc.Text = _dataRow["DanToc"].ToString();
                txtTonGiao.Text = _dataRow["TonGiao"].ToString();
                txtQueQuan.Text = _dataRow["QueQuan"].ToString();
                txtNoiThuongTru.Text = _dataRow["NoiThuongTru"].ToString();
                chkLaDangVien.Checked = _dataRow["LaDangVien"] != DBNull.Value && Convert.ToBoolean(_dataRow["LaDangVien"]);

                // Hiển thị tên tài khoản ở footer để tham khảo
                lblTrangThai.Text = "Tài khoản: " + _dataRow["TenTK"].ToString();
                lblTrangThai.Visible = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // --- VALIDATION ---
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống.", "Thông tin bắt buộc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            bool gioiTinh = cboGioiTinh.SelectedIndex == 1; // 1: Nữ, 0: Nam

            if (!_isEditMode) // ADD mode
            {
                if (string.IsNullOrWhiteSpace(txtTenTK.Text))
                {
                    MessageBox.Show("Tên tài khoản không được để trống.", "Thông tin bắt buộc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenTK.Focus(); return;
                }
                if (_bll.IsTenTKExists(txtTenTK.Text.Trim()))
                {
                    MessageBox.Show("Tên tài khoản này đã tồn tại. Vui lòng chọn tên khác.", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenTK.Focus(); return;
                }
                if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                {
                    MessageBox.Show("Mật khẩu không được để trống.", "Thông tin bắt buộc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus(); return;
                }

                bool result = _bll.AddGiaoVien(txtHoTen.Text.Trim(), gioiTinh, dtpNgaySinh.Value,
                    txtCCCD.Text.Trim(), txtEmail.Text.Trim(), txtDienThoai.Text.Trim(),
                    txtDanToc.Text.Trim(), txtTonGiao.Text.Trim(), chkLaDangVien.Checked,
                    txtNoiThuongTru.Text.Trim(), txtQueQuan.Text.Trim(),
                    txtTenTK.Text.Trim(), txtMatKhau.Text);

                HandleSaveResult(result, "Thêm mới giáo viên thành công!", "Thêm mới giáo viên thất bại.");
            }
            else // EDIT mode
            {
                bool result = _bll.UpdateGiaoVien(_giaoVienID.Value, txtHoTen.Text.Trim(), gioiTinh, dtpNgaySinh.Value,
                    txtCCCD.Text.Trim(), txtEmail.Text.Trim(), txtDienThoai.Text.Trim(),
                    txtDanToc.Text.Trim(), txtTonGiao.Text.Trim(), chkLaDangVien.Checked,
                    txtNoiThuongTru.Text.Trim(), txtQueQuan.Text.Trim());

                HandleSaveResult(result, "Cập nhật thông tin thành công!", "Cập nhật thông tin thất bại.");
            }
        }

        private void HandleSaveResult(bool success, string successMessage, string errorMessage)
        {
            if (success)
            {
                MessageBox.Show(successMessage, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Báo hiệu thành công cho form cha
                this.Close();
            }
            // Không cần else, vì BLL đã hiển thị MessageBox lỗi rồi.
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}