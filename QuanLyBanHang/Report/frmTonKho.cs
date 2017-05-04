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
    public partial class frmTonKho : Office2007Form
    {
        TonKhoCtrl m_TonKhoCtrl = new TonKhoCtrl();
        public frmTonKho()
        {
            InitializeComponent();

            DataService.OpenConnection();
        }

        private void frmTonKho_Load(object sender, EventArgs e)
        {
            m_TonKhoCtrl.HienThiComboBox(cmbThang);
            m_TonKhoCtrl.HienThiComboBox1(cmbNam);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTruyXuat_Click(object sender, EventArgs e)
        {
            IList<TonKhoInfo> ketqua = TonKhoCtrl.LayDsTonKhoTheoThang(Convert.ToInt32(cmbThang.SelectedValue), Convert.ToInt32(cmbNam.SelectedValue));

            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("Ngay", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));

            this.ReportViewerTonKho.LocalReport.SetParameters(param);
            this.TonKhoBindingSource.DataSource = ketqua;
            this.ReportViewerTonKho.RefreshReport();
        }
    }
}