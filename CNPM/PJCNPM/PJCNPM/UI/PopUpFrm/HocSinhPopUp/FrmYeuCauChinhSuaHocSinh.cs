using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PJCNPM.UI.PopUpFrm.HocSinhPopUp
{
    public partial class FrmYeuCauChinhSuaHocSinh : Form
    {
        private dynamic hocSinhHienTai;

        public FrmYeuCauChinhSuaHocSinh(dynamic hocSinh)
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

            txtHoTen.Text = Convert.ToString(hocSinhHienTai.HoTen);
            txtDanToc.Text = Convert.ToString(hocSinhHienTai.DanToc);
            txtTonGiao.Text = Convert.ToString(hocSinhHienTai.TonGiao);
            txtQueQuan.Text = Convert.ToString(hocSinhHienTai.QueQuan);

            if (hocSinhHienTai.NgaySinh is DateTime date)
                dtNgaySinh.Value = date;
            else if (DateTime.TryParse(Convert.ToString(hocSinhHienTai.NgaySinh), out DateTime parsed))
                dtNgaySinh.Value = parsed;

            bool isNam = hocSinhHienTai.GioiTinh is bool b && b;
            chkNam.Checked = isNam;
            chkNu.Checked = !isNam;
        }

        private void BtnGui_Click(object sender, EventArgs e)
        {
            string gioiTinhText = chkNam.Checked ? "Nam" : "Nữ";
            MessageBox.Show(
                $"Yêu cầu chỉnh sửa đã được gửi!\n\n" +
                $"Họ tên: {txtHoTen.Text}\n" +
                $"Ngày sinh: {dtNgaySinh.Value:dd/MM/yyyy}\n" +
                $"Giới tính: {gioiTinhText}\n" +
                $"Dân tộc: {txtDanToc.Text}\n" +
                $"Tôn giáo: {txtTonGiao.Text}\n" +
                $"Quê quán: {txtQueQuan.Text}",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
