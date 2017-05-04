using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using QuanLyBanHang.DataLayer;
using QuanLyBanHang.General;
using QuanLyBanHang.Bussiness;

namespace QuanLyBanHang.Controller
{
    public class TonKhoCtrl
    {
        TonKhoData m_TonKhoData = new TonKhoData();
        TonKhoInfo m_TonKhoInfo = new TonKhoInfo();

        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_TonKhoData.LayTonKho();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "Tháng";
            cbx.ValueMember = "Tháng";
        }
        public void HienThiComboBox1(ComboBox cbx)
        {
            DataTable m_DT = m_TonKhoData.LayTonKho();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "Năm";
            cbx.ValueMember = "Năm";
        }

        public static IList<TonKhoInfo> LayDsTonKhoTheoThang(int thang, int nam)
        {
            IList<TonKhoInfo> ds = new List<TonKhoInfo>();

            TonKhoData data = new TonKhoData();
            DataTable tbl = data.LayDSTonKhoTheoThang(thang, nam);

            IList<TonKhoInfo> TonKho = new List<TonKhoInfo>();

            foreach (DataRow row in tbl.Rows)
            {
                TonKhoInfo TK = new TonKhoInfo();

                MatHangInfo m_MH = new MatHangInfo();
                m_MH.TenMH = Convert.ToString(row["Tên Mặt Hàng"]);
                m_MH.MaMH = Convert.ToString(row["Mã Mặt Hàng"]);
                TK.Tháng = Convert.ToInt32(row["Tháng"]);
                TK.Năm = Convert.ToInt32(row["Năm"]);
                TK.Tồn_Kho = Convert.ToInt64(row["Tồn Kho"]);
                TK.Mã_Mặt_Hàng = Convert.ToString(row["Mã Mặt Hàng"]);
                TK.Tên_Mặt_Hàng = Convert.ToString(row["Tên Mặt Hàng"]);
                TK.MaMH = m_MH;
                TonKho.Add(TK);
            }
            return TonKho;
        }
    }
}
