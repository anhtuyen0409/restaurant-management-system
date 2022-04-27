using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THD_DoAnCuoiKi.DTO
{
    class NhanVienDTO
    {
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string TenTaiKhoan { get; set; }
    }
}
