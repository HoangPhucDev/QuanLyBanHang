namespace QuanLyBanHang.Report
{
    partial class frmDSNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.NhanVienInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportViewerDanhSachNhanVien = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportViewerDanhSachNhanVien
            // 
            this.ReportViewerDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "NhanVienInfo";
            reportDataSource1.Value = this.NhanVienInfoBindingSource;
            this.ReportViewerDanhSachNhanVien.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerDanhSachNhanVien.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.Report.rptNhanVien.rdlc";
            this.ReportViewerDanhSachNhanVien.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerDanhSachNhanVien.Name = "ReportViewerDanhSachNhanVien";
            this.ReportViewerDanhSachNhanVien.Size = new System.Drawing.Size(645, 447);
            this.ReportViewerDanhSachNhanVien.TabIndex = 1;
            // 
            // frmDSNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 447);
            this.Controls.Add(this.ReportViewerDanhSachNhanVien);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDSNhanVien";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH NHÂN VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDSNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerDanhSachNhanVien;
        private System.Windows.Forms.BindingSource NhanVienInfoBindingSource;
    }
}