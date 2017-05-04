using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHang.Bussiness
{
    public class DatHangInfo
    {
        public DatHangInfo()
        {
        }
        private String m_MaPhieu;
        public String MaPhieu
        {
            get { return m_MaPhieu; }
            set { m_MaPhieu = value; }
        }

        private MatHangInfo m_MaMH;
        public MatHangInfo MaMH
        {
            get { return m_MaMH; }
            set { m_MaMH = value; }
        }

        private KhachHangInfo m_MaKH;
        public KhachHangInfo MaKH
        {
            get { return m_MaKH; }
            set { m_MaKH = value; }
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

        private bool m_ThanhToan;
        public bool ThanhToan
        {
            get { return m_ThanhToan; }
            set { m_ThanhToan = value; }
        }

        private DateTime m_NgayDat;
        public DateTime NgayDat
        {
            get { return m_NgayDat; }
            set { m_NgayDat = value; }
        }

        private String m_SoLuong;
        public String SoLuong
        {
            get { return m_SoLuong; }
            set { m_SoLuong = value; }
        }

        private String m_ThanhTien;
        public String ThanhTien
        {
            get { return m_ThanhTien; }
            set { m_ThanhTien = value; }
        }

        private String m_GiaBan;
        public String GiaBan
        {
            get { return m_GiaBan; }
            set { m_GiaBan = value; }
        }

        private String m_GhiChu;
        public String GhiChu
        {
            get { return m_GhiChu; }
            set { m_GhiChu = value; }
        }
    }
}
