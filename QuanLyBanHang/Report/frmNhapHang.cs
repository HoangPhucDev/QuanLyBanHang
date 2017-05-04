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
    public partial class frmNhapHang : Office2007Form
    {
        NhapHangCtrl m_NhapHangCtrl = new NhapHangCtrl();
        public frmNhapHang()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            m_NhapHangCtrl.HienThiComboBox(cmbThang);
            m_NhapHangCtrl.HienThiComboBox1(cmbNam);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTruyXuat_Click(object sender, EventArgs e)
        {

            IList<NhapHangInfo> ketqua = NhapHangCtrl.LayDsNhapHangTheoThang(Convert.ToInt32(cmbThang.SelectedValue), Convert.ToInt32(cmbNam.SelectedValue));

            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("Ngay", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));

            this.ReportViewerNhapHang.LocalReport.SetParameters(param);
            this.NhapHangBindingSource.DataSource = ketqua;
            this.ReportViewerNhapHang.RefreshReport();
        }

    }
}