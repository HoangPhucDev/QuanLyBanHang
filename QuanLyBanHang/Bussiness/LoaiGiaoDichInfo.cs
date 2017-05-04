using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHang.Bussiness
{
    public class LoaiGiaoDichInfo
    {
        public LoaiGiaoDichInfo()
        {
        }

        private String m_MaLoaiGiaoDich;
        public String MaLoaiGiaoDich
        {
            get { return m_MaLoaiGiaoDich; }
            set { m_MaLoaiGiaoDich = value; }
        }

        private String m_TenGiaoDich;
        public String TenGiaoDich
        {
            get { return m_TenGiaoDich; }
            set { m_TenGiaoDich = value; }
        }
    }
}
