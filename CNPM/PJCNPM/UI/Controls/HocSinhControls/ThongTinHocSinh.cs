using System;
using System.Windows.Forms;
using PJCNPM.BLL.HocSinh;
using PJCNPM.UI.PopUpFrm.HocSinhPopUp;

namespace PJCNPM.UI.Controls.HocSinhControls
{
    public partial class ThongTinHocSinh : UserControl
    {
        private readonly ThongTinHocSinhBLL bll = new ThongTinHocSinhBLL();
        private HocSinhDTO currentHS;
        private readonly int hocSinhID;

        public ThongTinHocSinh(int maHocSinh)
        {
            InitializeComponent();
            hocSinhID = maHocSinh;
            this.Load += ThongTinHocSinh_Load;
        }

        private void ThongTinHocSinh_Load(object sender, EventArgs e)
        {
            LoadThongTinHocSinh();
        }

        private void LoadThongTinHocSinh()
        {
            currentHS = bll.GetHocSinhById(hocSinhID);
            if (currentHS == null)
            {
                MessageBox.Show("Không tìm thấy thông tin học sinh.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            valMaHS.Text = currentHS.HocSinhID.ToString();
            valHoTen.Text = currentHS.HoTen;
            valNgaySinh.Text = currentHS.NgaySinh.ToString("dd/MM/yyyy");
            valGioiTinh.Text = currentHS.GioiTinh;
            valDanToc.Text = currentHS.DanToc;
            valTonGiao.Text = currentHS.TonGiao;
            valQueQuan.Text = currentHS.QueQuan;
            valTrangThai.Text = currentHS.TrangThai;
            valNamNhapHoc.Text = currentHS.NamNhapHoc.ToString();
        }

        private void btnYeuCauChinhSua_Click(object sender, EventArgs e)
        {
            if (currentHS == null)
            {
                MessageBox.Show("Không có dữ liệu học sinh để chỉnh sửa.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmYeuCauChinhSuaHocSinh frm = new FrmYeuCauChinhSuaHocSinh(currentHS);
            frm.ShowDialog();
        }
    }
}
