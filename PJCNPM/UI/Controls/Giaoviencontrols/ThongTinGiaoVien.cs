using System;
using System.Drawing;
using System.Windows.Forms;
using PJCNPM.BLL.GiaoVien;
using PJCNPM.UI.PopUpFrm.GiaoVienPopUp;

namespace PJCNPM.UI.Controls.GiaoVienControls
{
    public partial class ThongTinGiaoVien : UserControl
    {
        private readonly string _currentTenTK;
        private int? _currentGiaoVienID = null;

        private readonly GiaoVienBLL _bllThongTin = new GiaoVienBLL();
        private readonly YeuCauChinhSua _bllYeuCau = new YeuCauChinhSua();

        public ThongTinGiaoVien(string tenTK)
        {
            InitializeComponent();
            _currentTenTK = tenTK;
            LoadThongTin();
        }

        public void LoadThongTin()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_currentTenTK))
                {
                    MessageBox.Show("Không xác định được tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var giaoVienInfo = _bllThongTin.GetThongTinGiaoVienByTenTK(_currentTenTK);
                if (giaoVienInfo == null)
                {
                    ClearView();
                    MessageBox.Show("Không tìm thấy thông tin giáo viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _currentGiaoVienID = giaoVienInfo.GiaoVienID;

                // Sửa đổi: Cập nhật hiển thị thông tin
                lblHoTen.Text = $"<b>Họ tên:</b> {giaoVienInfo.HoTen ?? "Chưa cập nhật"}";
                lblGioiTinh.Text = $"<b>Giới tính:</b> {(giaoVienInfo.GioiTinh.HasValue ? (giaoVienInfo.GioiTinh.Value ? "Nữ" : "Nam") : "Chưa cập nhật")}";
                lblCCCD.Text = $"<b>CCCD:</b> {giaoVienInfo.CCCD ?? "Chưa cập nhật"}";
                lblEmail.Text = $"<b>Email:</b> {giaoVienInfo.Email ?? "Chưa cập nhật"}";
                lblDienThoai.Text = $"<b>Điện thoại:</b> {giaoVienInfo.DienThoai ?? "Chưa cập nhật"}";
                lblDanToc.Text = $"<b>Dân tộc:</b> {giaoVienInfo.DanToc ?? "Chưa cập nhật"}";
                lblTonGiao.Text = $"<b>Tôn giáo:</b> {giaoVienInfo.TonGiao ?? "Chưa cập nhật"}";
                lblLaDangVien.Text = $"<b>Là Đảng viên:</b> {(giaoVienInfo.LaDangVien.HasValue ? (giaoVienInfo.LaDangVien.Value ? "Có" : "Không") : "Chưa cập nhật")}";
                lblNoiThuongTru.Text = $"<b>Nơi thường trú:</b> {giaoVienInfo.NoiThuongTru ?? "Chưa cập nhật"}";
                lblQueQuan.Text = $"<b>Quê quán:</b> {giaoVienInfo.QueQuan ?? "Chưa cập nhật"}";
                lblNgaySinh.Text = $"<b>Ngày sinh:</b> {(giaoVienInfo.NgaySinh.HasValue ? giaoVienInfo.NgaySinh.Value.ToString("dd/MM/yyyy") : "Chưa cập nhật")}";
                lblTenTK.Text = $"<b>Tên tài khoản:</b> {giaoVienInfo.TenTK ?? ""}";

                // Kiểm tra trạng thái yêu cầu chỉnh sửa
                var yc = _bllYeuCau.GetYeuCauChinhSuaByGiaoVienID(giaoVienInfo.GiaoVienID);
                if (yc == null || string.IsNullOrWhiteSpace(yc.TrangThaiYeuCau))
                {
                    lblTrangThaiYeuCau.Text = "Trạng thái yêu cầu: Chưa có";
                    lblTrangThaiYeuCau.ForeColor = Color.Gray;
                }
                else
                {
                    lblTrangThaiYeuCau.Text = "Trạng thái yêu cầu: " + yc.TrangThaiYeuCau;
                    switch ((yc.TrangThaiYeuCau ?? "").Trim().ToLower())
                    {
                        case "chờ duyệt":
                            lblTrangThaiYeuCau.ForeColor = Color.Orange;
                            break;
                        case "đã duyệt":
                            lblTrangThaiYeuCau.ForeColor = Color.Green;
                            break;
                        case "từ chối":
                            lblTrangThaiYeuCau.ForeColor = Color.Red;
                            break;
                        default:
                            lblTrangThaiYeuCau.ForeColor = Color.Gray;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearView();
            }
        }

        private void ClearView()
        {
            lblHoTen.Text = "<b>Họ tên:</b> ";
            lblGioiTinh.Text = "<b>Giới tính:</b> ";
            lblCCCD.Text = "<b>CCCD:</b> ";
            lblEmail.Text = "<b>Email:</b> ";
            lblDienThoai.Text = "<b>Điện thoại:</b> ";
            lblDanToc.Text = "<b>Dân tộc:</b> ";
            lblTonGiao.Text = "<b>Tôn giáo:</b> ";
            lblLaDangVien.Text = "<b>Là Đảng viên:</b> "; // Sửa đổi
            lblNoiThuongTru.Text = "<b>Nơi thường trú:</b> ";
            lblQueQuan.Text = "<b>Quê quán:</b> ";
            lblNgaySinh.Text = "<b>Ngày sinh:</b> ";
            lblTenTK.Text = "<b>Tên tài khoản:</b> ";
            lblTrangThaiYeuCau.Text = "Trạng thái yêu cầu: Chưa có";
            lblTrangThaiYeuCau.ForeColor = Color.Gray;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        private void btnYeuCauChinhSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_currentGiaoVienID.HasValue)
                {
                    MessageBox.Show("Không xác định được thông tin giáo viên để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var frm = new FrmYeuCauChinhSuaGiaoVien(_currentGiaoVienID.Value))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        // Tải lại thông tin sau khi lưu yêu cầu thành công
                        LoadThongTin();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form yêu cầu chỉnh sửa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}