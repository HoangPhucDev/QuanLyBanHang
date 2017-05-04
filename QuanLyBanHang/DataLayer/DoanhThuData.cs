using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanHang.General;

namespace QuanLyBanHang.DataLayer
{
    public class DoanhThuData
    {
        DataService m_DoanhThuData = new DataService();

        public DataTable LayDoanhThu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DoanhThu");
            m_DoanhThuData.Load(cmd);
            return m_DoanhThuData;
        }
        public DataTable LayDSDoanhThuTheoThang(int thang, int nam)
        {
            SqlCommand cmd = new SqlCommand("SELECT MH.MaMH, DT.[Mã Mặt Hàng], DT.[Tên Mặt Hàng], DT.Tháng, DT.Năm, DT.[Tổng Nhập], DT.[Tổng Xuất] FROM DoanhThu DT INNER JOIN Mat_Hang MH ON MH.MaMH = DT.[Mã Mặt Hàng] AND MH.TenMH = DT.[Tên Mặt Hàng] WHERE DT.Tháng = @Tháng AND DT.Năm = @Năm");
            cmd.Parameters.Add("Tháng", SqlDbType.Int).Value = thang;
            cmd.Parameters.Add("Năm", SqlDbType.Int).Value = nam;
            m_DoanhThuData.Load(cmd);
            return m_DoanhThuData;
        }
    }
}
