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
    public partial class frmNhanVien : Form
    {
        QLNhaHang dbContexts;
        NhanVienBT nhanvienBT;
        int manhanvien;
        public frmNhanVien()
        {
            InitializeComponent();
            dbContexts = new QLNhaHang();
            nhanvienBT = new NhanVienBT();
            manhanvien = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNhanVien.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!!");
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
            NhanVien nhanvien = new NhanVien();
            nhanvien.TenNhanVien = txtTenNhanVien.Text;
            nhanvien.GioiTinh = (radNam.Checked == true) ? "Nam" : "Nữ";
            nhanvien.NamSinh = dtpNamSinh.Value;
            nhanvien.DiaChi = txtDiaChi.Text;
            nhanvien.Email = txtEmail.Text;
            nhanvien.TenDangNhap = cboTaiKhoan.Text;
           
            if (nhanvienBT.LuuNhanVien(nhanvien, out error))
            {
                //lưu thành công
                MessageBox.Show("Lưu thành công!!");
                TaiDanhSachNhanVien();
                txtTenNhanVien.Text = "";
                txtDiaChi.Text = "";
                txtEmail.Text = "";
                cboTaiKhoan.Text = "";
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

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            TaiDanhSachNhanVien();
            FillDataToComboBox(dbContexts.TaiKhoans.ToList());
            radNam.Checked = true;

            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txtTenNhanVien.Text = "Nhấp để thêm thông tin";
            txtDiaChi.Text = "Nhấp để thêm thông tin";
            //txtEmail.Text = "Nhấp để thêm thông tin";
            txtTenNhanVien.ForeColor = Color.Gray;
            txtDiaChi.ForeColor = Color.Gray;
            //txtEmail.ForeColor = Color.Gray;
        }

        private void FillDataToComboBox(List<TaiKhoan> taiKhoans)
        {
            cboTaiKhoan.DataSource = taiKhoans;
            cboTaiKhoan.DisplayMember = "TenDangNhap";
            
        }

        private void TaiDanhSachNhanVien()
        {
            dgvNhanVien.DataSource = nhanvienBT.LayDanhSach();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dongChon = e.RowIndex;
            if (dongChon == -1)
            {
                return;
            }
            manhanvien = int.Parse(dgvNhanVien.Rows[dongChon].Cells[0].Value.ToString());
            string tenNhanVien = dgvNhanVien.Rows[dongChon].Cells[1].Value.ToString();
            string gioiTinh = dgvNhanVien.Rows[dongChon].Cells[2].Value.ToString();
            DateTime namSinh = DateTime.Parse(dgvNhanVien.Rows[dongChon].Cells[3].Value.ToString());
            string diaChi = dgvNhanVien.Rows[dongChon].Cells[4].Value.ToString();
            string email = dgvNhanVien.Rows[dongChon].Cells[5].Value.ToString();
            string tenDangNhap = dgvNhanVien.Rows[dongChon].Cells[6].Value.ToString();
            txtTenNhanVien.Text = tenNhanVien;
            radNam.Checked = (gioiTinh == "Nam") ? true : false;
            radNu.Checked = (gioiTinh == "Nữ") ? true : false;
            dtpNamSinh.Value = namSinh;
            txtDiaChi.Text = diaChi;
            txtEmail.Text = email;
            cboTaiKhoan.Text = tenDangNhap;
        }

        private void btnCapTaiKhoan_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan frm = new frmThemTaiKhoan();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.CapNhatTaiKhoan += Frm_CapNhatTaiKhoan;
            frm.ShowDialog();
        }

        private void Frm_CapNhatTaiKhoan()
        {
            FillDataToComboBox(dbContexts.TaiKhoans.ToList());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (manhanvien == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!!!");
                return;
            }
            if (string.IsNullOrEmpty(txtTenNhanVien.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!!");
                return;
            }
            string error;
            NhanVien nv = new NhanVien();
            nv.TenNhanVien = txtTenNhanVien.Text;
            nv.GioiTinh = (radNam.Checked == true) ? "Nam" : "Nữ";
            nv.NamSinh = dtpNamSinh.Value;
            nv.DiaChi = txtDiaChi.Text;
            nv.Email = txtEmail.Text;
            nv.TenDangNhap = cboTaiKhoan.Text;
            nv.MaNhanVien = manhanvien;
            if (nhanvienBT.LuuNhanVien(nv, out error))
            {
                //lưu thành công
                MessageBox.Show("Lưu thành công!!");
                TaiDanhSachNhanVien();
                //txtHoTen.Text = "";
                //CaiDatChucNang(true);
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (manhanvien == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!!!");
                return;
            }

            string error;

            if (nhanvienBT.XoaNhanVien(manhanvien, out error))
            {
                //lưu thành công
                MessageBox.Show("Xóa thành công!!");
                TaiDanhSachNhanVien();
                txtTenNhanVien.Text = "";
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

        private void cboTaiKhoan_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text == "Nhấp để thêm thông tin")
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
            }
        }

        private void cboTaiKhoan_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text == "")
            {
                txt.Text = "Nhấp để thêm thông tin";
                txt.ForeColor = Color.Gray;
            }
        }
       
    }
}
