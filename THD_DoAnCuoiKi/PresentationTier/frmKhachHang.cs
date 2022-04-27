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
using THD_DoAnCuoiKi.BusinessTier;
using System.Text.RegularExpressions;

namespace THD_DoAnCuoiKi
{
    public partial class frmKhachHang : Form
    {
        QLNhaHang dbContexts;
        KhachHangBT khachHangBT;
        int maKhachHang;
        public frmKhachHang()
        {
            InitializeComponent();
            dbContexts = new QLNhaHang();
            khachHangBT = new KhachHangBT();
            maKhachHang = -1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maKhachHang == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!!!");
                return;
            }
            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!!");
                return;
            }
            string error;
            KhachHang khachHang = new KhachHang();
            khachHang.TenKhachHang = txtTenKH.Text;
            khachHang.GioiTinh = (radNam.Checked == true) ? "Nam" : "Nữ";
            khachHang.NamSinh = dtpNamSinh.Value;
            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.Email = txtEmail.Text;
            khachHang.MaKhachHang = maKhachHang;
            if (khachHangBT.LuuKhachHang(khachHang, out error))
            {
                //lưu thành công
                MessageBox.Show("Lưu thành công!!");
                TaiDanhSachKhachHang();
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
                return;
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //txtTenKH.Text = "Nhấp để thêm thông tin";
            txtDiaChi.Text = "Nhấp để thêm thông tin";
            
            txtTenKH.ForeColor = Color.Gray;
            txtDiaChi.ForeColor = Color.Gray;
            
            TaiDanhSachKhachHang();
            radNam.Checked = true;
            radioButton1.Checked = true;

        }

        private void TaiDanhSachKhachHang()
        {
            dgvKhachHang.DataSource = khachHangBT.LayDanhSach();
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!!");
                return;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!!");
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email!!");
                return;
            }
            if (!isEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ!!");
                return;
            }
            string error;
            KhachHang khachHang = new KhachHang();
            khachHang.TenKhachHang = txtTenKH.Text;
            khachHang.GioiTinh = (radNam.Checked == true) ? "Nam" : "Nữ";
            khachHang.NamSinh = dtpNamSinh.Value;
            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.Email = txtEmail.Text;
            if (khachHangBT.LuuKhachHang(khachHang, out error))
            {
                //lưu thành công
                MessageBox.Show("Lưu thành công!!");
                TaiDanhSachKhachHang();
                txtTenKH.Text = "";
                txtDiaChi.Text = "";
                txtEmail.Text = "";
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
                return;
            }
        }

        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maKhachHang == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!!!");
                return;
            }

            string error;

            if (khachHangBT.XoaKhachHang(maKhachHang, out error))
            {
                //lưu thành công
                MessageBox.Show("Lưu thành công!!");
                TaiDanhSachKhachHang();
                txtTenKH.Text = "";
                txtDiaChi.Text = "";
                txtEmail.Text = "";
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (groupBox3.Visible == false)
            {
                groupBox1.Visible = false;
                groupBox3.Visible = true;
                btnThem.Enabled = false;
            }
            else
            {
                groupBox1.Visible = true;
                groupBox3.Visible = false;
                btnThem.Enabled = true;
            }
        }

        private void rdo1_CheckedChanged(object sender, EventArgs e)
        {
            dbcontext = new QLNhaHang();
            List<KhachHang> NguyenMau = dbcontext.KhachHangs.ToList();
            List<KhachHang> NguyenMau1 = GoiHam1();
            if (NguyenMau1 != null)
                NguyenMau = NguyenMau.Intersect(NguyenMau1).ToList();
            dgvKhachHang.DataSource = GoiHam(NguyenMau);
            dgvKhachHang.Columns["HoaDons"].Visible = false;
        }
        QLNhaHang dbcontext;
        private void txt3_TextChanged(object sender, EventArgs e)
        {
            dbcontext = new QLNhaHang();
            List<KhachHang> NguyenMau = dbcontext.KhachHangs.ToList();
            List<KhachHang> NguyenMau1 = GoiHam1();
            if (NguyenMau1 != null)
                NguyenMau = NguyenMau.Intersect(NguyenMau1).ToList();
            dgvKhachHang.DataSource = GoiHam(NguyenMau);
            dgvKhachHang.Columns["HoaDons"].Visible = false;

        }


        private List<KhachHang> GoiHam1()
        {
            if (rdo1.Checked == false && rdo2.Checked == false )
                return null;
            List<KhachHang> temp;
            if (rdo1.Checked == true)
            {
                temp = dbcontext.KhachHangs.Where(s => s.GioiTinh == "Nam").ToList();
                return temp;
            }

            else
            {
                temp = dbcontext.KhachHangs.Where(s => s.GioiTinh == "Nữ").ToList();
                return temp;
            }
            
        }

        private List<KhachHang> GoiHam(List<KhachHang> NguyenMau)
        {

            if (txt3.Text != "")
            {
                List<KhachHang> temp = dbcontext.KhachHangs.Where(s => s.TenKhachHang.StartsWith(txt3.Text)).ToList();
                NguyenMau = NguyenMau.Intersect(temp).ToList();
            }
            if (txt4.Text != "")
            {
                List<KhachHang> temp = dbcontext.KhachHangs.Where(s => s.Email.StartsWith(txt4.Text)).ToList();
                NguyenMau = NguyenMau.Intersect(temp).ToList();
            }
            return NguyenMau;
        }

        private void txtDiaChi_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.ForeColor == Color.Gray)
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
            }
        }

        private void txtTenKH_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text == "")
            {
                txt.Text = "Nhấp để thêm thông tin";
                txt.ForeColor = Color.Gray;
            }
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dongChon = e.RowIndex;
            txtTenKH.ForeColor = Color.Black;
            txtDiaChi.ForeColor = Color.Black;
            if (dongChon == -1)
            {
                return;
            }
            maKhachHang = int.Parse(dgvKhachHang.Rows[dongChon].Cells[0].Value.ToString());
            string tenKhachHang = dgvKhachHang.Rows[dongChon].Cells[1].Value.ToString();
            string gioiTinh = dgvKhachHang.Rows[dongChon].Cells[2].Value.ToString();
            DateTime namSinh = DateTime.Parse(dgvKhachHang.Rows[dongChon].Cells[3].Value.ToString());
            string diaChi = dgvKhachHang.Rows[dongChon].Cells[4].Value.ToString();
            string email = dgvKhachHang.Rows[dongChon].Cells[5].Value.ToString();
            txtTenKH.Text = tenKhachHang;
            radNam.Checked = (gioiTinh == "Nam") ? true : false;
            radNu.Checked = (gioiTinh == "Nữ") ? true : false;
            dtpNamSinh.Value = namSinh;
            txtDiaChi.Text = diaChi;
            txtEmail.Text = email;
            //CaiDatChucNang(false);
        }
    }
}
