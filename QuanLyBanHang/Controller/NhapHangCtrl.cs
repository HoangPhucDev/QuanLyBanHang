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
    public class NhapHangCtrl
    {
        NhapHangData m_NhapHangData = new NhapHangData();
        NhapHangInfo m_NhapHangInfo = new NhapHangInfo();

        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_NhapHangData.LayNhapHang();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "Tháng";
            cbx.ValueMember = "Tháng";
        }
        public void HienThiComboBox1(ComboBox cbx)
        {
            DataTable m_DT = m_NhapHangData.LayNhapHang();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "Năm";
            cbx.ValueMember = "Năm";
        }

        public static IList<NhapHangInfo> LayDsNhapHangTheoThang(int thang, int nam)
        {
            IList<NhapHangInfo> ds = new List<NhapHangInfo>();

            NhapHangData data = new NhapHangData();
            DataTable tbl = data.LayDSNhapHangTheoThang(thang, nam);

            IList<NhapHangInfo> NhapHang = new List<NhapHangInfo>();

            foreach (DataRow row in tbl.Rows)
            {
                NhaCungCapInfo m_NCC = new NhaCungCapInfo();
                m_NCC.MaNCC = Convert.ToString(row["MaNCC"]);
                m_NCC.DienThoai = Convert.ToString(row["DienThoai"]);
                m_NCC.DiaChi = Convert.ToString(row["DiaChi"]);
                NhapHangInfo NH = new NhapHangInfo();
                NH.Tháng = Convert.ToInt32(row["Tháng"]);
                NH.Năm = Convert.ToInt32(row["Năm"]);
                NH.Tổng_Nhập = Convert.ToInt64(row["Tổng Nhập"]);
                NH.GiaBan = Convert.ToInt64(row["GiaBan"]);
                NH.DonGia = Convert.ToInt64(row["DonGia"]);
                NH.SoLuong = Convert.ToInt64(row["SoLuong"]);
                NH.NgayNhap = Convert.ToDateTime(row["NgayNhap"]);
                NH.TenNCC = Convert.ToString(row["TenNCC"]);
                NH.LoaiTien = Convert.ToString(row["LoaiTien"]);
                NH.LoaiGD = Convert.ToString(row["TenLoaiGiaoDich"]);
                NH.MaMH = Convert.ToString(row["MaMH"]);
                NH.TenMH = Convert.ToString(row["TenMH"]);
                NH.NCC = m_NCC;
                NhapHang.Add(NH);
            }
            return NhapHang;
        }
    }
}
