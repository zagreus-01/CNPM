using System;
using System.Data;
using System.Windows.Forms;
using PJCNPM.BLL.Admin;

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    public partial class FrmThongBaoAdmin : Form
    {
        public int LoaiNguoiNhanInt { get; private set; }
        public string NguoiNhanID { get; private set; }
        public string TieuDe { get; private set; }
        public string NoiDung { get; private set; }

        private readonly NguoiNhanBLL bll = new NguoiNhanBLL();

        public FrmThongBaoAdmin()
        {
            InitializeComponent();
        }

        private void FrmThongBaoAdmin_Load(object sender, EventArgs e)
        {
            cboLoaiNguoiNhan.Items.AddRange(new object[]
            {
                "Tất cả học sinh",
                "Lớp",
                "Học sinh",
                "Giáo viên"
            });
            cboLoaiNguoiNhan.SelectedIndexChanged += cboLoaiNguoiNhan_SelectedIndexChanged;
            cboLoaiNguoiNhan.SelectedIndex = 0;
        }

        // 🔹 Khi chọn loại người nhận
        private void cboLoaiNguoiNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboNguoiNhan.Items.Clear();
            cboNguoiNhan.Enabled = true;

            string loai = cboLoaiNguoiNhan.SelectedItem.ToString();

            if (loai == "Học sinh")
            {
                DataTable dt = bll.LayHocSinh();
                foreach (DataRow r in dt.Rows)
                    cboNguoiNhan.Items.Add($"{r["Ma"]} - {r["Ten"]}");
            }
            else if (loai == "Giáo viên")
            {
                DataTable dt = bll.LayGiaoVien();
                foreach (DataRow r in dt.Rows)
                    cboNguoiNhan.Items.Add($"{r["Ma"]} - {r["Ten"]}");
            }
            else if (loai == "Lớp")
            {
                DataTable dt = bll.LayLop();
                foreach (DataRow r in dt.Rows)
                    cboNguoiNhan.Items.Add($"{r["Ma"]} - {r["Ten"]}");
            }
            else // Tất cả học sinh
            {
                cboNguoiNhan.Enabled = false;
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTieuDe.Text))
            {
                MessageBox.Show("Vui lòng nhập tiêu đề.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string loai = cboLoaiNguoiNhan.SelectedItem.ToString();

            // 🔹 Gán loại người nhận int theo DB
            if (loai == "Tất cả học sinh") LoaiNguoiNhanInt = -1;
            else if (loai == "Lớp") LoaiNguoiNhanInt = 1;
            else if (loai == "Học sinh") LoaiNguoiNhanInt = 2;
            else if (loai == "Giáo viên") LoaiNguoiNhanInt = 3;
            else LoaiNguoiNhanInt = 0;

            if (LoaiNguoiNhanInt != -1 && cboNguoiNhan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn người nhận cụ thể.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NguoiNhanID = LoaiNguoiNhanInt == -1 ? "ALL"
                : cboNguoiNhan.Text.Split('-')[0].Trim();

            TieuDe = txtTieuDe.Text.Trim();
            NoiDung = txtNoiDung.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
