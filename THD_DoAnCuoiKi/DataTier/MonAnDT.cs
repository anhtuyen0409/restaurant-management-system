using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THD_DoAnCuoiKi.DTO;
using THD_DoAnCuoiKi.DataContext;

namespace THD_DoAnCuoiKi.DataTier
{
    class MonAnDT
    {
        public List<MonAnDTO> LayDanhSach()
        {
            using (var dbContext = new QLNhaHang())
            {
                return (from m in dbContext.MonAns
                        select new MonAnDTO()
                        {
                            MaMon = m.MaMon,
                            TenMon = m.TenMon,
                            MaLoai = m.MaLoai,
                            GiaBan = m.Gia
                        }).ToList();
            }
        }
        public bool ThemMonAn(MonAn monan, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new QLNhaHang())
                {
                    dbContext.MonAns.Add(monan);
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

        public bool SuaMonAn(MonAn monan, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new QLNhaHang())
                {
                    var monanUpdate = dbContext.MonAns.SingleOrDefault(s => s.MaMon == monan.MaMon);
                    if (monanUpdate == null)
                    {
                        error = "Món ăn không tồn tại!!";
                        return false;
                    }
                    else
                    {
                        monanUpdate.TenMon = monan.TenMon;
                        monanUpdate.MaLoai = monan.MaLoai;
                        monanUpdate.Gia = monan.Gia;
                        
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

        public bool XoaMonAn(int maMonAn, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new QLNhaHang())
                {
                    var monanDelete = dbContext.MonAns.SingleOrDefault(s => s.MaMon == maMonAn);
                    if (dbContext.CTHDs.Any(s => s.MaMon == maMonAn))
                    {
                        error = "Món ăn đã có trong hóa đơn, không thể xóa!!!";
                        return false;
                    }
                    if (monanDelete == null)
                    {
                        error = "Món ăn không tồn tại!!";
                        return false;
                    }
                    dbContext.MonAns.Remove(monanDelete);
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
