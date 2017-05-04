using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHang.Bussiness
{
    public class NhanVienInfo
    {
        public NhanVienInfo()
        {
        }

        private String m_MaNV;
        public String MaNV
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
        }

        private String m_HoTen;
        public String HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        }

        private QuayGiaoDichInfo m_MaQuayGD;
        public QuayGiaoDichInfo MaQuayGD
        {
            get { return m_MaQuayGD; }
            set { m_MaQuayGD = value; }
        }

        private DateTime m_NgaySinh;
        public DateTime NgaySinh
        {
            get { return m_NgaySinh; }
            set { m_NgaySinh = value; }
        }

        private String m_DiaChi;
        public String DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }

        private String m_DienThoai;
        public String DienThoai
        {
            get { return m_DienThoai; }
            set { m_DienThoai = value; }
        }


    }
}
