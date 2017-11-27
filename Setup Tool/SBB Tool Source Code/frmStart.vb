Imports System.IO


Public Class frmStart







    Private Sub b_EXIT_Click(sender As Object, e As EventArgs) Handles b_EXIT.Click
        'Beschreibung:      Beendet die Applikation

        'Erstellungdatum :  10.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Beendet die Applikation
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Application.Exit()
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    End Sub

    Private Sub b_NeuInstall_Click(sender As Object, e As EventArgs) Handles b_NeuInstall.Click
        'Beschreibung:      Startet die komplette Installation :
        '                   WebServer
        '                   Controller

        'Erstellungdatum :  10.11.2017
        'Ersteller:         GioGrow
        'Version:           1

        'Änderungen:
        '==============================================================================================

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'Öffne die frmNeuInstallation
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        'frmNeuInstallation.ShowDialog()
        frmInstall.Show()
    End Sub


  
   
   
End Class
