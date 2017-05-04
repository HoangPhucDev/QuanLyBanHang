using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevComponents.DotNetBar;
using System.Xml;
using System.Windows.Forms;
using QuanLyBanHang.Report;

namespace QuanLyBanHang.General
{
    public class ThamSo
    {
        public static String DatabaseName;
    }
    #region Load form main
    public static class LoadMain
    {
        public static int STT = 001;

        #region goi form quan ly
        static frmQuyen m_FrmQuyen = null;

        public static void HienThiQuyen()
        {
            if (m_FrmQuyen == null || m_FrmQuyen.IsDisposed)
            {
                m_FrmQuyen = new frmQuyen();
                m_FrmQuyen.MdiParent = frmMain.ActiveForm;
                m_FrmQuyen.Show();
            }
            else
                m_FrmQuyen.Activate();
        }

        static frmPhanQuyen m_FrmPhanQuyen = null;
        public static void HienThiPhanQuyen()
        {
            if (m_FrmPhanQuyen == null || m_FrmPhanQuyen.IsDisposed)
            {
                m_FrmPhanQuyen = new frmPhanQuyen();
                m_FrmPhanQuyen.MdiParent = frmMain.ActiveForm;
                m_FrmPhanQuyen.Show();
            }
            else
                m_FrmPhanQuyen.Activate();
        }

        static frmKhachHang m_FrmKhachHang = null;
        public static void HienThiKhachHang()
        {
            if (m_FrmKhachHang == null || m_FrmKhachHang.IsDisposed)
            {
                m_FrmKhachHang = new frmKhachHang();
                m_FrmKhachHang.MdiParent = frmMain.ActiveForm;
                m_FrmKhachHang.Show();
            }
            else
                m_FrmKhachHang.Activate();
        }

        static frmNhanVien m_FrmNhanVien = null;
        public static void HienThiNhanVien()
        {
            if (m_FrmNhanVien == null || m_FrmNhanVien.IsDisposed)
            {
                m_FrmNhanVien = new frmNhanVien();
                m_FrmNhanVien.MdiParent = frmMain.ActiveForm;
                m_FrmNhanVien.Show();
            }
            else
                m_FrmNhanVien.Activate();
        }

        static frmQuayGiaoDich m_FrmQuayGiaoDich = null;
        public static void HienThiQuayGiaoDich()
        {
            if (m_FrmQuayGiaoDich == null || m_FrmQuayGiaoDich.IsDisposed)
            {
                m_FrmQuayGiaoDich = new frmQuayGiaoDich();
                m_FrmQuayGiaoDich.MdiParent = frmMain.ActiveForm;
                m_FrmQuayGiaoDich.Show();
            }
            else
                m_FrmQuayGiaoDich.Activate();
        }

        static frmLoaiTien m_FrmLoaiTien = null;
        public static void HienThiLoaiTien()
        {
            if (m_FrmLoaiTien == null || m_FrmLoaiTien.IsDisposed)
            {
                m_FrmLoaiTien = new frmLoaiTien();
                m_FrmLoaiTien.MdiParent = frmMain.ActiveForm;
                m_FrmLoaiTien.Show();
            }
            else
                m_FrmLoaiTien.Activate();
        }

        static frmLoaiGiaoDich m_FrmLoaiGiaoDich = null;
        public static void HienThiLoaiGiaoDich()
        {
            if (m_FrmLoaiGiaoDich == null || m_FrmLoaiGiaoDich.IsDisposed)
            {
                m_FrmLoaiGiaoDich = new frmLoaiGiaoDich();
                m_FrmLoaiGiaoDich.MdiParent = frmMain.ActiveForm;
                m_FrmLoaiGiaoDich.Show();
            }
            else
                m_FrmLoaiGiaoDich.Activate();
        }

