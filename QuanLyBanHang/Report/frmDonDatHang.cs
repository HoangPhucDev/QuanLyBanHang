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
    public partial class frmDonDatHang : Office2007Form
    {
        DatHangCtrl m_DatHangCtrl = new DatHangCtrl();
        public frmDonDatHang()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmDonDatHang_Load(object sender, EventArgs e)
        {
            m_DatHangCtrl.HienThiComboBox(cmbMaPhieu);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTruyXuat_Click(object sender, EventArgs e)
        {

            IList<DatHangInfo> ketqua = DatHangCtrl.LayDsDatHangTheoMa(cmbMaPhieu.SelectedValue.ToString());

            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("Ngay", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));

            this.ReportViewerDonDatHang.LocalReport.SetParameters(param);
            this.DatHangInfoBindingSource.DataSource = ketqua;
            this.ReportViewerDonDatHang.RefreshReport();
        }
    }
}