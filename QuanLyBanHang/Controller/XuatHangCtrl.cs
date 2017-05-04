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
    public class XuatHangCtrl
    {
        XuatHangData m_XuatHangData = new XuatHangData();
        XuatHangInfo m_XuatHangInfo = new XuatHangInfo();

        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_XuatHangData.LayXuatHang();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "MaPhieu";

            cbx.ValueMember = "MaPhieu";
        }

        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_XuatHangData.LayXuatHang();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public static IList<XuatHangInfo> LayDsXuatHangTheoMa(String MaPhieu)
        {
            IList<XuatHangInfo> ds = new List<XuatHangInfo>();

            XuatHangData data = new XuatHangData();
            DataTable tbl = data.LayDSXuatHangTheoMa(MaPhieu);

            IList<XuatHangInfo> XuatHang = new List<XuatHangInfo>();

            foreach (DataRow row in tbl.Rows)
            {
                XuatHangInfo XH = new XuatHangInfo();

                MatHangInfo m_MH = new MatHangInfo();
                m_MH.TenMH = Convert.ToString(row["TenMH"]);
                m_MH.MaMH = Convert.ToString(row["MaMH"]);
                KhachHangInfo m_KH = new KhachHangInfo();
                m_KH.HoTen = Convert.ToString(row["HoTen"]);
                m_KH.MaKH = Convert.ToString(row["MaKH"]);
                NhanVienInfo m_NV = new NhanVienInfo();
                m_NV.HoTen = Convert.ToString(row["HoTenNV"]);
                m_NV.MaNV = Convert.ToString(row["MaNV"]);
                LoaiTienInfo m_LoaiTien = new LoaiTienInfo();
                m_LoaiTien.LoaiTien = Convert.ToString(row["LoaiTien"]);
                LoaiGiaoDichInfo m_LoaiGD = new LoaiGiaoDichInfo();
                m_LoaiGD.TenGiaoDich = Convert.ToString(row["TenLoaiGiaoDich"]);

                XH.MaPhieu = Convert.ToString(row["MaPhieu"]);
                XH.SoLuong = Convert.ToString(row["SoLuong"]);
                XH.GiaBan = Convert.ToString(row["GiaBan"]);
                XH.ThanhTien = Convert.ToString(row["ThanhTien"]);
                XH.NgayXuat = Convert.ToDateTime(row["NgayXuat"]);
                XH.MaMH = m_MH;
                XH.MaKH = m_KH;
                XH.MaNV = m_NV;
                XH.MaLoaiGiaoDich = m_LoaiGD;
                XH.MaLoaiTien = m_LoaiTien;
                XuatHang.Add(XH);
            }
            return XuatHang;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaPhieu,
                            DateTimeInput dtNgayXuat,
                            TextBoxX txtSoLuong,
                            TextBoxX txtGiaBan,
                            TextBoxX txtThanhTien,
                            ComboBoxEx cmbTenMH,
                            ComboBoxEx cmbTenKH,
                            ComboBoxEx cmbTenNV,
                            ComboBoxEx cmbLoaiGiaoDich,
                            ComboBoxEx cmbLoaiTienGui)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_XuatHangData.LayXuatHang();

            txtMaPhieu.DataBindings.Clear();
            txtMaPhieu.DataBindings.Add("Text", bS, "MaPhieu");

            dtNgayXuat.DataBindings.Clear();
            dtNgayXuat.DataBindings.Add("Value", bS, "NgayXuat");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", bS, "SoLuong");

            txtGiaBan.DataBindings.Clear();
            txtGiaBan.DataBindings.Add("Text", bS, "GiaBan");

            txtThanhTien.DataBindings.Clear();
            txtThanhTien.DataBindings.Add("Text", bS, "ThanhTien");

            cmbLoaiGiaoDich.DataBindings.Clear();
            cmbLoaiGiaoDich.DataBindings.Add("SelectedValue", bS, "MaLoaiGiaoDich");

            cmbTenMH.DataBindings.Clear();
            cmbTenMH.DataBindings.Add("SelectedValue", bS, "MaMH");

            cmbTenKH.DataBindings.Clear();
            cmbTenKH.DataBindings.Add("SelectedValue", bS, "MaKH");

            cmbTenNV.DataBindings.Clear();
            cmbTenNV.DataBindings.Add("SelectedValue", bS, "MaNV");

            cmbLoaiTienGui.DataBindings.Clear();
            cmbLoaiTienGui.DataBindings.Add("SelectedValue", bS, "MaLoaiTien");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_XuatHangData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_XuatHangData.ThemXuatHang(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuXuatHang()
        {
            return m_XuatHangData.LuuXuatHang();
        }

        public void LuuXuatHang(String maphieu, String mamh, String makh, String manv, float soluong, float giaban, float thanhtien, DateTime ngayxuat, String maloaitien, String maloaigd)
        {
            m_XuatHangData.LuuXuatHang(maphieu, mamh, makh, manv, soluong, giaban, thanhtien, ngayxuat,maloaitien, maloaigd);
        }
        #endregion

        #region Sửa
        public void SuaXuatHang(String maphieu, String mamh, String makh, String manv, float soluong, float giaban, float thanhtien, DateTime ngayxuat, String maloaitien, String maloaigd)
        {
            m_XuatHangData.SuaXuatHang(maphieu, mamh, makh, manv, soluong, giaban, thanhtien, ngayxuat, maloaitien, maloaigd);
        }
        #endregion

        #region Xóa
        public void XoaXuatHang(String maphieu, String mamh, String makh, String manv)
        {
            m_XuatHangData.XoaXuatHang(maphieu, mamh, makh, manv);
        }
        #endregion
    }
}
