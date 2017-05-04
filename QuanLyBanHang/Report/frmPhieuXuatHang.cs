using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DevComponents.DotNetBar;
using QuanLyBanHang.General;
using QuanLyBanHang.Bussiness;
using QuanLyBanHang.Controller;

namespace QuanLyBanHang.Report
{
    public partial class frmPhieuXuatHang : Office2007Form
    {
        XuatHangCtrl m_XuatHangCtrl = new XuatHangCtrl();
        public frmPhieuXuatHang()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmPhieuXuatHang_Load(object sender, EventArgs e)
        {
            m_XuatHangCtrl.HienThiComboBox(cmbMaPhieu);         
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTruyXuat_Click(object sender, EventArgs e)
        {

            IList<XuatHangInfo> ketqua = XuatHangCtrl.LayDsXuatHangTheoMa(cmbMaPhieu.SelectedValue.ToString());

            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("Ngay", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));

            this.ReportViewerPhieuXuatHang.LocalReport.SetParameters(param);
            this.PhieuXuatHangBindingSource.DataSource = ketqua;
            this.ReportViewerPhieuXuatHang.RefreshReport();
        }
    }
}