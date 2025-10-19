using PJCNPM.DAL.Admin;
using PJCNPM.Mod;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace PJCNPM.BLL.Admin
{
    public class PhanCongBLL
    {
        private ThongTinNghiepVuGVDB _nghiepVuDB;
        private GiaoVienDB _giaoVienDB;
        private PhanCongDayDB _phanCongDB;
        private LopDB _lopDB;
        private MonHocDB _monHocDB;

        public PhanCongBLL()
        {
            _nghiepVuDB = new ThongTinNghiepVuGVDB();
            _giaoVienDB = new GiaoVienDB();
            _phanCongDB = new PhanCongDayDB();
            _lopDB = new LopDB();
            _monHocDB = new MonHocDB();
        }

        public DataTable LoadThongTinNghiepVuGV()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NghiepVuID", typeof(int));
            dt.Columns.Add("GiaoVienID", typeof(int));
            dt.Columns.Add("Họ tên");
            dt.Columns.Add("Dạy (Lớp:Môn)");
            dt.Columns.Add("Số tiết tối đa");
            dt.Columns.Add("Là chủ nhiệm");
            dt.Columns.Add("Lớp CN");

            var dsNV = _nghiepVuDB.GetAllThongTinNghiepVuGV();
            var dsGV = _giaoVienDB.GetAllGiaoVien();
            var dsPCD = _phanCongDB.GetAllPhanCongDay();
            var dsLop = _lopDB.GetAllLopBasic();
            var dsMon = _monHocDB.GetAllMonHoc();

            var mapTenGV = dsGV.ToDictionary(g => g.GiaoVienID, g => g.HoTen ?? "");
            var mapTenLop = dsLop.ToDictionary(l => l.LopID, l => l.TenLop ?? "");
            var mapTenMon = dsMon.ToDictionary(m => m.MonHocID, m => m.TenMon ?? "");

            foreach (var nv in dsNV)
            {
                int gvID = nv.GiaoVienID;
                string hoTen = mapTenGV.ContainsKey(gvID) ? mapTenGV[gvID] : "Chưa có";

                var pcs = dsPCD.Where(p => p.GiaoVienID == gvID).ToList();
                var pcsStr = pcs.Select(p =>
                {
                    var tenLop = mapTenLop.ContainsKey(p.LopID) ? mapTenLop[p.LopID] : $"Lop {p.LopID}";
                    var tenMon = mapTenMon.ContainsKey(p.MonHocID) ? mapTenMon[p.MonHocID] : $"Mon {p.MonHocID}";
                    return $"{tenLop}:{tenMon}";
                });
                string dayStr = string.Join(", ", pcsStr);

                string laChuNhiem = (nv.LaChuNhiem == true) ? "Có" : "Không";
                string lopCN = (nv.LaChuNhiem == true && nv.LopChuNhiemID.HasValue)
                               ? (mapTenLop.ContainsKey(nv.LopChuNhiemID.Value) ? mapTenLop[nv.LopChuNhiemID.Value] : nv.LopChuNhiemID.Value.ToString())
                               : "Chưa có";

                dt.Rows.Add(
                    nv.NghiepVuID,
                    gvID,
                    hoTen,
                    dayStr,
                    nv.SoTietToiDa?.ToString() ?? "Chưa có",
                    laChuNhiem,
                    lopCN
                );
            }

            return dt;
        }

        public List<Mod.GiaoVien> LoadGiaoVienCombo()
        {
            return _giaoVienDB.GetAllGiaoVien();
        }

        public List<Lop> LoadLopCombo()
        {
            return _lopDB.GetAllLopActive();
        }

        public List<MonHoc> LoadMonCombo()
        {
            return _monHocDB.GetAllMonHocActive();
        }

        public List<MonHoc> LoadMonComboByLop(int lopID)
        {
            if (lopID <= 0)
                return new List<MonHoc>();

            var list = new List<MonHoc>();
            using (var conn = new DBconnection().GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT DISTINCT m.MonHocID, m.TenMon, m.TrangThai
                    FROM MonHoc m
                    INNER JOIN PhanCong p ON m.MonHocID = p.MonHocID
                    WHERE p.LopID = @LopID AND (m.TrangThai = 1 OR m.TrangThai IS NULL)
                    ORDER BY m.TenMon";
                
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@LopID", lopID);
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            bool trangThai = false; // Default value
                            if (!r.IsDBNull(r.GetOrdinal("TrangThai")))
                            {
                                trangThai = r.GetBoolean(r.GetOrdinal("TrangThai"));
                            }

                            list.Add(new Mod.MonHoc
                            {
                                MonHocID = r.GetInt32(r.GetOrdinal("MonHocID")),
                                TenMon = r["TenMon"] as string ?? string.Empty,
                                TrangThai = trangThai
                            });
                        }
                    }
                }
            }
            return list;
        }

        public ThongTinNghiepVuGV LoadNghiepVuForSelectedTeacher(int selectedTeacherID)
        {
            if (selectedTeacherID <= 0)
                return null;

            return _nghiepVuDB.GetByGiaoVienID(selectedTeacherID);
        }

        public DataTable LoadAssignmentsForSelectedTeacher(int selectedTeacherID, bool showInactiveClasses = false)
        {
            var dt = new DataTable();
            dt.Columns.Add("Lớp");
            dt.Columns.Add("Môn");
            dt.Columns.Add("Số tiết");
            dt.Columns.Add("Trạng thái lớp");
            dt.Columns.Add("LopID", typeof(int));
            dt.Columns.Add("MonHocID", typeof(int));

            if (selectedTeacherID <= 0)
            {
                return dt;
            }

            var list = _phanCongDB.GetByGiaoVienID(selectedTeacherID);

            var lopList = _lopDB.GetAllLop();
            var mapLop = new Dictionary<int, (string TenLop, bool? DaKetThuc)>();
            foreach (var l in lopList) 
            {
                mapLop[l.LopID] = (l.TenLop ?? "", l.DaKetThuc);
            }

            var monList = _monHocDB.GetAllMonHoc();
            var mapMon = new Dictionary<int, string>();
            foreach (var m in monList) mapMon[m.MonHocID] = m.TenMon ?? "";

            foreach (var p in list)
            {
                if (mapLop.TryGetValue(p.LopID, out var lopInfo))
                {
                    bool isActive = lopInfo.DaKetThuc == false || lopInfo.DaKetThuc == null;
                    
                    // Nếu không hiển thị lớp không hoạt động và lớp này không hoạt động thì bỏ qua
                    if (!showInactiveClasses && !isActive)
                        continue;

                    string trangThaiLop = isActive ? "Đang hoạt động" : "Đã kết thúc";
                    
                    dt.Rows.Add(
                        lopInfo.TenLop,
                        mapMon.TryGetValue(p.MonHocID, out var tm) ? tm : $"Mon {p.MonHocID}",
                        p.SoTiet?.ToString() ?? "",
                        trangThaiLop,
                        p.LopID,
                        p.MonHocID
                    );
                }
            }

            return dt;
        }

        public bool AddPhanCong(int selectedTeacherID, int lopID, int monID, int? soTiet = null)
        {
            var p = new PhanCongDay
            {
                GiaoVienID = selectedTeacherID,
                LopID = lopID,
                MonHocID = monID,
                SoTiet = soTiet
            };
            
            bool success = _phanCongDB.Insert(p);
            
            // Nếu thêm phân công thành công, tự động gán môn cho học sinh
            if (success)
            {
                AutoAssignSubjectsToStudents(lopID, monID);
            }
            
            return success;
        }

        public bool UpdatePhanCong(int selectedTeacherID, int oldLopID, int oldMonID, int newLopID, int newMonID, int? newSoTiet = null)
        {
            var oldP = new PhanCongDay
            {
                GiaoVienID = selectedTeacherID,
                LopID = oldLopID,
                MonHocID = oldMonID
            };
            
            var newP = new PhanCongDay
            {
                GiaoVienID = selectedTeacherID,
                LopID = newLopID,
                MonHocID = newMonID,
                SoTiet = newSoTiet
            };
            
            bool success = _phanCongDB.Update(oldP, newP);
            
            // Nếu cập nhật thành công và có thay đổi lớp hoặc môn, gán môn cho học sinh lớp mới
            if (success && (oldLopID != newLopID || oldMonID != newMonID))
            {
                AutoAssignSubjectsToStudents(newLopID, newMonID);
            }
            
            return success;
        }

        public bool DeletePhanCong(int selectedTeacherID, int lopID, int monID)
        {
            var p = new PhanCongDay
            {
                GiaoVienID = selectedTeacherID,
                LopID = lopID,
                MonHocID = monID
            };
            
            bool success = _phanCongDB.Delete(p);
            
            // Nếu xóa phân công thành công, kiểm tra xem còn phân công nào khác cho môn này trong lớp không
            if (success)
            {
                // Kiểm tra xem còn phân công nào khác cho môn này trong lớp không
                var remainingAssignments = _phanCongDB.GetByLopAndMon(lopID, monID);
                if (remainingAssignments == null || remainingAssignments.Count == 0)
                {
                    // Không còn phân công nào cho môn này trong lớp, xóa bản điểm
                    DeleteDiemForSubjectInClass(lopID, monID);
                }
            }
            
            return success;
        }

        // Xóa bản điểm của tất cả học sinh trong lớp cho môn học cụ thể
        private bool DeleteDiemForSubjectInClass(int lopID, int monHocID)
        {
            try
            {
                using (var conn = new DBconnection().GetConnection())
                {
                    conn.Open();
                    string query = @"
                        DELETE FROM Diem 
                        WHERE LopID = @LopID AND MonHocID = @MonHocID";
                    
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LopID", lopID);
                        cmd.Parameters.AddWithValue("@MonHocID", monHocID);
                        return cmd.ExecuteNonQuery() >= 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public bool SaveNghiepVuGV(int selectedTeacherID, int? soTietToiDa, bool? laChuNhiem, int? lopCN)
        {
            var info = new ThongTinNghiepVuGV
            {
                GiaoVienID = selectedTeacherID,
                SoTietToiDa = soTietToiDa,
                LaChuNhiem = laChuNhiem,
                LopChuNhiemID = lopCN
            };

            return _nghiepVuDB.Upsert(info);
        }

        public bool DeleteNghiepVuAndAssignmentsByGV(int giaoVienID)
        {
            return _nghiepVuDB.DeleteNghiepVuAndAssignmentsByGV(giaoVienID);
        }

        // Lấy danh sách năm học có phân công
        public List<string> GetNamHocList()
        {
            var namHocList = new List<string>();
            using (var conn = new DBconnection().GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT DISTINCT l.NamHoc 
                    FROM Lop l
                    INNER JOIN PhanCong p ON l.LopID = p.LopID
                    WHERE l.NamHoc IS NOT NULL
                    ORDER BY l.NamHoc DESC";
                
                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        namHocList.Add(reader["NamHoc"].ToString());
                    }
                }
            }
            return namHocList;
        }

        // Lấy danh sách học kỳ theo năm học
        public List<int> GetHocKyList(string namHoc)
        {
            var hocKyList = new List<int>();
            using (var conn = new DBconnection().GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT DISTINCT l.HocKi 
                    FROM Lop l
                    INNER JOIN PhanCong p ON l.LopID = p.LopID
                    WHERE l.NamHoc = @NamHoc AND l.HocKi IS NOT NULL
                    ORDER BY l.HocKi";
                
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NamHoc", namHoc);
                    using (var reader = cmd.ExecuteReader())
                    {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        var value = reader[0];
                        if (value != null && int.TryParse(value.ToString(), out int hocKy))
                        {
                            hocKyList.Add(hocKy);
                        }
                    }
                }
                    }
                }
            }
            return hocKyList;
        }

        // Lấy phân công theo năm học và kỳ học
        public DataTable LoadAssignmentsBySemester(string namHoc, int? hocKy = null)
        {
            var dt = new DataTable();
            dt.Columns.Add("Giáo viên");
            dt.Columns.Add("Lớp");
            dt.Columns.Add("Môn học");
            dt.Columns.Add("Số tiết");
            dt.Columns.Add("Năm học");
            dt.Columns.Add("Học kỳ");
            dt.Columns.Add("Trạng thái lớp");
            dt.Columns.Add("GiaoVienID", typeof(int));
            dt.Columns.Add("LopID", typeof(int));
            dt.Columns.Add("MonHocID", typeof(int));

            using (var conn = new DBconnection().GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        gv.HoTen as TenGiaoVien,
                        l.TenLop,
                        mh.TenMon,
                        pc.SoTiet,
                        l.NamHoc,
                        l.HocKi,
                        CASE WHEN l.DaKetThuc = 1 THEN N'Đã kết thúc' ELSE N'Đang học' END AS TrangThaiLop,
                        pc.GiaoVienID,
                        pc.LopID,
                        pc.MonHocID
                    FROM PhanCong pc
                    INNER JOIN GiaoVien gv ON pc.GiaoVienID = gv.GiaoVienID
                    INNER JOIN Lop l ON pc.LopID = l.LopID
                    INNER JOIN MonHoc mh ON pc.MonHocID = mh.MonHocID
                    WHERE l.NamHoc = @NamHoc
                    AND (@HocKy IS NULL OR l.HocKi = @HocKy)
                    ORDER BY l.TenLop, gv.HoTen, mh.TenMon";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NamHoc", namHoc);
                    cmd.Parameters.AddWithValue("@HocKy", hocKy ?? (object)DBNull.Value);
                    
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dt.Rows.Add(
                                reader["TenGiaoVien"],
                                reader["TenLop"],
                                reader["TenMon"],
                                reader["SoTiet"]?.ToString() ?? "",
                                reader["NamHoc"],
                                reader["HocKi"]?.ToString() ?? "",
                                reader["TrangThaiLop"],
                                reader["GiaoVienID"],
                                reader["LopID"],
                                reader["MonHocID"]
                            );
                        }
                    }
                }
            }

            return dt;
        }

        // Tự động gán môn cho tất cả học sinh trong lớp khi có phân công mới
        public bool AutoAssignSubjectsToStudents(int lopID, int monHocID)
        {
            try
            {
                using (var conn = new DBconnection().GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Lấy danh sách học sinh trong lớp (chỉ học sinh đang học)
                            string getStudentsQuery = @"
                                SELECT DISTINCT hs.HocSinhID 
                                FROM HocSinh hs
                                INNER JOIN HocSinh_Lop hl ON hs.HocSinhID = hl.HocSinhID
                                WHERE hl.LopID = @LopID AND hs.TrangThai = 1";

                            var studentIds = new List<int>();
                            using (var cmd = new SqlCommand(getStudentsQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@LopID", lopID);
                                using (var reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        if (!reader.IsDBNull(0))
                                        {
                                            var value = reader[0];
                                            if (value != null && int.TryParse(value.ToString(), out int hocSinhID))
                                            {
                                                studentIds.Add(hocSinhID);
                                            }
                                        }
                                    }
                                }
                            }

                            // Thêm điểm trống cho môn học mới cho tất cả học sinh trong lớp
                            // Chỉ thêm nếu chưa có bản điểm cho môn này
                            string insertDiemQuery = @"
                                INSERT INTO Diem (HocSinhID, LopID, MonHocID, TX1, TX2, TX3, TX4, GiuaKy, CuoiKy)
                                SELECT @HocSinhID, @LopID, @MonHocID, NULL, NULL, NULL, NULL, NULL, NULL
                                WHERE NOT EXISTS (
                                    SELECT 1 FROM Diem 
                                    WHERE HocSinhID = @HocSinhID 
                                    AND LopID = @LopID 
                                    AND MonHocID = @MonHocID
                                )";

                            foreach (int hocSinhID in studentIds)
                            {
                                using (var cmd = new SqlCommand(insertDiemQuery, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@HocSinhID", hocSinhID);
                                    cmd.Parameters.AddWithValue("@LopID", lopID);
                                    cmd.Parameters.AddWithValue("@MonHocID", monHocID);
                                    cmd.ExecuteNonQuery();
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
            catch
            {
                return false;
            }
        }

        // Tự động tạo bản điểm cho tất cả học sinh trong lớp dựa trên phân công hiện tại
        public bool AutoCreateDiemForAllStudentsInClass(int lopID)
        {
            try
            {
                using (var conn = new DBconnection().GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Lấy danh sách học sinh trong lớp
                            string getStudentsQuery = @"
                                SELECT DISTINCT hs.HocSinhID 
                                FROM HocSinh hs
                                INNER JOIN HocSinh_Lop hl ON hs.HocSinhID = hl.HocSinhID
                                WHERE hl.LopID = @LopID AND hs.TrangThai = 1";

                            var studentIds = new List<int>();
                            using (var cmd = new SqlCommand(getStudentsQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@LopID", lopID);
                                using (var reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        if (!reader.IsDBNull(0))
                                        {
                                            var value = reader[0];
                                            if (value != null && int.TryParse(value.ToString(), out int hocSinhID))
                                            {
                                                studentIds.Add(hocSinhID);
                                            }
                                        }
                                    }
                                }
                            }

                            // Lấy danh sách môn học được phân công cho lớp
                            string getSubjectsQuery = @"
                                SELECT DISTINCT MonHocID 
                                FROM PhanCong 
                                WHERE LopID = @LopID";

                            var subjectIds = new List<int>();
                            using (var cmd = new SqlCommand(getSubjectsQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@LopID", lopID);
                                using (var reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        if (!reader.IsDBNull(0))
                                        {
                                            var value = reader[0];
                                            if (value != null && int.TryParse(value.ToString(), out int monHocID))
                                            {
                                                subjectIds.Add(monHocID);
                                            }
                                        }
                                    }
                                }
                            }

                            // Tạo bản điểm cho tất cả học sinh với tất cả môn được phân công
                            string insertDiemQuery = @"
                                INSERT INTO Diem (HocSinhID, LopID, MonHocID, TX1, TX2, TX3, TX4, GiuaKy, CuoiKy)
                                SELECT @HocSinhID, @LopID, @MonHocID, NULL, NULL, NULL, NULL, NULL, NULL
                                WHERE NOT EXISTS (
                                    SELECT 1 FROM Diem 
                                    WHERE HocSinhID = @HocSinhID 
                                    AND LopID = @LopID 
                                    AND MonHocID = @MonHocID
                                )";

                            foreach (int hocSinhID in studentIds)
                            {
                                foreach (int monHocID in subjectIds)
                                {
                                    using (var cmd = new SqlCommand(insertDiemQuery, conn, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@HocSinhID", hocSinhID);
                                        cmd.Parameters.AddWithValue("@LopID", lopID);
                                        cmd.Parameters.AddWithValue("@MonHocID", monHocID);
                                        cmd.ExecuteNonQuery();
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
            catch
            {
                return false;
            }
        }
    }
}
