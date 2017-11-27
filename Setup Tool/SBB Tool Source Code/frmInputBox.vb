Public Class frmInputBox

    Dim ButtonStatus As String = ""

    Private Sub b_EXIT_Click(sender As Object, e As EventArgs) Handles b_EXIT.Click
        Me.Close()
    End Sub

    Private Sub b_Übernehmen_Click(sender As Object, e As EventArgs) Handles b_Übernehmen.Click
        Me.Close()
    End Sub

    Public Function StarteEingabeFenster() As String
        Me.ShowDialog()
        Dim Name As String = txt_Wert.Text
        Return Name
        Me.Close()
    End Function


    Public Function LöscheOrdner(ByVal Pfad As String) As Boolean
        Me.txt_Wert.Visible = False
        Me.lbl_Anzeige.Text = "Möchten sie den Ordner:" & vbCrLf & Pfad & vbCrLf & "Wirklich Löschen?"
        lbl_Anzeige.Font = New Font(lbl_Anzeige.Font.FontFamily, 12)
        Me.ShowDialog()
        If ButtonStatus = "JA" Then
            Return True
        Else
            Return False
        End If
        Me.Close()
    End Function

    Private Sub b_JA_Click(sender As Object, e As EventArgs) Handles b_JA.Click
        ButtonStatus = "JA"
    End Sub

    Private Sub b_Nein_Click(sender As Object, e As EventArgs) Handles b_Nein.Click
        ButtonStatus = "NEIN"
    End Sub
End Class