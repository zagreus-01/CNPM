using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PJCNPM.DAL.Admin
{
    internal class XetDuyetDAL
    {
        private readonly DBConnection db = new DBConnection();

        // 🔹 Lấy danh sách yêu cầu chỉnh sửa học sinh
        public DataTable LayYeuCauChinhSuaHocSinh()
        {
            string sql = @"
                SELECT cs.HocSinhID, hs.HoTen AS HoTenCu, cs.HoTen AS HoTenMoi,
                       cs.NgaySinh, cs.GioiTinh, cs.DanToc, cs.TonGiao, cs.QueQuan, cs.TrangThaiYeuCau
                FROM ChinhSuaHocSinh cs
                INNER JOIN HocSinh hs ON cs.HocSinhID = hs.HocSinhID";
            return db.GetData(sql);
        }

        // 🔹 Lấy danh sách yêu cầu chỉnh sửa giáo viên
        public DataTable LayYeuCauChinhSuaGiaoVien()
        {
            string sql = @"
                SELECT cs.GiaoVienID, gv.HoTen AS HoTenCu, cs.HoTen AS HoTenMoi,
                       cs.NgaySinh, cs.GioiTinh, cs.CCCD, cs.Email, cs.DienThoai, cs.QueQuan, cs.TrangThaiYeuCau
                FROM ChinhSuaGiaoVien cs
                INNER JOIN GiaoVien gv ON cs.GiaoVienID = gv.GiaoVienID";
            return db.GetData(sql);
        }

        // 🔹 Duyệt hoặc từ chối yêu cầu (và luôn xóa yêu cầu sau khi xử lý)
        public bool CapNhatTrangThai(string loai, int id, string trangThai)
        {
            using (SqlConnection conn = new SqlConnection(
                @"Data Source=TUNG;Initial Catalog=PJCNPM;Integrated Security=True"))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // ✅ Nếu duyệt: cập nhật dữ liệu gốc
                    if (trangThai == "Đã duyệt")
                    {
                        if (loai == "Học sinh")
                        {
                            string sqlUpdate = @"
                                UPDATE HocSinh
                                SET HoTen = cs.HoTen,
                                    NgaySinh = cs.NgaySinh,
                                    GioiTinh = cs.GioiTinh,
                                    DanToc = cs.DanToc,
                                    TonGiao = cs.TonGiao,
                                    QueQuan = cs.QueQuan
                                FROM HocSinh hs
                                INNER JOIN ChinhSuaHocSinh cs ON hs.HocSinhID = cs.HocSinhID
                                WHERE cs.HocSinhID = @ID";
                            using (SqlCommand cmd = new SqlCommand(sqlUpdate, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@ID", id);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string sqlUpdate = @"
                                UPDATE GiaoVien
                                SET HoTen = cs.HoTen,
                                    NgaySinh = cs.NgaySinh,
                                    GioiTinh = cs.GioiTinh,
                                    CCCD = cs.CCCD,
                                    Email = cs.Email,
                                    DienThoai = cs.DienThoai,
                                    DanToc = cs.DanToc,
                                    TonGiao = cs.TonGiao,
                                    QueQuan = cs.QueQuan
                                FROM GiaoVien gv
                                INNER JOIN ChinhSuaGiaoVien cs ON gv.GiaoVienID = cs.GiaoVienID
                                WHERE cs.GiaoVienID = @ID";
                            using (SqlCommand cmd = new SqlCommand(sqlUpdate, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@ID", id);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // 📨 Gửi thông báo cho người yêu cầu
                    string nguoiNhanID = id.ToString();
                    int loaiNguoiNhan = (loai == "Học sinh") ? 2 : 3;

                    string tieuDe = "Kết quả xét duyệt yêu cầu chỉnh sửa";
                    string noiDung = trangThai == "Đã duyệt"
                        ? "✅ Yêu cầu chỉnh sửa thông tin của bạn đã được duyệt và cập nhật vào hệ thống."
                        : "❌ Yêu cầu chỉnh sửa thông tin của bạn đã bị từ chối. Vui lòng kiểm tra lại.";

                    string sqlThongBao = @"
                        INSERT INTO ThongBao (NguoiGuiID, LoaiNguoiGui, TieuDe, NoiDung, NgayGui)
                        VALUES ('ADMIN', 1, @TieuDe, @NoiDung, GETDATE());
                        DECLARE @TBID INT = SCOPE_IDENTITY();
                        INSERT INTO ThongBao_NguoiNhan (LoaiNguoiNhan, NguoiNhanID, ThongBaoID)
                        VALUES (@LoaiNguoiNhan, @NguoiNhanID, @TBID);";
                    using (SqlCommand cmd = new SqlCommand(sqlThongBao, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@LoaiNguoiNhan", loaiNguoiNhan);
                        cmd.Parameters.AddWithValue("@NguoiNhanID", nguoiNhanID);
                        cmd.Parameters.AddWithValue("@TieuDe", tieuDe);
                        cmd.Parameters.AddWithValue("@NoiDung", noiDung);
                        cmd.ExecuteNonQuery();
                    }

                    // ❌ Cuối cùng: XÓA yêu cầu chỉnh sửa (dù duyệt hay từ chối)
                    string sqlXoa = loai == "Học sinh"
                        ? "DELETE FROM ChinhSuaHocSinh WHERE HocSinhID = @ID"
                        : "DELETE FROM ChinhSuaGiaoVien WHERE GiaoVienID = @ID";
                    using (SqlCommand cmd = new SqlCommand(sqlXoa, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }

                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("❌ Lỗi khi xét duyệt: " + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
