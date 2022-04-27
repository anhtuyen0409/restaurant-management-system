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
    public partial class frmSua : Form
    {
        public frmSua()
        {
            InitializeComponent();
        }
        QLNhaHang dbcontext;
        string TenTaiKhoang;
        public frmSua(string Tentk)
        {
            InitializeComponent();
            TenTaiKhoang = Tentk;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dbcontext = new QLNhaHang();
            TaiKhoan taiKhoan = dbcontext.TaiKhoans.Where(s => s.TenDangNhap == TenTaiKhoang).FirstOrDefault();
            taiKhoan.TenDangNhap = TenTaiKhoang;
            taiKhoan.MatKhau = txtMatKhau.Text;
            taiKhoan.TenHienThi = txtTenHienThi.Text;
            dbcontext.SaveChanges();
            MessageBox.Show("Sua thanh cong.");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSua_Load(object sender, EventArgs e)
        {
            dbcontext = new QLNhaHang();
            TaiKhoan taiKhoan = dbcontext.TaiKhoans.Where(s => s.TenDangNhap == TenTaiKhoang).FirstOrDefault();
            txtTenDangNhap.Text = taiKhoan.TenDangNhap;
            txtMatKhau.Text = taiKhoan.MatKhau;
            txtTenHienThi.Text = taiKhoan.TenHienThi;
            
        }
    }
}
