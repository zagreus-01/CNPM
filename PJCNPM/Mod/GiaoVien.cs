using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PJCNPM.Mod
{
    public class GiaoVien
    {
        public int GiaoVienID { get; set; }
        public string HoTen { get; set; }
        public bool? GioiTinh { get; set; }
        public bool? TrangThai { get; set; }
        public string CCCD { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public bool? LaDoanVien { get; set; }
        public bool? LaDangVien { get; set; }
        public string NoiThuongTru { get; set; }
        public string QueQuan { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string TenTK { get; set; }
    }
}
