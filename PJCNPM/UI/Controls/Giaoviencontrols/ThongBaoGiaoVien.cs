using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PJCNPM.BLL.GiaoVien;
using PJCNPM.UI.PopUpFrm.GiaoVienPopUp; // Make sure this namespace is correct

namespace PJCNPM.UI.Controls.GiaoVienControls
{
    public partial class ThongBaoGiaoVien : UserControl
    {
        private readonly int _giaoVienID;
        private readonly string _tenTk;
        private readonly ThongBaoBLL _bllThongBao;
        private bool _isInboxView = true; // State variable to track the current view

        public ThongBaoGiaoVien(int giaoVienID, string tenTk)
        {
            InitializeComponent();
            _giaoVienID = giaoVienID;
            _tenTk = tenTk;
            _bllThongBao = new ThongBaoBLL();
            btnHopThuDen_Click(null, null); // Load inbox by default when the control is opened
        }

        #region Loading Data Methods
        private void LoadHopThuDen()
        {
            try
            {
                DataTable dt = _bllThongBao.GetThongBaoNhanTuAdmin(_giaoVienID);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvThongBao.DataSource = dt;
                    dgvThongBao.Visible = true;
                    lblEmptyMessage.Visible = false;
                    SetupDataGridViewForInbox();
                }
                else
                {
                    // If there is no data, hide the grid and show the "empty" message
                    dgvThongBao.DataSource = null;
                    dgvThongBao.Visible = false;
                    lblEmptyMessage.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hộp thư đến: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDaGui()
        {
            try
            {
                DataTable dt = _bllThongBao.GetThongBaoDaGui(_tenTk);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvThongBao.DataSource = dt;
                    dgvThongBao.Visible = true;
                    lblEmptyMessage.Visible = false;
                    SetupDataGridViewForSent();
                }
                else
                {
                    // If there is no data, hide the grid and show the "empty" message
                    dgvThongBao.DataSource = null;
                    dgvThongBao.Visible = false;
                    lblEmptyMessage.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thư đã gửi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region DataGridView Setup
        /// <summary>
        /// Configures the DataGridView columns for the Inbox view.
        /// </summary>
        private void SetupDataGridViewForInbox()
        {
            dgvThongBao.Columns["ThongBaoID"].Visible = false;
            dgvThongBao.Columns["NoiDung"].Visible = false;

            dgvThongBao.Columns["TieuDe"].HeaderText = "Tiêu đề";
            dgvThongBao.Columns["TenNguoiGui"].HeaderText = "Người gửi";
            dgvThongBao.Columns["NgayGui"].HeaderText = "Thời gian";

            dgvThongBao.Columns["TieuDe"].FillWeight = 60;
            dgvThongBao.Columns["TenNguoiGui"].FillWeight = 20;
            dgvThongBao.Columns["NgayGui"].FillWeight = 20;
        }

        /// <summary>
        /// Configures the DataGridView columns for the Sent Items view.
        /// </summary>
        private void SetupDataGridViewForSent()
        {
            dgvThongBao.Columns["ThongBaoID"].Visible = false;
            dgvThongBao.Columns["NoiDung"].Visible = false;

            dgvThongBao.Columns["TieuDe"].HeaderText = "Tiêu đề";
            dgvThongBao.Columns["DanhSachLopNhan"].HeaderText = "Các lớp nhận";
            dgvThongBao.Columns["NgayGui"].HeaderText = "Thời gian";

            dgvThongBao.Columns["TieuDe"].FillWeight = 50;
            dgvThongBao.Columns["DanhSachLopNhan"].FillWeight = 35;
            dgvThongBao.Columns["NgayGui"].FillWeight = 15;
        }
        #endregion

        #region UI Event Handlers
        /// <summary>
        /// Visually highlights the selected button and de-highlights others.
        /// </summary>
        private void HighlightButton(Guna.UI2.WinForms.Guna2Button selectedButton)
        {
            // Reset all buttons to default style
            btnHopThuDen.FillColor = Color.Gainsboro;
            btnHopThuDen.ForeColor = Color.Black;
            btnDaGui.FillColor = Color.Gainsboro;
            btnDaGui.ForeColor = Color.Black;

            // Apply active style to the selected button
            selectedButton.FillColor = Color.FromArgb(0, 120, 215);
            selectedButton.ForeColor = Color.White;
        }

        private void btnHopThuDen_Click(object sender, EventArgs e)
        {
            _isInboxView = true;
            HighlightButton(btnHopThuDen);
            LoadHopThuDen();
        }

        private void btnDaGui_Click(object sender, EventArgs e)
        {
            _isInboxView = false;
            HighlightButton(btnDaGui);
            LoadDaGui();
        }

        private void btnSoanThongBao_Click(object sender, EventArgs e)
        {
            // Open the form to compose a new message
            using (var frm = new FrmSoanThongBao(_giaoVienID, _tenTk))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // If the message was sent successfully, switch to the "Sent" tab and refresh it
                    btnDaGui_Click(null, null);
                }
            }
        }

        private void dgvThongBao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore clicks on the header row

            var row = dgvThongBao.Rows[e.RowIndex];
            string tieuDe = row.Cells["TieuDe"].Value?.ToString();
            string noiDung = row.Cells["NoiDung"].Value?.ToString();
            DateTime ngayGui = Convert.ToDateTime(row.Cells["NgayGui"].Value);
            string message;

            if (_isInboxView)
            {
                // Format the message for the Inbox view
                string nguoiGui = row.Cells["TenNguoiGui"].Value?.ToString();
                message = $"Người gửi: {nguoiGui}\n" +
                          $"Thời gian: {ngayGui:dd/MM/yyyy HH:mm:ss}\n\n" +
                          $"---------------------------------------------------\n\n" +
                          $"{noiDung}";
            }
            else
            {
                // Format the message for the Sent Items view
                string dsLopNhan = row.Cells["DanhSachLopNhan"].Value?.ToString();
                message = $"Người gửi: Bạn ({_tenTk})\n" +
                          $"Gửi đến các lớp: {dsLopNhan}\n" +
                          $"Thời gian: {ngayGui:dd/MM/yyyy HH:mm:ss}\n\n" +
                          $"---------------------------------------------------\n\n" +
                          $"{noiDung}";
            }

            MessageBox.Show(message, "Chi tiết thông báo: " + tieuDe, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}