using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PJCNPM.BLL.GiaoVien;

namespace PJCNPM.UI.PopUpFrm.GiaoVienPopUp
{
    public partial class FrmSoanThongBao : Form
    {
        private readonly int _giaoVienID;
        private readonly string _tenTkGui;
        private readonly ThongBaoBLL _bllThongBao;

        public FrmSoanThongBao(int giaoVienID, string tenTkGui)
        {
            InitializeComponent();
            _giaoVienID = giaoVienID;
            _tenTkGui = tenTkGui;
            _bllThongBao = new ThongBaoBLL();
        }

        private void FrmSoanThongBao_Load(object sender, EventArgs e)
        {
            try
            {
                var lopDayList = _bllThongBao.GetCacLopGiaoVienDay(_giaoVienID);
                if (lopDayList != null && lopDayList.Count > 0)
                {
                    // Nạp dữ liệu vào CheckedListBox
                    clbLop.DataSource = lopDayList;
                    clbLop.DisplayMember = "TenLopHienThi";
                    clbLop.ValueMember = "LopID";
                }
                else
                {
                    MessageBox.Show("Bạn chưa được phân công giảng dạy hoặc chủ nhiệm lớp nào để gửi thông báo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGui.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTieuDe.Text))
            {
                MessageBox.Show("Vui lòng nhập tiêu đề thông báo.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTieuDe.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung thông báo.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoiDung.Focus();
                return;
            }

            // Lấy danh sách các LopID được chọn
            var dsLopID = clbLop.CheckedItems.Cast<ThongBaoBLL.LopDayInfo>()
                               .Select(item => item.LopID)
                               .ToList();

            if (dsLopID.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một lớp để gửi thông báo.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string tieuDe = txtTieuDe.Text.Trim();
                string noiDung = txtNoiDung.Text.Trim();

                btnGui.Enabled = false;
                btnGui.Text = "Đang gửi...";

                bool success = _bllThongBao.GuiThongBao(tieuDe, noiDung, _tenTkGui, dsLopID);

                if (success)
                {
                    MessageBox.Show($"Gửi thông báo thành công đến {dsLopID.Count} lớp!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gửi thông báo thất bại do có lỗi xảy ra trong quá trình xử lý. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi thông báo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGui.Enabled = true;
                btnGui.Text = "Gửi thông báo";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}