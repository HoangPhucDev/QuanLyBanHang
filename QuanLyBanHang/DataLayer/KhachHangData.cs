using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanHang.General;

namespace QuanLyBanHang.DataLayer
{
    public class KhachHangData
    {
        DataService m_KhachHangData = new DataService();

        public DataTable LayKhachHang()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Khach_Hang");
            m_KhachHangData.Load(cmd);
            return m_KhachHangData;
        }

        public DataTable LayKHTheoMa(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Khach_Hang WHERE MaKH LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.NVarChar).Value = id;

            m_KhachHangData.Load(cmd);
            return m_KhachHangData;
        }

        public DataTable LayKHTheoTen(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Khach_Hang WHERE HoTen LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_KhachHangData.Load(cmd);
            return m_KhachHangData;
        }

        public DataTable LayMaKHTheoTen(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT MaKH FROM Khach_Hang WHERE HoTen LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_KhachHangData.Load(cmd);
            return m_KhachHangData;
        }

        public DataRow ThemDongMoi()
        {
            return m_KhachHangData.NewRow();
        }

        public void ThemKhachHang(DataRow m_Row)
        {
            m_KhachHangData.Rows.Add(m_Row);
        }

        public bool LuuKhachHang()
        {
            return m_KhachHangData.ExecuteNoneQuery() > 0;
        }
        public void LuuKhachHang(String makh, String hoten, String diachi, String dienthoai)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Khach_Hang VALUES(@makh, @hoten, @diachi, @dienthoai)");
            cmd.Parameters.Add("makh", SqlDbType.VarChar).Value = makh;
            cmd.Parameters.Add("hoten", SqlDbType.NVarChar).Value = hoten;
            cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = diachi;
            cmd.Parameters.Add("dienthoai", SqlDbType.VarChar).Value = dienthoai;

            m_KhachHangData.Load(cmd);
        }

    }
}
