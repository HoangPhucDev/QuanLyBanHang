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
using QuanLyBanHang.Bussiness;

namespace QuanLyBanHang.Controller
{
    public class MatHangCtrl
    {
        MatHangData m_MatHangData = new MatHangData();
        MatHangInfo m_MatHangInfo = new MatHangInfo();
        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_MatHangData.LayMatHang();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "TenMH";

            cbx.ValueMember = "MaMH";


        }

        public void HienThiComboBox1(ComboBox cbx)
        {
            DataTable m_DT = m_MatHangData.LayMatHang();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "MaPhieu";

            cbx.ValueMember = "MaPhieu";
        }
        public static IList<MatHangInfo> LayDsMatHang()
        {
            IList<MatHangInfo> ds = new List<MatHangInfo>();

            MatHangData data = new MatHangData();
            DataTable tbl = data.LayDSMatHang();

            IList<MatHangInfo> MatHang = new List<MatHangInfo>();

            foreach (DataRow row in tbl.Rows)
            {
                MatHangInfo MH = new MatHangInfo();

                NhaCungCapInfo m_NCC = new NhaCungCapInfo();
                m_NCC.TenNCC = Convert.ToString(row["TenNCC"]);
                LoaiTienInfo m_LoaiTien = new LoaiTienInfo();
                m_LoaiTien.LoaiTien = Convert.ToString(row["LoaiTien"]);
                LoaiGiaoDichInfo m_LoaiGD = new LoaiGiaoDichInfo();
                m_LoaiGD.TenGiaoDich = Convert.ToString(row["TenLoaiGiaoDich"]);

                MH.MaPhieu = Convert.ToString(row["MaPhieu"]);
                MH.MaMH = Convert.ToString(row["MaMH"]);
                MH.TenMH = Convert.ToString(row["TenMH"]);
                MH.SoLuong = Convert.ToString(row["SoLuong"]);
                MH.DonGia = Convert.ToString(row["DonGia"]);
                MH.GiaBan = Convert.ToString(row["GiaBan"]);
                MH.NgayNhap = Convert.ToDateTime(row["NgayNhap"]);
                MH.MaNCC = m_NCC;
                MH.MaLoaiGiaoDich = m_LoaiGD;
                MH.MaLoaiTien = m_LoaiTien;
                MatHang.Add(MH);
            }
            return MatHang;
        }

