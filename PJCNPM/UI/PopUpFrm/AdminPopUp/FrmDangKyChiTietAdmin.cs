using System;
using System.Data;
using System.Windows.Forms;
using PJCNPM.BLL.Admin;

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    public partial class FrmDangKyChiTietAdmin : Form
    {
        private readonly int _phongHocID;
        private readonly string _tenPhong;
        private readonly DateTime _ngay;
        private readonly PhongHocAdminBLL _bll;

        public FrmDangKyChiTietAdmin(int phongHocID, string tenPhong, DateTime ngay)
        {
            InitializeComponent();
            _phongHocID = phongHocID;
            _tenPhong = tenPhong;
            _ngay = ngay;
            _bll = new PhongHocAdminBLL();
        }

        private void FrmDangKyChiTietAdmin_Load(object sender, EventArgs e)
        {
            lblPhong.Text = "Phòng: " + _tenPhong;
            lblNgay.Text = "Ngày: " + _ngay.ToString("dd/MM/yyyy");
            LoadTietHoc();
            LoadGiaoVien();
        }

        private void LoadTietHoc()
        {
            for (int i = 1; i <= 10; i++)
            {
                cboTuTiet.Items.Add(i);
                cboDenTiet.Items.Add(i);
            }
            cboTuTiet.SelectedIndex = 0;
            cboDenTiet.SelectedIndex = 0;
        }

        private void LoadGiaoVien()
        {
            try
            {
                cboGiaoVien.DataSource = _bll.GetAllGiaoVien();
                cboGiaoVien.DisplayMember = "HoTen";
                cboGiaoVien.ValueMember = "GiaoVienID";
                cboGiaoVien.SelectedIndex = -1; // Để trống, yêu cầu admin phải chọn
                cboLop.DataSource = null; // Xóa danh sách lớp cũ
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách giáo viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLopHoc(int giaoVienID)
        {
            try
            {
                cboLop.DataSource = _bll.GetLopCuaGiaoVien(giaoVienID);
                cboLop.DisplayMember = "TenLopHienThi";
                cboLop.ValueMember = "LopID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGiaoVien.SelectedValue is int selectedGiaoVienID)
            {
                LoadLopHoc(selectedGiaoVienID);
            }
            else
            {
                cboLop.DataSource = null;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // --- Validation ---
            if (cboGiaoVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboLop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp học. Nếu không có lớp, có thể giáo viên chưa được phân công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tuTiet = Convert.ToInt32(cboTuTiet.SelectedItem);
            int denTiet = Convert.ToInt32(cboDenTiet.SelectedItem);
            if (denTiet < tuTiet)
            {
                MessageBox.Show("Tiết kết thúc phải lớn hơn hoặc bằng tiết bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mucDich = txtMucDich.Text.Trim();
            if (string.IsNullOrEmpty(mucDich))
            {
                MessageBox.Show("Vui lòng nhập mục đích sử dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- Execution ---
            int giaoVienID = Convert.ToInt32(cboGiaoVien.SelectedValue);
            int lopID = Convert.ToInt32(cboLop.SelectedValue);

            string ketQua = _bll.DangKyPhong(_ngay, tuTiet, denTiet, _phongHocID, lopID, giaoVienID, mucDich);

            if (ketQua.Contains("thành công"))
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}