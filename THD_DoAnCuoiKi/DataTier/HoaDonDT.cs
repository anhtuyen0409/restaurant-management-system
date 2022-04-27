using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THD_DoAnCuoiKi.DTO;
using THD_DoAnCuoiKi.DataContext;

namespace THD_DoAnCuoiKi.DataTier
{
    class HoaDonDT
    {
        public List<HoaDonDTO> LayDanhSach()
        {
            using (var dbContext = new QLNhaHang())
            {
                return (from hd in dbContext.HoaDons
                        select new HoaDonDTO()
                        {
                            MaHoaDon = hd.MaHoaDon,
                            NgayLap = hd.NgayLap,
                            TenKhachHang = hd.KhachHang.TenKhachHang,
                            TenNhanVien = hd.NhanVien.TenNhanVien,
                            
                        }).ToList();
            }
        }

        public bool TaoMoiHoaDon(HoaDon hoadon, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new QLNhaHang())
                {
                    dbContext.HoaDons.Add(hoadon);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }

        public bool SuaHoaDon(HoaDon hoaDon, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new QLNhaHang())
                {
                    var hoadonUpdate = dbContext.HoaDons.SingleOrDefault(s => s.MaHoaDon == hoaDon.MaHoaDon);
                   /* if (dbContext.HoaDons.Any(s => s.MaHoaDon == mahoadon))
                    {
                        error = "Khách hàng đã có hóa đơn, không thể xóa!!!";
                        return false;
                    }*/
                    if (hoadonUpdate == null)
                    {
                        error = "Hóa đơn không tồn tại!!";
                        return false;
                    }
                    else
                    {
                        hoadonUpdate.MaKhachHang = hoaDon.MaKhachHang;
                        hoadonUpdate.MaNhanVien = hoaDon.MaNhanVien;
                        hoadonUpdate.NgayLap = hoaDon.NgayLap;
                        dbContext.SaveChanges();
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }


        public bool XoaHoaDon(int maHoaDon, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new QLNhaHang())
                {
                    var hoadonDelete = dbContext.HoaDons.SingleOrDefault(s => s.MaHoaDon == maHoaDon);
                    if (dbContext.CTHDs.Any(s => s.MaHoaDon == maHoaDon))
                    {
                        error = "Hóa đơn đã lưu, không thể xóa!!!";
                        return false;
                    }
                    if (hoadonDelete == null)
                    {
                        error = "Hóa đơn không tồn tại!!";
                        return false;
                    }
                    dbContext.HoaDons.Remove(hoadonDelete);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }
    }
}
