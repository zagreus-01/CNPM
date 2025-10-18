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
        private DataTable _lopData;

        public NhapDiemAdmin()
        {
            InitializeComponent();
            _bll = new DiemSoAdminBLL();
        }

        private void NhapDiemAdmin_Load(object sender, EventArgs e)
        {
            // 🔹 Thêm checkbox để lọc lớp đã kết thúc
            chkHienLopKetThuc.CheckedChanged += ChkHienLopKetThuc_CheckedChanged;
            LoadLopHoc();
        }

        private void ChkHienLopKetThuc_CheckedChanged(object sender, EventArgs e)
        {
            LoadLopHoc();
        }

        private void LoadLopHoc()
        {
            try
            {
                bool hienLopKetThuc = chkHienLopKetThuc.Checked;
                _lopData = _bll.GetAllLop(hienLopKetThuc);

                if (_lopData != null && _lopData.Rows.Count > 0)
                {
                    cboLop.ValueMember = "LopID";
                    cboLop.DisplayMember = "TenLopHienThi";
                    cboLop.DataSource = _lopData;
                    cboLop.SelectedIndex = 0;
                }
                else
                {
                    HandleNoData("Không có lớp học phù hợp.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách lớp học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMonHocTheoLop()
        {
            if (cboLop.SelectedValue == null)
            {
                cboMonHoc.DataSource = null;
                return;
            }

            try
            {
                int lopID = Convert.ToInt32(cboLop.SelectedValue);
                DataTable dt = _bll.GetMonHocTheoLop(lopID);

                if (dt != null && dt.Rows.Count > 0)
                {
                    cboMonHoc.ValueMember = "MonHocID";
                    cboMonHoc.DisplayMember = "TenMon";
                    cboMonHoc.DataSource = dt;
                    cboMonHoc.SelectedIndex = 0;
                }
                else
                {
                    cboMonHoc.DataSource = null;
                    MessageBox.Show("Lớp này chưa được phân công môn học nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMonHocTheoLop();
            LoadBangDiem();
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBangDiem();
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
                dt.Columns.Add("DTBM", typeof(decimal));
                foreach (DataRow row in dt.Rows)
                {
                    TinhVaCapNhatDTBMChoDataRow(row);
                }

                dgvDiemSo.DataSource = dt;
                SetupDataGridView();

                // 🔹 Kiểm tra xem lớp có kết thúc hay chưa để bật/tắt nhập điểm
                bool daKetThuc = KiemTraLopDaKetThuc(lopID);
                CaiDatQuyenNhapDiem(daKetThuc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải bảng điểm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool KiemTraLopDaKetThuc(int lopID)
        {
            if (_lopData == null) return false;
            DataRow[] rows = _lopData.Select($"LopID = {lopID}");
            if (rows.Length == 0) return false;
            return rows[0]["DaKetThuc"] != DBNull.Value && Convert.ToBoolean(rows[0]["DaKetThuc"]);
        }

        private void CaiDatQuyenNhapDiem(bool daKetThuc)
        {
            if (daKetThuc)
            {
                dgvDiemSo.ReadOnly = true;
                btnLuuDiem.Enabled = false;
                lblEmptyMessage.Visible = true;
                lblEmptyMessage.Text = "⚠️ Lớp này đã kết thúc. Bạn chỉ có thể xem điểm, không thể chỉnh sửa.";
                lblEmptyMessage.ForeColor = Color.OrangeRed;
            }
            else
            {
                dgvDiemSo.ReadOnly = false;
                btnLuuDiem.Enabled = true;
                lblEmptyMessage.Visible = false;
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

        private void SetupDataGridView()
        {
            if (dgvDiemSo.Columns.Contains("HocSinhID"))
                dgvDiemSo.Columns["HocSinhID"].Visible = false;

            dgvDiemSo.Columns["HoTen"].HeaderText = "Họ và Tên";
            dgvDiemSo.Columns["HoTen"].ReadOnly = true;
            dgvDiemSo.Columns["HoTen"].DefaultCellStyle.BackColor = Color.LightGray;
            dgvDiemSo.Columns["HoTen"].FillWeight = 200;

            foreach (string colName in new[] { "TX1", "TX2", "TX3", "TX4", "GiuaKy", "CuoiKy" })
            {
                if (dgvDiemSo.Columns.Contains(colName))
                    dgvDiemSo.Columns[colName].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvDiemSo.Columns.Contains("DTBM"))
            {
                dgvDiemSo.Columns["DTBM"].HeaderText = "ĐTBM";
                dgvDiemSo.Columns["DTBM"].ReadOnly = true;
                dgvDiemSo.Columns["DTBM"].DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    BackColor = Color.LightGray,
                    Font = new Font(dgvDiemSo.Font, FontStyle.Bold),
                    Format = "N2"
                };
            }
        }

        private void TinhVaCapNhatDTBMChoDataRow(DataRow row)
        {
            decimal tongTX = 0;
            int countTX = 0;

            foreach (var col in new[] { "TX1", "TX2", "TX3", "TX4" })
            {
                if (row[col] != DBNull.Value && decimal.TryParse(row[col].ToString(), out decimal diem))
                {
                    tongTX += diem;
                    countTX++;
                }
            }

            decimal gk = row["GiuaKy"] != DBNull.Value ? Convert.ToDecimal(row["GiuaKy"]) : 0;
            decimal ck = row["CuoiKy"] != DBNull.Value ? Convert.ToDecimal(row["CuoiKy"]) : 0;

            if (countTX > 0)
            {
                decimal tbtx = tongTX / countTX;
                row["DTBM"] = Math.Round((tbtx + gk + (ck * 2)) / 4, 2);
            }
            else
            {
                row["DTBM"] = DBNull.Value;
            }
        }

        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null || cboMonHoc.SelectedValue == null || dgvDiemSo.DataSource == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ Lớp và Môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int lopID = Convert.ToInt32(cboLop.SelectedValue);
            if (KiemTraLopDaKetThuc(lopID))
            {
                MessageBox.Show("Không thể lưu điểm cho lớp đã kết thúc.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvDiemSo.EndEdit();
            DataTable dt = (DataTable)dgvDiemSo.DataSource;
            DataTable dtToSave = dt.Copy();
            if (dtToSave.Columns.Contains("DTBM"))
                dtToSave.Columns.Remove("DTBM");

            int monHocID = Convert.ToInt32(cboMonHoc.SelectedValue);

            if (_bll.LuuBangDiem(dtToSave, lopID, monHocID))
                MessageBox.Show("Lưu điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Lưu điểm thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // Khi người dùng thay đổi giá trị điểm
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

        // Khi nhập dữ liệu không hợp lệ (VD: ký tự thay vì số)
        private void dgvDiemSo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Lỗi dữ liệu. Vui lòng chỉ nhập số từ 0 đến 10.",
                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            e.ThrowException = false;
            e.Cancel = false;
        }

        // Khi đang nhập và rời ô — kiểm tra hợp lệ 0–10
        private void dgvDiemSo_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvDiemSo.Columns[e.ColumnIndex].ReadOnly) return;
            if (string.IsNullOrEmpty(e.FormattedValue.ToString())) return;
            if (!decimal.TryParse(e.FormattedValue.ToString(), out decimal diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải là số từ 0 đến 10.", "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

    }
}
