Imports System.Threading
Imports System.ComponentModel
Imports System.Management
Imports System
Imports System.IO
Imports System.Collections.ObjectModel
Imports System.Collections
Imports System.Text
Imports NativeWifi
Imports System.Net
Imports System.IO.Compression
Imports System.Security
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO.Ports

Public Class frmInstall

    Dim trdWarteKreis As New System.Threading.Thread(AddressOf ThreadCirrcle)
    Dim trdFTPConnection As New System.Threading.Thread(AddressOf PrüfeFTPConnection)
    Dim trdDownloas As New System.Threading.Thread(AddressOf PrüfeServerVersionenAusGithub)
    Dim FTPVerzeichnis(1) As String         'Array für das FTP Directory
    Dim strFTPVerzeichnis As String = "/"   'Variable um mir das FTP Verzeichnis zu merken
    Dim ftp As New Utilities.FTP.FTPclient  'Globaler FTP Client
    Dim mysql As New cMySQL                 'Globaler mySQLClient
    Dim ServerUpdate As Boolean = False     'Variable um zu speichern ob der Server geuppdet werden soll
    Dim ControllerUpdate As Boolean = False 'Variable um zu speichern ob der Controlle geupdated werden soll
    Dim Versionen() As String = Nothing

    Dim WithEvents SerialPort As New IO.Ports.SerialPort
    Dim selPort As String

    Public WithEvents wc As New WebClient

    Delegate Sub glgSetBunifuLabel(ByVal txt As Bunifu.Framework.UI.BunifuCustomLabel, ByVal s As String, Sichtbar As Boolean)
    Delegate Sub dlgSetAnyListbox(ByVal tb As Bunifu.Framework.UI.BunifuCircleProgressbar, ByVal i As Integer, sichtbar As Boolean)
    Delegate Sub glgSetPictureBox(ByVal pb As PictureBox, ByVal Farbe As String)
    Delegate Sub glgSetBunifuButton(ByVal txt As Bunifu.Framework.UI.BunifuThinButton2, ByVal s As String)

