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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        QLNhaHang dbcontext = new QLNhaHang();
        public string TenTaiKhoan;
        public frmMain(String customItem)
        {
            InitializeComponent();

            TenTaiKhoan = customItem;
            if (TenTaiKhoan != "admin")
            {
                mnBaoCao.Enabled = false;
                mnQL.Enabled = true;
                menuQLTaiKhoan.Enabled = false;
                menuNhanVien.Enabled = false;
                menuQLMonAn.Enabled = false;

            }
        }
        string TenHienThi;
        private void frmMain_Load(object sender, EventArgs e)
        {
            //maNV = dbcontext.NhanViens.Where(s => s.TenDangNhap == TenTaiKhoan).Select(s=>s.MaNhanVien).FirstOrDefault();
             TenHienThi = dbcontext.TaiKhoans.Where(s => s.TenDangNhap == TenTaiKhoan).Select(s => s.TenHienThi).FirstOrDefault();
            toolStripStatusLabel1.Text = "Xin chao tai khoan :" + TenHienThi;

        }
        
        

        private void menuQLTaiKhoan_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<frmQLTaiKhoan>().FirstOrDefault();
            if (frm != null)
                frm.Activate();
            else
            {
                frmQLTaiKhoan frmQLTaiKhoan = new frmQLTaiKhoan(TenTaiKhoan);

                frmQLTaiKhoan.MdiParent = this;
                this.Hide();
                frmQLTaiKhoan.StartPosition = FormStartPosition.CenterScreen;
                frmQLTaiKhoan.Show();
                this.Show();
            }
        }

      
        

        private void menuDatMon_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<frmDatMon>().FirstOrDefault();
            if (frm != null)
                frm.Activate();
            else
            {
                frmDatMon frmDatMon = new frmDatMon();

                frmDatMon.MdiParent = this;
                this.Hide();
                frmDatMon.StartPosition = FormStartPosition.CenterScreen;
                frmDatMon.Show();
                this.Show();
            }
            
        }

        private void menuSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<frmSua>().FirstOrDefault();
            if (frm == null)
            {
                frmSua frmSua = new frmSua(TenTaiKhoan);
                frmSua.MdiParent = this;
                this.Hide();
                frmSua.StartPosition = FormStartPosition.CenterScreen;
                frmSua.Show();
                TenHienThi = dbcontext.TaiKhoans.Where(s => s.TenDangNhap == TenTaiKhoan).Select(s => s.TenHienThi).FirstOrDefault();
                toolStripStatusLabel1.Text = "Xin chao tai khoan :" + TenHienThi;
                this.Show();
            }
            else
                frm.Activate();
        }
       
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

      

        private void menuKhachHang_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<frmKhachHang>().FirstOrDefault();
            if (frm != null)
                frm.Activate();
            else
            {
                frmKhachHang frmkhachhang = new frmKhachHang();

                frmkhachhang.MdiParent = this;
                this.Hide();
                frmkhachhang.StartPosition = FormStartPosition.CenterScreen;
                frmkhachhang.Show();
                this.Show();
            }
        }

        private void menuDoanhThu_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<frmThongKe>().FirstOrDefault();
            if (frm != null)
                frm.Activate();
            else
            {
                frmThongKe frmThongKe = new frmThongKe();

                frmThongKe.MdiParent = this;
                this.Hide();
                frmThongKe.StartPosition = FormStartPosition.CenterScreen;
                frmThongKe.Show();
                this.Show();
            }
        }

        private void mnDangXuat_Click_1(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Close();

            }
            this.Close();
        }

        private void menuQLMonAn_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<frmMonAn>().FirstOrDefault();
            if (frm != null)
                frm.Activate();
            else
            {
                frmMonAn frmmonan = new frmMonAn();

                frmmonan.MdiParent = this;
                this.Hide();
                frmmonan.StartPosition = FormStartPosition.CenterScreen;
                frmmonan.Show();
                this.Show();
            }
        }

        private void menuNhanVien_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<frmNhanVien>().FirstOrDefault();
            if (frm != null)
                frm.Activate();
            else
            {
                frmNhanVien frmnhanvien = new frmNhanVien();

                frmnhanvien.MdiParent = this;
                this.Hide();
                frmnhanvien.StartPosition = FormStartPosition.CenterScreen;
                frmnhanvien.Show();
                this.Show();
            }
        }

        private void lichSuDatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form frm = this.MdiChildren.OfType<frmLichSuDat>().FirstOrDefault();
            if (frm != null)
                frm.Activate();
            else
            {
                frmLichSuDat frmnhanvien = new frmLichSuDat();

                frmnhanvien.MdiParent = this;
                this.Hide();
                frmnhanvien.StartPosition = FormStartPosition.CenterScreen;
                frmnhanvien.Show();
                this.Show();
            }*/
        }
    }
}