        static frmNhaCungCap m_FrmNhaCungCap = null;
        public static void HienThiNhaCungCap()
        {
            if (m_FrmNhaCungCap == null || m_FrmNhaCungCap.IsDisposed)
            {
                m_FrmNhaCungCap = new frmNhaCungCap();
                m_FrmNhaCungCap.MdiParent = frmMain.ActiveForm;
                m_FrmNhaCungCap.Show();
            }
            else
                m_FrmNhaCungCap.Activate();
        }

        static frmThemMatHang m_FrmThemMatHang = null;
        public static void HienThiMatHang()
        {
            if (m_FrmThemMatHang == null || m_FrmThemMatHang.IsDisposed)
            {
                m_FrmThemMatHang = new frmThemMatHang();
                m_FrmThemMatHang.MdiParent = frmMain.ActiveForm;
                m_FrmThemMatHang.Show();
            }
            else
                m_FrmThemMatHang.Activate();
        }

        static frmDatHang m_FrmDatHang = null;
        public static void HienThiDatHang()
        {
            if (m_FrmDatHang == null || m_FrmDatHang.IsDisposed)
            {
                m_FrmDatHang = new frmDatHang();
                m_FrmDatHang.MdiParent = frmMain.ActiveForm;
                m_FrmDatHang.Show();
            }
            else
                m_FrmDatHang.Activate();
        }

        static frmXuatHang m_FrmXuatHang = null;
        public static void HienThiXuatHang()
        {
            if (m_FrmXuatHang == null || m_FrmXuatHang.IsDisposed)
            {
                m_FrmXuatHang = new frmXuatHang();
                m_FrmXuatHang.MdiParent = frmMain.ActiveForm;
                m_FrmXuatHang.Show();
            }
            else
                m_FrmXuatHang.Activate();
        }

        static frmNhomNguoiDung m_FrmNhomNguoiDung = null;
        public static void HienThiNhomNguoiDung()
        {
            if (m_FrmNhomNguoiDung == null || m_FrmNhomNguoiDung.IsDisposed)
            {
                m_FrmNhomNguoiDung = new frmNhomNguoiDung();
                m_FrmNhomNguoiDung.MdiParent = frmMain.ActiveForm;
                m_FrmNhomNguoiDung.Show();
            }
            else
                m_FrmNhomNguoiDung.Activate();
        }

        static frmPhanNhomNguoiDung m_FrmPhanNhomNguoiDung = null;
        public static void HienThiPhanNhomNguoiDung()
        {
            if (m_FrmPhanNhomNguoiDung == null || m_FrmPhanNhomNguoiDung.IsDisposed)
            {
                m_FrmPhanNhomNguoiDung = new frmPhanNhomNguoiDung();
                m_FrmPhanNhomNguoiDung.MdiParent = frmMain.ActiveForm;
                m_FrmPhanNhomNguoiDung.Show();
            }
            else
                m_FrmPhanNhomNguoiDung.Activate();
        }
        #endregion

        #region hiện thị form thống kê:

        static frmDSNhanVien m_FrmDSNhanVien = null;
        public static void HienThiDSNhanVien()
        {
            if (m_FrmDSNhanVien == null || m_FrmDSNhanVien.IsDisposed)
            {
                m_FrmDSNhanVien = new frmDSNhanVien();
                m_FrmDSNhanVien.MdiParent = frmMain.ActiveForm;
                m_FrmDSNhanVien.Show();
            }
            else
                m_FrmDSNhanVien.Activate();
        }

        static frmDSMatHang m_FrmDSMatHang = null;
        public static void HienThiDSMatHang()
        {
            if (m_FrmDSMatHang == null || m_FrmDSMatHang.IsDisposed)
            {
                m_FrmDSMatHang = new frmDSMatHang();
                m_FrmDSMatHang.MdiParent = frmMain.ActiveForm;
                m_FrmDSMatHang.Show();
            }
            else
                m_FrmDSMatHang.Activate();
        }

