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
    class KhachHangBT
    {
        private readonly KhachHangDT khachHangDT;
        public KhachHangBT()
        {
            khachHangDT = new KhachHangDT();
        }
        public List<KhachHangDTO> LayDanhSach()
        {
            return khachHangDT.LayDanhSach();
        }

        //method lưu khách hàng được áp dụng luôn cho thêm và sửa khách hàng
        public bool LuuKhachHang(KhachHang khachHang, out string error)
        {
            try
            {
                if (khachHang.MaKhachHang > 0)
                {
                    return khachHangDT.SuaKhachHang(khachHang, out error);
                }
                return khachHangDT.ThemKhachHang(khachHang, out error);
            }
            catch (Exception ex)
            {
                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }

        internal bool XoaKhachHang(int maKhachHang, out string error)
        {
            try
            {
                return khachHangDT.XoaKhachHang(maKhachHang, out error);
            }
            catch (Exception ex)
            {
                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }
    }
}
