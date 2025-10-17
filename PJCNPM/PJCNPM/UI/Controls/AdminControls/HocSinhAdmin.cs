using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PJCNPM.BLL.Admin;
using PJCNPM.UI.PopUpFrm.AdminPopUp;

namespace PJCNPM.UI.Controls.AdminControls
{
    public partial class HocSinhAdmin : UserControl
    {
        private readonly DocXoaHocSinhBLL bll = new DocXoaHocSinhBLL();
        private DataTable dtHocSinh;

        public HocSinhAdmin()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            bool hienThiDaKetThuc = chkDaKetThuc.Checked;

            // ✅ Luôn tải toàn bộ học sinh (không lọc lớp đã kết thúc)
            dtHocSinh = bll.LayTatCaHocSinh(hienThiDaKetThuc);

            dgvHocSinh.DataSource = dtHocSinh;

            // ✅ Load combobox lớp (lọc theo checkbox)
            cboLop.Items.Clear();
            cboLop.Items.Add("Tất cả");

            DataTable dtLop = bll.LayDanhSachLop(hienThiDaKetThuc);
            foreach (DataRow row in dtLop.Rows)
                cboLop.Items.Add(row["TenLop"].ToString());

            cboLop.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new FrmHocSinhEditAdmin().ShowDialog();
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvHocSinh.CurrentRow.Cells["HocSinhID"].Value);
            new FrmHocSinhEditAdmin(id).ShowDialog();
            LoadData();
        }

        private void btnChuyenLop_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvHocSinh.CurrentRow.Cells["HocSinhID"].Value);
            new FrmChuyenLopAdmin(id).ShowDialog();
            LoadData();
        }

        private void btnHocBa_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.CurrentRow == null) return;
            int hocSinhID = Convert.ToInt32(dgvHocSinh.CurrentRow.Cells["HocSinhID"].Value);
            using (var frm = new HocBaAdmin(hocSinhID))
            {
                frm.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvHocSinh.CurrentRow.Cells["HocSinhID"].Value);
            string ten = dgvHocSinh.CurrentRow.Cells["HoTen"].Value.ToString();

            if (MessageBox.Show($"Bạn có chắc muốn xóa học sinh {ten}?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (bll.XoaHocSinh(id))
                {
                    MessageBox.Show($"Đã xóa học sinh {ten}.");
                    LoadData();
                }
            }
        }

        private void LocDuLieu()
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            string lopChon = cboLop.SelectedItem?.ToString() ?? "Tất cả";
            bool hienThiDaKetThuc = chkDaKetThuc.Checked;

            dgvHocSinh.DataSource = bll.LocHocSinh(dtHocSinh, tuKhoa, lopChon, hienThiDaKetThuc);
        }

        private void btnLoc_Click(object sender, EventArgs e) => LocDuLieu();
        private void txtTimKiem_TextChanged(object sender, EventArgs e) => LocDuLieu();

        private void chkDaKetThuc_CheckedChanged(object sender, EventArgs e)
        {
            // ✅ Reload để làm mới combobox lớp, không ảnh hưởng danh sách học sinh
            LoadData();
            LocDuLieu();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e) => LocDuLieu();
        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHocSinh.CurrentRow == null) return;
            int hocSinhID = Convert.ToInt32(dgvHocSinh.CurrentRow.Cells["HocSinhID"].Value);
            using (var frm = new FrmHocSinhXemAdmin(hocSinhID))
            {
                frm.ShowDialog();
            }
        }
    }
}
