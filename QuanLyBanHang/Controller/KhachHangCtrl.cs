using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using QuanLyBanHang.DataLayer;
using QuanLyBanHang.General;

namespace QuanLyBanHang.Controller
{
    class KhachHangCtrl
    {
        KhachHangData m_KhachHangData = new KhachHangData();

        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_KhachHangData.LayKhachHang();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "HoTen";
            cbx.ValueMember = "MaKH";
        }

        public void HienThiComboBox1(ComboBox cbx)
        {
            DataTable m_DT = m_KhachHangData.LayKhachHang();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "DiaChi";
            cbx.ValueMember = "MaKH";
        }
        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_KhachHangData.LayKhachHang();
            cmbColumn.DisplayMember = "HoTen";
            cmbColumn.ValueMember = "MaKH";
            cmbColumn.DataPropertyName = "MaKH";
            cmbColumn.HeaderText = "Tên khách hàng";
        }

        public void LayMaTheoTen(String TenKH)
        {
            DataTable dt = m_KhachHangData.LayMaKHTheoTen(TenKH);
            this.MaKH = dt.Rows[0]["MaKH"].ToString();
        }

        private String m_MaKH;
        public String MaKH
        {
            get { return m_MaKH; }
            set { m_MaKH = value; }
        }
        #endregion
        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_KhachHangData.LayKhachHang();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaKH,
                            TextBoxX txtHoTen,
                            TextBoxX txtDiaChi,
                            TextBoxX txtSoDienThoai
                            )
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_KhachHangData.LayKhachHang();

            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", bS, "MaKH");

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", bS, "HoTen");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bS, "DiaChi");

            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", bS, "DienThoai");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion
        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_KhachHangData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_KhachHangData.ThemKhachHang(m_Row);
        }
        #endregion
        #region Luu
        public bool LuuKhachHang()
        {
            return m_KhachHangData.LuuKhachHang();
        }

        public void LuuKhachHang(String makh, String hoten, String diachi, String dienthoai)
        {
            m_KhachHangData.LuuKhachHang(makh, hoten, diachi, dienthoai);
        }
        #endregion 
        #region Tim kiem

        public void TimKiemTheoMa(String m_MaKH)
        {
            m_KhachHangData.LayKHTheoMa(m_MaKH);
        }

        public void TimKiemTheoTen(String m_HoTen)
        {
            m_KhachHangData.LayKHTheoTen(m_HoTen);
        }

        #endregion
    }
}
