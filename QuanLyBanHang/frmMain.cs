using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyBanHang.General;
using QuanLyBanHang.Controller;

namespace QuanLyBanHang
{
    public partial class frmMain : Office2007RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            frmFlash m_FrmFlash = new frmFlash();
            m_FrmFlash.Show();
            System.Threading.Thread.Sleep(3000);
            m_FrmFlash.Close();
            DataService.OpenConnection();
        }
        NhanVienCtrl m_NhanVienCtrl = new NhanVienCtrl();
        PhanQuyenCtrl m_PhanQuyenCtrl = new PhanQuyenCtrl();
        frmDangNhap m_FrmDangNhap = null;

        private void frmMain_Load(object sender, EventArgs e)
        {
            Default();

            DangNhap();

            // Load Quick Access Toolbar layout if one is saved from last session...
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\DevComponents\Ribbon");
            if (key != null)
            {
                try
                {
                    string layout = key.GetValue("RibbonPadCSLayout", "").ToString();
                    if (layout != "" && layout != null)
                        ribbonControl.QatLayout = layout;
                }
                finally
                {
                    key.Close();
                }
            }

            // Pulse the Application Button
            buttonFile.Pulse(11);
        }

        private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Save Quick Access Toolbar layout if it has changed...
            if (ribbonControl.QatLayoutChanged)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\DevComponents\Ribbon");
                try
                {
                    key.SetValue("RibbonPadCSLayout", ribbonControl.QatLayout);
                }
                finally
                {
                    key.Close();
                }
            }
        }
        #region Đăng Nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            m_FrmDangNhap.txtUserName.Text = "";
            m_FrmDangNhap.txtPass.Text = "";
            m_FrmDangNhap.lbErrorPass.Text = "";
            m_FrmDangNhap.lbErrorUserName.Text = "";

            DangNhap();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Default();
            lblTenNguoiDung.Text = "Bạn cần đăng nhập để sử dụng phần mềm";
        }

        public void DangNhap()
        {
            Cont:
            if (m_FrmDangNhap == null || m_FrmDangNhap.IsDisposed)
                m_FrmDangNhap = new frmDangNhap();

            if (m_FrmDangNhap.ShowDialog() == DialogResult.OK)
            {
                if (m_FrmDangNhap.txtUserName.Text == "")
                {
                    m_FrmDangNhap.lbErrorUserName.Text = "Bạn chưa nhập tên đăng nhập";
                    m_FrmDangNhap.lbErrorPass.Text = "";
                    goto Cont;
                }

                if (m_FrmDangNhap.txtPass.Text == "")
                {
                    m_FrmDangNhap.lbErrorPass.Text = "Bạn chưa nhập mật khẩu";
                    m_FrmDangNhap.lbErrorUserName.Text = "";
                    goto Cont;
                }
                int kq = m_PhanQuyenCtrl.DangNhap(m_FrmDangNhap.txtUserName.Text, m_FrmDangNhap.txtPass.Text);
                lblTenNguoiDung.Text = "Xin chào: " + m_PhanQuyenCtrl.LayTenNguoiDung(m_FrmDangNhap.txtUserName.Text);
                switch (kq)
                {
                    case 0:
                        m_FrmDangNhap.lbErrorPass.Text = "";
                        m_FrmDangNhap.lbErrorUserName.Text = "Người dùng không tồn tại";
                        goto Cont;
                    case 1:
                        m_FrmDangNhap.lbErrorUserName.Text = "";
                        m_FrmDangNhap.lbErrorPass.Text = "Mật khẩu không hợp lệ";
                        goto Cont;
                    case 2:
                        if (m_PhanQuyenCtrl.PhanQuyen == "MQ001")
                            Admin();
                        else
                            Users();
                        break;
                }
            }

        }

        public void Default()
        {
            btnAbout.Enabled = true;
            btnCalculator.Enabled = true;
            btnClose.Enabled = true;
            btnHelp.Enabled = true;

            btnDangNhap.Enabled = true;
            btnBackUp.Enabled = false;
            btnRestor.Enabled = false;
            btnChangePass.Enabled = false;
            btnDangXuat.Enabled = false;

            btnThemMatHang.Enabled = false;
            btnXuatHang.Enabled = false;
            btnDatHang.Enabled = false;

            btnKhachHang.Enabled = false;

            btnQuayGiaoDich.Enabled = false;
            btnNhanVien.Enabled = false;
            btnNhomNguoiDung.Enabled = false;
            btnQuyen.Enabled = false;
            btnPhanNhom.Enabled = false;
            btnPhanQuyen.Enabled = false;
            btnDSMatHang.Enabled = false;
            btnDSNhaCungCap.Enabled = false;

            btnDMLoaiGiaoDich.Enabled = false;
            btnDMLoaiTien.Enabled = false;

            btnPhieuNhapHang.Enabled = false;
            btnPhieuXuatHang.Enabled = false;
            btnDonDatHang.Enabled = false;
            btnDSNhanVien.Enabled = false;
            btnTonKho.Enabled = false;
            btnDoanhThu.Enabled = false;
            btnTimNV.Enabled = false;
            btnTimMatHang.Enabled = false;
            btnTimNhaCC.Enabled = false;
            btnTimKH.Enabled = false;
        }

        public void Admin()
        {
            btnHelp.Enabled = true;
            btnAbout.Enabled = true;
            btnCalculator.Enabled = true;
            btnClose.Enabled = true;
            btnDangNhap.Enabled = true;
            btnBackUp.Enabled = true;
            btnRestor.Enabled = true;
            btnChangePass.Enabled = true;
            btnDangXuat.Enabled = true;

            btnThemMatHang.Enabled = true;
            btnXuatHang.Enabled = true;
            btnDatHang.Enabled = true;

            btnKhachHang.Enabled = true;

            btnQuayGiaoDich.Enabled = true;
            btnNhanVien.Enabled = true;

            btnNhomNguoiDung.Enabled = true;
            btnQuyen.Enabled = true;
            btnPhanNhom.Enabled = true;
            btnPhanQuyen.Enabled = true;
            btnDSMatHang.Enabled = true;
            btnDSNhaCungCap.Enabled = true;

            btnDMLoaiGiaoDich.Enabled = true;
            btnDMLoaiTien.Enabled = true;

            btnPhieuNhapHang.Enabled = true;
            btnPhieuXuatHang.Enabled = true;
            btnDonDatHang.Enabled = true;
            btnDSNhanVien.Enabled = true;
            btnTonKho.Enabled = true;
            btnDoanhThu.Enabled = true;
            btnTimNV.Enabled = true;
            btnTimMatHang.Enabled = true;
            btnTimNhaCC.Enabled = true;
            btnTimKH.Enabled = true;
        }

        public void Users()
        {
            btnAbout.Enabled = true;
            btnCalculator.Enabled = true;
            btnClose.Enabled = true;
            btnHelp.Enabled = true;

            btnDangNhap.Enabled = true;
            btnBackUp.Enabled = false;
            btnRestor.Enabled = false;
            btnChangePass.Enabled = true;
            btnDangXuat.Enabled = true;

            btnThemMatHang.Enabled = true;
            btnXuatHang.Enabled = true;
            btnDatHang.Enabled = true;

            btnKhachHang.Enabled = true;

            btnQuayGiaoDich.Enabled = true;
            btnNhanVien.Enabled = true;

            btnNhomNguoiDung.Enabled = false;
            btnQuyen.Enabled = false;
            btnPhanNhom.Enabled = false;
            btnPhanQuyen.Enabled = false;
            btnDSMatHang.Enabled = true;
            btnDSNhaCungCap.Enabled = true;

            btnDMLoaiGiaoDich.Enabled = true;
            btnDMLoaiTien.Enabled = true;

            btnPhieuNhapHang.Enabled = true;
            btnPhieuXuatHang.Enabled = true;
            btnDonDatHang.Enabled = true;
            btnDSNhanVien.Enabled = true;
            btnTonKho.Enabled = true;
            btnDoanhThu.Enabled = true;
            btnTimNV.Enabled = false;
            btnTimMatHang.Enabled = true;
            btnTimNhaCC.Enabled = true;
            btnTimKH.Enabled = true;
        }
        #endregion
      
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có muốn thoát khỏi phần mềm quản lý siêu thị không?", "THOÁT KHỎI CHƯƠNG TRÌNH", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Trogiup.chm");
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }
        frmAbout m_FrmAbout = null;
        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (m_FrmAbout == null || m_FrmAbout.IsDisposed)
            {
                m_FrmAbout = new frmAbout();
                m_FrmAbout.MdiParent = frmMain.ActiveForm;
                m_FrmAbout.Show();
            }
            else
                m_FrmAbout.Activate();
        }
        #region Đổi mật khẩu
        frmDoiMatKhau m_FrmDoiMatKhau = null;
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (m_FrmDoiMatKhau == null || m_FrmDoiMatKhau.IsDisposed)
            {
                m_FrmDoiMatKhau = new frmDoiMatKhau();

                m_FrmDoiMatKhau.txtMatKhauCu.Text = "";
                m_FrmDoiMatKhau.txtMatKhauMoi.Text = "";
                m_FrmDoiMatKhau.txtNhapLaiMatKhauMoi.Text = "";

                m_FrmDoiMatKhau.lblMatKhauCu.Text = "";
                m_FrmDoiMatKhau.lblMatKhauMoi.Text = "";
                m_FrmDoiMatKhau.lblNhapLaiMatKhauMoi.Text = "";

                DoiMatKhau();

            }
        }
        public void DoiMatKhau()
        {
        Cont:
            if (m_FrmDoiMatKhau.ShowDialog() == DialogResult.OK)
            {
                if (m_FrmDoiMatKhau.txtMatKhauCu.Text == "")
                {
                    m_FrmDoiMatKhau.lblMatKhauCu.Text = "Chưa nhập mật khẩu cũ";
                    m_FrmDoiMatKhau.lblMatKhauMoi.Text = "";
                    m_FrmDoiMatKhau.lblNhapLaiMatKhauMoi.Text = "";

                    goto Cont;
                }

                if (m_FrmDoiMatKhau.txtMatKhauMoi.Text == "")
                {
                    m_FrmDoiMatKhau.lblMatKhauMoi.Text = "Chưa nhập mật khẩu mới";
                    m_FrmDoiMatKhau.lblMatKhauCu.Text = "";
                    m_FrmDoiMatKhau.lblNhapLaiMatKhauMoi.Text = "";

                    goto Cont;
                }

                if (m_FrmDoiMatKhau.txtNhapLaiMatKhauMoi.Text == "")
                {
                    m_FrmDoiMatKhau.lblNhapLaiMatKhauMoi.Text = "Chưa nhập lại mật khẩu mới";
                    m_FrmDoiMatKhau.lblMatKhauMoi.Text = "";
                    m_FrmDoiMatKhau.lblMatKhauCu.Text = "";

                    goto Cont;
                }

                String m_TenDangNhap = m_FrmDangNhap.txtUserName.Text;
                String m_MatKhau = m_FrmDangNhap.txtPass.Text;

                String m_MatKhauCu = m_FrmDoiMatKhau.txtMatKhauCu.Text;
                String m_MatKhauMoi = m_FrmDoiMatKhau.txtMatKhauMoi.Text;
                String m_NhapLaiMatKhauMoi = m_FrmDoiMatKhau.txtNhapLaiMatKhauMoi.Text;

                if (m_MatKhauCu != m_MatKhau)
                {
                    m_FrmDoiMatKhau.lblMatKhauCu.Text = "Nhập mật khẩu cũ không khớp";
                    m_FrmDoiMatKhau.lblMatKhauMoi.Text = "";
                    m_FrmDoiMatKhau.lblNhapLaiMatKhauMoi.Text = "";
                    goto Cont;
                }

                else if (m_MatKhauMoi != m_NhapLaiMatKhauMoi)
                {
                    m_FrmDoiMatKhau.lblNhapLaiMatKhauMoi.Text = "Nhập lại mật khẩu không khớp";
                    m_FrmDoiMatKhau.lblMatKhauMoi.Text = "";
                    m_FrmDoiMatKhau.lblMatKhauCu.Text = "";
                    goto Cont;
                }
                else
                {
                    m_PhanQuyenCtrl.DoiMatKhau(m_TenDangNhap, m_MatKhauMoi);
                    MessageBoxEx.Show("Đổi mật khẩu thành công!", "PASSWORD CHANGED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion
        #region sao lưu dữ liệu:
        private void btnBackUp_Click(object sender, EventArgs e)
        {
            if (backupDialog.ShowDialog() == DialogResult.OK)
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("BACKUP DATABASE " + ThamSo.DatabaseName + " TO DISK = '" + backupDialog.FileName.ToString() + "'");
                DataService data = new DataService();
                data.Load(cmd);
                MessageBoxEx.Show("Sao lưu dữ liệu thành công!", "BACKUP COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
        }

        private void btnRestor_Click(object sender, EventArgs e)
        {
            if (restoreDialog.ShowDialog() == DialogResult.OK)
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("BACKUP DATABASE " + ThamSo.DatabaseName + " TO DISK = '" + backupDialog.FileName.ToString() + "'");
                DataService data = new DataService();
                data.Load(cmd);
                MessageBoxEx.Show("Sao lưu dữ liệu thành công!", "BACKUP COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
        }
        #endregion
        #region hiện thị menu Quản Lý:
        private void btnThemMatHang_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiMatHang();
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiXuatHang();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiDatHang();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiKhachHang();
        }

        private void btnQuayGiaoDich_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiQuayGiaoDich();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiNhanVien();
        }

        private void btnNhomNguoiDung_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiNhomNguoiDung();
        }

        private void btnQuyen_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiQuyen();
        }

        private void btnPhanNhom_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiPhanNhomNguoiDung();
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiPhanQuyen();
        }
        #endregion
        #region Hiển Thị menu Quản Lý Chi tiết:

        private void btnDSMatHang_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiDSMatHang();
        }

        private void btnDSNhaCungCap_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiNhaCungCap();
        }

        private void btnDMLoaiTien_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiLoaiTien();
        }

        private void btnDMLoaiGiaoDich_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiLoaiGiaoDich();
        }
        #endregion

        #region Menu tìm Kiếm:
        private void btnTimNV_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiTimKiemNhanVien();
        }

        private void btnTimMatHang_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiTimKiemMatHang();
        }

        private void btnTimNhaCC_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiTimNhaCungCap();
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiTimKiemKhachHang();
        }
        #endregion
        #region menu Lập Phiếu:
        private void btnDonDatHang_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiDonDatHang();
        }

        private void btnPhieuNhapHang_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiPhieuNhapHang();
        }

        private void btnPhieuXuatHang_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiPhieuXuatHang();
        }
        #endregion
        #region Menu Thống Kê:

        private void btnDSNhanVien_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiDSNhanVien();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiDoanhThu();
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            LoadMain.HienThiTonKho();
        }
        #endregion
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có muốn thoát khỏi phần mềm quản lý siêu thị không?", "THOÁT KHỎI CHƯƠNG TRÌNH", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

    }
}
