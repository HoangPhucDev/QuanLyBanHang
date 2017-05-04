using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QuanLyBanHang.DataLayer;

namespace QuanLyBanHang.Controller
{
    public class NhomNguoiDungCtrl
    {
        NhomNguoiDungData m_NguoiDungData = new NhomNguoiDungData();

        public void HienThiComboBox(ComboBox cbx)
        {
            cbx.DataSource = m_NguoiDungData.LayNguoiDung();
            cbx.DisplayMember = "TenNhomNguoiDung";
            cbx.ValueMember = "MaNhomNguoiDung";
        }

        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_NguoiDungData.LayNguoiDung();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_NguoiDungData.LayNguoiDung();
            cmbColumn.DisplayMember = "TenNhomNguoiDung";
            cmbColumn.ValueMember = "MaNhomNguoiDung";
            cmbColumn.DataPropertyName = "MaNhomNguoiDung";
            cmbColumn.HeaderText = "Tên nhóm người dùng";
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_NguoiDungData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_NguoiDungData.ThemNguoiDung(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuNguoiDung()
        {
            return m_NguoiDungData.LuuNguoiDung();
        }
        #endregion
    }
}
