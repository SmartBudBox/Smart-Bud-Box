Imports System.Threading
Imports System.Globalization
Imports mysql.Data.MySqlClient

Public Class cMySQL
   


    Public _MySQL_Server As String = ""
    Public _MySQL_User As String = ""
    Public _mySQL_Password As String = ""
    Public _mySQL_DataBase As String = ""
    Public _mySQL_PORT As String = ""


    Dim ServerVerbindung As String = ""

    Public SQLcon As New MySqlConnection With _
       {.ConnectionString = ServerVerbindung}


    'Public SQLcmd As New Odbc.OdbcCommand
    Public SQLcmd As New MySqlCommand

    'Public SQLRead As Odbc.OdbcDataReader
    Public SQLRead As MySqlDataReader

    'Public daODBCDatadapter As New Odbc.OdbcDataAdapter
    Public daODBCDatadapter As New MySqlDataAdapter

    Public strSQLcmd As String


    Public Sub SetConnectionData()
        ServerVerbindung = "server=" & _MySQL_Server & ";user id=" & _MySQL_User & ";password=" & _mySQL_Password _
            & ";database=" & _mySQL_DataBase & ";port=" & _mySQL_PORT & ""
    End Sub


    Public Function HasConnection() As Boolean

        Try
            If mySQLConnectionOpen() = False Then
                Return False
            End If
            mySQLConnectionClose()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function



    Public Function mySQLConnectionOpen() As Boolean

        Try
            SQLcon.ConnectionString = ServerVerbindung
            SQLcmd.Connection = SQLcon
            SQLcon.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Fehler Objekte erstellen")
            Return False
        End Try

    End Function

    Public Sub mySQLConnectionClose()
        'Diese Function schliesst die Datenbankverbindung zu Prodis
        SQLcon.Close()
    End Sub

    Public Function Lese(ByVal SQLBefehel As String) As Long
        Dim Ergebnis As Long

        SQLcmd.CommandText = SQLBefehel
        SQLRead = SQLcmd.ExecuteReader()
        SQLRead.Read()

        Try
            Ergebnis = CLng(SQLRead("IP_TREND_VALUE"))
        Catch ex As Exception
            'MsgBox(ex.Message)

        End Try


        SQLRead.Close()
        Return Ergebnis

    End Function

    Public Function strLese(ByVal SQLBefehel As String) As String
        Dim Ergebnis As String = ""

        SQLcmd.CommandText = SQLBefehel
        SQLRead = SQLcmd.ExecuteReader()
        SQLRead.Read()

        Try
            Ergebnis = CStr(SQLRead("IP_INPUT_VALUE"))
        Catch ex As Exception
            'MsgBox(ex.Message)

        End Try


        SQLRead.Close()
        Return Ergebnis

    End Function

    Public Function Rechne(ByVal Wert1 As Long, ByVal Wert2 As Long) As Long
        'Diese kleine Funktion berechnet einfach aus zweit werten die Differenz.
        Dim Ergebnis As Long
        Ergebnis = Wert1 - Wert2
        Return Ergebnis
    End Function




    Public Function SQLBefehl(ByVal queryString As String) As Boolean
        mySQLConnectionOpen()
        Try
            'Schreibe den gelieferten Befehl "queryString" in die Datenbank
            'Using SQLCon As New Odbc.OdbcConnection(SQLCon.ConnectionString)

            'Dim command As New Odbc.OdbcCommand(queryString, SQLcon)
            Dim command As New MySqlCommand(queryString, SQLcon)

            'Dim reader As Odbc.OdbcDataReader = command.ExecuteReader()
            Dim reader As MySqlDataReader = command.ExecuteReader()
            reader.Close()

            SQLcon.Close()
            Return True
        Catch ex As Exception
            frmInstall.AM(ex.Message.ToString)
            If ex.Message.Contains("Duplicate entry") = True Then

                'Duplikat = True
            End If
            SQLcon.Close()
            Return False
            Exit Function
        End Try
        'MessageBox.Show("Vorgang erfolgreich", "Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Function

   

End Class

