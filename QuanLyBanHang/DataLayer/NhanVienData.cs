using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanHang.General;

namespace QuanLyBanHang.DataLayer
{
    public class NhanVienData
    {
        DataService m_NhanVienData = new DataService();

        public DataTable LayNhanVien()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Nhan_Vien");
            m_NhanVienData.Load(cmd);
            return m_NhanVienData;
        }
        public DataTable LayDSNhanVien()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Nhan_Vien NV INNER JOIN Quay_Giao_Dich QGD ON NV.MaQuayGiaoDich = QGD.MaQuayGiaoDich");
            m_NhanVienData.Load(cmd);
            return m_NhanVienData;
        }

        public DataRow ThemDongMoi()
        {
            return m_NhanVienData.NewRow();
        }

        public void ThemNhanVien(DataRow m_Row)
        {
            m_NhanVienData.Rows.Add(m_Row);
        }

        public bool LuuNhanVien()
        {
            return m_NhanVienData.ExecuteNoneQuery() > 0;
        }

        public void LuuNhanVien(String manv, String hoten, DateTime ngaysinh, String diachi, String dienthoai, String maquaygd)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Nhan_Vien VALUES(@MaNV, @HoTenNV, @NgaySinh, @DiaChi, @DienThoai,  @MaQuayGD)");
            cmd.Parameters.Add("MaNV", SqlDbType.VarChar).Value = manv;
            cmd.Parameters.Add("HoTenNV", SqlDbType.NVarChar).Value = hoten;
            cmd.Parameters.Add("NgaySinh", SqlDbType.DateTime).Value = ngaysinh;
            cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = diachi;
            cmd.Parameters.Add("DienThoai", SqlDbType.VarChar).Value = dienthoai;
            cmd.Parameters.Add("MaQuayGD", SqlDbType.VarChar).Value = maquaygd;

            m_NhanVienData.Load(cmd);
        }

        public void SuaNhanVien(String manv, String hoten, DateTime ngaysinh, String diachi, String dienthoai, String maquaygd)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Nhan_Vien SET HoTen = @HoTenNV, NgaySinh = @NgaySinh, DiaChi = @DiaChi, DienThoai = @DienThoai,  MaQuayGiaoDich = @MaQuayGD WHERE MaNV = @MaNV");
            cmd.Parameters.Add("MaNV", SqlDbType.VarChar).Value = manv;
            cmd.Parameters.Add("HoTenNV", SqlDbType.NVarChar).Value = hoten;
            cmd.Parameters.Add("NgaySinh", SqlDbType.DateTime).Value = ngaysinh;
            cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = diachi;
            cmd.Parameters.Add("DienThoai", SqlDbType.VarChar).Value = dienthoai;
            cmd.Parameters.Add("MaQuayGD", SqlDbType.VarChar).Value = maquaygd;

            m_NhanVienData.Load(cmd);
        }

        public void XoaNhanVien(String manv)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Nhan_Vien WHERE MaNV = @MaNV");
            cmd.Parameters.Add("MaNV", SqlDbType.VarChar).Value = manv;
            m_NhanVienData.Load(cmd);
        }

        #region tim kiem
        public DataTable TimKiemTheoMa(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Nhan_Vien WHERE MaNV LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            m_NhanVienData.Load(cmd);
            return m_NhanVienData;
        }

        public DataTable TimKiemTheoTen(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Nhan_Vien WHERE HoTenNV LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_NhanVienData.Load(cmd);
            return m_NhanVienData;
        }

        #endregion
    }
}
