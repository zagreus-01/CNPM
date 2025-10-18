using PJCNPM.BLL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PJCNPM.UI.MainFrm
{
    public partial class Login : Form
    {
        private readonly TaiKhoanBLL bll = new TaiKhoanBLL();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "⚠️ Vui lòng nhập đầy đủ thông tin.";
                return;
            }

            var result = bll.DangNhap(username, password);
            int roleID = result.RoleID;
            string roleName = result.RoleName;
            DataRow info = result.Info;

            if (info == null)
            {
                lblError.Text = "❌ Sai tài khoản hoặc mật khẩu.";
                return;
            }

            string hoTen = info.Table.Columns.Contains("HoTen") ? info["HoTen"].ToString() : username;
            int userID = 0; // int thay vì string

            // ✅ Lấy ID theo Role
            switch (roleID)
            {
                case 2:
                    userID = Convert.ToInt32(info["GiaoVienID"]);
                    break;
                case 3:
                    userID = Convert.ToInt32(info["HocSinhID"]);
                    break;
                default:
                    userID = 0; // Admin không cần ID cụ thể
                    break;
            }

            MessageBox.Show(
                $"Xin chào {hoTen}!\nChức vụ: {roleName}",
                "Đăng nhập thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Hide();

            // ✅ Truyền ID và họ tên sang form chính
            switch (roleID)
            {
                case 1:
                    new Admin().ShowDialog();
                    break;
                case 2:
                    new GiaoVien(username).ShowDialog();
                    break;
                case 3:
                    new HocSinh(userID).ShowDialog();
                    break;
                default:
                    MessageBox.Show("⚠️ Tài khoản không có quyền hợp lệ.");
                    break;
            }

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Khi checkbox được tick -> hiện mật khẩu
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0'; // hiện ký tự thật
            }
            else
            {
                txtPassword.PasswordChar = '•'; // ẩn bằng dấu chấm tròn
            }
        }
    }
}
