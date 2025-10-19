using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace PJCNPM.UI.Controls.HocSinhControls
{
    public partial class DiemSoHocSinh : UserControl
    {
        public DiemSoHocSinh()
        {
            InitializeComponent();
            InitCombos();
        }

        private void InitCombos()
        {
            // Năm học
            cboNamHoc.Items.AddRange(new object[] { "2023", "2024", "2025" });
            cboNamHoc.SelectedIndex = 0;

            // Học kỳ
            cboHocKy.Items.AddRange(new object[] { "Tất cả", "Học kỳ 1", "Học kỳ 2" });
            cboHocKy.SelectedIndex = 0;

            cboNamHoc.SelectedIndexChanged += (s, e) => LoadDiem();
            cboHocKy.SelectedIndexChanged += (s, e) => LoadDiem();

            LoadDiem();
        }

        private void LoadDiem()
        {
            string hocKyStr = cboHocKy.SelectedItem.ToString();
            int? hocKy = null;
            if (hocKyStr == "Học kỳ 1")
                hocKy = 1;
            else if (hocKyStr == "Học kỳ 2")
                hocKy = 2;

            DataTable dt = new DataTable();

            if (hocKy == null)
            {
                // ====== CẢ NĂM ======
                dt.Columns.Add("Môn học");
                dt.Columns.Add("Trung bình HK1");
                dt.Columns.Add("Trung bình HK2");
                dt.Columns.Add("Trung bình cả năm");

                dt.Rows.Add("Toán", 8.4, 7.8, 8.1);
                dt.Rows.Add("Ngữ văn", 7.9, 7.2, 7.6);
                dt.Rows.Add("Anh văn", 8.3, 8.0, 8.15);
                dt.Rows.Add("Vật lý", 7.8, 7.6, 7.7);
                dt.Rows.Add("Hóa học", 8.1, 8.0, 8.05);

                lblDiemTB.Text = "Điểm trung bình năm: 7.9";
                lblHanhKiem.Text = "Hạnh kiểm năm: Tốt";
            }
            else
            {
                // ====== HỌC KỲ CỤ THỂ ======
                dt.Columns.Add("Môn học");
                dt.Columns.Add("TX1");
                dt.Columns.Add("TX2");
                dt.Columns.Add("TX3");
                dt.Columns.Add("TX4");
                dt.Columns.Add("Giữa kỳ");
                dt.Columns.Add("Cuối kỳ");
                dt.Columns.Add("Trung bình môn");

                if (hocKy == 1)
                {
                    dt.Rows.Add("Toán", 8, 9, 8.5, 8, 8.5, 8.0, 8.4);
                    dt.Rows.Add("Ngữ văn", 7, 8, 7.5, 7, 7.5, 8, 7.6);
                    dt.Rows.Add("Anh văn", 9, 8.5, 8.5, 8, 8.5, 8, 8.4);
                    dt.Rows.Add("Vật lý", 8, 8, 7.5, 8, 8, 8, 7.9);
                    dt.Rows.Add("Hóa học", 7.5, 8, 8, 8, 8.5, 8, 8.0);
                    lblDiemTB.Text = "Điểm trung bình học kỳ 1: 8.1";
                    lblHanhKiem.Text = "Hạnh kiểm học kỳ 1: Tốt";
                }
                else
                {
                    dt.Rows.Add("Toán", 7.5, 8, 7.5, 8, 8, 8.5, 7.9);
                    dt.Rows.Add("Ngữ văn", 7, 7.5, 7, 7, 7.5, 7.5, 7.3);
                    dt.Rows.Add("Anh văn", 8, 8.5, 8, 8.5, 8.5, 8, 8.3);
                    dt.Rows.Add("Vật lý", 7.5, 7.8, 8, 7.8, 7.5, 7.8, 7.7);
                    dt.Rows.Add("Hóa học", 8, 8, 7.5, 8, 8, 8, 7.9);
                    lblDiemTB.Text = "Điểm trung bình học kỳ 2: 7.8";
                    lblHanhKiem.Text = "Hạnh kiểm học kỳ 2: Khá";
                }
            }

            // ====== Gán dữ liệu ======
            dgvDiemSo.DataSource = dt;

           
        }
    }
}
