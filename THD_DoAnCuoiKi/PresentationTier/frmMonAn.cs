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
    public partial class frmMonAn : Form
    {
        QLNhaHang dbContexts;
        MonAnBT monanBT;
        int mamonan;
        public frmMonAn()
        {
            InitializeComponent();
            dbContexts = new QLNhaHang();
            monanBT = new MonAnBT();
            mamonan = -1;
            dgvMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenMon.Text))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!!");
                return;
            }
            if (string.IsNullOrEmpty(txtGiaBan.Text))
            {
                MessageBox.Show("Vui lòng nhập giá bán!!");
                return;
            }
            
            string error;
            MonAn monan = new MonAn();
            monan.MaLoai = Convert.ToInt32(cboLoai.SelectedValue);
            monan.TenMon = txtTenMon.Text;
            monan.Gia = int.Parse(txtGiaBan.Text);
            if (monanBT.LuuMonAn(monan, out error))
            {
                //lưu thành công
                MessageBox.Show("Lưu thành công!!");
                TaiDanhSachMonAn();
                txtTenMon.Text = "";
                txtGiaBan.Text = "";
                
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
                return;
            }
        }

        private void frmMonAn_Load(object sender, EventArgs e)
        {
            TaiDanhSachMonAn();
            FillDataToComboBox(dbContexts.LoaiMons.ToList());
        }

        private void FillDataToComboBox(List<LoaiMon> loaiMons)
        {
            cboLoai.DataSource = loaiMons;
            cboLoai.DisplayMember = "TenLoai";
            cboLoai.ValueMember = "MaLoai";
        }

        private void TaiDanhSachMonAn()
        {
            dgvMonAn.DataSource = monanBT.LayDanhSach();
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMonAn.SelectedRows.Count == 1)
            {
                int dongChon = e.RowIndex;
                if (dongChon == -1)
                {
                    return;
                }
                mamonan = int.Parse(dgvMonAn.Rows[dongChon].Cells[0].Value.ToString());
                string tenMonAn = dgvMonAn.Rows[dongChon].Cells[1].Value.ToString();
                //int maLoai = int.Parse(dgvMonAn.Rows[dongChon].Cells[2].Value.ToString());
                int giaBan = int.Parse(dgvMonAn.Rows[dongChon].Cells[3].Value.ToString());
                cboLoai.SelectedIndex = Convert.ToInt32(dgvMonAn.SelectedRows[0].Cells[2].Value)-1;
                txtTenMon.Text = tenMonAn;
                txtGiaBan.Text = giaBan.ToString();
            }
            else
                return;
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (mamonan == -1)
            {
                MessageBox.Show("Vui lòng chọn món ăn!!!");
                return;
            }
            if (string.IsNullOrEmpty(txtTenMon.Text))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!!");
                return;
            }
            string error;
            MonAn monan = new MonAn();
            monan.TenMon = txtTenMon.Text;
            monan.MaLoai = cboLoai.SelectedIndex;
            monan.Gia = int.Parse(txtGiaBan.Text);
           
            monan.MaMon = mamonan;
            if (monanBT.LuuMonAn(monan, out error))
            {
                //lưu thành công
                MessageBox.Show("Lưu thành công!!");
                TaiDanhSachMonAn();
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
            if (mamonan == -1)
            {
                MessageBox.Show("Vui lòng chọn món ăn!!!");
                return;
            }

            string error;

            if (monanBT.XoaMonAn(mamonan, out error))
            {
                //lưu thành công
                MessageBox.Show("Lưu thành công!!");
                TaiDanhSachMonAn();
                txtTenMon.Text = "";
                txtGiaBan.Text = "";
                
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
    }
}
