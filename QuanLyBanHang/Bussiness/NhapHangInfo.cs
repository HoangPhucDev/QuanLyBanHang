using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHang.Bussiness
{
    public class NhapHangInfo
    {
          public NhapHangInfo()
        {
        }
          private NhaCungCapInfo m_NCC;
          public NhaCungCapInfo NCC
          {
              get { return m_NCC; }
              set { m_NCC = value; }
          }

         private String m_MaMH;
         public String MaMH
         {
             get { return m_MaMH; }
             set { m_MaMH = value; }
         }

         private String m_TenMH;
         public String TenMH
         {
             get { return m_TenMH; }
             set { m_TenMH = value; }
         }

         private String m_TenNCC;
         public String TenNCC
         {
             get { return m_TenNCC; }
             set { m_TenNCC = value; }
         }

         private String m_LoaiTien;
         public String LoaiTien
         {
             get { return m_LoaiTien; }
             set { m_LoaiTien = value; }
         }

         private String m_LoaiGD;
         public String LoaiGD
         {
             get { return m_LoaiGD; }
             set { m_LoaiGD = value; }
         }

         private DateTime m_NgayNhap;
         public DateTime NgayNhap
         {
             get { return m_NgayNhap; }
             set { m_NgayNhap = value; }
         }

         private int m_Tháng;
         public int Tháng
         {
             get { return m_Tháng; }
             set { m_Tháng = value; }
         }
         private int m_Năm;
         public int Năm
         {
             get { return m_Năm; }
             set { m_Năm = value; }
         }

         private float m_Tổng_Nhập;
         public float Tổng_Nhập
         {
             get { return m_Tổng_Nhập; }
             set { m_Tổng_Nhập = value; }
         }
         private float m_DonGia;
         public float DonGia
         {
             get { return m_DonGia; }
             set { m_DonGia = value; }
         }

         private float m_GiaBan;
         public float GiaBan
         {
             get { return m_GiaBan; }
             set { m_GiaBan = value; }
         }

         private float m_SoLuong;
         public float SoLuong
         {
             get { return m_SoLuong; }
             set { m_SoLuong = value; }
         }
    }
}
