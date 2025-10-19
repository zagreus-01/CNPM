using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJCNPM.DAL.Admin;
using PJCNPM.Mod;

namespace PJCNPM.BLL.Admin
{
    public class ThoiKhoaBieuBLL
    {
        private ThoiKhoaBieuDAL tkbDAL;
        private LopDB lopDAL;
        private GiaoVienDB giaoVienDAL;
        private MonHocDB monHocDAL;
        private PhanCongDayDB phanCongDAL;

        public ThoiKhoaBieuBLL()
        {
            tkbDAL = new ThoiKhoaBieuDAL();
            lopDAL = new LopDB();
            giaoVienDAL = new GiaoVienDB();
            monHocDAL = new MonHocDB();
            phanCongDAL = new PhanCongDayDB();
        }

        // Lấy danh sách lớp học
        public List<Lop> GetDanhSachLop()
        {
            return lopDAL.GetAllLop();
        }

        // Lấy danh sách lớp đang hoạt động
        public List<Lop> GetDanhSachLopActive()
        {
            return lopDAL.GetAllLopActive();
        }

        // Lấy danh sách giáo viên
        public List<Mod.GiaoVien> GetDanhSachGiaoVien()
        {
            return giaoVienDAL.GetAllGiaoVien();
        }

        // Lấy danh sách môn học
        public List<MonHoc> GetDanhSachMonHoc()
        {
            return monHocDAL.GetAllMonHoc();
        }

        // Lấy TKB theo lớp
        public List<ThoiKhoaBieu> GetTKBByLop(int lopHocID)
        {
            return tkbDAL.GetTKBByLop(lopHocID);
        }

        // Lấy TKB theo giáo viên
        public List<ThoiKhoaBieu> GetTKBByGiaoVien(int giaoVienID)
        {
            return tkbDAL.GetTKBByGiaoVien(giaoVienID);
        }

        // Lưu TKB
        public bool SaveTKB(ThoiKhoaBieu tkb)
        {
            return tkbDAL.SaveTKB(tkb);
        }

        // Tạo TKB mặc định cho lớp
        public bool CreateDefaultTKBForLop(int lopHocID)
        {
            return tkbDAL.CreateDefaultTKBForLop(lopHocID);
        }

        // Tự động tạo TKB cho tất cả lớp đang hoạt động
        public bool AutoGenerateTKBForAllClasses()
        {
            try
            {
                var danhSachLop = GetDanhSachLopActive(); // Chỉ lấy lớp đang hoạt động
                int successCount = 0;
                int failCount = 0;
                
                foreach (var lop in danhSachLop)
                {
                    if (CanCreateTKBForLop(lop.LopID))
                    {
                        if (AutoArrangeTKB(lop.LopID))
                        {
                            successCount++;
                        }
                        else
                        {
                            failCount++;
                        }
                    }
                    else
                    {
                        failCount++;
                    }
                }
                
                return successCount > 0;
            }
            catch (Exception)
            {
                // Log error if needed
                return false;
            }
        }

