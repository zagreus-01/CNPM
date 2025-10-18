using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJCNPM.Mod
{
    public class Lop
    {
        public int LopID { get; set; }
        public string TenLop { get; set; }
        public string NamHoc { get; set; }
        public int? HocKi { get; set; }
        public int? KhoiHoc { get; set; }
        public bool? DaKetThuc { get; set; }
        public int? GiaoVienID { get; set; }
    }
}