#Region "Allgemeine Form Funktionen"

    Private Sub frmInstall_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Beschreibung:      Wird beim start der WindowsForm ausgeführt

        'Erstellungdatum :  10.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Verberge zunächst die Form frmStart
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        frmStart.Hide()
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Me.Panel1.Width = 60
    End Sub

    Private Sub b_EXIT_Click(sender As Object, e As EventArgs) Handles b_EXIT.Click, b_Start_NEIN.Click
        'Beschreibung:      Schliesst das Installationsfenster

        'Erstellungdatum :  10.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Mache die frmStart wieder sichtbar und schliesse dich
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        frmStart.Show()
        Me.Close()
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    End Sub

    Private Sub b_Start_JA_Click(sender As Object, e As EventArgs) Handles b_Start_JA.Click
        'Beschreibung:      Startet die Installation der SSB Tools

        'Erstellungdatum :  10.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Wechsle auf die page tabServer1
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        TabControl1.SelectedTab = tabServer1
        '----------------------------------------------------------------------------------------------
        'Vergrößere das Panel damit man die Menüs sehen kann und setze den Server auf Aktiv
        Do Until Panel1.Width = 200
            Panel1.Width = Panel1.Width + 10
            Refresh()
        Loop
        '----------------------------------------------------------------------------------------------
        'Mache das Logo sichtbar
        PictureBox1.Visible = True
        '----------------------------------------------------------------------------------------------

        '----------------------------------------------------------------------------------------------
        'Aktiviere den Server Button
        b_ServerInstall.selected = True
        ''----------------------------------------------------------------------------------------------
        ''Prüfe ob bereits Benutzer Settings vorhanden sind.
        ''Falls ja fülle die Textboxen bereits aus damit mehr Komfort besteht
        ''----------------------------------------------------------------------------------------------
        'If My.Settings.FTPUser <> "" Then
        '    Me.txt_tabServer1_Username.text = My.Settings.FTPUser
        '    Me.txt_tabServer1_FTPPassword.text = My.Settings.FTPPassword
        '    Me.txt_tabServer1_SeverAddress.text = My.Settings.FTPServer
        'End If
    End Sub

    Private Sub SMS(ByVal Text As String, Optional caption As String = "Fehlende Eingabe")
        MessageBox.Show(Text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function GetFileOfPath(sPath As String, Optional sChar As String = "\") _
As String
        GetFileOfPath = ""
        Dim lngPos As Long
        lngPos = InStrRev(sPath, sChar)

        If lngPos > 0 Then _
            GetFileOfPath = Mid(sPath, lngPos + Len(sChar))
        Return GetFileOfPath
    End Function

    Private Sub AktiviereDasRegister(ByVal iStep As Integer)
        Select Case iStep

            Case 1
                b_ServerInstall.selected = True
                b_WLAN.selected = False
                b_Controller.selected = False
                b_Finish.selected = False
                b_Download.selected = False

            Case 2
                b_ServerInstall.selected = False
                b_WLAN.selected = True
                b_Controller.selected = False
                b_Finish.selected = False
                b_Download.selected = False

            Case 3
                b_ServerInstall.selected = False
                b_WLAN.selected = False
                b_Controller.selected = True
                b_Finish.selected = False
                b_Download.selected = False

            Case 4
                b_ServerInstall.selected = False
                b_WLAN.selected = False
                b_Controller.selected = False
                b_Finish.selected = False
                b_Download.selected = True

            Case 5
                b_ServerInstall.selected = False
                b_WLAN.selected = False
                b_Controller.selected = False
                b_Download.selected = False
                b_Flash.selected = True
                b_Finish.selected = False

            Case 6
                b_ServerInstall.selected = False
                b_WLAN.selected = False
                b_Controller.selected = False
                b_Download.selected = False
                b_Flash.selected = False
                b_Finish.selected = True

        End Select
    End Sub

    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) _
            Handles TabControl1.Selecting




        '**************************************************************************************************
        If Me.TabControl1.SelectedIndex = 1 Then    '"tabServer1"
            '----------------------------------------------------------------------------------------------
            'Prüfe ob bereits Benutzer Settings vorhanden sind.
            'Falls ja fülle die Textboxen bereits aus damit mehr Komfort besteht
            '----------------------------------------------------------------------------------------------
            If My.Settings.FTPUser <> "" Then
                Me.txt_tabServer1_Username.text = My.Settings.FTPUser
                Me.txt_tabServer1_FTPPassword.text = My.Settings.FTPPassword
                Me.txt_tabServer1_SeverAddress.text = My.Settings.FTPServer
            End If
            AktiviereDasRegister(1)
        End If
        '**************************************************************************************************


        '**************************************************************************************************
        If Me.TabControl1.SelectedIndex = 2 Then    '"tabServer2"
            '----------------------------------------------------------------------------------------------
            'Prüfe ob bereits Benutzer Settings vorhanden sind.
            '----------------------------------------------------------------------------------------------
            If My.Settings.FTPUpload <> "" Then
                Me.lbl_tabServer2_Pfad.Text = My.Settings.FTPUpload
                'Lade das Verzeichnis
                Try
                    Dim AnzahlVerzeichnisse As Integer = ftp.ListDirectory("/" & My.Settings.FTPUpload).Count
                    ReDim FTPVerzeichnis(AnzahlVerzeichnisse)
                    FTPVerzeichnis = ftp.ListDirectory("/" & My.Settings.FTPUpload).ToArray
                Catch ex As Exception
                    MessageBox.Show("Es ist ein Fehler aufgetreten." & vbCrLf & vbCrLf & ex.Message.ToString)
                    Exit Sub
                End Try
                '----------------------------------------------------------------------------------------------
                Me.lb_tabServer2_FTPVerzeichnis.Refresh()
                Me.lb_tabServer2_FTPVerzeichnis.DataSource = FTPVerzeichnis
            End If
            AktiviereDasRegister(1)
        End If
        '**************************************************************************************************


        '**************************************************************************************************
        If Me.TabControl1.SelectedIndex = 3 Then    '"mySQL1"
            '----------------------------------------------------------------------------------------------
            'Prüfe ob bereits Benutzer Settings vorhanden sind.
            '----------------------------------------------------------------------------------------------
            If My.Settings.mySQLUser <> "" Then
                Me.txt_tabMySQL1_Database.text = My.Settings.mySQLDatabase
                Me.txt_tabMySQL1_Password.text = My.Settings.mySQLPassword
                Me.txt_tabMySQL1_Port.text = My.Settings.myySQLPort
                Me.txt_tabMySQL1_ServerAdresse.text = My.Settings.mySQLServer
                Me.txt_tabMySQL1_User.text = My.Settings.mySQLUser
            End If
            AktiviereDasRegister(1)
        End If
        '**************************************************************************************************



        '**************************************************************************************************
        If Me.TabControl1.SelectedIndex = 4 Then    '"WLAN"
            '----------------------------------------------------------------------------------------------
            'Prüfe ob bereits Benutzer Settings vorhanden sind.
            '----------------------------------------------------------------------------------------------
            If Prüfe_WLAN_Verbindung() = False Then
                If My.Settings.WLANSSID <> "" Then
                    Me.txt_tabWLAN_WLANName.text = My.Settings.WLANSSID
                    Me.txt_tabWLAN_Key.text = My.Settings.WLANKEY
                End If
            End If
            AktiviereDasRegister(2)
        End If
        '**************************************************************************************************


        '**************************************************************************************************
        If Me.TabControl1.SelectedIndex = 5 Then    '"Controller"
            '----------------------------------------------------------------------------------------------
            'Prüfe ob bereits Benutzer Settings vorhanden sind.
            '----------------------------------------------------------------------------------------------
            If My.Settings.ControllerVersion = "V1" Then
                Me.lbl_tabController1_Controller_Auswahl.Text = "WeMos D1 mini"
            End If
            '-------------------------------------------------------------------
            If My.Settings.ControllerVersion = "V2" Then
                Me.lbl_tabController1_Controller_Auswahl.Text = "WeMos Lua"
            End If
            '-------------------------------------------------------------------
            'Die WLAN Gedöns 
            '-------------------------------------------------------------------
            Me.lbl_tabController1_WLAN_Schlüssel.Text = My.Settings.WLANKEY
            Me.lbl_tabController1_WLANSSID.Text = My.Settings.WLANSSID
            '-------------------------------------------------------------------
            'Die Host Server Gedöns
            '-------------------------------------------------------------------
            Me.lbl_tabController1_HostURL.Text = My.Settings.FTPUpload
            Me.txt_tabController1_API_Password.text = My.Settings.ControllerAPIPassword
            Me.txt_tabController1_URL.text = My.Settings.Controller_URL
            '-------------------------------------------------------------------
            'Die Server Angaben
            '-------------------------------------------------------------------
            Me.txt_tabController1_Host.text = My.Settings.Controller_Host
            Me.txt_tabController1_Intervall_Abfrage.text = My.Settings.Controller_Interval
            '*******************************************************************
          
            AktiviereDasRegister(3)
        End If
        '**************************************************************************************************


        '**************************************************************************************************
        If Me.TabControl1.SelectedIndex = 6 Then    '"Download"
            '********************************************************************
            'Überprüfe auf aktualität
            Me.circle_Wait.Visible = True
            trdWarteKreis = New System.Threading.Thread(AddressOf ThreadCirrcle)
            trdWarteKreis.Start()
            Me.Refresh()
            '********************************************************************

            'LÖSCHEN
            My.Settings.Version_Controller = ""
            My.Settings.Version_Server = ""
            'LÖSCHEN

            trdDownloas = New System.Threading.Thread(AddressOf PrüfeServerVersionenAusGithub)
            trdDownloas.Start()
            'Me.b_tabDownload_StarteDownload.Visible = True

            AktiviereDasRegister(4)
        End If
        '**************************************************************************************************


        '**************************************************************************************************
        If Me.TabControl1.SelectedIndex = 7 Then    '"Flash"
            '********************************************************************


            AktiviereDasRegister(5)
        End If
        '**************************************************************************************************

    End Sub

    Private Sub warte(Sekunden As Double)
        Try
            Dim ZeitSpanne As Double
            Dim Start As Double
            ZeitSpanne = Sekunden / 100000
            Start = DateTime.Now.ToOADate()   ' Anfangszeit setzen.
            Do While DateTime.Now.ToOADate() < Start + ZeitSpanne
                Application.DoEvents()  ' Steuerung an andere Prozesse abgeben
            Loop
        Catch ex As Exception

            Exit Sub
        End Try
    End Sub

#End Region

#Region "TabServer"

#Region "tabServer1_HauptDatenEingabe"

    Private Sub b_tabServer1_PrüfeFTP_Click(sender As Object, e As EventArgs) _
        Handles b_tabServer1_PrüfeFTP.Click
        'Beschreibung:      Prüfe die FTP Verbindung. 
        '                   Starte die Progressbar Anzeige in einem eigenen Thread
        '                   Starte die FTP Abfrage in einem anderen Thread

        'Erstellungdatum :  10.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Prüfe ob alle Eingaben gemacht worden sind
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        If Me.txt_tabServer1_Username.text = "" Then
            SMS("Bitte Username Eingeben", "Fehlende Eingabe")
            Exit Sub
        End If
        '---------------------------------------------------------------
        If Me.txt_tabServer1_SeverAddress.text = "" Then
            SMS("Bitte Server Adresse Eingeben", "Fehlende Eingabe")
            Exit Sub
        End If
        '---------------------------------------------------------------
        If Me.txt_tabServer1_FTPPassword.text = "" Then
            SMS("Bitte Password Eingeben", "Fehlende Eingabe")
            Exit Sub
        End If
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Starte die Progessbar
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Me.circle_Wait.Visible = True                   'Mache die Bar sichtbar
        Me.Refresh()                                    'Refresh der Userform
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        '---------------------------------------------------------------------------------------------
        'Setze die FTP Connection Daten ein
        '---------------------------------------------------------------------------------------------
        ftp.Hostname = Me.txt_tabServer1_SeverAddress.text
        ftp.Username = Me.txt_tabServer1_Username.text
        ftp.Password = Me.txt_tabServer1_FTPPassword.text
        '---------------------------------------------------------------------------------------------


        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Starte die Cirrcle Progressbar in einen gesonderten Thread.
        'So kann der Circle laufen während die FTP Abfrage stattfinden kann
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        trdWarteKreis = New System.Threading.Thread(AddressOf ThreadCirrcle)
        trdWarteKreis.Start()
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Starte die FTP Abfrage ebenfalls in einem eigenem Thread
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        trdFTPConnection = New System.Threading.Thread(AddressOf PrüfeFTPConnection)
        trdFTPConnection.Start()
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    End Sub

    Private Sub PrüfeFTPConnection()
        'Beschreibung:      Prüfe die FTP Verbindung. 
        '                   Starte die Progressbar Anzeige in einem eigenen Thread
        '                   Starte die FTP Abfrage in einem anderen Thread

        'Erstellungdatum :  11.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================
        Dim d As New glgSetBunifuLabel(AddressOf SetAnyLabel)
        Invoke(d, lbl_tabServer1_FTPStatus, "", True)

        Dim D2 As New dlgSetAnyListbox(AddressOf SetAnyListbox)
        Dim D3 As New glgSetPictureBox(AddressOf SetPictureBoxImage)



        Try
            Dim AnzahlVerzeichnisse As Integer = ftp.ListDirectory("/").Count
            ReDim FTPVerzeichnis(AnzahlVerzeichnisse)
            FTPVerzeichnis = ftp.ListDirectory("/").ToArray
        Catch ex As Exception
            If ex.Message.Contains("530") Then
                Invoke(d, lbl_tabServer1_FTPStatus, "Benutzer oder Passwort falsch", True)
                ' Me.lbl_tabServer1_FTPStatus.Text = "Benutzer oder Passwort falsch"
            Else
                ' Me.lbl_tabServer1_FTPStatus.Text = "Server Adresse falsch"
                Invoke(d, lbl_tabServer1_FTPStatus, "Server Adresse falsch", True)
            End If

            D3.Invoke(pic_tabServer1_FTPStatus, "ROT")
            GoTo Info
        End Try
        Invoke(d, lbl_tabServer1_FTPStatus, "FTP OK", True)
        D3.Invoke(pic_tabServer1_FTPStatus, "GRÜN")
        '-------------------------------------------------------------------------------------
        'Speichere die Zugangsdaten in die User Settings Datei
        '-------------------------------------------------------------------------------------
        My.Settings.FTPUser = Me.txt_tabServer1_Username.text
        My.Settings.FTPPassword = Me.txt_tabServer1_FTPPassword.text
        My.Settings.FTPServer = Me.txt_tabServer1_SeverAddress.text
        My.Settings.Save()
        '-------------------------------------------------------------------------------------
        Dim D4 As New glgSetBunifuButton(AddressOf setButton)
        Invoke(D4, Me.b_tabServer1_WeiterZuFtpVerzeichnis, "TRUE")
info:




        'Dim D2 As New dlgSetAnyListbox(AddressOf SetAnyListbox)
        Invoke(D2, circle_Wait, 0, False)
        trdWarteKreis.Abort()


        trdFTPConnection.Abort()



    End Sub

    Private Sub setButton(ByVal Name As Bunifu.Framework.UI.BunifuThinButton2, ByVal s As String)
        If s = "TRUE" Then
            Name.Visible = True
        Else
            Name.Visible = False
        End If
    End Sub


    Private Sub SetPictureBoxImage(ByVal pb As PictureBox, ByVal Farbe As String)
        If Farbe = "ROT" Then
            pb.BackgroundImage = My.Resources.ServerRot
        End If
        If Farbe = "GRÜN" Then
            pb.BackgroundImage = My.Resources.ServerGrün
        End If
    End Sub

    Private Sub b_tabServer1_Zurück_Click(sender As Object, e As EventArgs) _
        Handles b_tabServer1_Zurück.Click
        TabControl1.SelectedTab = Start
    End Sub

#End Region

#Region "tabServer2"
    Private Sub lb_tabServer2_DoubleClick(sender As Object, e As EventArgs) _
        Handles lb_tabServer2_FTPVerzeichnis.DoubleClick
        'Beschreibung:      Bei einem Doppellick in die Listbox wird das FTP Verzeichnis verändert

        'Erstellungdatum :  11.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ermittle welches Verzeichnis ausgewählt worden ist und lade die Directory
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        '----------------------------------------------------------------------------------------------
        Dim strTemp As String = Me.lb_tabServer2_FTPVerzeichnis.SelectedItem.ToString
        '----------------------------------------------------------------------------------------------

        '----------------------------------------------------------------------------------------------
        'Weil ich nicht weiß wie ich mir die Verzeichnis Pfade besser merken kann verwende ich
        'bis zu 5 Variablen. Ist zwar total behindert gelöst aber ich kann es nicht besser
        '----------------------------------------------------------------------------------------------
        'If FTP_ErstesVerzeichnis = "" Then
        '    FTP_ErstesVerzeichnis = strTemp
        'Else
        '    If FTP_ZWeitesVerzeichnis = "" Then
        '        FTP_ZWeitesVerzeichnis = GetFileOfPath(strTemp, "/")
        '    Else
        '        If FTP_DrittesVerzeichnis = "" Then
        '            FTP_DrittesVerzeichnis = GetFileOfPath(strTemp, "/")
        '        End If
        '    End If
        'End If

        '        strFTPVerzeichnis = FTP_ErstesVerzeichnis & "/" & FTP_ZWeitesVerzeichnis & "/" & FTP_DrittesVerzeichnis


        If Not (strTemp.Contains("/")) Then
            strFTPVerzeichnis = ftp._lastDirectory & "/" & strTemp
        Else
            strFTPVerzeichnis = ftp._lastDirectory & "/" & GetFileOfPath(strTemp, "/")
            If strFTPVerzeichnis.Contains("//") Then
                Dim AnzahlZeichen As Integer = strFTPVerzeichnis.Length
                strFTPVerzeichnis = Microsoft.VisualBasic.Right(strFTPVerzeichnis, AnzahlZeichen - 2)
            End If
        End If


        'MessageBox.Show(ftp._lastDirectory.ToString)

        Try
            Dim AnzahlVerzeichnisse As Integer = ftp.ListDirectory("/" & strFTPVerzeichnis).Count
            ReDim FTPVerzeichnis(AnzahlVerzeichnisse)
            FTPVerzeichnis = ftp.ListDirectory("/" & strFTPVerzeichnis).ToArray
        Catch ex As Exception
            MessageBox.Show("Es ist ein Fehler aufgetreten." & vbCrLf & vbCrLf & ex.Message.ToString)
            Exit Sub
        End Try
        Me.lbl_tabServer2_Pfad.Text = strFTPVerzeichnis
        '----------------------------------------------------------------------------------------------
        Me.lb_tabServer2_FTPVerzeichnis.Refresh()
        'Me.lb_tabServer2_FTPVerzeichnis.Items.Clear()  'Lösche die bestehenden Directory aus der Liste
        'Lade die neuen Verzeichnisse rein
        Me.lb_tabServer2_FTPVerzeichnis.DataSource = FTPVerzeichnis

    End Sub


    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        'Beschreibung:      Geht zum letzen bekannten Punkt

        'Erstellungdatum :  11.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ermittle welches Verzeichnis ausgewählt worden ist und lade die Directory
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim iTemp As Integer = 0

        Try
            iTemp = GetFileOfPath(ftp._lastDirectory, "/").Length
        Catch ex As Exception
            If ftp._lastDirectory <> "" Then
                If ftp._lastDirectory.Contains("/") = False Then
                    ftp._lastDirectory = "/"
                    GoTo HauptVerzeichnis
                End If
            End If
        End Try

        If iTemp = 0 Then
            If ftp._lastDirectory.EndsWith("/") Then
                ftp._lastDirectory = ftp._lastDirectory.Substring(0, ftp._lastDirectory.Length - 1)
            Else
                ftp._lastDirectory = "/"
            End If
        End If


HauptVerzeichnis:

        Dim strTemp As String = Microsoft.VisualBasic.Left(ftp._lastDirectory, ftp._lastDirectory.Length - iTemp)



        Me.lbl_tabServer2_Pfad.Text = strTemp

        If strTemp.Contains("//") Then
            Dim AnzahlZeichen As Integer = strTemp.Length
            strTemp = Microsoft.VisualBasic.Right(strTemp, AnzahlZeichen - 2)
        End If

        Try
            Dim AnzahlVerzeichnisse As Integer = ftp.ListDirectory("/" & strTemp).Count
            ReDim FTPVerzeichnis(AnzahlVerzeichnisse)
            FTPVerzeichnis = ftp.ListDirectory("/" & strTemp).ToArray
        Catch ex As Exception
            MessageBox.Show("Es ist ein Fehler aufgetreten." & vbCrLf & vbCrLf & ex.Message.ToString)
            Exit Sub
        End Try
        '----------------------------------------------------------------------------------------------
        Me.lb_tabServer2_FTPVerzeichnis.Refresh()
        'Me.lb_tabServer2_FTPVerzeichnis.Items.Clear()  'Lösche die bestehenden Directory aus der Liste
        'Lade die neuen Verzeichnisse rein
        Me.lb_tabServer2_FTPVerzeichnis.DataSource = FTPVerzeichnis
    End Sub

    Private Sub b_tabServer2_OrdnerHinzufügen_Click(sender As Object, e As EventArgs) _
        Handles b_tabServer2_OrdnerHinzufügen.Click
        'Beschreibung:      Erstellt einen neuen FTP Ordner im aktuelle Verzeichnis

        'Erstellungdatum :  11.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ermittle welches den gewünschten OrdnerName
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim Name As String = frmInputBox.StarteEingabeFenster()
        If Name = "" Then Exit Sub
        '---------------------------------------------------------------
        ftp.FtpCreateDirectory(ftp._lastDirectory & "/" & Name)

        Try
            Dim AnzahlVerzeichnisse As Integer = ftp.ListDirectory("/" & ftp._lastDirectory).Count
            ReDim FTPVerzeichnis(AnzahlVerzeichnisse)
            FTPVerzeichnis = ftp.ListDirectory("/" & ftp._lastDirectory).ToArray
        Catch ex As Exception
            MessageBox.Show("Es ist ein Fehler aufgetreten." & vbCrLf & vbCrLf & ex.Message.ToString)
            Exit Sub
        End Try
        Me.lb_tabServer2_FTPVerzeichnis.DataSource = FTPVerzeichnis
        Me.lb_tabServer2_FTPVerzeichnis.Refresh()

    End Sub



    Private Sub b_tabServer2_OrdnerLöschen_Click(sender As Object, e As EventArgs) _
        Handles b_tabServer2_OrdnerLöschen.Click
        'Beschreibung:      Löscht FTP Ordner im aktuelle Verzeichnis

        'Erstellungdatum :  11.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ermittle welcher Ordner gelöscht werden soll
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim strOrdner As String = Me.lb_tabServer2_FTPVerzeichnis.SelectedItem.ToString
        '------------------------------------------------------------------------------
        'Falls in keinem Verzeichnis schicke eine Warnung raus
        If lbl_tabServer2_Pfad.Text = "Aktueller Pfad" Then
            strOrdner = "/" & strOrdner
        End If
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Öffne die Sicherheitsabfrage
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        If frmInputBox.LöscheOrdner(strOrdner) = True Then
            MessageBox.Show("ICH LÖSCHE")
        End If

    End Sub

    Private Sub b_tabServer2_HomeButton_Click(sender As Object, e As EventArgs) _
        Handles b_tabServer2_HomeButton.Click
        'Beschreibung:      Weil ich das FTP Browsen noch nicht sauber hin bekommen habe
        '                   habe ich diesen Button erstellt.
        '                   Er navigiert einfach in das root Verzeichnis

        'Erstellungdatum :  13.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Ermittle welcher Ordner gelöscht werden soll
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        Try
            Dim AnzahlVerzeichnisse As Integer = ftp.ListDirectory("/").Count
            ReDim FTPVerzeichnis(AnzahlVerzeichnisse)
            FTPVerzeichnis = ftp.ListDirectory("/").ToArray
        Catch ex As Exception
            MessageBox.Show("Es ist ein Fehler aufgetreten." & vbCrLf & vbCrLf & ex.Message.ToString)
            Exit Sub
        End Try
        '----------------------------------------------------------------------------------------------
        Me.lb_tabServer2_FTPVerzeichnis.Refresh()
        Me.lb_tabServer2_FTPVerzeichnis.DataSource = FTPVerzeichnis
        '----------------------------------------------------------------------------------------------
        'Setze Pfad in das Label
        '----------------------------------------------------------------------------------------------
        Me.lbl_tabServer2_Pfad.Text = "/"
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) _
        Handles b_tabServer2_UploadPfadÜbernehmen.Click
        'Beschreibung:      Zeigt das ausgewählte Upload Verzeichnis in einem Label an welches sich
        '                   in einem Panel verbirgt. Das Panel wird auf sichtbar geschaltet.

        'Erstellungdatum :  13.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Passe den Pfad an und ergänze SBB als Ordner Name
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Dim strOrdner As String = ftp._lastDirectory
        '------------------------------------------------------------------------------
        If lbl_tabServer2_Pfad.Text = "Aktueller Pfad" Then
            strOrdner = "/" & strOrdner / "SBB"
        End If
        '------------------------------------------------------------------------------
        'Panel sichtbar machen und den Endgültigen Pfad anzeigen
        '------------------------------------------------------------------------------
        Me.lbl_AusgewähltesUploadVerzeichnis.Text = strOrdner 'Pfad anzeigen
        Me.p_tabServer2_UploadVerzeichnis.Visible = True
    End Sub


    Private Sub b_tabServer1_WeiterZuFtpVerzeichnis_Click_1(sender As Object, e As EventArgs) _
        Handles b_tabServer1_WeiterZuFtpVerzeichnis.Click
        'Beschreibung:      Es wird der "tabServer2" aktiviert und der dort befindliche DataGrid wird mit den 
        '                   FTP Directory gefüllt.

        'Erstellungdatum :  10.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Füge die Directory in den DataGrid
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Me.lb_tabServer2_FTPVerzeichnis.DataSource = FTPVerzeichnis
        '----------------------------------------------------------------------------------------------
        'Wechsel die TabPage
        '----------------------------------------------------------------------------------------------
        TabControl1.SelectedTab = tabServer2
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    End Sub

    Private Sub b_tabServer2_WeiterZuMySQL_Click(sender As Object, e As EventArgs) _
        Handles b_tabServer2_WeiterZuMySQL.Click
        'Beschreibung:      Dieser Button erscheint nur wenn das Upload Verzeichnis ausgewählt worden ist.
        '                   Daraufhin wird das Upload Verzeichnis in den APP Einstellungen gespreichert.
        '                   Es wird das tabServer3 geladen damit die MySQL DB erstellt werden kann.

        'Erstellungdatum :  13.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Speichern der Einstellung und wechsel der tabServer Page
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        My.Settings.FTPUpload = Me.lbl_AusgewähltesUploadVerzeichnis.Text
        My.Settings.Save()
        '-----------------------------------------------------------------
        TabControl1.SelectedTab = tabMySQL1
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    End Sub


