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
using PJCNPM.UI.PopUpFrm.AdminPopUp;

namespace PJCNPM.UI.Controls.AdminControls
{
    public partial class TKBTheoLopControl : UserControl
    {
        private ThoiKhoaBieuBLL tkbBLL;
        private List<Lop> danhSachLop;
        private List<GiaoVien> danhSachGiaoVien;
        private List<MonHoc> danhSachMonHoc;
        private int selectedLopID = -1;
        private DataTable tkbDataTable;
        private bool hienThiGiaoVien = true; // Mặc định hiển thị tên giáo viên

        public TKBTheoLopControl()
        {
            InitializeComponent();
            tkbBLL = new ThoiKhoaBieuBLL();
            InitializeData();
            SetupDataGridView();
        }

        private void InitializeData()
        {
            danhSachLop = tkbBLL.GetDanhSachLopActive();
            danhSachGiaoVien = tkbBLL.GetDanhSachGiaoVien();
            danhSachMonHoc = tkbBLL.GetDanhSachMonHoc();

            // Load danh sách lớp vào ComboBox
            cboLopHoc.DataSource = danhSachLop;
            cboLopHoc.DisplayMember = "TenLop";
            cboLopHoc.ValueMember = "LopID";
            cboLopHoc.SelectedIndex = -1;

            // Thiết lập checkbox mặc định
            chkHienThiGiaoVien.Checked = hienThiGiaoVien;
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

        private void DgvTKB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedLopID == -1) return;

            if (e.RowIndex >= 0 && e.ColumnIndex > 0) // Bỏ qua cột Tiết
            {
                int tiet = e.RowIndex + 1;
                int thu = e.ColumnIndex + 1; // Map column index to thu: 1->2, 2->3, ..., 6->7

                // Không cho chỉnh sửa tiết 1,2 thứ 2 (Chào cờ, SHCN)
                if (thu == 2 && (tiet == 1 || tiet == 2))
                {
                    MessageBox.Show("Tiết 1 thứ 2 (Chào cờ) và tiết 2 thứ 2 (SHCN) không thể chỉnh sửa!", 
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Kiểm tra xem có phân công nào cho lớp này không
                var phanCongList = tkbBLL.GetPhanCongByLop(selectedLopID);
                if (phanCongList == null || phanCongList.Count == 0)
                {
                    MessageBox.Show("Chưa có môn học nào được phân công cho lớp này!\nVui lòng phân công môn học trước khi chỉnh sửa thời khóa biểu.", 
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy danh sách giáo viên được phân công (chỉ những môn đã phân công)
                var phanCongGiaoVien = tkbBLL.GetGiaoVienDuocPhanCong(selectedLopID);
                if (phanCongGiaoVien == null || phanCongGiaoVien.Count == 0)
                {
                    MessageBox.Show("Chưa có giáo viên nào được phân công dạy lớp này!\nVui lòng phân công giáo viên trước khi chỉnh sửa thời khóa biểu.", 
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mở form chỉnh sửa tiết học (chỉ cho phép chọn môn và giáo viên đã được phân công)
                using (var editForm = new FrmEditTietHoc(selectedLopID, thu, tiet, phanCongGiaoVien, danhSachMonHoc))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadTKBForLop(selectedLopID);
                        LoadThongKeGiaoVien(selectedLopID);
                    }
                }
            }
        }

        private void cboLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLopHoc.SelectedItem != null)
            {
                try
                {
                    var selectedLop = cboLopHoc.SelectedItem as Lop;
                    if (selectedLop != null)
                    {
                        selectedLopID = selectedLop.LopID;
                        LoadTKBForLop(selectedLopID);
                        LoadThongKeGiaoVien(selectedLopID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi chọn lớp: {ex.Message}", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                MessageBox.Show($"Lỗi khi tải TKB lớp: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadThongKeGiaoVien(int lopID)
        {
            try
            {
                var thongKeData = tkbBLL.GetThongKeGiaoVienByLop(lopID);
                dgvThongKe.DataSource = thongKeData;
                
                // Đặt tên cột cho DataGridView
                if (dgvThongKe.Columns.Count > 0)
                {
                    dgvThongKe.Columns["GiaoVienID"].Visible = false;
                    dgvThongKe.Columns["HoTen"].HeaderText = "Tên Giáo Viên";
                    dgvThongKe.Columns["TenMonHoc"].HeaderText = "Môn Học";
                    dgvThongKe.Columns["SoTietThucTe"].HeaderText = "Số Tiết Thực Tế";
                    dgvThongKe.Columns["SoTietPhanCong"].HeaderText = "Số Tiết Phân Công";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thống kê giáo viên: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaoTKB_Click(object sender, EventArgs e)
        {
            if (selectedLopID == -1)
            {
                MessageBox.Show("Vui lòng chọn lớp học trước khi tạo TKB!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem lớp có đang hoạt động không
            if (!tkbBLL.IsLopActive(selectedLopID))
            {
                MessageBox.Show("Không thể tạo TKB cho lớp đã kết thúc!\nChỉ có thể tạo TKB cho lớp đang hoạt động.", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem có giáo viên được phân công không
            if (!tkbBLL.CanCreateTKBForLop(selectedLopID))
            {
                MessageBox.Show("Chưa có giáo viên nào được phân công dạy lớp này!\nVui lòng phân công giáo viên trước khi tạo thời khóa biểu.", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn tạo TKB cho lớp này?", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    tkbBLL.AutoArrangeTKB(selectedLopID);
                    MessageBox.Show("Tạo TKB thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTKBForLop(selectedLopID);
                    LoadThongKeGiaoVien(selectedLopID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tạo TKB: {ex.Message}", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTaoTKBAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn tạo TKB cho tất cả lớp đang hoạt động?\nHệ thống sẽ tự động tạo TKB cho tất cả lớp đang hoạt động và đã có phân công giáo viên.", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var danhSachLop = tkbBLL.GetDanhSachLopActive();
                    int successCount = 0;
                    int failCount = 0;
                    
                    foreach (var lop in danhSachLop)
                    {
                        if (tkbBLL.CanCreateTKBForLop(lop.LopID))
                        {
                            try
                            {
                                tkbBLL.AutoArrangeTKB(lop.LopID);
                                successCount++;
                            }
                            catch (Exception ex)
                            {
                                failCount++;
                                // Log chi tiết lỗi cho từng lớp nếu cần
                                System.Diagnostics.Debug.WriteLine($"Lỗi tạo TKB cho lớp {lop.TenLop}: {ex.Message}");
                            }
                        }
                        else
                        {
                            failCount++;
                        }
                    }
                    
                    string message = $"Hoàn thành tạo TKB:\n- Thành công: {successCount} lớp\n- Thất bại: {failCount} lớp";
                    MessageBox.Show(message, "Kết quả", MessageBoxButtons.OK, 
                        successCount > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                    
                    if (selectedLopID != -1)
                    {
                        LoadTKBForLop(selectedLopID);
                        LoadThongKeGiaoVien(selectedLopID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tạo TKB cho tất cả lớp: {ex.Message}", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chkHienThiGiaoVien_CheckedChanged(object sender, EventArgs e)
        {
            hienThiGiaoVien = chkHienThiGiaoVien.Checked;
            
            // Reload TKB nếu đã có lớp được chọn
            if (selectedLopID != -1)
            {
                LoadTKBForLop(selectedLopID);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
