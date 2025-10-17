// PJCNPM.UI.Controls.AdminControls.NhapDiemAdmin.cs

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PJCNPM.BLL.Admin;

namespace PJCNPM.UI.Controls.AdminControls
{
    public partial class NhapDiemAdmin : UserControl
    {
        private readonly DiemSoAdminBLL _bll;

        public NhapDiemAdmin()
        {
            InitializeComponent();
            _bll = new DiemSoAdminBLL();
        }

        private void NhapDiemAdmin_Load(object sender, EventArgs e)
        {
            LoadLopHoc();
            LoadMonHoc();
        }

        private void LoadLopHoc()
        {
            try
            {
                DataTable dt = _bll.GetAllLop();
                if (dt != null && dt.Rows.Count > 0)
                {
                    cboLop.ValueMember = "LopID";
                    cboLop.DisplayMember = "TenLopHienThi";
                    cboLop.DataSource = dt;
                    cboLop.SelectedIndex = 0; // Chọn lớp đầu tiên
                }
                else
                {
                    HandleNoData("Chưa có lớp học nào trong hệ thống.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách lớp học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMonHoc()
        {
            try
            {
                DataTable dt = _bll.GetAllMonHoc();
                if (dt != null && dt.Rows.Count > 0)
                {
                    cboMonHoc.ValueMember = "MonHocID";
                    cboMonHoc.DisplayMember = "TenMon";
                    cboMonHoc.DataSource = dt;
                    cboMonHoc.SelectedIndex = 0; // Chọn môn đầu tiên
                }
                else
                {
                    HandleNoData("Chưa có môn học nào trong hệ thống.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBangDiem()
        {
            if (cboLop.SelectedValue == null || cboMonHoc.SelectedValue == null)
            {
                dgvDiemSo.DataSource = null;
                return;
            }
            try
            {
                int lopID = Convert.ToInt32(cboLop.SelectedValue);
                int monHocID = Convert.ToInt32(cboMonHoc.SelectedValue);

                DataTable dt = _bll.GetDanhSachDiemCuaLop(lopID, monHocID);

                dt.Columns.Add("DTBM", typeof(decimal)); // Thêm cột điểm trung bình môn
                foreach (DataRow row in dt.Rows)
                {
                    TinhVaCapNhatDTBMChoDataRow(row);
                }

                dgvDiemSo.DataSource = dt;
                SetupDataGridView();

                dgvDiemSo.Visible = true;
                btnLuuDiem.Visible = true;
                lblEmptyMessage.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải bảng điểm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleNoData(string message)
        {
            cboLop.Enabled = false;
            cboMonHoc.Enabled = false;
            lblEmptyMessage.Text = message;
            lblEmptyMessage.Visible = true;
            dgvDiemSo.Visible = false;
            btnLuuDiem.Visible = false;
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBangDiem();
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBangDiem();
        }

        private void SetupDataGridView()
        {
            dgvDiemSo.Columns["HocSinhID"].Visible = false;
            dgvDiemSo.Columns["HoTen"].HeaderText = "Họ và Tên";
            dgvDiemSo.Columns["HoTen"].ReadOnly = true;
            dgvDiemSo.Columns["HoTen"].DefaultCellStyle.BackColor = Color.LightGray;
            dgvDiemSo.Columns["HoTen"].FillWeight = 200;

            dgvDiemSo.Columns["TX1"].HeaderText = "TX 1";
            dgvDiemSo.Columns["TX2"].HeaderText = "TX 2";
            dgvDiemSo.Columns["TX3"].HeaderText = "TX 3";
            dgvDiemSo.Columns["TX4"].HeaderText = "TX 4";
            dgvDiemSo.Columns["GiuaKy"].HeaderText = "Giữa Kỳ";
            dgvDiemSo.Columns["CuoiKy"].HeaderText = "Cuối Kỳ";

            dgvDiemSo.Columns["DTBM"].HeaderText = "ĐTBM";
            dgvDiemSo.Columns["DTBM"].ReadOnly = true;
            dgvDiemSo.Columns["DTBM"].DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                BackColor = Color.LightGray,
                Font = new Font(dgvDiemSo.Font, FontStyle.Bold),
                Format = "N2"
            };
            dgvDiemSo.Columns["DTBM"].FillWeight = 90;

            foreach (DataGridViewColumn col in dgvDiemSo.Columns)
            {
                if (col.Name != "HoTen" && col.Name != "DTBM")
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.FillWeight = 80;
                }
            }
        }

        private void TinhVaCapNhatDTBMChoDataRow(DataRow row)
        {
            decimal tongDiemTX = 0;
            int soDiemTX = 0;

            foreach (string colName in new[] { "TX1", "TX2", "TX3", "TX4" })
            {
                if (row[colName] != DBNull.Value && decimal.TryParse(row[colName].ToString(), out decimal diem))
                {
                    tongDiemTX += diem;
                    soDiemTX++;
                }
            }

            decimal diemGK = 0;
            bool coDiemGK = row["GiuaKy"] != DBNull.Value && decimal.TryParse(row["GiuaKy"].ToString(), out diemGK);

            decimal diemCK = 0;
            bool coDiemCK = row["CuoiKy"] != DBNull.Value && decimal.TryParse(row["CuoiKy"].ToString(), out diemCK);

            if (soDiemTX > 0 && coDiemGK && coDiemCK)
            {
                decimal diemTBTX = tongDiemTX / soDiemTX;
                decimal dtbm = (diemTBTX + diemGK + (diemCK * 2)) / 4;
                row["DTBM"] = Math.Round(dtbm, 2);
            }
            else
            {
                row["DTBM"] = DBNull.Value;
            }
        }

        private void dgvDiemSo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDiemSo.Rows.Count > e.RowIndex)
            {
                DataGridViewRow changedRow = dgvDiemSo.Rows[e.RowIndex];
                if (changedRow.DataBoundItem is DataRowView drv)
                {
                    DataRow dataRow = drv.Row;
                    TinhVaCapNhatDTBMChoDataRow(dataRow);
                }
            }
        }

        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null || cboMonHoc.SelectedValue == null || dgvDiemSo.DataSource == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ Lớp và Môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvDiemSo.EndEdit();
            DataTable dtDiem = (DataTable)dgvDiemSo.DataSource;

            // Tạo bản sao để loại bỏ cột DTBM trước khi lưu
            DataTable dtToSave = dtDiem.Copy();
            if (dtToSave.Columns.Contains("DTBM"))
            {
                dtToSave.Columns.Remove("DTBM");
            }

            int lopID = Convert.ToInt32(cboLop.SelectedValue);
            int monHocID = Convert.ToInt32(cboMonHoc.SelectedValue);

            bool success = _bll.LuuBangDiem(dtToSave, lopID, monHocID);

            if (success)
            {
                MessageBox.Show("Lưu điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu điểm thất bại. Đã có lỗi xảy ra.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDiemSo_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvDiemSo.Columns[e.ColumnIndex].ReadOnly) return;
            if (string.IsNullOrEmpty(e.FormattedValue.ToString())) return;
            if (!decimal.TryParse(e.FormattedValue.ToString(), out decimal diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải là một số từ 0 đến 10.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void dgvDiemSo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Lỗi dữ liệu. Vui lòng chỉ nhập số cho các cột điểm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false;
            e.Cancel = false;
        }
    }
}