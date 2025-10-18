using System;
using System.Data;
using System.Windows.Forms;
using PJCNPM.BLL.GiaoVien;

namespace PJCNPM.UI.PopUpFrm.GiaoVienPopUp
{
    public partial class FrmDangKyChiTiet : Form
    {
        private readonly int _giaoVienID;
        private readonly int _phongHocID;
        private readonly string _tenPhong;
        private readonly DateTime _ngay;
        private readonly PhongHocBLL _bll;

        public FrmDangKyChiTiet(int giaoVienID, int phongHocID, string tenPhong, DateTime ngay)
        {
            InitializeComponent();
            _giaoVienID = giaoVienID;
            _phongHocID = phongHocID;
            _tenPhong = tenPhong;
            _ngay = ngay;
            _bll = new PhongHocBLL();
        }

        private void FrmDangKyChiTiet_Load(object sender, EventArgs e)
        {
            lblPhong.Text += _tenPhong;
            lblNgay.Text += _ngay.ToString("dd/MM/yyyy");
            LoadTietHoc();
            LoadLopHoc();
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

        private void LoadLopHoc()
        {
            try
            {
                cboLop.DataSource = _bll.GetLopCuaGiaoVien(_giaoVienID);
                cboLop.DisplayMember = "TenLopHienThi";
                cboLop.ValueMember = "LopID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách lớp: " + ex.Message);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int tuTiet = Convert.ToInt32(cboTuTiet.SelectedItem);
            int denTiet = Convert.ToInt32(cboDenTiet.SelectedItem);
            string mucDich = txtMucDich.Text.Trim();

            if (cboLop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int lopID = Convert.ToInt32(cboLop.SelectedValue);

            if (denTiet < tuTiet)
            {
                MessageBox.Show("Tiết kết thúc phải lớn hơn hoặc bằng tiết bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(mucDich))
            {
                MessageBox.Show("Vui lòng nhập mục đích sử dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ketQua = _bll.DangKyPhong(_ngay, tuTiet, denTiet, _phongHocID, lopID, _giaoVienID, mucDich);

            if (ketQua == "Đăng ký phòng thành công!")
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