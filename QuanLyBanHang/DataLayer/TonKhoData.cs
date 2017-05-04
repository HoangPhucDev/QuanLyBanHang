using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanHang.General;

namespace QuanLyBanHang.DataLayer
{
    public class TonKhoData
    {
        DataService m_TonKhoData = new DataService();
        public DataTable LayTonKho()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TonKho");
            m_TonKhoData.Load(cmd);
            return m_TonKhoData;
        }
        public DataTable LayDSTonKhoTheoThang(int thang, int nam)
        {
            SqlCommand cmd = new SqlCommand("SELECT MH.MaMH, TK.[Mã Mặt Hàng], Tk.[Tên Mặt Hàng], TK.Tháng, TK.Năm, TK.[Tồn Kho] FROM TonKho TK INNER JOIN Mat_Hang MH ON MH.MaMH = TK.[Mã Mặt Hàng] AND MH.TenMH = TK.[Tên Mặt Hàng] WHERE TK.Tháng = @Tháng AND TK.Năm = @Năm");
            cmd.Parameters.Add("Tháng", SqlDbType.Int).Value = thang;
            cmd.Parameters.Add("Năm", SqlDbType.Int).Value = nam;
            m_TonKhoData.Load(cmd);
            return m_TonKhoData;
        }
    }
}
