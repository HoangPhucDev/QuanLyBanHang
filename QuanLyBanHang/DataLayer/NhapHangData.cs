using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanHang.General;

namespace QuanLyBanHang.DataLayer
{
    public class NhapHangData
    {
        DataService m_NhapHangData = new DataService();
         public DataTable LayNhapHang()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhapHang");
            m_NhapHangData.Load(cmd);
            return m_NhapHangData;
        }
         public DataTable LayDSNhapHangTheoThang(int thang, int nam)
         {
             SqlCommand cmd = new SqlCommand("SELECT NCC.MaNCC, NCC.DiaChi, NCC.DienThoai, NCC.TenNCC, NH.MaMH, NH.TenMH, NH.NgayNhap, NH.Tháng, NH.Năm, NH.[Tổng Nhập], NH.SoLuong, NH.GiaBan, NH.DonGia, NH.TenNCC, NH.TenLoaiGiaoDich, NH.LoaiTien FROM NhapHang NH INNER JOIN Mat_Hang MH ON MH.MaMH = NH.MaMH AND MH.TenMH = NH.TenMH INNER JOIN Nha_Cung_Cap NCC ON NCC.TenNCC = NH.TenNCC INNER JOIN Loai_Tien LT ON LT.LoaiTien = NH.LoaiTien INNER JOIN Loai_Giao_Dich LGD ON LGD.TenLoaiGiaoDich = NH.TenLoaiGiaoDich WHERE NH.Tháng = @Tháng AND NH.Năm = @Năm");
             cmd.Parameters.Add("Tháng", SqlDbType.Int).Value = thang;
             cmd.Parameters.Add("Năm", SqlDbType.Int).Value = nam;
             m_NhapHangData.Load(cmd);
             return m_NhapHangData;
         }
    }
}
