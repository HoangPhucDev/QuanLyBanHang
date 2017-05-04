using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanHang.General;

namespace QuanLyBanHang.DataLayer
{
    public class DatHangData
    {
        DataService m_DatHangData = new DataService();
        DataService m_MatHangData = new DataService();
        public DataTable LayMatHang()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Mat_Hang");
            m_MatHangData.Load(cmd);
            return m_MatHangData;
        }
        public DataTable LayDatHang()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Dat_Hang");
            m_DatHangData.Load(cmd);
            return m_DatHangData;
        }
        public DataTable LayDSDatHangTheoMa(String MaPhieu)
        {
            SqlCommand cmd = new SqlCommand("SELECT DH.MaPhieu, MH.MaMH, KH.MaKH, KH.HoTen, MH.TenMH, LT.LoaiTien, LGD.TenLoaiGiaoDich, DH.SoLuong, DH.GiaBan, DH.ThanhTien, DH.ThanhToan, DH.NgayDat  FROM Dat_Hang DH INNER JOIN Mat_Hang MH ON MH.MaMH = DH.MaMH INNER JOIN Khach_Hang KH ON KH.MaKH = DH.MaKH INNER JOIN Loai_Tien LT ON LT.MaLoaiTien = DH.MaLoaiTien INNER JOIN Loai_Giao_Dich LGD ON LGD.MaLoaiGiaoDich = DH.MaLoaiGiaoDich WHERE DH.MaPhieu = @MaPhieu");
            cmd.Parameters.Add("MaPhieu", SqlDbType.VarChar).Value = MaPhieu;
            m_DatHangData.Load(cmd);
            return m_DatHangData;
        }

        public DataRow ThemDongMoi()
        {
            return m_DatHangData.NewRow();
        }

        public void ThemDatHang(DataRow m_Row)
        {
            m_DatHangData.Rows.Add(m_Row);
        }

        public bool LuuDatHang()
        {
            return m_DatHangData.ExecuteNoneQuery() > 0;
        }

        public void LuuDatHang(String maphieu, String mamh, String makh, float soluong, float giaban, float thanhtien, DateTime ngaydat, bool thanhtoan, String maloaitien, String maloaigd, String ghichu)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Dat_Hang VALUES(@maphieu, @mamh, @makh, @soluong, @giaban, @thanhtien, @ngaydat, @thanhtoan, @maloaitien, @maloaigd, @ghichu)");
            cmd.Parameters.Add("maphieu", SqlDbType.VarChar).Value = maphieu;
            cmd.Parameters.Add("mamh", SqlDbType.VarChar).Value = mamh;
            cmd.Parameters.Add("makh", SqlDbType.VarChar).Value = makh;
            cmd.Parameters.Add("soluong", SqlDbType.Float).Value = soluong;
            cmd.Parameters.Add("giaban", SqlDbType.Float).Value = giaban;
            cmd.Parameters.Add("thanhtien", SqlDbType.Float).Value = thanhtien;
            cmd.Parameters.Add("ngaydat", SqlDbType.DateTime).Value = ngaydat;
            cmd.Parameters.Add("thanhtoan", SqlDbType.Bit).Value = thanhtoan;
            cmd.Parameters.Add("maloaitien", SqlDbType.VarChar).Value = maloaitien;
            cmd.Parameters.Add("maloaigd", SqlDbType.VarChar).Value = maloaigd;
            cmd.Parameters.Add("ghichu", SqlDbType.NVarChar).Value = ghichu;
            m_DatHangData.Load(cmd);
        }

        public void SuaDatHang(String maphieu, String mamh, String makh, float soluong, float giaban, float thanhtien, DateTime ngaydat, bool thanhtoan, String maloaitien, String maloaigd, String ghichu)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Dat_Hang SET soluong = @soluong, giaban = @giaban, thanhtien = @thanhtien, ngaydat = @ngaydat, thanhtoan = @thanhtoan, maloaitien = @maloaitien, maloaigiaodich = @maloaigd, ghichu = @ghichu WHERE maphieu = @maphieu AND mamh = @mamh AND makh = @makh");
            cmd.Parameters.Add("maphieu", SqlDbType.VarChar).Value = maphieu;
            cmd.Parameters.Add("mamh", SqlDbType.VarChar).Value = mamh;
            cmd.Parameters.Add("makh", SqlDbType.VarChar).Value = makh;
            cmd.Parameters.Add("soluong", SqlDbType.Float).Value = soluong;
            cmd.Parameters.Add("giaban", SqlDbType.Float).Value = giaban;
            cmd.Parameters.Add("thanhtien", SqlDbType.Float).Value = thanhtien;
            cmd.Parameters.Add("ngaydat", SqlDbType.DateTime).Value = ngaydat;
            cmd.Parameters.Add("thanhtoan", SqlDbType.Bit).Value = thanhtoan;
            cmd.Parameters.Add("maloaitien", SqlDbType.VarChar).Value = maloaitien;
            cmd.Parameters.Add("maloaigd", SqlDbType.VarChar).Value = maloaigd;
            cmd.Parameters.Add("ghichu", SqlDbType.NVarChar).Value = ghichu;
            m_DatHangData.Load(cmd);
        }

        public void XoaDatHang(String maphieu, String mamh, String makh)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Dat_Hang WHERE maphieu = @maphieu AND mamh = @mamh AND makh = @makh");
            cmd.Parameters.Add("maphieu", SqlDbType.VarChar).Value = maphieu;
            cmd.Parameters.Add("mamh", SqlDbType.VarChar).Value = mamh;
            cmd.Parameters.Add("makh", SqlDbType.VarChar).Value = makh;
            m_DatHangData.Load(cmd);
        }
    }
}
