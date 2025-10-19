using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PJCNPM.UI.PopUpFrm.AdminPopUp;

namespace PJCNPM.UI.Controls.AdminControls
{
    public partial class HocSinhAdmin : UserControl
    {
        private DataTable dtHocSinh;

        public HocSinhAdmin()
        {
            InitializeComponent();
            LoadFakeData();
            
        }

        private void LoadFakeData()
        {
            dtHocSinh = new DataTable();
            dtHocSinh.Columns.Add("HocSinhID", typeof(int));
            dtHocSinh.Columns.Add("HoTen", typeof(string));
            dtHocSinh.Columns.Add("Lop", typeof(string));
            dtHocSinh.Columns.Add("NamHoc", typeof(string));
            dtHocSinh.Columns.Add("HocKy", typeof(string));
            dtHocSinh.Columns.Add("TrangThai", typeof(string));

            dtHocSinh.Rows.Add(1, "Nguyễn Văn A", "10A1", "2024-2025", "1", "Đang học");
            dtHocSinh.Rows.Add(2, "Trần Thị B", "10A2", "2024-2025", "1", "Đang học");
            dtHocSinh.Rows.Add(3, "Phạm Minh C", "11A1", "2023-2024", "2", "Đã kết thúc");

            dgvHocSinh.DataSource = dtHocSinh;
            cboLop.Items.Clear();
            cboLop.Items.Add("Tất cả");
            foreach (var lop in dtHocSinh.AsEnumerable().Select(r => r["Lop"].ToString()).Distinct())
                cboLop.Items.Add(lop);
            cboLop.SelectedIndex = 0;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            new FrmHocSinhEditAdmin().ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            new FrmHocSinhEditAdmin(1).ShowDialog();
        }

        private void btnChuyenLop_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.CurrentRow == null) return;
            string ten = dgvHocSinh.CurrentRow.Cells["HoTen"].Value.ToString();
            MessageBox.Show($"Chuyển lớp cho {ten} (FrmChuyenLopHocSinh).");
        }

        private void btnHocBa_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.CurrentRow == null) return;
            string ten = dgvHocSinh.CurrentRow.Cells["HoTen"].Value.ToString();
            MessageBox.Show($"Hiển thị học bạ của {ten}.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.CurrentRow == null) return;
            int id = (int)dgvHocSinh.CurrentRow.Cells["HocSinhID"].Value;
            string ten = dgvHocSinh.CurrentRow.Cells["HoTen"].Value.ToString();

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa học sinh {ten} cùng dữ liệu liên quan?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                var row = dtHocSinh.AsEnumerable().FirstOrDefault(r => (int)r["HocSinhID"] == id);
                if (row != null) row.Delete();
                MessageBox.Show($"Đã xóa học sinh {ten}.");
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            bool hienThiDaKetThuc = chkDaKetThuc.Checked;
            string lopChon = cboLop.SelectedItem?.ToString() ?? "Tất cả";

            var filtered = dtHocSinh.AsEnumerable()
                .Where(r =>
                    (lopChon == "Tất cả" || r["Lop"].ToString() == lopChon) &&
                    (hienThiDaKetThuc || r["TrangThai"].ToString() != "Đã kết thúc") &&
                    (r["HoTen"].ToString().ToLower().Contains(tuKhoa))
                );

            dgvHocSinh.DataSource = filtered.Any() ? filtered.CopyToDataTable() : dtHocSinh.Clone();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            bool hienThiDaKetThuc = chkDaKetThuc.Checked;
            string lopChon = cboLop.SelectedItem?.ToString() ?? "Tất cả";

            var filtered = dtHocSinh.AsEnumerable()
                .Where(r =>
                    (lopChon == "Tất cả" || r["Lop"].ToString() == lopChon) &&
                    (hienThiDaKetThuc || r["TrangThai"].ToString() != "Đã kết thúc") &&
                    (r["HoTen"].ToString().ToLower().Contains(tuKhoa))
                );

            dgvHocSinh.DataSource = filtered.Any() ? filtered.CopyToDataTable() : dtHocSinh.Clone();
        }

        private void chkDaKetThuc_CheckedChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            bool hienThiDaKetThuc = chkDaKetThuc.Checked;
            string lopChon = cboLop.SelectedItem?.ToString() ?? "Tất cả";

            var filtered = dtHocSinh.AsEnumerable()
                .Where(r =>
                    (lopChon == "Tất cả" || r["Lop"].ToString() == lopChon) &&
                    (hienThiDaKetThuc || r["TrangThai"].ToString() != "Đã kết thúc") &&
                    (r["HoTen"].ToString().ToLower().Contains(tuKhoa))
                );

            dgvHocSinh.DataSource = filtered.Any() ? filtered.CopyToDataTable() : dtHocSinh.Clone();
        }

        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHocSinh.CurrentRow == null) return;
            string ten = dgvHocSinh.CurrentRow.Cells["HoTen"].Value.ToString();
            MessageBox.Show($"Hiển thị học bạ của {ten}.");
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            bool hienThiDaKetThuc = chkDaKetThuc.Checked;
            string lopChon = cboLop.SelectedItem?.ToString() ?? "Tất cả";

            var filtered = dtHocSinh.AsEnumerable()
                .Where(r =>
                    (lopChon == "Tất cả" || r["Lop"].ToString() == lopChon) &&
                    (hienThiDaKetThuc || r["TrangThai"].ToString() != "Đã kết thúc") &&
                    (r["HoTen"].ToString().ToLower().Contains(tuKhoa))
                );

            dgvHocSinh.DataSource = filtered.Any() ? filtered.CopyToDataTable() : dtHocSinh.Clone();
        }
    }
}
