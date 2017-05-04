using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHang.Bussiness
{
    public class LoaiTienInfo
    {

        public LoaiTienInfo()
        {
        }

        private String m_MaLoaiTien;
        public String MaLoaiTien
        {
            get { return m_MaLoaiTien; }
            set { m_MaLoaiTien = value; }
        }

        private String m_LoaiTien;
        public String LoaiTien
        {
            get { return m_LoaiTien; }
            set { m_LoaiTien = value; }
        }
        
    }
}
