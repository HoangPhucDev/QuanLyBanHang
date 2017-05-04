using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QuanLyBanHang.DataLayer;

namespace QuanLyBanHang.Controller
{

    public class QuayGiaoDichCtrl
    {
        QuayGiaoDichData m_QuayGiaoDichData = new QuayGiaoDichData();

        public void HienThiComboBox(ComboBox cbx)
        {
            cbx.DataSource = m_QuayGiaoDichData.LayQuayGiaoDich();
            cbx.DisplayMember = "TenQuayGiaoDich";
            cbx.ValueMember = "MaQuayGiaoDich";
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_QuayGiaoDichData.LayQuayGiaoDich();
            cmbColumn.DisplayMember = "TenQuayGiaoDich";
            cmbColumn.ValueMember = "MaQuayGiaoDich";
            cmbColumn.DataPropertyName = "MaQuayGiaoDich";
            cmbColumn.HeaderText = "Tên quầy Giao Dịch";
        }
        #endregion

        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_QuayGiaoDichData.LayQuayGiaoDich();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_QuayGiaoDichData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_QuayGiaoDichData.ThemQuayGiaoDich(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuQuayGiaoDich()
        {
            return m_QuayGiaoDichData.LuuQuayGiaoDich();
        }
        #endregion

    }
}
