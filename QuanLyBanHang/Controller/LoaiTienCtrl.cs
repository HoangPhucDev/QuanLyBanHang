using System;
using System.Collections.Generic;
using System.Linq;
using DevComponents.Editors.DateTimeAdv;
using QuanLyBanHang.DataLayer;
using QuanLyBanHang.General;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
namespace QuanLyBanHang.Controller
{
    public class LoaiTienCtrl
    {
        LoaiTienData m_LoaiTienData = new LoaiTienData();



        #region Hien thi

        public void HienThiComboBox(ComboBox cbx)
        {
            cbx.DataSource = m_LoaiTienData.LayLoaiTien();
            cbx.DisplayMember = "LoaiTien";
            cbx.ValueMember = "MaLoaiTien";
        }

        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_LoaiTienData.LayLoaiTien();
            cmbColumn.DisplayMember = "LoaiTien";
            cmbColumn.ValueMember = "MaLoaiTien";
            cmbColumn.DataPropertyName = "MaLoaiTien";
            cmbColumn.HeaderText = "Loại Tiền";
        }
        #endregion

        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_LoaiTienData.LayLoaiTien();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaLoaiTien,
                            TextBoxX txtLoaiTien)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_LoaiTienData.LayLoaiTien();

            txtMaLoaiTien.DataBindings.Clear();
            txtMaLoaiTien.DataBindings.Add("Text", bS, "MaLoaiTien");

            txtLoaiTien.DataBindings.Clear();
            txtLoaiTien.DataBindings.Add("Text", bS, "LoaiTien");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_LoaiTienData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_LoaiTienData.ThemLoaiTien(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuLoaiTien()
        {
            return m_LoaiTienData.LuuLoaiTien();
        }
        #endregion 
    }
}
