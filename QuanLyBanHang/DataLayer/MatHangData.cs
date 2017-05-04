using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanHang.General;

namespace QuanLyBanHang.DataLayer
{
    public class MatHangData
    {

        DataService m_MatHangData = new DataService();
        public DataTable LayMatHang()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Mat_Hang");
            m_MatHangData.Load(cmd);
            return m_MatHangData;
        }
        public DataTable LayDSMatHang()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Mat_Hang MH INNER JOIN Nha_Cung_Cap NCC ON MH.MaNCC = NCC.MaNCC INNER JOIN Loai_Tien LT ON MH.MaLoaiTien = LT.MaLoaiTien INNER JOIN Loai_Giao_Dich LGD ON MH.MaLoaiGiaoDich = LGD.MaLoaiGiaoDich");
            m_MatHangData.Load(cmd);
            return m_MatHangData;
        }

        public DataTable LayDSMatHangTheoMa(String MaPhieu)
        {
            SqlCommand cmd = new SqlCommand("SELECT MH.MaPhieu, MH.MaMH, NCC.MaNCC, NCC.TenNCC, MH.TenMH, LT.LoaiTien, LGD.TenLoaiGiaoDich, MH.SoLuong, MH.GiaBan, MH.DonGia, MH.NgayNhap FROM Mat_Hang MH INNER JOIN Nha_Cung_Cap NCC ON MH.MaNCC = NCC.MaNCC INNER JOIN Loai_Tien LT ON MH.MaLoaiTien = LT.MaLoaiTien INNER JOIN Loai_Giao_Dich LGD ON MH.MaLoaiGiaoDich = LGD.MaLoaiGiaoDich WHERE MH.MaPhieu = @MaPhieu");
            cmd.Parameters.Add("MaPhieu", SqlDbType.VarChar).Value = MaPhieu;
            m_MatHangData.Load(cmd);
            return m_MatHangData;
        }

        public DataRow ThemDongMoi()
        {
            return m_MatHangData.NewRow();
        }

        public void ThemMatHang(DataRow m_Row)
        {
            m_MatHangData.Rows.Add(m_Row);
        }

        public bool LuuMatHang()
        {
            return m_MatHangData.ExecuteNoneQuery() > 0;
        }

        public void LuuMatHang(String maphieu, String mamh, String tenmh, float soluong, float dongia, float giaban, String mancc, DateTime ngaynhap, String maloaitien, String maloaigd)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Mat_Hang VALUES(@maphieu, @mamh, @tenmh, @soluong, @dongia, @giaban, @mancc, @ngaynhap, @maloaitien, @maloaigd)");
            cmd.Parameters.Add("maphieu", SqlDbType.VarChar).Value = maphieu;
            cmd.Parameters.Add("mamh", SqlDbType.VarChar).Value = mamh;
            cmd.Parameters.Add("tenmh", SqlDbType.NVarChar).Value = tenmh;
            cmd.Parameters.Add("soluong", SqlDbType.Float).Value = soluong;
            cmd.Parameters.Add("dongia", SqlDbType.Float).Value = dongia;
            cmd.Parameters.Add("giaban", SqlDbType.Float).Value = giaban;
            cmd.Parameters.Add("mancc", SqlDbType.VarChar).Value = mancc;
            cmd.Parameters.Add("ngaynhap", SqlDbType.DateTime).Value = ngaynhap;
            cmd.Parameters.Add("maloaitien", SqlDbType.VarChar).Value = maloaitien;
            cmd.Parameters.Add("maloaigd", SqlDbType.VarChar).Value = maloaigd;

            m_MatHangData.Load(cmd);
        }

        public void SuaMatHang(String maphieu, String mamh, String tenmh, float soluong, float dongia, float giaban, String mancc, DateTime ngaynhap, String maloaitien, String maloaigd)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Mat_Hang SET tenmh= @tenmh, soluong = @soluong, dongia = @dongia, giaban = @giaban, mancc = @mancc, ngaynhap = @ngaynhap, maloaitien = @maloaitien, maloaigiaodich = @maloaigd WHERE mamh = @mamh AND maphieu = @maphieu");
            cmd.Parameters.Add("maphieu", SqlDbType.VarChar).Value = maphieu;
            cmd.Parameters.Add("mamh", SqlDbType.VarChar).Value = mamh;
            cmd.Parameters.Add("tenmh", SqlDbType.NVarChar).Value = tenmh;
            cmd.Parameters.Add("soluong", SqlDbType.Float).Value = soluong;
            cmd.Parameters.Add("dongia", SqlDbType.Float).Value = dongia;
            cmd.Parameters.Add("giaban", SqlDbType.Float).Value = giaban;
            cmd.Parameters.Add("mancc", SqlDbType.VarChar).Value = mancc;
            cmd.Parameters.Add("ngaynhap", SqlDbType.DateTime).Value = ngaynhap;
            cmd.Parameters.Add("maloaitien", SqlDbType.VarChar).Value = maloaitien;
            cmd.Parameters.Add("maloaigd", SqlDbType.VarChar).Value = maloaigd;

            m_MatHangData.Load(cmd);
        }

        public void XoaMatHang(String maphieu, String mamh)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Mat_Hang WHERE mamh = @mamh AND maphieu = @maphieu");
            cmd.Parameters.Add("maphieu", SqlDbType.VarChar).Value = maphieu;
            cmd.Parameters.Add("mamh", SqlDbType.VarChar).Value = mamh;

            m_MatHangData.Load(cmd);
        }

        #region tim kiem
        public DataTable TimKiemTheoMa(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Mat_Hang WHERE MaMH LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            m_MatHangData.Load(cmd);
            return m_MatHangData;
        }

        public DataTable TimKiemTheoTen(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Mat_Hang WHERE TenMH LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_MatHangData.Load(cmd);
            return m_MatHangData;
        }



        #endregion
    }
}
