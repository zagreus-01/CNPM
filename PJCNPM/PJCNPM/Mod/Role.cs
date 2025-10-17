using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJCNPM.Mod
{
    public class Role
    {
        public int RoleID { get; set; }       // Khóa chính
        public string Ten { get; set; }       // Tên role (VD: Admin, Giáo viên, Học sinh)
        public bool TrangThai { get; set; }
    }
}
