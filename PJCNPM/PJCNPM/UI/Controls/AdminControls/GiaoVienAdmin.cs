// PJCNPM.UI.Controls.AdminControls.GiaoVienAdmin.cs

using PJCNPM.BLL.Admin;
using PJCNPM.UI.PopUpFrm.AdminPopUp;
using System;
using System.Data;
using System.Windows.Forms;

namespace PJCNPM.UI.Controls.AdminControls
{
    public partial class GiaoVienAdmin : UserControl
    {
        private readonly CRUDGiaoVienBLL _bll;
        private DataTable _giaoVienDataTable;

        public GiaoVienAdmin()
        {
            InitializeComponent();
            _bll = new CRUDGiaoVienBLL();
        }

        private void GiaoVienAdmin_Load(object sender, EventArgs e)
        {
            LoadAllGiaoVien();
            UpdateActionButtonsState();
        }

        private void LoadAllGiaoVien()
        {
            try
            {
                _giaoVienDataTable = _bll.GetAllGiaoVien();
                dgvGiaoVien.DataSource = _giaoVienDataTable;
                SetupDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu giáo viên. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchAndLoadGiaoVien(string keyword)
        {
            try
            {
                _giaoVienDataTable = _bll.SearchGiaoVien(keyword);
                dgvGiaoVien.DataSource = _giaoVienDataTable;
                // Không cần gọi lại SetupDataGridView() vì cấu trúc cột không đổi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm giáo viên. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            dgvGiaoVien.AutoGenerateColumns = false;
            dgvGiaoVien.Columns.Clear();

            // Thêm các cột theo thứ tự mong muốn
            dgvGiaoVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HoTen", HeaderText = "HỌ TÊN", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dgvGiaoVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "GioiTinhText", HeaderText = "GIỚI TÍNH" });
            dgvGiaoVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NgaySinh", HeaderText = "NGÀY SINH", DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });
            dgvGiaoVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenTK", HeaderText = "TÀI KHOẢN" });
            dgvGiaoVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "EMAIL", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            dgvGiaoVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DienThoai", HeaderText = "ĐIỆN THOẠI" });
            dgvGiaoVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CCCD", HeaderText = "CCCD" });
            dgvGiaoVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "QueQuan", HeaderText = "QUÊ QUÁN", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
        }


        private void UpdateActionButtonsState()
        {
            bool isRowSelected = dgvGiaoVien.SelectedRows.Count > 0;
            btnSua.Enabled = isRowSelected;
            btnXoa.Enabled = isRowSelected;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var form = new FrmGiaoVienEditAdmin())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadAllGiaoVien();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvGiaoVien.SelectedRows.Count > 0)
            {
                DataRowView drv = (DataRowView)dgvGiaoVien.SelectedRows[0].DataBoundItem;
                DataRow row = drv.Row;

                using (var form = new FrmGiaoVienEditAdmin(row))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadAllGiaoVien();
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGiaoVien.SelectedRows.Count > 0)
            {
                DataRowView drv = (DataRowView)dgvGiaoVien.SelectedRows[0].DataBoundItem;
                DataRow row = drv.Row;
                int giaoVienID = Convert.ToInt32(row["GiaoVienID"]);
                string hoTen = row["HoTen"].ToString();

                var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa giáo viên '{hoTen}'?\nTất cả dữ liệu liên quan (phân công, lịch dạy,...) cũng sẽ bị xóa.",
                                                  "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    string resultMessage = _bll.DeleteGiaoVien(giaoVienID);
                    MessageBox.Show(resultMessage, "Thông Báo Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllGiaoVien();
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadAllGiaoVien();
            }
            else
            {
                SearchAndLoadGiaoVien(keyword);
            }
        }

        private void dgvGiaoVien_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_giaoVienDataTable == null || dgvGiaoVien.Columns.Count <= e.ColumnIndex) return;

            string columnName = dgvGiaoVien.Columns[e.ColumnIndex].DataPropertyName;
            if (string.IsNullOrEmpty(columnName)) return;

            DataView dv = _giaoVienDataTable.DefaultView;
            if (dv == null) return;

            string currentSort = dv.Sort;
            string newSort;

            if (currentSort.Contains(columnName) && currentSort.EndsWith("ASC"))
            {
                newSort = $"{columnName} DESC";
            }
            else
            {
                newSort = $"{columnName} ASC";
            }
            dv.Sort = newSort;
            dgvGiaoVien.DataSource = dv.ToTable();
        }

        private void dgvGiaoVien_SelectionChanged(object sender, EventArgs e)
        {
            UpdateActionButtonsState();
        }
    }
}