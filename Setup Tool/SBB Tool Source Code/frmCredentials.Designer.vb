<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCredentials
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
        Me.txtPort = New System.Windows.Forms.ComboBox()
        Me.btnRefreshPorts = New System.Windows.Forms.Button()
        Me.txtSendData = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtSerialText = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.SuspendLayout()
        '
        'txtPort
        '
        Me.txtPort.FormattingEnabled = True
        Me.txtPort.Location = New System.Drawing.Point(21, 12)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(113, 21)
        Me.txtPort.TabIndex = 0
        '
        'btnRefreshPorts
        '
        Me.btnRefreshPorts.Location = New System.Drawing.Point(191, 13)
        Me.btnRefreshPorts.Name = "btnRefreshPorts"
        Me.btnRefreshPorts.Size = New System.Drawing.Size(142, 20)
        Me.btnRefreshPorts.TabIndex = 1
        Me.btnRefreshPorts.Text = "Button5"
        Me.btnRefreshPorts.UseVisualStyleBackColor = True
        Me.btnRefreshPorts.Visible = False
        '
        'txtSendData
        '
        Me.txtSendData.Location = New System.Drawing.Point(23, 57)
        Me.txtSendData.Name = "txtSendData"
        Me.txtSendData.Size = New System.Drawing.Size(489, 20)
        Me.txtSendData.TabIndex = 2
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(518, 58)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(142, 19)
        Me.btnSend.TabIndex = 3
        Me.btnSend.Text = "Button6"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(21, 389)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(142, 19)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Button7"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(614, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(142, 19)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Button8"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(666, 58)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(74, 19)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Button6"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'txtSerialText
        '
        Me.txtSerialText.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtSerialText.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSerialText.Enabled = False
        Me.txtSerialText.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerialText.ForeColor = System.Drawing.Color.White
        Me.txtSerialText.Location = New System.Drawing.Point(21, 93)
        Me.txtSerialText.Multiline = True
        Me.txtSerialText.Name = "txtSerialText"
        Me.txtSerialText.Size = New System.Drawing.Size(719, 290)
        Me.txtSerialText.TabIndex = 30
        Me.txtSerialText.Visible = False
        '
        'frmCredentials
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(768, 443)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSerialText)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtSendData)
        Me.Controls.Add(Me.btnRefreshPorts)
        Me.Controls.Add(Me.txtPort)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmCredentials"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPort As System.Windows.Forms.ComboBox
    Friend WithEvents btnRefreshPorts As System.Windows.Forms.Button
    Friend WithEvents txtSendData As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtSerialText As WindowsFormsControlLibrary1.BunifuCustomTextbox
End Class
