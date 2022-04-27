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
    public delegate void CapNhatTaiKhoan();
    public partial class frmThemTaiKhoan : Form
    {
        QLNhaHang dbContexts;
        public event CapNhatTaiKhoan CapNhatTaiKhoan;
        public frmThemTaiKhoan()
        {
            InitializeComponent();
            dbContexts = new QLNhaHang();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenHienThi.Text))
            {
                MessageBox.Show("Vui lòng nhập tên hiển thị!", "Thông báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (dbContexts.TaiKhoans.Where(r => r.TenDangNhap == txtTenDangNhap.Text).Count() > 0)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    TaiKhoan tk = new TaiKhoan()
                    {
                        TenDangNhap = txtTenDangNhap.Text,
                        MatKhau = txtMatKhau.Text,
                        TenHienThi = txtTenHienThi.Text
                    };
                    dbContexts.TaiKhoans.Add(tk);
                    dbContexts.SaveChanges();
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            
        }

        private void frmThemTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            CapNhatTaiKhoan();
            
        }
    }
}
