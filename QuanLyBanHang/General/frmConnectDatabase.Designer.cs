namespace QuanLyBanHang.General
{
    partial class frmConnectDatabase
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
            this.cmbAuthentication = new System.Windows.Forms.ComboBox();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.txtBrower = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBrower = new DevComponents.DotNetBar.ButtonX();
            this.lblDatabase = new DevComponents.DotNetBar.LabelX();
            this.cmbDatabase = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnTest = new DevComponents.DotNetBar.ButtonX();
            this.lblPassword = new DevComponents.DotNetBar.LabelX();
            this.txtpassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblUserName = new DevComponents.DotNetBar.LabelX();
            this.lblAuthentication = new DevComponents.DotNetBar.LabelX();
            this.lblServer = new DevComponents.DotNetBar.LabelX();
            this.txtSever = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbKetNoi = new System.Windows.Forms.ComboBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // cmbAuthentication
            // 
            this.cmbAuthentication.FormattingEnabled = true;
            this.cmbAuthentication.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cmbAuthentication.Location = new System.Drawing.Point(203, 77);
            this.cmbAuthentication.Name = "cmbAuthentication";
            this.cmbAuthentication.Size = new System.Drawing.Size(205, 21);
            this.cmbAuthentication.TabIndex = 37;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Location = new System.Drawing.Point(94, 260);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(324, 1);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 36;
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(300, 271);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 23);
            this.btnHuy.TabIndex = 34;
            this.btnHuy.Text = "Hủy bỏ";
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(160, 271);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 23);
            this.btnLogin.TabIndex = 35;
            this.btnLogin.Text = "Chấp nhận";
            // 
            // txtBrower
            // 
            // 
            // 
            // 
            this.txtBrower.Border.Class = "TextBoxBorder";
            this.txtBrower.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBrower.Location = new System.Drawing.Point(88, 104);
            this.txtBrower.Multiline = true;
            this.txtBrower.Name = "txtBrower";
            this.txtBrower.Size = new System.Drawing.Size(216, 25);
            this.txtBrower.TabIndex = 33;
            // 
            // btnBrower
            // 
            this.btnBrower.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrower.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBrower.Location = new System.Drawing.Point(310, 104);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(98, 25);
            this.btnBrower.TabIndex = 32;
            this.btnBrower.Text = "Brower";
            // 
            // lblDatabase
            // 
            // 
            // 
            // 
            this.lblDatabase.BackgroundStyle.Class = "";
            this.lblDatabase.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDatabase.Location = new System.Drawing.Point(94, 223);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(75, 23);
            this.lblDatabase.TabIndex = 31;
            this.lblDatabase.Text = "Database:";
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.DisplayMember = "Text";
            this.cmbDatabase.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.ItemHeight = 14;
            this.cmbDatabase.Location = new System.Drawing.Point(203, 223);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(205, 20);
            this.cmbDatabase.TabIndex = 30;
            // 
            // btnTest
            // 
            this.btnTest.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTest.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTest.Location = new System.Drawing.Point(300, 181);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(108, 27);
            this.btnTest.TabIndex = 29;
            this.btnTest.Text = "Test Connection";
            // 
            // lblPassword
            // 
            // 
            // 
            // 
            this.lblPassword.BackgroundStyle.Class = "";
            this.lblPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPassword.Location = new System.Drawing.Point(94, 146);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 26);
            this.lblPassword.TabIndex = 28;
            this.lblPassword.Text = "Password:";
            // 
            // txtpassword
            // 
            // 
            // 
            // 
            this.txtpassword.Border.Class = "TextBoxBorder";
            this.txtpassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpassword.Location = new System.Drawing.Point(203, 146);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(193, 20);
            this.txtpassword.TabIndex = 26;
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.Border.Class = "TextBoxBorder";
            this.txtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUserName.Location = new System.Drawing.Point(203, 109);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(193, 20);
            this.txtUserName.TabIndex = 27;
            // 
            // lblUserName
            // 
            // 
            // 
            // 
            this.lblUserName.BackgroundStyle.Class = "";
            this.lblUserName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUserName.Location = new System.Drawing.Point(94, 109);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 23);
            this.lblUserName.TabIndex = 25;
            this.lblUserName.Text = "UserName:";
            // 
            // lblAuthentication
            // 
            // 
            // 
            // 
            this.lblAuthentication.BackgroundStyle.Class = "";
            this.lblAuthentication.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAuthentication.Location = new System.Drawing.Point(94, 78);
            this.lblAuthentication.Name = "lblAuthentication";
            this.lblAuthentication.Size = new System.Drawing.Size(92, 20);
            this.lblAuthentication.TabIndex = 24;
            this.lblAuthentication.Text = "Authentication:";
            // 
            // lblServer
            // 
            // 
            // 
            // 
            this.lblServer.BackgroundStyle.Class = "";
            this.lblServer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblServer.Location = new System.Drawing.Point(98, 39);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(75, 23);
            this.lblServer.TabIndex = 23;
            this.lblServer.Text = "Server: ";
            // 
            // txtSever
            // 
            // 
            // 
            // 
            this.txtSever.Border.Class = "TextBoxBorder";
            this.txtSever.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSever.Location = new System.Drawing.Point(203, 42);
            this.txtSever.Name = "txtSever";
            this.txtSever.Size = new System.Drawing.Size(205, 20);
            this.txtSever.TabIndex = 22;
            // 
            // cmbKetNoi
            // 
            this.cmbKetNoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKetNoi.FormattingEnabled = true;
            this.cmbKetNoi.Items.AddRange(new object[] {
            "Microsoft SQL Server (SqlClient)",
            "Microsoft Access Database File (OLE DB)"});
            this.cmbKetNoi.Location = new System.Drawing.Point(203, 7);
            this.cmbKetNoi.Name = "cmbKetNoi";
            this.cmbKetNoi.Size = new System.Drawing.Size(205, 21);
            this.cmbKetNoi.TabIndex = 21;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(96, 7);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(101, 23);
            this.labelX2.TabIndex = 20;
            this.labelX2.Text = "Chọn loại kết nối:";
            // 
            // frmConnectDatabase
            // 
            this.ClientSize = new System.Drawing.Size(433, 304);
            this.Controls.Add(this.cmbAuthentication);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBrower);
            this.Controls.Add(this.btnBrower);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.cmbDatabase);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblAuthentication);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.txtSever);
            this.Controls.Add(this.cmbKetNoi);
            this.Controls.Add(this.labelX2);
            this.DoubleBuffered = true;
            this.Name = "frmConnectDatabase";
            this.Text = "KẾT NỐI DỮ LIỆU";
            this.Load += new System.EventHandler(this.frmConnectDatabase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAuthentication;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.ButtonX btnLogin;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBrower;
        private DevComponents.DotNetBar.ButtonX btnBrower;
        private DevComponents.DotNetBar.LabelX lblDatabase;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDatabase;
        private DevComponents.DotNetBar.ButtonX btnTest;
        private DevComponents.DotNetBar.LabelX lblPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserName;
        private DevComponents.DotNetBar.LabelX lblUserName;
        private DevComponents.DotNetBar.LabelX lblAuthentication;
        private DevComponents.DotNetBar.LabelX lblServer;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSever;
        private System.Windows.Forms.ComboBox cmbKetNoi;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}