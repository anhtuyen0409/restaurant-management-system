using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THD_DoAnCuoiKi.DTO
{
    class ReportHoaDonDTO
    {
        public int MaHoaDon { get; set; }
        public DateTime NgayLap { get; set; }
        public string TenKhachHang { get; set; }
        public string NhanVienLap { get; set; }
        public int TongTien { get; set; }
    }
}
