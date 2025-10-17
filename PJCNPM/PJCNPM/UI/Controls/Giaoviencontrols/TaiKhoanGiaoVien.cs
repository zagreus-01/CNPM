using System;
using System.Windows.Forms;
using PJCNPM.UI.PopUpFrm.GiaoVienPopUp;

namespace PJCNPM.UI.Controls.GiaoVienControls
{
    public partial class TaiKhoanGiaoVien : UserControl
    {
        private readonly string _tenTK;

        public TaiKhoanGiaoVien(string tenTK)
        {
            InitializeComponent();
            _tenTK = tenTK;
            LoadThongTinTaiKhoan();
        }

        private void LoadThongTinTaiKhoan()
        {
            lblTenDangNhapValue.Text = _tenTK;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmDoiMatKhauGiaoVien(_tenTK))
            {
                frm.ShowDialog();
            }
        }

        private void lblTenDangNhapValue_Click(object sender, EventArgs e)
        {

        }
    }
}