using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanHang.General;


namespace QuanLyBanHang.DataLayer
{
     public class NhaCungCapData
    {
         DataService m_NhaCungCapData = new DataService();
        public DataTable LayNhaCungCap()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Nha_Cung_Cap");
            m_NhaCungCapData.Load(cmd);
            return m_NhaCungCapData;
        }

        public DataRow ThemDongMoi()
        {
            return m_NhaCungCapData.NewRow();
        }

        public void ThemNhaCungCap(DataRow m_Row)
        {
            m_NhaCungCapData.Rows.Add(m_Row);
        }

        public bool LuuNhaCungCap()
        {
            return m_NhaCungCapData.ExecuteNoneQuery() > 0;
        }
        public void LuuNhaCungCap(String mancc, String tenncc, String dienthoai, String fax, String email, String diachi, String ghichu)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Nha_Cung_Cap VALUES(@MaNCC, @TenNCC, @DienThoai, @Fax,  @Email, @DiaChi, @GhiChu)");
            cmd.Parameters.Add("MaNCC", SqlDbType.VarChar).Value = mancc;
            cmd.Parameters.Add("TenNCC", SqlDbType.NVarChar).Value = tenncc;
            cmd.Parameters.Add("DienThoai", SqlDbType.VarChar).Value = dienthoai;
            cmd.Parameters.Add("Fax", SqlDbType.VarChar).Value = fax;
            cmd.Parameters.Add("Email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = diachi;
            cmd.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value = ghichu;

            m_NhaCungCapData.Load(cmd);
        }

        public void SuaNhaCungCap(String mancc, String tenncc, String dienthoai, String fax, String email, String diachi, String ghichu)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Nha_Cung_Cap SET TenNCC = @TenNCC, DienThoai = @DienThoai, Fax = @Fax, Email = @Email, DiaChi = @DiaChi, GhiChu = @GhiChu WHERE MaNCC = @MaNCC");
            cmd.Parameters.Add("MaNCC", SqlDbType.VarChar).Value = mancc;
            cmd.Parameters.Add("TenNCC", SqlDbType.NVarChar).Value = tenncc;
            cmd.Parameters.Add("DienThoai", SqlDbType.VarChar).Value = dienthoai;
            cmd.Parameters.Add("Fax", SqlDbType.VarChar).Value = fax;
            cmd.Parameters.Add("Email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = diachi;
            cmd.Parameters.Add("GhiChu", SqlDbType.NVarChar).Value = ghichu;
            m_NhaCungCapData.Load(cmd);
        }

        public void XoaNhaCungCap(String mancc)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Nha_Cung_Cap WHERE MaNCC = @MaNCC");
            cmd.Parameters.Add("MaNCC", SqlDbType.VarChar).Value = mancc;
            
            m_NhaCungCapData.Load(cmd);
        }

        #region tim kiem
        public DataTable TimKiemTheoMa(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Nha_Cung_Cap WHERE MaNCC LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            m_NhaCungCapData.Load(cmd);
            return m_NhaCungCapData;
        }

        public DataTable TimKiemTheoTen(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Nha_Cung_Cap WHERE TenNCC LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_NhaCungCapData.Load(cmd);
            return m_NhaCungCapData;
        }



        #endregion
    }
}
