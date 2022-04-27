using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THD_DoAnCuoiKi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
            //Application.Run(new frmMain());
            //plication.Run(new frmDatMon());
            //Application.Run(new frmQLTaiKhoan());
            //Application.Run(new frmLichSuDat()); 
        }
    }
}
