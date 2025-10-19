using PJCNPM.BLL.Admin;
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
    public partial class TaiKhoanControl : UserControl
    {
        private TaiKhoanBLL _taiKhoanBLL;

        public TaiKhoanControl()
        {
            InitializeComponent();
            _taiKhoanBLL = new TaiKhoanBLL();
            LoadHocSinhGridAll();
            LoadGiaoVienGridAll();
        }

        private void LoadHocSinhGridAll()
        {
            var dt = _taiKhoanBLL.LoadHocSinhAccounts("");
            dgvHocSinh.DataSource = dt;
            dgvHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            EnsureCheckBoxColumn(dgvHocSinh);
            if (dgvHocSinh.Columns.Contains("Chon")) dgvHocSinh.Columns["Chon"].DisplayIndex = 0;

            SetHeaderIfPresent(dgvHocSinh, "HocSinhID", "ID học sinh");
            SetHeaderIfPresent(dgvHocSinh, "HoTen", "Tên học sinh");
            SetHeaderIfPresent(dgvHocSinh, "NamNhapHoc", "Năm nhập học");
            SetHeaderIfPresent(dgvHocSinh, "Lop", "Lớp");
            SetHeaderIfPresent(dgvHocSinh, "TrangThai", "Trạng thái");
            SetHeaderIfPresent(dgvHocSinh, "TenTK", "Tên TK");
            SetHeaderIfPresent(dgvHocSinh, "MatKhau", "Mật khẩu tài khoản");
            SetHeaderIfPresent(dgvHocSinh, "RoleID", "RoleID");
            SetHeaderIfPresent(dgvHocSinh, "VaiTro", "Vai trò");
        }

        private void LoadGiaoVienGridAll()
        {
            var dt = _taiKhoanBLL.LoadGiaoVienAccounts("");

            dgvGiaoVien.DataSource = dt;
            dgvGiaoVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            EnsureCheckBoxColumn(dgvGiaoVien);
            if (dgvGiaoVien.Columns.Contains("Chon")) dgvGiaoVien.Columns["Chon"].DisplayIndex = 0;

            SetHeaderIfPresent(dgvGiaoVien, "GiaoVienID", "ID giáo viên");
            SetHeaderIfPresent(dgvGiaoVien, "HoTen", "Tên giáo viên");
            SetHeaderIfPresent(dgvGiaoVien, "TrangThai", "Trạng thái");
            SetHeaderIfPresent(dgvGiaoVien, "TenTK", "Tên TK");
            SetHeaderIfPresent(dgvGiaoVien, "MatKhau", "Mật khẩu tài khoản");
            SetHeaderIfPresent(dgvGiaoVien, "RoleID", "RoleID");
            SetHeaderIfPresent(dgvGiaoVien, "VaiTro", "Vai trò");
        }

        private void EnsureCheckBoxColumn(DataGridView dgv)
        {
            const string chkName = "Chon";
            if (dgv.Columns.Contains(chkName))
                dgv.Columns.Remove(chkName);

            var c = new DataGridViewCheckBoxColumn();
            c.Name = chkName;
            c.HeaderText = "Chọn";
            c.DataPropertyName = "Chon";
            c.ReadOnly = false; // Cho phép edit checkbox
            dgv.Columns.Insert(0, c);
            
            // Set các cột khác là readonly
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Name != chkName)
                {
                    col.ReadOnly = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string kw = txtTimKiemHS.Text?.Trim() ?? "";
            var dt = _taiKhoanBLL.LoadHocSinhAccounts(kw);

            dgvHocSinh.DataSource = dt;
            dgvHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            EnsureCheckBoxColumn(dgvHocSinh);
            if (dgvHocSinh.Columns.Contains("Chon")) dgvHocSinh.Columns["Chon"].DisplayIndex = 0;

            SetDisplayIndexIfPresent(dgvHocSinh, "HocSinhID", 1);
            SetHeaderIfPresent(dgvHocSinh, "HocSinhID", "ID học sinh");
            SetHeaderIfPresent(dgvHocSinh, "HoTen", "Tên học sinh");
            SetHeaderIfPresent(dgvHocSinh, "NamNhapHoc", "Năm nhập học");
            SetHeaderIfPresent(dgvHocSinh, "Lop", "Lớp");
            SetHeaderIfPresent(dgvHocSinh, "TrangThai", "Trạng thái");
            SetHeaderIfPresent(dgvHocSinh, "TenTK", "Tên TK");
            SetHeaderIfPresent(dgvHocSinh, "MatKhau", "Mật khẩu tài khoản");
            SetHeaderIfPresent(dgvHocSinh, "RoleID", "RoleID");
            SetHeaderIfPresent(dgvHocSinh, "VaiTro", "Vai trò");
        }

        private void txtTimKiemHS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button4_Click(sender, e);
        }

        private void dgvHocSinh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvHocSinh.Rows[e.RowIndex];

            int hocSinhID = _taiKhoanBLL.ToInt(row.Cells["HocSinhID"]?.Value);
            string tenTK = Convert.ToString(row.Cells["TenTK"]?.Value ?? "");
            string mk = Convert.ToString(row.Cells["MatKhau"]?.Value ?? "");
            int? role = _taiKhoanBLL.ToNullableInt(row.Cells["RoleID"]?.Value);
            int trangThaiGrid = _taiKhoanBLL.ParseTrangThai(row.Cells["TrangThai"]?.Value);

            var dlg = new PJCNPM.UI.PopUpFrm.AdminPopUp.EditTaiKhoanForm(new int?[] { 1,2,3 });
            dlg.TenTK = tenTK;
            dlg.MatKhau = mk;
            dlg.RoleID = role;
            dlg.TrangThai = trangThaiGrid;

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                if (!string.Equals(tenTK, dlg.TenTK, StringComparison.Ordinal))
                {
                    _taiKhoanBLL.UpdateTenTKForHocSinh(hocSinhID, dlg.TenTK);
                }

                bool isActive = dlg.TrangThai == 1;
                _taiKhoanBLL.UpdateAccount(dlg.TenTK, dlg.MatKhau, isActive, dlg.RoleID);

                button4_Click(null, EventArgs.Empty);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var selectedUsers = new List<string>();
            foreach (DataGridViewRow r in dgvHocSinh.Rows)
            {
                bool isChecked = false;
                try { isChecked = Convert.ToBoolean(r.Cells["Chon"].Value ?? false); } catch { }
                if (isChecked)
                {
                    var u = Convert.ToString(r.Cells["TenTK"]?.Value ?? "");
                    if (!string.IsNullOrWhiteSpace(u)) selectedUsers.Add(u);
                }
            }
            if (selectedUsers.Count == 0)
            {
                MessageBox.Show("Vui lòng tích chọn ít nhất 1 dòng.");
                return;
            }

            var choose = MessageBox.Show("Bạn muốn đặt RoleID = 1? (Nhấn No để đặt NULL)",
                                         "Cấu hình Role HS",
                                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (choose == DialogResult.Cancel) return;

            int? role = (choose == DialogResult.Yes) ? 1 : (int?)null;
            int n = _taiKhoanBLL.BulkUpdateRole(selectedUsers, role);
            MessageBox.Show($"Đã cập nhật Role cho {n} tài khoản.");

            button4_Click(null, EventArgs.Empty);
            LoadHocSinhGridAll();
            LoadGiaoVienGridAll();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string kw = txtTimKiemGV.Text?.Trim() ?? "";
            var dt = _taiKhoanBLL.LoadGiaoVienAccounts(kw);

            dgvGiaoVien.DataSource = dt;
            dgvGiaoVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            EnsureCheckBoxColumn(dgvGiaoVien);
            if (dgvGiaoVien.Columns.Contains("Chon")) dgvGiaoVien.Columns["Chon"].DisplayIndex = 0;

            SetHeaderIfPresent(dgvGiaoVien, "GiaoVienID", "ID giáo viên");
            SetHeaderIfPresent(dgvGiaoVien, "HoTen", "Tên giáo viên");
            SetHeaderIfPresent(dgvGiaoVien, "TrangThai", "Trạng thái");
            SetHeaderIfPresent(dgvGiaoVien, "TenTK", "Tên TK");
            SetHeaderIfPresent(dgvGiaoVien, "MatKhau", "Mật khẩu tài khoản");
            SetHeaderIfPresent(dgvGiaoVien, "RoleID", "RoleID");
            SetHeaderIfPresent(dgvGiaoVien, "VaiTro", "Vai trò");
        }

        private void txtTimKiemGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button12_Click(sender, e);
        }

        private void dgvGiaoVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvGiaoVien.Rows[e.RowIndex];

            string tenTK = Convert.ToString(row.Cells["TenTK"]?.Value ?? "");
            string mk = Convert.ToString(row.Cells["MatKhau"]?.Value ?? "");
            int? role = _taiKhoanBLL.ToNullableInt(row.Cells["RoleID"]?.Value);
            int trangThaiGrid = _taiKhoanBLL.ParseTrangThai(row.Cells["TrangThai"]?.Value);

            var dlg = new PJCNPM.UI.PopUpFrm.AdminPopUp.EditTaiKhoanForm(new int?[] {1, 2, 3 });
            dlg.TenTK = tenTK;
            dlg.MatKhau = mk;
            dlg.RoleID = role;
            dlg.TrangThai = trangThaiGrid;

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                bool isActive = (dlg.TrangThai == 1);
                _taiKhoanBLL.UpdateAccount(dlg.TenTK, dlg.MatKhau, isActive, dlg.RoleID);
                button12_Click(null, EventArgs.Empty);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var selectedUsers = new List<string>();
            foreach (DataGridViewRow r in dgvGiaoVien.Rows)
            {
                bool isChecked = false;
                try { isChecked = Convert.ToBoolean(r.Cells["Chon"].Value ?? false); } catch { }
                if (isChecked)
                {
                    var u = Convert.ToString(r.Cells["TenTK"]?.Value ?? "");
                    if (!string.IsNullOrWhiteSpace(u)) selectedUsers.Add(u);
                }
            }
            if (selectedUsers.Count == 0)
            {
                MessageBox.Show("Vui lòng tích chọn ít nhất 1 dòng.");
                return;
            }

            var choose = MessageBox.Show("Bạn muốn đặt RoleID = 2? (Nhấn No để đặt NULL)",
                                         "Cấu hình Role GV",
                                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (choose == DialogResult.Cancel) return;

            int? role = (choose == DialogResult.Yes) ? 2 : (int?)null;
            int n = _taiKhoanBLL.BulkUpdateRole(selectedUsers, role);
            MessageBox.Show($"Đã cập nhật Role cho {n} tài khoản.");

            button12_Click(null, EventArgs.Empty);
            LoadHocSinhGridAll();
            LoadGiaoVienGridAll();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var oldCursor = Cursor;
            var btn = sender as Guna.UI2.WinForms.Guna2Button;
            if (btn != null) btn.Enabled = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                var selectedUsers = new HashSet<string>(StringComparer.Ordinal);
                foreach (DataGridViewRow r in dgvHocSinh.Rows)
                {
                    if (r.IsNewRow) continue;

                    bool isChecked = false;
                    try { isChecked = Convert.ToBoolean(r.Cells["Chon"]?.Value ?? false); } catch { /* ignore */ }
                    if (!isChecked) continue;

                    var u = Convert.ToString(r.Cells["TenTK"]?.Value ?? "").Trim();
                    if (!string.IsNullOrWhiteSpace(u))
                        selectedUsers.Add(u);
                }

                if (selectedUsers.Count == 0)
                {
                    MessageBox.Show("Vui lòng tích chọn ít nhất 1 dòng.", "Thiếu lựa chọn",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var choose = MessageBox.Show(
                    "Bạn muốn đặt trạng thái Hoạt động? (Nhấn No để đặt Khoá)",
                    "Cấu hình trạng thái tài khoản",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (choose == DialogResult.Cancel) return;

                bool trangThai = (choose == DialogResult.Yes);

                int n = 0, fail = 0;
                foreach (var u in selectedUsers)
                {
                    try
                    {
                        if (_taiKhoanBLL.UpdateTrangThaiByTenTK(u, trangThai)) n++;
                        else fail++;
                    }
                    catch
                    {
                        fail++;
                    }
                }

                MessageBox.Show(
                    $"Đã cập nhật trạng thái cho {n}/{selectedUsers.Count} tài khoản"
                    + (fail > 0 ? $". Thất bại: {fail}" : ""),
                    "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);

                button4_Click(null, EventArgs.Empty);
            }
            finally
            {
                Cursor = oldCursor;
                if (btn != null) btn.Enabled = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var oldCursor = Cursor;
            var btn = sender as Guna.UI2.WinForms.Guna2Button;
            if (btn != null) btn.Enabled = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                var selectedUsers = new HashSet<string>(StringComparer.Ordinal);
                foreach (DataGridViewRow r in dgvGiaoVien.Rows)
                {
                    if (r.IsNewRow) continue;

                    bool isChecked = false;
                    try { isChecked = Convert.ToBoolean(r.Cells["Chon"]?.Value ?? false); } catch { /* ignore */ }

                    if (!isChecked) continue;

                    var u = Convert.ToString(r.Cells["TenTK"]?.Value ?? "").Trim();
                    if (!string.IsNullOrWhiteSpace(u))
                        selectedUsers.Add(u);
                }

                if (selectedUsers.Count == 0)
                {
                    MessageBox.Show("Vui lòng tích chọn ít nhất 1 dòng.", "Thiếu lựa chọn",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var choose = MessageBox.Show(
                    "Bạn muốn đặt trạng thái Hoạt động? (Nhấn No để đặt Khoá)",
                    "Cấu hình trạng thái tài khoản",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (choose == DialogResult.Cancel) return;

                bool trangThai = (choose == DialogResult.Yes);

                int n = 0, fail = 0;
                foreach (var u in selectedUsers)
                {
                    try
                    {
                        if (_taiKhoanBLL.UpdateTrangThaiByTenTK(u, trangThai)) n++;
                        else fail++;
                    }
                    catch
                    {
                        fail++;
                    }
                }

                MessageBox.Show(
                    $"Đã cập nhật trạng thái cho {n}/{selectedUsers.Count} tài khoản"
                    + (fail > 0 ? $". Thất bại: {fail}" : ""),
                    "Hoàn tất",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                button12_Click(null, EventArgs.Empty);
            }
            finally
            {
                Cursor = oldCursor;
                if (btn != null) btn.Enabled = true;
            }
        }

        private void txtTimKiemHS_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiemHS.Text))
                LoadHocSinhGridAll();
        }

        private void txtTimKiemGV_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiemGV.Text))
                LoadGiaoVienGridAll();
        }

        private void dgvHocSinh_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvHocSinh.IsCurrentCellDirty)
                dgvHocSinh.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvGiaoVien_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvGiaoVien.IsCurrentCellDirty)
                dgvGiaoVien.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private static void SetHeaderIfPresent(DataGridView dgv, string colName, string header)
        {
            if (dgv.Columns.Contains(colName)) dgv.Columns[colName].HeaderText = header;
        }

        private static void SetDisplayIndexIfPresent(DataGridView dgv, string col, int idx)
        {
            if (dgv.Columns.Contains(col)) dgv.Columns[col].DisplayIndex = idx;
        }
    }
}
