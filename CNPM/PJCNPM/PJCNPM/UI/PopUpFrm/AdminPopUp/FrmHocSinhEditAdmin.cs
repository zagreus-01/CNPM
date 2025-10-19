using System;
using System.Windows.Forms;

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    public partial class FrmHocSinhEditAdmin : Form
    {
        private int? hocSinhId;
        private bool isEditMode;

        public FrmHocSinhEditAdmin(int? id = null)
        {
            InitializeComponent();
            hocSinhId = id;
            isEditMode = id.HasValue;

            if (isEditMode)
            {
                LoadHocSinhData(id.Value);
                lblTitle.Text = "SỬA THÔNG TIN HỌC SINH";

                // 🔒 Ẩn phần chọn lớp khi sửa
                lblLop.Visible = false;
                cboLop.Visible = false;
            }
            else
            {
                lblTitle.Text = "THÊM HỌC SINH";
                lblLop.Visible = true;
                cboLop.Visible = true;
            }
        }

        private void LoadHocSinhData(int id)
        {
            // 🧠 Giả lập dữ liệu DB
            txtHoTen.Text = "Nguyễn Văn A";
            dtNgaySinh.Value = new DateTime(2008, 5, 20);
            chkNam.Checked = true;
            txtDanToc.Text = "Kinh";
            txtTonGiao.Text = "Không";
            txtQueQuan.Text = "TP.HCM";
            numNamNhapHoc.Value = 2023;
            cboTrangThai.SelectedIndex = 0;
            cboLop.SelectedIndex = 1;
        }

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNam.Checked) chkNu.Checked = false;
        }

        private void chkNu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNu.Checked) chkNam.Checked = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string gioiTinh = chkNam.Checked ? "Nam" : (chkNu.Checked ? "Nữ" : "Khác");
            string trangThai = cboTrangThai.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên học sinh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu đang thêm, cần có lớp
            string lop = "";
            if (!isEditMode)
            {
                if (cboLop.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn lớp cho học sinh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                lop = cboLop.SelectedItem.ToString();
            }

            // 🔄 Xử lý lưu
            if (isEditMode)
            {
                MessageBox.Show($"✅ Đã cập nhật học sinh: {hoTen} - {trangThai}.", "Cập nhật thành công");
            }
            else
            {
                MessageBox.Show($"✅ Đã thêm học sinh: {hoTen} ({lop}) - {trangThai}.", "Thêm thành công");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
