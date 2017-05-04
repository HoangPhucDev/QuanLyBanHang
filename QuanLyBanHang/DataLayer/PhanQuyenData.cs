using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;
using QuanLyBanHang.General;

namespace QuanLyBanHang.DataLayer
{
    public class PhanQuyenData
    {
        DataService m_PhanQuyenData = new DataService();

        public DataTable LayPhanQuyen()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Phan_Quyen");
            m_PhanQuyenData.Load(cmd);
            return m_PhanQuyenData;
        }

        public DataTable LayPhanQuyen(String m_Name)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Phan_Quyen WHERE TenDangNhap = @m_Name");
            cmd.Parameters.Add("m_Name", SqlDbType.VarChar).Value = m_Name;

            m_PhanQuyenData.Load(cmd);
            return m_PhanQuyenData;
        }

        public DataRow ThemDongMoi()
        {
            return m_PhanQuyenData.NewRow();
        }

        public void ThemPhanQuyen(DataRow m_Row)
        {
            m_PhanQuyenData.Rows.Add(m_Row);
        }

        public bool LuuPhanQuyen()
        {

            return m_PhanQuyenData.ExecuteNoneQuery() > 0;
        }

        #region doi mat khau
        public void DoiMatKhau(String TenDN, String MatKhauMoi)
        {
            m_PhanQuyenData.DoiMatKhau(TenDN, MatKhauMoi);
        }
        #endregion
    }
}
