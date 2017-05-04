using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanHang.General;

namespace QuanLyBanHang.DataLayer
{
    public class QuayGiaoDichData
    {
        DataService m_QuayGiaoDichData = new DataService();

        public DataTable LayQuayGiaoDich()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Quay_Giao_Dich");
            m_QuayGiaoDichData.Load(cmd);
            return m_QuayGiaoDichData;
        }

        public DataRow ThemDongMoi()
        {
            return m_QuayGiaoDichData.NewRow();
        }

        public void ThemQuayGiaoDich(DataRow m_Row)
        {
            m_QuayGiaoDichData.Rows.Add(m_Row);
        }

        public bool LuuQuayGiaoDich()
        {
            return m_QuayGiaoDichData.ExecuteNoneQuery() > 0;
        }
    }
}
