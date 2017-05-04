using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHang.Bussiness
{
    public class QuayGiaoDichInfo
    {
        public QuayGiaoDichInfo()
        {
        }

        private String m_TenQuayGD;
        public String TenQuayGD
        {
            get { return m_TenQuayGD; }
            set { m_TenQuayGD = value; }
        }

        private String m_MaQuayGD;
        public String MaQuayGD
        {
            get { return m_MaQuayGD; }
            set { m_MaQuayGD = value; }
        }


    }
}
