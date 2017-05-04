using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHang.General;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanHang.DataLayer
{
    public class LoaiGiaoDichData
    {
        DataService m_LoaiGiaoDichData = new DataService();

        public DataTable LayLoaiGiaoDich()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Loai_Giao_Dich");
            m_LoaiGiaoDichData.Load(cmd);
            return m_LoaiGiaoDichData;
        }

        public DataRow ThemDongMoi()
        {
            return m_LoaiGiaoDichData.NewRow();
        }

        public void ThemLoaiGiaoDich(DataRow m_Row)
        {
            m_LoaiGiaoDichData.Rows.Add(m_Row);
        }

        public bool LuuLoaiGiaoDich()
        {
            return m_LoaiGiaoDichData.ExecuteNoneQuery() > 0;
        }

    }
}
