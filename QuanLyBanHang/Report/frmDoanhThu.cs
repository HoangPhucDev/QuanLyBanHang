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
    public partial class frmDoanhThu : Office2007Form
    {
        DoanhThuCtrl m_DoanhThuCtrl = new DoanhThuCtrl();
        public frmDoanhThu()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {

            m_DoanhThuCtrl.HienThiComboBox(cmbThang);
            m_DoanhThuCtrl.HienThiComboBox1(cmbNam);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTruyXuat_Click(object sender, EventArgs e)
        {

            IList<DoanhThuInfo> ketqua = DoanhThuCtrl.LayDsDoanhThuTheoThang(Convert.ToInt32(cmbThang.SelectedValue), Convert.ToInt32(cmbNam.SelectedValue));

            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("Ngay", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));

            this.ReportViewerDoanhThu.LocalReport.SetParameters(param);
            this.DoanhThuBindingSource.DataSource = ketqua;
            this.ReportViewerDoanhThu.RefreshReport();
        }
    }
}