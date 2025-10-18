using System;
using System.Data;
using System.Windows.Forms;
using PJCNPM.BLL.Admin;

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    public partial class FrmChuyenLopAdmin : Form
    {
        private readonly ChuyenLopHocSinhBLL bll = new ChuyenLopHocSinhBLL();
        private int hocSinhID;
        private DataRow lopCu;

        public FrmChuyenLopAdmin(int hocSinhID)
        {
            InitializeComponent();
            this.hocSinhID = hocSinhID;
            this.Load += FrmChuyenLopAdmin_Load;
            cboLopMoi.SelectedIndexChanged += CheckRule;
            btnHuy.Click += (s, e) => Close();
        }

        private void FrmChuyenLopAdmin_Load(object sender, EventArgs e)
        {
            var (hs, lop) = bll.LayThongTinHienTai(hocSinhID);
            lopCu = lop;

            txtHocSinh.Text = $"[{hocSinhID}] {hs["HoTen"]}";
            txtLopCu.Text = lop != null ? lop["TenLop"].ToString() : "(Chưa có lớp)";

            cboLopMoi.DataSource = bll.LayDanhSachLopHoatDong();
            cboLopMoi.DisplayMember = "TenLop";
            cboLopMoi.ValueMember = "LopID";
        }

        private void CheckRule(object sender, EventArgs e)
        {
            if (cboLopMoi.SelectedItem == null) return;
            DataRow lopMoi = bll.LayLopTheoID(Convert.ToInt32(((DataRowView)cboLopMoi.SelectedItem)["LopID"]));
            string rule = bll.KiemTraQuyTac(lopCu, lopMoi);
            lblKetQua.Text = rule;

            if (rule.Contains("bắt buộc xóa điểm"))
            {
                chkXoaDiem.Checked = true;
                chkXoaDiem.Enabled = false;
            }
            else if (rule.Contains("Không thể chuyển"))
            {
                chkXoaDiem.Checked = false;
                chkXoaDiem.Enabled = false;
            }
            else
            {
                chkXoaDiem.Enabled = true;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cboLopMoi.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn lớp mới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int lopMoiID = Convert.ToInt32(((DataRowView)cboLopMoi.SelectedItem)["LopID"]);
            bool xoaDiem = chkXoaDiem.Checked;

            if (lblKetQua.Text.Contains("Không thể chuyển"))
            {
                MessageBox.Show("Không thể chuyển sang chính lớp hiện tại.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = bll.ChuyenLop(hocSinhID, lopMoiID, xoaDiem);
            if (ok)
            {
                MessageBox.Show("✅ Chuyển lớp thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("❌ Không thể chuyển lớp. Hãy kiểm tra dữ liệu hoặc ràng buộc khóa ngoại.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
