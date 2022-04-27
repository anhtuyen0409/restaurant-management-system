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
    public partial class frmQLTaiKhoan : Form
    {
        QLNhaHang dbcontext;
        private string tenTaiKhoan;

        public frmQLTaiKhoan()
        {
            InitializeComponent();
            
        }

        public frmQLTaiKhoan(string tenTaiKhoan)
        {
            InitializeComponent();
            this.tenTaiKhoan = tenTaiKhoan;
        }

        void LoadToDataGridView()
        {
            dbcontext = new QLNhaHang();
            dgvQLTaiKhoan.DataSource = dbcontext.TaiKhoans.Select(g=>new {g.TenDangNhap,g.MatKhau,g.TenHienThi }).ToList();
        }

        private void frmQLTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvQLTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQLTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadToDataGridView();
        }


        private void txtTimKiem1_TextChanged_1(object sender, EventArgs e)
        {
            dbcontext = new QLNhaHang();
            List<TaiKhoan> NguyenMau = dbcontext.TaiKhoans.ToList();

            dgvQLTaiKhoan.DataSource = GoiHam(NguyenMau);
            dgvQLTaiKhoan.Columns["NhanViens"].Visible = false;
        }
        private void txtTimKiem1_TextChanged(object sender, EventArgs e)
        {
            dbcontext = new QLNhaHang();
            List<TaiKhoan> NguyenMau = dbcontext.TaiKhoans.ToList();
            dgvQLTaiKhoan.Columns.RemoveAt(3);
            dgvQLTaiKhoan.DataSource = GoiHam(NguyenMau);
            dgvQLTaiKhoan.Columns.RemoveAt(3);
            dgvQLTaiKhoan.Columns["NhanViens"].Visible = false;
        }

        private List<TaiKhoan> GoiHam(List<TaiKhoan> NguyenMau)
        {

            if (txtTimKiem.Text != "")
            {
                List<TaiKhoan> temp = dbcontext.TaiKhoans.Where(s => s.TenDangNhap.StartsWith(txtTimKiem.Text)).ToList();
                NguyenMau = NguyenMau.Intersect(temp).ToList();
            }
            if (txtTimKiem1.Text != "")
            {
                List<TaiKhoan> temp = dbcontext.TaiKhoans.Where(s => s.TenHienThi.StartsWith(txtTimKiem1.Text)).ToList();
                NguyenMau = NguyenMau.Intersect(temp).ToList();
            }
            return NguyenMau;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dbcontext = new QLNhaHang();
            if (dgvQLTaiKhoan.SelectedRows.Count > 0)
            {
                try
                {
                    string TennTK = dgvQLTaiKhoan.SelectedRows[0].Cells[0].Value.ToString();
                    TaiKhoan tk = dbcontext.TaiKhoans.Where(s => s.TenDangNhap == TennTK).FirstOrDefault();
                    dbcontext.TaiKhoans.Remove(tk);
                    dbcontext.SaveChanges();
                    LoadToDataGridView();
                    MessageBox.Show("Xoa thanh cong");
                }
                catch
                {
                    MessageBox.Show("Tai khoan co hoa don -> Ko the xoa");
                    return;
                }
            }
            
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            dbcontext = new QLNhaHang();
            if (dgvQLTaiKhoan.SelectedRows.Count > 0)
            {
                try
                {
                    string TennTK = dgvQLTaiKhoan.SelectedRows[0].Cells[0].Value.ToString();
                    TaiKhoan tk = dbcontext.TaiKhoans.Where(s => s.TenDangNhap == TennTK).FirstOrDefault();
                    dbcontext.TaiKhoans.Remove(tk);
                    dbcontext.SaveChanges();
                    LoadToDataGridView();
                    MessageBox.Show("Xoa thanh cong");
                }
                catch
                {
                    MessageBox.Show("Tai khoan co hoa don -> Ko the xoa");
                    return;
                }
            }
        }
    }
}
