using PJCNPM.BLL.Admin;
using System;
using System.Data;
using System.Windows.Data;
using System.Windows.Forms;

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    public partial class FrmHocSinhXemAdmin : Form
    {
        private readonly HocSinhXemBLL bll = new HocSinhXemBLL();
        private readonly int hocSinhID;

        public FrmHocSinhXemAdmin(int hocSinhID)
        {
            InitializeComponent();
            this.hocSinhID = hocSinhID;
            this.Load += FrmHocSinhXemAdmin_Load;
            btnHocBa.Click += BtnHocBa_Click;
            btnDong.Click += BtnDong_Click;
        }

        private void FrmHocSinhXemAdmin_Load(object sender, EventArgs e)
        {
            LoadThongTinHocSinh();
        }

        private void LoadThongTinHocSinh()
        {
            DataRow hs = bll.LayThongTinHocSinh(hocSinhID);
            if (hs == null)
            {
                MessageBox.Show($"Không tìm thấy học sinh có ID = {hocSinhID}.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            txtHoTen.Text = hs["HoTen"]?.ToString() ?? "";
            dtNgaySinh.Value = hs["NgaySinh"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(hs["NgaySinh"]);

            bool isNam = false;
            if (hs["GioiTinh"] != DBNull.Value)
                isNam = Convert.ToBoolean(hs["GioiTinh"]);
            chkNam.Checked = isNam;
            chkNu.Checked = !isNam;

            txtDanToc.Text = hs["DanToc"]?.ToString() ?? "";
            txtTonGiao.Text = hs["TonGiao"]?.ToString() ?? "";
            txtQueQuan.Text = hs["QueQuan"]?.ToString() ?? "";
            numNamNhapHoc.Value = hs["NamNhapHoc"] == DBNull.Value ? DateTime.Now.Year : Convert.ToDecimal(hs["NamNhapHoc"]);

            // Trạng thái học sinh
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new object[] { "Đang học", "Bảo lưu", "Đã tốt nghiệp", "Thôi học" });
            if (hs["TrangThai"] != DBNull.Value)
            {
                int trangThai = Convert.ToInt32(hs["TrangThai"]);
                cboTrangThai.SelectedIndex = Math.Min(trangThai, cboTrangThai.Items.Count - 1);
            }

            // Lớp
            cboLop.Items.Clear();
            string tenLop = hs["TenLop"]?.ToString() ?? "Chưa xếp lớp";
            cboLop.Items.Add(tenLop);
            cboLop.SelectedIndex = 0;

            // Khóa toàn bộ control (chỉ xem)
            foreach (Control c in this.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2TextBox txt) txt.ReadOnly = true;
                if (c is Guna.UI2.WinForms.Guna2ComboBox cb) cb.Enabled = false;
                if (c is Guna.UI2.WinForms.Guna2CheckBox chk) chk.Enabled = false;
                if (c is NumericUpDown num) num.Enabled = false;
                if (c is Guna.UI2.WinForms.Guna2DateTimePicker dt) dt.Enabled = false;
            }
        }

        private void BtnHocBa_Click(object sender, EventArgs e)
        {
            try
            {
                new HocBaAdmin(hocSinhID).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở học bạ: " + ex.Message);
            }
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
