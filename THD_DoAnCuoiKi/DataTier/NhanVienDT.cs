using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THD_DoAnCuoiKi.DTO;
using THD_DoAnCuoiKi.DataContext;

namespace THD_DoAnCuoiKi.DataTier
{
    class NhanVienDT
    {
        public List<NhanVienDTO> LayDanhSach()
        {
            using (var dbContext = new QLNhaHang())
            {
                return (from nv in dbContext.NhanViens
                        select new NhanVienDTO()
                        {
                            MaNhanVien = nv.MaNhanVien,
                            TenNhanVien = nv.TenNhanVien,
                            GioiTinh = nv.GioiTinh,
                            NamSinh = nv.NamSinh,
                            DiaChi = nv.DiaChi,
                            Email = nv.Email,
                            TenTaiKhoan = nv.TenDangNhap
                        }).ToList();
            }
        }
        public bool ThemNhanVien(NhanVien nhanvien, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new QLNhaHang())
                {
                    dbContext.NhanViens.Add(nhanvien);
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

        public bool SuaNhanVien(NhanVien nhanvien, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new QLNhaHang())
                {
                    var nhanvienUpdate = dbContext.NhanViens.SingleOrDefault(s => s.MaNhanVien == nhanvien.MaNhanVien);
                    if (nhanvienUpdate == null)
                    {
                        error = "Nhân viên không tồn tại!!";
                        return false;
                    }
                    else
                    {
                        nhanvienUpdate.TenNhanVien = nhanvien.TenNhanVien;
                        nhanvienUpdate.GioiTinh = nhanvien.GioiTinh;
                        nhanvienUpdate.NamSinh = nhanvien.NamSinh;
                        nhanvienUpdate.DiaChi = nhanvien.DiaChi;
                        nhanvienUpdate.Email = nhanvien.Email;
                        nhanvienUpdate.TenDangNhap = nhanvien.TenDangNhap;
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

        public bool XoaNhanVien(int maNV, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new QLNhaHang())
                {
                    var nhanvienDelete = dbContext.NhanViens.SingleOrDefault(s => s.MaNhanVien == maNV);
                    if (dbContext.HoaDons.Any(s => s.MaNhanVien == maNV))
                    {
                        error = "Nhân viên đã lập hóa đơn, không thể xóa!!!";
                        return false;
                    }
                    if (nhanvienDelete == null)
                    {
                        error = "Nhân viên không tồn tại!!";
                        return false;
                    }
                    dbContext.NhanViens.Remove(nhanvienDelete);
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
