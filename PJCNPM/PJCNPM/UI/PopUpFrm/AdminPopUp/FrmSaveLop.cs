using PJCNPM.BLL.Admin;
using System;
using System.Data;
using System.Windows.Forms;

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    public partial class FrmSaveLop : Form
    {
        private readonly SaveLopBLL bll = new SaveLopBLL();
        private readonly int lopId; // 0 = thêm mới, >0 = sửa

        public FrmSaveLop(int id = 0)
        {
            InitializeComponent();
            lopId = id;
        }

        private void FrmSaveLop_Load(object sender, EventArgs e)
        {
            LoadNamHoc();
            LoadHocKi();
            LoadKhoiHoc();
            LoadGiaoVien();

            if (lopId > 0)
                LoadThongTinLop();
        }

        private void LoadNamHoc()
        {
            int year = DateTime.Now.Year;
            cboNamHoc.Items.Clear();
            for (int i = year - 2; i <= year + 1; i++)
                cboNamHoc.Items.Add(i);
            cboNamHoc.SelectedItem = year;
        }

        private void LoadHocKi()
        {
            cboHocKi.Items.Clear();
            cboHocKi.Items.AddRange(new object[] { 1, 2 });
            cboHocKi.SelectedIndex = 0;
        }

        private void LoadKhoiHoc()
        {
            cboKhoiHoc.Items.Clear();
            cboKhoiHoc.Items.AddRange(new object[] { 10, 11, 12 });
            cboKhoiHoc.SelectedIndex = 0;
        }

        private void LoadGiaoVien()
        {
            DataTable dt = lopId == 0
                ? bll.LayDanhSachGiaoVienChuaChuNhiem()
                : bll.LayDanhSachGiaoVienToanBo();

            cboGiaoVien.DataSource = dt;
            cboGiaoVien.DisplayMember = "HoTen";
            cboGiaoVien.ValueMember = "GiaoVienID";
        }

        private void LoadThongTinLop()
        {
            DataRow row = bll.LayThongTinLop(lopId);
            if (row == null) return;

            txtTenLop.Text = row["TenLop"].ToString();
            cboNamHoc.SelectedItem = Convert.ToInt32(row["NamHoc"]);
            cboHocKi.SelectedItem = Convert.ToInt32(row["HocKi"]);
            cboKhoiHoc.SelectedItem = Convert.ToInt32(row["KhoiHoc"]);
            chkDaKetThuc.Checked = Convert.ToBoolean(row["DaKetThuc"]);

            if (row["GiaoVienID"] != DBNull.Value)
                cboGiaoVien.SelectedValue = Convert.ToInt32(row["GiaoVienID"]);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenLop = txtTenLop.Text.Trim();
            if (string.IsNullOrEmpty(tenLop))
            {
                MessageBox.Show("⚠️ Vui lòng nhập tên lớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int namHoc = Convert.ToInt32(cboNamHoc.SelectedItem);
            int hocKi = Convert.ToInt32(cboHocKi.SelectedItem);
            int khoiHoc = Convert.ToInt32(cboKhoiHoc.SelectedItem);
            bool daKetThuc = chkDaKetThuc.Checked;
            int? giaoVienId = cboGiaoVien.SelectedValue != null ? Convert.ToInt32(cboGiaoVien.SelectedValue) : (int?)null;

            bool success = lopId == 0
                ? bll.ThemLop(tenLop, namHoc, hocKi, khoiHoc, giaoVienId)
                : bll.CapNhatLop(lopId, tenLop, namHoc, hocKi, khoiHoc, daKetThuc, giaoVienId);

            if (success)
            {
                MessageBox.Show("✅ Lưu lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("❌ Không thể lưu lớp học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
