﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHang.Bussiness
{
    public class DoanhThuInfo
    {
         public DoanhThuInfo()
        {
        }
         private String m_Mã_Mặt_Hàng;
         public String Mã_Mặt_Hàng
         {
             get { return m_Mã_Mặt_Hàng; }
             set { m_Mã_Mặt_Hàng = value; }
         }

         private String m_Tên_Mặt_Hàng;
         public String Tên_Mặt_Hàng
         {
             get { return m_Tên_Mặt_Hàng; }
             set { m_Tên_Mặt_Hàng = value; }
         }

         private int m_Tháng;
         public int Tháng
         {
             get { return m_Tháng; }
             set { m_Tháng = value; }
         }

         private MatHangInfo m_MaMH;
         public MatHangInfo MaMH
         {
             get { return m_MaMH; }
             set { m_MaMH = value; }
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
         private float m_Tổng_Xuất;
         public float Tổng_Xuất
         {
             get { return m_Tổng_Xuất; }
             set { m_Tổng_Xuất = value; }
         }
    }
}
