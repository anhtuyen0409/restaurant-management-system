using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THD_DoAnCuoiKi.DataContext;
using THD_DoAnCuoiKi.DTO;

namespace THD_DoAnCuoiKi.DataTier
{
    class KhachHangDT
    {
        public List<KhachHangDTO> LayDanhSach()
        {
            using (var dbContext = new QLNhaHang())
            {
                return (from kh in dbContext.KhachHangs
                        select new KhachHangDTO()
                        {
                            MaKH = kh.MaKhachHang,
                            TenKH = kh.TenKhachHang,
                            GioiTinh = kh.GioiTinh,
                            NamSinh = kh.NamSinh,
                            DiaChi = kh.DiaChi,
                            Email = kh.Email
                        }).ToList();
            }
        }
        public bool ThemKhachHang(KhachHang khachHang, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new QLNhaHang())
                {
                    dbContext.KhachHangs.Add(khachHang);
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

        public bool SuaKhachHang(KhachHang khachHang, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new QLNhaHang())
                {
                    var khachHangUpdate = dbContext.KhachHangs.SingleOrDefault(s => s.MaKhachHang == khachHang.MaKhachHang);
                    if (khachHangUpdate == null)
                    {
                        error = "Khách hàng không tồn tại!!";
                        return false;
                    }
                    else
                    {
                        khachHangUpdate.TenKhachHang = khachHang.TenKhachHang;
                        khachHangUpdate.GioiTinh = khachHang.GioiTinh;
                        khachHangUpdate.NamSinh = khachHang.NamSinh;
                        khachHangUpdate.DiaChi = khachHang.DiaChi;
                        khachHangUpdate.Email = khachHang.Email;
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

        public bool XoaKhachHang(int maKhachHang, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new QLNhaHang())
                {
                    var khachHangDelete = dbContext.KhachHangs.SingleOrDefault(s => s.MaKhachHang == maKhachHang);
                    if (dbContext.HoaDons.Any(s => s.MaKhachHang == maKhachHang))
                    {
                        error = "Khách hàng đã có hóa đơn, không thể xóa!!!";
                        return false;
                    }
                    if (khachHangDelete == null)
                    {
                        error = "Khách hàng không tồn tại!!";
                        return false;
                    }
                    dbContext.KhachHangs.Remove(khachHangDelete);
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
