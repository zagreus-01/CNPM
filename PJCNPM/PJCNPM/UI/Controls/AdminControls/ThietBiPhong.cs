using PJCNPM.BLL.NhanVienBLL;
using System;
using System.Data;
using System.Windows.Forms;
using PJCNPM.UI.PopUpFrm.NhanVienPopUp;
namespace PJCNPM.UI.Control.ControlNhanVien
{
    public partial class ThietBiPhong : UserControl
    {
        private ThietBiPhongHocBLL bll = new ThietBiPhongHocBLL();

        public ThietBiPhong()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        private void DanhSachThietBiPhong_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadData();
        }

        private void LoadComboBoxes()
        {
            // Thiết bị
            var dtTB = bll.GetThietBiList();
            ThietBicbo.DataSource = dtTB;
            ThietBicbo.DisplayMember = "TenThietBi";
            ThietBicbo.ValueMember = "ThietBiID";

            // Phòng học
            var dtPhong = bll.GetPhongList();
            Phongcbo.DataSource = dtPhong;
            Phongcbo.DisplayMember = "TenPhong";
            Phongcbo.ValueMember = "PhongHocID";
        }

        private void LoadData()
        {
            DataTable dt = bll.GetAll();

            // Đặt tiêu đề có dấu
            dt.Columns["TenThietBi"].ColumnName = "Tên Thiết Bị";
            dt.Columns["TenPhong"].ColumnName = "Tên Phòng";
            dt.Columns["SoLuong"].ColumnName = "Số Lượng";
            dt.Columns["DonViTinh"].ColumnName = "Đơn Vị Tính";

            dataGridView1.DataSource = dt;

            // Ẩn cột ID
            if (dataGridView1.Columns.Contains("ThietBiID"))
                dataGridView1.Columns["ThietBiID"].Visible = false;
            if (dataGridView1.Columns.Contains("PhongHocID"))
                dataGridView1.Columns["PhongHocID"].Visible = false;

            dataGridView1.ClearSelection();
            ClearInput();
        }

        private void ClearInput()
        {
            SoLuongtxt.Text = "";
            ThietBicbo.SelectedIndex = -1;
            Phongcbo.SelectedIndex = -1;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ThietBicbo.SelectedIndex == -1 || Phongcbo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(SoLuongtxt.Text))
                {
                    MessageBox.Show("Vui lòng chọn thiết bị, phòng học và nhập số lượng!");
                    return;
                }

                if (!int.TryParse(SoLuongtxt.Text, out int soLuong) || soLuong <= 0)
                {
                    MessageBox.Show("Số lượng phải là số nguyên dương!");
                    return;
                }

                int phongHocID = Convert.ToInt32(Phongcbo.SelectedValue);
                int thietBiID = Convert.ToInt32(ThietBicbo.SelectedValue);

                if (bll.Insert(phongHocID, thietBiID, soLuong))
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadData();
                }
                else MessageBox.Show("Không thể thêm (thiết bị có thể đã tồn tại trong phòng)!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(SoLuongtxt.Text, out int soLuong) || soLuong <= 0)
                {
                    MessageBox.Show("Số lượng phải là số nguyên dương!");
                    return;
                }

                int phongHocID = Convert.ToInt32(Phongcbo.SelectedValue);
                int thietBiID = Convert.ToInt32(ThietBicbo.SelectedValue);

                if (bll.Update(phongHocID, thietBiID, soLuong))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                }
                else MessageBox.Show("Cập nhật thất bại!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int phongHocID = Convert.ToInt32(Phongcbo.SelectedValue);
                int thietBiID = Convert.ToInt32(ThietBicbo.SelectedValue);

                if (MessageBox.Show("Bạn có chắc muốn xóa thiết bị này khỏi phòng?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (bll.Delete(phongHocID, thietBiID))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadData();
                    }
                    else MessageBox.Show("Xóa thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string tenThietBi = ThietBicbo.SelectedIndex != -1 ? ThietBicbo.Text.Trim() : null;
            string tenPhong = Phongcbo.SelectedIndex != -1 ? Phongcbo.Text.Trim() : null;

            int? soLuong = null;
            if (int.TryParse(SoLuongtxt.Text.Trim(), out int parsedSoLuong))
                soLuong = parsedSoLuong;

            // Nếu không nhập gì, load lại tất cả
            if (string.IsNullOrWhiteSpace(tenThietBi) && string.IsNullOrWhiteSpace(tenPhong) && soLuong == null)
            {
                LoadData();
                return;
            }

            DataTable dt = bll.Search(tenThietBi, tenPhong, soLuong);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null;
                return;
            }

            // Cập nhật header
            dt.Columns["TenThietBi"].ColumnName = "Tên Thiết Bị";
            dt.Columns["TenPhong"].ColumnName = "Tên Phòng";
            dt.Columns["SoLuong"].ColumnName = "Số Lượng";
            dt.Columns["DonViTinh"].ColumnName = "Đơn Vị Tính";

            dataGridView1.DataSource = dt;
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
                ThietBicbo.Text = row.Cells["Tên Thiết Bị"].Value.ToString();
                Phongcbo.Text = row.Cells["Tên Phòng"].Value.ToString();
                SoLuongtxt.Text = row.Cells["Số Lượng"].Value.ToString();
            }
        }

        private void KhoTBbtn_Click(object sender, EventArgs e)
        {
            KhoThietBiForm popup = new KhoThietBiForm();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog();
        }

        
    }
}
