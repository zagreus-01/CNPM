using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using PJCNPM.BLL.HocSinh;
using PJCNPM.UI.PopUpFrm.HocSinhPopUp;
using Guna.UI2.WinForms;

namespace PJCNPM.UI.Controls.HocSinhControls
{
    public partial class ThongBaoHocSinh : UserControl
    {
        private readonly ThongBaoHocSinhBLL bll;
        private DataTable dtThongBao;

        public ThongBaoHocSinh(int maHocSinh)
        {
            InitializeComponent();
            bll = new ThongBaoHocSinhBLL(maHocSinh);

            InitStyles();
            InitColumns();
            InitEvents();
            LoadData();
        }

        // 🎨 Style
        private void InitStyles()
        {
            dgvThongBao.AutoGenerateColumns = false;
            dgvThongBao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThongBao.MultiSelect = false;
            dgvThongBao.ReadOnly = true;
            dgvThongBao.AllowUserToAddRows = false;
            dgvThongBao.AllowUserToResizeRows = false;

            // 🔹 Header style mặc định
            dgvThongBao.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleLeft
            };

            dgvThongBao.ColumnHeadersHeight = 42;
            dgvThongBao.DefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 10.5F),
                BackColor = Color.White,
                ForeColor = Color.Black,
                SelectionBackColor = Color.FromArgb(225, 235, 255),
                SelectionForeColor = Color.Black
            };

            dgvThongBao.GridColor = Color.FromArgb(230, 230, 230);
            dgvThongBao.RowHeadersVisible = false;

            // ✅ Giữ màu header không đổi khi hover/click
            FixHeaderColor(dgvThongBao);
        }

        // 🧱 Cột
        private void InitColumns()
        {
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
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 45
            });

            dgvThongBao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NguoiGui",
                HeaderText = "Người gửi",
                DataPropertyName = "NguoiGui",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 25
            });

            dgvThongBao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayGui",
                HeaderText = "Ngày gửi",
                DataPropertyName = "NgayGui",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 30,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }
            });

            dgvThongBao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NoiDung",
                DataPropertyName = "NoiDung",
                Visible = false
            });
        }

        // ⚙️ Event
        private void InitEvents()
        {
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            dgvThongBao.CellDoubleClick += dgvThongBao_CellDoubleClick;
        }

        // 🔄 Load
        private void LoadData()
        {
            try
            {
                dtThongBao = bll.LayDanhSachThongBao();
                dgvThongBao.DataSource = dtThongBao;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách thông báo: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔍 Tìm kiếm
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (dtThongBao == null || dtThongBao.Rows.Count == 0)
                return;

            string keyword = txtTimKiem.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                dgvThongBao.DataSource = dtThongBao;
                return;
            }

            var filtered = dtThongBao.AsEnumerable()
                .Where(r => r["TieuDe"].ToString().ToLower().Contains(keyword)
                         || r["NguoiGui"].ToString().ToLower().Contains(keyword));

            dgvThongBao.DataSource = filtered.Any()
                ? filtered.CopyToDataTable()
                : dtThongBao.Clone();
        }

        // 👁️ Xem chi tiết
        private void dgvThongBao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int thongBaoID = Convert.ToInt32(dgvThongBao.Rows[e.RowIndex].Cells["ThongBaoID"].Value);
            DataRow row = dtThongBao.AsEnumerable()
                .FirstOrDefault(r => Convert.ToInt32(r["ThongBaoID"]) == thongBaoID);

            if (row != null)
            {
                string tieuDe = row["TieuDe"].ToString();
                string noiDung = row["NoiDung"].ToString();
                string nguoiGui = row["NguoiGui"].ToString();
                DateTime ngayGui = Convert.ToDateTime(row["NgayGui"]);

                using (var frm = new FrmThongBaoHocSinh(tieuDe, noiDung, nguoiGui, ngayGui))
                {
                    frm.ShowDialog();
                }
            }
        }

        // 🔒 Giữ nguyên màu header Guna2 (không đổi khi click/hover)
        private void FixHeaderColor(Guna2DataGridView dgv)
        {
            // Ngắt theme Guna
            dgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            dgv.EnableHeadersVisualStyles = false;
            dgv.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;

            // Màu header cố định
            var headerColor = Color.FromArgb(0, 120, 215);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = headerColor;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            // Đảm bảo Guna2 không override theme
            dgv.ThemeStyle.HeaderStyle.BackColor = headerColor;
            dgv.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgv.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        }
    }
}
