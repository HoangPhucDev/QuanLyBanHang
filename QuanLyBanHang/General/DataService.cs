using System;
using System.Data;
using System.Xml;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using QuanLyBanHang.General;
using System.Windows.Forms;

namespace QuanLyBanHang.General
{
    partial class DataService : DataTable
    {
        #region Cac bien
        private static SqlConnection m_Connection;
        public static String m_ConnectString = Properties.Settings.Default.ConnectionString;
        private SqlCommand m_Command;
        private SqlDataAdapter m_DataAdapter;
        #endregion

        public DataService()
        {

        }
        #region Ket noi he quan tri co so du lieu
        public static void ConnectDBMS()
        {
        }
        #endregion
        #region Ket noi du lieu
        public static void ConnectionString()
        {
            XmlDocument XmlDOcument = XML.ReadXml("");
            XmlElement XmlElement = XmlDOcument.DocumentElement;

            try
            {
                if (XmlElement.SelectSingleNode("costatus").InnerText == "true")
                {
                    m_ConnectString = "Data Source=" + XmlElement.SelectSingleNode("servername").InnerText + ";Initial Catalog=" + XmlElement.SelectSingleNode("database").InnerText + XmlElement.SelectSingleNode(";Integrated Security=True;");
                }
                else
                {
                    m_ConnectString = "Data Source=" + XmlElement.SelectSingleNode("servername").InnerText + ";Initial Catalog=" + XmlElement.SelectSingleNode("database").InnerText + ";User Id=" + XmlElement.SelectSingleNode("username").InnerText + ";Password=" + XmlElement.SelectSingleNode("password").InnerText + ";";
                }
                ThamSo.DatabaseName = XmlElement.SelectSingleNode("database").InnerText;
            }
            catch
            {
                MessageBoxEx.Show("Không thể kết nối được cơ sở dữ liệu! \n Lỗi: kết nối", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
        

        #region dua du lieu
        public void Load(SqlCommand m_Sql)
        {
            m_Command = m_Sql;
            try
            {
                m_Command.Connection = m_Connection;

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                this.Clear();
                m_DataAdapter.Fill(this);
            }
            catch (Exception e)
            {
                MessageBoxEx.Show("Không thể thực thi câu lệnh SQL này!\nLỗi: " + e.Message, "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        #endregion

        #region mo ket noi
        public static bool OpenConnection()
        {
            try
            {
                if (m_Connection == null)
                    m_Connection = new SqlConnection(m_ConnectString);
                if (m_Connection.State == ConnectionState.Closed)
                    m_Connection.Open();
                return true;
            }
            catch
            {
                m_Connection.Close();
                return false;
            }
        }
        #endregion

        #region dong ket noi
        public void CloseConnection()
        {
            m_Connection.Close();
        }
        #endregion

        #region Cap nhat du lieu
        public int ExecuteNoneQuery()
        {
            int result = 0;
            SqlTransaction m_SqlTran = null;
            try
            {
                m_SqlTran = m_Connection.BeginTransaction();

                m_Command.Connection = m_Connection;
                m_Command.Transaction = m_SqlTran;

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                SqlCommandBuilder builder = new SqlCommandBuilder(m_DataAdapter);

                result = m_DataAdapter.Update(this);
                m_SqlTran.Commit();
            }
            catch
            {
                if (m_SqlTran != null)
                    m_SqlTran.Rollback();
                throw;
            }
            return result;
        }
        #endregion

        #region Thực thi câu lệnh SQL
        public int ExecuteNoneQuery(SqlCommand m_Sql)
        {
            int result = 0;
            SqlTransaction m_SqlTran = null;
            try
            {
                m_SqlTran = m_Connection.BeginTransaction();

                m_Sql.Connection = m_Connection;
                m_Sql.Transaction = m_SqlTran;
                result = m_Sql.ExecuteNonQuery();

                this.AcceptChanges();
                m_SqlTran.Commit();
            }
            catch
            {
                if (m_SqlTran != null)
                    m_SqlTran.Rollback();
                throw;
            }
            return result;
        }
        #endregion

        #region ExecuteScalar
        public object ExecuteScalar(SqlCommand m_Sql)
        {
            object result = null;
            SqlTransaction m_SqlTran = null;
            try
            {
                m_SqlTran = m_Connection.BeginTransaction();
                m_Sql.Connection = m_Connection;
                m_Sql.Transaction = m_SqlTran;
                result = m_Sql.ExecuteScalar();

                this.AcceptChanges();
                m_SqlTran.Commit();
                if (result == DBNull.Value)
                {
                    result = null;
                }
            }
            catch
            {
                if (m_SqlTran != null)
                    m_SqlTran.Rollback();
                throw;
            }
            return result;
        }
        #endregion

        #region Doi mat khau
        public void DoiMatKhau(String userName, String newPassword)
        {
            m_DataAdapter = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand("UPDATE Phan_Quyen SET MatKhau = @matkhau WHERE TenDangNhap = @tendangnhap");
            cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = userName;
            cmd.Parameters.Add("matkhau", SqlDbType.VarChar).Value = newPassword;

            if (m_ConnectString == "")
                ConnectionString();

            if (m_Connection == null || m_Connection.State == ConnectionState.Closed)
            {
                m_Connection = new SqlConnection(m_ConnectString);
                m_Connection.Open();
            }

            m_Command = new SqlCommand();
            m_Command = cmd;

            try
            {
                m_Command.Connection = m_Connection;

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                //this.Clear();

                m_DataAdapter.Fill(this);

                SqlCommandBuilder buider = new SqlCommandBuilder(m_DataAdapter);
                m_DataAdapter.Update(this);
            }
            catch (Exception e)
            {
                MessageBoxEx.Show("Không thể thực thi câu lệnh SQL này!\nLỗi: " + e.Message, "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
