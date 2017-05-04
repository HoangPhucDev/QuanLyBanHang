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
    public class DatHangCtrl
    {
        DatHangData m_DatHangData = new DatHangData();
        DatHangInfo m_DatHangInfo = new DatHangInfo();


        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_DatHangData.LayDatHang();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "MaPhieu";

            cbx.ValueMember = "MaPhieu";
        }
        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_DatHangData.LayDatHang();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public static IList<DatHangInfo> LayDsDatHangTheoMa(String MaPhieu)
        {
            IList<DatHangInfo> ds = new List<DatHangInfo>();

            DatHangData data = new DatHangData();
            DataTable tbl = data.LayDSDatHangTheoMa(MaPhieu);

            IList<DatHangInfo> DatHang = new List<DatHangInfo>();

            foreach (DataRow row in tbl.Rows)
            {
                DatHangInfo DH = new DatHangInfo();

                MatHangInfo m_MH = new MatHangInfo();
                m_MH.TenMH = Convert.ToString(row["TenMH"]);
                m_MH.MaMH = Convert.ToString(row["MaMH"]);
                KhachHangInfo m_KH = new KhachHangInfo();
                m_KH.HoTen = Convert.ToString(row["HoTen"]);
                m_KH.MaKH = Convert.ToString(row["MaKH"]);
                LoaiTienInfo m_LoaiTien = new LoaiTienInfo();
                m_LoaiTien.LoaiTien = Convert.ToString(row["LoaiTien"]);
                LoaiGiaoDichInfo m_LoaiGD = new LoaiGiaoDichInfo();
                m_LoaiGD.TenGiaoDich = Convert.ToString(row["TenLoaiGiaoDich"]);

                DH.MaPhieu = Convert.ToString(row["MaPhieu"]);
                DH.ThanhToan = Convert.ToBoolean(row["ThanhToan"]);
                DH.SoLuong = Convert.ToString(row["SoLuong"]);
                DH.GiaBan = Convert.ToString(row["GiaBan"]);
                DH.ThanhTien = Convert.ToString(row["ThanhTien"]);
                DH.NgayDat = Convert.ToDateTime(row["NgayDat"]);
                DH.MaMH = m_MH;
                DH.MaKH = m_KH;
                DH.MaLoaiGiaoDich = m_LoaiGD;
                DH.MaLoaiTien = m_LoaiTien;
                DatHang.Add(DH);
            }
            return DatHang;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaPhieu,
                            DateTimeInput dtNgayDat,
                            TextBoxX txtSoLuong,
                            TextBoxX txtGiaBan,
                            TextBoxX txtThanhTien,
                            TextBoxX txtGhiChu,
                            CheckBoxX cbThanhToan,
                            ComboBoxEx cmbTenMH,
                            ComboBoxEx cmbTenKH,
                            ComboBoxEx cmbLoaiGiaoDich,
                            ComboBoxEx cmbLoaiTienGui)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_DatHangData.LayDatHang();
            DataTable dT = m_DatHangData.LayDatHang();
            bool dathang = Convert.ToBoolean(dT.Rows[0]["ThanhToan"]);

            if (dathang)
                cbThanhToan.Checked = true;
            else
                cbThanhToan.Checked = true;

            txtMaPhieu.DataBindings.Clear();
            txtMaPhieu.DataBindings.Add("Text", bS, "MaPhieu");

            dtNgayDat.DataBindings.Clear();
            dtNgayDat.DataBindings.Add("Value", bS, "NgayDat");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", bS, "SoLuong");

            txtGiaBan.DataBindings.Clear();
            txtGiaBan.DataBindings.Add("Text", bS, "GiaBan");

            txtThanhTien.DataBindings.Clear();
            txtThanhTien.DataBindings.Add("Text", bS, "ThanhTien");

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", bS, "GhiChu");

            cbThanhToan.DataBindings.Clear();
            cbThanhToan.DataBindings.Add("Checked", bS, "ThanhToan");

            cmbLoaiGiaoDich.DataBindings.Clear();
            cmbLoaiGiaoDich.DataBindings.Add("SelectedValue", bS, "MaLoaiGiaoDich");

            cmbTenMH.DataBindings.Clear();
            cmbTenMH.DataBindings.Add("SelectedValue", bS, "MaMH");

            cmbTenKH.DataBindings.Clear();
            cmbTenKH.DataBindings.Add("SelectedValue", bS, "MaKH");

            cmbLoaiTienGui.DataBindings.Clear();
            cmbLoaiTienGui.DataBindings.Add("SelectedValue", bS, "MaLoaiTien");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_DatHangData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_DatHangData.ThemDatHang(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuDatHang()
        {
            return m_DatHangData.LuuDatHang();
        }

        public void LuuDatHang(String maphieu, String mamh, String makh, float soluong, float giaban, float thanhtien, DateTime ngaydat, bool thanhtoan, String maloaitien, String maloaigd, String ghichu)
        {
            m_DatHangData.LuuDatHang(maphieu, mamh, makh, soluong, giaban, thanhtien, ngaydat, thanhtoan, maloaitien, maloaigd, ghichu);
        }
        #endregion

        #region Sửa
        public void SuaDatHang(String maphieu, String mamh, String makh, float soluong, float giaban, float thanhtien, DateTime ngaydat, bool thanhtoan, String maloaitien, String maloaigd, String ghichu)
        {
            m_DatHangData.SuaDatHang(maphieu, mamh, makh, soluong, giaban, thanhtien, ngaydat, thanhtoan, maloaitien, maloaigd, ghichu);
        }
        #endregion

        #region Xóa
        public void XoaDatHang(String maphieu, String mamh, String makh)
        {
            m_DatHangData.XoaDatHang(maphieu, mamh, makh);
        }
        #endregion
    }
}
