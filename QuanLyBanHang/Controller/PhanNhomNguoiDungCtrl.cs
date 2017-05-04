using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using QuanLyBanHang.DataLayer;
using QuanLyBanHang.Bussiness;

namespace QuanLyBanHang.Controller
{
    public class PhanNhomNguoiDungCtrl
    {
        PhanNhomNguoiDungData m_PhanNhomNguoiDungData = new PhanNhomNguoiDungData();
        PhanNhomNguoiDungInfo m_PhanNhomNguoiDungInfo = new PhanNhomNguoiDungInfo();

        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = new DataTable();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "MaNhomNguoiDung";
            cbx.ValueMember = "MaNV";
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_PhanNhomNguoiDungData.LayPhanNhomNguoiDung();
            cmbColumn.DisplayMember = "MaNhomNguoiDung";
            cmbColumn.ValueMember = "MaNV";
            cmbColumn.DataPropertyName = "MaNV";
            cmbColumn.HeaderText = "Ten dang nhap";
        }
        #endregion

        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_PhanNhomNguoiDungData.LayPhanNhomNguoiDung();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_PhanNhomNguoiDungData.ThemDongMoi();
        }
        public void ThemPhanNhomNguoiDung(DataRow m_Row)
        {
            m_PhanNhomNguoiDungData.ThemPhanNhomNguoiDung(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuPhanNhomNguoiDung()
        {
            return m_PhanNhomNguoiDungData.LuuPhanNhomNguoiDung();
        }
        #endregion
    }
}
