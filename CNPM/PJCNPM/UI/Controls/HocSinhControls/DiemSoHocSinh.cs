using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using PJCNPM.BLL.HocSinh;   // Namespace chứa DiemHocSinhBLL

namespace PJCNPM.UI.Controls.HocSinhControls
{
    public partial class DiemSoHocSinh : UserControl
    {
        private readonly DiemHocSinhBLL diemBLL = new DiemHocSinhBLL();
        private readonly int maHS;

        public DiemSoHocSinh(int maHs)
        {
            InitializeComponent();
            maHS = maHs;
            InitCombos();
        }

        private void InitCombos()
        {
            try
            {
                // ===== Năm học =====
                List<string> dsNamHoc = diemBLL.GetNamHocHocSinh(maHS);
                cboNamHoc.Items.Clear();
                cboNamHoc.Items.AddRange(dsNamHoc.ToArray());

                if (cboNamHoc.Items.Count > 0)
                    cboNamHoc.SelectedIndex = 0;

                // ===== Học kỳ =====
                cboHocKy.Items.Clear();
                cboHocKy.Items.AddRange(new object[] { "Tất cả", "Học kỳ 1", "Học kỳ 2" });
                cboHocKy.SelectedIndex = 0;

                // ===== Sự kiện thay đổi =====
                cboNamHoc.SelectedIndexChanged += (s, e) => LoadDiem();
                cboHocKy.SelectedIndexChanged += (s, e) => LoadDiem();

                // Gọi lần đầu
                LoadDiem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu năm học: " + ex.Message);
            }
        }

        private void LoadDiem()
        {
            try
            {
                if (cboNamHoc.SelectedItem == null) return;

                string namHocStr = cboNamHoc.SelectedItem.ToString();
                string hocKyStr = cboHocKy.SelectedItem.ToString();

                // Lấy dữ liệu điểm và hạnh kiểm từ BLL
                var result = diemBLL.GetBangDiem(maHS, namHocStr, hocKyStr);

                dgvDiemSo.DataSource = result.Diem;

                // ===== Hiển thị điểm TB =====
                double tong = 0;
                int dem = 0;
                foreach (DataRow row in result.Diem.Rows)
                {
                    if (result.Diem.Columns.Contains("Trung bình môn"))
                    {
                        double tbm;
                        if (double.TryParse(row["Trung bình môn"].ToString(), out tbm))
                        {
                            tong += tbm;
                            dem++;
                        }
                    }
                    else if (result.Diem.Columns.Contains("Trung bình cả năm"))
                    {
                        double tbn;
                        if (double.TryParse(row["Trung bình cả năm"].ToString(), out tbn))
                        {
                            tong += tbn;
                            dem++;
                        }
                    }
                }

                double diemTB = dem > 0 ? Math.Round(tong / dem, 2) : 0;

                // ===== Gán label =====
                if (hocKyStr == "Tất cả")
                    lblDiemTB.Text = $"Điểm trung bình năm: {diemTB}";
                else
                    lblDiemTB.Text = $"Điểm trung bình {hocKyStr.ToLower()}: {diemTB}";

                lblHanhKiem.Text = $"Hạnh kiểm: {result.HanhKiem}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải điểm: " + ex.Message);
            }
        }
    }
}
