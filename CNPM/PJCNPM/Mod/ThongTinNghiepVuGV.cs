using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJCNPM.Mod
{
    public class ThongTinNghiepVuGV
    {
        public int NghiepVuID { get; set; }          
        public int GiaoVienID { get; set; }          

        public int? SoTietToiDa { get; set; }      
        public bool? LaChuNhiem { get; set; }       
        public int? LopChuNhiemID { get; set; }
    }
}
