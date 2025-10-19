using PJCNPM.UI.Controls.GiaoVienControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PJCNPM.UI.MainFrm
{
    public partial class GiaoVien : Form
    {
        private bool isSidebarCollapsed = false;
        private string tenTaiKhoan;
        private int _giaoVienID;

        public GiaoVien(string tenTK)
        {
            InitializeComponent();
            this.tenTaiKhoan = tenTK;
            this.WindowState = FormWindowState.Maximized;

            GetGiaoVienIDFromTenTK();

            // Mặc định load Thông tin cá nhân khi khởi tạo
            LoadThongTinCaNhan();
        }

        private void GetGiaoVienIDFromTenTK()
        {
            if (string.IsNullOrEmpty(tenTaiKhoan)) return;
            try
            {
                var bll = new PJCNPM.BLL.GiaoVien.GiaoVienBLL();
                var info = bll.GetThongTinGiaoVienByTenTK(tenTaiKhoan);
                if (info != null)
                {
                    _giaoVienID = info.GiaoVienID;
                }
                else
                {
                    MessageBox.Show("Không thể xác định ID của giáo viên. Một số chức năng có thể không hoạt động.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnLogout.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nghiêm trọng khi lấy thông tin giáo viên: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebar.Width = isSidebarCollapsed ? 220 : 0;
            isSidebarCollapsed = !isSidebarCollapsed;
        }

        private void ResetSidebarButtons()
        {
            foreach (Control control in sidebar.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2Button btn && btn != btnLogout)
                {
                    btn.FillColor = Color.FromArgb(64, 64, 64);
                }
            }
        }

        private void LoadContent(UserControl control)
        {
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
        }

        private void HighlightButton(Guna.UI2.WinForms.Guna2Button button)
        {
            ResetSidebarButtons();
            button.FillColor = Color.FromArgb(0, 120, 215);
        }

        private void LoadThongTinCaNhan()
        {
            HighlightButton(btnThongTinCaNhan);
            var thongTinControl = new ThongTinGiaoVien(tenTaiKhoan);
            LoadContent(thongTinControl);
            lblTitle.Text = "TRANG GIÁO VIÊN - THÔNG TIN CÁ NHÂN";
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            LoadThongTinCaNhan();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            if (_giaoVienID == 0)
            {
                MessageBox.Show("Không thể mở chức năng do không xác định được mã giáo viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HighlightButton(btnThongBao);
            var thongBaoControl = new ThongBaoGiaoVien(_giaoVienID, this.tenTaiKhoan);
            LoadContent(thongBaoControl);
            lblTitle.Text = "TRANG GIÁO VIÊN - QUẢN LÝ THÔNG BÁO";
        }

        private void btnDiemSo_Click(object sender, EventArgs e)
        {
            if (_giaoVienID == 0)
            {
                MessageBox.Show("Không thể mở chức năng do không xác định được mã giáo viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HighlightButton(btnNhapDiem);
            var nhapDiemControl = new NhapDiemGiaoVien(_giaoVienID);
            LoadContent(nhapDiemControl);
            lblTitle.Text = "TRANG GIÁO VIÊN - NHẬP ĐIỂM";
        }
        

        private void btnChinhSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            HighlightButton(btnChinhSuaTaiKhoan);
            var taiKhoanControl = new TaiKhoanGiaoVien(this.tenTaiKhoan);
            LoadContent(taiKhoanControl);
            lblTitle.Text = "TRANG GIÁO VIÊN - TÀI KHOẢN";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?",
                "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDKPhong_Click(object sender, EventArgs e)
        {
            if (_giaoVienID == 0)
            {
                MessageBox.Show("Không thể mở chức năng do không xác định được mã giáo viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HighlightButton(btnDKPhong); 
            var dangKyControl = new DangKyPhongHoc(_giaoVienID);
            LoadContent(dangKyControl);
            lblTitle.Text = "TRANG GIÁO VIÊN - ĐĂNG KÝ PHÒNG HỌC";
        }

        private void btnThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            if (_giaoVienID == 0)
            {
                MessageBox.Show("Không thể mở chức năng do không xác định được mã giáo viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HighlightButton(btnThoiKhoaBieu);
            var tkbControl = new PJCNPM.UI.Controls.GiaoVienControls.ThoiKhoaBieuGiaoVien(_giaoVienID);
            LoadContent(tkbControl);
            lblTitle.Text = "TRANG GIÁO VIÊN - THỜI KHÓA BIỂU";
        }
    }
}