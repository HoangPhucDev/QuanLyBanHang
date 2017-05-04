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
    public partial class frmDSMatHang : Office2007Form
    {
        public frmDSMatHang()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmDSMatHang_Load(object sender, EventArgs e)
        {
            IList<MatHangInfo> ketqua = MatHangCtrl.LayDsMatHang();

            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("Ngay", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            this.ReportViewerDanhSachMatHang.LocalReport.SetParameters(param);

            this.MatHangInfoBindingSource.DataSource = ketqua;

            this.ReportViewerDanhSachMatHang.RefreshReport();
        }
    }
}