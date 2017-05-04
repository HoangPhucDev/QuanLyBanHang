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
using QuanLyBanHang.Bussiness;

namespace QuanLyBanHang.Controller
{
     public class NhaCungCapCtrl
    {
         NhaCungCapData m_NhaCungCapData = new NhaCungCapData();
         NhaCungCapInfo m_NhaCungCapInfo = new NhaCungCapInfo();
        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_NhaCungCapData.LayNhaCungCap();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "TenNCC";

            cbx.ValueMember = "MaNCC";


        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_NhaCungCapData.LayNhaCungCap();
            cmbColumn.DisplayMember = "TenNCC";
            cmbColumn.ValueMember = "MaNCC";
            cmbColumn.DataPropertyName = "MaNCC";
            cmbColumn.HeaderText = "Tên nhà cung cấp";
        }
        #endregion

        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_NhaCungCapData.LayNhaCungCap();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaNCC,
                            TextBoxX txtTenNhaCC,
                            TextBoxX txtEmail,
                            TextBoxX txtDiaChi,
                            TextBoxX txtFax,
                            TextBoxX txtGhiChu,
                            TextBoxX txtDienThoai)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_NhaCungCapData.LayNhaCungCap();

            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("Text", bS, "MaNCC");

            txtTenNhaCC.DataBindings.Clear();
            txtTenNhaCC.DataBindings.Add("Text", bS, "TenNCC");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", bS, "Email");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bS, "DiaChi");

            txtFax.DataBindings.Clear();
            txtFax.DataBindings.Add("Text", bS, "Fax");


            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", bS, "GhiChu");

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bS, "DienThoai");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_NhaCungCapData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_NhaCungCapData.ThemNhaCungCap(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuNhaCungCap()
        {
            return m_NhaCungCapData.LuuNhaCungCap();
        }

        public void LuuNhaCungCap(String mancc, String tenncc, String dienthoai, String fax, String email, String diachi, String ghichu)
        {
            m_NhaCungCapData.LuuNhaCungCap(mancc, tenncc, dienthoai, fax, email, diachi, ghichu);
        }
        #endregion

        #region Sửa

        public void SuaNhaCungCap(String mancc, String tenncc, String dienthoai, String fax, String email, String diachi, String ghichu)
        {
            m_NhaCungCapData.SuaNhaCungCap(mancc, tenncc, dienthoai, fax, email, diachi, ghichu);
        }
        #endregion
        #region Xóa
        public void XoaNhaCungCap(String mancc)
        {
            m_NhaCungCapData.XoaNhaCungCap(mancc);
        }
        #endregion
        #region tim kiem
        public void TimKiemTheoMa(String m_MaNV)
        {
            m_NhaCungCapData.TimKiemTheoMa(m_MaNV);
        }

        public void TiemKiemTheoTen(String m_HoTen)
        {
            m_NhaCungCapData.TimKiemTheoTen(m_HoTen);
        }
        #endregion

    }
}
