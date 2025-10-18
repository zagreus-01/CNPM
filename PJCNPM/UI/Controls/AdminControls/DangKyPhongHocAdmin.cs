using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using PJCNPM.BLL.Admin;
using PJCNPM.UI.PopUpFrm.AdminPopUp;

namespace PJCNPM.UI.Controls.AdminControls
{
    public partial class DangKyPhongHocAdmin : UserControl
    {
        private readonly PhongHocAdminBLL _bll;
        private DataTable _dtLichToanBoPhong;
        private const int SoTiet = 10;

        public DangKyPhongHocAdmin()
        {
            InitializeComponent();
            _bll = new PhongHocAdminBLL();
        }

        private void DangKyPhongHocAdmin_Load(object sender, EventArgs e)
        {
            dtpNgayChon.Value = DateTime.Today;
            VeLichBieu(DateTime.Today);
        }

        private void dtpNgayChon_ValueChanged(object sender, EventArgs e)
        {
            VeLichBieu(dtpNgayChon.Value);
        }

        private void VeLichBieu(DateTime ngay)
        {
            _dtLichToanBoPhong = _bll.GetLichPhongTheoNgay(ngay);

            tblLichBieu.SuspendLayout();
            tblLichBieu.Controls.Clear();
            tblLichBieu.ColumnStyles.Clear();
            tblLichBieu.RowStyles.Clear();

            var phongHocs = _dtLichToanBoPhong.AsEnumerable()
                                      .GroupBy(r => new { PhongHocID = r.Field<int>("PhongHocID"), TenPhong = r.Field<string>("TenPhong") })
                                      .Select(g => g.Key)
                                      .OrderBy(p => p.TenPhong)
                                      .ToList();
            if (!phongHocs.Any())
            {
                tblLichBieu.ResumeLayout();
                // Có thể thêm một label thông báo không có phòng học nào
                return;
            }

            tblLichBieu.ColumnCount = SoTiet + 1;
            tblLichBieu.RowCount = phongHocs.Count + 1;

            // Thiết lập style cho cột và hàng
            tblLichBieu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F)); // Cột tên phòng
            for (int i = 0; i < SoTiet; i++) tblLichBieu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / SoTiet));
            tblLichBieu.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F)); // Hàng header
            for (int i = 0; i < phongHocs.Count; i++) tblLichBieu.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));

            // Tạo header
            tblLichBieu.Controls.Add(CreateHeaderLabel("Phòng"), 0, 0);
            for (int tiet = 1; tiet <= SoTiet; tiet++) tblLichBieu.Controls.Add(CreateHeaderLabel($"Tiết {tiet}"), tiet, 0);

            // Tạo các ô lịch biểu
            for (int i = 0; i < phongHocs.Count; i++)
            {
                var phong = phongHocs[i];
                tblLichBieu.Controls.Add(CreateHeaderLabel(phong.TenPhong, false), 0, i + 1);

                for (int tiet = 1; tiet <= SoTiet; tiet++)
                {
                    var lichDangKy = _dtLichToanBoPhong.AsEnumerable()
                        .FirstOrDefault(r => r.Field<int>("PhongHocID") == phong.PhongHocID &&
                                             r.Field<object>("LichDangKiPhongID") != DBNull.Value &&
                                             tiet >= r.Field<byte?>("TietBatDau") &&
                                             tiet <= r.Field<byte?>("TietKetThuc"));

                    Guna2Panel cellPanel = (lichDangKy == null)
                        ? CreateCellPanel_Trong(phong.PhongHocID, phong.TenPhong, tiet)
                        : CreateCellPanel_DaDat(lichDangKy);

                    tblLichBieu.Controls.Add(cellPanel, tiet, i + 1);
                }
            }
            tblLichBieu.ResumeLayout();
        }

        #region UI Creation Helpers

        private Label CreateHeaderLabel(string text, bool isColumnHeader = true)
        {
            return new Label
            {
                Text = text,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = isColumnHeader ? Color.FromArgb(79, 70, 229) : Color.FromArgb(243, 244, 246),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = isColumnHeader ? Color.White : Color.FromArgb(55, 65, 81),
                Margin = new Padding(1)
            };
        }

        private Guna2Panel CreateCellPanel_Trong(int phongID, string tenPhong, int tiet)
        {
            var panel = new Guna2Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(2),
                FillColor = Color.White,
                BorderColor = Color.FromArgb(229, 231, 235),
                BorderThickness = 1,
                BorderRadius = 4,
                Cursor = Cursors.Hand,
                Tag = new { Type = "Trong", PhongID = phongID, TenPhong = tenPhong, Tiet = tiet }
            };
            panel.Click += CellPanel_Click;

            var originalBorderColor = panel.BorderColor;
            panel.MouseEnter += (s, e) => { (s as Guna2Panel).BorderColor = Color.FromArgb(74, 222, 128); };
            panel.MouseLeave += (s, e) => { (s as Guna2Panel).BorderColor = originalBorderColor; };
            return panel;
        }

        private Guna2Panel CreateCellPanel_DaDat(DataRow row)
        {
            var panel = new Guna2Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(2),
                BorderThickness = 1,
                BorderRadius = 4,
                Cursor = Cursors.Hand, // Admin có thể click để hủy
                Tag = new { Type = "DaDat", LichDangKiID = row["LichDangKiPhongID"] }
            };
            panel.Click += CellPanel_Click;

            var lblInfo = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 8F),
                Enabled = false,
                Text = $"GV: {row["GiaoVienDangKy"]}\nLớp: {row["TenLop"]}"
            };
            panel.Controls.Add(lblInfo);

            panel.FillColor = Color.FromArgb(254, 226, 226);
            panel.BorderColor = Color.FromArgb(252, 165, 165);
            lblInfo.ForeColor = Color.FromArgb(159, 18, 57);

            return panel;
        }

        #endregion

        #region Event Handlers

        private void CellPanel_Click(object sender, EventArgs e)
        {
            var panel = sender as Guna2Panel;
            dynamic tagData = panel.Tag;
            DateTime selectedDate = dtpNgayChon.Value;

            if (selectedDate.Date < DateTime.Today)
            {
                MessageBox.Show("Không thể thực hiện thao tác cho ngày trong quá khứ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tagData.Type == "Trong")
            {
                using (var frm = new FrmDangKyChiTietAdmin(tagData.PhongID, tagData.TenPhong, selectedDate))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        VeLichBieu(selectedDate); // Refresh lại lịch biểu
                    }
                }
            }
            else if (tagData.Type == "DaDat")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn hủy lịch đăng ký này?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string ketQua = _bll.HuyDangKy(Convert.ToInt32(tagData.LichDangKiID));
                    MessageBox.Show(ketQua, "Thông báo", MessageBoxButtons.OK, ketQua.Contains("thành công") ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                    if (ketQua.Contains("thành công"))
                    {
                        VeLichBieu(selectedDate); // Refresh lại lịch biểu
                    }
                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabLichSu)
            {
                LoadLichSu(); // Tải dữ liệu không có bộ lọc khi chuyển tab
            }
        }

        private void txtSearchLichSu_TextChanged(object sender, EventArgs e)
        {
            LoadLichSu(txtSearchLichSu.Text.Trim());
        }

        private void LoadLichSu(string searchTerm = "")
        {
            try
            {
                dgvLichSu.DataSource = null;
                dgvLichSu.Columns.Clear();
                dgvLichSu.DataSource = _bll.GetLichSuDangKy(searchTerm);
                SetupDgvLichSu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch sử đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDgvLichSu()
        {
            if (dgvLichSu.Columns.Count == 0) return;

            dgvLichSu.Columns["LichDangKiPhongID"].Visible = false;

            dgvLichSu.Columns["Ngay"].HeaderText = "Ngày Đăng Ký";
            dgvLichSu.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvLichSu.Columns["TenPhong"].HeaderText = "Tên Phòng";
            dgvLichSu.Columns["GiaoVienDangKy"].HeaderText = "Giáo Viên";
            dgvLichSu.Columns["TietBatDau"].HeaderText = "Từ Tiết";
            dgvLichSu.Columns["TietKetThuc"].HeaderText = "Đến Tiết";
            dgvLichSu.Columns["TenLop"].HeaderText = "Lớp Sử Dụng";
            dgvLichSu.Columns["MucDich"].HeaderText = "Mục Đích";

            if (dgvLichSu.Columns["HuyButton"] == null)
            {
                var huyButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "HuyButton",
                    HeaderText = "Hành động",
                    Text = "Hủy",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Flat,
                };
                huyButtonColumn.DefaultCellStyle.ForeColor = Color.White;
                huyButtonColumn.DefaultCellStyle.BackColor = Color.FromArgb(239, 68, 68);
                huyButtonColumn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 38, 38);
                dgvLichSu.Columns.Add(huyButtonColumn);
            }

            dgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichSu.Columns["MucDich"].FillWeight = 150;
            dgvLichSu.Columns["GiaoVienDangKy"].FillWeight = 110;
            dgvLichSu.Columns["HuyButton"].FillWeight = 50;
        }

        private void dgvLichSu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvLichSu.Columns["HuyButton"].Index)
            {
                DateTime ngayDangKy = Convert.ToDateTime(dgvLichSu.Rows[e.RowIndex].Cells["Ngay"].Value);
                if (ngayDangKy.Date < DateTime.Today)
                {
                    MessageBox.Show("Không thể hủy lịch đăng ký đã diễn ra trong quá khứ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn hủy lịch đăng ký này?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int lichDangKiID = Convert.ToInt32(dgvLichSu.Rows[e.RowIndex].Cells["LichDangKiPhongID"].Value);
                    string ketQua = _bll.HuyDangKy(lichDangKiID);
                    MessageBox.Show(ketQua, "Thông báo", MessageBoxButtons.OK, ketQua.Contains("thành công") ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                    if (ketQua.Contains("thành công"))
                    {
                        LoadLichSu(txtSearchLichSu.Text.Trim()); // Tải lại với bộ lọc hiện tại
                    }
                }
            }
        }

        #endregion
    }
}