using PJCNPM.BLL.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJCNPM.UI.Controls.AdminControls
{
    public partial class MonHocControl : UserControl
    {
        private MonHocBLL _monHocBLL;
        private int selectedMonHocID = 0;

        public MonHocControl()
        {
            InitializeComponent();
            _monHocBLL = new MonHocBLL();
            chkTatCaMon.Checked = false;
            chkMonKhoa.Checked = false;
            chkMo.Checked = true; // Mặc định môn học ở trạng thái "Mở"
            LoadMonHoc();
            RefreshGridMonHoc_ByCheckbox();
        }

        private void LoadMonHoc()
        {
            var dt = _monHocBLL.LoadMonHoc();
            dgvMonHoc.DataSource = dt;
            dgvMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonHoc.Columns["MonHocID"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMonHoc.Rows[e.RowIndex];

                selectedMonHocID = row?.Cells["MonHocID"]?.Value is int v ? v
                  : (row?.Cells["MonHocID"]?.Value is string s && int.TryParse(s, out var x)) ? x
                  : 0;

                txtTenMon.Text = row.Cells["Môn học"].Value?.ToString();
                chkTietDoi.Checked = row.Cells["Môn đôi"].Value?.ToString() == "Có";
                chkMonNangKhieu.Checked = row.Cells["Môn năng khiếu"].Value?.ToString() == "Có";
                chkMo.Checked = row.Cells["Trạng thái"].Value?.ToString() == "Mở";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenMon = txtTenMon.Text.Trim();
            bool laMonDoi = chkTietDoi.Checked;
            bool laMonNangKhieu = chkMonNangKhieu.Checked;
            bool trangThaiMo = chkMo.Checked;

            if (string.IsNullOrEmpty(tenMon))
            {
                MessageBox.Show("Vui lòng nhập tên môn học!");
                return;
            }

            bool success = false;
            if (selectedMonHocID > 0)
            {
                success = _monHocBLL.UpdateMonHoc(selectedMonHocID, tenMon, laMonDoi, laMonNangKhieu, trangThaiMo);
                if (success)
                {
                    MessageBox.Show("Cập nhật môn học thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            else
            {
                success = _monHocBLL.AddMonHoc(tenMon, laMonDoi, laMonNangKhieu, trangThaiMo);
                if (success)
                {
                    MessageBox.Show("Thêm môn học thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }

            if (success)
            {
                LoadMonHoc();
                RefreshGridMonHoc_ByCheckbox();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTenMon.Text = string.Empty;
            chkTietDoi.Checked = false;
            chkMonNangKhieu.Checked = false;
            chkMo.Checked = true;
            dgvMonHoc.ClearSelection();
            selectedMonHocID = 0;

            LoadMonHoc();
            RefreshGridMonHoc_ByCheckbox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn môn học để xóa!");
                return;
            }

            int monHocID = Convert.ToInt32(dgvMonHoc.CurrentRow.Cells["MonHocID"].Value);

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (_monHocBLL.DeleteMonHoc(monHocID))
                {
                    MessageBox.Show("Xóa môn học thành công!");
                    LoadMonHoc();
                    RefreshGridMonHoc_ByCheckbox();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnXoaVinhVien_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn môn học để xóa vĩnh viễn!");
                return;
            }

            int monHocID = Convert.ToInt32(dgvMonHoc.CurrentRow.Cells["MonHocID"].Value);
            string tenMon = dgvMonHoc.CurrentRow.Cells["Môn học"].Value.ToString();

            // Cảnh báo nghiêm trọng về việc xóa vĩnh viễn
            DialogResult result = MessageBox.Show(
                $"⚠️ CẢNH BÁO NGHIÊM TRỌNG ⚠️\n\n" +
                $"Bạn đang thực hiện xóa VĨNH VIỄN môn học: '{tenMon}'\n\n" +
                $"Hành động này sẽ:\n" +
                $"• Xóa hoàn toàn môn học khỏi hệ thống\n" +
                $"• Xóa tất cả phân công dạy liên quan\n" +
                $"• Xóa tất cả thời khóa biểu liên quan\n" +
                $"• Xóa tất cả điểm số liên quan\n\n" +
                $"⚠️ KHÔNG THỂ HOÀN TÁC ⚠️\n\n" +
                $"Bạn có chắc chắn muốn tiếp tục?",
                "XÓA VĨNH VIỄN MÔN HỌC",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                // Xác nhận lần 2
                DialogResult confirmResult = MessageBox.Show(
                    $"Xác nhận cuối cùng:\n\n" +
                    $"Bạn có chắc chắn 100% muốn xóa VĨNH VIỄN môn học '{tenMon}'?\n\n" +
                    $"Hành động này KHÔNG THỂ HOÀN TÁC!",
                    "XÁC NHẬN CUỐI CÙNG",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Stop);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        if (_monHocBLL.PermanentlyDeleteMonHoc(monHocID))
                        {
                            MessageBox.Show("✅ Xóa vĩnh viễn môn học thành công!\n\n" +
                                          "Môn học và tất cả dữ liệu liên quan đã được xóa hoàn toàn khỏi hệ thống.",
                                          "Thành công",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Information);
                            
                            LoadMonHoc();
                            RefreshGridMonHoc_ByCheckbox();
                        }
                        else
                        {
                            MessageBox.Show("❌ Xóa vĩnh viễn thất bại!\n\n" +
                                          "Có thể môn học đang được sử dụng trong hệ thống hoặc có lỗi xảy ra.",
                                          "Lỗi",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"❌ Lỗi khi xóa vĩnh viễn môn học:\n\n{ex.Message}",
                                      "Lỗi",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BindMonHocToGrid(List<PJCNPM.Mod.MonHoc> dsmh)
        {
            var dt = new DataTable();
            dt.Columns.Add("MonHocID", typeof(int));
            dt.Columns.Add("Môn học");
            dt.Columns.Add("Môn đôi");
            dt.Columns.Add("Môn năng khiếu");
            dt.Columns.Add("Trạng thái");

            foreach (var mon in dsmh)
            {
                dt.Rows.Add(
                    mon.MonHocID,
                    mon.TenMon,
                    mon.LaMonDoi ? "Có" : "Không",
                    mon.LaMonNangKhieu ? "Có" : "Không",
                    mon.TrangThai ? "Mở" : "Khoá"
                );
            }

            dgvMonHoc.DataSource = dt;
            dgvMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonHoc.Columns["MonHocID"].Visible = false;
        }

        private void RefreshGridMonHoc_ByCheckbox()
        {
            var dt = _monHocBLL.LoadMonHocByFilter(chkTatCaMon.Checked, chkMonKhoa.Checked);
            dgvMonHoc.DataSource = dt;
            dgvMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonHoc.Columns["MonHocID"].Visible = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            RefreshGridMonHoc_ByCheckbox();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            chkMonKhoa.Enabled = !chkTatCaMon.Checked;
            RefreshGridMonHoc_ByCheckbox();
        }
    }
}
