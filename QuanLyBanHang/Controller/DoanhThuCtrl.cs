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
    public class DoanhThuCtrl
    {
        DoanhThuData m_DoanhThuData = new DoanhThuData();
        DoanhThuInfo m_DoanhThuInfo = new DoanhThuInfo();

        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_DoanhThuData.LayDoanhThu();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "Tháng";
            cbx.ValueMember = "Tháng";
        }
        public void HienThiComboBox1(ComboBox cbx)
        {
            DataTable m_DT = m_DoanhThuData.LayDoanhThu();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "Năm";
            cbx.ValueMember = "Năm";
        }

        public static IList<DoanhThuInfo> LayDsDoanhThuTheoThang(int thang, int nam)
        {
            IList<DoanhThuInfo> ds = new List<DoanhThuInfo>();

            DoanhThuData data = new DoanhThuData();
            DataTable tbl = data.LayDSDoanhThuTheoThang(thang, nam);

            IList<DoanhThuInfo> DoanhThu = new List<DoanhThuInfo>();

            foreach (DataRow row in tbl.Rows)
            {
                DoanhThuInfo DT = new DoanhThuInfo();

                MatHangInfo m_MH = new MatHangInfo();
                m_MH.TenMH = Convert.ToString(row["Tên Mặt Hàng"]); 
                m_MH.MaMH = Convert.ToString(row["Mã Mặt Hàng"]);
                DT.Tháng = Convert.ToInt32(row["Tháng"]);
                DT.Năm = Convert.ToInt32(row["Năm"]);
                DT.Tổng_Nhập = Convert.ToInt64(row["Tổng Nhập"]);
                DT.Tổng_Xuất = Convert.ToInt64(row["Tổng Xuất"]);
                DT.Mã_Mặt_Hàng = Convert.ToString(row["Mã Mặt Hàng"]);
                DT.Tên_Mặt_Hàng = Convert.ToString(row["Tên Mặt Hàng"]); 
                DT.MaMH = m_MH;
                DoanhThu.Add(DT);
            }
            return DoanhThu;
        }
    }
}
