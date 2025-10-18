using System;
using System.Windows.Forms;
using PJCNPM.BLL.Admin;

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    public partial class FrmChuyenToanBoLop : Form
    {
        private readonly ChuyenToanBoLopBLL bll = new ChuyenToanBoLopBLL();
        private readonly int _lopCuID;
        private readonly string _tenLopCu;

        public FrmChuyenToanBoLop(int lopCuID, string tenLopCu)
        {
            InitializeComponent();
            _lopCuID = lopCuID;
            _tenLopCu = tenLopCu;
            this.Load += new System.EventHandler(this.FrmChuyenToanBoLop_Load);

        }

        private void FrmChuyenToanBoLop_Load(object sender, EventArgs e)
        {
            txtLopCu.Text = _tenLopCu;
            txtHocSinh.Text = $"Toàn bộ học sinh lớp {_tenLopCu}";

            cboLopMoi.DisplayMember = "TenLop";
            cboLopMoi.ValueMember = "LopID";
            cboLopMoi.DataSource = bll.LayDanhSachLopHoatDong();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cboLopMoi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int lopMoiID = Convert.ToInt32(cboLopMoi.SelectedValue);
            bool xoaDiem = chkXoaDiem.Checked;

            string msg = xoaDiem
                ? $"Chuyển toàn bộ học sinh lớp '{_tenLopCu}' sang '{cboLopMoi.Text}' và XÓA điểm lớp cũ?"
                : $"Chuyển toàn bộ học sinh lớp '{_tenLopCu}' sang '{cboLopMoi.Text}' và GIỮ điểm lớp cũ?";

            if (MessageBox.Show(msg, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool ok = bll.ChuyenToanBoHocSinh(_lopCuID, lopMoiID, xoaDiem);
                    if (ok)
                    {
                        MessageBox.Show("✅ Đã chuyển toàn bộ học sinh sang lớp mới!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
