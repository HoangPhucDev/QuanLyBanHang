using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanHang.General;

namespace QuanLyBanHang.DataLayer
{
    public class XuatHangData
    {
         DataService m_XuatHangData = new DataService();
        DataService m_MatHangData = new DataService();
        public DataTable LayMatHang()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Mat_Hang");
            m_MatHangData.Load(cmd);
            return m_MatHangData;
        }
        public DataTable LayXuatHang()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Xuat_Hang");
            m_XuatHangData.Load(cmd);
            return m_XuatHangData;
        }
        public DataTable LayDSXuatHangTheoMa(String MaPhieu)
        {
            SqlCommand cmd = new SqlCommand("SELECT XH.MaPhieu, MH.MaMH, KH.MaKH, KH.HoTen, NV.MaNV, NV.HoTenNV, MH.TenMH, LT.LoaiTien, LGD.TenLoaiGiaoDich, XH.SoLuong, XH.GiaBan, XH.ThanhTien, XH.NgayXuat FROM Xuat_Hang XH INNER JOIN Mat_Hang MH ON MH.MaMH = XH.MaMH INNER JOIN Khach_Hang KH ON KH.MaKH = XH.MaKH INNER JOIN Nhan_Vien NV ON NV.MaNV = XH.MaNV INNER JOIN Loai_Tien LT ON LT.MaLoaiTien = XH.MaLoaiTien INNER JOIN Loai_Giao_Dich LGD ON LGD.MaLoaiGiaoDich = XH.MaLoaiGiaoDich WHERE XH.MaPhieu = @MaPhieu");
            cmd.Parameters.Add("MaPhieu", SqlDbType.VarChar).Value = MaPhieu;
            m_XuatHangData.Load(cmd);
            return m_XuatHangData;
        }

        public DataRow ThemDongMoi()
        {
            return m_XuatHangData.NewRow();
        }

        public void ThemXuatHang(DataRow m_Row)
        {
            m_XuatHangData.Rows.Add(m_Row);
        }

        public bool LuuXuatHang()
        {
            return m_XuatHangData.ExecuteNoneQuery() > 0;
        }

        public void LuuXuatHang(String maphieu, String mamh, String makh, String manv, float soluong, float giaban, float thanhtien, DateTime ngayxuat, String maloaitien, String maloaigd)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Xuat_Hang VALUES(@maphieu, @mamh, @makh, @manv, @soluong, @giaban, @thanhtien, @ngayxuat, @maloaitien, @maloaigd)");
            cmd.Parameters.Add("maphieu", SqlDbType.VarChar).Value = maphieu;
            cmd.Parameters.Add("mamh", SqlDbType.VarChar).Value = mamh;
            cmd.Parameters.Add("makh", SqlDbType.VarChar).Value = makh;
            cmd.Parameters.Add("manv", SqlDbType.VarChar).Value = manv;
            cmd.Parameters.Add("soluong", SqlDbType.Float).Value = soluong;
            cmd.Parameters.Add("giaban", SqlDbType.Float).Value = giaban;
            cmd.Parameters.Add("thanhtien", SqlDbType.Float).Value = thanhtien;
            cmd.Parameters.Add("ngayxuat", SqlDbType.DateTime).Value = ngayxuat;
            cmd.Parameters.Add("maloaitien", SqlDbType.VarChar).Value = maloaitien;
            cmd.Parameters.Add("maloaigd", SqlDbType.VarChar).Value = maloaigd;
            m_XuatHangData.Load(cmd);
        }

        public void SuaXuatHang(String maphieu, String mamh, String makh, String manv, float soluong, float giaban, float thanhtien, DateTime ngayxuat, String maloaitien, String maloaigd)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Xuat_Hang SET soluong = @soluong, giaban = @giaban, thanhtien = @thanhtien, ngayxuat = @ngayxuat, maloaitien = @maloaitien, maloaigiaodich = @maloaigd WHERE maphieu = @maphieu AND mamh = @mamh AND makh = @makh AND manv = @manv");
            cmd.Parameters.Add("maphieu", SqlDbType.VarChar).Value = maphieu;
            cmd.Parameters.Add("mamh", SqlDbType.VarChar).Value = mamh;
            cmd.Parameters.Add("makh", SqlDbType.VarChar).Value = makh;
            cmd.Parameters.Add("manv", SqlDbType.VarChar).Value = manv;
            cmd.Parameters.Add("soluong", SqlDbType.Float).Value = soluong;
            cmd.Parameters.Add("giaban", SqlDbType.Float).Value = giaban;
            cmd.Parameters.Add("thanhtien", SqlDbType.Float).Value = thanhtien;
            cmd.Parameters.Add("ngayxuat", SqlDbType.DateTime).Value = ngayxuat;
            cmd.Parameters.Add("maloaitien", SqlDbType.VarChar).Value = maloaitien;
            cmd.Parameters.Add("maloaigd", SqlDbType.VarChar).Value = maloaigd;
            m_XuatHangData.Load(cmd);
        }

        public void XoaXuatHang(String maphieu, String mamh, String makh, String manv)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Xuat_Hang WHERE maphieu = @maphieu AND mamh = @mamh AND makh = @makh AND manv = @manv");
            cmd.Parameters.Add("maphieu", SqlDbType.VarChar).Value = maphieu;
            cmd.Parameters.Add("mamh", SqlDbType.VarChar).Value = mamh;
            cmd.Parameters.Add("makh", SqlDbType.VarChar).Value = makh;
            cmd.Parameters.Add("manv", SqlDbType.VarChar).Value = manv;
            m_XuatHangData.Load(cmd);
        }
    }
}
