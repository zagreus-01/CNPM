using PJCNPM.BLL.NhanVienBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJCNPM.UI.PopUpFrm.NhanVienPopUp
{
    public partial class KhoThietBiForm : Form
    {
        private ThietBiPhongHocBLL bll = new ThietBiPhongHocBLL();

        public KhoThietBiForm()
        {
            InitializeComponent();
        }

        private void KhoThietBiForm_Load(object sender, EventArgs e)
        {
            LoadThietBiKho();
        }

        private void LoadThietBiKho()
        {
            DataTable dt = bll.GetTonKhoThietBi();
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["TenThietBi"].HeaderText = "Tên Thiết Bị";
            dataGridView1.Columns["TongSoLuong"].HeaderText = "Tổng Số Lượng";
            dataGridView1.Columns["DaPhanBo"].HeaderText = "Đã Phân Bổ";
            dataGridView1.Columns["ConLai"].HeaderText = "Còn Lại";
            dataGridView1.Columns["DonViTinh"].HeaderText = "Đơn Vị Tính";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
