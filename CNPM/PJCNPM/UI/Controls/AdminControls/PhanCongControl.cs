using PJCNPM.BLL.Admin;
using PJCNPM.Mod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJCNPM.UI.Controls.AdminControls
{
    public partial class PhanCongControl : UserControl
    {
        private PhanCongBLL _phanCongBLL;
        private int selectedTeacherID = 0;
        private int selectedLopID = 0;
        private int selectedMonID = 0;

        public PhanCongControl()
        {
            InitializeComponent();
            _phanCongBLL = new PhanCongBLL();
            LoadGiaoVienCombo();
            LoadLopCombo();
            LoadMonCombo();
            LoadNamHocCombo();
            loadThongTinNghiepVuGV();
        }

        private void loadThongTinNghiepVuGV()
        {
            var dt = _phanCongBLL.LoadThongTinNghiepVuGV();
            dgvNghiepVuGV.DataSource = dt;
            dgvNghiepVuGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNghiepVuGV.Columns["NghiepVuID"].Visible = false;
            dgvNghiepVuGV.Columns["GiaoVienID"].Visible = false;
        }

        private void LoadGiaoVienCombo()
        {
            var list = _phanCongBLL.LoadGiaoVienCombo();
            cboGiaoVien.DisplayMember = "HoTen";
            cboGiaoVien.ValueMember = "GiaoVienID";
            cboGiaoVien.DataSource = list;
        }

        private void LoadLopCombo()
        {
            var list = _phanCongBLL.LoadLopCombo();

            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "LopID";
            cboLop.DataSource = new List<Lop>(list);

            cboLopChuNhiem.DisplayMember = "TenLop";
            cboLopChuNhiem.ValueMember = "LopID";
            cboLopChuNhiem.DataSource = list;
        }

        private void LoadMonCombo()
        {
            var list = _phanCongBLL.LoadMonCombo();
            cboMonHoc.DisplayMember = "TenMon";
            cboMonHoc.ValueMember = "MonHocID";
            cboMonHoc.DataSource = list;
        }


        private void LoadNamHocCombo()
        {
            var list = _phanCongBLL.GetNamHocList();
            cboNamHoc.DataSource = list;
            if (list.Count > 0)
            {
                cboNamHoc.SelectedIndex = 0;
                LoadHocKyCombo();
            }
        }

        private void LoadHocKyCombo()
        {
            if (cboNamHoc.SelectedItem != null)
            {
                string namHoc = cboNamHoc.SelectedItem.ToString();
                var list = _phanCongBLL.GetHocKyList(namHoc);
                cboHocKy.DataSource = list;
                if (list.Count > 0)
                {
                    cboHocKy.SelectedIndex = 0;
                }
            }
        }

        private void LoadNghiepVuForSelectedTeacher()
        {
            if (selectedTeacherID <= 0)
            {
                txtGioiHanTiet.Text = string.Empty;
                chkChuNhiem.Checked = false;
                cboLopChuNhiem.SelectedIndex = -1;
                return;
            }

            var info = _phanCongBLL.LoadNghiepVuForSelectedTeacher(selectedTeacherID);
            if (info == null)
            {
                txtGioiHanTiet.Text = string.Empty;
                chkChuNhiem.Checked = false;
                cboLopChuNhiem.SelectedIndex = -1;
                return;
            }

            txtGioiHanTiet.Text = info.SoTietToiDa?.ToString() ?? string.Empty;
            chkChuNhiem.Checked = info.LaChuNhiem == true;

            if (info.LopChuNhiemID.HasValue)
                cboLopChuNhiem.SelectedValue = info.LopChuNhiemID.Value;
            else
                cboLopChuNhiem.SelectedIndex = -1;
        }

        private void LoadAssignmentsForSelectedTeacher()
        {
            bool showInactiveClasses = chkShowInactiveClasses.Checked;
            var dt = _phanCongBLL.LoadAssignmentsForSelectedTeacher(selectedTeacherID, showInactiveClasses);

            dgvPhanCong.DataSource = dt;
            dgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhanCong.Columns["LopID"].Visible = false;
            dgvPhanCong.Columns["MonHocID"].Visible = false;
        }

        private void dgvNghiepVuGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvNghiepVuGV.Rows[e.RowIndex];

            selectedTeacherID = row?.Cells["GiaoVienID"]?.Value is int v ? v
              : (row?.Cells["GiaoVienID"]?.Value is string s && int.TryParse(s, out var x)) ? x : 0;

            if (selectedTeacherID > 0)
            {
                if (cboGiaoVien.DataSource == null) LoadGiaoVienCombo();
                cboGiaoVien.SelectedValue = selectedTeacherID;
            }

            LoadNghiepVuForSelectedTeacher();
            LoadAssignmentsForSelectedTeacher();
            selectedLopID = 0;
            selectedMonID = 0;
        }

        private void dgvPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvPhanCong.Rows[e.RowIndex];

            if (cboLop.DataSource == null) LoadLopCombo();
            if (cboMonHoc.DataSource == null) LoadMonCombo();

            var lopID = row?.Cells["LopID"]?.Value is int vl ? vl
              : (row?.Cells["LopID"]?.Value is string sl && int.TryParse(sl, out var xl)) ? xl : 0;

            var monID = row?.Cells["MonHocID"]?.Value is int vm ? vm
              : (row?.Cells["MonHocID"]?.Value is string sm && int.TryParse(sm, out var xm)) ? xm : 0;

            selectedLopID = lopID;
            selectedMonID = monID;

            if (lopID > 0) cboLop.SelectedValue = lopID;
            if (monID > 0) cboMonHoc.SelectedValue = monID;

            // Load số tiết từ cột "Số tiết"
            var soTietCell = row?.Cells["Số tiết"]?.Value;
            if (soTietCell != null && !string.IsNullOrEmpty(soTietCell.ToString()))
            {
                txtSoTiet.Text = soTietCell.ToString();
            }
            else
            {
                txtSoTiet.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cboGiaoVien.DataSource == null) LoadGiaoVienCombo();
            if (cboLop.DataSource == null) LoadLopCombo();
            if (cboMonHoc.DataSource == null) LoadMonCombo();

            if (!(cboGiaoVien.SelectedValue is int gvID) || gvID <= 0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên.");
                return;
            }
            selectedTeacherID = gvID;

            if (!(cboLop.SelectedValue is int lopID) || lopID <= 0)
            {
                MessageBox.Show("Vui lòng chọn lớp.");
                return;
            }

            if (!(cboMonHoc.SelectedValue is int monID) || monID <= 0)
            {
                MessageBox.Show("Vui lòng chọn môn.");
                return;
            }

            // Lấy số tiết từ textbox
            int? soTiet = null;
            if (!string.IsNullOrEmpty(txtSoTiet.Text.Trim()) && int.TryParse(txtSoTiet.Text.Trim(), out int st))
            {
                soTiet = st;
            }

            bool success;
            if (selectedLopID > 0 && selectedMonID > 0)
            {
                // Cập nhật phân công
                success = _phanCongBLL.UpdatePhanCong(selectedTeacherID, selectedLopID, selectedMonID, lopID, monID, soTiet);
                if (success)
                    MessageBox.Show("Cập nhật phân công thành công!");
                else
                    MessageBox.Show("Cập nhật phân công thất bại!");
            }
            else
            {
                // Thêm phân công mới
                success = _phanCongBLL.AddPhanCong(selectedTeacherID, lopID, monID, soTiet);
                if (success)
                    MessageBox.Show("Thêm phân công thành công!");
                else
                    MessageBox.Show("Thêm phân công thất bại!");
            }

            LoadAssignmentsForSelectedTeacher();
            selectedLopID = 0;
            selectedMonID = 0;
            loadThongTinNghiepVuGV();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (selectedLopID <= 0 || selectedMonID <= 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng phân công để xoá.");
                return;
            }
            var confirm = MessageBox.Show("Xác nhận xoá phân công này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            if (_phanCongBLL.DeletePhanCong(selectedTeacherID, selectedLopID, selectedMonID))
                MessageBox.Show("Xoá phân công thành công!");
            else
                MessageBox.Show("Xoá phân công thất bại!");

            LoadAssignmentsForSelectedTeacher();
            selectedLopID = 0;
            selectedMonID = 0;
            loadThongTinNghiepVuGV();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (cboGiaoVien.DataSource == null) LoadGiaoVienCombo();
            if (!(cboGiaoVien.SelectedValue is int gvID) || gvID <= 0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên.");
                return;
            }
            selectedTeacherID = gvID;

            int? soTietToiDa = null;
            if (int.TryParse(txtGioiHanTiet.Text.Trim(), out int st)) soTietToiDa = st;

            bool? laChuNhiem = chkChuNhiem.Checked;
            int? lopCN = null;
            if (cboLopChuNhiem.SelectedValue is int v && v > 0) lopCN = v;

            if (_phanCongBLL.SaveNghiepVuGV(selectedTeacherID, soTietToiDa, laChuNhiem, lopCN))
            {
                MessageBox.Show("Lưu nghiệp vụ giáo viên thành công!");
                loadThongTinNghiepVuGV();
                LoadNghiepVuForSelectedTeacher();
            }
            else
            {
                MessageBox.Show("Lưu nghiệp vụ giáo viên thất bại!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dgvNghiepVuGV.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng trong bảng tổng hợp nghiệp vụ giáo viên.");
                return;
            }

            int giaoVienID = 0;
            var cellGV = dgvNghiepVuGV.CurrentRow.Cells["GiaoVienID"];
            if (cellGV?.Value is int v) giaoVienID = v;
            else if (cellGV?.Value is string s && int.TryParse(s, out var x)) giaoVienID = x;

            if (giaoVienID <= 0)
            {
                MessageBox.Show("Không tìm thấy GiaoVienID hợp lệ.");
                return;
            }

            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xoá THÔNG TIN NGHIỆP VỤ và TẤT CẢ PHÂN CÔNG DẠY của giáo viên này không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            if (_phanCongBLL.DeleteNghiepVuAndAssignmentsByGV(giaoVienID))
            {
                MessageBox.Show("Đã xoá Nghiệp vụ và toàn bộ Phân công dạy của giáo viên.");
                loadThongTinNghiepVuGV();
                selectedTeacherID = 0;
                selectedLopID = 0;
                selectedMonID = 0;

                txtGioiHanTiet.Text = string.Empty;
                chkChuNhiem.Checked = false;
                cboLopChuNhiem.SelectedIndex = -1;
                dgvPhanCong.DataSource = null;
            }
            else
            {
                MessageBox.Show("Xoá thất bại (đã rollback).");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            selectedTeacherID = 0;
            selectedLopID = 0;
            selectedMonID = 0;

            if (cboGiaoVien.DataSource == null) LoadGiaoVienCombo();
            cboGiaoVien.SelectedIndex = -1;

            if (cboLop.DataSource == null) LoadLopCombo();
            if (cboMonHoc.DataSource == null) LoadMonCombo();
            cboLop.SelectedIndex = -1;
            cboMonHoc.SelectedIndex = -1;

            txtGioiHanTiet.Text = string.Empty;
            chkChuNhiem.Checked = false;
            cboLopChuNhiem.SelectedIndex = -1;
            txtSoTiet.Text = string.Empty;

            dgvPhanCong.DataSource = null;
            dgvNghiepVuGV.ClearSelection();
            loadThongTinNghiepVuGV();
        }

        private void chkShowInactiveClasses_CheckedChanged(object sender, EventArgs e)
        {
            // Reload assignments when checkbox state changes
            if (selectedTeacherID > 0)
            {
                LoadAssignmentsForSelectedTeacher();
            }
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHocKyCombo();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Trong giao diện phân công, luôn hiển thị tất cả môn học
            // để có thể phân công môn mới cho lớp
            LoadMonCombo();
        }

        private void btnXemTheoKy_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn năm học.");
                return;
            }

            string namHoc = cboNamHoc.SelectedItem.ToString();
            int? hocKy = null;
            
            if (cboHocKy.SelectedItem != null)
            {
                hocKy = (int)cboHocKy.SelectedItem;
            }

            var dt = _phanCongBLL.LoadAssignmentsBySemester(namHoc, hocKy);
            dgvPhanCong.DataSource = dt;
            dgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhanCong.Columns["GiaoVienID"].Visible = false;
            dgvPhanCong.Columns["LopID"].Visible = false;
            dgvPhanCong.Columns["MonHocID"].Visible = false;
        }

    }
}
