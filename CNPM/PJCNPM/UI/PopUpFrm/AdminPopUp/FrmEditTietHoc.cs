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

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    public partial class FrmEditTietHoc : Form
    {
        private ThoiKhoaBieuBLL tkbBLL;
        private int lopHocID;
        private int thu;
        private int tiet;
        private List<GiaoVien> danhSachGiaoVien;
        private List<MonHoc> danhSachMonHoc;

        public FrmEditTietHoc(int lopHocID, int thu, int tiet, List<GiaoVien> danhSachGiaoVien, List<MonHoc> danhSachMonHoc)
        {
            InitializeComponent();
            this.lopHocID = lopHocID;
            this.thu = thu;
            this.tiet = tiet;
            this.danhSachGiaoVien = danhSachGiaoVien;
            this.danhSachMonHoc = danhSachMonHoc;
            tkbBLL = new ThoiKhoaBieuBLL();
            
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Load danh sách môn học đã được phân công cho lớp này
            LoadMonHocDuocPhanCong();

            // Load danh sách giáo viên đã được phân công
            cboGiaoVien.DataSource = danhSachGiaoVien;
            cboGiaoVien.DisplayMember = "HoTen";
            cboGiaoVien.ValueMember = "GiaoVienID";
            cboGiaoVien.SelectedIndex = -1;

            // Hiển thị thông tin tiết học
            lblTietHoc.Text = $"Tiết {tiet} - {GetThuName(thu)}";

            // Load thông tin hiện tại nếu có
            LoadCurrentTietHoc();
        }

        private void LoadMonHocDuocPhanCong()
        {
            try
            {
                // Lấy danh sách phân công cho lớp này
                var phanCongList = tkbBLL.GetPhanCongByLop(lopHocID);
                
                if (phanCongList != null && phanCongList.Count > 0)
                {
                    // Lấy danh sách môn học đã được phân công
                    var monHocDuocPhanCong = phanCongList
                        .Select(pc => danhSachMonHoc.FirstOrDefault(m => m.MonHocID == pc.MonHocID))
                        .Where(m => m != null)
                        .Distinct()
                        .ToList();

                    // Thêm option "Trống" để có thể xóa tiết học
                    var monHocWithEmpty = new List<MonHoc>();
                    monHocWithEmpty.Add(new MonHoc { MonHocID = 0, TenMon = "-- Trống --" });
                    monHocWithEmpty.AddRange(monHocDuocPhanCong);

                    cboMonHoc.DataSource = monHocWithEmpty;
                    cboMonHoc.DisplayMember = "TenMon";
                    cboMonHoc.ValueMember = "MonHocID";
                    cboMonHoc.SelectedIndex = 0; // Mặc định chọn "Trống"
                    cboMonHoc.SelectedIndexChanged += CboMonHoc_SelectedIndexChanged;
                }
                else
                {
                    // Nếu không có phân công, chỉ hiển thị option "Trống"
                    var emptyList = new List<MonHoc>();
                    emptyList.Add(new MonHoc { MonHocID = 0, TenMon = "-- Trống --" });
                    
                    cboMonHoc.DataSource = emptyList;
                    cboMonHoc.DisplayMember = "TenMon";
                    cboMonHoc.ValueMember = "MonHocID";
                    cboMonHoc.SelectedIndex = 0;
                    cboMonHoc.SelectedIndexChanged += CboMonHoc_SelectedIndexChanged;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load môn học: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetThuName(int thu)
        {
            switch (thu)
            {
                case 1: return "Thứ 2";
                case 2: return "Thứ 3";
                case 3: return "Thứ 4";
                case 4: return "Thứ 5";
                case 5: return "Thứ 6";
                case 6: return "Thứ 7";
                case 7: return "Chủ nhật";
                default: return "";
            }
        }

        private void LoadCurrentTietHoc()
        {
            var tkbList = tkbBLL.GetTKBByLop(lopHocID);
            var currentTiet = tkbList.FirstOrDefault(t => t.Thu == thu && t.Tiet == tiet);

            if (currentTiet != null)
            {
                try
                {
                    if (currentTiet.MonHocID.HasValue && currentTiet.GiaoVienID.HasValue)
                    {
                        cboMonHoc.SelectedValue = currentTiet.MonHocID.Value;
                        cboGiaoVien.SelectedValue = currentTiet.GiaoVienID.Value;
                    }
                    else
                    {
                        // Nếu tiết học trống, chọn "-- Trống --"
                        cboMonHoc.SelectedValue = 0;
                        cboGiaoVien.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi load dữ liệu tiết học: {ex.Message}", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Nếu chưa có tiết học, mặc định chọn "-- Trống --"
                cboMonHoc.SelectedValue = 0;
                cboGiaoVien.SelectedIndex = -1;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int? monHocID = null;
                int? giaoVienID = null;

                // Xử lý môn học
                if (cboMonHoc.SelectedValue != null && cboMonHoc.SelectedValue != DBNull.Value)
                {
                    int selectedMonHocID = Convert.ToInt32(cboMonHoc.SelectedValue);
                    if (selectedMonHocID > 0) // Không phải "-- Trống --"
                    {
                        monHocID = selectedMonHocID;
                    }
                }

                // Xử lý giáo viên
                if (cboGiaoVien.SelectedValue != null && cboGiaoVien.SelectedValue != DBNull.Value)
                {
                    giaoVienID = Convert.ToInt32(cboGiaoVien.SelectedValue);
                }

                // Kiểm tra logic: nếu chọn môn học thì phải chọn giáo viên
                if (monHocID.HasValue && !giaoVienID.HasValue)
                {
                    MessageBox.Show("Vui lòng chọn giáo viên khi chọn môn học!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var tkb = new ThoiKhoaBieu
                {
                    LopHocID = lopHocID,
                    Thu = thu,
                    Tiet = tiet,
                    MonHocID = monHocID,
                    GiaoVienID = giaoVienID
                };

                if (tkbBLL.SaveTKB(tkb))
                {
                    string message = monHocID.HasValue ? 
                        "Lưu tiết học thành công!" : 
                        "Xóa tiết học thành công!";
                    MessageBox.Show(message, "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi lưu tiết học!", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboMonHoc.SelectedValue != null && cboMonHoc.SelectedValue != DBNull.Value)
                {
                    int selectedMonHocID = Convert.ToInt32(cboMonHoc.SelectedValue);
                    
                    if (selectedMonHocID > 0) // Có chọn môn học
                    {
                        // Lấy danh sách giáo viên được phân công dạy môn này cho lớp này
                        var phanCongList = tkbBLL.GetPhanCongByLop(lopHocID);
                        var giaoVienDuocPhanCong = phanCongList
                            .Where(pc => pc.MonHocID == selectedMonHocID)
                            .Select(pc => danhSachGiaoVien.FirstOrDefault(gv => gv.GiaoVienID == pc.GiaoVienID))
                            .Where(gv => gv != null)
                            .ToList();

                        // Cập nhật danh sách giáo viên
                        cboGiaoVien.DataSource = giaoVienDuocPhanCong;
                        cboGiaoVien.DisplayMember = "HoTen";
                        cboGiaoVien.ValueMember = "GiaoVienID";
                        cboGiaoVien.SelectedIndex = -1;
                    }
                    else // Chọn "-- Trống --"
                    {
                        // Reset danh sách giáo viên về tất cả giáo viên được phân công
                        cboGiaoVien.DataSource = danhSachGiaoVien;
                        cboGiaoVien.DisplayMember = "HoTen";
                        cboGiaoVien.ValueMember = "GiaoVienID";
                        cboGiaoVien.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật danh sách giáo viên: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaTiet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tiết học này?", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var tkb = new ThoiKhoaBieu
                {
                    LopHocID = lopHocID,
                    Thu = thu,
                    Tiet = tiet,
                    MonHocID = null,
                    GiaoVienID = null
                };

                if (tkbBLL.SaveTKB(tkb))
                {
                    MessageBox.Show("Xóa tiết học thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa tiết học!", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
