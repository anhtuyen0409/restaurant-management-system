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
    class MonAnBT
    {
        private readonly MonAnDT monanDT;
        public MonAnBT()
        {
            monanDT = new MonAnDT();
        }
        public List<MonAnDTO> LayDanhSach()
        {
            return monanDT.LayDanhSach();
        }

        
        public bool LuuMonAn(MonAn monan, out string error)
        {
            try
            {
                if (monan.MaMon > 0)
                {
                    return monanDT.SuaMonAn(monan, out error);
                }
                return monanDT.ThemMonAn(monan, out error);
            }
            catch (Exception ex)
            {
                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }

        internal bool XoaMonAn(int mamonan, out string error)
        {
            try
            {
                return monanDT.XoaMonAn(mamonan, out error);
            }
            catch (Exception ex)
            {
                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }
    }
}
