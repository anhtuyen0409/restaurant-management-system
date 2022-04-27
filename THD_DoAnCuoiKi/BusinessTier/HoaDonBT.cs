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
    class HoaDonBT
    {
        private readonly HoaDonDT hoadonDT;
        public HoaDonBT()
        {
            hoadonDT = new HoaDonDT();
        }
        public List<HoaDonDTO> LayDanhSach()
        {
            return hoadonDT.LayDanhSach();
        }

       
        public bool LuuHoaDon(HoaDon hoadon, out string error)
        {
            try
            {
                if (hoadon.MaHoaDon > 0)
                {
                    return hoadonDT.SuaHoaDon(hoadon, out error);
                }
                return hoadonDT.TaoMoiHoaDon(hoadon, out error);
            }
            catch (Exception ex)
            {
                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }

        internal bool XoaHoaDon(int maHoaDon, out string error)
        {
            try
            {
                return hoadonDT.XoaHoaDon(maHoaDon, out error);
            }
            catch (Exception ex)
            {
                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }
    }
}
