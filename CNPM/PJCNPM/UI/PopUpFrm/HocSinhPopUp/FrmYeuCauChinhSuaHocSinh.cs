using System;
using System.Windows.Forms;
using PJCNPM.BLL.HocSinh;

namespace PJCNPM.UI.PopUpFrm.HocSinhPopUp
{
    public partial class FrmYeuCauChinhSuaHocSinh : Form
    {
        private readonly HocSinhDTO hocSinhHienTai;

        public FrmYeuCauChinhSuaHocSinh(HocSinhDTO hocSinh)
        {
            hocSinhHienTai = hocSinh;
            InitializeComponent();
            InitEvents();
            GanThongTinCu();
        }

        private void InitEvents()
        {
            chkNam.CheckedChanged += GioiTinh_CheckedChanged;
            chkNu.CheckedChanged += GioiTinh_CheckedChanged;
            btnGui.Click += BtnGui_Click;
            btnHuy.Click += (s, e) => this.Close();
        }

        private void GioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is Guna.UI2.WinForms.Guna2CheckBox changed)) return;
            if (changed.Checked)
            {
                if (changed == chkNam) chkNu.Checked = false;
                else chkNam.Checked = false;
            }
        }

        private void GanThongTinCu()
        {
            if (hocSinhHienTai == null) return;

            txtHoTen.Text = hocSinhHienTai.HoTen;
            txtDanToc.Text = hocSinhHienTai.DanToc;
            txtTonGiao.Text = hocSinhHienTai.TonGiao;
            txtQueQuan.Text = hocSinhHienTai.QueQuan;
            dtNgaySinh.Value = hocSinhHienTai.NgaySinh;

            if (hocSinhHienTai.GioiTinh=="Nam")
            {
                chkNam.Checked = true;
                chkNu.Checked = false;
            }
            else
            {
                chkNam.Checked = false;
                chkNu.Checked = true;
            }
        }

        private void BtnGui_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy giới tính dạng chuỗi
                string gioiTinhMoi = chkNam.Checked ? "Nam" : "Nữ";

                var bll = new ThongTinHocSinhBLL();

                bool ok = bll.GuiYeuCauChinhSua(
                    hocSinhHienTai.HocSinhID,
                    txtHoTen.Text.Trim(),
                    dtNgaySinh.Value,
                    gioiTinhMoi,
                    txtDanToc.Text.Trim(),
                    txtTonGiao.Text.Trim(),
                    txtQueQuan.Text.Trim()
                );

                if (ok)
                {
                    MessageBox.Show("✅ Yêu cầu chỉnh sửa đã được gửi đến Ban quản trị.\nVui lòng chờ duyệt!",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể gửi yêu cầu, vui lòng thử lại.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi yêu cầu: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
