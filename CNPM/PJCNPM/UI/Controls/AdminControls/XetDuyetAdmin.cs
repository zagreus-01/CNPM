using System;
using System.Data;
using System.Windows.Forms;
using PJCNPM.BLL.Admin;
using PJCNPM.UI.PopUpFrm.AdminPopUp;

namespace PJCNPM.UI.Controls.AdminControls
{
    public partial class XetDuyetAdmin : UserControl
    {
        private readonly XetDuyetBLL bll = new XetDuyetBLL();

        public XetDuyetAdmin()
        {
            InitializeComponent();
            cboLoaiNguoiGui.SelectedIndex = 0;
            LoadBangYeuCau("Học sinh");
        }

        private void LoadBangYeuCau(string loai)
        {
            try
            {
                DataTable dt = bll.LayBangYeuCau(loai);
                dgvYeuCau.DataSource = dt;
                dgvYeuCau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvYeuCau.ReadOnly = true;
                dgvYeuCau.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi tải dữ liệu: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboLoaiNguoiGui_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBangYeuCau(cboLoaiNguoiGui.SelectedItem.ToString());
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvYeuCau.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một yêu cầu để xem chi tiết.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🧱 Lấy ID từ dòng đang chọn
            int id = Convert.ToInt32(dgvYeuCau.CurrentRow.Cells[0].Value);

            // 🧭 Lấy loại (Học sinh / Giáo viên)
            string loai = cboLoaiNguoiGui.Text;

            // 🔍 Mở form chi tiết, truyền ID & loại
            using (var frm = new FrmChiTietChinhSua(loai, id))
            {
                frm.ShowDialog();
            }
        }


        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (dgvYeuCau.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvYeuCau.CurrentRow.Cells[0].Value);
            string loai = cboLoaiNguoiGui.Text;

            if (bll.CapNhatTrangThai(loai, id, "Đã duyệt"))
            {
                MessageBox.Show("✅ Đã duyệt và gửi thông báo cho người yêu cầu.",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBangYeuCau(loai);
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            if (dgvYeuCau.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvYeuCau.CurrentRow.Cells[0].Value);
            string loai = cboLoaiNguoiGui.Text;

            if (bll.CapNhatTrangThai(loai, id, "Từ chối"))
            {
                MessageBox.Show("❌ Đã từ chối và gửi thông báo cho người yêu cầu.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBangYeuCau(loai);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadBangYeuCau(cboLoaiNguoiGui.Text);
        }
    }
}
