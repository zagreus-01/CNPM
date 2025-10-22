using PJCNPM.DAL.Admin;
using PJCNPM.Mod;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PJCNPM.BLL.Admin
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDB _taiKhoanDB;
        private HocSinhDB _hocSinhDB;

        public TaiKhoanBLL()
        {
            _taiKhoanDB = new TaiKhoanDB();
            _hocSinhDB = new HocSinhDB();
        }

        public DataTable LoadHocSinhAccounts(string keyword = "")
        {
            var dt = _taiKhoanDB.SearchHocSinhAccounts(keyword);

            if (!dt.Columns.Contains("Chon"))
                dt.Columns.Add("Chon", typeof(bool));
            dt.Columns["Chon"].ReadOnly = false;
            foreach (DataRow row in dt.Rows)
                row["Chon"] = false;

            if (!dt.Columns.Contains("VaiTro"))
                dt.Columns.Add("VaiTro", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                var roleObj = row["RoleID"];
                int? role = roleObj == DBNull.Value ? (int?)null : Convert.ToInt32(roleObj);
                if (role == 2)
                    row["VaiTro"] = "Giáo viên";
                else if (role == 1)
                    row["VaiTro"] = "Admin";
                else if (role == 3)
                    row["VaiTro"] = "Học Sinh";
                else
                    row["VaiTro"] = "Chưa có vai trò";
            }

            return dt;
        }

        public DataTable LoadGiaoVienAccounts(string keyword = "")
        {
            var dt = _taiKhoanDB.SearchGiaoVienAccounts(keyword);

            if (!dt.Columns.Contains("Chon"))
                dt.Columns.Add("Chon", typeof(bool));
            dt.Columns["Chon"].ReadOnly = false;
            foreach (DataRow row in dt.Rows)
                row["Chon"] = false;

            if (!dt.Columns.Contains("VaiTro"))
                dt.Columns.Add("VaiTro", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                var roleObj = row["RoleID"];
                int? role = roleObj == DBNull.Value ? (int?)null : Convert.ToInt32(roleObj);
                if (role == 2)
                    row["VaiTro"] = "Giáo viên";
                else if (role == 1)
                    row["VaiTro"] = "Admin";
                else if (role == 3)
                    row["VaiTro"] = "Học Sinh";
                else
                    row["VaiTro"] = "Chưa có vai trò";
            }

            return dt;
        }

        public bool UpdateAccount(string tenTK, string matKhau, bool isActive, int? roleID)
        {
            return _taiKhoanDB.UpsertAccount(tenTK, matKhau, isActive, roleID);
        }

        public bool UpdateTenTKForHocSinh(int hocSinhID, string tenTK)
        {
            return _hocSinhDB.UpdateTenTK_ForHocSinh(hocSinhID, tenTK);
        }

        public int BulkUpdateRole(List<string> selectedUsers, int? role)
        {
            return _taiKhoanDB.BulkUpdateRole(selectedUsers, role);
        }

        public bool UpdateTrangThaiByTenTK(string tenTK, bool trangThai)
        {
            return _taiKhoanDB.UpdateTrangThaiByTenTK(tenTK, trangThai);
        }

        public int ParseTrangThai(object value)
        {
            try
            {
                if (value == null || value == DBNull.Value) return 1;
                if (value is bool b) return b ? 1 : 0;
                if (value is int i) return (i == 0) ? 0 : 1;

                var s = Convert.ToString(value)?.Trim().ToLowerInvariant() ?? "";
                if (s.Contains("hoạt") || s.Contains("hoat") || s.Contains("mở") || s.Contains("mo")) return 1;
                if (s.Contains("khóa") || s.Contains("khoá") || s.Contains("khoa") || s.Contains("đóng") || s.Contains("dong")) return 0;

                if (int.TryParse(s, out var n)) return (n == 0) ? 0 : 1;

                return 1;
            }
            catch { return 1; }
        }

        public int ToInt(object value, int defaultValue = 0)
        {
            try
            {
                if (value == null) return defaultValue;
                if (value is int i) return i;
                if (value is long l) return (int)l;
                if (value is bool b) return b ? 1 : 0;
                if (int.TryParse(Convert.ToString(value)?.Trim(), out var ii)) return ii;
                return defaultValue;
            }
            catch { return defaultValue; }
        }

        public int? ToNullableInt(object value)
        {
            try
            {
                if (value == null || value == DBNull.Value) return null;
                if (value is int i) return i;
                if (int.TryParse(Convert.ToString(value)?.Trim(), out var ii)) return ii;
                return null;
            }
            catch { return null; }
        }
    }
}
