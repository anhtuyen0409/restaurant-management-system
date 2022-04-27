using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THD_DoAnCuoiKi.DTO;
using THD_DoAnCuoiKi.DataContext;

namespace THD_DoAnCuoiKi.DataTier
{
    class ReportHoaDonDT
    {
        internal List<ReportHoaDonDTO> LayDanhSachHoaDonTheoMaKhachHang(int maKhachHang)
        {
            using (var dbContext = new QLNhaHang())
            {
                return (from hd in dbContext.HoaDons
                        where hd.MaKhachHang == maKhachHang
                        select new ReportHoaDonDTO()
                        {
                            MaHoaDon = hd.MaHoaDon,
                            NgayLap = hd.NgayLap,
                            TenKhachHang = hd.KhachHang.TenKhachHang,
                            NhanVienLap = hd.NhanVien.TenNhanVien,
                            TongTien = hd.CTHDs.Sum(s=>s.ThanhTien)
                            
                        }).ToList();
            }
        }

        /*public List<ReportHoaDonDTO> LayDanhSach()
        {
            using (var dbContext = new QLNhaHang())
            {
                return (from hd in dbContext.HoaDons
                        join cthd in dbContext.CTHDs on hd.MaHoaDon equals cthd.MaHoaDon
                        

                        select new ReportHoaDonDTO()
                        {
                            MaHoaDon = hd.MaHoaDon,
                            NgayLap = hd.NgayLap,
                            TenKhachHang = hd.KhachHang.TenKhachHang,
                            NhanVienLap = hd.NhanVien.TenNhanVien,
                            TongTien = hd.CTHDs.Sum(s => s.ThanhTien)
                        }).ToList();
            }
        }*/
    }
}
