using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THD_DoAnCuoiKi.DataTier;
using THD_DoAnCuoiKi.DTO;
using THD_DoAnCuoiKi.DataContext;

namespace THD_DoAnCuoiKi.BusinessTier
{
    class NhanVienBT
    {
        private readonly NhanVienDT nhanvienDT;
        public NhanVienBT()
        {
            nhanvienDT = new NhanVienDT();
        }
        public List<NhanVienDTO> LayDanhSach()
        {
            return nhanvienDT.LayDanhSach();
        }

        
        public bool LuuNhanVien(NhanVien nv, out string error)
        {
            try
            {
                if (nv.MaNhanVien > 0)
                {
                    return nhanvienDT.SuaNhanVien(nv, out error);
                }
                return nhanvienDT.ThemNhanVien(nv, out error);
            }
            catch (Exception ex)
            {
                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }

        internal bool XoaNhanVien(int manv, out string error)
        {
            try
            {
                return nhanvienDT.XoaNhanVien(manv, out error);
            }
            catch (Exception ex)
            {
                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }
    }
}
