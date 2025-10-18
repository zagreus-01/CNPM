using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJCNPM.Mod;

namespace PJCNPM.DAL.Admin
{
    public class ThoiKhoaBieuDAL
    {
        private DBconnection dbConnection;

        public ThoiKhoaBieuDAL()
        {
            dbConnection = new DBconnection();
        }

        // Lấy tất cả TKB theo lớp
        public List<ThoiKhoaBieu> GetTKBByLop(int lopHocID)
        {
            List<ThoiKhoaBieu> tkbList = new List<ThoiKhoaBieu>();
            string query = @"
                SELECT TKBID, LopHocID, Thu, Tiet, MonHocID, GiaoVienID 
                FROM ThoiKhoaBieu 
                WHERE LopHocID = @LopHocID 
                ORDER BY Thu, Tiet";

            using (SqlConnection connection = dbConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LopHocID", lopHocID);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tkbList.Add(new ThoiKhoaBieu
                            {
                                TKBID = reader.GetInt32(reader.GetOrdinal("TKBID")),
                                LopHocID = reader.GetInt32(reader.GetOrdinal("LopHocID")),
                                Thu = reader.GetInt32(reader.GetOrdinal("Thu")),
                                Tiet = reader.GetInt32(reader.GetOrdinal("Tiet")),
                                MonHocID = reader.IsDBNull(reader.GetOrdinal("MonHocID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("MonHocID")),
                                GiaoVienID = reader.IsDBNull(reader.GetOrdinal("GiaoVienID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("GiaoVienID"))
                            });
                        }
                    }
                }
            }
            return tkbList;
        }

        // Lấy TKB theo giáo viên
        public List<ThoiKhoaBieu> GetTKBByGiaoVien(int giaoVienID)
        {
            List<ThoiKhoaBieu> tkbList = new List<ThoiKhoaBieu>();
            string query = @"
                SELECT t.TKBID, t.LopHocID, t.Thu, t.Tiet, t.MonHocID, t.GiaoVienID,
                       l.TenLop, m.TenMon as TenMonHoc
                FROM ThoiKhoaBieu t
                LEFT JOIN Lop l ON t.LopHocID = l.LopID
                LEFT JOIN MonHoc m ON t.MonHocID = m.MonHocID
                WHERE t.GiaoVienID = @GiaoVienID 
                ORDER BY t.Thu, t.Tiet";

            using (SqlConnection connection = dbConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GiaoVienID", giaoVienID);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tkbList.Add(new ThoiKhoaBieu
                            {
                                TKBID = reader.GetInt32(reader.GetOrdinal("TKBID")),
                                LopHocID = reader.GetInt32(reader.GetOrdinal("LopHocID")),
                                Thu = reader.GetInt32(reader.GetOrdinal("Thu")),
                                Tiet = reader.GetInt32(reader.GetOrdinal("Tiet")),
                                MonHocID = reader.IsDBNull(reader.GetOrdinal("MonHocID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("MonHocID")),
                                GiaoVienID = reader.IsDBNull(reader.GetOrdinal("GiaoVienID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("GiaoVienID"))
                            });
                        }
                    }
                }
            }
            return tkbList;
        }

