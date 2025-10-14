using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using PJCNPM.UI.PopUpFrm.HocSinhPopUp;

namespace PJCNPM.UI.Controls.HocSinhControls
{
    public partial class ThongBaoHocSinh : UserControl
    {
        private DataTable dtThongBao;

        public ThongBaoHocSinh()
        {
            InitializeComponent();

            // Đưa các phần có thể lỗi Designer vào logic
            InitStyles();
            InitColumns();
            InitEvents();
            LoadData();
        }

        private void InitStyles()
        {
            // ===== Header Style =====
            var headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                SelectionBackColor = Color.FromArgb(0, 120, 215),
                SelectionForeColor = Color.White
            };
            dgvThongBao.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvThongBao.ColumnHeadersHeight = 42;

            // ===== Cell Style =====
            var cellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.Black,
                SelectionBackColor = Color.FromArgb(225, 235, 255),
                SelectionForeColor = Color.Black,
                Font = new Font("Segoe UI", 10.5F)
            };
            dgvThongBao.DefaultCellStyle = cellStyle;
        }

        private void InitColumns()
        {
            dgvThongBao.AutoGenerateColumns = false;
            dgvThongBao.Columns.Clear();

            dgvThongBao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ThongBaoID",
                DataPropertyName = "ThongBaoID",
                Visible = false
            });

            dgvThongBao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TieuDe",
                HeaderText = "Tiêu đề",
                DataPropertyName = "TieuDe",
                FillWeight = 45
            });

            dgvThongBao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NguoiGui",
                HeaderText = "Người gửi",
                DataPropertyName = "NguoiGui",
                FillWeight = 25
            });

            dgvThongBao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayGui",
                HeaderText = "Ngày gửi",
                DataPropertyName = "NgayGui",
                FillWeight = 30
            });

            dgvThongBao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NoiDung",
                DataPropertyName = "NoiDung",
                Visible = false
            });
        }

        private void InitEvents()
        {
            this.txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            this.dgvThongBao.CellDoubleClick += dgvThongBao_CellDoubleClick;
        }

        private void LoadData()
        {
            dtThongBao = new DataTable();
            dtThongBao.Columns.Add("ThongBaoID", typeof(int));
            dtThongBao.Columns.Add("TieuDe", typeof(string));
            dtThongBao.Columns.Add("NguoiGui", typeof(string));
            dtThongBao.Columns.Add("NgayGui", typeof(DateTime));
            dtThongBao.Columns.Add("NoiDung", typeof(string));

            dtThongBao.Rows.Add(1, "Nộp học phí", "Phòng Tài vụ", DateTime.Parse("2025-10-10"), "Hạn cuối nộp học phí là 15/10/2025.");
            dtThongBao.Rows.Add(2, "Lịch thi học kỳ 1", "Giáo vụ", DateTime.Parse("2025-10-01"), "Lịch thi học kỳ 1 sẽ được công bố trên website.");
            dtThongBao.Rows.Add(3, "Họp phụ huynh", "Ban giám hiệu", DateTime.Parse("2025-09-30"), "Buổi họp phụ huynh tổ chức vào ngày 5/10/2025.");
            dtThongBao.Rows.Add(4, "Bổ sung hồ sơ", "Cô Hương", DateTime.Parse("2025-09-25"), "Các em nộp hồ sơ học bổng trước 30/9/2025.");
            dtThongBao.Rows.Add(5, "Báo nghỉ dạy", "Thầy Nam", DateTime.Parse("2025-10-08"), "Lớp nghỉ học tiết 2, môn Toán ngày 9/10/2025.");

            dgvThongBao.DataSource = dtThongBao;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string filter = txtTimKiem.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(filter))
            {
                dgvThongBao.DataSource = dtThongBao;
            }
            else
            {
                var filtered = dtThongBao.AsEnumerable()
                    .Where(r => r["TieuDe"].ToString().ToLower().Contains(filter)
                             || r["NguoiGui"].ToString().ToLower().Contains(filter));
                dgvThongBao.DataSource = filtered.Any() ? filtered.CopyToDataTable() : dtThongBao.Clone();
            }
        }

        private void dgvThongBao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgvThongBao.Rows[e.RowIndex].Cells["ThongBaoID"].Value);
                DataRow row = dtThongBao.AsEnumerable().FirstOrDefault(r => Convert.ToInt32(r["ThongBaoID"]) == id);

                if (row != null)
                {
                    string tieuDe = row["TieuDe"].ToString();
                    string noiDung = row["NoiDung"].ToString();
                    string nguoiGui = row["NguoiGui"].ToString();
                    DateTime ngayGui = (DateTime)row["NgayGui"];

                    using (var frm = new FrmThongBaoHocSinh(tieuDe,noiDung,nguoiGui,ngayGui))
                    {
                        frm.ShowDialog();
                    }
                }

            }
        }
    }
}
