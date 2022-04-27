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

namespace THD_DoAnCuoiKi
{
    public partial class frmDatMon : Form
    {

        QLNhaHang dbContexts;
        HoaDonBT hoadonBT;
        ChiTietHoaDonBT chitiethoadonBT;
        int mahoadon;
        int machitiethoadon;
        public frmDatMon()
        {
            InitializeComponent();

            dbContexts = new QLNhaHang();
            hoadonBT = new HoaDonBT();
            chitiethoadonBT = new ChiTietHoaDonBT();
            mahoadon = -1;
            machitiethoadon = -1;
        }


        private void frmDatMon_Load(object sender, EventArgs e)
        {
            cboLoai.DisplayMember = "TenLoai";
            cboLoai.ValueMember = "MaLoai";
            cboMon.DisplayMember = "TenMon";
            cboMon.ValueMember = "MaMon";
            cboMon.SelectedValue = 1;
            FillCboLoai();
            /*dataGridView1.Columns.Add("Tên sản phẩm", "Tên sản phẩm");
            dataGridView1.Columns.Add("Ngày mua", "Ngày mua");
            dataGridView1.Columns.Add("Số Lượng", "Số Lượng");
            dataGridView1.Columns.Add("Gia Tien", "Gia Tien");*/
            dgvChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FillDataToComboBoxKH(dbContexts.KhachHangs.ToList());
            FillDataToComboBoxNV(dbContexts.NhanViens.ToList());
            TaiDanhSachHoaDon();
        }

        private void TaiDanhSachHoaDon()
        {
            dgvHoaDon.DataSource = hoadonBT.LayDanhSach();
        }

        private void FillDataToComboBoxNV(List<NhanVien> nhanViens)
        {
            cboNhanVienLap.DataSource = nhanViens;
            cboNhanVienLap.DisplayMember = "TenNhanVien";
            cboNhanVienLap.ValueMember = "MaNhanVien";
        }

        private void FillDataToComboBoxKH(List<KhachHang> khachHangs)
        {
            cboTenKhachHang.DataSource = khachHangs;
            cboTenKhachHang.DisplayMember = "TenKhachHang";
            cboTenKhachHang.ValueMember = "MaKhachHang";
        }

        void FillCboLoai()
        {
            cboLoai.DataSource = dbContexts.LoaiMons.ToList();
        }

        

        private void cboLoai_TextChanged(object sender, EventArgs e)
        {
           
            int temp = Convert.ToInt32(cboLoai.SelectedValue);
            cboMon.DataSource = dbContexts.MonAns.Where(s => s.MaLoai == temp).ToList();
        }

        private void cboMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbContexts = new QLNhaHang();
            int ma = Convert.ToInt32(cboMon.SelectedValue);
            int a = dbContexts.MonAns.Where(s => s.MaMon == ma).Select(s => s.Gia).FirstOrDefault();
            if (txtSoLuong.Text != "")
                txtGiaTien.Text = Convert.ToString(a * Convert.ToInt32(txtSoLuong.Text));
            else
                txtGiaTien.Text = 0.ToString();
           

            string ma1 = cboMon.SelectedValue.ToString();
            try
            {
                pictureBox1.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\" + ma1 + ".jpg");
               // ImageLayout Stretch = default(ImageLayout);
                pictureBox1.BackgroundImageLayout= ImageLayout.Stretch;
            }
            catch//(Exception ex)
            {
                pictureBox1.Image = null;
            }
            
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            dbContexts = new QLNhaHang();
            int ma = Convert.ToInt32(cboMon.SelectedValue);
            int a = dbContexts.MonAns.Where(s => s.MaMon == ma).Select(s => s.Gia).FirstOrDefault();
            if (txtSoLuong.Text != "")
                txtGiaTien.Text = Convert.ToString(a * Convert.ToInt32(txtSoLuong.Text));
            else
                txtGiaTien.Text = 0.ToString();
        }
        

       /* private void btnHuy_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtSoLuong.Text = "";
            txtGiaTien.Text = "";
        }

      /*  private void btnThem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(new string[] { cboMon.Text,DateTime.Now.Date.ToShortDateString(),
                                            txtSoLuong.Text,txtGiaTien.Text});
        }

       /* private void txtMua_Click(object sender, EventArgs e)
        {
            /*dbcontext = new QLNhaHang();
            HoaDon hoaDon = new HoaDon();
            //hoaDon.TenDangNhap = TenTaiKhoan;
            hoaDon.NgayLap = DateTime.Now.Date;
            //dbcontext.HoaDon.Add(hoaDon);
            dbcontext.SaveChanges();
            
            CTHD cthd;
            int a;
            //MessageBox.Show((dataGridView1.Rows.Count-1).ToString());
            for (int i=0;i<dataGridView1.Rows.Count -1;i++)
            {
                cthd = new CTHD();
                a = LayMaMonTheoTenMon(Convert.ToString(dataGridView1.Rows[i].Cells[0].Value));
                
                cthd.MaHoaDon = hoaDon.MaHoaDon;
                cthd.MaMon = a;
                cthd.SoLuong = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value); 
                cthd.ThanhTien= Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                addCTHDtoCSDL(cthd);
            }
            MessageBox.Show("Mua thanh cong.");
            dataGridView1.Rows.Clear();
            */

        