        static frmDoanhThu m_FrmDoanhThu = null;
        public static void HienThiDoanhThu()
        {
            if (m_FrmDoanhThu == null || m_FrmDoanhThu.IsDisposed)
            {
                m_FrmDoanhThu = new frmDoanhThu();
                m_FrmDoanhThu.MdiParent = frmMain.ActiveForm;
                m_FrmDoanhThu.Show();
            }
            else
                m_FrmDoanhThu.Activate();
        }

        static frmTonKho m_FrmTonKho = null;
        public static void HienThiTonKho()
        {
            if (m_FrmTonKho == null || m_FrmTonKho.IsDisposed)
            {
                m_FrmTonKho = new frmTonKho();
                m_FrmTonKho.MdiParent = frmMain.ActiveForm;
                m_FrmTonKho.Show();
            }
            else
                m_FrmTonKho.Activate();
        }
        #endregion

        #region hiển thị menu tìm kiếm
        static frmTimKiemNhanVien m_FrmTimKiemNhanVien = null;
        public static void HienThiTimKiemNhanVien()
        {
            if (m_FrmTimKiemNhanVien == null || m_FrmTimKiemNhanVien.IsDisposed)
            {
                m_FrmTimKiemNhanVien = new frmTimKiemNhanVien();
                m_FrmTimKiemNhanVien.MdiParent = frmMain.ActiveForm;
                m_FrmTimKiemNhanVien.Show();
            }
            else
                m_FrmTimKiemNhanVien.Activate();
        }

        static frmTimKiemMatHang m_FrmTimKiemMatHang = null;
        public static void HienThiTimKiemMatHang()
        {
            if (m_FrmTimKiemMatHang == null || m_FrmTimKiemMatHang.IsDisposed)
            {
                m_FrmTimKiemMatHang = new frmTimKiemMatHang();
                m_FrmTimKiemMatHang.MdiParent = frmMain.ActiveForm;
                m_FrmTimKiemMatHang.Show();
            }
            else
                m_FrmTimKiemMatHang.Activate();
        }
        static frmTimNhaCungCap m_FrmTimNhaCungCap = null;
        public static void HienThiTimNhaCungCap()
        {
            if (m_FrmTimNhaCungCap == null || m_FrmTimNhaCungCap.IsDisposed)
            {
                m_FrmTimNhaCungCap = new frmTimNhaCungCap();
                m_FrmTimNhaCungCap.MdiParent = frmMain.ActiveForm;
                m_FrmTimNhaCungCap.Show();
            }
            else
                m_FrmTimNhaCungCap.Activate();
        }

        static frmTimKiemKhachHang m_FrmTimKiemKhachHang = null;
        public static void HienThiTimKiemKhachHang()
        {
            if (m_FrmTimKiemKhachHang == null || m_FrmTimKiemKhachHang.IsDisposed)
            {
                m_FrmTimKiemKhachHang = new frmTimKiemKhachHang();
                m_FrmTimKiemKhachHang.MdiParent = frmMain.ActiveForm;
                m_FrmTimKiemKhachHang.Show();
            }
            else
                m_FrmTimKiemKhachHang.Activate();
        }
        #endregion

        #region hiển thị menu lập phiếu

        static frmDonDatHang m_FrmDonDatHang = null;
        public static void HienThiDonDatHang()
        {
            if (m_FrmDonDatHang == null || m_FrmDonDatHang.IsDisposed)
            {
                m_FrmDonDatHang = new frmDonDatHang();
                m_FrmDonDatHang.MdiParent = frmMain.ActiveForm;
                m_FrmDonDatHang.Show();
            }
            else
                m_FrmDonDatHang.Activate();
        }

