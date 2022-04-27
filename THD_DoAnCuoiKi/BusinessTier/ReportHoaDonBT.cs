using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THD_DoAnCuoiKi.DTO;
using THD_DoAnCuoiKi.DataTier;

namespace THD_DoAnCuoiKi.BusinessTier
{
    class ReportHoaDonBT
    {
        private readonly ReportHoaDonDT reporthoadonDT;
        public ReportHoaDonBT()
        {
            reporthoadonDT = new ReportHoaDonDT();
        }
        internal List<ReportHoaDonDTO> LayDanhSachHoaDonTheoMaKhachHang(int maKhachHang)
        {
            return reporthoadonDT.LayDanhSachHoaDonTheoMaKhachHang(maKhachHang);
        }

       /* public List<ReportHoaDonDTO> LayDanhSach()
        {
            return reporthoadonDT.LayDanhSach();
        }*/
    }
}
