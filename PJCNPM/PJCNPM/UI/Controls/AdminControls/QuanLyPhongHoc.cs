using PJCNPM.BLL.Admin;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PJCNPM.UI.Controls.AdminControls
{
    public partial class QuanLyPhongHoc : UserControl
    {
        private readonly PhongHocBLL bll = new PhongHocBLL();
        private int selectedID = -1;

        public QuanLyPhongHoc()
        {
            InitializeComponent();
            LoadComboBoxData();
            LoadData();
            this.DoubleBuffered = true;

        }

        // =============================
        //  Load dữ liệu và thiết lập DataGridView
        // =============================
        private void LoadData()
        {
            dataGridView1.DataSource = bll.GetAllPhongHoc();
            SetupGridHeader();
            dataGridView1.ClearSelection();
        }

        private void SetupGridHeader()
        {
            // đặt DataSource đã gán trước khi gọi hàm này
            if (dataGridView1.Columns.Contains("PhongHocID"))
            {
                dataGridView1.Columns["PhongHocID"].HeaderText = "Mã Phòng";
                dataGridView1.Columns["PhongHocID"].Visible = false;
            }
            if (dataGridView1.Columns.Contains("TenPhong"))
                dataGridView1.Columns["TenPhong"].HeaderText = "Tên Phòng";
            if (dataGridView1.Columns.Contains("LoaiPhong"))
                dataGridView1.Columns["LoaiPhong"].HeaderText = "Loại Phòng";
            if (dataGridView1.Columns.Contains("SucChua"))
                dataGridView1.Columns["SucChua"].HeaderText = "Sức chứa";
            if (dataGridView1.Columns.Contains("TrangThai"))
                dataGridView1.Columns["TrangThai"].HeaderText = "Trạng Thái";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // đăng ký cellformatting một lần an toàn (khử khả năng đăng ký nhiều lần)
            dataGridView1.CellFormatting -= DataGridView1_CellFormatting;
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }

        // C#7.3: dùng if/switch thay switch-expression
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns.Count <= e.ColumnIndex || e.ColumnIndex < 0) return;
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;

                if ((colName == "LoaiPhong" || colName.Equals("LoaiPhong", StringComparison.OrdinalIgnoreCase))
                    && e.Value != null && e.Value != DBNull.Value)
                {
                    int loai;
                    if (int.TryParse(e.Value.ToString(), out loai))
                    {
                        string display = "Không xác định";
                        switch (loai)
                        {
                            case 1:
                                display = "Phòng máy";
                                break;
                            case 2:
                                display = "Phòng thí nghiệm";
                                break;
                            case 3:
                                display = "Sân";
                                break;
                            case 4:
                                display = "Hội trường";
                                break;
                        }
                        e.Value = display;
                    }
                }

                if ((colName == "TrangThai" || colName.Equals("TrangThai", StringComparison.OrdinalIgnoreCase))
                    && e.Value != null && e.Value != DBNull.Value)
                {
                    int tt;
                    if (int.TryParse(e.Value.ToString(), out tt))
                    {
                        string display = tt == 1 ? "Phòng trống" : "Bảo trì";
                        e.Value = display;
                    }
                }
            }
            catch
            {
                // ignore formatting errors to avoid UI crash
            }
        }

        // =============================
        //  ComboBox setup
        // =============================
        private void LoadComboBoxData()
        {
            LoaiPhongcbo.Items.Clear();
            LoaiPhongcbo.Items.Add(new ComboBoxItem("Phòng máy", 1));
            LoaiPhongcbo.Items.Add(new ComboBoxItem("Phòng thí nghiệm", 2));
            LoaiPhongcbo.Items.Add(new ComboBoxItem("Sân", 3));
            LoaiPhongcbo.Items.Add(new ComboBoxItem("Hội trường", 4));

            TrangThaicbo.Items.Clear();
            TrangThaicbo.Items.Add(new ComboBoxItem("Bảo trì", 0));
            TrangThaicbo.Items.Add(new ComboBoxItem("Phòng trống", 1));
        }

        private void ClearInput()
        {
            TenPhongtxt.Clear();
            SucChuatxt.Clear();
            LoaiPhongcbo.SelectedIndex = -1;
            TrangThaicbo.SelectedIndex = -1;
            selectedID = -1;
        }

        // =============================
        //  Nút Thêm
        // =============================
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (LoaiPhongcbo.SelectedItem == null || TrangThaicbo.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại phòng và trạng thái!");
                return;
            }

            if (string.IsNullOrWhiteSpace(TenPhongtxt.Text) || !int.TryParse(SucChuatxt.Text, out int succhua))
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin!");
                return;
            }

            int loai = ((ComboBoxItem)LoaiPhongcbo.SelectedItem).Value;
            int trangthai = ((ComboBoxItem)TrangThaicbo.SelectedItem).Value;

            if (bll.InsertPhongHoc(TenPhongtxt.Text.Trim(), loai, succhua, trangthai))
            {
                MessageBox.Show("Thêm phòng học thành công!");
                LoadData();
                ClearInput();
            }
            else
                MessageBox.Show("Thêm thất bại!");
        }

        // =============================
        //  Nút Xóa
        // =============================
        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa phòng này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bll.DeletePhongHoc(selectedID))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    ClearInput();
                }
                else
                    MessageBox.Show("Xóa thất bại!");
            }
        }

        // =============================
        //  Nút Sửa
        // =============================
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!");
                return;
            }

            if (LoaiPhongcbo.SelectedItem == null || TrangThaicbo.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại phòng và trạng thái!");
                return;
            }

            if (!int.TryParse(SucChuatxt.Text, out int succhua))
            {
                MessageBox.Show("Sức chứa phải là số!");
                return;
            }

            int loai = ((ComboBoxItem)LoaiPhongcbo.SelectedItem).Value;
            int trangthai = ((ComboBoxItem)TrangThaicbo.SelectedItem).Value;

            if (bll.UpdatePhongHoc(selectedID, TenPhongtxt.Text.Trim(), loai, succhua, trangthai))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
                ClearInput();
            }
            else
                MessageBox.Show("Cập nhật thất bại!");
        }

        // =============================
        //  Nút Tìm kiếm
        // =============================
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string keyword = TenPhongtxt.Text.Trim();

            int? loaiPhong = null;
            int? trangThai = null;
            int? sucChua = null;

            if (LoaiPhongcbo.SelectedItem != null)
                loaiPhong = (int?)((ComboBoxItem)LoaiPhongcbo.SelectedItem).Value;

            if (TrangThaicbo.SelectedItem != null)
                trangThai = (int?)((ComboBoxItem)TrangThaicbo.SelectedItem).Value;

            if (int.TryParse(SucChuatxt.Text.Trim(), out int sc))
                sucChua = sc;

            // Nếu cả 3 ô đều trống → hiển thị lại toàn bộ danh sách
            if (string.IsNullOrWhiteSpace(keyword) && loaiPhong == null && trangThai == null && sucChua == null)
            {
                LoadData();
                return;
            }

            DataTable dt = bll.SearchPhongHoc(keyword, loaiPhong, trangThai, sucChua);
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phòng học nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = null;
                return;
            }

            dataGridView1.DataSource = dt;
            SetupGridHeader();
        }


        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearInput();
            LoadData();
        }

        // =============================
        //  Khi click vào dòng DataGridView
        // =============================
        private int? GetIntFromRow(DataGridViewRow row, string colName)
        {
            if (row == null) return null;
            if (!dataGridView1.Columns.Contains(colName)) return null;
            var cell = row.Cells[colName];
            if (cell == null || cell.Value == null || cell.Value == DBNull.Value) return null;
            if (int.TryParse(cell.Value.ToString(), out int val)) return val;
            return null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            var id = GetIntFromRow(row, "PhongHocID");
            if (id.HasValue) selectedID = id.Value;

            if (dataGridView1.Columns.Contains("TenPhong"))
                TenPhongtxt.Text = row.Cells["TenPhong"]?.Value?.ToString() ?? "";

            if (dataGridView1.Columns.Contains("SucChua"))
                SucChuatxt.Text = row.Cells["SucChua"]?.Value?.ToString() ?? "";

            var loai = GetIntFromRow(row, "LoaiPhong");
            if (loai.HasValue)
            {
                foreach (ComboBoxItem item in LoaiPhongcbo.Items)
                    if (item.Value == loai.Value) { LoaiPhongcbo.SelectedItem = item; break; }
            }
            else LoaiPhongcbo.SelectedIndex = -1;

            var trangthai = GetIntFromRow(row, "TrangThai");
            if (trangthai.HasValue)
            {
                foreach (ComboBoxItem item in TrangThaicbo.Items)
                    if (item.Value == trangthai.Value) { TrangThaicbo.SelectedItem = item; break; }
            }
            else TrangThaicbo.SelectedIndex = -1;
        }

        // =============================
        //  Class phụ cho ComboBox
        // =============================
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString() => Text;
        }

        
    }
}