#End Region


#End Region

#Region "WarteKreis"

    Private Sub SetAnyLabel(ByVal txt As Bunifu.Framework.UI.BunifuCustomLabel, ByVal s As String, Sichtbar As Boolean)
        If Sichtbar = True Then
            txt.Visible = True
        End If

        If Sichtbar = False Then
            txt.Visible = False
            Exit Sub
        End If

        txt.Text = s
        txt.Refresh()
    End Sub

    Private Sub WarteKreis(ByVal Wert As Integer)
        '// Dort wo es aufgrufen werden soll:
        Dim d As New dlgSetAnyListbox(AddressOf SetAnyListbox)
        '// Zum eintragen:
        On Error Resume Next

        Invoke(d, circle_Wait, Wert, True)

    End Sub

    Private Sub ThreadCirrcle()
        Dim Wert As Integer = 0
VonVorne:
        For i = 0 To 100
            WarteKreis(i)
            Thread.Sleep(100)
        Next
        WarteKreis(0)
        GoTo VonVorne

    End Sub

    Private Sub SetAnyListbox(ByVal tb As Bunifu.Framework.UI.BunifuCircleProgressbar, ByVal i As Integer, sichtbar As Boolean)
        If sichtbar = False Then
            tb.Visible = False
            Exit Sub
        End If

        tb.Value = i
        tb.Refresh()
    End Sub

#End Region

#Region "Allgemeine Funktionen"








#End Region

