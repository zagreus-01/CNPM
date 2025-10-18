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

namespace PJCNPM.UI.Controls.GiaoVienControls
{
    public partial class ThoiKhoaBieuGiaoVien : UserControl
    {
        private ThoiKhoaBieuBLL tkbBLL;
        private List<Lop> danhSachLop;
        private List<MonHoc> danhSachMonHoc;
        private int giaoVienID;
        private DataTable tkbDataTable;
        private bool hienThiLop = true; // Mặc định hiển thị tên lớp

        public ThoiKhoaBieuGiaoVien(int gvID)
        {
            InitializeComponent();
            this.giaoVienID = gvID;
            tkbBLL = new ThoiKhoaBieuBLL();
            InitializeData();
            SetupDataGridView();
        }

        private void InitializeData()
        {
            try
            {
                // Lấy thông tin giáo viên
                var giaoVienBLL = new PJCNPM.BLL.GiaoVien.GiaoVienBLL();
                var thongTinGV = giaoVienBLL.GetThongTinGiaoVienByID(giaoVienID);
                
                if (thongTinGV != null)
                {
                    lblTenGiaoVien.Text = $"Giáo viên: {thongTinGV.HoTen}";
                }
                else
                {
                    lblTenGiaoVien.Text = "Giáo viên: Không xác định";
                }

                danhSachLop = tkbBLL.GetDanhSachLop();
                danhSachMonHoc = tkbBLL.GetDanhSachMonHoc();

                // Thiết lập checkbox mặc định
                chkHienThiLop.Checked = hienThiLop;

                // Load TKB của giáo viên
                LoadTKBForGiaoVien(giaoVienID);
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

        private void LoadTKBForGiaoVien(int giaoVienID)
        {
            try
            {
                if (tkbDataTable == null)
                {
                    SetupDataGridView();
                }

                if (danhSachMonHoc == null || danhSachLop == null)
                {
                    InitializeData();
                }

                var tkbList = tkbBLL.GetTKBByGiaoVien(giaoVienID);
                
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
                    if (tkb.MonHocID.HasValue)
                    {
                        var monHoc = danhSachMonHoc?.FirstOrDefault(m => m.MonHocID == tkb.MonHocID);
                        var lop = danhSachLop?.FirstOrDefault(l => l.LopID == tkb.LopHocID);
                        
                        if (monHoc != null && lop != null)
                        {
                            string cellValue;
                            if (hienThiLop)
                            {
                                cellValue = $"{lop.TenLop} – {monHoc.TenMon}";
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
            if (giaoVienID == 0)
            {
                MessageBox.Show("Không thể cập nhật do không xác định được giáo viên.", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadTKBForGiaoVien(giaoVienID);
            MessageBox.Show("Cập nhật thời khóa biểu thành công!", "Thông báo", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chkHienThiLop_CheckedChanged(object sender, EventArgs e)
        {
            hienThiLop = chkHienThiLop.Checked;
            
            // Reload TKB nếu đã có giáo viên được xác định
            if (giaoVienID != 0)
            {
                LoadTKBForGiaoVien(giaoVienID);
            }
        }

        private void ThoiKhoaBieuGiaoVien_Load(object sender, EventArgs e)
        {
            // Khởi tạo dữ liệu khi load control
            if (giaoVienID == 0)
            {
                InitializeData();
            }
        }
    }
}
