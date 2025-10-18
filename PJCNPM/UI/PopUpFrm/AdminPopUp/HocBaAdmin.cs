using PJCNPM.BLL.Admin;
using System;
using System.Data;
using System.Windows.Forms;

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    public partial class HocBaAdmin : Form
    {
        private readonly HocBaAdminBLL bll = new HocBaAdminBLL();
        private readonly int hocSinhID;
        private bool isLoading = true; // Tránh load lặp khi đang khởi tạo

        public HocBaAdmin(int hocSinhID)
        {
            InitializeComponent();
            this.hocSinhID = hocSinhID;

            this.Load += HocBaAdmin_Load;

            cboNamHoc.SelectedIndexChanged += cboNamHoc_SelectedIndexChanged;
            cboHocKy.SelectedIndexChanged += cboHocKy_SelectedIndexChanged;
        }

        private void HocBaAdmin_Load(object sender, EventArgs e)
        {
            LoadNamHoc();

            if (cboNamHoc.Items.Count > 0)
            {
                cboNamHoc.SelectedIndex = 0;
                LoadHocKy();
                cboHocKy.SelectedIndex = 0;

                // 🔹 Sau khi khởi tạo xong → cho phép auto-load
                isLoading = false;

                // 🔹 Hiển thị học bạ mặc định
                HienThiBangDiem();
            }
        }

        private void LoadNamHoc()
        {
            DataTable dt = bll.LayNamHocTheoHocSinh(hocSinhID);
            cboNamHoc.Items.Clear();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    cboNamHoc.Items.Add(row["NamHoc"].ToString());
            }
            else
            {
                cboNamHoc.Items.Add(DateTime.Now.Year.ToString());
            }
        }

        private void LoadHocKy()
        {
            cboHocKy.Items.Clear();
            cboHocKy.Items.Add("1");
            cboHocKy.Items.Add("2");
        }

        // 🔹 Khi đổi năm học → tự load lại học kỳ & học bạ
        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return;

            LoadHocKy();
            cboHocKy.SelectedIndex = 0;
            HienThiBangDiem();
        }

        // 🔹 Khi đổi học kỳ → tự load lại bảng điểm
        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            HienThiBangDiem();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            HienThiBangDiem();
        }

        /// <summary>
        /// Hàm hiển thị bảng điểm theo học kỳ + năm học
        /// </summary>
        private void HienThiBangDiem()
        {
            if (cboNamHoc.SelectedItem == null || cboHocKy.SelectedItem == null)
                return;

            int namHoc = Convert.ToInt32(cboNamHoc.SelectedItem);
            int hocKy = Convert.ToInt32(cboHocKy.SelectedItem);

            // 🔹 Lấy dữ liệu điểm
            DataTable dt = bll.LayDiemTheoHocKy(hocSinhID, namHoc, hocKy);

            if (dt == null || dt.Rows.Count == 0)
            {
                dgvDiemSo.DataSource = null;
                lblDiemTB.Text = "Điểm Trung Bình: 0.00";
                lblHanhKiem.Text = "Hạnh Kiểm: Chưa có";
                return;
            }

            dgvDiemSo.DataSource = dt;
            if (dgvDiemSo.Columns.Contains("Điểm TB"))
                dgvDiemSo.Columns["Điểm TB"].DefaultCellStyle.Format = "N2";

            // 🔹 Lấy điểm trung bình học kỳ & hạnh kiểm
            DataRow thongTin = bll.LayThongTinHocKy(hocSinhID, namHoc, hocKy);

            double tb = 0;
            string hanhKiem = "Chưa có";

            if (thongTin != null)
            {
                if (thongTin.Table.Columns.Contains("DiemTrungBinhHK") && thongTin["DiemTrungBinhHK"] != DBNull.Value)
                    tb = Convert.ToDouble(thongTin["DiemTrungBinhHK"]);

                if (thongTin.Table.Columns.Contains("HanhKiem") && thongTin["HanhKiem"] != DBNull.Value &&
                    !string.IsNullOrWhiteSpace(thongTin["HanhKiem"].ToString()))
                    hanhKiem = thongTin["HanhKiem"].ToString();
            }

            lblDiemTB.Text = $"Điểm Trung Bình: {tb:F2}";
            lblHanhKiem.Text = $"Hạnh Kiểm: {hanhKiem}";
        }
    }
}