#Region "mySQL_Connection"

    Private Sub b_tabMySQL1_PrüfeMySQLConnection_Click(sender As Object, e As EventArgs) _
        Handles b_tabMySQL1_PrüfeMySQLConnection.Click
        mysql = New cMySQL With {._mySQL_DataBase = Me.txt_tabMySQL1_Database.text, _
                                      ._mySQL_Password = Me.txt_tabMySQL1_Password.text, _
                                      ._MySQL_Server = Me.txt_tabMySQL1_ServerAdresse.text, _
                                      ._MySQL_User = Me.txt_tabMySQL1_User.text, _
                                      ._mySQL_PORT = Me.txt_tabMySQL1_Port.text}

        'Beschreibung:      Prüfe ob die mySQL Datenbank erreichbar ist.
        '                   Damit der Warten Kreis startet wird hierfür ein eigener Thread verwendet

        'Erstellungdatum :  13.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '**********************************************************************************************
        'Prüfe ob alle Eingaben gemacht worden sind
        '**********************************************************************************************
        If Me.txt_tabMySQL1_User.text = "" Then
            SMS("Bitte Benutzername eingeben", "Fehlender Eintrag")
            Exit Sub
        End If
        '-------------------------------------------------------------
        If Me.txt_tabMySQL1_ServerAdresse.text = "" Then
            SMS("Bitte Serveradresse eingeben", "Fehlender Eintrag")
            Exit Sub
        End If
        '-------------------------------------------------------------
        If Me.txt_tabMySQL1_Password.text = "" Then
            SMS("Bitte Passwort eingeben", "Fehlender Eintrag")
            Exit Sub
        End If
        '-------------------------------------------------------------
        If Me.txt_tabMySQL1_Database.text = "" Then
            SMS("Bitte Datenbank Name eingeben", "Fehlender Eintrag")
            Exit Sub
        End If
        '**********************************************************************************************

        '**********************************************************************************************
        'Mache den Warte Kreis sichrbar und starte den Prozess in einem eigenen Thread
        '**********************************************************************************************
        Me.circle_Wait.Visible = True
        trdWarteKreis = New System.Threading.Thread(AddressOf ThreadCirrcle)
        trdWarteKreis.Start()
        '**********************************************************************************************

        '**********************************************************************************************
        'Starte die Prüfung der mySQL Datenbank in einem anderen Thread
        '**********************************************************************************************
        Dim trdDaten As New System.Threading.Thread(AddressOf PrüfeMySQLVerbindung)
        trdDaten.Start()
        '**********************************************************************************************


    End Sub


    Private Sub PrüfeMySQLVerbindung()
        Dim d As New glgSetBunifuLabel(AddressOf SetAnyLabel)
        'Setze die benötigten Connection Daten
        mysql.SetConnectionData()
        'Prüfe die Verbindung
        If mysql.HasConnection() = True Then
            My.Settings.mySQLPassword = Me.txt_tabMySQL1_Password.text
            My.Settings.mySQLServer = Me.txt_tabMySQL1_ServerAdresse.text
            My.Settings.mySQLUser = Me.txt_tabMySQL1_User.text
            My.Settings.myySQLPort = Me.txt_tabMySQL1_Port.text
            My.Settings.mySQLDatabase = Me.txt_tabMySQL1_Database.text
            'Speichere die Settings
            My.Settings.Save()
            '--------------------------------------------------------------------
            'Mache die erfolgreiche Verbindung sichtbar
            '--------------------------------------------------------------------
            Me.PictureBox2.BackgroundImage = My.Resources.ServerGrün
            Invoke(d, lbl_tabMySQL1_MySQLStatus, "mySQL Connection OK", True)
            '--------------------------------------------------------------------
            'Mache den WLAN Button sichtbar
            '--------------------------------------------------------------------
            Dim D4 As New glgSetBunifuButton(AddressOf setButton)
            Invoke(D4, Me.b_tabMySQL_WeiterZuWLAN, "TRUE")
            '--------------------------------------------------------------------
            GoTo CheckOK
        End If
        Me.PictureBox2.BackgroundImage = My.Resources.ServerRot
        Invoke(d, lbl_tabMySQL1_MySQLStatus, "mySQL Connection FAIL", True)

checkOK:
        Dim D2 As New dlgSetAnyListbox(AddressOf SetAnyListbox)
        Invoke(D2, circle_Wait, 0, False)
        trdWarteKreis.Abort()



    End Sub


    Private Sub b_tabMySQL_WeiterZuWLAN_Click(sender As Object, e As EventArgs) _
        Handles b_tabMySQL_WeiterZuWLAN.Click
        'Beschreibung:      Weiter zu den WLAN Einstellungen

        'Erstellungdatum :  13.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================
        My.Settings.mySQLPassword = Me.txt_tabMySQL1_Password.text
        My.Settings.mySQLServer = Me.txt_tabMySQL1_ServerAdresse.text
        My.Settings.mySQLUser = Me.txt_tabMySQL1_User.text
        My.Settings.myySQLPort = Me.txt_tabMySQL1_Port.text
        My.Settings.mySQLDatabase = Me.txt_tabMySQL1_Database.text

        If Me.cb_tabMySQL1_KeineMySQL_User_Prüfung.Checked = True Then
            My.Settings.mySQLNOCheck = "1"
        Else
            My.Settings.mySQLNOCheck = "0"
        End If

        'Speichere die Settings
        My.Settings.Save()
        '**********************************************************************************************
        'Wechsle in WLAN Tab
        '**********************************************************************************************
        TabControl1.SelectedTab = tabWLAN1
    End Sub

    Private Sub b_tabMySQL1_Zurück_Click(sender As Object, e As EventArgs) Handles b_tabMySQL1_Zurück.Click
        TabControl1.SelectedTab = tabServer2
    End Sub

#End Region

#Region "WLAN Settings"

    Private Sub b_tabWLAN1_WeiterZuController_Click(sender As Object, e As EventArgs) _
        Handles b_tabWLAN1_WeiterZuController.Click
        'Beschreibung:      Prüfe ob alle WLAN Eintragungen gemacht worden sind.
        '                   Speichere die Settings
        '                   Wechsle den Reiter

        'Erstellungdatum :  11.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '**********************************************************************************************
        'Prüfe die Eingabe
        '**********************************************************************************************
        If Me.txt_tabWLAN_WLANName.text = "" Then
            SMS("Bitte WLAN SSID eingeben", "Fehlende Eingabe")
            Exit Sub
        End If
        '--------------------------------------------------------
        If Me.txt_tabWLAN_Key.text = "" Then
            SMS("Bitte WLAN Schlüssel eingeben", "Fehlende Eingabe")
            Exit Sub
        End If
        '**********************************************************************************************
        'Speichere die Settings
        '**********************************************************************************************
        My.Settings.WLANSSID = Me.txt_tabWLAN_WLANName.text
        My.Settings.WLANKEY = Me.txt_tabWLAN_Key.text
        My.Settings.Save()
        '**********************************************************************************************
        'Wechsle in Controler Tab
        '**********************************************************************************************
        TabControl1.SelectedTab = tabController1
        '**********************************************************************************************
    End Sub

    Private Sub b_tabWLAN_Zurück_Click(sender As Object, e As EventArgs) Handles b_tabWLAN_Zurück.Click
        TabControl1.SelectedTab = tabMySQL1
    End Sub

    Private Sub b_tabWlan_Suche_Wlan_Click(sender As Object, e As EventArgs) Handles b_tabWlan_Suche_Wlan.Click
        Prüfe_WLAN_Verbindung()
    End Sub

    Public Function GetWLANKey() As String


        Dim info As New ProcessStartInfo
        ' Hide window
        info.WindowStyle = ProcessWindowStyle.Hidden
        info.FileName = "cmd.exe"
        info.Arguments = "/c netsh wlan show profile name=" & _
            Me.txt_tabWLAN_WLANName.text & " key=clear | findstr Schlüssel > C:\Temp\W-LAN-Key.txt"
        Process.Start(info)

        Application.DoEvents()
        Threading.Thread.Sleep(1000) ' 500 milliseconds = 0.5 seconds

        Dim objReader As New StreamReader("C:\Temp\W-LAN-Key.txt")
        Dim sLine As String = ""
        Dim arrText As New ArrayList()

        Do
            sLine = objReader.ReadLine()
            If Not sLine Is Nothing Then
                arrText.Add(sLine)
            End If
        Loop Until sLine Is Nothing
        objReader.Close()

        Dim WlanKey As String = ""

        For Each sLine In arrText
            'Console.WriteLine(sLine)
            If InStr(1, sLine, ":") Then
                Dim strTemp As String = ""
                strTemp = Mid(sLine, 1, InStr(1, sLine, ":"))
                Dim AnzahlZeichen As Integer = Len(strTemp)
                WlanKey = Microsoft.VisualBasic.Right(sLine, Len(sLine) - AnzahlZeichen).Trim
                Try
                    File.Delete("C:\Temp\W-LAN-Key.txt")
                Catch ex As Exception

                End Try


                Return WlanKey
            Else
                MsgBox("Das Zeichen : ist nicht vorhanden")
            End If

        Next
    End Function



    Private Function Prüfe_WLAN_Verbindung() As Boolean
        Dim wlan = New WlanClient()
        Dim connectedSsids As Collection(Of [String]) = New Collection(Of String)()
        Dim WLAN_Name As String = ""

        Try
            For Each wlanInterface As WlanClient.WlanInterface In wlan.Interfaces
                Dim ssid As Wlan.Dot11Ssid = wlanInterface.CurrentConnection.wlanAssociationAttributes.dot11Ssid
                connectedSsids.Add(New [String](Encoding.ASCII.GetChars(ssid.SSID, 0, CInt(ssid.SSIDLength))))

                For Each item As String In connectedSsids
                    WLAN_Name = item
                Next
                'netsh wlan show profile name="NAME" key=clear | findstr Schlüssel > %userprofile%\Desktop\W-LAN-Key.txt
            Next
            ''CONTINUE ON FROM HERE.
        Catch ex As Exception

        End Try


        If WLAN_Name = "" Then
            Me.lbl_tabWLAN1_WLANStatus.Text = "Es konnte keine WLAN Verbindung gefunden werden"
            Me.lbl_tabWLAN1_WLANStatus.ForeColor = Color.Red
            Return False
        Else
            Me.lbl_tabWLAN1_WLANStatus.Text = "Verbunden mit WLAN:"
            Me.lbl_tabWLAN1_WLANStatus.ForeColor = Color.Green
            Me.txt_tabWLAN_WLANName.text = WLAN_Name
            Me.txt_tabWLAN_Key.text = GetWLANKey()
        End If
        Return True
    End Function

