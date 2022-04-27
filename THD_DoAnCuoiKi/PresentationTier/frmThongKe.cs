using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THD_DoAnCuoiKi.DataContext;

namespace THD_DoAnCuoiKi
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rdoSoMonMua.Checked = true;
        }
        QLNhaHang dbcontext = new QLNhaHang();

        private void rdoDThuTheoTDN_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSoMonMua.Checked)
                FillDatagrid();
            if (rdoTheoHoaDon.Checked)
                FillDatagrid1();
        }

        private void FillDatagrid1()
        {
            dataGridView1.DataSource = LoadFull1();
        }

        
        private object LoadFull1()
        {

            using (dbcontext = new QLNhaHang())
            {

                return (from hd in dbcontext.HoaDons
                        join CTHD in dbcontext.CTHDs on hd.MaHoaDon equals CTHD.MaHoaDon
                        join kh in dbcontext.KhachHangs on hd.MaKhachHang equals kh.MaKhachHang
                        group CTHD by new { hd.MaHoaDon, hd.NgayLap, hd, kh.TenKhachHang } into users
                        select new
                        {
                            Hóa_Don = users.Key.MaHoaDon,
                            users.Key.TenKhachHang,
                            users.Key.NgayLap,
                            Tong_Tien = users.Sum(g => g.ThanhTien)
                        }).ToList();
            }
        }

        void FillDatagrid()
        {
            
            dataGridView1.DataSource = LoadFull();
        }
        private object LoadFull()
        {

            using (dbcontext = new QLNhaHang())
            {

                return (from t1 in dbcontext.CTHDs.ToList()
                        join t2 in dbcontext.HoaDons.ToList()
                                 on t1.MaHoaDon equals t2.MaHoaDon
                        join t3 in dbcontext.KhachHangs.ToList()
                             on t2.MaKhachHang equals t3.MaKhachHang
                        group t3 by new { t3.TenKhachHang } into g
                        select new
                        {
                            TenKhachHang = g.Key.TenKhachHang,
                            So_mon_da_mua = g.Count(a => a.HoaDons!=null),
                        }).ToList();
            }
        }
    }
}