        // Thêm hoặc cập nhật TKB
        public bool SaveTKB(ThoiKhoaBieu tkb)
        {
            string query = @"
                IF EXISTS (SELECT 1 FROM ThoiKhoaBieu WHERE LopHocID = @LopHocID AND Thu = @Thu AND Tiet = @Tiet)
                    UPDATE ThoiKhoaBieu 
                    SET MonHocID = @MonHocID, GiaoVienID = @GiaoVienID
                    WHERE LopHocID = @LopHocID AND Thu = @Thu AND Tiet = @Tiet
                ELSE
                    INSERT INTO ThoiKhoaBieu (LopHocID, Thu, Tiet, MonHocID, GiaoVienID)
                    VALUES (@LopHocID, @Thu, @Tiet, @MonHocID, @GiaoVienID)";

            using (SqlConnection connection = dbConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LopHocID", tkb.LopHocID);
                    command.Parameters.AddWithValue("@Thu", tkb.Thu);
                    command.Parameters.AddWithValue("@Tiet", tkb.Tiet);
                    command.Parameters.AddWithValue("@MonHocID", tkb.MonHocID ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@GiaoVienID", tkb.GiaoVienID ?? (object)DBNull.Value);
                    
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        // Xóa TKB theo lớp
        public bool DeleteTKBByLop(int lopHocID)
        {
            string query = "DELETE FROM ThoiKhoaBieu WHERE LopHocID = @LopHocID";
            
            using (SqlConnection connection = dbConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LopHocID", lopHocID);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    // Trả về true nếu xóa thành công hoặc không có bản ghi nào để xóa
                    return rowsAffected >= 0;
                }
            }
        }

        // Tạo TKB mặc định cho lớp (Thứ 2-7, mỗi ngày 7 tiết)
        public bool CreateDefaultTKBForLop(int lopHocID)
        {
            using (SqlConnection connection = dbConnection.GetConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Tạo TKB mới (Thứ 2-7, mỗi ngày 7 tiết)
                        string insertQuery = @"
                            INSERT INTO ThoiKhoaBieu (LopHocID, Thu, Tiet, MonHocID, GiaoVienID)
                            VALUES (@LopHocID, @Thu, @Tiet, @MonHocID, @GiaoVienID)";

                        for (int thu = 2; thu <= 7; thu++) // Thứ 2-7
                        {
                            for (int tiet = 1; tiet <= 7; tiet++) // 7 tiết mỗi ngày
                            {
                                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection, transaction))
                                {
                                    insertCommand.Parameters.AddWithValue("@LopHocID", lopHocID);
                                    insertCommand.Parameters.AddWithValue("@Thu", thu);
                                    insertCommand.Parameters.AddWithValue("@Tiet", tiet);
                                    
                                    // Tiết 1 thứ 2: Chào cờ, Tiết 2 thứ 2: SHCN
                                    if (thu == 2 && tiet == 1)
                                    {
                                        insertCommand.Parameters.AddWithValue("@MonHocID", DBNull.Value);
                                        insertCommand.Parameters.AddWithValue("@GiaoVienID", DBNull.Value);
                                    }
                                    else if (thu == 2 && tiet == 2)
                                    {
                                        insertCommand.Parameters.AddWithValue("@MonHocID", DBNull.Value);
                                        insertCommand.Parameters.AddWithValue("@GiaoVienID", DBNull.Value);
                                    }
                                    else
                                    {
                                        insertCommand.Parameters.AddWithValue("@MonHocID", DBNull.Value);
                                        insertCommand.Parameters.AddWithValue("@GiaoVienID", DBNull.Value);
                                    }
                                    
                                    insertCommand.ExecuteNonQuery();
                                }
                            }
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        // Lấy thống kê giáo viên theo lớp
        public DataTable GetThongKeGiaoVienByLop(int lopHocID)
        {
            string query = @"
                SELECT 
                    gv.GiaoVienID,
                    gv.HoTen,
                    m.TenMon as TenMonHoc,
                    COUNT(CASE WHEN t.MonHocID IS NOT NULL AND t.GiaoVienID IS NOT NULL THEN 1 END) as SoTietThucTe,
                    ISNULL(pc.SoTiet, 0) as SoTietPhanCong
                FROM GiaoVien gv
                INNER JOIN PhanCong pc ON gv.GiaoVienID = pc.GiaoVienID AND pc.LopID = @LopHocID
                LEFT JOIN MonHoc m ON pc.MonHocID = m.MonHocID
                LEFT JOIN ThoiKhoaBieu t ON gv.GiaoVienID = t.GiaoVienID 
                    AND t.LopHocID = @LopHocID 
                    AND t.MonHocID = pc.MonHocID
                GROUP BY gv.GiaoVienID, gv.HoTen, m.TenMon, pc.SoTiet
                ORDER BY gv.HoTen, m.TenMon";

            using (SqlConnection connection = dbConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LopHocID", lopHocID);
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        // Lấy thống kê tiết theo môn của giáo viên
        public DataTable GetThongKeTietByGiaoVien(int giaoVienID)
        {
            string query = @"
                SELECT 
                    m.TenMon as TenMonHoc,
                    COUNT(CASE WHEN t.MonHocID IS NOT NULL AND t.GiaoVienID IS NOT NULL THEN 1 END) as SoTietThucTe,
                    ISNULL(pc.SoTiet, 0) as SoTietPhanCong
                FROM MonHoc m
                INNER JOIN PhanCong pc ON m.MonHocID = pc.MonHocID AND pc.GiaoVienID = @GiaoVienID
                LEFT JOIN ThoiKhoaBieu t ON m.MonHocID = t.MonHocID AND t.GiaoVienID = @GiaoVienID
                GROUP BY m.MonHocID, m.TenMon, pc.SoTiet
                ORDER BY m.TenMon";

            using (SqlConnection connection = dbConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GiaoVienID", giaoVienID);
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

    }
}