        // Thuật toán sắp xếp TKB tự động dựa trên logic stored procedure
        public bool AutoArrangeTKB(int lopHocID)
        {
            try
            {
                // Kiểm tra xem có phân công dạy cho lớp không
                var phanCongList = phanCongDAL.GetPhanCongByLop(lopHocID);
                if (phanCongList == null || phanCongList.Count == 0)
                {
                    throw new Exception("Không có phân công dạy nào cho lớp này");
                }

                // Xóa TKB cũ trước khi tạo mới
                if (!tkbDAL.DeleteTKBByLop(lopHocID))
                {
                    throw new Exception("Không thể xóa thời khóa biểu cũ");
                }

                // Tạo TKB mặc định (Thứ 2-7, mỗi ngày 7 tiết)
                if (!CreateDefaultTKBForLop(lopHocID))
                {
                    throw new Exception("Không thể tạo thời khóa biểu mặc định");
                }

                // Sắp xếp TKB theo thuật toán
                var tkbList = GetTKBByLop(lopHocID);
                if (tkbList == null || tkbList.Count == 0)
                {
                    throw new Exception("Không thể load thời khóa biểu mặc định");
                }

                var arrangedTKB = ArrangeTKBAlgorithm(phanCongList, tkbList);

                // Lưu TKB đã sắp xếp
                foreach (var tkb in arrangedTKB)
                {
                    if (!SaveTKB(tkb))
                    {
                        throw new Exception($"Không thể lưu tiết học thứ {tkb.Thu}, tiết {tkb.Tiet}");
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                // Log error và throw lại để UI có thể hiển thị thông báo chi tiết
                throw new Exception($"Lỗi khi tạo thời khóa biểu: {ex.Message}", ex);
            }
        }

        // Thuật toán sắp xếp TKB dựa trên logic stored procedure
        private List<ThoiKhoaBieu> ArrangeTKBAlgorithm(List<PhanCongDay> phanCongList, List<ThoiKhoaBieu> tkbList)
        {
            var result = new List<ThoiKhoaBieu>();
            
            // Tạo bản sao của tkbList để không thay đổi dữ liệu gốc
            var availableSlots = tkbList.Where(t => !t.MonHocID.HasValue && !t.GiaoVienID.HasValue).ToList();
            
            // Debug: Log số lượng slot có sẵn
            System.Diagnostics.Debug.WriteLine($"Số slot có sẵn: {availableSlots.Count}");
            
            // Debug: Log số lượng phân công
            System.Diagnostics.Debug.WriteLine($"Số phân công: {phanCongList.Count}");
            
            // Duyệt qua từng phân công dạy
            foreach (var phanCong in phanCongList)
            {
                int soTietDaPhan = 0;
                int soTietCanPhan = phanCong.SoTiet ?? 2; // Sử dụng số tiết từ phân công, mặc định 2 tiết/tuần
                
                // Debug: Log thông tin phân công
                System.Diagnostics.Debug.WriteLine($"Phân công: GV {phanCong.GiaoVienID}, Môn {phanCong.MonHocID}, Số tiết: {soTietCanPhan}");
                
                // Phân bổ số tiết cho môn học này
                while (soTietDaPhan < soTietCanPhan && availableSlots.Count > 0)
                {
                    // Tìm slot phù hợp (không phải thứ 2 tiết 1,2 và giáo viên không bị trùng lịch)
                    var bestSlot = FindBestSlot(availableSlots, phanCong.GiaoVienID, phanCong.MonHocID);
                    
                    if (bestSlot != null)
                    {
                        // Cập nhật slot với môn học và giáo viên
                        bestSlot.MonHocID = phanCong.MonHocID;
                        bestSlot.GiaoVienID = phanCong.GiaoVienID;
                        
                        // Debug: Log slot được phân bổ
                        System.Diagnostics.Debug.WriteLine($"Phân bổ: Thứ {bestSlot.Thu}, Tiết {bestSlot.Tiet} - GV {phanCong.GiaoVienID}, Môn {phanCong.MonHocID}");
                        
                        // Loại bỏ slot đã được phân công
                        availableSlots.Remove(bestSlot);
                        soTietDaPhan++;
                    }
                    else
                    {
                        // Debug: Log không tìm được slot
                        System.Diagnostics.Debug.WriteLine($"Không tìm được slot cho GV {phanCong.GiaoVienID}, Môn {phanCong.MonHocID}");
                        
                        // Không tìm được slot phù hợp, dừng phân bổ cho môn này
                        break;
                    }
                }
            }
            
            return tkbList;
        }

        // Tìm slot tốt nhất cho phân công dạy
        private ThoiKhoaBieu FindBestSlot(List<ThoiKhoaBieu> availableSlots, int giaoVienID, int monHocID)
        {
            // Sắp xếp slots theo thứ tự ưu tiên (thứ 2-7, tiết 1-7)
            // Loại bỏ thứ 2 tiết 1 (Chào cờ) và tiết 2 (SHCN)
            var sortedSlots = availableSlots
                .Where(s => !(s.Thu == 2 && (s.Tiet == 1 || s.Tiet == 2))) // Né tiết 1,2 thứ 2
                .OrderBy(s => s.Thu)
                .ThenBy(s => s.Tiet)
                .ToList();

            foreach (var slot in sortedSlots)
            {
                // Kiểm tra giáo viên có bị trùng lịch không (cả trong cùng lớp và các lớp khác)
                bool isBusy = IsGiaoVienBusy(giaoVienID, slot.Thu, slot.Tiet);
                System.Diagnostics.Debug.WriteLine($"Kiểm tra GV {giaoVienID} - Thứ {slot.Thu}, Tiết {slot.Tiet}: {(isBusy ? "BẬN" : "RẢNH")}");
                
                if (!isBusy)
                {
                    return slot;
                }
            }

            return null;
        }

        // Kiểm tra giáo viên có bận không (trùng lịch với lớp khác)
        private bool IsGiaoVienBusy(int giaoVienID, int thu, int tiet)
        {
            try
            {
                // Kiểm tra trực tiếp trong database xem giáo viên có dạy ở thời điểm này không
                string query = @"
                    SELECT COUNT(*) 
                    FROM ThoiKhoaBieu 
                    WHERE GiaoVienID = @GiaoVienID 
                      AND Thu = @Thu 
                      AND Tiet = @Tiet";
                
                using (var conn = new DBconnection().GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@GiaoVienID", giaoVienID);
                        cmd.Parameters.AddWithValue("@Thu", thu);
                        cmd.Parameters.AddWithValue("@Tiet", tiet);
                        
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        // Lấy thống kê giáo viên theo lớp
        public DataTable GetThongKeGiaoVienByLop(int lopHocID)
        {
            return tkbDAL.GetThongKeGiaoVienByLop(lopHocID);
        }

        // Lấy thống kê tiết theo môn của giáo viên
        public DataTable GetThongKeTietByGiaoVien(int giaoVienID)
        {
            return tkbDAL.GetThongKeTietByGiaoVien(giaoVienID);
        }

        // Xóa TKB theo lớp
        public bool DeleteTKBByLop(int lopHocID)
        {
            return tkbDAL.DeleteTKBByLop(lopHocID);
        }

        // Lấy danh sách giáo viên được phân công dạy lớp
        public List<Mod.GiaoVien> GetGiaoVienDuocPhanCong(int lopHocID)
        {
            var phanCongList = phanCongDAL.GetPhanCongByLop(lopHocID);
            var giaoVienList = new List<Mod.GiaoVien>();
            var danhSachGiaoVien = GetDanhSachGiaoVien();
            
            foreach (var pc in phanCongList)
            {
                var giaoVien = danhSachGiaoVien.FirstOrDefault(g => g.GiaoVienID == pc.GiaoVienID);
                if (giaoVien != null && !giaoVienList.Any(g => g.GiaoVienID == giaoVien.GiaoVienID))
                {
                    giaoVienList.Add(giaoVien);
                }
            }
            
            return giaoVienList;
        }

        // Kiểm tra xem có thể tạo TKB cho lớp không
        public bool CanCreateTKBForLop(int lopHocID)
        {
            // Chỉ tạo TKB cho lớp đang hoạt động
            if (!IsLopActive(lopHocID))
                return false;
                
            var phanCongList = phanCongDAL.GetPhanCongByLop(lopHocID);
            return phanCongList != null && phanCongList.Count > 0;
        }

        // Lấy danh sách phân công theo lớp
        public List<PhanCongDay> GetPhanCongByLop(int lopHocID)
        {
            return phanCongDAL.GetPhanCongByLop(lopHocID);
        }

        // Kiểm tra xem lớp có đang hoạt động không
        public bool IsLopActive(int lopHocID)
        {
            var lop = lopDAL.GetLopByID(lopHocID);
            return lop != null && (lop.DaKetThuc == false || lop.DaKetThuc == null);
        }
    }
}
