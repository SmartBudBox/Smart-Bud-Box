Imports System.IO.Ports

Public Class cSerial

    Dim serPort As New SerialPort

    Public Function ÖffneCommunication(ByVal Parameter As String, ByVal COMPort As String)

        Try
            serPort.PortName = COMPort
            serPort.Open()
            serPort.Write(Parameter)
            serPort.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function PrüfePort(ByVal Port As String) As Boolean
        serPort.PortName = Port
        Try
            serPort.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub PortCLOSE()
        serPort.Close()
    End Sub


    Public Sub SendeCredentials(ByVal PORT As String)
        '//Werte für einige Eigenschaften
        serPort.PortName = PORT
        serPort.BaudRate = 115200
        serPort.Parity = IO.Ports.Parity.None
        serPort.DataBits = 8
        serPort.StopBits = IO.Ports.StopBits.One
        serPort.Handshake = IO.Ports.Handshake.None
        serPort.RtsEnable = True


        If Not serPort.IsOpen Then '//Öffnen der seriellen Schnittstelle wenn sie nicht offen ist
            serPort.Open()
        Else
            '//Serielle Schnittstelle ist schon offen
            '//Schreibt z.B. Daten an der seriellen Schnittstelle 
            '//SerialPort1.Write("MicroCommand")
        End If


    End Sub
End Class
