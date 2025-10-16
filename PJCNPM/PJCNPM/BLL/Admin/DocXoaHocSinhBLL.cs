using System.Data;
using System.Linq;
using PJCNPM.DAL.Admin;

namespace PJCNPM.BLL.Admin
{
    internal class DocXoaHocSinhBLL
    {
        private readonly DocXoaHocSinhDAL dal = new DocXoaHocSinhDAL();

        // 🔹 Lấy danh sách toàn bộ học sinh (lọc theo lớp kết thúc hay không)
        public DataTable LayTatCaHocSinh(bool baoGomLopKetThuc = false)
        {
            return dal.LayTatCaHocSinh(baoGomLopKetThuc);
        }

        // 🔹 Lấy danh sách lớp (ẩn/hiện lớp đã kết thúc)
        public DataTable LayDanhSachLop(bool baoGomDaKetThuc = false)
        {
            return dal.LayDanhSachLop(baoGomDaKetThuc);
        }

        // 🔹 Lọc học sinh theo tên + lớp + trạng thái lớp (checkbox)
        public DataTable LocHocSinh(DataTable dt, string tuKhoa, string lopChon, bool hienThiLopDaKetThuc)
        {
            tuKhoa = tuKhoa?.Trim().ToLower() ?? "";
            lopChon = lopChon ?? "Tất cả";

            var filtered = dt.AsEnumerable()
                .Where(r =>
                    (lopChon == "Tất cả" || r["TenLop"].ToString() == lopChon) &&
                    (hienThiLopDaKetThuc || r["TrangThai"].ToString() != "Đã kết thúc") &&
                    r["HoTen"].ToString().ToLower().Contains(tuKhoa)
                );

            return filtered.Any() ? filtered.CopyToDataTable() : dt.Clone();
        }

        // 🔹 Xóa học sinh (gọi xuống DAL xử lý transaction)
        public bool XoaHocSinh(int hocSinhID)
        {
            return dal.XoaHocSinh(hocSinhID);
        }
    }
}