#End Region

#Region "Controller"

    Private Sub b_tabController1_ControllerV1_Click(sender As Object, e As EventArgs) _
        Handles b_tabController1_ControllerV1.Click
        'Beschreibung:      Wechsle die Controller Version auf V1

        'Erstellungdatum :  14.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================
        Me.lbl_tabController1_Controller_Auswahl.Text = "WeMos D1 mini"

    End Sub

    Private Sub b_tabController1_ControllerV2_Click(sender As Object, e As EventArgs) _
        Handles b_tabController1_ControllerV2.Click
        'Beschreibung:      Wechsle die Controller Version auf V2

        'Erstellungdatum :  14.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================
        'Me.lbl_tabController1_Controller_Auswahl.Text = "WeMos Lua"
        MessageBox.Show("Noch keine Funktion", "Fehlendes Modul", _
                        MessageBoxButtons.OK, _
                        MessageBoxIcon.Information)
    End Sub

    Private Sub b_tabController1_Weiter_Click(sender As Object, e As EventArgs) _
        Handles b_tabController1_Weiter.Click
        'Beschreibung:      Prüfe ob alle Angaben gemacht worden sind.
        '                   Speichere die Settings
        '                   Gehe zum nächsten Schritt              

        'Erstellungdatum :  14.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================


        '**********************************************************************************************
        'Prüfe ob alle Eingaben getätigt wurden
        '**********************************************************************************************
        'API-Passwort
        If Me.txt_tabController1_API_Password.text = "" Then
            SMS("Bitte das API-Passwort eingeben")
            Exit Sub
        End If
        '-----------------------------------------------------------------
        'Web Seiten HOST Adresse
        If Me.txt_tabController1_Host.text = "" Then
            SMS("Bitte den HOST Namen eingeben z.B.: meineAdresse.de")
            Exit Sub
        End If
        '-----------------------------------------------------------------
        If Me.txt_tabController1_HTTP_port.text = "" Then
            SMS("Bitte HTTP Port eingeben")
            Exit Sub
        End If
        '-----------------------------------------------------------------
        If Me.txt_tabController1_Intervall_Abfrage.text = "" Then
            SMS("Bitte Abfrage Intervall Eingeben")
            Exit Sub
        End If
        '-----------------------------------------------------------------
       
        '**********************************************************************************************


        '**********************************************************************************************
        'Speichern der Settings
        '**********************************************************************************************
        My.Settings.Controller_Host = Me.txt_tabController1_Host.text
        My.Settings.Controller_HTTP_Port = Me.txt_tabController1_HTTP_port.text
        My.Settings.Controller_Interval = Me.txt_tabController1_Intervall_Abfrage.text
        My.Settings.ControllerAPIPassword = Me.txt_tabController1_API_Password.text
        My.Settings.Controller_URL = Me.txt_tabController1_URL.text
        If Me.lbl_tabController1_Controller_Auswahl.Text = "WeMos D1 mini" Then
            My.Settings.ControllerVersion = "V1"
        End If
        My.Settings.Save()
        '---------------------------------------------------------------------------------------------
        TabControl1.SelectedTab = tabDownload
    End Sub



    Private Sub PanelAnimaton() Handles b_tabController1_ControllerV1.Click, b_tabController1_ControllerV2.Click
        Do Until Panel5.Height = 0
            Panel5.Height = Panel5.Height - 20
            Refresh()
        Loop
    End Sub

#End Region

#Region "Download"


    Private Function PrüfeServerVersionenAusGithub() As Array

        '----------------------------------------------------------------------------------------------
        'Versuche aus GitHub die aktuellen Versionen zu ermitteln
        '----------------------------------------------------------------------------------------------
        Dim strVersionen As String = String.Empty
        Dim iWebServer As Integer = 0
        Dim iController As String = 0
        Dim strWords() As String = Nothing



        Using web = New Net.WebClient() With {.Proxy = Nothing, .Encoding = Encoding.Default}
            Try
                strVersionen = web.DownloadString("https://raw.githubusercontent.com/SmartBudBox/Smart-Bud-Box/master/UPDATE/Version.txt")
            Catch ex As Exception
                MessageBox.Show("Es konnte keine Verbindung zum Server hergestellt werden" & vbCrLf & ex.Message.ToString)
                GoTo KeineVerbindung
            End Try
            strWords = strVersionen.Split(New String() {},
                     StringSplitOptions.RemoveEmptyEntries)

            'iWebServer = Mid(strWords(0), 6)
            'iController = Mid(strWords(1), 13)
            strWords(0) = Mid(strWords(0), 6)
            strWords(1) = Mid(strWords(1), 13)
        End Using
        ''----------------------------------------------------------------------------------------------
        ''Speichere das Ergebnnis in die Settings
        ''----------------------------------------------------------------------------------------------
        'My.Settings.Version_Server = iWebServer
        'My.Settings.Version_Controller = iController
        'My.Settings.Save()

        Versionen = strWords


        Dim Label As New glgSetBunifuLabel(AddressOf SetAnyLabel)
        Invoke(Label, lbl_tabServer1_FTPStatus, "", True)

        'Beschrifte auf jeden Fall die Server Versionen Labels
        'Me.lbl_tabDownload_SVWeb.Text = Versionen(0)
        Invoke(Label, lbl_tabDownload_SVWeb, Versionen(0), True)
        'Me.lbl_tabDownload_SVController.Text = Versionen(1)
        Invoke(Label, lbl_tabDownload_SVController, Versionen(1), True)


        If My.Settings.Version_Server <> "" Then
            'Wenn was in den Settings steht bedeutet das, dass es wohlmöglich ein Update ist
            'Me.lbl_tabDownload_LVWeb.Text = My.Settings.Version_Server
            'Me.lbl_tabDownload_LVController.Text = My.Settings.Version_Controller

            Invoke(Label, lbl_tabDownload_LVWeb, My.Settings.Version_Server, True)
            Invoke(Label, lbl_tabDownload_LVController, My.Settings.Version_Controller, True)
        End If
        '--------------------------------------------------------------------
        If Versionen(0) > My.Settings.Version_Server Then
            Invoke(Label, lbl_tabDownload_Server_Status, "Es ist eine neue Version verfügbar", True)
            'Me.lbl_tabDownload_Server_Status.Text = "Es ist eine neue Version verfügbar"
            'Me.lbl_tabDownload_Server_Status.ForeColor = Color.Red
            ServerUpdate = True
        Else
            'Me.lbl_tabDownload_Server_Status.Text = "Lokale Version ist aktuell"
            Invoke(Label, lbl_tabDownload_Server_Status, "Lokale Version ist aktuell", True)
            ' Me.lbl_tabDownload_Server_Status.ForeColor = Color.Green
        End If
        '--------------------------------------------------------------------
        If Versionen(1) > My.Settings.Version_Controller Then
            'Me.lbl_tabDownload_Controller_Status.Text = "Es ist eine neue Version verfügbar"
            Invoke(Label, lbl_tabDownload_Controller_Status, "Es ist eine neue Version verfügbar", True)
            ' Me.lbl_tabDownload_Controller_Status.ForeColor = Color.Red
            ControllerUpdate = True
        Else
            'Me.lbl_tabDownload_Controller_Status.Text = "Lokale Version ist aktuell"
            Invoke(Label, lbl_tabDownload_Controller_Status, "Lokale Version ist aktuell", True)
            Me.lbl_tabDownload_Controller_Status.ForeColor = Color.Green
        End If
        '********************************************************************

KeineVerbindung:

        Dim D2 As New dlgSetAnyListbox(AddressOf SetAnyListbox)
        Invoke(D2, circle_Wait, 0, False)
        trdWarteKreis.Abort()

        Dim DButton As New glgSetBunifuButton(AddressOf setButton)
        If ServerUpdate = True Or ControllerUpdate = True Then
            Invoke(DButton, b_tabDownload_StarteDownload, "TRUE")
        End If

        Return strWords
    End Function



    Private Sub b_tabDownload_StarteDownload_Click(sender As Object, e As EventArgs) Handles b_tabDownload_StarteDownload.Click
        'Beschreibung:      Startet aufgrund zuvor ermittelten Parameter den Datei Download

        'Erstellungdatum :  20.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Dieser Bereich wird erst einmal DEAKTIVIERT 
        'Grundsätzlich Funktioniert der Upload aber hier durch die Einschränkungen kaum Nutzbar
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'mache den Ablauf sichtbar
        Me.txt_tabDownload_AblaufStatus.Visible = True

        'Starte den Warte Kreis in einem anderen Thread
        trdWarteKreis = New System.Threading.Thread(AddressOf ThreadCirrcle)
        trdWarteKreis.Start()

        Try
            Directory.Delete(Application.StartupPath & "\Download", True)
        Catch ex As Exception
            Directory.CreateDirectory(Application.StartupPath & "\Download")
        End Try
        If StarteDateiDownload(ServerUpdate, ControllerUpdate) = False Then
            AM("Download Fehlgeschlagen")
            GoTo Ausgang
        End If
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        If ServerUpdate = True Then
            If UploadWebServer() = False Then
                AM("Web Server Upload fehlgeschlagen")
                GoTo Ausgang
            End If

            If My.Settings.mySQLNOCheck = "0" Then
                AM("Erstelle die mySQL Tabellen")
                ErstelleMySQL_DB_V1()
            Else
                AM("MySQL Datenbank bitte selbst erstellen")
                MessageBox.Show("Bitte nicht vergessen die MySQL DB zu erstellen", "MySQL Datenbank", MessageBoxButtons.OK)
            End If
           
        End If



        AM("")
        AM("Downloads, WebServer und Controller Einstellungen abgeschlossen." & vbCrLf & "Bitte weiter zum nächsten Schritt")
        '-----------------------------------------------------------------------------------------------
        'Mach den weiter Button sichtbar
        '-----------------------------------------------------------------------------------------------
        Me.b_tabDownload_Weiter_zum_Flashen.Visible = True
        Me.b_tabDownload_StarteDownload.Visible = False

