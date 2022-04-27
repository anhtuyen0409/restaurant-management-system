using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THD_DoAnCuoiKi.DTO;
using THD_DoAnCuoiKi.DataContext;

namespace THD_DoAnCuoiKi.DataTier
{
    class ChiTietHoaDonDT
    {
        public List<ChiTietHoaDonDTO> LayDanhSach()
        {
            using (var dbContext = new QLNhaHang())
            {
                return (from cthd in dbContext.CTHDs
                        select new ChiTietHoaDonDTO()
                        {
                            
                            MaHD = cthd.MaHoaDon,
                            TenMon = cthd.MonAn.TenMon,
                            SoLuong = cthd.SoLuong,
                            ThanhTien = cthd.ThanhTien
                        }).ToList();
            }
        }

        public bool Them(CTHD cthd, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new QLNhaHang())
                {
                    dbContext.CTHDs.Add(cthd);
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

        public bool XoaChiTietHoaDon(int maChiTietHoaDon, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new QLNhaHang())
                {
                    var chitiethoadonDelete = dbContext.CTHDs.SingleOrDefault(s => s.MaCTHD == maChiTietHoaDon);
                    /*if (dbContext.CTHDs.Any(s => s.MaHoaDon == maHoaDon))
                    {
                        error = "Hóa đơn đã lưu, không thể xóa!!!";
                        return false;
                    }*/
                    if (chitiethoadonDelete == null)
                    {
                        error = "Dòng bạn muốn xóa không tồn tại!!";
                        return false;
                    }
                    dbContext.CTHDs.Remove(chitiethoadonDelete);
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

        internal List<ChiTietHoaDonDTO> LayDanhSachTheoMaHoaDon(int maHoaDonDangChon)
        {
            using (var dbContext = new QLNhaHang())
            {
                return (from cthd in dbContext.CTHDs
                        where cthd.MaHoaDon == maHoaDonDangChon
                        select new ChiTietHoaDonDTO()
                        {
                            MaHD = cthd.MaHoaDon,
                            TenMon = cthd.MonAn.TenMon,
                            SoLuong = cthd.SoLuong,
                            ThanhTien = cthd.ThanhTien
                            
                        }).ToList();
            }
        }
    }
}
