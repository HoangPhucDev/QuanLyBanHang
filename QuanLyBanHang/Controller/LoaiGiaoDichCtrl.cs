using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using QuanLyBanHang.DataLayer;
using QuanLyBanHang.General;

namespace QuanLyBanHang.Controller
{
    public class LoaiGiaoDichCtrl
    {
        LoaiGiaoDichData m_LoaiGiaoDichData = new LoaiGiaoDichData();

        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_LoaiGiaoDichData.LayLoaiGiaoDich();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "TenLoaiGiaoDich";
            cbx.ValueMember = "MaLoaiGiaoDich";
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_LoaiGiaoDichData.LayLoaiGiaoDich();
            cmbColumn.DisplayMember = "TenLoaiGiaoDich";
            cmbColumn.ValueMember = "MaLoaiGiaoDich";
            cmbColumn.DataPropertyName = "MaLoaiGiaoDich";
            cmbColumn.HeaderText = "Loại Giao Dịch";
        }
        #endregion

        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_LoaiGiaoDichData.LayLoaiGiaoDich();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaLoaiGiaoDich,
                            TextBoxX txtTenLoaiGiaoDich)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_LoaiGiaoDichData.LayLoaiGiaoDich();

            txtMaLoaiGiaoDich.DataBindings.Clear();
            txtMaLoaiGiaoDich.DataBindings.Add("Text", bS, "MaLoaiGiaoDich");

            txtTenLoaiGiaoDich.DataBindings.Clear();
            txtTenLoaiGiaoDich.DataBindings.Add("Text", bS, "TenLoaiGiaoDich");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_LoaiGiaoDichData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_LoaiGiaoDichData.ThemLoaiGiaoDich(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuLoaiGiaoDich()
        {
            return m_LoaiGiaoDichData.LuuLoaiGiaoDich();
        }
        #endregion 
    }
}