       /* void addCTHDtoCSDL(CTHD cthd)
        {
            var dbcontext1 = new QLNhaHang();
            dbcontext1.CTHDs.Add(cthd);
            dbcontext1.SaveChanges();//sao lai du 1

        }
        int LayMaMonTheoTenMon(string tenMon)
        {
            var dbcontext2 = new QLNhaHang();
            return dbcontext2.MonAns.Where(s => s.TenMon.CompareTo(tenMon)==0).Select(s => s.MaMon).FirstOrDefault();
        }

        /*private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Ban co muon thoat ", "Thong bao", MessageBoxButtons.YesNo);
            if(result ==DialogResult.Yes)
            this.Close();
        }*/

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
                groupBox1.Visible = true;
            string error;
            HoaDon hoadon = new HoaDon();
            hoadon.NgayLap = dtpNgayLap.Value;
            hoadon.MaKhachHang = Convert.ToInt32(cboTenKhachHang.SelectedValue.ToString());
            hoadon.MaNhanVien = Convert.ToInt32(cboNhanVienLap.SelectedValue.ToString());


            if (hoadonBT.LuuHoaDon(hoadon, out error))
            {
                //lưu thành công
                MessageBox.Show("Thêm hóa đơn thành công!!");
                TaiDanhSachHoaDon();
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
                return;
            }
        }

        private int Dem()
        {
            int dem = 0;
            if (dgvHoaDon.Rows[0].Cells[0].Value.ToString() == null)
                return 0;
            foreach (DataGridViewRow item in dgvHoaDon.Rows)
            {
                dem++;
            }
            return dem;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int index = Dem();
            
            string error;
            CTHD chitiethoadon = new CTHD();
            chitiethoadon.MaHoaDon = int.Parse(dgvHoaDon.Rows[index-1].Cells[0].Value.ToString());
            
            chitiethoadon.MaMon = Convert.ToInt32(cboMon.SelectedValue);
            chitiethoadon.SoLuong = int.Parse(txtSoLuong.Text);
            chitiethoadon.ThanhTien = int.Parse(txtGiaTien.Text);

            if (chitiethoadonBT.LuuChiTietHoaDon(chitiethoadon, out error))
            {
                //lưu thành công
                MessageBox.Show("Lưu thành công!!");
                TaiDanhSachChiTietHoaDon();
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
                return;
            }
            
        }

        private void TaiDanhSachChiTietHoaDon()
        {
            dgvChiTietHoaDon.DataSource = chitiethoadonBT.LayDanhSach();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //hiển thị thông tin qua chi tiết hóa đơn
            
            int rowIndex = e.RowIndex;
            if (rowIndex == -1)
            {
                return;
            }
            int maHoaDonDangChon = int.Parse(dgvHoaDon.Rows[rowIndex].Cells[0].Value.ToString());
            mahoadon = int.Parse(dgvHoaDon.Rows[rowIndex].Cells[0].Value.ToString());

            //lấy chi tiết từ database
            dgvChiTietHoaDon.DataSource = chitiethoadonBT.LayDanhSachTheoMaHoaDon(maHoaDonDangChon);
            //lọc danh sách chi tiết hóa đơn theo mã hóa đơn được chọn
            /* DataTable tblChiTiet = tblChiTietHoaDon.AsEnumerable().
                 Where(row => row.Field<string>("Mã Hóa Đơn") == maHoaDonDangChon).CopyToDataTable();
             dgvChiTietHoaDon.DataSource = tblChiTiet;*/

            //xác định hóa đơn 
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (mahoadon == -1)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn!!!");
                return;
            }
            
            string error;
            HoaDon hoadon = new HoaDon();
            hoadon.MaKhachHang = cboTenKhachHang.SelectedIndex;
            hoadon.MaNhanVien = cboNhanVienLap.SelectedIndex;
            hoadon.NgayLap = dtpNgayLap.Value;
            hoadon.MaHoaDon = mahoadon;
            if (hoadonBT.LuuHoaDon(hoadon, out error))
            {
                //lưu thành công
                MessageBox.Show("Lưu thành công!!");
                TaiDanhSachHoaDon();
                
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (mahoadon == -1)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn!!!");
                return;
            }

            string error;

            if (hoadonBT.XoaHoaDon(mahoadon, out error))
            {
                //lưu thành công
                MessageBox.Show("Xoa thành công!!");
                TaiDanhSachHoaDon();
                
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
                return;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (machitiethoadon == -1)
            {
                MessageBox.Show("Vui lòng chọn!!!");
                return;
            }

            string error;

            if (chitiethoadonBT.XoaChiTietHoaDon(machitiethoadon, out error))
            {
                //lưu thành công
                MessageBox.Show("Xóa thành công!!");
                TaiDanhSachChiTietHoaDon();

            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
                return;
            }
        }
    }
}
