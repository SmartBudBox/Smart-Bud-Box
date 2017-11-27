<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInputBox))
        Me.lbl_Anzeige = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.b_Übernehmen = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txt_Wert = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.b_EXIT = New Bunifu.Framework.UI.BunifuImageButton()
        Me.b_Nein = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.b_JA = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.b_EXIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Anzeige
        '
        Me.lbl_Anzeige.AutoSize = True
        Me.lbl_Anzeige.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lbl_Anzeige.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Anzeige.ForeColor = System.Drawing.Color.White
        Me.lbl_Anzeige.Location = New System.Drawing.Point(57, 30)
        Me.lbl_Anzeige.Name = "lbl_Anzeige"
        Me.lbl_Anzeige.Size = New System.Drawing.Size(372, 39)
        Me.lbl_Anzeige.TabIndex = 7
        Me.lbl_Anzeige.Text = "Bitte Namen eingeben"
        '
        'b_Übernehmen
        '
        Me.b_Übernehmen.ActiveBorderThickness = 1
        Me.b_Übernehmen.ActiveCornerRadius = 20
        Me.b_Übernehmen.ActiveFillColor = System.Drawing.Color.DarkGreen
        Me.b_Übernehmen.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_Übernehmen.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b_Übernehmen.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_Übernehmen.BackgroundImage = CType(resources.GetObject("b_Übernehmen.BackgroundImage"), System.Drawing.Image)
        Me.b_Übernehmen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.b_Übernehmen.ButtonText = "Übernehmen"
        Me.b_Übernehmen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_Übernehmen.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Übernehmen.ForeColor = System.Drawing.Color.SeaGreen
        Me.b_Übernehmen.IdleBorderThickness = 1
        Me.b_Übernehmen.IdleCornerRadius = 20
        Me.b_Übernehmen.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_Übernehmen.IdleForecolor = System.Drawing.Color.SeaShell
        Me.b_Übernehmen.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.b_Übernehmen.Location = New System.Drawing.Point(158, 132)
        Me.b_Übernehmen.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.b_Übernehmen.Name = "b_Übernehmen"
        Me.b_Übernehmen.Size = New System.Drawing.Size(151, 38)
        Me.b_Übernehmen.TabIndex = 2
        Me.b_Übernehmen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_Wert
        '
        Me.txt_Wert.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_Wert.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Wert.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Wert.ForeColor = System.Drawing.Color.Red
        Me.txt_Wert.HintForeColor = System.Drawing.Color.White
        Me.txt_Wert.HintText = ""
        Me.txt_Wert.isPassword = False
        Me.txt_Wert.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_Wert.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_Wert.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_Wert.LineThickness = 4
        Me.txt_Wert.Location = New System.Drawing.Point(40, 79)
        Me.txt_Wert.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_Wert.Name = "txt_Wert"
        Me.txt_Wert.Size = New System.Drawing.Size(402, 51)
        Me.txt_Wert.TabIndex = 1
        Me.txt_Wert.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'b_EXIT
        '
        Me.b_EXIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_EXIT.Image = Global.SBB_Tool.My.Resources.Resources.Close
        Me.b_EXIT.ImageActive = Nothing
        Me.b_EXIT.Location = New System.Drawing.Point(410, 12)
        Me.b_EXIT.Name = "b_EXIT"
        Me.b_EXIT.Size = New System.Drawing.Size(32, 24)
        Me.b_EXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.b_EXIT.TabIndex = 10
        Me.b_EXIT.TabStop = False
        Me.b_EXIT.Zoom = 10
        '
        'b_Nein
        '
        Me.b_Nein.ActiveBorderThickness = 1
        Me.b_Nein.ActiveCornerRadius = 20
        Me.b_Nein.ActiveFillColor = System.Drawing.Color.DarkGreen
        Me.b_Nein.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_Nein.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b_Nein.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_Nein.BackgroundImage = CType(resources.GetObject("b_Nein.BackgroundImage"), System.Drawing.Image)
        Me.b_Nein.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.b_Nein.ButtonText = "NEIN"
        Me.b_Nein.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_Nein.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_Nein.ForeColor = System.Drawing.Color.SeaGreen
        Me.b_Nein.IdleBorderThickness = 1
        Me.b_Nein.IdleCornerRadius = 20
        Me.b_Nein.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_Nein.IdleForecolor = System.Drawing.Color.SeaShell
        Me.b_Nein.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.b_Nein.Location = New System.Drawing.Point(369, 132)
        Me.b_Nein.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.b_Nein.Name = "b_Nein"
        Me.b_Nein.Size = New System.Drawing.Size(73, 38)
        Me.b_Nein.TabIndex = 12
        Me.b_Nein.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.b_Nein.Visible = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'b_JA
        '
        Me.b_JA.ActiveBorderThickness = 1
        Me.b_JA.ActiveCornerRadius = 20
        Me.b_JA.ActiveFillColor = System.Drawing.Color.DarkGreen
        Me.b_JA.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.b_JA.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.b_JA.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_JA.BackgroundImage = CType(resources.GetObject("b_JA.BackgroundImage"), System.Drawing.Image)
        Me.b_JA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.b_JA.ButtonText = "JA"
        Me.b_JA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_JA.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_JA.ForeColor = System.Drawing.Color.SeaGreen
        Me.b_JA.IdleBorderThickness = 1
        Me.b_JA.IdleCornerRadius = 20
        Me.b_JA.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.b_JA.IdleForecolor = System.Drawing.Color.SeaShell
        Me.b_JA.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.b_JA.Location = New System.Drawing.Point(40, 132)
        Me.b_JA.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.b_JA.Name = "b_JA"
        Me.b_JA.Size = New System.Drawing.Size(73, 38)
        Me.b_JA.TabIndex = 13
        Me.b_JA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.b_JA.Visible = False
        '
        'frmInputBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(469, 185)
        Me.ControlBox = False
        Me.Controls.Add(Me.b_JA)
        Me.Controls.Add(Me.b_Nein)
        Me.Controls.Add(Me.b_EXIT)
        Me.Controls.Add(Me.txt_Wert)
        Me.Controls.Add(Me.b_Übernehmen)
        Me.Controls.Add(Me.lbl_Anzeige)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInputBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CType(Me.b_EXIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Anzeige As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents b_Übernehmen As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txt_Wert As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents b_EXIT As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents b_Nein As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents b_JA As Bunifu.Framework.UI.BunifuThinButton2
End Class