        static frmPhieuXuatHang m_FrmPhieuXuatHang = null;
        public static void HienThiPhieuXuatHang()
        {
            if (m_FrmPhieuXuatHang == null || m_FrmPhieuXuatHang.IsDisposed)
            {
                m_FrmPhieuXuatHang = new frmPhieuXuatHang();
                m_FrmPhieuXuatHang.MdiParent = frmMain.ActiveForm;
                m_FrmPhieuXuatHang.Show();
            }
            else
                m_FrmPhieuXuatHang.Activate();
        }
        static frmNhapHang m_FrmNhapHang = null;
        public static void HienThiPhieuNhapHang()
        {
            if (m_FrmNhapHang == null || m_FrmNhapHang.IsDisposed)
            {
                m_FrmNhapHang = new frmNhapHang();
                m_FrmNhapHang.MdiParent = frmMain.ActiveForm;
                m_FrmNhapHang.Show();
            }
            else
                m_FrmNhapHang.Activate();
        }
        #endregion
    }
    #endregion
    
    #region Ket not DBMS
    public class DBMS
    {

    }
    #endregion
    #region Xu ly tap tin Xml
    public class XML
    {
        public static XmlDocument ReadXml(String fileName)
        {
            XmlDocument XmlDocument = new XmlDocument();
            try
            {
                XmlDocument.Load(fileName);
            }
            catch
            {
                MessageBoxEx.Show("Không đọc được hoặc không tồn tại tập tin cấu hình " + fileName, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return XmlDocument;
        }

        public static void WriteXml(String fileName, String serverName, String dataBase, String costatus)
        {
            XmlTextWriter XmlWrite = new XmlTextWriter(fileName, null);
            XmlWrite.Formatting = Formatting.Indented;

            XmlWrite.WriteStartDocument();
            XmlWrite.WriteComment("Thong so co ban:\n\t" +
                                "costatus = true : quyen Windows\n\t" +
                                "costatus = false: quyen SQL Server\n\t" +
                                "servname: ten server\n\t" +
                                "username: ten dang nhap he thong\n\t" +
                                "password: mat khau dang nhap he thong\n\t" +
                                "database: ten co so du lieu\n");
            XmlWrite.WriteStartElement("config");

            XmlWrite.WriteStartElement("costatus");
            XmlWrite.WriteString(costatus);
            XmlWrite.WriteEndElement();

            XmlWrite.WriteStartElement("servername");
            XmlWrite.WriteString(serverName);
            XmlWrite.WriteEndElement();

            XmlWrite.WriteStartElement("username");
            XmlWrite.WriteString("");
            XmlWrite.WriteEndElement();

            XmlWrite.WriteStartElement("password");
            XmlWrite.WriteString("");
            XmlWrite.WriteEndElement();

            XmlWrite.WriteStartElement("database");
            XmlWrite.WriteString(dataBase);
            XmlWrite.WriteEndElement();

            XmlWrite.WriteEndElement();
            XmlWrite.WriteEndDocument();

            XmlWrite.Close();
        }

        public static void XMLWriter(String fileName, String serverName, String userName, String passWord, String dataBase, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(fileName, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                "Thong so co ban:\n\t" +
                                "costatus = true : quyen Windows\n\t" +
                                "costatus = false: quyen SQL Server\n\t" +
                                "servname: ten server\n\t" +
                                "username: ten dang nhap he thong\n\t" +
                                "password: mat khau dang nhap he thong\n\t" +
                                "database: ten co so du lieu\n");
            xmlW.WriteStartElement("config");

            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("servername");
            xmlW.WriteString(serverName);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString(userName);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString(passWord);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(dataBase);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }

    }
    #endregion
    #region Quy dinh
    public class QuyDinh
    {
        public String LaySTT(int autoNum)
        {
            if (autoNum < 10)
                return "00000" + autoNum;
            else if (autoNum >= 10 && autoNum < 100000)
                return "0000" + autoNum;

            else if (autoNum >= 1000 && autoNum < 10000)
                return "000" + autoNum;
            else if (autoNum >= 10000 && autoNum < 100000)
                return "00" + autoNum;
            else if (autoNum >= 10000 && autoNum < 100000)
                return "0" + autoNum;
            else if (autoNum >= 10000 && autoNum < 100000)
                return "" + autoNum;
            else
                return "";
        }

        private String m_DiaChi;
        public String DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }
    }
    #endregion
}
