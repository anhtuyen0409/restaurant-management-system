using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THD_DoAnCuoiKi.BusinessTier;
using THD_DoAnCuoiKi.DTO;
using THD_DoAnCuoiKi.DataContext;
using Microsoft.Reporting.WinForms;

namespace THD_DoAnCuoiKi
{
    public partial class frmReport : Form
    {
        KhachHangBT khachHangBT;
        ReportHoaDonBT reporthoadonBT;
        QLNhaHang dbContexts;
        public frmReport()
        {
            InitializeComponent();
            khachHangBT = new KhachHangBT();
            dbContexts = new QLNhaHang();
            reporthoadonBT = new ReportHoaDonBT();
            cboTenKhachHang.DisplayMember = "TenKH";
            cboTenKhachHang.ValueMember = "MaKH";
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
           // FillDataToComboBoxKH(dbContexts.KhachHangs.ToList());
            cboTenKhachHang.DataSource = khachHangBT.LayDanhSach();
        }

       /* private void FillDataToComboBoxKH(List<KhachHang> khachHangs)
        {
            cboTenKhachHang.DataSource = khachHangs;
            cboTenKhachHang.DisplayMember = "TenKhachHang";
            cboTenKhachHang.ValueMember = "MaKhachHang";
        }*/

        private void cboTenKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maKhachHang = int.Parse(cboTenKhachHang.SelectedValue.ToString());
            List<ReportHoaDonDTO> danhSachHoaDonTheoKhachHang = reporthoadonBT.LayDanhSachHoaDonTheoMaKhachHang(maKhachHang);
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            var reportDataSource = new ReportDataSource("HoaDonDataSet", danhSachHoaDonTheoKhachHang);

            this.reportViewer1.LocalReport.DataSources.Clear(); //clear 
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport(); //ch y repo
        }
    }
}
