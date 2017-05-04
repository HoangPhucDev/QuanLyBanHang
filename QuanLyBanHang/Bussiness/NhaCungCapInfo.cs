using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHang.Bussiness
{
    public class NhaCungCapInfo
    {
        public NhaCungCapInfo()
        {
        }

        private String m_MaNCC;
        public String MaNCC
        {
            get { return m_MaNCC; }
            set { m_MaNCC = value; }
        }

        private String m_TenNCC;
        public String TenNCC
        {
            get { return m_TenNCC; }
            set { m_TenNCC = value; }
        }

        private MatHangInfo m_MaMH;
        public MatHangInfo MaMH
        {
            get { return m_MaMH; }
            set { m_MaMH = value; }
        }

        private String m_DiaChi;
        public String DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }

        private String m_Fax;
        public String Fax
        {
            get { return m_Fax; }
            set { m_Fax = value; }
        }

        private String m_Email;
        public String Email
        {
            get { return m_Email; }
            set { m_Email = value; }
        }

        private String m_DienThoai;
        public String DienThoai
        {
            get { return m_DienThoai; }
            set { m_DienThoai = value; }
        }

        private String m_GhiChu;
        public String GhiChu
        {
            get { return m_GhiChu; }
            set { m_GhiChu = value; }
        }
    }
}
