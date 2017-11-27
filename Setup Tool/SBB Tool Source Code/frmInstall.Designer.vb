<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstall
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstall))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.b_Finish = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.b_Flash = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.b_Download = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.b_WLAN = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.b_Controller = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.b_ServerInstall = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.circle_Wait = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.b_EXIT = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Start = New System.Windows.Forms.TabPage()
        Me.BunifuCustomLabel32 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.b_Start_NEIN = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.b_Start_JA = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tabServer1 = New System.Windows.Forms.TabPage()
        Me.b_tabServer1_Zurück = New Bunifu.Framework.UI.BunifuImageButton()
        Me.b_tabServer1_WeiterZuFtpVerzeichnis = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pic_tabServer1_FTPStatus = New System.Windows.Forms.PictureBox()
        Me.lbl_tabServer1_FTPStatus = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txt_tabServer1_SeverAddress = New Bunifu.Framework.UI.BunifuTextbox()
        Me.txt_tabServer1_Port = New Bunifu.Framework.UI.BunifuTextbox()
        Me.b_tabServer1_PrüfeFTP = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txt_tabServer1_FTPPassword = New Bunifu.Framework.UI.BunifuTextbox()
        Me.txt_tabServer1_Username = New Bunifu.Framework.UI.BunifuTextbox()
        Me.tabServer2 = New System.Windows.Forms.TabPage()
        Me.p_tabServer2_UploadVerzeichnis = New System.Windows.Forms.Panel()
        Me.b_tabServer2_WeiterZuMySQL = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lbl_AusgewähltesUploadVerzeichnis = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_tabServer2_Pfad = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.b_tabServer2_HomeButton = New Bunifu.Framework.UI.BunifuImageButton()
        Me.b_tabServer2_OrdnerLöschen = New Bunifu.Framework.UI.BunifuImageButton()
        Me.b_tabServer2_OrdnerHinzufügen = New Bunifu.Framework.UI.BunifuImageButton()
        Me.b_tabServer2_UploadPfadÜbernehmen = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lb_tabServer2_FTPVerzeichnis = New System.Windows.Forms.ListBox()
        Me.tabMySQL1 = New System.Windows.Forms.TabPage()
        Me.BunifuCustomLabel42 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel41 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cb_tabMySQL1_KeineMySQL_User_Prüfung = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.b_tabMySQL1_Zurück = New Bunifu.Framework.UI.BunifuImageButton()
        Me.b_tabMySQL_WeiterZuWLAN = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_tabMySQL1_MySQLStatus = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel15 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel13 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel14 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txt_tabMySQL1_Database = New Bunifu.Framework.UI.BunifuTextbox()
        Me.txt_tabMySQL1_ServerAdresse = New Bunifu.Framework.UI.BunifuTextbox()
        Me.txt_tabMySQL1_Port = New Bunifu.Framework.UI.BunifuTextbox()
        Me.b_tabMySQL1_PrüfeMySQLConnection = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txt_tabMySQL1_Password = New Bunifu.Framework.UI.BunifuTextbox()
        Me.txt_tabMySQL1_User = New Bunifu.Framework.UI.BunifuTextbox()
        Me.tabWLAN1 = New System.Windows.Forms.TabPage()
        Me.b_tabWlan_Suche_Wlan = New Bunifu.Framework.UI.BunifuImageButton()
        Me.b_tabWLAN_Zurück = New Bunifu.Framework.UI.BunifuImageButton()
        Me.b_tabWLAN1_WeiterZuController = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel19 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel18 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_tabWLAN_Key = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuCustomLabel17 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_tabWLAN1_WLANStatus = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel16 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txt_tabWLAN_WLANName = New Bunifu.Framework.UI.BunifuTextbox()
        Me.tabController1 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel43 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txt_tabController1_URL = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuCustomLabel29 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel26 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel33 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel31 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel30 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCustomLabel28 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_tabController1_HostURL = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel27 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel25 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel24 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel22 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.lbl_tabController1_Controller_Auswahl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_tabController1_WLAN_Schlüssel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel21 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_tabController1_WLANSSID = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel23 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator4 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel20 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.b_tabController1_Weiter = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txt_tabController1_Intervall_Abfrage = New Bunifu.Framework.UI.BunifuTextbox()
        Me.txt_tabController1_HTTP_port = New Bunifu.Framework.UI.BunifuTextbox()
        Me.txt_tabController1_Host = New Bunifu.Framework.UI.BunifuTextbox()
        Me.txt_tabController1_API_Password = New Bunifu.Framework.UI.BunifuTextbox()
        Me.b_tabController1_ControllerV2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.b_tabController1_ControllerV1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tabDownload = New System.Windows.Forms.TabPage()
        Me.b_tabDownload_Weiter_zum_Flashen = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txt_tabDownload_AblaufStatus = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.lbl_tabDownload_Controller_Status = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_tabDownload_Server_Status = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_tabDownload_SVController = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_tabDownload_SVWeb = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_tabDownload_LVController = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_tabDownload_LVWeb = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator11 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator10 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator9 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator8 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator7 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel38 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel37 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel36 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel35 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator6 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel34 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.b_tabDownload_StarteDownload = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.tabFlash1 = New System.Windows.Forms.TabPage()
        Me.b_tabFlash1_Sende_Credentials = New Bunifu.Framework.UI.BunifuTileButton()
        Me.pb_tabFlash1_ProgressBar = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.panelComPort = New System.Windows.Forms.Panel()
        Me.b_TabFlash1_Burn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel40 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cb_tabFlash1_COM_Ports = New System.Windows.Forms.ComboBox()
        Me.lbl_tabFlash1_Anweisungen = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txt_tabFlash1_Status = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.b_TabFlash1_Starte_FlashVorgang = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuSeparator13 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuSeparator12 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel39 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.b_EXIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Start.SuspendLayout()
        Me.tabServer1.SuspendLayout()
        CType(Me.b_tabServer1_Zurück, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_tabServer1_FTPStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabServer2.SuspendLayout()
        Me.p_tabServer2_UploadVerzeichnis.SuspendLayout()
        CType(Me.b_tabServer2_HomeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.b_tabServer2_OrdnerLöschen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.b_tabServer2_OrdnerHinzufügen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.b_tabServer2_UploadPfadÜbernehmen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMySQL1.SuspendLayout()
        CType(Me.b_tabMySQL1_Zurück, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWLAN1.SuspendLayout()
        CType(Me.b_tabWlan_Suche_Wlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.b_tabWLAN_Zurück, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.tabController1.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.b_tabController1_ControllerV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.b_tabController1_ControllerV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDownload.SuspendLayout()
        Me.tabFlash1.SuspendLayout()
        Me.panelComPort.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.b_Finish)
        Me.Panel1.Controls.Add(Me.b_Flash)
        Me.Panel1.Controls.Add(Me.b_Download)
        Me.Panel1.Controls.Add(Me.b_WLAN)
        Me.Panel1.Controls.Add(Me.b_Controller)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.b_ServerInstall)
        Me.Panel1.Controls.Add(Me.circle_Wait)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 617)
        Me.Panel1.TabIndex = 0
        '
        'b_Finish
        '
        Me.b_Finish.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.b_Finish.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.b_Finish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_Finish.BorderRadius = 0
        Me.b_Finish.ButtonText = "           Finish"
        Me.b_Finish.CausesValidation = False
        Me.b_Finish.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_Finish.DisabledColor = System.Drawing.Color.Gray
        Me.b_Finish.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Finish.Iconcolor = System.Drawing.Color.Transparent
        Me.b_Finish.Iconimage = Global.SBB_Tool.My.Resources.Resources.Finish
        Me.b_Finish.Iconimage_right = Nothing
        Me.b_Finish.Iconimage_right_Selected = Nothing
        Me.b_Finish.Iconimage_Selected = Nothing
        Me.b_Finish.IconMarginLeft = 0
        Me.b_Finish.IconMarginRight = 0
        Me.b_Finish.IconRightVisible = True
        Me.b_Finish.IconRightZoom = 0.0R
        Me.b_Finish.IconVisible = True
        Me.b_Finish.IconZoom = 45.0R
        Me.b_Finish.IsTab = False
        Me.b_Finish.Location = New System.Drawing.Point(-5, 316)
        Me.b_Finish.Margin = New System.Windows.Forms.Padding(0)
        Me.b_Finish.Name = "b_Finish"
        Me.b_Finish.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.b_Finish.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.b_Finish.OnHoverTextColor = System.Drawing.Color.White
        Me.b_Finish.selected = False
        Me.b_Finish.Size = New System.Drawing.Size(215, 65)
        Me.b_Finish.TabIndex = 2
        Me.b_Finish.Text = "           Finish"
        Me.b_Finish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_Finish.Textcolor = System.Drawing.Color.White
        Me.b_Finish.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'b_Flash
        '
        Me.b_Flash.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.b_Flash.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.b_Flash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_Flash.BorderRadius = 0
        Me.b_Flash.ButtonText = "           Firmware Flash"
        Me.b_Flash.CausesValidation = False
        Me.b_Flash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_Flash.DisabledColor = System.Drawing.Color.Gray
        Me.b_Flash.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Flash.Iconcolor = System.Drawing.Color.Transparent
        Me.b_Flash.Iconimage = Global.SBB_Tool.My.Resources.Resources.FLASH
        Me.b_Flash.Iconimage_right = Nothing
        Me.b_Flash.Iconimage_right_Selected = Nothing
        Me.b_Flash.Iconimage_Selected = Nothing
        Me.b_Flash.IconMarginLeft = 0
        Me.b_Flash.IconMarginRight = 0
        Me.b_Flash.IconRightVisible = True
        Me.b_Flash.IconRightZoom = 0.0R
        Me.b_Flash.IconVisible = True
        Me.b_Flash.IconZoom = 45.0R
        Me.b_Flash.IsTab = False
        Me.b_Flash.Location = New System.Drawing.Point(-5, 251)
        Me.b_Flash.Margin = New System.Windows.Forms.Padding(0)
        Me.b_Flash.Name = "b_Flash"
        Me.b_Flash.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.b_Flash.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.b_Flash.OnHoverTextColor = System.Drawing.Color.White
        Me.b_Flash.selected = False
        Me.b_Flash.Size = New System.Drawing.Size(215, 65)
        Me.b_Flash.TabIndex = 3
        Me.b_Flash.Text = "           Firmware Flash"
        Me.b_Flash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_Flash.Textcolor = System.Drawing.Color.White
        Me.b_Flash.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'b_Download
        '
        Me.b_Download.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.b_Download.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.b_Download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_Download.BorderRadius = 0
        Me.b_Download.ButtonText = "           Download"
        Me.b_Download.CausesValidation = False
        Me.b_Download.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_Download.DisabledColor = System.Drawing.Color.Gray
        Me.b_Download.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Download.Iconcolor = System.Drawing.Color.Transparent
        Me.b_Download.Iconimage = Global.SBB_Tool.My.Resources.Resources.Wolke
        Me.b_Download.Iconimage_right = Nothing
        Me.b_Download.Iconimage_right_Selected = Nothing
        Me.b_Download.Iconimage_Selected = Nothing
        Me.b_Download.IconMarginLeft = 0
        Me.b_Download.IconMarginRight = 0
        Me.b_Download.IconRightVisible = True
        Me.b_Download.IconRightZoom = 0.0R
        Me.b_Download.IconVisible = True
        Me.b_Download.IconZoom = 45.0R
        Me.b_Download.IsTab = False
        Me.b_Download.Location = New System.Drawing.Point(-5, 186)
        Me.b_Download.Margin = New System.Windows.Forms.Padding(0)
        Me.b_Download.Name = "b_Download"
        Me.b_Download.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.b_Download.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.b_Download.OnHoverTextColor = System.Drawing.Color.White
        Me.b_Download.selected = False
        Me.b_Download.Size = New System.Drawing.Size(215, 65)
        Me.b_Download.TabIndex = 13
        Me.b_Download.Text = "           Download"
        Me.b_Download.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_Download.Textcolor = System.Drawing.Color.White
        Me.b_Download.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'b_WLAN
        '
        Me.b_WLAN.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.b_WLAN.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.b_WLAN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_WLAN.BorderRadius = 0
        Me.b_WLAN.ButtonText = "           WLAN Settings"
        Me.b_WLAN.CausesValidation = False
        Me.b_WLAN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_WLAN.DisabledColor = System.Drawing.Color.Gray
        Me.b_WLAN.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_WLAN.Iconcolor = System.Drawing.Color.Transparent
        Me.b_WLAN.Iconimage = Global.SBB_Tool.My.Resources.Resources.WLAN
        Me.b_WLAN.Iconimage_right = Nothing
        Me.b_WLAN.Iconimage_right_Selected = Nothing
        Me.b_WLAN.Iconimage_Selected = Nothing
        Me.b_WLAN.IconMarginLeft = 0
        Me.b_WLAN.IconMarginRight = 0
        Me.b_WLAN.IconRightVisible = True
        Me.b_WLAN.IconRightZoom = 0.0R
        Me.b_WLAN.IconVisible = True
        Me.b_WLAN.IconZoom = 45.0R
        Me.b_WLAN.IsTab = False
        Me.b_WLAN.Location = New System.Drawing.Point(-5, 56)
        Me.b_WLAN.Margin = New System.Windows.Forms.Padding(0)
        Me.b_WLAN.Name = "b_WLAN"
        Me.b_WLAN.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.b_WLAN.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.b_WLAN.OnHoverTextColor = System.Drawing.Color.White
        Me.b_WLAN.selected = False
        Me.b_WLAN.Size = New System.Drawing.Size(215, 65)
        Me.b_WLAN.TabIndex = 3
        Me.b_WLAN.Text = "           WLAN Settings"
        Me.b_WLAN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_WLAN.Textcolor = System.Drawing.Color.White
        Me.b_WLAN.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'b_Controller
        '
        Me.b_Controller.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.b_Controller.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.b_Controller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_Controller.BorderRadius = 0
        Me.b_Controller.ButtonText = "           WemOS Firmware"
        Me.b_Controller.CausesValidation = False
        Me.b_Controller.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_Controller.DisabledColor = System.Drawing.Color.Gray
        Me.b_Controller.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Controller.Iconcolor = System.Drawing.Color.Transparent
        Me.b_Controller.Iconimage = CType(resources.GetObject("b_Controller.Iconimage"), System.Drawing.Image)
        Me.b_Controller.Iconimage_right = Nothing
        Me.b_Controller.Iconimage_right_Selected = Nothing
        Me.b_Controller.Iconimage_Selected = Nothing
        Me.b_Controller.IconMarginLeft = 0
        Me.b_Controller.IconMarginRight = 0
        Me.b_Controller.IconRightVisible = True
        Me.b_Controller.IconRightZoom = 0.0R
        Me.b_Controller.IconVisible = True
        Me.b_Controller.IconZoom = 45.0R
        Me.b_Controller.IsTab = False
        Me.b_Controller.Location = New System.Drawing.Point(-5, 121)
        Me.b_Controller.Margin = New System.Windows.Forms.Padding(0)
        Me.b_Controller.Name = "b_Controller"
        Me.b_Controller.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.b_Controller.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.b_Controller.OnHoverTextColor = System.Drawing.Color.White
        Me.b_Controller.selected = False
        Me.b_Controller.Size = New System.Drawing.Size(215, 65)
        Me.b_Controller.TabIndex = 1
        Me.b_Controller.Text = "           WemOS Firmware"
        Me.b_Controller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_Controller.Textcolor = System.Drawing.Color.White
        Me.b_Controller.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SBB_Tool.My.Resources.Resources.SBBLogo
        Me.PictureBox1.Location = New System.Drawing.Point(51, 415)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'b_ServerInstall
        '
        Me.b_ServerInstall.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.b_ServerInstall.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.b_ServerInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_ServerInstall.BorderRadius = 0
        Me.b_ServerInstall.ButtonText = "           Server Install"
        Me.b_ServerInstall.CausesValidation = False
        Me.b_ServerInstall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_ServerInstall.DisabledColor = System.Drawing.Color.Gray
        Me.b_ServerInstall.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_ServerInstall.Iconcolor = System.Drawing.Color.Transparent
        Me.b_ServerInstall.Iconimage = Global.SBB_Tool.My.Resources.Resources.SBBIcons
        Me.b_ServerInstall.Iconimage_right = Nothing
        Me.b_ServerInstall.Iconimage_right_Selected = Nothing
        Me.b_ServerInstall.Iconimage_Selected = Nothing
        Me.b_ServerInstall.IconMarginLeft = 0
        Me.b_ServerInstall.IconMarginRight = 0
        Me.b_ServerInstall.IconRightVisible = True
        Me.b_ServerInstall.IconRightZoom = 0.0R
        Me.b_ServerInstall.IconVisible = True
        Me.b_ServerInstall.IconZoom = 45.0R
        Me.b_ServerInstall.IsTab = False
        Me.b_ServerInstall.Location = New System.Drawing.Point(-5, 0)
        Me.b_ServerInstall.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.b_ServerInstall.Name = "b_ServerInstall"
        Me.b_ServerInstall.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.b_ServerInstall.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.b_ServerInstall.OnHoverTextColor = System.Drawing.Color.White
        Me.b_ServerInstall.selected = False
        Me.b_ServerInstall.Size = New System.Drawing.Size(215, 65)
        Me.b_ServerInstall.TabIndex = 0
        Me.b_ServerInstall.Text = "           Server Install"
        Me.b_ServerInstall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_ServerInstall.Textcolor = System.Drawing.Color.White
        Me.b_ServerInstall.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'circle_Wait
        '
        Me.circle_Wait.animated = True
        Me.circle_Wait.animationIterval = 5
        Me.circle_Wait.animationSpeed = 300
        Me.circle_Wait.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.circle_Wait.BackgroundImage = CType(resources.GetObject("circle_Wait.BackgroundImage"), System.Drawing.Image)
        Me.circle_Wait.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.circle_Wait.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.circle_Wait.LabelVisible = True
        Me.circle_Wait.LineProgressThickness = 8
        Me.circle_Wait.LineThickness = 5
        Me.circle_Wait.Location = New System.Drawing.Point(8, 380)
        Me.circle_Wait.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.circle_Wait.MaxValue = 100
        Me.circle_Wait.Name = "circle_Wait"
        Me.circle_Wait.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.circle_Wait.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.circle_Wait.Size = New System.Drawing.Size(188, 188)
        Me.circle_Wait.TabIndex = 12
        Me.circle_Wait.Value = 0
        Me.circle_Wait.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel2.Controls.Add(Me.b_EXIT)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1079, 51)
        Me.Panel2.TabIndex = 1
        '
        'b_EXIT
        '
        Me.b_EXIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.b_EXIT.Image = Global.SBB_Tool.My.Resources.Resources.Close
        Me.b_EXIT.ImageActive = Nothing
        Me.b_EXIT.Location = New System.Drawing.Point(1015, 3)
        Me.b_EXIT.Name = "b_EXIT"
        Me.b_EXIT.Size = New System.Drawing.Size(51, 45)
        Me.b_EXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.b_EXIT.TabIndex = 6
        Me.b_EXIT.TabStop = False
        Me.ToolTip1.SetToolTip(Me.b_EXIT, "Schliesse das Fenster")
        Me.b_EXIT.Zoom = 10
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(12, 9)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(702, 30)
        Me.BunifuCustomLabel2.TabIndex = 4
        Me.BunifuCustomLabel2.Text = "Smart Bud Box ...     the new way to cultivate SMART Plants"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TabControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(200, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(879, 617)
        Me.Panel3.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Start)
        Me.TabControl1.Controls.Add(Me.tabServer1)
        Me.TabControl1.Controls.Add(Me.tabServer2)
        Me.TabControl1.Controls.Add(Me.tabMySQL1)
        Me.TabControl1.Controls.Add(Me.tabWLAN1)
        Me.TabControl1.Controls.Add(Me.tabController1)
        Me.TabControl1.Controls.Add(Me.tabDownload)
        Me.TabControl1.Controls.Add(Me.tabFlash1)
        Me.TabControl1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(1, 6)
        Me.TabControl1.Location = New System.Drawing.Point(-9, -18)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1042, 642)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Start.Controls.Add(Me.BunifuCustomLabel32)
        Me.Start.Controls.Add(Me.b_Start_NEIN)
        Me.Start.Controls.Add(Me.b_Start_JA)
        Me.Start.Controls.Add(Me.BunifuCustomLabel1)
        Me.Start.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start.Location = New System.Drawing.Point(4, 10)
        Me.Start.Name = "Start"
        Me.Start.Padding = New System.Windows.Forms.Padding(3)
        Me.Start.Size = New System.Drawing.Size(1034, 628)
        Me.Start.TabIndex = 0
        '
        'BunifuCustomLabel32
        '
        Me.BunifuCustomLabel32.AutoSize = True
        Me.BunifuCustomLabel32.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel32.ForeColor = System.Drawing.Color.Red
        Me.BunifuCustomLabel32.Location = New System.Drawing.Point(171, 294)
        Me.BunifuCustomLabel32.Name = "BunifuCustomLabel32"
        Me.BunifuCustomLabel32.Size = New System.Drawing.Size(635, 22)
        Me.BunifuCustomLabel32.TabIndex = 27
        Me.BunifuCustomLabel32.Text = "Controller erst per USB anschliessen wenn du dazu aufgefordert wirst!"
        '
        'b_Start_NEIN
        '
        Me.b_Start_NEIN.ActiveBorderThickness = 1
        Me.b_Start_NEIN.ActiveCornerRadius = 20
        Me.b_Start_NEIN.ActiveFillColor = System.Drawing.Color.Red
        Me.b_Start_NEIN.ActiveForecolor = System.Drawing.Color.White
        Me.b_Start_NEIN.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b_Start_NEIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_Start_NEIN.BackgroundImage = CType(resources.GetObject("b_Start_NEIN.BackgroundImage"), System.Drawing.Image)
        Me.b_Start_NEIN.ButtonText = "NEIN"
        Me.b_Start_NEIN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_Start_NEIN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Start_NEIN.ForeColor = System.Drawing.Color.Red
        Me.b_Start_NEIN.IdleBorderThickness = 1
        Me.b_Start_NEIN.IdleCornerRadius = 20
        Me.b_Start_NEIN.IdleFillColor = System.Drawing.Color.White
        Me.b_Start_NEIN.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.b_Start_NEIN.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.b_Start_NEIN.Location = New System.Drawing.Point(598, 372)
        Me.b_Start_NEIN.Margin = New System.Windows.Forms.Padding(5)
        Me.b_Start_NEIN.Name = "b_Start_NEIN"
        Me.b_Start_NEIN.Size = New System.Drawing.Size(263, 72)
        Me.b_Start_NEIN.TabIndex = 2
        Me.b_Start_NEIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'b_Start_JA
        '
        Me.b_Start_JA.ActiveBorderThickness = 1
        Me.b_Start_JA.ActiveCornerRadius = 20
        Me.b_Start_JA.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.b_Start_JA.ActiveForecolor = System.Drawing.Color.White
        Me.b_Start_JA.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b_Start_JA.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_Start_JA.BackgroundImage = CType(resources.GetObject("b_Start_JA.BackgroundImage"), System.Drawing.Image)
        Me.b_Start_JA.ButtonText = "JA"
        Me.b_Start_JA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_Start_JA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Start_JA.ForeColor = System.Drawing.Color.SeaGreen
        Me.b_Start_JA.IdleBorderThickness = 1
        Me.b_Start_JA.IdleCornerRadius = 20
        Me.b_Start_JA.IdleFillColor = System.Drawing.Color.White
        Me.b_Start_JA.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.b_Start_JA.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.b_Start_JA.Location = New System.Drawing.Point(174, 372)
        Me.b_Start_JA.Margin = New System.Windows.Forms.Padding(5)
        Me.b_Start_JA.Name = "b_Start_JA"
        Me.b_Start_JA.Size = New System.Drawing.Size(263, 72)
        Me.b_Start_JA.TabIndex = 1
        Me.b_Start_JA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(167, 66)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(727, 195)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Willkommen bei der Installation deiner neuen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Smart Bud Box" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Möchtest Du mit" & _
    " der Installation fortfahren?"
        '
        'tabServer1
        '
        Me.tabServer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.tabServer1.Controls.Add(Me.b_tabServer1_Zurück)
        Me.tabServer1.Controls.Add(Me.b_tabServer1_WeiterZuFtpVerzeichnis)
        Me.tabServer1.Controls.Add(Me.pic_tabServer1_FTPStatus)
        Me.tabServer1.Controls.Add(Me.lbl_tabServer1_FTPStatus)
        Me.tabServer1.Controls.Add(Me.BunifuCustomLabel7)
        Me.tabServer1.Controls.Add(Me.BunifuCustomLabel6)
        Me.tabServer1.Controls.Add(Me.BunifuCustomLabel5)
        Me.tabServer1.Controls.Add(Me.BunifuCustomLabel4)
        Me.tabServer1.Controls.Add(Me.BunifuSeparator1)
        Me.tabServer1.Controls.Add(Me.BunifuCustomLabel3)
        Me.tabServer1.Controls.Add(Me.txt_tabServer1_SeverAddress)
        Me.tabServer1.Controls.Add(Me.txt_tabServer1_Port)
        Me.tabServer1.Controls.Add(Me.b_tabServer1_PrüfeFTP)
        Me.tabServer1.Controls.Add(Me.txt_tabServer1_FTPPassword)
        Me.tabServer1.Controls.Add(Me.txt_tabServer1_Username)
        Me.tabServer1.Location = New System.Drawing.Point(4, 10)
        Me.tabServer1.Name = "tabServer1"
        Me.tabServer1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabServer1.Size = New System.Drawing.Size(1034, 628)
        Me.tabServer1.TabIndex = 1
        '
        'b_tabServer1_Zurück
        '
        Me.b_tabServer1_Zurück.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabServer1_Zurück.Image = Global.SBB_Tool.My.Resources.Resources.PfeilLinks
        Me.b_tabServer1_Zurück.ImageActive = Nothing
        Me.b_tabServer1_Zurück.Location = New System.Drawing.Point(30, 480)
        Me.b_tabServer1_Zurück.Name = "b_tabServer1_Zurück"
        Me.b_tabServer1_Zurück.Size = New System.Drawing.Size(46, 40)
        Me.b_tabServer1_Zurück.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.b_tabServer1_Zurück.TabIndex = 14
        Me.b_tabServer1_Zurück.TabStop = False
        Me.ToolTip1.SetToolTip(Me.b_tabServer1_Zurück, "Pfad Zurück")
        Me.b_tabServer1_Zurück.Zoom = 10
        '
        'b_tabServer1_WeiterZuFtpVerzeichnis
        '
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.ActiveBorderThickness = 1
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.ActiveCornerRadius = 20
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.ActiveFillColor = System.Drawing.Color.DarkGreen
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.BackgroundImage = CType(resources.GetObject("b_tabServer1_WeiterZuFtpVerzeichnis.BackgroundImage"), System.Drawing.Image)
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.ButtonText = "Weiter zu FTP Ordner"
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.ForeColor = System.Drawing.Color.SeaGreen
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.IdleBorderThickness = 1
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.IdleCornerRadius = 20
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.IdleFillColor = System.Drawing.Color.Black
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.Location = New System.Drawing.Point(582, 478)
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.Name = "b_tabServer1_WeiterZuFtpVerzeichnis"
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.Size = New System.Drawing.Size(240, 42)
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.TabIndex = 5
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.b_tabServer1_WeiterZuFtpVerzeichnis.Visible = False
        '
        'pic_tabServer1_FTPStatus
        '
        Me.pic_tabServer1_FTPStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pic_tabServer1_FTPStatus.Location = New System.Drawing.Point(691, 360)
        Me.pic_tabServer1_FTPStatus.Name = "pic_tabServer1_FTPStatus"
        Me.pic_tabServer1_FTPStatus.Size = New System.Drawing.Size(131, 109)
        Me.pic_tabServer1_FTPStatus.TabIndex = 13
        Me.pic_tabServer1_FTPStatus.TabStop = False
        '
        'lbl_tabServer1_FTPStatus
        '
        Me.lbl_tabServer1_FTPStatus.AutoSize = True
        Me.lbl_tabServer1_FTPStatus.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tabServer1_FTPStatus.ForeColor = System.Drawing.Color.White
        Me.lbl_tabServer1_FTPStatus.Location = New System.Drawing.Point(237, 410)
        Me.lbl_tabServer1_FTPStatus.Name = "lbl_tabServer1_FTPStatus"
        Me.lbl_tabServer1_FTPStatus.Size = New System.Drawing.Size(203, 39)
        Me.lbl_tabServer1_FTPStatus.TabIndex = 12
        Me.lbl_tabServer1_FTPStatus.Text = "FTP STATUS..."
        Me.lbl_tabServer1_FTPStatus.Visible = False
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(26, 264)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(163, 24)
        Me.BunifuCustomLabel7.TabIndex = 10
        Me.BunifuCustomLabel7.Text = "Server Adresse:"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(664, 224)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(85, 24)
        Me.BunifuCustomLabel6.TabIndex = 8
        Me.BunifuCustomLabel6.Text = "FTP Port"
        Me.BunifuCustomLabel6.Visible = False
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(26, 191)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(102, 24)
        Me.BunifuCustomLabel5.TabIndex = 4
        Me.BunifuCustomLabel5.Text = "Passwort:"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(26, 115)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(210, 24)
        Me.BunifuCustomLabel4.TabIndex = 3
        Me.BunifuCustomLabel4.Text = "FTP Benutzer Name:"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 65535
        Me.BunifuSeparator1.Location = New System.Drawing.Point(31, 89)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(800, 2)
        Me.BunifuSeparator1.TabIndex = 2
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(23, 44)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(359, 39)
        Me.BunifuCustomLabel3.TabIndex = 1
        Me.BunifuCustomLabel3.Text = "Web Server FTP Daten"
        '
        'txt_tabServer1_SeverAddress
        '
        Me.txt_tabServer1_SeverAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_tabServer1_SeverAddress.BackgroundImage = CType(resources.GetObject("txt_tabServer1_SeverAddress.BackgroundImage"), System.Drawing.Image)
        Me.txt_tabServer1_SeverAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_tabServer1_SeverAddress.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabServer1_SeverAddress.ForeColor = System.Drawing.Color.SeaGreen
        Me.txt_tabServer1_SeverAddress.Icon = CType(resources.GetObject("txt_tabServer1_SeverAddress.Icon"), System.Drawing.Image)
        Me.txt_tabServer1_SeverAddress.Location = New System.Drawing.Point(244, 253)
        Me.txt_tabServer1_SeverAddress.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_tabServer1_SeverAddress.Name = "txt_tabServer1_SeverAddress"
        Me.txt_tabServer1_SeverAddress.Size = New System.Drawing.Size(414, 47)
        Me.txt_tabServer1_SeverAddress.TabIndex = 3
        Me.txt_tabServer1_SeverAddress.text = ""
        '
        'txt_tabServer1_Port
        '
        Me.txt_tabServer1_Port.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_tabServer1_Port.BackgroundImage = CType(resources.GetObject("txt_tabServer1_Port.BackgroundImage"), System.Drawing.Image)
        Me.txt_tabServer1_Port.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_tabServer1_Port.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabServer1_Port.ForeColor = System.Drawing.Color.SeaGreen
        Me.txt_tabServer1_Port.Icon = CType(resources.GetObject("txt_tabServer1_Port.Icon"), System.Drawing.Image)
        Me.txt_tabServer1_Port.Location = New System.Drawing.Point(668, 253)
        Me.txt_tabServer1_Port.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_tabServer1_Port.Name = "txt_tabServer1_Port"
        Me.txt_tabServer1_Port.Size = New System.Drawing.Size(154, 47)
        Me.txt_tabServer1_Port.TabIndex = 9
        Me.txt_tabServer1_Port.text = "21"
        Me.txt_tabServer1_Port.Visible = False
        '
        'b_tabServer1_PrüfeFTP
        '
        Me.b_tabServer1_PrüfeFTP.ActiveBorderThickness = 1
        Me.b_tabServer1_PrüfeFTP.ActiveCornerRadius = 20
        Me.b_tabServer1_PrüfeFTP.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.b_tabServer1_PrüfeFTP.ActiveForecolor = System.Drawing.Color.White
        Me.b_tabServer1_PrüfeFTP.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b_tabServer1_PrüfeFTP.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabServer1_PrüfeFTP.BackgroundImage = CType(resources.GetObject("b_tabServer1_PrüfeFTP.BackgroundImage"), System.Drawing.Image)
        Me.b_tabServer1_PrüfeFTP.ButtonText = "Prüfe FTP Verbindung"
        Me.b_tabServer1_PrüfeFTP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_tabServer1_PrüfeFTP.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_tabServer1_PrüfeFTP.ForeColor = System.Drawing.Color.SeaGreen
        Me.b_tabServer1_PrüfeFTP.IdleBorderThickness = 1
        Me.b_tabServer1_PrüfeFTP.IdleCornerRadius = 20
        Me.b_tabServer1_PrüfeFTP.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabServer1_PrüfeFTP.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.b_tabServer1_PrüfeFTP.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.b_tabServer1_PrüfeFTP.Location = New System.Drawing.Point(244, 310)
        Me.b_tabServer1_PrüfeFTP.Margin = New System.Windows.Forms.Padding(5)
        Me.b_tabServer1_PrüfeFTP.Name = "b_tabServer1_PrüfeFTP"
        Me.b_tabServer1_PrüfeFTP.Size = New System.Drawing.Size(578, 42)
        Me.b_tabServer1_PrüfeFTP.TabIndex = 4
        Me.b_tabServer1_PrüfeFTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_tabServer1_FTPPassword
        '
        Me.txt_tabServer1_FTPPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_tabServer1_FTPPassword.BackgroundImage = CType(resources.GetObject("txt_tabServer1_FTPPassword.BackgroundImage"), System.Drawing.Image)
        Me.txt_tabServer1_FTPPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_tabServer1_FTPPassword.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabServer1_FTPPassword.ForeColor = System.Drawing.Color.SeaGreen
        Me.txt_tabServer1_FTPPassword.Icon = CType(resources.GetObject("txt_tabServer1_FTPPassword.Icon"), System.Drawing.Image)
        Me.txt_tabServer1_FTPPassword.Location = New System.Drawing.Point(244, 180)
        Me.txt_tabServer1_FTPPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_tabServer1_FTPPassword.Name = "txt_tabServer1_FTPPassword"
        Me.txt_tabServer1_FTPPassword.Size = New System.Drawing.Size(302, 47)
        Me.txt_tabServer1_FTPPassword.TabIndex = 2
        Me.txt_tabServer1_FTPPassword.text = ""
        '
        'txt_tabServer1_Username
        '
        Me.txt_tabServer1_Username.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_tabServer1_Username.BackgroundImage = CType(resources.GetObject("txt_tabServer1_Username.BackgroundImage"), System.Drawing.Image)
        Me.txt_tabServer1_Username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_tabServer1_Username.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabServer1_Username.ForeColor = System.Drawing.Color.SeaGreen
        Me.txt_tabServer1_Username.Icon = CType(resources.GetObject("txt_tabServer1_Username.Icon"), System.Drawing.Image)
        Me.txt_tabServer1_Username.Location = New System.Drawing.Point(244, 104)
        Me.txt_tabServer1_Username.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_tabServer1_Username.Name = "txt_tabServer1_Username"
        Me.txt_tabServer1_Username.Size = New System.Drawing.Size(302, 47)
        Me.txt_tabServer1_Username.TabIndex = 1
        Me.txt_tabServer1_Username.text = ""
        '
        'tabServer2
        '
        Me.tabServer2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.tabServer2.Controls.Add(Me.p_tabServer2_UploadVerzeichnis)
        Me.tabServer2.Controls.Add(Me.lbl_tabServer2_Pfad)
        Me.tabServer2.Controls.Add(Me.BunifuCustomLabel8)
        Me.tabServer2.Controls.Add(Me.b_tabServer2_HomeButton)
        Me.tabServer2.Controls.Add(Me.b_tabServer2_OrdnerLöschen)
        Me.tabServer2.Controls.Add(Me.b_tabServer2_OrdnerHinzufügen)
        Me.tabServer2.Controls.Add(Me.b_tabServer2_UploadPfadÜbernehmen)
        Me.tabServer2.Controls.Add(Me.BunifuImageButton1)
        Me.tabServer2.Controls.Add(Me.lb_tabServer2_FTPVerzeichnis)
        Me.tabServer2.Location = New System.Drawing.Point(4, 10)
        Me.tabServer2.Name = "tabServer2"
        Me.tabServer2.Size = New System.Drawing.Size(1034, 628)
        Me.tabServer2.TabIndex = 2
        '
        'p_tabServer2_UploadVerzeichnis
        '
        Me.p_tabServer2_UploadVerzeichnis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p_tabServer2_UploadVerzeichnis.Controls.Add(Me.b_tabServer2_WeiterZuMySQL)
        Me.p_tabServer2_UploadVerzeichnis.Controls.Add(Me.lbl_AusgewähltesUploadVerzeichnis)
        Me.p_tabServer2_UploadVerzeichnis.Controls.Add(Me.BunifuCustomLabel9)
        Me.p_tabServer2_UploadVerzeichnis.Location = New System.Drawing.Point(428, 358)
        Me.p_tabServer2_UploadVerzeichnis.Name = "p_tabServer2_UploadVerzeichnis"
        Me.p_tabServer2_UploadVerzeichnis.Size = New System.Drawing.Size(424, 166)
        Me.p_tabServer2_UploadVerzeichnis.TabIndex = 12
        Me.p_tabServer2_UploadVerzeichnis.Visible = False
        '
        'b_tabServer2_WeiterZuMySQL
        '
        Me.b_tabServer2_WeiterZuMySQL.ActiveBorderThickness = 1
        Me.b_tabServer2_WeiterZuMySQL.ActiveCornerRadius = 20
        Me.b_tabServer2_WeiterZuMySQL.ActiveFillColor = System.Drawing.Color.DarkGreen
        Me.b_tabServer2_WeiterZuMySQL.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_tabServer2_WeiterZuMySQL.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b_tabServer2_WeiterZuMySQL.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabServer2_WeiterZuMySQL.BackgroundImage = CType(resources.GetObject("b_tabServer2_WeiterZuMySQL.BackgroundImage"), System.Drawing.Image)
        Me.b_tabServer2_WeiterZuMySQL.ButtonText = "Weiter zu MySQL DB"
        Me.b_tabServer2_WeiterZuMySQL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_tabServer2_WeiterZuMySQL.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_tabServer2_WeiterZuMySQL.ForeColor = System.Drawing.Color.SeaGreen
        Me.b_tabServer2_WeiterZuMySQL.IdleBorderThickness = 1
        Me.b_tabServer2_WeiterZuMySQL.IdleCornerRadius = 20
        Me.b_tabServer2_WeiterZuMySQL.IdleFillColor = System.Drawing.Color.Black
        Me.b_tabServer2_WeiterZuMySQL.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.b_tabServer2_WeiterZuMySQL.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.b_tabServer2_WeiterZuMySQL.Location = New System.Drawing.Point(95, 110)
        Me.b_tabServer2_WeiterZuMySQL.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.b_tabServer2_WeiterZuMySQL.Name = "b_tabServer2_WeiterZuMySQL"
        Me.b_tabServer2_WeiterZuMySQL.Size = New System.Drawing.Size(240, 42)
        Me.b_tabServer2_WeiterZuMySQL.TabIndex = 14
        Me.b_tabServer2_WeiterZuMySQL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_AusgewähltesUploadVerzeichnis
        '
        Me.lbl_AusgewähltesUploadVerzeichnis.AutoSize = True
        Me.lbl_AusgewähltesUploadVerzeichnis.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AusgewähltesUploadVerzeichnis.ForeColor = System.Drawing.Color.White
        Me.lbl_AusgewähltesUploadVerzeichnis.Location = New System.Drawing.Point(34, 71)
        Me.lbl_AusgewähltesUploadVerzeichnis.Name = "lbl_AusgewähltesUploadVerzeichnis"
        Me.lbl_AusgewähltesUploadVerzeichnis.Size = New System.Drawing.Size(226, 17)
        Me.lbl_AusgewähltesUploadVerzeichnis.TabIndex = 13
        Me.lbl_AusgewähltesUploadVerzeichnis.Text = "Ausgewähltes Upload Verzeichnis:"
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(34, 30)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(356, 24)
        Me.BunifuCustomLabel9.TabIndex = 12
        Me.BunifuCustomLabel9.Text = "Ausgewähltes Upload Verzeichnis:"
        '
        'lbl_tabServer2_Pfad
        '
        Me.lbl_tabServer2_Pfad.AutoSize = True
        Me.lbl_tabServer2_Pfad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tabServer2_Pfad.ForeColor = System.Drawing.Color.White
        Me.lbl_tabServer2_Pfad.Location = New System.Drawing.Point(21, 527)
        Me.lbl_tabServer2_Pfad.Name = "lbl_tabServer2_Pfad"
        Me.lbl_tabServer2_Pfad.Size = New System.Drawing.Size(97, 16)
        Me.lbl_tabServer2_Pfad.TabIndex = 6
        Me.lbl_tabServer2_Pfad.Text = "Aktueller Pfad"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(20, 8)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(321, 24)
        Me.BunifuCustomLabel8.TabIndex = 4
        Me.BunifuCustomLabel8.Text = "Upload Verzeichnis Auswählen"
        '
        'b_tabServer2_HomeButton
        '
        Me.b_tabServer2_HomeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabServer2_HomeButton.Image = Global.SBB_Tool.My.Resources.Resources.HomeButton
        Me.b_tabServer2_HomeButton.ImageActive = Nothing
        Me.b_tabServer2_HomeButton.Location = New System.Drawing.Point(428, 37)
        Me.b_tabServer2_HomeButton.Name = "b_tabServer2_HomeButton"
        Me.b_tabServer2_HomeButton.Size = New System.Drawing.Size(46, 40)
        Me.b_tabServer2_HomeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.b_tabServer2_HomeButton.TabIndex = 9
        Me.b_tabServer2_HomeButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.b_tabServer2_HomeButton, "Pfad Zurück")
        Me.b_tabServer2_HomeButton.Zoom = 10
        '
        'b_tabServer2_OrdnerLöschen
        '
        Me.b_tabServer2_OrdnerLöschen.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabServer2_OrdnerLöschen.Image = Global.SBB_Tool.My.Resources.Resources.FolderDEL
        Me.b_tabServer2_OrdnerLöschen.ImageActive = Nothing
        Me.b_tabServer2_OrdnerLöschen.Location = New System.Drawing.Point(428, 227)
        Me.b_tabServer2_OrdnerLöschen.Name = "b_tabServer2_OrdnerLöschen"
        Me.b_tabServer2_OrdnerLöschen.Size = New System.Drawing.Size(46, 40)
        Me.b_tabServer2_OrdnerLöschen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.b_tabServer2_OrdnerLöschen.TabIndex = 8
        Me.b_tabServer2_OrdnerLöschen.TabStop = False
        Me.ToolTip1.SetToolTip(Me.b_tabServer2_OrdnerLöschen, "Pfad Zurück")
        Me.b_tabServer2_OrdnerLöschen.Visible = False
        Me.b_tabServer2_OrdnerLöschen.Zoom = 10
        '
        'b_tabServer2_OrdnerHinzufügen
        '
        Me.b_tabServer2_OrdnerHinzufügen.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabServer2_OrdnerHinzufügen.Image = Global.SBB_Tool.My.Resources.Resources.FolderADD
        Me.b_tabServer2_OrdnerHinzufügen.ImageActive = Nothing
        Me.b_tabServer2_OrdnerHinzufügen.Location = New System.Drawing.Point(428, 162)
        Me.b_tabServer2_OrdnerHinzufügen.Name = "b_tabServer2_OrdnerHinzufügen"
        Me.b_tabServer2_OrdnerHinzufügen.Size = New System.Drawing.Size(46, 40)
        Me.b_tabServer2_OrdnerHinzufügen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.b_tabServer2_OrdnerHinzufügen.TabIndex = 7
        Me.b_tabServer2_OrdnerHinzufügen.TabStop = False
        Me.ToolTip1.SetToolTip(Me.b_tabServer2_OrdnerHinzufügen, "Pfad Zurück")
        Me.b_tabServer2_OrdnerHinzufügen.Zoom = 10
        '
        'b_tabServer2_UploadPfadÜbernehmen
        '
        Me.b_tabServer2_UploadPfadÜbernehmen.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabServer2_UploadPfadÜbernehmen.Image = Global.SBB_Tool.My.Resources.Resources.Check
        Me.b_tabServer2_UploadPfadÜbernehmen.ImageActive = Nothing
        Me.b_tabServer2_UploadPfadÜbernehmen.Location = New System.Drawing.Point(428, 289)
        Me.b_tabServer2_UploadPfadÜbernehmen.Name = "b_tabServer2_UploadPfadÜbernehmen"
        Me.b_tabServer2_UploadPfadÜbernehmen.Size = New System.Drawing.Size(46, 40)
        Me.b_tabServer2_UploadPfadÜbernehmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.b_tabServer2_UploadPfadÜbernehmen.TabIndex = 2
        Me.b_tabServer2_UploadPfadÜbernehmen.TabStop = False
        Me.ToolTip1.SetToolTip(Me.b_tabServer2_UploadPfadÜbernehmen, "Pfad Zurück")
        Me.b_tabServer2_UploadPfadÜbernehmen.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuImageButton1.Image = Global.SBB_Tool.My.Resources.Resources.PfeilLinks
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(428, 102)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(46, 40)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 1
        Me.BunifuImageButton1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton1, "Pfad Zurück")
        Me.BunifuImageButton1.Zoom = 10
        '
        'lb_tabServer2_FTPVerzeichnis
        '
        Me.lb_tabServer2_FTPVerzeichnis.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lb_tabServer2_FTPVerzeichnis.ForeColor = System.Drawing.Color.White
        Me.lb_tabServer2_FTPVerzeichnis.FormattingEnabled = True
        Me.lb_tabServer2_FTPVerzeichnis.ItemHeight = 21
        Me.lb_tabServer2_FTPVerzeichnis.Location = New System.Drawing.Point(24, 37)
        Me.lb_tabServer2_FTPVerzeichnis.Name = "lb_tabServer2_FTPVerzeichnis"
        Me.lb_tabServer2_FTPVerzeichnis.Size = New System.Drawing.Size(387, 487)
        Me.lb_tabServer2_FTPVerzeichnis.TabIndex = 0
        '
        'tabMySQL1
        '
        Me.tabMySQL1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.tabMySQL1.Controls.Add(Me.BunifuCustomLabel42)
        Me.tabMySQL1.Controls.Add(Me.BunifuCustomLabel41)
        Me.tabMySQL1.Controls.Add(Me.cb_tabMySQL1_KeineMySQL_User_Prüfung)
        Me.tabMySQL1.Controls.Add(Me.b_tabMySQL1_Zurück)
        Me.tabMySQL1.Controls.Add(Me.b_tabMySQL_WeiterZuWLAN)
        Me.tabMySQL1.Controls.Add(Me.PictureBox2)
        Me.tabMySQL1.Controls.Add(Me.lbl_tabMySQL1_MySQLStatus)
        Me.tabMySQL1.Controls.Add(Me.BunifuCustomLabel15)
        Me.tabMySQL1.Controls.Add(Me.BunifuCustomLabel11)
        Me.tabMySQL1.Controls.Add(Me.BunifuCustomLabel12)
        Me.tabMySQL1.Controls.Add(Me.BunifuCustomLabel13)
        Me.tabMySQL1.Controls.Add(Me.BunifuCustomLabel14)
        Me.tabMySQL1.Controls.Add(Me.BunifuSeparator2)
        Me.tabMySQL1.Controls.Add(Me.BunifuCustomLabel10)
        Me.tabMySQL1.Controls.Add(Me.txt_tabMySQL1_Database)
        Me.tabMySQL1.Controls.Add(Me.txt_tabMySQL1_ServerAdresse)
        Me.tabMySQL1.Controls.Add(Me.txt_tabMySQL1_Port)
        Me.tabMySQL1.Controls.Add(Me.b_tabMySQL1_PrüfeMySQLConnection)
        Me.tabMySQL1.Controls.Add(Me.txt_tabMySQL1_Password)
        Me.tabMySQL1.Controls.Add(Me.txt_tabMySQL1_User)
        Me.tabMySQL1.Location = New System.Drawing.Point(4, 10)
        Me.tabMySQL1.Name = "tabMySQL1"
        Me.tabMySQL1.Size = New System.Drawing.Size(1034, 628)
        Me.tabMySQL1.TabIndex = 3
        '
        'BunifuCustomLabel42
        '
        Me.BunifuCustomLabel42.AutoSize = True
        Me.BunifuCustomLabel42.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel42.ForeColor = System.Drawing.Color.Red
        Me.BunifuCustomLabel42.Location = New System.Drawing.Point(247, 461)
        Me.BunifuCustomLabel42.Name = "BunifuCustomLabel42"
        Me.BunifuCustomLabel42.Size = New System.Drawing.Size(186, 17)
        Me.BunifuCustomLabel42.TabIndex = 29
        Me.BunifuCustomLabel42.Text = "MySQL erlaubt keine Zugriffe"
        '
        'BunifuCustomLabel41
        '
        Me.BunifuCustomLabel41.AutoSize = True
        Me.BunifuCustomLabel41.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel41.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel41.Location = New System.Drawing.Point(279, 432)
        Me.BunifuCustomLabel41.Name = "BunifuCustomLabel41"
        Me.BunifuCustomLabel41.Size = New System.Drawing.Size(199, 24)
        Me.BunifuCustomLabel41.TabIndex = 28
        Me.BunifuCustomLabel41.Text = "Keine Überprüfung"
        '
        'cb_tabMySQL1_KeineMySQL_User_Prüfung
        '
        Me.cb_tabMySQL1_KeineMySQL_User_Prüfung.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cb_tabMySQL1_KeineMySQL_User_Prüfung.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cb_tabMySQL1_KeineMySQL_User_Prüfung.Checked = False
        Me.cb_tabMySQL1_KeineMySQL_User_Prüfung.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cb_tabMySQL1_KeineMySQL_User_Prüfung.ForeColor = System.Drawing.Color.White
        Me.cb_tabMySQL1_KeineMySQL_User_Prüfung.Location = New System.Drawing.Point(251, 436)
        Me.cb_tabMySQL1_KeineMySQL_User_Prüfung.Margin = New System.Windows.Forms.Padding(5)
        Me.cb_tabMySQL1_KeineMySQL_User_Prüfung.Name = "cb_tabMySQL1_KeineMySQL_User_Prüfung"
        Me.cb_tabMySQL1_KeineMySQL_User_Prüfung.Size = New System.Drawing.Size(20, 20)
        Me.cb_tabMySQL1_KeineMySQL_User_Prüfung.TabIndex = 27
        '
        'b_tabMySQL1_Zurück
        '
        Me.b_tabMySQL1_Zurück.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabMySQL1_Zurück.Image = Global.SBB_Tool.My.Resources.Resources.PfeilLinks
        Me.b_tabMySQL1_Zurück.ImageActive = Nothing
        Me.b_tabMySQL1_Zurück.Location = New System.Drawing.Point(31, 432)
        Me.b_tabMySQL1_Zurück.Name = "b_tabMySQL1_Zurück"
        Me.b_tabMySQL1_Zurück.Size = New System.Drawing.Size(46, 40)
        Me.b_tabMySQL1_Zurück.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.b_tabMySQL1_Zurück.TabIndex = 26
        Me.b_tabMySQL1_Zurück.TabStop = False
        Me.ToolTip1.SetToolTip(Me.b_tabMySQL1_Zurück, "Pfad Zurück")
        Me.b_tabMySQL1_Zurück.Zoom = 10
        '
        'b_tabMySQL_WeiterZuWLAN
        '
        Me.b_tabMySQL_WeiterZuWLAN.ActiveBorderThickness = 1
        Me.b_tabMySQL_WeiterZuWLAN.ActiveCornerRadius = 20
        Me.b_tabMySQL_WeiterZuWLAN.ActiveFillColor = System.Drawing.Color.DarkGreen
        Me.b_tabMySQL_WeiterZuWLAN.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_tabMySQL_WeiterZuWLAN.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b_tabMySQL_WeiterZuWLAN.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabMySQL_WeiterZuWLAN.BackgroundImage = CType(resources.GetObject("b_tabMySQL_WeiterZuWLAN.BackgroundImage"), System.Drawing.Image)
        Me.b_tabMySQL_WeiterZuWLAN.ButtonText = "Weiter zu WLAN"
        Me.b_tabMySQL_WeiterZuWLAN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_tabMySQL_WeiterZuWLAN.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_tabMySQL_WeiterZuWLAN.ForeColor = System.Drawing.Color.SeaGreen
        Me.b_tabMySQL_WeiterZuWLAN.IdleBorderThickness = 1
        Me.b_tabMySQL_WeiterZuWLAN.IdleCornerRadius = 20
        Me.b_tabMySQL_WeiterZuWLAN.IdleFillColor = System.Drawing.Color.Black
        Me.b_tabMySQL_WeiterZuWLAN.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.b_tabMySQL_WeiterZuWLAN.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.b_tabMySQL_WeiterZuWLAN.Location = New System.Drawing.Point(580, 430)
        Me.b_tabMySQL_WeiterZuWLAN.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.b_tabMySQL_WeiterZuWLAN.Name = "b_tabMySQL_WeiterZuWLAN"
        Me.b_tabMySQL_WeiterZuWLAN.Size = New System.Drawing.Size(240, 42)
        Me.b_tabMySQL_WeiterZuWLAN.TabIndex = 25
        Me.b_tabMySQL_WeiterZuWLAN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.b_tabMySQL_WeiterZuWLAN.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Location = New System.Drawing.Point(689, 115)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(131, 109)
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'lbl_tabMySQL1_MySQLStatus
        '
        Me.lbl_tabMySQL1_MySQLStatus.AutoSize = True
        Me.lbl_tabMySQL1_MySQLStatus.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tabMySQL1_MySQLStatus.ForeColor = System.Drawing.Color.White
        Me.lbl_tabMySQL1_MySQLStatus.Location = New System.Drawing.Point(235, 480)
        Me.lbl_tabMySQL1_MySQLStatus.Name = "lbl_tabMySQL1_MySQLStatus"
        Me.lbl_tabMySQL1_MySQLStatus.Size = New System.Drawing.Size(261, 39)
        Me.lbl_tabMySQL1_MySQLStatus.TabIndex = 22
        Me.lbl_tabMySQL1_MySQLStatus.Text = "mySQL STATUS..."
        Me.lbl_tabMySQL1_MySQLStatus.Visible = False
        '
        'BunifuCustomLabel15
        '
        Me.BunifuCustomLabel15.AutoSize = True
        Me.BunifuCustomLabel15.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel15.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel15.Location = New System.Drawing.Point(27, 257)
        Me.BunifuCustomLabel15.Name = "BunifuCustomLabel15"
        Me.BunifuCustomLabel15.Size = New System.Drawing.Size(202, 24)
        Me.BunifuCustomLabel15.TabIndex = 21
        Me.BunifuCustomLabel15.Text = "Datenbank Name:"
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(27, 323)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(163, 24)
        Me.BunifuCustomLabel11.TabIndex = 19
        Me.BunifuCustomLabel11.Text = "Server Adresse:"
        '
        'BunifuCustomLabel12
        '
        Me.BunifuCustomLabel12.AutoSize = True
        Me.BunifuCustomLabel12.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel12.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel12.Location = New System.Drawing.Point(662, 282)
        Me.BunifuCustomLabel12.Name = "BunifuCustomLabel12"
        Me.BunifuCustomLabel12.Size = New System.Drawing.Size(49, 24)
        Me.BunifuCustomLabel12.TabIndex = 17
        Me.BunifuCustomLabel12.Text = "Port"
        '
        'BunifuCustomLabel13
        '
        Me.BunifuCustomLabel13.AutoSize = True
        Me.BunifuCustomLabel13.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel13.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel13.Location = New System.Drawing.Point(27, 191)
        Me.BunifuCustomLabel13.Name = "BunifuCustomLabel13"
        Me.BunifuCustomLabel13.Size = New System.Drawing.Size(102, 24)
        Me.BunifuCustomLabel13.TabIndex = 15
        Me.BunifuCustomLabel13.Text = "Passwort:"
        '
        'BunifuCustomLabel14
        '
        Me.BunifuCustomLabel14.AutoSize = True
        Me.BunifuCustomLabel14.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel14.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel14.Location = New System.Drawing.Point(27, 126)
        Me.BunifuCustomLabel14.Name = "BunifuCustomLabel14"
        Me.BunifuCustomLabel14.Size = New System.Drawing.Size(179, 24)
        Me.BunifuCustomLabel14.TabIndex = 13
        Me.BunifuCustomLabel14.Text = "mySQL Benutzer:"
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 65535
        Me.BunifuSeparator2.Location = New System.Drawing.Point(31, 89)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(8)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(800, 2)
        Me.BunifuSeparator2.TabIndex = 4
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(23, 44)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(308, 39)
        Me.BunifuCustomLabel10.TabIndex = 3
        Me.BunifuCustomLabel10.Text = "MySQL Datenbank"
        '
        'txt_tabMySQL1_Database
        '
        Me.txt_tabMySQL1_Database.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_tabMySQL1_Database.BackgroundImage = CType(resources.GetObject("txt_tabMySQL1_Database.BackgroundImage"), System.Drawing.Image)
        Me.txt_tabMySQL1_Database.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_tabMySQL1_Database.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabMySQL1_Database.ForeColor = System.Drawing.Color.SeaGreen
        Me.txt_tabMySQL1_Database.Icon = CType(resources.GetObject("txt_tabMySQL1_Database.Icon"), System.Drawing.Image)
        Me.txt_tabMySQL1_Database.Location = New System.Drawing.Point(242, 245)
        Me.txt_tabMySQL1_Database.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_tabMySQL1_Database.Name = "txt_tabMySQL1_Database"
        Me.txt_tabMySQL1_Database.Size = New System.Drawing.Size(305, 47)
        Me.txt_tabMySQL1_Database.TabIndex = 3
        Me.txt_tabMySQL1_Database.text = ""
        '
        'txt_tabMySQL1_ServerAdresse
        '
        Me.txt_tabMySQL1_ServerAdresse.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_tabMySQL1_ServerAdresse.BackgroundImage = CType(resources.GetObject("txt_tabMySQL1_ServerAdresse.BackgroundImage"), System.Drawing.Image)
        Me.txt_tabMySQL1_ServerAdresse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_tabMySQL1_ServerAdresse.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabMySQL1_ServerAdresse.ForeColor = System.Drawing.Color.SeaGreen
        Me.txt_tabMySQL1_ServerAdresse.Icon = CType(resources.GetObject("txt_tabMySQL1_ServerAdresse.Icon"), System.Drawing.Image)
        Me.txt_tabMySQL1_ServerAdresse.Location = New System.Drawing.Point(242, 311)
        Me.txt_tabMySQL1_ServerAdresse.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_tabMySQL1_ServerAdresse.Name = "txt_tabMySQL1_ServerAdresse"
        Me.txt_tabMySQL1_ServerAdresse.Size = New System.Drawing.Size(414, 47)
        Me.txt_tabMySQL1_ServerAdresse.TabIndex = 4
        Me.txt_tabMySQL1_ServerAdresse.text = ""
        '
        'txt_tabMySQL1_Port
        '
        Me.txt_tabMySQL1_Port.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_tabMySQL1_Port.BackgroundImage = CType(resources.GetObject("txt_tabMySQL1_Port.BackgroundImage"), System.Drawing.Image)
        Me.txt_tabMySQL1_Port.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_tabMySQL1_Port.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabMySQL1_Port.ForeColor = System.Drawing.Color.SeaGreen
        Me.txt_tabMySQL1_Port.Icon = CType(resources.GetObject("txt_tabMySQL1_Port.Icon"), System.Drawing.Image)
        Me.txt_tabMySQL1_Port.Location = New System.Drawing.Point(666, 311)
        Me.txt_tabMySQL1_Port.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_tabMySQL1_Port.Name = "txt_tabMySQL1_Port"
        Me.txt_tabMySQL1_Port.Size = New System.Drawing.Size(154, 47)
        Me.txt_tabMySQL1_Port.TabIndex = 5
        Me.txt_tabMySQL1_Port.text = "3306"
        '
        'b_tabMySQL1_PrüfeMySQLConnection
        '
        Me.b_tabMySQL1_PrüfeMySQLConnection.ActiveBorderThickness = 1
        Me.b_tabMySQL1_PrüfeMySQLConnection.ActiveCornerRadius = 20
        Me.b_tabMySQL1_PrüfeMySQLConnection.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.b_tabMySQL1_PrüfeMySQLConnection.ActiveForecolor = System.Drawing.Color.White
        Me.b_tabMySQL1_PrüfeMySQLConnection.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b_tabMySQL1_PrüfeMySQLConnection.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabMySQL1_PrüfeMySQLConnection.BackgroundImage = CType(resources.GetObject("b_tabMySQL1_PrüfeMySQLConnection.BackgroundImage"), System.Drawing.Image)
        Me.b_tabMySQL1_PrüfeMySQLConnection.ButtonText = "Verbinde mit mySQL Datenbank"
        Me.b_tabMySQL1_PrüfeMySQLConnection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_tabMySQL1_PrüfeMySQLConnection.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_tabMySQL1_PrüfeMySQLConnection.ForeColor = System.Drawing.Color.SeaGreen
        Me.b_tabMySQL1_PrüfeMySQLConnection.IdleBorderThickness = 1
        Me.b_tabMySQL1_PrüfeMySQLConnection.IdleCornerRadius = 20
        Me.b_tabMySQL1_PrüfeMySQLConnection.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabMySQL1_PrüfeMySQLConnection.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.b_tabMySQL1_PrüfeMySQLConnection.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.b_tabMySQL1_PrüfeMySQLConnection.Location = New System.Drawing.Point(242, 380)
        Me.b_tabMySQL1_PrüfeMySQLConnection.Margin = New System.Windows.Forms.Padding(5)
        Me.b_tabMySQL1_PrüfeMySQLConnection.Name = "b_tabMySQL1_PrüfeMySQLConnection"
        Me.b_tabMySQL1_PrüfeMySQLConnection.Size = New System.Drawing.Size(578, 42)
        Me.b_tabMySQL1_PrüfeMySQLConnection.TabIndex = 6
        Me.b_tabMySQL1_PrüfeMySQLConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_tabMySQL1_Password
        '
        Me.txt_tabMySQL1_Password.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_tabMySQL1_Password.BackgroundImage = CType(resources.GetObject("txt_tabMySQL1_Password.BackgroundImage"), System.Drawing.Image)
        Me.txt_tabMySQL1_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_tabMySQL1_Password.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabMySQL1_Password.ForeColor = System.Drawing.Color.SeaGreen
        Me.txt_tabMySQL1_Password.Icon = CType(resources.GetObject("txt_tabMySQL1_Password.Icon"), System.Drawing.Image)
        Me.txt_tabMySQL1_Password.Location = New System.Drawing.Point(245, 180)
        Me.txt_tabMySQL1_Password.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_tabMySQL1_Password.Name = "txt_tabMySQL1_Password"
        Me.txt_tabMySQL1_Password.Size = New System.Drawing.Size(302, 47)
        Me.txt_tabMySQL1_Password.TabIndex = 2
        Me.txt_tabMySQL1_Password.text = ""
        '
        'txt_tabMySQL1_User
        '
        Me.txt_tabMySQL1_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_tabMySQL1_User.BackgroundImage = CType(resources.GetObject("txt_tabMySQL1_User.BackgroundImage"), System.Drawing.Image)
        Me.txt_tabMySQL1_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_tabMySQL1_User.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabMySQL1_User.ForeColor = System.Drawing.Color.SeaGreen
        Me.txt_tabMySQL1_User.Icon = CType(resources.GetObject("txt_tabMySQL1_User.Icon"), System.Drawing.Image)
        Me.txt_tabMySQL1_User.Location = New System.Drawing.Point(245, 115)
        Me.txt_tabMySQL1_User.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_tabMySQL1_User.Name = "txt_tabMySQL1_User"
        Me.txt_tabMySQL1_User.Size = New System.Drawing.Size(302, 47)
        Me.txt_tabMySQL1_User.TabIndex = 1
        Me.txt_tabMySQL1_User.text = ""
        '
        'tabWLAN1
        '
        Me.tabWLAN1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.tabWLAN1.Controls.Add(Me.b_tabWlan_Suche_Wlan)
        Me.tabWLAN1.Controls.Add(Me.b_tabWLAN_Zurück)
        Me.tabWLAN1.Controls.Add(Me.b_tabWLAN1_WeiterZuController)
        Me.tabWLAN1.Controls.Add(Me.BunifuCustomLabel19)
        Me.tabWLAN1.Controls.Add(Me.BunifuCustomLabel18)
        Me.tabWLAN1.Controls.Add(Me.Panel4)
        Me.tabWLAN1.Controls.Add(Me.lbl_tabWLAN1_WLANStatus)
        Me.tabWLAN1.Controls.Add(Me.BunifuSeparator3)
        Me.tabWLAN1.Controls.Add(Me.BunifuCustomLabel16)
        Me.tabWLAN1.Controls.Add(Me.txt_tabWLAN_WLANName)
        Me.tabWLAN1.Location = New System.Drawing.Point(4, 10)
        Me.tabWLAN1.Name = "tabWLAN1"
        Me.tabWLAN1.Size = New System.Drawing.Size(1034, 628)
        Me.tabWLAN1.TabIndex = 4
        '
        'b_tabWlan_Suche_Wlan
        '
        Me.b_tabWlan_Suche_Wlan.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabWlan_Suche_Wlan.Image = Global.SBB_Tool.My.Resources.Resources.Search
        Me.b_tabWlan_Suche_Wlan.ImageActive = Nothing
        Me.b_tabWlan_Suche_Wlan.Location = New System.Drawing.Point(658, 169)
        Me.b_tabWlan_Suche_Wlan.Name = "b_tabWlan_Suche_Wlan"
        Me.b_tabWlan_Suche_Wlan.Size = New System.Drawing.Size(46, 40)
        Me.b_tabWlan_Suche_Wlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.b_tabWlan_Suche_Wlan.TabIndex = 28
        Me.b_tabWlan_Suche_Wlan.TabStop = False
        Me.ToolTip1.SetToolTip(Me.b_tabWlan_Suche_Wlan, "Suche neue WLAN Einstellungen")
        Me.b_tabWlan_Suche_Wlan.Zoom = 10
        '
        'b_tabWLAN_Zurück
        '
        Me.b_tabWLAN_Zurück.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabWLAN_Zurück.Image = Global.SBB_Tool.My.Resources.Resources.PfeilLinks
        Me.b_tabWLAN_Zurück.ImageActive = Nothing
        Me.b_tabWLAN_Zurück.Location = New System.Drawing.Point(30, 362)
        Me.b_tabWLAN_Zurück.Name = "b_tabWLAN_Zurück"
        Me.b_tabWLAN_Zurück.Size = New System.Drawing.Size(46, 40)
        Me.b_tabWLAN_Zurück.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.b_tabWLAN_Zurück.TabIndex = 27
        Me.b_tabWLAN_Zurück.TabStop = False
        Me.ToolTip1.SetToolTip(Me.b_tabWLAN_Zurück, "Pfad Zurück")
        Me.b_tabWLAN_Zurück.Zoom = 10
        '
        'b_tabWLAN1_WeiterZuController
        '
        Me.b_tabWLAN1_WeiterZuController.ActiveBorderThickness = 1
        Me.b_tabWLAN1_WeiterZuController.ActiveCornerRadius = 20
        Me.b_tabWLAN1_WeiterZuController.ActiveFillColor = System.Drawing.Color.DarkGreen
        Me.b_tabWLAN1_WeiterZuController.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_tabWLAN1_WeiterZuController.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b_tabWLAN1_WeiterZuController.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabWLAN1_WeiterZuController.BackgroundImage = CType(resources.GetObject("b_tabWLAN1_WeiterZuController.BackgroundImage"), System.Drawing.Image)
        Me.b_tabWLAN1_WeiterZuController.ButtonText = "Weiter zum Controller"
        Me.b_tabWLAN1_WeiterZuController.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_tabWLAN1_WeiterZuController.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_tabWLAN1_WeiterZuController.ForeColor = System.Drawing.Color.SeaGreen
        Me.b_tabWLAN1_WeiterZuController.IdleBorderThickness = 1
        Me.b_tabWLAN1_WeiterZuController.IdleCornerRadius = 20
        Me.b_tabWLAN1_WeiterZuController.IdleFillColor = System.Drawing.Color.Black
        Me.b_tabWLAN1_WeiterZuController.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.b_tabWLAN1_WeiterZuController.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.b_tabWLAN1_WeiterZuController.Location = New System.Drawing.Point(410, 360)
        Me.b_tabWLAN1_WeiterZuController.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.b_tabWLAN1_WeiterZuController.Name = "b_tabWLAN1_WeiterZuController"
        Me.b_tabWLAN1_WeiterZuController.Size = New System.Drawing.Size(240, 42)
        Me.b_tabWLAN1_WeiterZuController.TabIndex = 26
        Me.b_tabWLAN1_WeiterZuController.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel19
        '
        Me.BunifuCustomLabel19.AutoSize = True
        Me.BunifuCustomLabel19.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel19.ForeColor = System.Drawing.Color.Red
        Me.BunifuCustomLabel19.Location = New System.Drawing.Point(37, 314)
        Me.BunifuCustomLabel19.Name = "BunifuCustomLabel19"
        Me.BunifuCustomLabel19.Size = New System.Drawing.Size(471, 21)
        Me.BunifuCustomLabel19.TabIndex = 11
        Me.BunifuCustomLabel19.Text = "Eine überprüfung der WLAN Einstellungen findet nicht statt!"
        '
        'BunifuCustomLabel18
        '
        Me.BunifuCustomLabel18.AutoSize = True
        Me.BunifuCustomLabel18.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel18.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel18.Location = New System.Drawing.Point(38, 174)
        Me.BunifuCustomLabel18.Name = "BunifuCustomLabel18"
        Me.BunifuCustomLabel18.Size = New System.Drawing.Size(98, 21)
        Me.BunifuCustomLabel18.TabIndex = 10
        Me.BunifuCustomLabel18.Text = "WLAN SSID:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txt_tabWLAN_Key)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel17)
        Me.Panel4.Location = New System.Drawing.Point(36, 227)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(614, 65)
        Me.Panel4.TabIndex = 9
        '
        'txt_tabWLAN_Key
        '
        Me.txt_tabWLAN_Key.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_tabWLAN_Key.BackgroundImage = CType(resources.GetObject("txt_tabWLAN_Key.BackgroundImage"), System.Drawing.Image)
        Me.txt_tabWLAN_Key.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_tabWLAN_Key.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabWLAN_Key.ForeColor = System.Drawing.Color.SeaGreen
        Me.txt_tabWLAN_Key.Icon = CType(resources.GetObject("txt_tabWLAN_Key.Icon"), System.Drawing.Image)
        Me.txt_tabWLAN_Key.Location = New System.Drawing.Point(222, 5)
        Me.txt_tabWLAN_Key.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_tabWLAN_Key.Name = "txt_tabWLAN_Key"
        Me.txt_tabWLAN_Key.Size = New System.Drawing.Size(393, 47)
        Me.txt_tabWLAN_Key.TabIndex = 10
        Me.txt_tabWLAN_Key.text = ""
        '
        'BunifuCustomLabel17
        '
        Me.BunifuCustomLabel17.AutoSize = True
        Me.BunifuCustomLabel17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel17.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel17.Location = New System.Drawing.Point(2, 16)
        Me.BunifuCustomLabel17.Name = "BunifuCustomLabel17"
        Me.BunifuCustomLabel17.Size = New System.Drawing.Size(131, 21)
        Me.BunifuCustomLabel17.TabIndex = 9
        Me.BunifuCustomLabel17.Text = "WLAN Schlüssel:"
        '
        'lbl_tabWLAN1_WLANStatus
        '
        Me.lbl_tabWLAN1_WLANStatus.AutoSize = True
        Me.lbl_tabWLAN1_WLANStatus.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tabWLAN1_WLANStatus.ForeColor = System.Drawing.Color.White
        Me.lbl_tabWLAN1_WLANStatus.Location = New System.Drawing.Point(37, 118)
        Me.lbl_tabWLAN1_WLANStatus.Name = "lbl_tabWLAN1_WLANStatus"
        Me.lbl_tabWLAN1_WLANStatus.Size = New System.Drawing.Size(123, 21)
        Me.lbl_tabWLAN1_WLANStatus.TabIndex = 7
        Me.lbl_tabWLAN1_WLANStatus.Text = "WLAN Settings"
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 65535
        Me.BunifuSeparator3.Location = New System.Drawing.Point(31, 89)
        Me.BunifuSeparator3.Margin = New System.Windows.Forms.Padding(13)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(800, 2)
        Me.BunifuSeparator3.TabIndex = 6
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'BunifuCustomLabel16
        '
        Me.BunifuCustomLabel16.AutoSize = True
        Me.BunifuCustomLabel16.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel16.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel16.Location = New System.Drawing.Point(23, 44)
        Me.BunifuCustomLabel16.Name = "BunifuCustomLabel16"
        Me.BunifuCustomLabel16.Size = New System.Drawing.Size(236, 39)
        Me.BunifuCustomLabel16.TabIndex = 5
        Me.BunifuCustomLabel16.Text = "WLAN Settings"
        '
        'txt_tabWLAN_WLANName
        '
        Me.txt_tabWLAN_WLANName.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_tabWLAN_WLANName.BackgroundImage = CType(resources.GetObject("txt_tabWLAN_WLANName.BackgroundImage"), System.Drawing.Image)
        Me.txt_tabWLAN_WLANName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_tabWLAN_WLANName.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabWLAN_WLANName.ForeColor = System.Drawing.Color.SeaGreen
        Me.txt_tabWLAN_WLANName.Icon = CType(resources.GetObject("txt_tabWLAN_WLANName.Icon"), System.Drawing.Image)
        Me.txt_tabWLAN_WLANName.Location = New System.Drawing.Point(257, 162)
        Me.txt_tabWLAN_WLANName.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_tabWLAN_WLANName.Name = "txt_tabWLAN_WLANName"
        Me.txt_tabWLAN_WLANName.Size = New System.Drawing.Size(393, 47)
        Me.txt_tabWLAN_WLANName.TabIndex = 8
        Me.txt_tabWLAN_WLANName.text = ""
        '
        'tabController1
        '
        Me.tabController1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.tabController1.Controls.Add(Me.Panel5)
        Me.tabController1.Controls.Add(Me.BunifuCustomLabel43)
        Me.tabController1.Controls.Add(Me.txt_tabController1_URL)
        Me.tabController1.Controls.Add(Me.BunifuCustomLabel29)
        Me.tabController1.Controls.Add(Me.BunifuCustomLabel26)
        Me.tabController1.Controls.Add(Me.BunifuCustomLabel33)
        Me.tabController1.Controls.Add(Me.BunifuCustomLabel31)
        Me.tabController1.Controls.Add(Me.BunifuCustomLabel30)
        Me.tabController1.Controls.Add(Me.BunifuCards2)
        Me.tabController1.Controls.Add(Me.BunifuCustomLabel27)
        Me.tabController1.Controls.Add(Me.BunifuSeparator5)
        Me.tabController1.Controls.Add(Me.BunifuCustomLabel25)
        Me.tabController1.Controls.Add(Me.BunifuCustomLabel24)
        Me.tabController1.Controls.Add(Me.BunifuCustomLabel22)
        Me.tabController1.Controls.Add(Me.BunifuCards1)
        Me.tabController1.Controls.Add(Me.BunifuSeparator4)
        Me.tabController1.Controls.Add(Me.BunifuCustomLabel20)
        Me.tabController1.Controls.Add(Me.b_tabController1_Weiter)
        Me.tabController1.Controls.Add(Me.txt_tabController1_Intervall_Abfrage)
        Me.tabController1.Controls.Add(Me.txt_tabController1_HTTP_port)
        Me.tabController1.Controls.Add(Me.txt_tabController1_Host)
        Me.tabController1.Controls.Add(Me.txt_tabController1_API_Password)
        Me.tabController1.Controls.Add(Me.b_tabController1_ControllerV2)
        Me.tabController1.Controls.Add(Me.b_tabController1_ControllerV1)
        Me.tabController1.Location = New System.Drawing.Point(4, 10)
        Me.tabController1.Name = "tabController1"
        Me.tabController1.Size = New System.Drawing.Size(1034, 585)
        Me.tabController1.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(30, 269)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(800, 329)
        Me.Panel5.TabIndex = 18
        '
        'BunifuCustomLabel43
        '
        Me.BunifuCustomLabel43.AutoSize = True
        Me.BunifuCustomLabel43.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel43.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel43.Location = New System.Drawing.Point(28, 426)
        Me.BunifuCustomLabel43.Name = "BunifuCustomLabel43"
        Me.BunifuCustomLabel43.Size = New System.Drawing.Size(298, 21)
        Me.BunifuCustomLabel43.TabIndex = 29
        Me.BunifuCustomLabel43.Text = "URL (für Hauptverzeichnis Leer lassen)"
        '
        'txt_tabController1_URL
        '
        Me.txt_tabController1_URL.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_tabController1_URL.BackgroundImage = CType(resources.GetObject("txt_tabController1_URL.BackgroundImage"), System.Drawing.Image)
        Me.txt_tabController1_URL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_tabController1_URL.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabController1_URL.ForeColor = System.Drawing.Color.SeaGreen
        Me.txt_tabController1_URL.Icon = CType(resources.GetObject("txt_tabController1_URL.Icon"), System.Drawing.Image)
        Me.txt_tabController1_URL.Location = New System.Drawing.Point(32, 452)
        Me.txt_tabController1_URL.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_tabController1_URL.Name = "txt_tabController1_URL"
        Me.txt_tabController1_URL.Size = New System.Drawing.Size(420, 39)
        Me.txt_tabController1_URL.TabIndex = 30
        Me.txt_tabController1_URL.text = ""
        '
        'BunifuCustomLabel29
        '
        Me.BunifuCustomLabel29.AutoSize = True
        Me.BunifuCustomLabel29.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel29.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel29.Location = New System.Drawing.Point(26, 496)
        Me.BunifuCustomLabel29.Name = "BunifuCustomLabel29"
        Me.BunifuCustomLabel29.Size = New System.Drawing.Size(81, 21)
        Me.BunifuCustomLabel29.TabIndex = 22
        Me.BunifuCustomLabel29.Text = "Http Port"
        '
        'BunifuCustomLabel26
        '
        Me.BunifuCustomLabel26.AutoSize = True
        Me.BunifuCustomLabel26.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel26.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel26.Location = New System.Drawing.Point(27, 275)
        Me.BunifuCustomLabel26.Name = "BunifuCustomLabel26"
        Me.BunifuCustomLabel26.Size = New System.Drawing.Size(196, 21)
        Me.BunifuCustomLabel26.TabIndex = 16
        Me.BunifuCustomLabel26.Text = "Controller API Kennwort"
        '
        'BunifuCustomLabel33
        '
        Me.BunifuCustomLabel33.AutoSize = True
        Me.BunifuCustomLabel33.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel33.ForeColor = System.Drawing.Color.Red
        Me.BunifuCustomLabel33.Location = New System.Drawing.Point(29, 340)
        Me.BunifuCustomLabel33.Name = "BunifuCustomLabel33"
        Me.BunifuCustomLabel33.Size = New System.Drawing.Size(173, 16)
        Me.BunifuCustomLabel33.TabIndex = 28
        Me.BunifuCustomLabel33.Text = "IP-Adressen funktionieren nicht!"
        '
        'BunifuCustomLabel31
        '
        Me.BunifuCustomLabel31.AutoSize = True
        Me.BunifuCustomLabel31.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel31.ForeColor = System.Drawing.Color.Red
        Me.BunifuCustomLabel31.Location = New System.Drawing.Point(238, 565)
        Me.BunifuCustomLabel31.Name = "BunifuCustomLabel31"
        Me.BunifuCustomLabel31.Size = New System.Drawing.Size(435, 16)
        Me.BunifuCustomLabel31.TabIndex = 26
        Me.BunifuCustomLabel31.Text = "Wie oft soll der Controller mit dem Server kommunizieren? ( 10 sek * 1000 = 10000" & _
    ")"
        '
        'BunifuCustomLabel30
        '
        Me.BunifuCustomLabel30.AutoSize = True
        Me.BunifuCustomLabel30.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel30.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel30.Location = New System.Drawing.Point(238, 496)
        Me.BunifuCustomLabel30.Name = "BunifuCustomLabel30"
        Me.BunifuCustomLabel30.Size = New System.Drawing.Size(184, 21)
        Me.BunifuCustomLabel30.TabIndex = 24
        Me.BunifuCustomLabel30.Text = "Web Abfrage Intervall"
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.White
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = False
        Me.BunifuCards2.color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuCards2.Controls.Add(Me.BunifuCustomLabel28)
        Me.BunifuCards2.Controls.Add(Me.lbl_tabController1_HostURL)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(567, 296)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = False
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(264, 104)
        Me.BunifuCards2.TabIndex = 21
        '
        'BunifuCustomLabel28
        '
        Me.BunifuCustomLabel28.AutoSize = True
        Me.BunifuCustomLabel28.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel28.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuCustomLabel28.Location = New System.Drawing.Point(3, 21)
        Me.BunifuCustomLabel28.Name = "BunifuCustomLabel28"
        Me.BunifuCustomLabel28.Size = New System.Drawing.Size(245, 23)
        Me.BunifuCustomLabel28.TabIndex = 12
        Me.BunifuCustomLabel28.Text = "HOST Url (FTP-Verzeichnis)"
        '
        'lbl_tabController1_HostURL
        '
        Me.lbl_tabController1_HostURL.AutoSize = True
        Me.lbl_tabController1_HostURL.BackColor = System.Drawing.Color.White
        Me.lbl_tabController1_HostURL.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tabController1_HostURL.ForeColor = System.Drawing.Color.Blue
        Me.lbl_tabController1_HostURL.Location = New System.Drawing.Point(3, 49)
        Me.lbl_tabController1_HostURL.Name = "lbl_tabController1_HostURL"
        Me.lbl_tabController1_HostURL.Size = New System.Drawing.Size(31, 16)
        Me.lbl_tabController1_HostURL.TabIndex = 9
        Me.lbl_tabController1_HostURL.Text = "URL"
        '
        'BunifuCustomLabel27
        '
        Me.BunifuCustomLabel27.AutoSize = True
        Me.BunifuCustomLabel27.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel27.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel27.Location = New System.Drawing.Point(27, 353)
        Me.BunifuCustomLabel27.Name = "BunifuCustomLabel27"
        Me.BunifuCustomLabel27.Size = New System.Drawing.Size(396, 21)
        Me.BunifuCustomLabel27.TabIndex = 19
        Me.BunifuCustomLabel27.Text = "Webseiten HOST Adresse (z.B.: meineadresse.com)"
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 65535
        Me.BunifuSeparator5.Location = New System.Drawing.Point(30, 269)
        Me.BunifuSeparator5.Margin = New System.Windows.Forms.Padding(37, 34, 37, 34)
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Size = New System.Drawing.Size(800, 2)
        Me.BunifuSeparator5.TabIndex = 15
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = False
        '
        'BunifuCustomLabel25
        '
        Me.BunifuCustomLabel25.AutoSize = True
        Me.BunifuCustomLabel25.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuCustomLabel25.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel25.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel25.Location = New System.Drawing.Point(114, 97)
        Me.BunifuCustomLabel25.Name = "BunifuCustomLabel25"
        Me.BunifuCustomLabel25.Size = New System.Drawing.Size(249, 23)
        Me.BunifuCustomLabel25.TabIndex = 14
        Me.BunifuCustomLabel25.Text = "Bitte Controller auswählen"
        '
        'BunifuCustomLabel24
        '
        Me.BunifuCustomLabel24.AutoSize = True
        Me.BunifuCustomLabel24.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel24.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel24.Location = New System.Drawing.Point(282, 227)
        Me.BunifuCustomLabel24.Name = "BunifuCustomLabel24"
        Me.BunifuCustomLabel24.Size = New System.Drawing.Size(98, 21)
        Me.BunifuCustomLabel24.TabIndex = 13
        Me.BunifuCustomLabel24.Text = "WeMos Lua"
        '
        'BunifuCustomLabel22
        '
        Me.BunifuCustomLabel22.AutoSize = True
        Me.BunifuCustomLabel22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel22.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel22.Location = New System.Drawing.Point(111, 225)
        Me.BunifuCustomLabel22.Name = "BunifuCustomLabel22"
        Me.BunifuCustomLabel22.Size = New System.Drawing.Size(91, 21)
        Me.BunifuCustomLabel22.TabIndex = 12
        Me.BunifuCustomLabel22.Text = "WeMos D1"
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = False
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.lbl_tabController1_Controller_Auswahl)
        Me.BunifuCards1.Controls.Add(Me.lbl_tabController1_WLAN_Schlüssel)
        Me.BunifuCards1.Controls.Add(Me.BunifuCustomLabel21)
        Me.BunifuCards1.Controls.Add(Me.lbl_tabController1_WLANSSID)
        Me.BunifuCards1.Controls.Add(Me.BunifuCustomLabel23)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(567, 110)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = False
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(264, 136)
        Me.BunifuCards1.TabIndex = 9
        '
        'lbl_tabController1_Controller_Auswahl
        '
        Me.lbl_tabController1_Controller_Auswahl.AutoSize = True
        Me.lbl_tabController1_Controller_Auswahl.BackColor = System.Drawing.Color.White
        Me.lbl_tabController1_Controller_Auswahl.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tabController1_Controller_Auswahl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lbl_tabController1_Controller_Auswahl.Location = New System.Drawing.Point(3, 10)
        Me.lbl_tabController1_Controller_Auswahl.Name = "lbl_tabController1_Controller_Auswahl"
        Me.lbl_tabController1_Controller_Auswahl.Size = New System.Drawing.Size(249, 23)
        Me.lbl_tabController1_Controller_Auswahl.TabIndex = 12
        Me.lbl_tabController1_Controller_Auswahl.Text = "Bitte Controller auswählen"
        '
        'lbl_tabController1_WLAN_Schlüssel
        '
        Me.lbl_tabController1_WLAN_Schlüssel.AutoSize = True
        Me.lbl_tabController1_WLAN_Schlüssel.BackColor = System.Drawing.Color.White
        Me.lbl_tabController1_WLAN_Schlüssel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tabController1_WLAN_Schlüssel.ForeColor = System.Drawing.Color.Blue
        Me.lbl_tabController1_WLAN_Schlüssel.Location = New System.Drawing.Point(4, 109)
        Me.lbl_tabController1_WLAN_Schlüssel.Name = "lbl_tabController1_WLAN_Schlüssel"
        Me.lbl_tabController1_WLAN_Schlüssel.Size = New System.Drawing.Size(104, 16)
        Me.lbl_tabController1_WLAN_Schlüssel.TabIndex = 11
        Me.lbl_tabController1_WLAN_Schlüssel.Text = "WLAN Schlüssel"
        '
        'BunifuCustomLabel21
        '
        Me.BunifuCustomLabel21.AutoSize = True
        Me.BunifuCustomLabel21.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuCustomLabel21.Location = New System.Drawing.Point(3, 40)
        Me.BunifuCustomLabel21.Name = "BunifuCustomLabel21"
        Me.BunifuCustomLabel21.Size = New System.Drawing.Size(94, 21)
        Me.BunifuCustomLabel21.TabIndex = 8
        Me.BunifuCustomLabel21.Text = "WLAN SSID"
        '
        'lbl_tabController1_WLANSSID
        '
        Me.lbl_tabController1_WLANSSID.AutoSize = True
        Me.lbl_tabController1_WLANSSID.BackColor = System.Drawing.Color.White
        Me.lbl_tabController1_WLANSSID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tabController1_WLANSSID.ForeColor = System.Drawing.Color.Blue
        Me.lbl_tabController1_WLANSSID.Location = New System.Drawing.Point(4, 61)
        Me.lbl_tabController1_WLANSSID.Name = "lbl_tabController1_WLANSSID"
        Me.lbl_tabController1_WLANSSID.Size = New System.Drawing.Size(75, 16)
        Me.lbl_tabController1_WLANSSID.TabIndex = 9
        Me.lbl_tabController1_WLANSSID.Text = "WLAN SSID"
        '
        'BunifuCustomLabel23
        '
        Me.BunifuCustomLabel23.AutoSize = True
        Me.BunifuCustomLabel23.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuCustomLabel23.Location = New System.Drawing.Point(3, 88)
        Me.BunifuCustomLabel23.Name = "BunifuCustomLabel23"
        Me.BunifuCustomLabel23.Size = New System.Drawing.Size(127, 21)
        Me.BunifuCustomLabel23.TabIndex = 10
        Me.BunifuCustomLabel23.Text = "WLAN Schlüssel"
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 65535
        Me.BunifuSeparator4.Location = New System.Drawing.Point(31, 89)
        Me.BunifuSeparator4.Margin = New System.Windows.Forms.Padding(22, 21, 22, 21)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Size = New System.Drawing.Size(800, 2)
        Me.BunifuSeparator4.TabIndex = 8
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = False
        '
        'BunifuCustomLabel20
        '
        Me.BunifuCustomLabel20.AutoSize = True
        Me.BunifuCustomLabel20.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel20.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel20.Location = New System.Drawing.Point(23, 44)
        Me.BunifuCustomLabel20.Name = "BunifuCustomLabel20"
        Me.BunifuCustomLabel20.Size = New System.Drawing.Size(378, 39)
        Me.BunifuCustomLabel20.TabIndex = 7
        Me.BunifuCustomLabel20.Text = "Controller Einstellungen"
        '
        'b_tabController1_Weiter
        '
        Me.b_tabController1_Weiter.ActiveBorderThickness = 1
        Me.b_tabController1_Weiter.ActiveCornerRadius = 20
        Me.b_tabController1_Weiter.ActiveFillColor = System.Drawing.Color.DarkGreen
        Me.b_tabController1_Weiter.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_tabController1_Weiter.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b_tabController1_Weiter.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabController1_Weiter.BackgroundImage = CType(resources.GetObject("b_tabController1_Weiter.BackgroundImage"), System.Drawing.Image)
        Me.b_tabController1_Weiter.ButtonText = "Weiter"
        Me.b_tabController1_Weiter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_tabController1_Weiter.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_tabController1_Weiter.ForeColor = System.Drawing.Color.SeaGreen
        Me.b_tabController1_Weiter.IdleBorderThickness = 1
        Me.b_tabController1_Weiter.IdleCornerRadius = 20
        Me.b_tabController1_Weiter.IdleFillColor = System.Drawing.Color.Black
        Me.b_tabController1_Weiter.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.b_tabController1_Weiter.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.b_tabController1_Weiter.Location = New System.Drawing.Point(566, 522)
        Me.b_tabController1_Weiter.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.b_tabController1_Weiter.Name = "b_tabController1_Weiter"
        Me.b_tabController1_Weiter.Size = New System.Drawing.Size(264, 42)
        Me.b_tabController1_Weiter.TabIndex = 27
        Me.b_tabController1_Weiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_tabController1_Intervall_Abfrage
        '
        Me.txt_tabController1_Intervall_Abfrage.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_tabController1_Intervall_Abfrage.BackgroundImage = CType(resources.GetObject("txt_tabController1_Intervall_Abfrage.BackgroundImage"), System.Drawing.Image)
        Me.txt_tabController1_Intervall_Abfrage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_tabController1_Intervall_Abfrage.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabController1_Intervall_Abfrage.ForeColor = System.Drawing.Color.SeaGreen
        Me.txt_tabController1_Intervall_Abfrage.Icon = CType(resources.GetObject("txt_tabController1_Intervall_Abfrage.Icon"), System.Drawing.Image)
        Me.txt_tabController1_Intervall_Abfrage.Location = New System.Drawing.Point(242, 522)
        Me.txt_tabController1_Intervall_Abfrage.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_tabController1_Intervall_Abfrage.Name = "txt_tabController1_Intervall_Abfrage"
        Me.txt_tabController1_Intervall_Abfrage.Size = New System.Drawing.Size(208, 39)
        Me.txt_tabController1_Intervall_Abfrage.TabIndex = 25
        Me.txt_tabController1_Intervall_Abfrage.text = ""
        '
        'txt_tabController1_HTTP_port
        '
        Me.txt_tabController1_HTTP_port.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_tabController1_HTTP_port.BackgroundImage = CType(resources.GetObject("txt_tabController1_HTTP_port.BackgroundImage"), System.Drawing.Image)
        Me.txt_tabController1_HTTP_port.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_tabController1_HTTP_port.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabController1_HTTP_port.ForeColor = System.Drawing.Color.SeaGreen
        Me.txt_tabController1_HTTP_port.Icon = CType(resources.GetObject("txt_tabController1_HTTP_port.Icon"), System.Drawing.Image)
        Me.txt_tabController1_HTTP_port.Location = New System.Drawing.Point(30, 522)
        Me.txt_tabController1_HTTP_port.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_tabController1_HTTP_port.Name = "txt_tabController1_HTTP_port"
        Me.txt_tabController1_HTTP_port.Size = New System.Drawing.Size(171, 39)
        Me.txt_tabController1_HTTP_port.TabIndex = 23
        Me.txt_tabController1_HTTP_port.text = "80"
        '
        'txt_tabController1_Host
        '
        Me.txt_tabController1_Host.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_tabController1_Host.BackgroundImage = CType(resources.GetObject("txt_tabController1_Host.BackgroundImage"), System.Drawing.Image)
        Me.txt_tabController1_Host.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_tabController1_Host.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabController1_Host.ForeColor = System.Drawing.Color.SeaGreen
        Me.txt_tabController1_Host.Icon = CType(resources.GetObject("txt_tabController1_Host.Icon"), System.Drawing.Image)
        Me.txt_tabController1_Host.Location = New System.Drawing.Point(31, 379)
        Me.txt_tabController1_Host.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_tabController1_Host.Name = "txt_tabController1_Host"
        Me.txt_tabController1_Host.Size = New System.Drawing.Size(420, 39)
        Me.txt_tabController1_Host.TabIndex = 20
        Me.txt_tabController1_Host.text = ""
        '
        'txt_tabController1_API_Password
        '
        Me.txt_tabController1_API_Password.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_tabController1_API_Password.BackgroundImage = CType(resources.GetObject("txt_tabController1_API_Password.BackgroundImage"), System.Drawing.Image)
        Me.txt_tabController1_API_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txt_tabController1_API_Password.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabController1_API_Password.ForeColor = System.Drawing.Color.SeaGreen
        Me.txt_tabController1_API_Password.Icon = CType(resources.GetObject("txt_tabController1_API_Password.Icon"), System.Drawing.Image)
        Me.txt_tabController1_API_Password.Location = New System.Drawing.Point(31, 296)
        Me.txt_tabController1_API_Password.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_tabController1_API_Password.Name = "txt_tabController1_API_Password"
        Me.txt_tabController1_API_Password.Size = New System.Drawing.Size(420, 39)
        Me.txt_tabController1_API_Password.TabIndex = 17
        Me.txt_tabController1_API_Password.text = ""
        '
        'b_tabController1_ControllerV2
        '
        Me.b_tabController1_ControllerV2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabController1_ControllerV2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.b_tabController1_ControllerV2.Image = Global.SBB_Tool.My.Resources.Resources.WemosV2
        Me.b_tabController1_ControllerV2.ImageActive = Nothing
        Me.b_tabController1_ControllerV2.Location = New System.Drawing.Point(208, 129)
        Me.b_tabController1_ControllerV2.Name = "b_tabController1_ControllerV2"
        Me.b_tabController1_ControllerV2.Size = New System.Drawing.Size(143, 117)
        Me.b_tabController1_ControllerV2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.b_tabController1_ControllerV2.TabIndex = 11
        Me.b_tabController1_ControllerV2.TabStop = False
        Me.b_tabController1_ControllerV2.Zoom = 10
        '
        'b_tabController1_ControllerV1
        '
        Me.b_tabController1_ControllerV1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabController1_ControllerV1.Image = Global.SBB_Tool.My.Resources.Resources.WeMosV1
        Me.b_tabController1_ControllerV1.ImageActive = Nothing
        Me.b_tabController1_ControllerV1.Location = New System.Drawing.Point(30, 129)
        Me.b_tabController1_ControllerV1.Name = "b_tabController1_ControllerV1"
        Me.b_tabController1_ControllerV1.Size = New System.Drawing.Size(143, 117)
        Me.b_tabController1_ControllerV1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.b_tabController1_ControllerV1.TabIndex = 10
        Me.b_tabController1_ControllerV1.TabStop = False
        Me.b_tabController1_ControllerV1.Zoom = 10
        '
        'tabDownload
        '
        Me.tabDownload.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.tabDownload.Controls.Add(Me.b_tabDownload_Weiter_zum_Flashen)
        Me.tabDownload.Controls.Add(Me.txt_tabDownload_AblaufStatus)
        Me.tabDownload.Controls.Add(Me.lbl_tabDownload_Controller_Status)
        Me.tabDownload.Controls.Add(Me.lbl_tabDownload_Server_Status)
        Me.tabDownload.Controls.Add(Me.lbl_tabDownload_SVController)
        Me.tabDownload.Controls.Add(Me.lbl_tabDownload_SVWeb)
        Me.tabDownload.Controls.Add(Me.lbl_tabDownload_LVController)
        Me.tabDownload.Controls.Add(Me.lbl_tabDownload_LVWeb)
        Me.tabDownload.Controls.Add(Me.BunifuSeparator11)
        Me.tabDownload.Controls.Add(Me.BunifuSeparator10)
        Me.tabDownload.Controls.Add(Me.BunifuSeparator9)
        Me.tabDownload.Controls.Add(Me.BunifuSeparator8)
        Me.tabDownload.Controls.Add(Me.BunifuSeparator7)
        Me.tabDownload.Controls.Add(Me.BunifuCustomLabel38)
        Me.tabDownload.Controls.Add(Me.BunifuCustomLabel37)
        Me.tabDownload.Controls.Add(Me.BunifuCustomLabel36)
        Me.tabDownload.Controls.Add(Me.BunifuCustomLabel35)
        Me.tabDownload.Controls.Add(Me.BunifuSeparator6)
        Me.tabDownload.Controls.Add(Me.BunifuCustomLabel34)
        Me.tabDownload.Controls.Add(Me.b_tabDownload_StarteDownload)
        Me.tabDownload.Location = New System.Drawing.Point(4, 10)
        Me.tabDownload.Name = "tabDownload"
        Me.tabDownload.Size = New System.Drawing.Size(1034, 628)
        Me.tabDownload.TabIndex = 6
        '
        'b_tabDownload_Weiter_zum_Flashen
        '
        Me.b_tabDownload_Weiter_zum_Flashen.ActiveBorderThickness = 1
        Me.b_tabDownload_Weiter_zum_Flashen.ActiveCornerRadius = 20
        Me.b_tabDownload_Weiter_zum_Flashen.ActiveFillColor = System.Drawing.Color.DarkGreen
        Me.b_tabDownload_Weiter_zum_Flashen.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_tabDownload_Weiter_zum_Flashen.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b_tabDownload_Weiter_zum_Flashen.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabDownload_Weiter_zum_Flashen.BackgroundImage = CType(resources.GetObject("b_tabDownload_Weiter_zum_Flashen.BackgroundImage"), System.Drawing.Image)
        Me.b_tabDownload_Weiter_zum_Flashen.ButtonText = "Weiter zum Flashen"
        Me.b_tabDownload_Weiter_zum_Flashen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_tabDownload_Weiter_zum_Flashen.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_tabDownload_Weiter_zum_Flashen.ForeColor = System.Drawing.Color.SeaGreen
        Me.b_tabDownload_Weiter_zum_Flashen.IdleBorderThickness = 1
        Me.b_tabDownload_Weiter_zum_Flashen.IdleCornerRadius = 20
        Me.b_tabDownload_Weiter_zum_Flashen.IdleFillColor = System.Drawing.Color.Black
        Me.b_tabDownload_Weiter_zum_Flashen.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.b_tabDownload_Weiter_zum_Flashen.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.b_tabDownload_Weiter_zum_Flashen.Location = New System.Drawing.Point(599, 463)
        Me.b_tabDownload_Weiter_zum_Flashen.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.b_tabDownload_Weiter_zum_Flashen.Name = "b_tabDownload_Weiter_zum_Flashen"
        Me.b_tabDownload_Weiter_zum_Flashen.Size = New System.Drawing.Size(240, 42)
        Me.b_tabDownload_Weiter_zum_Flashen.TabIndex = 29
        Me.b_tabDownload_Weiter_zum_Flashen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.b_tabDownload_Weiter_zum_Flashen.Visible = False
        '
        'txt_tabDownload_AblaufStatus
        '
        Me.txt_tabDownload_AblaufStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txt_tabDownload_AblaufStatus.BorderColor = System.Drawing.Color.SeaGreen
        Me.txt_tabDownload_AblaufStatus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabDownload_AblaufStatus.ForeColor = System.Drawing.Color.White
        Me.txt_tabDownload_AblaufStatus.Location = New System.Drawing.Point(185, 302)
        Me.txt_tabDownload_AblaufStatus.Multiline = True
        Me.txt_tabDownload_AblaufStatus.Name = "txt_tabDownload_AblaufStatus"
        Me.txt_tabDownload_AblaufStatus.Size = New System.Drawing.Size(405, 203)
        Me.txt_tabDownload_AblaufStatus.TabIndex = 28
        Me.txt_tabDownload_AblaufStatus.Visible = False
        '
        'lbl_tabDownload_Controller_Status
        '
        Me.lbl_tabDownload_Controller_Status.AutoSize = True
        Me.lbl_tabDownload_Controller_Status.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tabDownload_Controller_Status.ForeColor = System.Drawing.Color.White
        Me.lbl_tabDownload_Controller_Status.Location = New System.Drawing.Point(595, 192)
        Me.lbl_tabDownload_Controller_Status.Name = "lbl_tabDownload_Controller_Status"
        Me.lbl_tabDownload_Controller_Status.Size = New System.Drawing.Size(14, 19)
        Me.lbl_tabDownload_Controller_Status.TabIndex = 25
        Me.lbl_tabDownload_Controller_Status.Text = "."
        Me.lbl_tabDownload_Controller_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_tabDownload_Server_Status
        '
        Me.lbl_tabDownload_Server_Status.AutoSize = True
        Me.lbl_tabDownload_Server_Status.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tabDownload_Server_Status.ForeColor = System.Drawing.Color.White
        Me.lbl_tabDownload_Server_Status.Location = New System.Drawing.Point(595, 143)
        Me.lbl_tabDownload_Server_Status.Name = "lbl_tabDownload_Server_Status"
        Me.lbl_tabDownload_Server_Status.Size = New System.Drawing.Size(14, 19)
        Me.lbl_tabDownload_Server_Status.TabIndex = 24
        Me.lbl_tabDownload_Server_Status.Text = "."
        Me.lbl_tabDownload_Server_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_tabDownload_SVController
        '
        Me.lbl_tabDownload_SVController.AutoSize = True
        Me.lbl_tabDownload_SVController.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tabDownload_SVController.ForeColor = System.Drawing.Color.White
        Me.lbl_tabDownload_SVController.Location = New System.Drawing.Point(504, 192)
        Me.lbl_tabDownload_SVController.Name = "lbl_tabDownload_SVController"
        Me.lbl_tabDownload_SVController.Size = New System.Drawing.Size(24, 19)
        Me.lbl_tabDownload_SVController.TabIndex = 23
        Me.lbl_tabDownload_SVController.Text = "..."
        Me.lbl_tabDownload_SVController.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_tabDownload_SVWeb
        '
        Me.lbl_tabDownload_SVWeb.AutoSize = True
        Me.lbl_tabDownload_SVWeb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tabDownload_SVWeb.ForeColor = System.Drawing.Color.White
        Me.lbl_tabDownload_SVWeb.Location = New System.Drawing.Point(504, 143)
        Me.lbl_tabDownload_SVWeb.Name = "lbl_tabDownload_SVWeb"
        Me.lbl_tabDownload_SVWeb.Size = New System.Drawing.Size(24, 19)
        Me.lbl_tabDownload_SVWeb.TabIndex = 22
        Me.lbl_tabDownload_SVWeb.Text = "..."
        Me.lbl_tabDownload_SVWeb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_tabDownload_LVController
        '
        Me.lbl_tabDownload_LVController.AutoSize = True
        Me.lbl_tabDownload_LVController.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tabDownload_LVController.ForeColor = System.Drawing.Color.White
        Me.lbl_tabDownload_LVController.Location = New System.Drawing.Point(333, 192)
        Me.lbl_tabDownload_LVController.Name = "lbl_tabDownload_LVController"
        Me.lbl_tabDownload_LVController.Size = New System.Drawing.Size(24, 19)
        Me.lbl_tabDownload_LVController.TabIndex = 21
        Me.lbl_tabDownload_LVController.Text = "..."
        Me.lbl_tabDownload_LVController.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_tabDownload_LVWeb
        '
        Me.lbl_tabDownload_LVWeb.AutoSize = True
        Me.lbl_tabDownload_LVWeb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tabDownload_LVWeb.ForeColor = System.Drawing.Color.White
        Me.lbl_tabDownload_LVWeb.Location = New System.Drawing.Point(333, 143)
        Me.lbl_tabDownload_LVWeb.Name = "lbl_tabDownload_LVWeb"
        Me.lbl_tabDownload_LVWeb.Size = New System.Drawing.Size(24, 19)
        Me.lbl_tabDownload_LVWeb.TabIndex = 20
        Me.lbl_tabDownload_LVWeb.Text = "..."
        Me.lbl_tabDownload_LVWeb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuSeparator11
        '
        Me.BunifuSeparator11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator11.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator11.LineThickness = 22
        Me.BunifuSeparator11.Location = New System.Drawing.Point(420, 102)
        Me.BunifuSeparator11.Margin = New System.Windows.Forms.Padding(478, 376, 478, 376)
        Me.BunifuSeparator11.Name = "BunifuSeparator11"
        Me.BunifuSeparator11.Size = New System.Drawing.Size(20, 129)
        Me.BunifuSeparator11.TabIndex = 19
        Me.BunifuSeparator11.Transparency = 255
        Me.BunifuSeparator11.Vertical = True
        '
        'BunifuSeparator10
        '
        Me.BunifuSeparator10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator10.Cursor = System.Windows.Forms.Cursors.No
        Me.BunifuSeparator10.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator10.LineThickness = 22
        Me.BunifuSeparator10.Location = New System.Drawing.Point(252, 102)
        Me.BunifuSeparator10.Margin = New System.Windows.Forms.Padding(287, 233, 287, 233)
        Me.BunifuSeparator10.Name = "BunifuSeparator10"
        Me.BunifuSeparator10.Size = New System.Drawing.Size(25, 129)
        Me.BunifuSeparator10.TabIndex = 18
        Me.BunifuSeparator10.Transparency = 255
        Me.BunifuSeparator10.Vertical = True
        '
        'BunifuSeparator9
        '
        Me.BunifuSeparator9.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator9.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator9.LineThickness = 21
        Me.BunifuSeparator9.Location = New System.Drawing.Point(30, 223)
        Me.BunifuSeparator9.Margin = New System.Windows.Forms.Padding(172, 144, 172, 144)
        Me.BunifuSeparator9.Name = "BunifuSeparator9"
        Me.BunifuSeparator9.Size = New System.Drawing.Size(560, 8)
        Me.BunifuSeparator9.TabIndex = 17
        Me.BunifuSeparator9.Transparency = 255
        Me.BunifuSeparator9.Vertical = False
        '
        'BunifuSeparator8
        '
        Me.BunifuSeparator8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator8.LineThickness = 21
        Me.BunifuSeparator8.Location = New System.Drawing.Point(30, 171)
        Me.BunifuSeparator8.Margin = New System.Windows.Forms.Padding(103, 89, 103, 89)
        Me.BunifuSeparator8.Name = "BunifuSeparator8"
        Me.BunifuSeparator8.Size = New System.Drawing.Size(560, 8)
        Me.BunifuSeparator8.TabIndex = 16
        Me.BunifuSeparator8.Transparency = 255
        Me.BunifuSeparator8.Vertical = False
        '
        'BunifuSeparator7
        '
        Me.BunifuSeparator7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator7.LineThickness = 21
        Me.BunifuSeparator7.Location = New System.Drawing.Point(30, 124)
        Me.BunifuSeparator7.Margin = New System.Windows.Forms.Padding(62, 55, 62, 55)
        Me.BunifuSeparator7.Name = "BunifuSeparator7"
        Me.BunifuSeparator7.Size = New System.Drawing.Size(560, 8)
        Me.BunifuSeparator7.TabIndex = 15
        Me.BunifuSeparator7.Transparency = 255
        Me.BunifuSeparator7.Vertical = False
        '
        'BunifuCustomLabel38
        '
        Me.BunifuCustomLabel38.AutoSize = True
        Me.BunifuCustomLabel38.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel38.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel38.Location = New System.Drawing.Point(455, 102)
        Me.BunifuCustomLabel38.Name = "BunifuCustomLabel38"
        Me.BunifuCustomLabel38.Size = New System.Drawing.Size(116, 19)
        Me.BunifuCustomLabel38.TabIndex = 14
        Me.BunifuCustomLabel38.Text = "Server Version"
        '
        'BunifuCustomLabel37
        '
        Me.BunifuCustomLabel37.AutoSize = True
        Me.BunifuCustomLabel37.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel37.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel37.Location = New System.Drawing.Point(285, 102)
        Me.BunifuCustomLabel37.Name = "BunifuCustomLabel37"
        Me.BunifuCustomLabel37.Size = New System.Drawing.Size(119, 19)
        Me.BunifuCustomLabel37.TabIndex = 13
        Me.BunifuCustomLabel37.Text = "Lokale Version"
        '
        'BunifuCustomLabel36
        '
        Me.BunifuCustomLabel36.AutoSize = True
        Me.BunifuCustomLabel36.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel36.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel36.Location = New System.Drawing.Point(27, 190)
        Me.BunifuCustomLabel36.Name = "BunifuCustomLabel36"
        Me.BunifuCustomLabel36.Size = New System.Drawing.Size(161, 21)
        Me.BunifuCustomLabel36.TabIndex = 12
        Me.BunifuCustomLabel36.Text = "Controller Firmware"
        '
        'BunifuCustomLabel35
        '
        Me.BunifuCustomLabel35.AutoSize = True
        Me.BunifuCustomLabel35.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel35.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel35.Location = New System.Drawing.Point(27, 141)
        Me.BunifuCustomLabel35.Name = "BunifuCustomLabel35"
        Me.BunifuCustomLabel35.Size = New System.Drawing.Size(158, 21)
        Me.BunifuCustomLabel35.TabIndex = 11
        Me.BunifuCustomLabel35.Text = "Web-Server Version"
        '
        'BunifuSeparator6
        '
        Me.BunifuSeparator6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator6.LineThickness = 65535
        Me.BunifuSeparator6.Location = New System.Drawing.Point(32, 89)
        Me.BunifuSeparator6.Margin = New System.Windows.Forms.Padding(37, 34, 37, 34)
        Me.BunifuSeparator6.Name = "BunifuSeparator6"
        Me.BunifuSeparator6.Size = New System.Drawing.Size(800, 2)
        Me.BunifuSeparator6.TabIndex = 10
        Me.BunifuSeparator6.Transparency = 255
        Me.BunifuSeparator6.Vertical = False
        '
        'BunifuCustomLabel34
        '
        Me.BunifuCustomLabel34.AutoSize = True
        Me.BunifuCustomLabel34.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel34.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel34.Location = New System.Drawing.Point(23, 44)
        Me.BunifuCustomLabel34.Name = "BunifuCustomLabel34"
        Me.BunifuCustomLabel34.Size = New System.Drawing.Size(437, 39)
        Me.BunifuCustomLabel34.TabIndex = 9
        Me.BunifuCustomLabel34.Text = "File Download und Settings"
        '
        'b_tabDownload_StarteDownload
        '
        Me.b_tabDownload_StarteDownload.ActiveBorderThickness = 1
        Me.b_tabDownload_StarteDownload.ActiveCornerRadius = 20
        Me.b_tabDownload_StarteDownload.ActiveFillColor = System.Drawing.Color.DarkGreen
        Me.b_tabDownload_StarteDownload.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_tabDownload_StarteDownload.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b_tabDownload_StarteDownload.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_tabDownload_StarteDownload.BackgroundImage = CType(resources.GetObject("b_tabDownload_StarteDownload.BackgroundImage"), System.Drawing.Image)
        Me.b_tabDownload_StarteDownload.ButtonText = "Starte Download"
        Me.b_tabDownload_StarteDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_tabDownload_StarteDownload.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_tabDownload_StarteDownload.ForeColor = System.Drawing.Color.SeaGreen
        Me.b_tabDownload_StarteDownload.IdleBorderThickness = 1
        Me.b_tabDownload_StarteDownload.IdleCornerRadius = 20
        Me.b_tabDownload_StarteDownload.IdleFillColor = System.Drawing.Color.Black
        Me.b_tabDownload_StarteDownload.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.b_tabDownload_StarteDownload.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.b_tabDownload_StarteDownload.Location = New System.Drawing.Point(185, 251)
        Me.b_tabDownload_StarteDownload.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.b_tabDownload_StarteDownload.Name = "b_tabDownload_StarteDownload"
        Me.b_tabDownload_StarteDownload.Size = New System.Drawing.Size(405, 42)
        Me.b_tabDownload_StarteDownload.TabIndex = 27
        Me.b_tabDownload_StarteDownload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.b_tabDownload_StarteDownload.Visible = False
        '
        'tabFlash1
        '
        Me.tabFlash1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.tabFlash1.Controls.Add(Me.pb_tabFlash1_ProgressBar)
        Me.tabFlash1.Controls.Add(Me.panelComPort)
        Me.tabFlash1.Controls.Add(Me.lbl_tabFlash1_Anweisungen)
        Me.tabFlash1.Controls.Add(Me.txt_tabFlash1_Status)
        Me.tabFlash1.Controls.Add(Me.b_TabFlash1_Starte_FlashVorgang)
        Me.tabFlash1.Controls.Add(Me.BunifuSeparator13)
        Me.tabFlash1.Controls.Add(Me.BunifuThinButton22)
        Me.tabFlash1.Controls.Add(Me.BunifuSeparator12)
        Me.tabFlash1.Controls.Add(Me.BunifuCustomLabel39)
        Me.tabFlash1.Location = New System.Drawing.Point(4, 10)
        Me.tabFlash1.Name = "tabFlash1"
        Me.tabFlash1.Size = New System.Drawing.Size(1034, 628)
        Me.tabFlash1.TabIndex = 7
        '
        'b_tabFlash1_Sende_Credentials
        '
        Me.b_tabFlash1_Sende_Credentials.BackColor = System.Drawing.Color.SeaGreen
        Me.b_tabFlash1_Sende_Credentials.color = System.Drawing.Color.SeaGreen
        Me.b_tabFlash1_Sende_Credentials.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.b_tabFlash1_Sende_Credentials.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_tabFlash1_Sende_Credentials.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.b_tabFlash1_Sende_Credentials.ForeColor = System.Drawing.Color.White
        Me.b_tabFlash1_Sende_Credentials.Image = Global.SBB_Tool.My.Resources.Resources.Controller
        Me.b_tabFlash1_Sende_Credentials.ImagePosition = 20
        Me.b_tabFlash1_Sende_Credentials.ImageZoom = 55
        Me.b_tabFlash1_Sende_Credentials.LabelPosition = 41
        Me.b_tabFlash1_Sende_Credentials.LabelText = "Sende Credentials"
        Me.b_tabFlash1_Sende_Credentials.Location = New System.Drawing.Point(6, 6)
        Me.b_tabFlash1_Sende_Credentials.Margin = New System.Windows.Forms.Padding(6)
        Me.b_tabFlash1_Sende_Credentials.Name = "b_tabFlash1_Sende_Credentials"
        Me.b_tabFlash1_Sende_Credentials.Size = New System.Drawing.Size(241, 208)
        Me.b_tabFlash1_Sende_Credentials.TabIndex = 35
        Me.b_tabFlash1_Sende_Credentials.Visible = False
        '
        'pb_tabFlash1_ProgressBar
        '
        Me.pb_tabFlash1_ProgressBar.BackColor = System.Drawing.Color.Silver
        Me.pb_tabFlash1_ProgressBar.BorderRadius = 5
        Me.pb_tabFlash1_ProgressBar.Location = New System.Drawing.Point(240, 192)
        Me.pb_tabFlash1_ProgressBar.Margin = New System.Windows.Forms.Padding(5)
        Me.pb_tabFlash1_ProgressBar.MaximumValue = 100
        Me.pb_tabFlash1_ProgressBar.Name = "pb_tabFlash1_ProgressBar"
        Me.pb_tabFlash1_ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pb_tabFlash1_ProgressBar.Size = New System.Drawing.Size(230, 18)
        Me.pb_tabFlash1_ProgressBar.TabIndex = 34
        Me.pb_tabFlash1_ProgressBar.Value = 0
        Me.pb_tabFlash1_ProgressBar.Visible = False
        '
        'panelComPort
        '
        Me.panelComPort.Controls.Add(Me.b_tabFlash1_Sende_Credentials)
        Me.panelComPort.Controls.Add(Me.b_TabFlash1_Burn)
        Me.panelComPort.Controls.Add(Me.BunifuCustomLabel40)
        Me.panelComPort.Controls.Add(Me.cb_tabFlash1_COM_Ports)
        Me.panelComPort.Location = New System.Drawing.Point(497, 300)
        Me.panelComPort.Name = "panelComPort"
        Me.panelComPort.Size = New System.Drawing.Size(253, 220)
        Me.panelComPort.TabIndex = 33
        Me.panelComPort.Visible = False
        '
        'b_TabFlash1_Burn
        '
        Me.b_TabFlash1_Burn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.b_TabFlash1_Burn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.b_TabFlash1_Burn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_TabFlash1_Burn.BorderRadius = 0
        Me.b_TabFlash1_Burn.ButtonText = "           Burn"
        Me.b_TabFlash1_Burn.CausesValidation = False
        Me.b_TabFlash1_Burn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_TabFlash1_Burn.DisabledColor = System.Drawing.Color.Gray
        Me.b_TabFlash1_Burn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_TabFlash1_Burn.Iconcolor = System.Drawing.Color.Transparent
        Me.b_TabFlash1_Burn.Iconimage = Global.SBB_Tool.My.Resources.Resources.FLASH
        Me.b_TabFlash1_Burn.Iconimage_right = Nothing
        Me.b_TabFlash1_Burn.Iconimage_right_Selected = Nothing
        Me.b_TabFlash1_Burn.Iconimage_Selected = Nothing
        Me.b_TabFlash1_Burn.IconMarginLeft = 0
        Me.b_TabFlash1_Burn.IconMarginRight = 0
        Me.b_TabFlash1_Burn.IconRightVisible = False
        Me.b_TabFlash1_Burn.IconRightZoom = 0.0R
        Me.b_TabFlash1_Burn.IconVisible = False
        Me.b_TabFlash1_Burn.IconZoom = 80.0R
        Me.b_TabFlash1_Burn.IsTab = False
        Me.b_TabFlash1_Burn.Location = New System.Drawing.Point(58, 114)
        Me.b_TabFlash1_Burn.Margin = New System.Windows.Forms.Padding(0)
        Me.b_TabFlash1_Burn.Name = "b_TabFlash1_Burn"
        Me.b_TabFlash1_Burn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.b_TabFlash1_Burn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.b_TabFlash1_Burn.OnHoverTextColor = System.Drawing.Color.White
        Me.b_TabFlash1_Burn.selected = False
        Me.b_TabFlash1_Burn.Size = New System.Drawing.Size(130, 86)
        Me.b_TabFlash1_Burn.TabIndex = 34
        Me.b_TabFlash1_Burn.Text = "           Burn"
        Me.b_TabFlash1_Burn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.b_TabFlash1_Burn.Textcolor = System.Drawing.Color.White
        Me.b_TabFlash1_Burn.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_TabFlash1_Burn.Visible = False
        '
        'BunifuCustomLabel40
        '
        Me.BunifuCustomLabel40.AutoSize = True
        Me.BunifuCustomLabel40.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel40.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel40.Location = New System.Drawing.Point(14, 16)
        Me.BunifuCustomLabel40.Name = "BunifuCustomLabel40"
        Me.BunifuCustomLabel40.Size = New System.Drawing.Size(219, 19)
        Me.BunifuCustomLabel40.TabIndex = 32
        Me.BunifuCustomLabel40.Text = "Bitte COM Port auswählen"
        '
        'cb_tabFlash1_COM_Ports
        '
        Me.cb_tabFlash1_COM_Ports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_tabFlash1_COM_Ports.FormattingEnabled = True
        Me.cb_tabFlash1_COM_Ports.Location = New System.Drawing.Point(58, 47)
        Me.cb_tabFlash1_COM_Ports.Name = "cb_tabFlash1_COM_Ports"
        Me.cb_tabFlash1_COM_Ports.Size = New System.Drawing.Size(130, 29)
        Me.cb_tabFlash1_COM_Ports.TabIndex = 31
        '
        'lbl_tabFlash1_Anweisungen
        '
        Me.lbl_tabFlash1_Anweisungen.AutoSize = True
        Me.lbl_tabFlash1_Anweisungen.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tabFlash1_Anweisungen.ForeColor = System.Drawing.Color.White
        Me.lbl_tabFlash1_Anweisungen.Location = New System.Drawing.Point(24, 244)
        Me.lbl_tabFlash1_Anweisungen.Name = "lbl_tabFlash1_Anweisungen"
        Me.lbl_tabFlash1_Anweisungen.Size = New System.Drawing.Size(44, 39)
        Me.lbl_tabFlash1_Anweisungen.TabIndex = 30
        Me.lbl_tabFlash1_Anweisungen.Text = "..."
        '
        'txt_tabFlash1_Status
        '
        Me.txt_tabFlash1_Status.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txt_tabFlash1_Status.BorderColor = System.Drawing.Color.SeaGreen
        Me.txt_tabFlash1_Status.Enabled = False
        Me.txt_tabFlash1_Status.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tabFlash1_Status.ForeColor = System.Drawing.Color.White
        Me.txt_tabFlash1_Status.Location = New System.Drawing.Point(30, 317)
        Me.txt_tabFlash1_Status.Multiline = True
        Me.txt_tabFlash1_Status.Name = "txt_tabFlash1_Status"
        Me.txt_tabFlash1_Status.Size = New System.Drawing.Size(440, 203)
        Me.txt_tabFlash1_Status.TabIndex = 29
        Me.txt_tabFlash1_Status.Visible = False
        '
        'b_TabFlash1_Starte_FlashVorgang
        '
        Me.b_TabFlash1_Starte_FlashVorgang.ActiveBorderThickness = 1
        Me.b_TabFlash1_Starte_FlashVorgang.ActiveCornerRadius = 20
        Me.b_TabFlash1_Starte_FlashVorgang.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.b_TabFlash1_Starte_FlashVorgang.ActiveForecolor = System.Drawing.Color.White
        Me.b_TabFlash1_Starte_FlashVorgang.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b_TabFlash1_Starte_FlashVorgang.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_TabFlash1_Starte_FlashVorgang.BackgroundImage = CType(resources.GetObject("b_TabFlash1_Starte_FlashVorgang.BackgroundImage"), System.Drawing.Image)
        Me.b_TabFlash1_Starte_FlashVorgang.ButtonText = "Installiere Treiber"
        Me.b_TabFlash1_Starte_FlashVorgang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_TabFlash1_Starte_FlashVorgang.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_TabFlash1_Starte_FlashVorgang.ForeColor = System.Drawing.Color.SeaGreen
        Me.b_TabFlash1_Starte_FlashVorgang.IdleBorderThickness = 1
        Me.b_TabFlash1_Starte_FlashVorgang.IdleCornerRadius = 20
        Me.b_TabFlash1_Starte_FlashVorgang.IdleFillColor = System.Drawing.Color.White
        Me.b_TabFlash1_Starte_FlashVorgang.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.b_TabFlash1_Starte_FlashVorgang.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.b_TabFlash1_Starte_FlashVorgang.Location = New System.Drawing.Point(31, 179)
        Me.b_TabFlash1_Starte_FlashVorgang.Margin = New System.Windows.Forms.Padding(5)
        Me.b_TabFlash1_Starte_FlashVorgang.Name = "b_TabFlash1_Starte_FlashVorgang"
        Me.b_TabFlash1_Starte_FlashVorgang.Size = New System.Drawing.Size(199, 44)
        Me.b_TabFlash1_Starte_FlashVorgang.TabIndex = 16
        Me.b_TabFlash1_Starte_FlashVorgang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuSeparator13
        '
        Me.BunifuSeparator13.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator13.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator13.LineThickness = 65535
        Me.BunifuSeparator13.Location = New System.Drawing.Point(31, 168)
        Me.BunifuSeparator13.Margin = New System.Windows.Forms.Padding(103, 89, 103, 89)
        Me.BunifuSeparator13.Name = "BunifuSeparator13"
        Me.BunifuSeparator13.Size = New System.Drawing.Size(800, 2)
        Me.BunifuSeparator13.TabIndex = 14
        Me.BunifuSeparator13.Transparency = 255
        Me.BunifuSeparator13.Vertical = False
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Custom"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Location = New System.Drawing.Point(30, 105)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(124, 44)
        Me.BunifuThinButton22.TabIndex = 13
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuSeparator12
        '
        Me.BunifuSeparator12.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator12.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator12.LineThickness = 65535
        Me.BunifuSeparator12.Location = New System.Drawing.Point(31, 89)
        Me.BunifuSeparator12.Margin = New System.Windows.Forms.Padding(62, 55, 62, 55)
        Me.BunifuSeparator12.Name = "BunifuSeparator12"
        Me.BunifuSeparator12.Size = New System.Drawing.Size(800, 2)
        Me.BunifuSeparator12.TabIndex = 11
        Me.BunifuSeparator12.Transparency = 255
        Me.BunifuSeparator12.Vertical = False
        '
        'BunifuCustomLabel39
        '
        Me.BunifuCustomLabel39.AutoSize = True
        Me.BunifuCustomLabel39.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel39.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel39.Location = New System.Drawing.Point(23, 44)
        Me.BunifuCustomLabel39.Name = "BunifuCustomLabel39"
        Me.BunifuCustomLabel39.Size = New System.Drawing.Size(447, 39)
        Me.BunifuCustomLabel39.TabIndex = 10
        Me.BunifuCustomLabel39.Text = "Controller Firmware Flashen"
        '
        'frmInstall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 668)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInstall"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.b_EXIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Start.ResumeLayout(False)
        Me.Start.PerformLayout()
        Me.tabServer1.ResumeLayout(False)
        Me.tabServer1.PerformLayout()
        CType(Me.b_tabServer1_Zurück, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_tabServer1_FTPStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabServer2.ResumeLayout(False)
        Me.tabServer2.PerformLayout()
        Me.p_tabServer2_UploadVerzeichnis.ResumeLayout(False)
        Me.p_tabServer2_UploadVerzeichnis.PerformLayout()
        CType(Me.b_tabServer2_HomeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.b_tabServer2_OrdnerLöschen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.b_tabServer2_OrdnerHinzufügen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.b_tabServer2_UploadPfadÜbernehmen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMySQL1.ResumeLayout(False)
        Me.tabMySQL1.PerformLayout()
        CType(Me.b_tabMySQL1_Zurück, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWLAN1.ResumeLayout(False)
        Me.tabWLAN1.PerformLayout()
        CType(Me.b_tabWlan_Suche_Wlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.b_tabWLAN_Zurück, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.tabController1.ResumeLayout(False)
        Me.tabController1.PerformLayout()
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        CType(Me.b_tabController1_ControllerV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.b_tabController1_ControllerV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDownload.ResumeLayout(False)
        Me.tabDownload.PerformLayout()
        Me.tabFlash1.ResumeLayout(False)
        Me.tabFlash1.PerformLayout()
        Me.panelComPort.ResumeLayout(False)
        Me.panelComPort.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents b_ServerInstall As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents b_Controller As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents b_WLAN As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents b_Finish As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents b_EXIT As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Start As System.Windows.Forms.TabPage
    Friend WithEvents tabServer1 As System.Windows.Forms.TabPage
    Friend WithEvents b_Start_NEIN As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents b_Start_JA As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents txt_tabServer1_Username As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txt_tabServer1_FTPPassword As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents b_tabServer1_PrüfeFTP As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txt_tabServer1_Port As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txt_tabServer1_SeverAddress As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents circle_Wait As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents lbl_tabServer1_FTPStatus As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pic_tabServer1_FTPStatus As System.Windows.Forms.PictureBox
    Friend WithEvents tabServer2 As System.Windows.Forms.TabPage
    Friend WithEvents lb_tabServer2_FTPVerzeichnis As System.Windows.Forms.ListBox
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents b_tabServer2_UploadPfadÜbernehmen As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_tabServer2_Pfad As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents b_tabServer2_OrdnerHinzufügen As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents b_tabServer2_OrdnerLöschen As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents b_tabServer2_HomeButton As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents p_tabServer2_UploadVerzeichnis As System.Windows.Forms.Panel
    Friend WithEvents lbl_AusgewähltesUploadVerzeichnis As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents b_tabServer1_WeiterZuFtpVerzeichnis As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents b_tabServer2_WeiterZuMySQL As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents tabMySQL1 As System.Windows.Forms.TabPage
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel15 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txt_tabMySQL1_Database As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel13 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel14 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txt_tabMySQL1_ServerAdresse As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents txt_tabMySQL1_Port As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents b_tabMySQL1_PrüfeMySQLConnection As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txt_tabMySQL1_Password As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents txt_tabMySQL1_User As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_tabMySQL1_MySQLStatus As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tabWLAN1 As System.Windows.Forms.TabPage
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel16 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents b_tabMySQL_WeiterZuWLAN As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lbl_tabWLAN1_WLANStatus As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txt_tabWLAN_Key As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuCustomLabel17 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txt_tabWLAN_WLANName As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuCustomLabel18 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents b_tabWLAN1_WeiterZuController As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel19 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tabController1 As System.Windows.Forms.TabPage
    Friend WithEvents BunifuSeparator4 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel20 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents b_tabServer1_Zurück As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents b_tabMySQL1_Zurück As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents b_tabWLAN_Zurück As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents b_tabController1_ControllerV2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents b_tabController1_ControllerV1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lbl_tabController1_WLAN_Schlüssel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel23 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_tabController1_WLANSSID As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel21 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel24 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel22 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_tabController1_Controller_Auswahl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel25 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txt_tabController1_API_Password As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuCustomLabel26 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents txt_tabController1_Host As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuCustomLabel27 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCustomLabel28 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_tabController1_HostURL As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txt_tabController1_Intervall_Abfrage As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuCustomLabel30 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txt_tabController1_HTTP_port As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuCustomLabel29 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel31 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel32 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents b_tabController1_Weiter As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel33 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents b_Download As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tabDownload As System.Windows.Forms.TabPage
    Friend WithEvents BunifuSeparator6 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel34 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel36 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel35 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents b_tabWlan_Suche_Wlan As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuSeparator7 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel38 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel37 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator8 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator9 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator10 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator11 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents lbl_tabDownload_SVController As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_tabDownload_SVWeb As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_tabDownload_LVController As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_tabDownload_LVWeb As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_tabDownload_Controller_Status As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_tabDownload_Server_Status As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents b_tabDownload_StarteDownload As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txt_tabDownload_AblaufStatus As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents b_tabDownload_Weiter_zum_Flashen As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents tabFlash1 As System.Windows.Forms.TabPage
    Friend WithEvents b_Flash As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuSeparator12 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel39 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator13 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents b_TabFlash1_Starte_FlashVorgang As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txt_tabFlash1_Status As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents lbl_tabFlash1_Anweisungen As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cb_tabFlash1_COM_Ports As System.Windows.Forms.ComboBox
    Friend WithEvents BunifuCustomLabel40 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents panelComPort As System.Windows.Forms.Panel
    Friend WithEvents b_TabFlash1_Burn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents pb_tabFlash1_ProgressBar As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents b_tabFlash1_Sende_Credentials As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuCustomLabel42 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel41 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cb_tabMySQL1_KeineMySQL_User_Prüfung As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuCustomLabel43 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txt_tabController1_URL As Bunifu.Framework.UI.BunifuTextbox
End Class
