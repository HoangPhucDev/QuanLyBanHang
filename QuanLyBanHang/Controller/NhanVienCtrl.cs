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
    public class NhanVienCtrl
    {
        NhanVienData m_NhanVienData = new NhanVienData();
        NhanVienInfo m_NhanVienInfo = new NhanVienInfo();
        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_NhanVienData.LayNhanVien();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "HoTenNV";

            cbx.ValueMember = "MaNV";


        }

        public static IList<NhanVienInfo> LayDsNhanVien()
        {
            IList<NhanVienInfo> ds = new List<NhanVienInfo>();

            NhanVienData data = new NhanVienData();
            DataTable tbl = data.LayDSNhanVien();

            IList<NhanVienInfo> NhanVien = new List<NhanVienInfo>();

            foreach (DataRow row in tbl.Rows)
            {
                NhanVienInfo NV = new NhanVienInfo();

                QuayGiaoDichInfo m_QGD = new QuayGiaoDichInfo();
                m_QGD.TenQuayGD = Convert.ToString(row["TenQuayGiaoDich"]);

                NV.MaNV = Convert.ToString(row["MaNV"]);
                NV.HoTen = Convert.ToString(row["HoTenNV"]);
                NV.DiaChi = Convert.ToString(row["DiaChi"]);
                NV.DienThoai = Convert.ToString(row["DienThoai"]);
                NV.NgaySinh = Convert.ToDateTime(row["NgaySinh"]);

                NV.MaQuayGD = m_QGD;

                NhanVien.Add(NV);
            }
            return NhanVien;
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_NhanVienData.LayNhanVien();
            cmbColumn.DisplayMember = "HoTenNV";
            cmbColumn.ValueMember = "MaNV";
            cmbColumn.DataPropertyName = "MaNV";
            cmbColumn.HeaderText = "Tên nhân viên";
        }
        #endregion

        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_NhanVienData.LayNhanVien();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaNV,
                            TextBoxX txtHoTen,
                            DateTimeInput dtNgaySinh,
                            TextBoxX txtDiaChi,
                            TextBoxX txtSoDienThoai,
                            ComboBoxEx cmbQuayGiaoDich)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_NhanVienData.LayNhanVien();

            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", bS, "MaNV");

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", bS, "HoTenNV");

            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", bS, "DienThoai");

            dtNgaySinh.DataBindings.Clear();
            dtNgaySinh.DataBindings.Add("Value", bS, "NgaySinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bS, "DiaChi");

            cmbQuayGiaoDich.DataBindings.Clear();
            cmbQuayGiaoDich.DataBindings.Add("SelectedValue", bS, "MaQuayGiaoDich");


            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_NhanVienData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_NhanVienData.ThemNhanVien(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuNhanVien()
        {
            return m_NhanVienData.LuuNhanVien();
        }

        public void LuuNhanVien(String manv, String hoten, DateTime ngaysinh, String diachi, String dienthoai, String maquaygd)
        {
            m_NhanVienData.LuuNhanVien(manv, hoten, ngaysinh, diachi, dienthoai, maquaygd);
        }
        #endregion

        #region Sửa
        public void SuaNhanVien(String manv, String hoten, DateTime ngaysinh, String diachi, String dienthoai, String maquaygd)
        {
            m_NhanVienData.SuaNhanVien(manv, hoten, ngaysinh, diachi, dienthoai, maquaygd);
        }
        #endregion

        #region Xóa
        public void XoaNhanVien(String manv)
        {
            m_NhanVienData.XoaNhanVien(manv);
        }
        #endregion
        #region tim kiem
        public void TimKiemTheoMa(String m_MaNV)
        {
            m_NhanVienData.TimKiemTheoMa(m_MaNV);
        }

        public void TiemKiemTheoTen(String m_HoTen)
        {
            m_NhanVienData.TimKiemTheoTen(m_HoTen);
        }
        #endregion

    }
}
