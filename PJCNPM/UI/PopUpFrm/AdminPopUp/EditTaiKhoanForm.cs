using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PJCNPM.UI.PopUpFrm.AdminPopUp
{
    public partial class EditTaiKhoanForm : Form
    {
        // Lưu role cho phép (ví dụ HS: { null, 1 }, GV: { null, 2 })
        private readonly IEnumerable<int?> _allowedRoleIDs;

        // Public getters/setters để Form1 truy cập
        public string TenTK
        {
            get => txtTenTK.Text.Trim();
            set => txtTenTK.Text = value ?? string.Empty;
        }

        public string MatKhau
        {
            get => txtMatKhau.Text;
            set => txtMatKhau.Text = value ?? string.Empty;
        }

        public int? RoleID
        {
            get
            {
                if (cboRole.SelectedItem is RoleItem ri) return ri.Key;
                return null;
            }
            set
            {
                // set trước khi Load hoặc sau khi đã nạp items
                _pendingRole = value;
                TrySelectRole(value);
            }
        }

        /// <summary>
        /// Trạng thái tài khoản: 1 = Mở, 0 = Khóa
        /// </summary>
        public int TrangThai
        {
            get
            {
                // mapping theo UI:
                // index 0 = "Mở"   => 1
                // index 1 = "Khóa" => 0
                if (comboBox1.SelectedIndex == 1) return 0;
                return 1;
            }
            set
            {
                // value = 1 => chọn "Mở" (index = 0)
                // value = 0 => chọn "Khóa" (index = 1)
                if (comboBox1.Items.Count == 0) return;
                comboBox1.SelectedIndex = (value == 1) ? 0 : 1;
            }
        }

        private int? _pendingRole = null;

        // Class item cho ComboBox Role
        private sealed class RoleItem
        {
            public int? Key { get; }
            public string Text { get; }
            public RoleItem(int? key, string text) { Key = key; Text = text; }
            public override string ToString() => Text;
        }

        // Khởi tạo: truyền vào danh sách role cho phép (ví dụ new int?[]{1} cho HS, {2} cho GV, {1,2,3}…)
        public EditTaiKhoanForm(IEnumerable<int?> allowedRoleIDs)
        {
            _allowedRoleIDs = allowedRoleIDs ?? Enumerable.Empty<int?>();
            InitializeComponent();
        }

        private void EditTaiKhoanForm_Load(object sender, EventArgs e)
        {
            // ===== Nạp ROLE =====
            cboRole.Items.Clear();
            cboRole.Items.Add(new RoleItem(null, "Không gán (NULL)"));

            foreach (var id in _allowedRoleIDs.Distinct())
            {
                if (id.HasValue)
                {
                    string roleText = $"RoleID = {id.Value}";
                    if (id.Value == 1) roleText = "Học sinh";
                    else if (id.Value == 2) roleText = "Giáo viên";
                    else if (id.Value == 3) roleText = "Admin";
                    cboRole.Items.Add(new RoleItem(id.Value, roleText));
                }
            }

            // Mặc định chọn item đầu tiên
            if (cboRole.Items.Count > 0 && cboRole.SelectedIndex < 0)
                cboRole.SelectedIndex = 0;

            // Nếu trước đó đã set RoleID, thử chọn lại
            if (_pendingRole != null) TrySelectRole(_pendingRole);

            // ===== Nạp TRẠNG THÁI (comboBox1) =====
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Mở");   // index 0  -> TrangThai = 1
            comboBox1.Items.Add("Khóa"); // index 1  -> TrangThai = 0

            // Nếu chưa được set từ ngoài, mặc định là "Mở"
            if (comboBox1.SelectedIndex < 0)
                comboBox1.SelectedIndex = 0;
        }

        private void TrySelectRole(int? role)
        {
            if (cboRole.Items.Count == 0) return;
            for (int i = 0; i < cboRole.Items.Count; i++)
            {
                if (cboRole.Items[i] is RoleItem ri && ri.Key == role)
                {
                    cboRole.SelectedIndex = i;
                    return;
                }
            }
            // Không tìm thấy -> chọn NULL
            for (int i = 0; i < cboRole.Items.Count; i++)
            {
                if (cboRole.Items[i] is RoleItem ri && ri.Key == null)
                {
                    cboRole.SelectedIndex = i;
                    return;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TenTK))
            {
                MessageBox.Show("Vui lòng nhập Tên tài khoản.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTK.Focus();
                return;
            }

            // Có thể bổ sung validate khác ở đây (độ dài mật khẩu, ký tự hợp lệ, ...)

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
