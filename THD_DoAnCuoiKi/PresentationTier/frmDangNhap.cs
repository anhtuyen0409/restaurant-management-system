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
    public partial class frmDangNhap : Form
    {
        QLNhaHang dbcontext;
        public frmDangNhap()
        {
            InitializeComponent();
            dbcontext = new QLNhaHang();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
           // pnlDangKy.Visible = false;
          
        }
        public string TenTaiKhoan;

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // pnlDangKy.Visible = false;
            if (string.IsNullOrWhiteSpace(txtDangNhapTK.Text))
            {
                MessageBox.Show("Vui long nhap ten dang nhap!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDangNhapMK.Text))
            {
                MessageBox.Show("Vui long nhap mat khau!");
                return;
            }
            if (dbcontext.TaiKhoans.Where(r => r.TenDangNhap == txtDangNhapTK.Text && r.MatKhau == txtDangNhapMK.Text).Count() == 0)
            {
                MessageBox.Show("Tai khoan hoac mat khau sai!!");
                return;
            }
            if (pnlDangNhap.Visible == true)
            {
                dbcontext = new QLNhaHang();

                try
                {
                    TenTaiKhoan = dbcontext.TaiKhoans.Where(s => s.TenDangNhap == txtDangNhapTK.Text
                                  && s.MatKhau == txtDangNhapMK.Text).Select(s=>s.TenDangNhap)
                                  .FirstOrDefault().ToString();
                    MessageBox.Show("Dang nhap thanh cong");

                    frmMain frm = new frmMain(TenTaiKhoan);
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
            }
                catch
                {
                    MessageBox.Show("Dang nhap that bai");
                    return;
                }
            }
            else
                pnlDangNhap.Visible = true;
        }


       /* private void btnDangKy_Click(object sender, EventArgs e)
        {
            pnlDangNhap.Visible = false;
            if (pnlDangKy.Visible == true)
            {
                try
                {
                    dbcontext = new QLNhaHang();
                    TaiKhoan taiKhoan = new TaiKhoan();
                    taiKhoan.TenDangNhap = txtDangKyTK.Text;
                    taiKhoan.TenHienThi = txtTenHienThi.Text;
                    taiKhoan.MatKhau = txtDangKyMK.Text;
                    dbcontext.TaiKhoan.Add(taiKhoan);
                    dbcontext.SaveChanges();
                    MessageBox.Show("Dang ki thanh cong.");
                    btnDangNhap.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Dang ki that bai.");
                }
            }

            else
                pnlDangKy.Visible = true;
        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMatKhau.Checked == true)
                txtDangNhapMK.UseSystemPasswordChar = false;
            else
                txtDangNhapMK.UseSystemPasswordChar = true;
        }

       /* private void ckbMatkhau2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMatkhau2.Checked == true)
                txtDangKyMK.UseSystemPasswordChar = false;
            else
                txtDangKyMK.UseSystemPasswordChar = true;
        }*/
    }
}
