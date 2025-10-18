using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PJCNPM.BLL.Admin;
using PJCNPM.Mod;

namespace PJCNPM.UI.Controls.HocSinhControls
{
    public partial class ThoiKhoaBieuHocSinh : UserControl
    {
        private ThoiKhoaBieuBLL tkbBLL;
        private List<GiaoVien> danhSachGiaoVien;
        private List<MonHoc> danhSachMonHoc;
        private int maHocSinh;
        private int lopID;
        private DataTable tkbDataTable;
        private bool hienThiGiaoVien = true; // Mặc định hiển thị tên giáo viên

        public ThoiKhoaBieuHocSinh(int maHS)
        {
            InitializeComponent();
            this.maHocSinh = maHS;
            tkbBLL = new ThoiKhoaBieuBLL();
            InitializeData();
            SetupDataGridView();
        }

        private void InitializeData()
        {
            try
            {
                // Lấy thông tin lớp của học sinh
                var hocSinhBLL = new PJCNPM.BLL.HocSinh.ThongTinHocSinhBLL();
                var thongTinHS = hocSinhBLL.GetThongTinHocSinh(maHocSinh);
                
                if (thongTinHS != null && thongTinHS.LopID.HasValue)
                {
                    lopID = thongTinHS.LopID.Value;
                    lblTenLop.Text = $"Lớp: {thongTinHS.TenLop}";
                }
                else
                {
                    MessageBox.Show("Không thể xác định lớp học của học sinh.", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                danhSachGiaoVien = tkbBLL.GetDanhSachGiaoVien();
                danhSachMonHoc = tkbBLL.GetDanhSachMonHoc();

                // Thiết lập checkbox mặc định
                chkHienThiGiaoVien.Checked = hienThiGiaoVien;

                // Load TKB của lớp
                LoadTKBForLop(lopID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi khởi tạo dữ liệu: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            // Tạo DataTable cho TKB
            tkbDataTable = new DataTable();
            tkbDataTable.Columns.Add("Tiet", typeof(int));
            tkbDataTable.Columns.Add("Thu2", typeof(string));
            tkbDataTable.Columns.Add("Thu3", typeof(string));
            tkbDataTable.Columns.Add("Thu4", typeof(string));
            tkbDataTable.Columns.Add("Thu5", typeof(string));
            tkbDataTable.Columns.Add("Thu6", typeof(string));
            tkbDataTable.Columns.Add("Thu7", typeof(string));

            // Thêm 7 tiết
            for (int i = 1; i <= 7; i++)
            {
                tkbDataTable.Rows.Add(i, "", "", "", "", "", "");
            }

            dgvTKB.DataSource = tkbDataTable;
            dgvTKB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTKB.AllowUserToAddRows = false;
            dgvTKB.AllowUserToDeleteRows = false;
            dgvTKB.ReadOnly = true;
            dgvTKB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Đặt tên cột
            dgvTKB.Columns["Tiet"].HeaderText = "Tiết";
            dgvTKB.Columns["Thu2"].HeaderText = "Thứ 2";
            dgvTKB.Columns["Thu3"].HeaderText = "Thứ 3";
            dgvTKB.Columns["Thu4"].HeaderText = "Thứ 4";
            dgvTKB.Columns["Thu5"].HeaderText = "Thứ 5";
            dgvTKB.Columns["Thu6"].HeaderText = "Thứ 6";
            dgvTKB.Columns["Thu7"].HeaderText = "Thứ 7";

            // Thiết lập style cho DataGridView
            dgvTKB.BackgroundColor = Color.White;
            dgvTKB.BorderStyle = BorderStyle.Fixed3D;
            dgvTKB.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvTKB.GridColor = Color.LightGray;
            dgvTKB.RowHeadersVisible = false;
            dgvTKB.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgvTKB.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTKB.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvTKB.EnableHeadersVisualStyles = false;
        }

        private void LoadTKBForLop(int lopID)
        {
            try
            {
                if (tkbDataTable == null)
                {
                    SetupDataGridView();
                }

                if (danhSachMonHoc == null || danhSachGiaoVien == null)
                {
                    InitializeData();
                }

                var tkbList = tkbBLL.GetTKBByLop(lopID);
                
                // Xóa dữ liệu cũ
                for (int i = 0; i < 7; i++) // 7 tiết
                {
                    for (int j = 1; j <= 6; j++) // 6 cột (Thu2-Thu7)
                    {
                        tkbDataTable.Rows[i][j] = "";
                    }
                }

                // Load dữ liệu mới
                foreach (var tkb in tkbList)
                {
                    // Tiết 1 thứ 2: Chào cờ, Tiết 2 thứ 2: SHCN
                    if (tkb.Thu == 2 && tkb.Tiet == 1)
                    {
                        tkbDataTable.Rows[tkb.Tiet - 1][1] = "Chào cờ"; // Thu2 = cột 1
                    }
                    else if (tkb.Thu == 2 && tkb.Tiet == 2)
                    {
                        tkbDataTable.Rows[tkb.Tiet - 1][1] = "SHCN"; // Thu2 = cột 1
                    }
                    else if (tkb.MonHocID.HasValue && tkb.GiaoVienID.HasValue)
                    {
                        var monHoc = danhSachMonHoc?.FirstOrDefault(m => m.MonHocID == tkb.MonHocID);
                        var giaoVien = danhSachGiaoVien?.FirstOrDefault(g => g.GiaoVienID == tkb.GiaoVienID);
                        
                        if (monHoc != null && giaoVien != null)
                        {
                            string cellValue;
                            if (hienThiGiaoVien)
                            {
                                cellValue = $"{monHoc.TenMon} – {giaoVien.HoTen}";
                            }
                            else
                            {
                                cellValue = monHoc.TenMon;
                            }
                            
                            // Map thu to column index: thu=2->1, thu=3->2, ..., thu=7->6
                            int columnIndex = tkb.Thu - 1;
                            if (columnIndex >= 1 && columnIndex <= 6)
                            {
                                tkbDataTable.Rows[tkb.Tiet - 1][columnIndex] = cellValue;
                            }
                        }
                    }
                }

                dgvTKB.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thời khóa biểu: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lopID == 0)
            {
                MessageBox.Show("Không thể cập nhật do không xác định được lớp học.", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadTKBForLop(lopID);
            MessageBox.Show("Cập nhật thời khóa biểu thành công!", "Thông báo", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chkHienThiGiaoVien_CheckedChanged(object sender, EventArgs e)
        {
            hienThiGiaoVien = chkHienThiGiaoVien.Checked;
            
            // Reload TKB nếu đã có lớp được xác định
            if (lopID != 0)
            {
                LoadTKBForLop(lopID);
            }
        }

        private void ThoiKhoaBieuHocSinh_Load(object sender, EventArgs e)
        {
            // Khởi tạo dữ liệu khi load control
            if (lopID == 0)
            {
                InitializeData();
            }
        }
    }
}
