using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanHang.General;

namespace QuanLyBanHang.DataLayer
{
    public class LoaiTienData
    {
        DataService m_LoaiTienData = new DataService();

        public DataTable LayLoaiTien()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Loai_Tien");
            m_LoaiTienData.Load(cmd);
            return m_LoaiTienData;
        }

        public DataRow ThemDongMoi()
        {
            return m_LoaiTienData.NewRow();
        }

        public void ThemLoaiTien(DataRow m_Row)
        {
            m_LoaiTienData.Rows.Add(m_Row);
        }

        public bool LuuLoaiTien()
        {
            return m_LoaiTienData.ExecuteNoneQuery() > 0;
        }
    }
}