        public static IList<MatHangInfo> LayDsMatHangTheoMa(String MaPhieu)
        {
            IList<MatHangInfo> ds = new List<MatHangInfo>();

            MatHangData data = new MatHangData();
            DataTable tbl = data.LayDSMatHangTheoMa(MaPhieu);

            IList<MatHangInfo> MatHang = new List<MatHangInfo>();

            foreach (DataRow row in tbl.Rows)
            {
                MatHangInfo MH = new MatHangInfo();

                NhaCungCapInfo m_NCC = new NhaCungCapInfo();
                m_NCC.TenNCC = Convert.ToString(row["TenNCC"]);
                m_NCC.MaNCC = Convert.ToString(row["MaNCC"]);
                LoaiTienInfo m_LoaiTien = new LoaiTienInfo();
                m_LoaiTien.LoaiTien = Convert.ToString(row["LoaiTien"]);
                LoaiGiaoDichInfo m_LoaiGD = new LoaiGiaoDichInfo();
                m_LoaiGD.TenGiaoDich = Convert.ToString(row["TenLoaiGiaoDich"]);

                MH.MaPhieu = Convert.ToString(row["MaPhieu"]);
                MH.MaMH = Convert.ToString(row["MaMH"]);
                MH.TenMH = Convert.ToString(row["TenMH"]);
                MH.SoLuong = Convert.ToString(row["SoLuong"]);
                MH.DonGia = Convert.ToString(row["DonGia"]);
                MH.GiaBan = Convert.ToString(row["GiaBan"]);
                MH.NgayNhap = Convert.ToDateTime(row["NgayNhap"]);
                MH.MaNCC = m_NCC;
                MH.MaLoaiGiaoDich = m_LoaiGD;
                MH.MaLoaiTien = m_LoaiTien;
                MatHang.Add(MH);
            }
            return MatHang;
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_MatHangData.LayMatHang();
            cmbColumn.DisplayMember = "TenMH";
            cmbColumn.ValueMember = "MaMH";
            cmbColumn.DataPropertyName = "MaMH";
            cmbColumn.HeaderText = "Tên mặt hàng";
        }
        #endregion

        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_MatHangData.LayMatHang();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                             TextBoxX txtMaPhieu,
                            TextBoxX txtMaMH,
                            TextBoxX txtTenMH,
                            DateTimeInput dtNgayNhap,
                            TextBoxX txtSoLuong,
                            TextBoxX txtDonGia,
                            TextBoxX txtGiaBan,
                            TextBoxX txtMaNCC,
                            ComboBoxEx cmbTenNCC,
                            ComboBoxEx cmbLoaiGiaoDich,
                            ComboBoxEx cmbLoaiTienGui)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_MatHangData.LayMatHang();

            txtMaPhieu.DataBindings.Clear();
            txtMaPhieu.DataBindings.Add("Text", bS, "MaPhieu");

            txtMaMH.DataBindings.Clear();
            txtMaMH.DataBindings.Add("Text", bS, "MaMH");

            txtTenMH.DataBindings.Clear();
            txtTenMH.DataBindings.Add("Text", bS, "TenMH");

            dtNgayNhap.DataBindings.Clear();
            dtNgayNhap.DataBindings.Add("Value", bS, "NgayNhap");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", bS, "SoLuong");

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", bS, "DonGia");


            txtGiaBan.DataBindings.Clear();
            txtGiaBan.DataBindings.Add("Text", bS, "GiaBan");

            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("Text", bS, "MaNCC");

            cmbLoaiGiaoDich.DataBindings.Clear();
            cmbLoaiGiaoDich.DataBindings.Add("SelectedValue", bS, "MaLoaiGiaoDich");



            cmbTenNCC.DataBindings.Clear();
            cmbTenNCC.DataBindings.Add("SelectedValue", bS, "MaNCC");

            cmbLoaiTienGui.DataBindings.Clear();
            cmbLoaiTienGui.DataBindings.Add("SelectedValue", bS, "MaLoaiTien");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_MatHangData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_MatHangData.ThemMatHang(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuMatHang()
        {
            return m_MatHangData.LuuMatHang();
        }

        public void LuuMatHang(String maphieu, String mamh, String tenmh, float soluong, float dongia, float giaban, String mancc, DateTime ngaynhap, String maloaitien, String maloaigd)
        {
            m_MatHangData.LuuMatHang(maphieu, mamh, tenmh, soluong, dongia, giaban, mancc, ngaynhap, maloaitien, maloaigd);
        }
        #endregion
        #region Sửa
        public void SuaMatHang(String maphieu, String mamh, String tenmh, float soluong, float dongia, float giaban, String mancc, DateTime ngaynhap, String maloaitien, String maloaigd)
        {
            m_MatHangData.SuaMatHang(maphieu, mamh, tenmh, soluong, dongia, giaban, mancc, ngaynhap, maloaitien, maloaigd);
        }
        #endregion

        #region Xóa
        public void XoaMatHang(String maphieu, String mamh)
        {
            m_MatHangData.XoaMatHang(maphieu, mamh);
        }
        #endregion
        #region tim kiem
        public void TimKiemTheoMa(String m_MaMH)
        {
            m_MatHangData.TimKiemTheoMa(m_MaMH);
        }

        public void TiemKiemTheoTen(String m_TenMH)
        {
            m_MatHangData.TimKiemTheoTen(m_TenMH);
        }
        #endregion
    }
}