Ausgang:
        ' trdWarteKreis.Start()
    End Sub


    Private Function StarteDateiDownload(ByVal Server As Boolean, ByVal Controller As Boolean) As Boolean
        'Beschreibung:      Startet aufgrund zuvor ermittelten Parameter den Datei Download

        'Erstellungdatum :  20.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Prüfe ob das Download Verzeichnis vorhanden ist. Fall ja lösche es damit wir sicher sind das
        'keine alten Versionen drin sind. Falls Nein dann erstelle eins
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Directory.CreateDirectory(Application.StartupPath & "\Download")

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        If My.Settings.ControllerVersion = "V1" Then

            If Server = True Then
                AM("Starte Download : WebServer Datei")
                Dim strServerLink As String = _
                    "https://github.com/SmartBudBox/Smart-Bud-Box/raw/master/UPDATE/WEB_V" & Me.lbl_tabDownload_SVWeb.Text & ".zip"
                Dim strServerZiel As String = Application.StartupPath & "\Download\Web.zip"
                If dwlByLink(strServerLink, strServerZiel) = False Then
                    AM("Installation abgebrochen")
                    Return False
                End If
                AM("WebServer Download beendet")
            End If

            If Controller = True Then
                AM("Starte Download : Controller Firmware")
                Dim strServerLink As String = _
                    " https://raw.githubusercontent.com/SmartBudBox/Smart-Bud-Box/master/UPDATE/Controller_V" & Me.lbl_tabDownload_SVController.Text & ".bin"
                Dim strServerZiel As String = Application.StartupPath & "\Controller.bin"
                If dwlByLink(strServerLink, strServerZiel) = False Then
                    AM("Installation abgebrochen")
                    Return False
                End If
                AM("Firmware Download beendet")
                '---------------------------------------------------------------------------------------------------------------
                '---------------------------------------------------------------------------------------------------------------
                'Das wird nicht mehr gemacht weil, das Beschreiben der Daten nun über die Serielle Schnittstelle erledigt wird
                'passe die Firmware an
                'FirmwareAnpassen()
                '---------------------------------------------------------------------------------------------------------------
                '---------------------------------------------------------------------------------------------------------------
            End If
            Return True

        End If
        Return False
    End Function

    Public Function UploadWebServer() As Boolean


        '-------------------------------------------------------------------------------------------------------
        'Erstelle die Leere Datenbank aus den Ressourcen
        '-------------------------------------------------------------------------------------------------------
        warte(10)   'damit die Files nicht mehr im Speicher liegen


        If File.Exists(Application.StartupPath & "\WinSCP.exe") = False Then
            AM("Entpacke die WinSCP Daten")
            Try
                Dim binaryw As New IO.BinaryWriter(New IO.FileStream(Application.StartupPath & "\WinSCP.exe", IO.FileMode.Create))
                binaryw.Write(My.Resources.WinSCP)
                '-------------------------------------------------------------------------------------------------------
                'Erstelle das Datenbank Import Tool aus den Ressourcen
                '-------------------------------------------------------------------------------------------------------
                binaryw.Close()

                warte(5)
                binaryw.Close()
                AM("WinSCP.exe erfolgreich")
            Catch ex As Exception

            End Try

            Try
                Dim binaryw2 As New IO.BinaryWriter(New IO.FileStream(Application.StartupPath & "\WinSCPnet.dll", IO.FileMode.Create))
                binaryw2.Write(My.Resources.WinSCPnet)
                '-------------------------------------------------------------------------------------------------------
                'Erstelle das Datenbank Import Tool aus den Ressourcen
                '-------------------------------------------------------------------------------------------------------
                binaryw2.Close()

                warte(5)
                binaryw2.Close()
                AM("WINSCP DLL erfolgreich")
            Catch ex As Exception

            End Try

        End If




        Try
            '----------------------------------------------------------------------------
            'Versuche die Datei zu entpacken
            '----------------------------------------------------------------------------
            AM("Entpacke WebServer Daten")
            ZipFile.ExtractToDirectory(Application.StartupPath & "\Download\Web.zip", Application.StartupPath & "\Download\WebServer")
            AM("WebServer Daten entpackt")
            '----------------------------------------------------------------------------
            'Passe die config.inc.php an
            '----------------------------------------------------------------------------
            AM("Ändere die Settings vom Web Server")
            Dim path As String = Application.StartupPath & "\Download\WebServer\config.inc.php"

            ' Create or overwrite the file.
            Dim fs As FileStream = File.Create(path)

            Dim strdateiText As String = "<?php" & vbCrLf & vbCrLf _
                                         & "//date_default_timezone_set('Europe/Berlin');" & vbCrLf & vbCrLf _
                                         & "// MYSQL Logindaten" & vbCrLf _
                                         & "define(""MYSQL_SERVER"", " & """" & My.Settings.mySQLServer & """" & ");" & vbCrLf _
                                         & "define(""MYSQL_DB"", " & """" & My.Settings.mySQLDatabase & """" & ");" & vbCrLf _
                                         & "define(""MYSQL_USER"", " & """" & My.Settings.mySQLUser & """" & ");" & vbCrLf _
                                         & "define(""MYSQL_PASS"", " & """" & My.Settings.mySQLPassword & """" & ");" & vbCrLf _
                                         & "define(""MYSQL_PORT"", " & """" & My.Settings.myySQLPort & """" & ");" & vbCrLf _
                                         & vbCrLf _
                                         & vbCrLf _
                                         & "// URL Zur Webseite ohne Slashzeichen am Ende" & vbCrLf _
                                         & "define(""URL"", " & """" & My.Settings.Controller_URL & """" & ");" & vbCrLf _
                                         & "define(""PASSWORD"", " & """" & My.Settings.ControllerAPIPassword & """" & ");" & vbCrLf _
                                         & "define(""MAIL_ADRESS"", " & """" & "" & """" & ");" & vbCrLf _
                                         & vbCrLf & vbCrLf _
                                         & "define(""VERSION"", ""1.0"");" & vbCrLf _
                                         & "?>"



            ' Add text to the file.
            Dim info As Byte() = New UTF8Encoding(True).GetBytes(strdateiText)
            fs.Write(info, 0, info.Length)
            fs.Close()
            AM("Web Server Settings erfolgreich geändert")



            ' '' ''*********************************************************************************
            ' '' ''Wenn man den WebServer extern hosted und deshalb keinen Zugriff auf die MySQL DB hat passe ist es 
            ' '' ''notwendig die Datenbank intern zu erstellen
            ' '' ''*********************************************************************************
            '' ''AM("Ändere die Settings vom Web Server")
            '' ''Dim path2 As String = Application.StartupPath & "\Download\WebServer\install\index.php"

            ' '' '' Create or overwrite the file.
            '' ''Dim fs2 As FileStream = File.Create(path)

            '' ''Dim strdateiText2 As String = "<?php" & vbCrLf & vbCrLf _
            '' ''                             & "//date_default_timezone_set('Europe/Berlin');" & vbCrLf & vbCrLf _
            '' ''                             & "// MYSQL Logindaten" & vbCrLf _
            '' ''                             & "define(""MYSQL_SERVER"", " & """" & My.Settings.mySQLServer & """" & ");" & vbCrLf _
            '' ''                             & "define(""MYSQL_DB"", " & """" & My.Settings.mySQLDatabase & """" & ");" & vbCrLf _
            '' ''                             & "define(""MYSQL_USER"", " & """" & My.Settings.mySQLUser & """" & ");" & vbCrLf _
            '' ''                             & "define(""MYSQL_PASS"", " & """" & My.Settings.mySQLPassword & """" & ");" & vbCrLf _
            '' ''                             & "define(""MYSQL_PORT"", " & """" & My.Settings.myySQLPort & """" & ");" & vbCrLf _
            '' ''                             & vbCrLf _
            '' ''                             & vbCrLf _
            '' ''                             & "// URL Zur Webseite ohne Slashzeichen am Ende" & vbCrLf _
            '' ''                             & "define(""URL"", " & """" & My.Settings.Controller_Host & """" & ");" & vbCrLf _
            '' ''                             & "define(""PASSWORD"", " & """" & My.Settings.ControllerAPIPassword & """" & ");" & vbCrLf _
            '' ''                             & "define(""MAIL_ADRESS"", " & """" & "" & """" & ");" & vbCrLf _
            '' ''                             & vbCrLf & vbCrLf _
            '' ''                             & "define(""VERSION"", ""1.0"");" & vbCrLf _
            '' ''                             & "?>"
            ' '' ''*********************************************************************************
            ' '' ''*********************************************************************************


            ' '' '' Add text to the file.
            '' ''Dim info As Byte() = New UTF8Encoding(True).GetBytes(strdateiText)
            '' ''fs.Write(info, 0, info.Length)
            '' ''fs.Close()
            '' ''AM("Web Server Settings erfolgreich geändert")
            ' '' ''*********************************************************************************
            ' '' ''*********************************************************************************






            '----------------------------------------------------------------------------
            'Beginne mit FTP Upload
            '----------------------------------------------------------------------------
            'AM("Erstelle ZIP Datei")
            'ZipFile.CreateFromDirectory(Application.StartupPath & "\Download\WebServer", Application.StartupPath & "\Download\WebServer.zip")
            'AM("ZIP Datei wurde erstellt")
            AM("Beginne mit FTP Upload")
            warte(5)
            ftp.OrdnerUpload(Application.StartupPath & "\Download\WebServer", My.Settings.FTPUpload)
            AM("FTP Upload abgeschlossen")
            My.Settings.Version_Server = Me.lbl_tabDownload_SVWeb.Text
            My.Settings.Save()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            Return False
        End Try
        Return True
    End Function

    Public Function dwlByLink(myLink As String, myFile As String) As Boolean
        Try

            Dim myRequest As System.Net.WebRequest = System.Net.WebRequest.Create(myLink) 'Request erstellen
            myRequest.Proxy = Net.WebRequest.GetSystemWebProxy
            myRequest.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials
            Dim myResponse As System.Net.WebResponse = myRequest.GetResponse() 'Respons speichern
            Dim myStream As System.IO.Stream = myResponse.GetResponseStream() 'Datenstream aus dem Respons extrahieren
            Dim myReader As New System.IO.BinaryReader(myStream) 'Binärer "leser" zum Lesen des Streams




            'Datei speichern
            Dim myFileStream As New System.IO.FileStream(myFile, System.IO.FileMode.Create) 'Datei auswählen
            Dim i As Long


            For i = 1 To myResponse.ContentLength 'Byte für Byte in die Datei übertragen
                myFileStream.WriteByte(myReader.ReadByte())
            Next i
            myFileStream.Flush() 'noch mal spülen ...
            myFileStream.Close() ' und schließen
        Catch exc As Exception
            'Fehlerbehandlung, MSG-Box, ect ...
            MessageBox.Show(exc.Message.ToString)
            Return False
        End Try
        Return True
    End Function


    Public Sub AM(ByVal str As String)
        Me.txt_tabDownload_AblaufStatus.Text = Me.txt_tabDownload_AblaufStatus.Text & str & vbCrLf
        Me.txt_tabDownload_AblaufStatus.SelectionStart = Me.txt_tabDownload_AblaufStatus.Text.Length
        Me.txt_tabDownload_AblaufStatus.ScrollToCaret()
        Me.txt_tabDownload_AblaufStatus.Refresh()
    End Sub




    Private Function FirmwareAnpassen() As Boolean
        AM("Beginne mit Anpassung der Firmware")

        Dim objReader As New StreamReader(Application.StartupPath & "\Download\Controller.ino")
        Dim sLine As String = ""
        Dim arrText As New ArrayList()

        Do
            sLine = objReader.ReadLine()
            If Not sLine Is Nothing Then


                '------------------------------------------------------------------------------------------------------------
                'WLAN SSID
                '------------------------------------------------------------------------------------------------------------
                If sLine.Contains("const char* ssid =") Then
                    Dim strTemp As String = _
                        "const char* ssid = """ & My.Settings.WLANSSID & """; // name of your wlan ssid"
                    arrText.Add(strTemp)
                    AM("WLAN SSID: " & My.Settings.WLANSSID)
                    GoTo ManipulationOK
                End If
                '------------------------------------------------------------------------------------------------------------





                '------------------------------------------------------------------------------------------------------------
                'WLAN Schlüssel
                '------------------------------------------------------------------------------------------------------------
                If sLine.Contains("const char* pass =") Then
                    Dim strTemp As String = _
                        "const char* pass = """ & My.Settings.WLANKEY & """; // wlan wpa password or key for wep"
                    arrText.Add(strTemp)
                    AM("WLAN KEY: " & My.Settings.WLANKEY)
                    GoTo ManipulationOK
                End If
                '------------------------------------------------------------------------------------------------------------




                '------------------------------------------------------------------------------------------------------------
                'Web HOST
                '------------------------------------------------------------------------------------------------------------
                If sLine.Contains("const char* host =") Then
                    Dim strTemp As String = _
                        "const char* host = """ & My.Settings.Controller_Host & """; // hostname, ip adresses wont work, example: host.com"
                    arrText.Add(strTemp)
                    AM("WEB HOST: " & My.Settings.Controller_Host)
                    GoTo ManipulationOK
                End If
                '------------------------------------------------------------------------------------------------------------



                '------------------------------------------------------------------------------------------------------------
                'HTTP Port
                '------------------------------------------------------------------------------------------------------------
                If sLine.Contains("const int httpPort =") Then
                    Dim strTemp As String = _
                        "const int httpPort = " & My.Settings.Controller_HTTP_Port & "; // normalyy 80"
                    arrText.Add(strTemp)
                    AM("HTTP PORT: " & My.Settings.Controller_HTTP_Port)
                    GoTo ManipulationOK
                End If
                '------------------------------------------------------------------------------------------------------------


                '------------------------------------------------------------------------------------------------------------
                'Host URL
                '------------------------------------------------------------------------------------------------------------
                If sLine.Contains("const char* host_url =") Then
                    Dim strTemp As String = _
                        "const char* host_url = """ & My.Settings.FTPUpload & """; // folder without slash at end, example: /your/folder or blank for main dir"
                    arrText.Add(strTemp)
                    AM("HOST URL: " & My.Settings.FTPUpload)
                    GoTo ManipulationOK
                End If
                '------------------------------------------------------------------------------------------------------------


                '------------------------------------------------------------------------------------------------------------
                'api_password
                '------------------------------------------------------------------------------------------------------------
                If sLine.Contains("const char* api_password =") Then
                    Dim strTemp As String = _
                        "const char* api_password = """ & My.Settings.ControllerAPIPassword & """; // password for interface wich defined at config.inc.php"
                    arrText.Add(strTemp)
                    AM("API PASSWORD: " & My.Settings.ControllerAPIPassword)
                    GoTo ManipulationOK
                End If
                '------------------------------------------------------------------------------------------------------------


                '------------------------------------------------------------------------------------------------------------
                'sensor_submission_interval
                '------------------------------------------------------------------------------------------------------------
                If sLine.Contains("const long sensor_submission_interval =") Then
                    Dim strTemp As String = _
                        "const long sensor_submission_interval = " & My.Settings.Controller_Interval & "; // password for interface wich defined at config.inc.php"
                    arrText.Add(strTemp)
                    AM("ABFRAGE INTERVALL: " & My.Settings.Controller_Interval)
                    GoTo ManipulationOK
                End If
                '------------------------------------------------------------------------------------------------------------


                arrText.Add(sLine)
ManipulationOK:
            End If
        Loop Until sLine Is Nothing
        objReader.Close()

        Dim path As String = Application.StartupPath & "\Download\Firmware.ino"

        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)
        Dim info As Byte()
        For Each sLine In arrText
            info = New UTF8Encoding(True).GetBytes(sLine & vbCrLf)
            fs.Write(info, 0, info.Length)
        Next
        fs.Close()

        AM("Firmware Anpassung abgeschlossen")
        Return True

    End Function



    Private Sub lbl_tabDownload_Server_Status_TextChanged(sender As Object, e As EventArgs) Handles lbl_tabDownload_Server_Status.TextChanged
        If lbl_tabDownload_Server_Status.Text = "Es ist eine neue Version verfügbar" Then
            lbl_tabDownload_Server_Status.ForeColor = Color.Red
        Else
            lbl_tabDownload_Server_Status.ForeColor = Color.Green
        End If
    End Sub

    Private Sub lbl_tabDownload_Controller_Status_TextChanged(sender As Object, e As EventArgs) Handles lbl_tabDownload_Controller_Status.TextChanged
        If lbl_tabDownload_Controller_Status.Text = "Es ist eine neue Version verfügbar" Then
            lbl_tabDownload_Controller_Status.ForeColor = Color.Red
        Else
            lbl_tabDownload_Controller_Status.ForeColor = Color.Green
        End If
    End Sub

    Private Sub b_tabDownload_Weiter_zum_Flashen_Click(sender As Object, e As EventArgs) Handles b_tabDownload_Weiter_zum_Flashen.Click
        'Übergebe die bisherigen Eintragungen der neuen Textbox
        Me.txt_tabFlash1_Status.Text = Me.txt_tabDownload_AblaufStatus.Text
        AM2("")
        AM2("")

        '**********************************************************************************************
        'Wechsle in Controler Tab
        '**********************************************************************************************
        TabControl1.SelectedTab = tabFlash1
        '**********************************************************************************************
    End Sub

#End Region




    Private Sub AM2(ByVal str As String)
        Me.txt_tabFlash1_Status.Text = Me.txt_tabFlash1_Status.Text & str & vbCrLf
        Me.txt_tabFlash1_Status.SelectionStart = Me.txt_tabFlash1_Status.Text.Length
        Me.txt_tabFlash1_Status.ScrollToCaret()
        Me.txt_tabFlash1_Status.Refresh()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        MessageBox.Show("Bisher ohne Funktion")
    End Sub


    Private Sub b_TabFlash1_Starte_FlashVorgang_Click(sender As Object, e As EventArgs) Handles b_TabFlash1_Starte_FlashVorgang.Click
        'Beschreibung:      Starte den Flash Vorgang.
        '                   Im Moment nicht implementiert aber in Zukunft soll vorher geprüft werden
        '                   ob der Controller mit einer selbstausgesuchten Firmware geflasht werden soll
        '                   oder mit der automatisch herunter geladenen.

        'Erstellungdatum :  21.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '**********************************************************************************************
        If Me.b_TabFlash1_Starte_FlashVorgang.ButtonText = "Installiere Treiber" Then

            Me.txt_tabFlash1_Status.Visible = True
            AM2("Microcontroller Vorbereitung zum Flashen")


            '**********************************************************************************************
            'Treiber installieren für Microcontroller
            '**********************************************************************************************
            '--------------------------------------------------------
            'Hier der Bereiche für den WeMOS D1 mini
            '--------------------------------------------------------
            If My.Settings.ControllerVersion = "V1" Then
                AM2("Starte externes Programm für Treiber installation")
                Try
                    Dim binaryw As New IO.BinaryWriter(New IO.FileStream(Application.StartupPath & "\CH341SER.EXE", IO.FileMode.Create))
                    binaryw.Write(My.Resources.CH341SER)
                    binaryw.Close()

                    'warte(5)
                    binaryw.Close()
                    AM("Treiber erfolgreich entpackt")
                Catch ex As Exception

                End Try
                '--------------------------------------------------------
                'Starte das Hersteller Programm für die Treiber Installation
                '--------------------------------------------------------
                InstalliereWeMosTreiber()


                '--------------------------------------------------------

                Me.b_TabFlash1_Starte_FlashVorgang.ButtonText = "Starte Flash Vorgang"



                Exit Sub

            End If

        End If


        If Me.b_TabFlash1_Starte_FlashVorgang.ButtonText = "Starte Flash Vorgang" Then

            'Gebe den Hinweis das der Controller jetzt per USB angeschlossen werden muss
            '--------------------------------------------------------
            Me.lbl_tabFlash1_Anweisungen.Text = "Bitte den Controller JETZT per USB anschliessen"
            Me.lbl_tabFlash1_Anweisungen.ForeColor = Color.Red
            Me.Refresh()


            'Dim aa() As String = System.IO.Ports.SerialPort.GetPortNames()
            Dim AnzahlPorts As Integer = System.IO.Ports.SerialPort.GetPortNames.Count
            Dim AnzahlPortsNachSchleife As Integer = 0
            Me.pb_tabFlash1_ProgressBar.Visible = True
            Me.pb_tabFlash1_ProgressBar.Maximum_Value = 100
            For i = 1 To 100
                AnzahlPortsNachSchleife = System.IO.Ports.SerialPort.GetPortNames.Count
                If AnzahlPorts < AnzahlPortsNachSchleife Then
                    Me.b_TabFlash1_Starte_FlashVorgang.ForeColor = Color.Red
                    Me.lbl_tabFlash1_Anweisungen.Text = "Bitte den richtigen COM Port auswählen!"
                    Me.pb_tabFlash1_ProgressBar.Visible = False
                    GoTo EndeSchleife
                End If
                Me.pb_tabFlash1_ProgressBar.Value = Me.pb_tabFlash1_ProgressBar.Value + 1
                Me.pb_tabFlash1_ProgressBar.Refresh()
                warte(1)
            Next
            AM("Es konnte kein Controlle gefunden werden")
            Me.lbl_tabFlash1_Anweisungen.Text = "Starten Sie den Vorgang neu!"
            Exit Sub
EndeSchleife:
            '---------------------------------------------------------------------------------
            'Fülle die ComboBox mit den vorhandenen Ports aus
            Me.cb_tabFlash1_COM_Ports.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames())
            Me.panelComPort.Visible = True
        End If
        '--------------------------------------------------------
        '********************************************************



    End Sub

    Private Function InstalliereWeMosTreiber() As Boolean
        Try
            Dim myPath As String = "CH341SER.exe"
            Dim pr As New Process
            pr.StartInfo.FileName = myPath
            pr.StartInfo.Arguments = "/S"
            pr.Start()
        Catch ex As Exception
            AM2(ex.Message.ToString)
            MessageBox.Show(ex.Message.ToString)
            Return False
        End Try

        AM2("Treiber erfolgreich installiert?")
        Return True
    End Function




    Private Sub cb_tabFlash1_COM_Ports_MouseClick(sender As Object, e As MouseEventArgs) Handles cb_tabFlash1_COM_Ports.MouseClick
        Me.b_TabFlash1_Burn.Visible = True
    End Sub

    Private Sub b_TabFlash1_Burn_Click(sender As Object, e As EventArgs) Handles b_TabFlash1_Burn.Click
        'Beschreibung:      Brennt die Controller Firmware

        'Erstellungdatum :  25.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '**********************************************************************************************
        'Erstelle die Binary Datei ESP
        '----------------------------------------------------------------------------------------------
        AM2("FLASH Tool wird vorbereitet")
        Dim binaryw As New IO.BinaryWriter(New IO.FileStream(Application.StartupPath & "\esptool.exe", IO.FileMode.Create))
        binaryw.Write(My.Resources.esptool)
        binaryw.Close()
        AM2("FLASH Tool warte bis Binary CLOSE")
        warte(5)
        binaryw.Close()
        '----------------------------------------------------------------------------------------------
        Dim process As New Process
        process.StartInfo.FileName = "esptool.exe"
        'process.StartInfo.UserName = Environment.UserName
        process.StartInfo.Arguments = "-vv -cd nodemcu -cb 115200 -cp COM4 -ca 0x00000 -cf Controller.bin"  'der/die Parameter
        'process.StartInfo.WorkingDirectory = """" & Application.StartupPath & "\Download\" & """"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.ErrorDialog = False
        process.StartInfo.RedirectStandardOutput = False
        process.Start()
        'wait for exit
        process.WaitForExit()

        '***************************************************************************************
        'Beginne mit der Seriellen übertragung der Credentials
        '***************************************************************************************
        'COM PORT übergeben


        'lbl_tabFlash1_Anweisungen.Text = "Bitte den Controller vom PC trennen"

        'Dim AnzahlPorts As Integer = System.IO.Ports.SerialPort.GetPortNames.Count
        'Dim AnzahlPortsNachSchleife As Integer = 0
        'Me.pb_tabFlash1_ProgressBar.Visible = True
        'Me.pb_tabFlash1_ProgressBar.Maximum_Value = 100
        'For i = 1 To 100
        '    AnzahlPortsNachSchleife = System.IO.Ports.SerialPort.GetPortNames.Count
        '    If AnzahlPorts > AnzahlPortsNachSchleife Then
        '        Me.b_TabFlash1_Starte_FlashVorgang.ForeColor = Color.Red
        '        Me.lbl_tabFlash1_Anweisungen.Text = "Controller wieder anschliessen!"
        '        'b_tabFlash1_Sende_Credentials.Visible = True
        '        Me.Refresh()
        '        ControllerWiederAnschliessen()


        '        GoTo EndeSchleife
        '    End If
        '    warte(1)
        'Next
EndeSchleife:


        My.Settings.Version_Controller = Me.lbl_tabDownload_SVController.Text
        My.Settings.Save()

        b_TabFlash1_Burn.Visible = False
        b_tabFlash1_Sende_Credentials.Visible = True

    End Sub


    Private Sub ControllerWiederAnschliessen()

        Dim AnzahlPorts As Integer = System.IO.Ports.SerialPort.GetPortNames.Count
        Dim AnzahlPortsNachSchleife As Integer = 0
        Me.pb_tabFlash1_ProgressBar.Visible = True
        Me.pb_tabFlash1_ProgressBar.Maximum_Value = 100
        For i = 1 To 100
            AnzahlPortsNachSchleife = System.IO.Ports.SerialPort.GetPortNames.Count
            If AnzahlPorts < AnzahlPortsNachSchleife Then
                Me.b_TabFlash1_Starte_FlashVorgang.ForeColor = Color.Red
                Me.lbl_tabFlash1_Anweisungen.Text = "Controller wieder anschliessen!"
                Me.pb_tabFlash1_ProgressBar.Visible = False
                b_tabFlash1_Sende_Credentials.Visible = True
                b_TabFlash1_Burn.Visible = False

                GoTo EndeSchleife
            End If
            warte(1)
        Next
EndeSchleife:
    End Sub

    Delegate Sub myMethodDelegate(ByVal [text] As String)
    Dim myD1 As New myMethodDelegate(AddressOf myShowStringMethod)

    Sub myShowStringMethod(ByVal myString As String)
        txt_tabFlash1_Status.AppendText(myString)
        txt_tabFlash1_Status.Refresh()
    End Sub

    Private Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Dim str As String = SerialPort.ReadExisting
        Invoke(myD1, str)
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
        'SerialPort.Handshake = IO.Ports.Handshake.None
        SerialPort.Parity = IO.Ports.Parity.None
        '----->  Now change the Encoding to enable 8-bit communications:  <-----
        'SerialPort.Encoding = System.Text.Encoding.GetEncoding(1252)
        SerialPort.Open()
    End Sub

    Dim inputData As String = ""
    Public Event DataReceived As IO.Ports.SerialDataReceivedEventHandler


    

    Private Sub b_tabFlash1_Sende_Credentials_Click(sender As Object, e As EventArgs) Handles b_tabFlash1_Sende_Credentials.Click

        SPSetup()
        If SerialPort.IsOpen Then

            AM2("Sende SSID")
            SerialPort.Write("SSID" & My.Settings.WLANSSID.Trim & vbCr)
            'SerialPort.Write(vbCr)
            Thread.Sleep(2000)

            AM2("Sende KEY")
            SerialPort.Write("PASS" & My.Settings.WLANKEY.Trim & vbCr)
            Thread.Sleep(2000)

            AM2("Sende HOST")
            SerialPort.Write("HOST" & My.Settings.Controller_Host.Trim & vbCr)
            Thread.Sleep(2000)

            AM2("Sende PORT")
            SerialPort.Write("HTTP" & My.Settings.Controller_HTTP_Port.Trim & vbCr)
            Thread.Sleep(2000)

            AM2("Sende URL")
            SerialPort.Write("URL" & My.Settings.Controller_URL.Trim & vbCr)
            Thread.Sleep(2000)

            AM2("Sende Passwort")
            SerialPort.Write("API" & My.Settings.ControllerAPIPassword.Trim & vbCr)
            Thread.Sleep(2000)

            AM2("Sende Intervall")
            SerialPort.Write("SEN" & My.Settings.Controller_Interval.Trim & vbCr)
            Thread.Sleep(2000)


        Else
            SPSetup()

            SerialPort.Write("SSID" & My.Settings.WLANSSID.Trim & vbCr)
            'SerialPort.Write(vbCr)
            Thread.Sleep(2000)


            SerialPort.Write("PASS" & My.Settings.WLANKEY.Trim & vbCr)
            Thread.Sleep(2000)


            SerialPort.Write("HOST" & My.Settings.Controller_Host.Trim & vbCr)
            Thread.Sleep(2000)


            SerialPort.Write("HTTP" & My.Settings.Controller_HTTP_Port.Trim & vbCr)
            Thread.Sleep(2000)


            SerialPort.Write("URL" & My.Settings.Controller_URL.Trim & vbCr)
            Thread.Sleep(2000)


            SerialPort.Write("API" & My.Settings.ControllerAPIPassword.Trim & vbCr)
            Thread.Sleep(2000)


            SerialPort.Write("SEN" & My.Settings.Controller_Interval.Trim & vbCr)
            Thread.Sleep(2000)
        End If

        AM2("")
        AM2("")
        AM2("Viel Spaß mit der Smart Bud Box")

        SerialPort.Close()

        warte(5)
        Application.Exit()
    End Sub

   


    Private Sub ConnectSerial()
        Try
            SerialPort.BaudRate = 115200
            SerialPort.PortName = selPort
            SerialPort.Open()
        Catch
            SerialPort.Close()
        End Try
    End Sub



    Private Sub cb_tabFlash1_COM_Ports_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_tabFlash1_COM_Ports.SelectedIndexChanged
        selPort = cb_tabFlash1_COM_Ports.Text
        'SPSetup()
    End Sub

  

  

 
   
   
    Private Sub cb_tabMySQL1_KeineMySQL_User_Prüfung_OnChange(sender As Object, e As EventArgs) Handles cb_tabMySQL1_KeineMySQL_User_Prüfung.OnChange
        If Me.cb_tabMySQL1_KeineMySQL_User_Prüfung.Checked = True Then
            Me.b_tabMySQL_WeiterZuWLAN.Visible = True
        Else
            Me.b_tabMySQL_WeiterZuWLAN.Visible = False
        End If
    End Sub
End Class