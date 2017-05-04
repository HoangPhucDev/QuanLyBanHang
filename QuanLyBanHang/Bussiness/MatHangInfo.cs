using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHang.Bussiness
{
    public class MatHangInfo
    {
        public MatHangInfo()
        {
        }

        private String m_MaPhieu;
        public String MaPhieu
        {
            get { return m_MaPhieu; }
            set { m_MaPhieu = value; }
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

        private NhaCungCapInfo m_MaNCC;
        public NhaCungCapInfo MaNCC
        {
            get { return m_MaNCC; }
            set { m_MaNCC = value; }
        }

        private NhaCungCapInfo m_TenNCC;
        public NhaCungCapInfo TenNCC
        {
            get { return m_TenNCC; }
            set { m_TenNCC = value; }
        }

        private LoaiTienInfo m_MaLoaiTien;
        public LoaiTienInfo MaLoaiTien
        {
            get { return m_MaLoaiTien; }
            set { m_MaLoaiTien = value; }
        }

        private LoaiGiaoDichInfo m_MaLoaiGiaoDich;
        public LoaiGiaoDichInfo MaLoaiGiaoDich
        {
            get { return m_MaLoaiGiaoDich; }
            set { m_MaLoaiGiaoDich = value; }
        }

        private DateTime m_NgayNhap;
        public DateTime NgayNhap
        {
            get { return m_NgayNhap; }
            set { m_NgayNhap = value; }
        }

        private String m_SoLuong;
        public String SoLuong
        {
            get { return m_SoLuong; }
            set { m_SoLuong = value; }
        }

        private String m_DonGia;
        public String DonGia
        {
            get { return m_DonGia; }
            set { m_DonGia = value; }
        }

        private String m_GiaBan;
        public String GiaBan
        {
            get { return m_GiaBan; }
            set { m_GiaBan = value; }
        }

    }
}
