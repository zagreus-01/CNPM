using PJCNPM.BLL.GiaoVien;
using PJCNPM.DAL;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PJCNPM.UI.PopUpFrm.GiaoVienPopUp
{
    public partial class FrmYeuCauChinhSuaGiaoVien : Form
    {
        private readonly int _giaoVienID;
        // Giữ nguyên tên lớp BLL và cách gọi như logic gốc
        private readonly GiaoVienBLL _bllThongTin;
        private readonly YeuCauChinhSua _bllYeuCau;

        public FrmYeuCauChinhSuaGiaoVien(int giaoVienID)
        {
            InitializeComponent();
            _giaoVienID = giaoVienID;
            _bllThongTin = new GiaoVienBLL();
            _bllYeuCau = new YeuCauChinhSua();
        }

        private void FrmYeuCauChinhSuaGiaoVien_Load(object sender, EventArgs e)
        {
            try
            {
                // Ưu tiên load thông tin từ bảng yêu cầu chỉnh sửa nếu có
                var yc = _bllYeuCau.GetYeuCauChinhSuaByGiaoVienID(_giaoVienID);
                if (yc != null)
                {
                    BindFromYeuCau(yc);
                    SetTrangThai(yc.TrangThaiYeuCau);
                }
                else
                {
                    // Nếu không, load thông tin gốc từ bảng GiaoVien
                    // Giữ nguyên phương thức GetGiaoVienInfo() như logic gốc
                    var info = GetGiaoVienInfo();
                    if (info == null)
                    {
                        MessageBox.Show("Không tìm thấy thông tin gốc của giáo viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }
                    BindFromGiaoVien(info);
                    SetTrangThai("Chưa có yêu cầu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Giữ nguyên phương thức này từ code gốc của bạn
        private GiaoVienBLL.GiaoVienInfo GetGiaoVienInfo()
        {
            try
            {
                // 🔹 Không nên gọi DBConnection trực tiếp trong Form (vi phạm nguyên tắc 3 tầng)
                // Hãy tạo BLL riêng để lấy thông tin giáo viên
                var gvBll = new GiaoVienBLL();

                // 🔹 Dùng 1 truy vấn nhỏ để lấy TenTK của giáo viên theo ID
                string sql = "SELECT TenTK FROM dbo.GiaoVien WHERE GiaoVienID = @ID";
                var param = new System.Data.SqlClient.SqlParameter("@ID", _giaoVienID);

                var db = new DBConnection();
                DataTable dt = db.GetData(sql, new[] { param });

                if (dt == null || dt.Rows.Count == 0)
                    return null;

                string tenTK = dt.Rows[0]["TenTK"]?.ToString()?.Trim();
                if (string.IsNullOrEmpty(tenTK))
                    return null;

                // 🔹 Gọi sang BLL đã có để lấy thông tin chi tiết
                return gvBll.GetThongTinGiaoVienByTenTK(tenTK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi lấy thông tin giáo viên: " + ex.Message,
                    "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void SetTrangThai(string trangThai)
        {
            string st = (trangThai ?? "Chưa có yêu cầu");
            lblTrangThai.Text = "Trạng thái: " + st;
            switch (st.Trim().ToLower())
            {
                case "chờ duyệt":
                    lblTrangThai.ForeColor = Color.Orange;
                    break;
                case "đã duyệt":
                    lblTrangThai.ForeColor = Color.Green;
                    btnLuu.Enabled = false; // Không cho lưu khi đã được duyệt
                    btnLuu.Text = "Đã Duyệt";
                    break;
                case "từ chối":
                    lblTrangThai.ForeColor = Color.Red;
                    break;
                default:
                    lblTrangThai.ForeColor = Color.Gray;
                    break;
            }
        }

        private void BindFromYeuCau(YeuCauChinhSua.YeuCauChinhSuaInfo yc)
        {
            txtHoTen.Text = yc.HoTen ?? "";
            cboGioiTinh.SelectedIndex = yc.GioiTinh.HasValue ? (yc.GioiTinh.Value ? 1 : 0) : 0; // 1: Nữ, 0: Nam
            dtpNgaySinh.Value = yc.NgaySinh ?? DateTime.Now.AddYears(-25);
            txtCCCD.Text = yc.CCCD ?? "";
            txtEmail.Text = yc.Email ?? "";
            txtDienThoai.Text = yc.DienThoai ?? "";
            txtDanToc.Text = yc.DanToc ?? "";
            txtTonGiao.Text = yc.TonGiao ?? "";
            txtQueQuan.Text = yc.QueQuan ?? "";
            txtNoiThuongTru.Text = yc.NoiThuongTru ?? "";
            // Đã cập nhật cho phù hợp với database mới
            chkLaDangVien.Checked = yc.LaDangVien ?? false;
        }

        private void BindFromGiaoVien(GiaoVienBLL.GiaoVienInfo info)
        {
            txtHoTen.Text = info.HoTen ?? "";
            cboGioiTinh.SelectedIndex = info.GioiTinh.HasValue ? (info.GioiTinh.Value ? 1 : 0) : 0;
            dtpNgaySinh.Value = info.NgaySinh ?? DateTime.Now.AddYears(-25);
            txtCCCD.Text = info.CCCD ?? "";
            txtEmail.Text = info.Email ?? "";
            txtDienThoai.Text = info.DienThoai ?? "";
            txtDanToc.Text = info.DanToc ?? "";
            txtTonGiao.Text = info.TonGiao ?? "";
            txtQueQuan.Text = info.QueQuan ?? "";
            txtNoiThuongTru.Text = info.NoiThuongTru ?? "";
            // Đã cập nhật cho phù hợp với database mới
            chkLaDangVien.Checked = info.LaDangVien ?? false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm()) return;

                var model = new YeuCauChinhSua.YeuCauChinhSuaInfo
                {
                    GiaoVienID = _giaoVienID,
                    HoTen = txtHoTen.Text.Trim(),
                    GioiTinh = cboGioiTinh.SelectedIndex == 1, // 1: Nữ
                    NgaySinh = dtpNgaySinh.Value,
                    CCCD = txtCCCD.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    DienThoai = txtDienThoai.Text.Trim(),
                    DanToc = txtDanToc.Text.Trim(),
                    TonGiao = txtTonGiao.Text.Trim(),
                    QueQuan = txtQueQuan.Text.Trim(),
                    NoiThuongTru = txtNoiThuongTru.Text.Trim(),
                    // Đã cập nhật cho phù hợp với database mới
                    LaDangVien = chkLaDangVien.Checked,
                    TrangThaiYeuCau = "Chờ duyệt" // Luôn set là "Chờ duyệt" khi lưu
                };

                btnLuu.Enabled = false;
                btnLuu.Text = "Đang lưu...";

                bool ok = _bllYeuCau.LuuYeuCauChinhSua(model);
                if (ok)
                {
                    MessageBox.Show("Đã gửi yêu cầu chỉnh sửa thành công. Vui lòng chờ quản trị viên duyệt!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể lưu yêu cầu. Đã có lỗi xảy ra, vui lòng thử lại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nghiêm trọng khi lưu yêu cầu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLuu.Enabled = true;
                btnLuu.Text = "Gửi Yêu Cầu";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên là trường bắt buộc.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Định dạng Email không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtDienThoai.Text) && !Regex.IsMatch(txtDienThoai.Text, @"^(0\d{9,10})$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Phải bắt đầu bằng 0 và có 10-11 chữ số.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtCCCD.Text) && !Regex.IsMatch(txtCCCD.Text.Trim(), @"^\d{12}$"))
            {
                MessageBox.Show("CCCD phải là 12 chữ số.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCCCD.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch { return false; }
        }
    }
}