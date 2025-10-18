using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJCNPM.Mod
{
    public class TaiKhoan
    {
        public string TenTK { get; set; }      // Khóa chính (username)
        public string MatKhau { get; set; }    // Khuyến nghị: lưu hash, không lưu plaintext
        public bool TrangThai { get; set; }    // true=hoạt động, false=khóa
        public int RoleID { get; set; }
    }
}
