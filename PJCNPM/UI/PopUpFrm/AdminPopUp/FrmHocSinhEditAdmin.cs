using System;
using System.Data;
using System.Windows.Forms;
using PJCNPM.BLL.Admin;
using PJCNPM.Utils; // 👈 để dùng EnumHelper

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    public partial class FrmHocSinhEditAdmin : Form
    {
        private readonly SaveHocSinhBLL bll = new SaveHocSinhBLL();
        private int? hocSinhId;
        private bool isEditMode;

        public FrmHocSinhEditAdmin(int? id = null)
        {
            InitializeComponent();
            hocSinhId = id;
            isEditMode = id.HasValue;

            LoadComboTrangThai();
            LoadComboLop();

            if (isEditMode)
            {
                LoadHocSinhData(id.Value);
                lblTitle.Text = "SỬA THÔNG TIN HỌC SINH";
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

        // 🔹 Load combobox trạng thái theo EnumHelper
        private void LoadComboTrangThai()
        {
            cboTrangThai.Items.Clear();
            // Load theo các giá trị EnumHelper hỗ trợ
            cboTrangThai.Items.Add(EnumHelper.TrangThaiHocSinhToText(1)); // Đang học
            cboTrangThai.Items.Add(EnumHelper.TrangThaiHocSinhToText(0)); // Nghỉ học
            cboTrangThai.Items.Add(EnumHelper.TrangThaiHocSinhToText(2)); // Tạm dừng
            cboTrangThai.SelectedIndex = 0;
        }

        private void LoadComboLop()
        {
            DataTable dt = bll.LayDanhSachLop();
            cboLop.DataSource = dt;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "LopID";
            cboLop.SelectedIndex = -1;
        }

        private void LoadHocSinhData(int id)
        {
            DataRow row = bll.LayHocSinhTheoID(id);
            if (row == null) return;

            txtHoTen.Text = row["HoTen"].ToString();
            dtNgaySinh.Value = Convert.ToDateTime(row["NgaySinh"]);

            bool gioiTinh = Convert.ToBoolean(row["GioiTinh"]);
            chkNam.Checked = gioiTinh;
            chkNu.Checked = !gioiTinh;

            txtDanToc.Text = row["DanToc"].ToString();
            txtTonGiao.Text = row["TonGiao"].ToString();
            txtQueQuan.Text = row["QueQuan"].ToString();
            numNamNhapHoc.Value = Convert.ToInt32(row["NamNhapHoc"]);

            // 🔹 Lấy trạng thái từ DB (số) → text EnumHelper
            byte trangThai = Convert.ToByte(row["TrangThai"]);
            string textTrangThai = EnumHelper.TrangThaiHocSinhToText(trangThai);

            int index = cboTrangThai.Items.IndexOf(textTrangThai);
            if (index >= 0)
                cboTrangThai.SelectedIndex = index;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên học sinh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool gioiTinh = chkNam.Checked;
            string danToc = txtDanToc.Text.Trim();
            string tonGiao = txtTonGiao.Text.Trim();
            string queQuan = txtQueQuan.Text.Trim();

            // 🔹 Dùng EnumHelper để lấy byte trạng thái từ text
            byte trangThai = EnumHelper.TrangThaiHocSinhToValue(cboTrangThai.SelectedItem?.ToString() ?? "Đang học");

            int namNhapHoc = (int)numNamNhapHoc.Value;
            DateTime ngaySinh = dtNgaySinh.Value;

            bool ok;
            if (isEditMode)
            {
                ok = bll.CapNhatHocSinh(
                    hocSinhId.Value, hoTen, ngaySinh, gioiTinh, danToc, tonGiao, queQuan, namNhapHoc, trangThai
                );
                MessageBox.Show(ok ? "✅ Cập nhật thành công!" : "❌ Cập nhật thất bại!");
            }
            else
            {
                if (cboLop.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn lớp cho học sinh mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int lopId = Convert.ToInt32(cboLop.SelectedValue);
                ok = bll.ThemHocSinh(
                    hoTen, ngaySinh, gioiTinh, danToc, tonGiao, queQuan, namNhapHoc, trangThai, lopId
                );
                MessageBox.Show(ok ? "✅ Thêm học sinh thành công!" : "❌ Thêm thất bại!");
            }

            if (ok)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e) => this.Close();

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNam.Checked) chkNu.Checked = false;
        }

        private void chkNu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNu.Checked) chkNam.Checked = false;
        }
    }
}
