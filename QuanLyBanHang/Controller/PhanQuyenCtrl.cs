using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QuanLyBanHang.Bussiness;
using QuanLyBanHang.DataLayer;

namespace QuanLyBanHang.Controller
{
    public class PhanQuyenCtrl
    {
        PhanQuyenData m_PhanQuyenData = new PhanQuyenData();
        PhanQuyenInfo m_PhanQuyenInfo = new PhanQuyenInfo();

        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = new DataTable();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "TenDangNhap";
            cbx.ValueMember = "MaQuyen";
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_PhanQuyenData.LayPhanQuyen();
            cmbColumn.DisplayMember = "TenDangNhap";
            cmbColumn.ValueMember = "MaQuyen";
            cmbColumn.DataPropertyName = "MaQuyen";
            cmbColumn.HeaderText = "Ten dang nhap";
        }
        #endregion

        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_PhanQuyenData.LayPhanQuyen();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_PhanQuyenData.ThemDongMoi();
        }
        public void ThemPhanQuyen(DataRow m_Row)
        {
            m_PhanQuyenData.ThemPhanQuyen(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuPhanQuyen()
        {
            return m_PhanQuyenData.LuuPhanQuyen();
        }
        #endregion

        #region DangNhap

        private String m_PhanQuyen;
        public String PhanQuyen
        {
            get { return m_PhanQuyen; }
            set { m_PhanQuyen = value; }
        }

        public int DangNhap(String m_UserName, String m_Pass)
        {
            m_PhanQuyenInfo.MatKhau = m_Pass;
            m_PhanQuyenInfo.TenDangNhap = m_UserName;

            DataTable Pq = m_PhanQuyenData.LayPhanQuyen(m_PhanQuyenInfo.TenDangNhap);

            if (Pq.Rows.Count == 0)
                return 0;
            String m_Str = Pq.Rows[0]["MatKhau"].ToString();

            if (m_Str != m_Pass)
                return 1;

            else
            {
                PhanQuyen = Pq.Rows[0]["MaQuyen"].ToString();
                return 2;
            }
        }

        public String LayTenNguoiDung(string m_Name)
        {
            m_PhanQuyenInfo.TenDangNhap = m_Name;

            DataTable TenND = m_PhanQuyenData.LayPhanQuyen(m_PhanQuyenInfo.TenDangNhap);

            if (TenND.Rows.Count == 0)
                return "";
            else
                return TenND.Rows[0]["TenDangNhap"].ToString();
        }
        #endregion

        #region Doi mat khau
        public void DoiMatKhau(String TenDN, String MatKhauMoi)
        {
            m_PhanQuyenData.DoiMatKhau(TenDN, MatKhauMoi);
        }
        #endregion
    }
}
