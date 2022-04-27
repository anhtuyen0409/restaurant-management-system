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
    class ChiTietHoaDonBT
    {
        private readonly ChiTietHoaDonDT chitiethoadonDT;
        public ChiTietHoaDonBT()
        {
            chitiethoadonDT = new ChiTietHoaDonDT();
        }
        public List<ChiTietHoaDonDTO> LayDanhSach()
        {
            return chitiethoadonDT.LayDanhSach();
        }


        public bool LuuChiTietHoaDon(CTHD chitiethoadon, out string error)
        {
            try
            {
               
                return chitiethoadonDT.Them(chitiethoadon, out error);
            }
            catch (Exception ex)
            {
                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }

        internal bool XoaChiTietHoaDon(int maChiTietHoaDon, out string error)
        {
            try
            {
                return chitiethoadonDT.XoaChiTietHoaDon(maChiTietHoaDon, out error);
            }
            catch (Exception ex)
            {
                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }

        internal List<ChiTietHoaDonDTO> LayDanhSachTheoMaHoaDon(int maHoaDonDangChon)
        {
            return chitiethoadonDT.LayDanhSachTheoMaHoaDon(maHoaDonDangChon);
        }
    }
}
