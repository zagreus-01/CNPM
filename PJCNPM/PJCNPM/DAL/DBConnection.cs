using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PJCNPM.DAL
{
    internal class DBConnection
    {
        private readonly string connectionString =
            @"Data Source=TUNG;Initial Catalog=PJCNPM;Integrated Security=True";

        // 🔹 Lấy dữ liệu (dạng DataTable) - hỗ trợ cả query có tham số
        public DataTable GetData(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi truy vấn dữ liệu: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // 🔹 Thực thi câu lệnh không trả kết quả (INSERT, UPDATE, DELETE)
        public bool ExecuteNonQuery(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi thực thi SQL: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // 🔹 Nếu bạn vẫn muốn dùng cách cũ (chuỗi trực tiếp)
        public DataTable GetData(string sql)
        {
            return GetData(sql, null);
        }

        public bool ExecuteNonQuery(string sql)
        {
            return ExecuteNonQuery(sql, null);
        }
    }
}
