using PJCNPM.BLL.Admin;
using System;
using System.Data;
using System.Windows.Data;
using System.Windows.Forms;

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    public partial class HocBaAdmin : Form
    {
        private readonly HocBaAdminBLL bll = new HocBaAdminBLL();
        private readonly int hocSinhID;

        public HocBaAdmin(int hocSinhID)
        {
            InitializeComponent();
            this.hocSinhID = hocSinhID;
            this.Load += HocBaAdmin_Load;
            cboNamHoc.SelectedIndexChanged += cboNamHoc_SelectedIndexChanged;
        }

        private void HocBaAdmin_Load(object sender, EventArgs e)
        {
            LoadNamHoc();
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

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboHocKy.Items.Clear();
            // 🔹 Luôn hiển thị 2 học kỳ
            cboHocKy.Items.Add("1");
            cboHocKy.Items.Add("2");
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedItem == null || cboHocKy.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn năm học và học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int namHoc = Convert.ToInt32(cboNamHoc.SelectedItem);
            int hocKy = Convert.ToInt32(cboHocKy.SelectedItem);

            // 🔹 Lấy dữ liệu điểm
            DataTable dt = bll.LayDiemTheoHocKy(hocSinhID, namHoc, hocKy);

            if (dt == null || dt.Rows.Count == 0)
            {
                dgvDiemSo.DataSource = null;
                MessageBox.Show($"Không có dữ liệu điểm cho học kỳ {hocKy} - năm {namHoc}.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvDiemSo.DataSource = dt;

                // Làm tròn hiển thị 2 chữ số sau dấu phẩy
                if (dgvDiemSo.Columns["Điểm TB"] != null)
                    dgvDiemSo.Columns["Điểm TB"].DefaultCellStyle.Format = "N2";
            }

            // 🔹 Lấy điểm trung bình học kỳ & hạnh kiểm
            DataRow thongTin = bll.LayThongTinHocKy(hocSinhID, namHoc, hocKy);

            double tb = 0;
            string hanhKiem = "Chưa có";

            if (thongTin != null)
            {
                if (thongTin.Table.Columns.Contains("DiemTrungBinhHK") && thongTin["DiemTrungBinhHK"] != DBNull.Value)
                    tb = Convert.ToDouble(thongTin["DiemTrungBinhHK"]);

                if (thongTin.Table.Columns.Contains("HanhKiem") && thongTin["HanhKiem"] != DBNull.Value && !string.IsNullOrWhiteSpace(thongTin["HanhKiem"].ToString()))
                    hanhKiem = thongTin["HanhKiem"].ToString();
            }

            lblDiemTB.Text = $"Điểm Trung Bình: {tb:F2}";
            lblHanhKiem.Text = $"Hạnh Kiểm: {hanhKiem}";
        }

    }
}
