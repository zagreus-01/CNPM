using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PJCNPM.BLL.Admin;

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    public partial class FrmChiTietChinhSua : Form
    {
        private readonly string _loai;
        private readonly int _id;
        private readonly ChiTietChinhSuaBLL bll = new ChiTietChinhSuaBLL();

        public FrmChiTietChinhSua(string loai, int id)
        {
            InitializeComponent();
            _loai = loai;
            _id = id;

            this.Load += FrmChiTietChinhSua_Load;
        }

        private void FrmChiTietChinhSua_Load(object sender, EventArgs e)
        {
            lblTieuDe.Text = $"CHI TIẾT CHỈNH SỬA ({_loai})";
            lblHoTen.Text = $"Người gửi: {_loai} #{_id}";
            LoadChiTiet();
        }

        private void LoadChiTiet()
        {
            DataTable src = bll.LayChiTietYeuCau(_loai, _id);
            if (src == null || src.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu chi tiết cho yêu cầu này.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var r = src.Rows[0];
            DataTable dt = new DataTable();
            dt.Columns.Add("Trường thông tin");
            dt.Columns.Add("Giá trị hiện tại");
            dt.Columns.Add("Giá trị đề nghị");

            if (_loai == "Học sinh")
            {
                dt.Rows.Add("Họ tên", r["HoTenCu"], r["HoTenMoi"]);
                dt.Rows.Add("Ngày sinh",
                    FormatDate(r["NgaySinhCu"]), FormatDate(r["NgaySinhMoi"]));
                dt.Rows.Add("Giới tính",
                    ConvertGioiTinh(r["GioiTinhCu"]), ConvertGioiTinh(r["GioiTinhMoi"]));
                dt.Rows.Add("Dân tộc", r["DanTocCu"], r["DanTocMoi"]);
                dt.Rows.Add("Tôn giáo", r["TonGiaoCu"], r["TonGiaoMoi"]);
                dt.Rows.Add("Quê quán", r["QueQuanCu"], r["QueQuanMoi"]);
            }
            else
            {
                dt.Rows.Add("Họ tên", r["HoTenCu"], r["HoTenMoi"]);
                dt.Rows.Add("Ngày sinh",
                    FormatDate(r["NgaySinhCu"]), FormatDate(r["NgaySinhMoi"]));
                dt.Rows.Add("Giới tính",
                    ConvertGioiTinh(r["GioiTinhCu"]), ConvertGioiTinh(r["GioiTinhMoi"]));
                dt.Rows.Add("CCCD", r["CCCDCu"], r["CCCDMoi"]);
                dt.Rows.Add("Email", r["EmailCu"], r["EmailMoi"]);
                dt.Rows.Add("Điện thoại", r["DienThoaiCu"], r["DienThoaiMoi"]);
                dt.Rows.Add("Quê quán", r["QueQuanCu"], r["QueQuanMoi"]);
            }

            dgvChiTiet.DataSource = dt;

            // 🎨 Style
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(94, 148, 255);
            dgvChiTiet.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvChiTiet.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvChiTiet.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvChiTiet.EnableHeadersVisualStyles = false;
        }

        // 🔹 Chuyển bit hoặc bool sang Nam/Nữ
        private string ConvertGioiTinh(object value)
        {
            if (value == null || value == DBNull.Value) return "Không rõ";
            string val = value.ToString().Trim().ToLower();

            if (val == "true" || val == "1") return "Nam";
            if (val == "false" || val == "0") return "Nữ";
            return val; // nếu đã là "Nam"/"Nữ" thì giữ nguyên
        }

        // 🔹 Định dạng ngày (nếu có)
        private string FormatDate(object value)
        {
            if (value == null || value == DBNull.Value) return "";
            if (DateTime.TryParse(value.ToString(), out DateTime date))
                return date.ToString("dd/MM/yyyy");
            return value.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
