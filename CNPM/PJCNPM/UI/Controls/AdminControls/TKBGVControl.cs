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

namespace PJCNPM.UI.Controls.AdminControls
{
    public partial class TKBGVControl : UserControl
    {
        private ThoiKhoaBieuBLL tkbBLL;
        private List<GiaoVien> danhSachGiaoVien;
        private List<Lop> danhSachLop;
        private List<MonHoc> danhSachMonHoc;
        private int selectedGiaoVienID = -1;
        private DataTable tkbDataTable;
        private bool hienThiMonHoc = true; // Mặc định hiển thị tên môn học

        public TKBGVControl()
        {
            InitializeComponent();
            tkbBLL = new ThoiKhoaBieuBLL();
            InitializeData();
            SetupDataGridView();
        }

        private void InitializeData()
        {
            danhSachGiaoVien = tkbBLL.GetDanhSachGiaoVien();
            danhSachLop = tkbBLL.GetDanhSachLop();
            danhSachMonHoc = tkbBLL.GetDanhSachMonHoc();

            // Load danh sách giáo viên vào ComboBox
            cboGiaoVien.DataSource = danhSachGiaoVien;
            cboGiaoVien.DisplayMember = "HoTen";
            cboGiaoVien.ValueMember = "GiaoVienID";
            cboGiaoVien.SelectedIndex = -1;

            // Thiết lập checkbox mặc định
            chkHienThiLop.Checked = hienThiMonHoc;
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
        }

        private void cboGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGiaoVien.SelectedItem != null)
            {
                try
                {
                    var selectedGiaoVien = cboGiaoVien.SelectedItem as GiaoVien;
                    if (selectedGiaoVien != null)
                    {
                        selectedGiaoVienID = selectedGiaoVien.GiaoVienID;
                        LoadTKBForGiaoVien(selectedGiaoVienID);
                        LoadThongKeTiet(selectedGiaoVienID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi chọn giáo viên: {ex.Message}", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                            if (hienThiMonHoc)
                            {
                                cellValue = $"{lop.TenLop} – {monHoc.TenMon}";
                            }
                            else
                            {
                                cellValue = lop.TenLop;
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
                MessageBox.Show($"Lỗi khi tải TKB giáo viên: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadThongKeTiet(int giaoVienID)
        {
            try
            {
                var thongKeData = tkbBLL.GetThongKeTietByGiaoVien(giaoVienID);
                dgvThongKe.DataSource = thongKeData;
                
                // Đặt tên cột cho DataGridView
                if (dgvThongKe.Columns.Count > 0)
                {
                    dgvThongKe.Columns["TenMonHoc"].HeaderText = "Môn Học";
                    dgvThongKe.Columns["SoTietThucTe"].HeaderText = "Số Tiết Thực Tế";
                    dgvThongKe.Columns["SoTietPhanCong"].HeaderText = "Số Tiết Phân Công";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thống kê tiết: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (selectedGiaoVienID == -1)
            {
                MessageBox.Show("Vui lòng chọn giáo viên trước khi cập nhật!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadTKBForGiaoVien(selectedGiaoVienID);
            LoadThongKeTiet(selectedGiaoVienID);
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chkHienThiLop_CheckedChanged(object sender, EventArgs e)
        {
            hienThiMonHoc = chkHienThiLop.Checked;
            
            // Reload TKB nếu đã có giáo viên được chọn
            if (selectedGiaoVienID != -1)
            {
                LoadTKBForGiaoVien(selectedGiaoVienID);
            }
        }
    }
}
