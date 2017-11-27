Imports System.IO

Public Class frmCredentials

    Dim WithEvents SerialPort As New IO.Ports.SerialPort
    Dim selPort As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshPorts()
        SPSetup()
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        If SerialPort.IsOpen Then
            'SerialPort.Write(Chr(1) & Chr(90) & Chr(48) & Chr(57) & Chr(48)) 'txtSendData.Text)
            SerialPort.Write(txtSendData.Text)
        Else
            SPSetup()
            SerialPort.Write(txtSendData.Text)
        End If
    End Sub

    Private Sub ConnectSerial()
        Try
            SerialPort.BaudRate = 9600
            SerialPort.PortName = selPort
            SerialPort.Open()
        Catch
            SerialPort.Close()
        End Try
    End Sub

    Delegate Sub myMethodDelegate(ByVal [text] As String)
    Dim myD1 As New myMethodDelegate(AddressOf myShowStringMethod)

    Sub myShowStringMethod(ByVal myString As String)
        txtSerialText.AppendText(myString)
    End Sub


    Private Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Dim str As String = SerialPort.ReadExisting
        Invoke(myD1, str)
    End Sub

    Private Sub btnRefreshPorts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshPorts.Click
        RefreshPorts()
    End Sub

    Private Sub RefreshPorts()
        txtPort.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            txtPort.Items.Add(sp)
        Next

        If txtPort.Items.Count > 0 Then
            txtPort.SelectedIndex = 0
            selPort = txtPort.Text
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSerialText.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Sub SPSetup()    'Serial Port Setup
        On Error Resume Next
        If SerialPort.IsOpen Then
            SerialPort.Close()
        End If
        SerialPort.PortName = selPort  ' "COM3"
        SerialPort.BaudRate = 115200
        SerialPort.DataBits = 8
        SerialPort.StopBits = IO.Ports.StopBits.One
        SerialPort.Handshake = IO.Ports.Handshake.None
        SerialPort.Parity = IO.Ports.Parity.None
        '----->  Now change the Encoding to enable 8-bit communications:  <-----
        'SerialPort.Encoding = System.Text.Encoding.GetEncoding(1252)
        SerialPort.Open()
    End Sub

    Private Sub txtPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPort.SelectedIndexChanged
        selPort = txtPort.Text
        Me.Text = String.Format("Arduino Serial Communication - {0}", selPort)
        SPSetup()
    End Sub




    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If SerialPort.IsOpen Then
            'SerialPort.Write(Chr(1) & Chr(90) & Chr(48) & Chr(57) & Chr(48)) 'txtSendData.Text)
            SerialPort.Write("SSID" & My.Settings.WLANSSID.Trim)
        Else
            SPSetup()
            SerialPort.Write("SSID" & My.Settings.WLANSSID.Trim)
        End If
    End Sub

    Private Sub txtPort_TextChanged(sender As Object, e As EventArgs) Handles txtPort.TextChanged
        selPort = txtPort.Text
        Me.Text = String.Format("Arduino Serial Communication - {0}", selPort)
        SPSetup()
    End Sub

    Public Sub SendeCredentials()
        If SerialPort.IsOpen Then
            SerialPort.Write("SSID" & My.Settings.WLANSSID.Trim)
            SerialPort.Write("PASS" & My.Settings.WLANKEY.Trim)

        Else
            SPSetup()
            SerialPort.Write("SSID" & My.Settings.WLANSSID.Trim)
            SerialPort.Write("PASS" & My.Settings.WLANKEY.Trim)
        End If
    End Sub

   
   
End Class
