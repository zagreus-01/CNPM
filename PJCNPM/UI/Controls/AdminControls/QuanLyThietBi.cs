using PJCNPM.BLL.Admin;
using System;
using System.Data;
using System.Windows.Forms;

namespace PJCNPM.UI.Controls.AdminControls
{
    public partial class QuanLyThietBi : UserControl
    {
        private ThietBiBLL bll = new ThietBiBLL();
        private int selectedID = -1;

        public QuanLyThietBi()
        {
            InitializeComponent();
            DonVicbo.DropDownStyle = ComboBoxStyle.DropDown;
            LoadDonViTinh();
            LoadData();
            this.DoubleBuffered = true;

        }

        private void LoadData()
        {
            DataTable dt = bll.GetAllThietBi();

            // Đặt tên hiển thị cột có dấu tiếng Việt
            dt.Columns["ThietBiID"].ColumnName = "Mã Thiết Bị";
            dt.Columns["TenThietBi"].ColumnName = "Tên Thiết Bị";
            dt.Columns["MoTa"].ColumnName = "Mô Tả";
            dt.Columns["SoLuong"].ColumnName = "Số Lượng";
            dt.Columns["DonViTinh"].ColumnName = "Đơn Vị Tính";

            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
            ClearInput();
        }
        private void LoadDonViTinh()
        {
            DataTable dt = bll.GetAllDonViTinh();
            DonVicbo.DataSource = dt;
            DonVicbo.DisplayMember = "DonViTinh";
            DonVicbo.ValueMember = "DonViTinh";
            DonVicbo.SelectedIndex = -1;
        }


        private void ClearInput()
        {
            ThietBitxt.Text = "";
            SoLuongtxt.Text = "";
            MoTatxt.Text = "";
            DonVicbo.SelectedIndex = -1;
            selectedID = -1;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ThietBitxt.Text) ||
                string.IsNullOrWhiteSpace(SoLuongtxt.Text) ||
                string.IsNullOrWhiteSpace(DonVicbo.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!int.TryParse(SoLuongtxt.Text, out int sl))
            {
                MessageBox.Show("Số lượng phải là số!");
                return;
            }

            if (bll.InsertThietBi(ThietBitxt.Text, MoTatxt.Text, sl, DonVicbo.Text))
            {
                MessageBox.Show("Thêm thiết bị thành công!");
                LoadData();
            }
            else MessageBox.Show("Thêm thất bại!");
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần sửa!");
                return;
            }

            if (!int.TryParse(SoLuongtxt.Text, out int sl))
            {
                MessageBox.Show("Số lượng phải là số!");
                return;
            }

            if (bll.UpdateThietBi(selectedID, ThietBitxt.Text, MoTatxt.Text, sl, DonVicbo.Text))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
            else MessageBox.Show("Cập nhật thất bại!");
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa thiết bị này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bll.DeleteThietBi(selectedID))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
                else MessageBox.Show("Xóa thất bại!");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các ô nhập
            string tenThietBi = ThietBitxt.Text.Trim();
            string moTa = MoTatxt.Text.Trim();
            string donViTinh = DonVicbo.Text.Trim();

            // Kiểm tra số lượng (nếu có nhập)
            int? soLuong = null;
            if (!string.IsNullOrWhiteSpace(SoLuongtxt.Text))
            {
                if (int.TryParse(SoLuongtxt.Text.Trim(), out int sl))
                {
                    soLuong = sl;
                }
                else
                {
                    MessageBox.Show("Số lượng phải là số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // 🔹 Nếu tất cả ô đều trống -> hiển thị toàn bộ dữ liệu
            if (string.IsNullOrWhiteSpace(tenThietBi) &&
                string.IsNullOrWhiteSpace(moTa) &&
                string.IsNullOrWhiteSpace(donViTinh) &&
                !soLuong.HasValue)
            {
                LoadData();
                return;
            }

            // 🔹 Gọi hàm tìm kiếm trong BLL
            DataTable dt = bll.SearchThietBi(tenThietBi, moTa, soLuong, donViTinh);

            // Kiểm tra nếu không có kết quả
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thiết bị nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null;
                return;
            }

            // Đặt lại tên hiển thị cột
            dt.Columns["ThietBiID"].ColumnName = "Mã Thiết Bị";
            dt.Columns["TenThietBi"].ColumnName = "Tên Thiết Bị";
            dt.Columns["MoTa"].ColumnName = "Mô Tả";
            dt.Columns["SoLuong"].ColumnName = "Số Lượng";
            dt.Columns["DonViTinh"].ColumnName = "Đơn Vị Tính";

            // Gán dữ liệu lên DataGridView
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
        }


        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearInput();
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedID = Convert.ToInt32(row.Cells["Mã Thiết Bị"].Value);
                ThietBitxt.Text = row.Cells["Tên Thiết Bị"].Value.ToString();
                MoTatxt.Text = row.Cells["Mô Tả"].Value.ToString();
                SoLuongtxt.Text = row.Cells["Số Lượng"].Value.ToString();
                DonVicbo.Text = row.Cells["Đơn Vị Tính"].Value.ToString();
            }
        }

        
    }
}
