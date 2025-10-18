using PJCNPM.BLL.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using PJCNPM.UI.PopUpFrm.AdminPopUp;

namespace PJCNPM.UI.Controls.AdminControls
{
    public partial class LopAdmin : UserControl
    {
        private readonly LopHocBLL bll = new LopHocBLL();

        public LopAdmin()
        {
            InitializeComponent();
        }

        private void LopAdmin_Load(object sender, EventArgs e)
        {
            LoadNamHoc();
            LoadHocKi();
            LoadData();
        }

        private void LoadNamHoc()
        {
            List<int> dt = bll.LayDanhSachNamHoc();

            cboNamHoc.DisplayMember = "NamHoc";
            cboNamHoc.ValueMember = "NamHoc";
            cboNamHoc.DataSource = dt;

            // Ngắt sự kiện tạm thời để tránh SelectedIndexChanged bị kích hoạt sớm
            cboNamHoc.SelectedIndexChanged -= cboNamHoc_SelectedIndexChanged;

            if (dt.Count > 0)
                cboNamHoc.SelectedIndex = 0;

            cboNamHoc.SelectedIndexChanged += cboNamHoc_SelectedIndexChanged;

        }

        private void LoadHocKi()
        {
            cboHocKi.Items.Clear();
            cboHocKi.Items.AddRange(new object[] { "1", "2" });
            cboHocKi.SelectedIndex = 0;
        }

        private void LoadData()
        {
            int? namHoc = cboNamHoc.SelectedItem != null ? Convert.ToInt32(cboNamHoc.SelectedItem) : (int?)null;
            int? hocKi = cboHocKi.SelectedItem != null ? Convert.ToInt32(cboHocKi.SelectedItem) : (int?)null;
            bool hienKetThuc = chkDaKetThuc.Checked;
            string keyword = txtTimKiem.Text.Trim();

            DataTable dt = bll.LayDanhSachLop(namHoc, hocKi, hienKetThuc, keyword);
            dgvLop.DataSource = dt;
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e) => LoadData();
        private void cboHocKi_SelectedIndexChanged(object sender, EventArgs e) => LoadData();
        private void chkDaKetThuc_CheckedChanged(object sender, EventArgs e) => LoadData();
        private void txtTimKiem_TextChanged(object sender, EventArgs e) => LoadData();
        private void btnLoc_Click(object sender, EventArgs e) => LoadData();

        private void btnThem_Click(object sender, EventArgs e)
        {
            new FrmSaveLop(0).ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
          if (dgvLop.CurrentRow == null) return;
            int lopId = Convert.ToInt32(dgvLop.CurrentRow.Cells["LopID"].Value);
            new FrmSaveLop(lopId).ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow == null) return;
            int lopId = Convert.ToInt32(dgvLop.CurrentRow.Cells["LopID"].Value);

            if (MessageBox.Show("Xóa lớp này sẽ mất toàn bộ học sinh trong lớp. Bạn chắc chứ?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (bll.XoaLop(lopId))
                    LoadData();
                else
                    MessageBox.Show("Không thể xóa lớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChuyenHocSinh_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvLop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btnSua_Click(sender, e);
        }
    }
}
