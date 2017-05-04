using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHang.Bussiness
{
    public class XuatHangInfo
    {
        public XuatHangInfo()
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

        private NhanVienInfo m_MaNV;
        public NhanVienInfo MaNV
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
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

        private DateTime m_NgayXuat;
        public DateTime NgayXuat
        {
            get { return m_NgayXuat; }
            set { m_NgayXuat = value; }
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
    }
}
