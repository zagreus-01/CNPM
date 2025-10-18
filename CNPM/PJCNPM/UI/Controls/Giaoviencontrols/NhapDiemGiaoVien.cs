using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PJCNPM.BLL.GiaoVien;

namespace PJCNPM.UI.Controls.GiaoVienControls
{
    public partial class NhapDiemGiaoVien : UserControl
    {
        private readonly int _giaoVienID;
        private readonly DiemSoBLL _bll;

        public NhapDiemGiaoVien(int giaoVienID)
        {
            InitializeComponent();
            _giaoVienID = giaoVienID;
            _bll = new DiemSoBLL();
            this.dgvDiemSo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiemSo_CellValueChanged);
        }

        private void NhapDiemGiaoVien_Load(object sender, EventArgs e)
        {
            LoadLopHocVaChonMacDinh();
        }

        private void LoadLopHocVaChonMacDinh()
        {
            try
            {
                DataTable dt = _bll.GetLopDayCuaGiaoVien(_giaoVienID);
                if (dt != null && dt.Rows.Count > 0)
                {
                    cboLop.ValueMember = "LopID";
                    cboLop.DisplayMember = "TenLopHienThi";
                    cboLop.DataSource = dt;

                    if (cboLop.SelectedValue != null)
                    {
                        LoadMonHocVaChonMacDinh();
                    }
                }
                else
                {
                    cboLop.Enabled = false;
                    cboMonHoc.Enabled = false;
                    lblEmptyMessage.Visible = true;
                    dgvDiemSo.Visible = false;
                    btnLuuDiem.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách lớp học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMonHocVaChonMacDinh()
        {
            if (cboLop.SelectedValue == null) return;
            try
            {
                int lopID = Convert.ToInt32(cboLop.SelectedValue);
                DataTable dt = _bll.GetMonHocDayCuaGiaoVienTrongLop(_giaoVienID, lopID);
                if (dt != null && dt.Rows.Count > 0)
                {
                    cboMonHoc.ValueMember = "MonHocID";
                    cboMonHoc.DisplayMember = "TenMon";
                    cboMonHoc.DataSource = dt;
                    cboMonHoc.Enabled = true;

                    if (cboMonHoc.SelectedValue != null)
                    {
                        LoadBangDiem();
                    }
                }
                else
                {
                    cboMonHoc.DataSource = null;
                    cboMonHoc.Enabled = false;
                    dgvDiemSo.DataSource = null;
                    dgvDiemSo.Visible = false;
                    btnLuuDiem.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBangDiem()
        {
            if (cboLop.SelectedValue == null || cboMonHoc.SelectedValue == null) return;
            try
            {
                int lopID = Convert.ToInt32(cboLop.SelectedValue);
                int monHocID = Convert.ToInt32(cboMonHoc.SelectedValue);

                DataTable dt = _bll.GetDanhSachDiemCuaLop(lopID, monHocID);

                // **QUAN TRỌNG: Thêm cột và tính toán trên DataTable TRƯỚC KHI gán cho DataGridView**
                dt.Columns.Add("DTBM", typeof(decimal)); // Thêm cột mới vào DataTable
                foreach (DataRow row in dt.Rows)
                {
                    TinhVaCapNhatDTBMChoDataRow(row); // Tính toán và điền dữ liệu cho cột mới
                }

                // Bây giờ mới gán DataTable đã hoàn chỉnh cho DataGridView
                dgvDiemSo.DataSource = dt;
                SetupDataGridView(); // Cấu hình giao diện cho các cột đã có sẵn

                dgvDiemSo.Visible = true;
                btnLuuDiem.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải bảng điểm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl == cboLop)
            {
                LoadMonHocVaChonMacDinh();
            }
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl == cboMonHoc)
            {
                LoadBangDiem();
            }
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

            // Cấu hình cột DTBM đã tồn tại trong DataSource
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

        // **QUAN TRỌNG: Phương thức mới để tính toán trực tiếp trên DataRow**
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
                row["DTBM"] = Math.Round(dtbm, 2); // Cập nhật giá trị vào DataRow
            }
            else
            {
                row["DTBM"] = DBNull.Value; // Cập nhật giá trị DBNull vào DataRow
            }
        }

        private void dgvDiemSo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDiemSo.Rows.Count > e.RowIndex)
            {
                // Khi một cell thay đổi, lấy DataRow tương ứng và tính lại
                DataGridViewRow changedRow = dgvDiemSo.Rows[e.RowIndex];
                DataRowView drv = changedRow.DataBoundItem as DataRowView;
                if (drv != null)
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

            // Cần loại bỏ cột DTBM trước khi lưu vì CSDL không có cột này
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