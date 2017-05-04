using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyBanHang.DataLayer;
using System.Windows.Forms;

namespace QuanLyBanHang.Controller
{
    public class QuyenCtrl
    {
        QuyenData m_QuyenData = new QuyenData();

        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = new DataTable();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "TenQuyen";
            cbx.ValueMember = "MaQuyen";
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_QuyenData.LayQuyen();
            cmbColumn.DisplayMember = "TenQuyen";
            cmbColumn.ValueMember = "MaQuyen";
            cmbColumn.DataPropertyName = "MaQuyen";
            cmbColumn.HeaderText = "Quyền người dùng";
        }
        #endregion

        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_QuyenData.LayQuyen();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_QuyenData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_QuyenData.ThemQuyen(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuQuyen()
        {
            return m_QuyenData.LuuQuyen();
        }
        #endregion
    }
}
