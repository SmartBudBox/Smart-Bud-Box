<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart))
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.b_EXIT = New Bunifu.Framework.UI.BunifuImageButton()
        Me.b_WebServer = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.b_Firmware = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.b_NeuInstall = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.b_EXIT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Gray
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(130, 313)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(118, 13)
        Me.BunifuCustomLabel1.TabIndex = 4
        Me.BunifuCustomLabel1.Text = "GNU License Version 1"
        '
        'b_EXIT
        '
        Me.b_EXIT.BackColor = System.Drawing.Color.Black
        Me.b_EXIT.Image = Global.SBB_Tool.My.Resources.Resources.Close
        Me.b_EXIT.ImageActive = Nothing
        Me.b_EXIT.Location = New System.Drawing.Point(160, 600)
        Me.b_EXIT.Name = "b_EXIT"
        Me.b_EXIT.Size = New System.Drawing.Size(40, 44)
        Me.b_EXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.b_EXIT.TabIndex = 5
        Me.b_EXIT.TabStop = False
        Me.ToolTip1.SetToolTip(Me.b_EXIT, "Beenden das Smart Bud Box Tool")
        Me.b_EXIT.Zoom = 10
        '
        'b_WebServer
        '
        Me.b_WebServer.ActiveBorderThickness = 1
        Me.b_WebServer.ActiveCornerRadius = 20
        Me.b_WebServer.ActiveFillColor = System.Drawing.Color.DarkGreen
        Me.b_WebServer.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_WebServer.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b_WebServer.BackColor = System.Drawing.Color.Black
        Me.b_WebServer.BackgroundImage = CType(resources.GetObject("b_WebServer.BackgroundImage"), System.Drawing.Image)
        Me.b_WebServer.ButtonText = "WebServer Update"
        Me.b_WebServer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_WebServer.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_WebServer.ForeColor = System.Drawing.Color.SeaGreen
        Me.b_WebServer.IdleBorderThickness = 1
        Me.b_WebServer.IdleCornerRadius = 20
        Me.b_WebServer.IdleFillColor = System.Drawing.Color.Black
        Me.b_WebServer.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.b_WebServer.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.b_WebServer.Location = New System.Drawing.Point(40, 506)
        Me.b_WebServer.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.b_WebServer.Name = "b_WebServer"
        Me.b_WebServer.Size = New System.Drawing.Size(290, 75)
        Me.b_WebServer.TabIndex = 3
        Me.b_WebServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'b_Firmware
        '
        Me.b_Firmware.ActiveBorderThickness = 1
        Me.b_Firmware.ActiveCornerRadius = 20
        Me.b_Firmware.ActiveFillColor = System.Drawing.Color.DarkGreen
        Me.b_Firmware.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_Firmware.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b_Firmware.BackColor = System.Drawing.Color.Black
        Me.b_Firmware.BackgroundImage = CType(resources.GetObject("b_Firmware.BackgroundImage"), System.Drawing.Image)
        Me.b_Firmware.ButtonText = "Firmware Update"
        Me.b_Firmware.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_Firmware.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Firmware.ForeColor = System.Drawing.Color.SeaGreen
        Me.b_Firmware.IdleBorderThickness = 1
        Me.b_Firmware.IdleCornerRadius = 20
        Me.b_Firmware.IdleFillColor = System.Drawing.Color.Black
        Me.b_Firmware.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.b_Firmware.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.b_Firmware.Location = New System.Drawing.Point(40, 419)
        Me.b_Firmware.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.b_Firmware.Name = "b_Firmware"
        Me.b_Firmware.Size = New System.Drawing.Size(290, 75)
        Me.b_Firmware.TabIndex = 2
        Me.b_Firmware.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'b_NeuInstall
        '
        Me.b_NeuInstall.ActiveBorderThickness = 1
        Me.b_NeuInstall.ActiveCornerRadius = 20
        Me.b_NeuInstall.ActiveFillColor = System.Drawing.Color.DarkGreen
        Me.b_NeuInstall.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_NeuInstall.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b_NeuInstall.BackColor = System.Drawing.Color.Black
        Me.b_NeuInstall.BackgroundImage = CType(resources.GetObject("b_NeuInstall.BackgroundImage"), System.Drawing.Image)
        Me.b_NeuInstall.ButtonText = "Neu Installation"
        Me.b_NeuInstall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_NeuInstall.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_NeuInstall.ForeColor = System.Drawing.Color.SeaGreen
        Me.b_NeuInstall.IdleBorderThickness = 1
        Me.b_NeuInstall.IdleCornerRadius = 20
        Me.b_NeuInstall.IdleFillColor = System.Drawing.Color.Black
        Me.b_NeuInstall.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.b_NeuInstall.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.b_NeuInstall.Location = New System.Drawing.Point(40, 332)
        Me.b_NeuInstall.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.b_NeuInstall.Name = "b_NeuInstall"
        Me.b_NeuInstall.Size = New System.Drawing.Size(290, 75)
        Me.b_NeuInstall.TabIndex = 1
        Me.b_NeuInstall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SBB_Tool.My.Resources.Resources.SBBLogo
        Me.PictureBox1.Location = New System.Drawing.Point(41, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(290, 276)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(373, 667)
        Me.ControlBox = False
        Me.Controls.Add(Me.b_EXIT)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.b_WebServer)
        Me.Controls.Add(Me.b_Firmware)
        Me.Controls.Add(Me.b_NeuInstall)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.b_EXIT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents b_NeuInstall As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents b_Firmware As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents b_WebServer As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents b_EXIT As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
