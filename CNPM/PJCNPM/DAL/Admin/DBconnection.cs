using System;
using System.Data.SqlClient;
using PJCNPM.DAL;
namespace PJCNPM.DAL.Admin
{
    internal class DBconnection
    {
        private readonly string connectionString;

        public DBconnection()
        {
            // Connection string mặc định (có thể thay đổi theo môi trường)
            connectionString = PJCNPM.DAL.DBConnection.GlobalConfig.ConnectionString;

        }

        public DBconnection(string connString)
        {
            connectionString = connString;
        }

        // Hàm lấy kết nối
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
