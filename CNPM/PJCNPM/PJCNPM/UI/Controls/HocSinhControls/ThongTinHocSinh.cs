using System;
using System.Windows.Forms;
using PJCNPM.UI.PopUpFrm.HocSinhPopUp;

namespace PJCNPM.UI.Controls.HocSinhControls
{
    public partial class ThongTinHocSinh : UserControl
    {
        public ThongTinHocSinh()
        {
            InitializeComponent();
            this.Load += ThongTinHocSinh_Load;
        }

        private void ThongTinHocSinh_Load(object sender, EventArgs e)
        {
            // 🧠 Giả lập lấy dữ liệu học sinh
            var hs = GetHocSinhById(1);

            // 🏷️ Hiển thị thông tin lên các label
            valMaHS.Text = hs.HocSinhID.ToString();
            valHoTen.Text = hs.HoTen;
            valNgaySinh.Text = hs.NgaySinh.ToString("dd/MM/yyyy");
            valGioiTinh.Text = hs.GioiTinh ? "Nam" : "Nữ";
            valDanToc.Text = hs.DanToc;
            valTonGiao.Text = hs.TonGiao;
            valQueQuan.Text = hs.QueQuan;
            valTrangThai.Text = hs.TrangThai;
            valNamNhapHoc.Text = hs.NamNhapHoc.ToString();
        }

        private HocSinh GetHocSinhById(int id)
        {
            // 🚀 Bạn có thể gọi DAL hoặc database thật ở đây.
            return new HocSinh
            {
                HocSinhID = 1,
                HoTen = "Nguyễn Văn A",
                NgaySinh = new DateTime(2008, 5, 20),
                GioiTinh = true,
                DanToc = "Kinh",
                TonGiao = "Không",
                QueQuan = "TP. Hồ Chí Minh",
                TrangThai = "Đang học",
                NamNhapHoc = 2023
            };
        }

        private void btnYeuCauChinhSua_Click(object sender, EventArgs e)
        {
           HocSinh hs = GetHocSinhById(1);  

            FrmYeuCauChinhSuaHocSinh yc= new FrmYeuCauChinhSuaHocSinh(hs);
            yc.ShowDialog();

        }

    }

    public class HocSinh
    {
        public int HocSinhID { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public string QueQuan { get; set; }
        public string TrangThai { get; set; }
        public int NamNhapHoc { get; set; }
    }
}
