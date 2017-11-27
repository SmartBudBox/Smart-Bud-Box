Imports System.Security
Imports System.Security.Principal
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms


Public Class Impersonator



    Dim LOGON32_LOGON_INTERACTIVE As Integer = 2
    Dim LOGON32_PROVIDER_DEFAULT As Integer = 0
    '
    Private Declare Function LogonUserA Lib "advapi32.dll" (ByVal lpxzUsername As String, _
                                            ByVal lpszDomain As String, _
                                            ByVal lpszpassword As String, _
                                            ByVal dwLogonType As Integer, _
                                            ByVal dwLogonProvider As Integer, _
                                            ByRef phToken As IntPtr) As Integer
    Private Declare Auto Function DuplicateToken Lib "advapi32.dll" ( _
                                            ByVal ExistingTokenHandle As IntPtr, _
                                            ByVal ImpersonationLevel As Integer, _
                                            ByRef DuplicateTokenHandle As IntPtr) As Integer
    Private Declare Auto Function RevertToSelf Lib "advapi32.dll" () As Long
    '
    Private Declare Auto Function CloseHandle Lib "Kernel32.dll" (ByVal handle As IntPtr) As Long
    '
    Dim impersonationContext As WindowsImpersonationContext

    Public Function ImpersonateValidUser(ByVal userName As String, _
       ByVal domain As String, ByVal password As String) As Boolean
        Dim tempWindowsIdentity As WindowsIdentity
        Dim token As IntPtr = IntPtr.Zero
        Dim tokenDuplicate As IntPtr = IntPtr.Zero
        ImpersonateValidUser = False
        '

        Try
            If RevertToSelf() Then
                If LogonUserA(userName, domain, password, LOGON32_LOGON_INTERACTIVE, _
                    LOGON32_PROVIDER_DEFAULT, token) <> 0 Then
                    If DuplicateToken(token, 2, tokenDuplicate) <> 0 Then
                        tempWindowsIdentity = New WindowsIdentity(tokenDuplicate)
                        impersonationContext = tempWindowsIdentity.Impersonate()
                        If Not impersonationContext Is Nothing Then
                            ImpersonateValidUser = True
                        End If
                    End If
                End If
            End If
            '
            If Not tokenDuplicate.Equals(IntPtr.Zero) Then
                CloseHandle(tokenDuplicate)
            End If
            '
            If Not token.Equals(IntPtr.Zero) Then
                CloseHandle(token)
            End If
            ''
        Catch ex As Exception
            Throw New ApplicationException("User not found in the server or incorrect password. User Name: " + userName + " Domain: " + domain, ex)
        End Try
    End Function
    '
    Public Sub UndoImpersonation()
        impersonationContext.Undo()
    End Sub

End Class


'-----------------------------------------------------------------------------------------------------------------------------------------------------------
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'Der eigentliche Filemanager mit Zugriff auf Impersonate
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
Public Class FileManager

    Friend Shared Function ApplicationPath() As String
        Return _
        Path.GetDirectoryName([Assembly].GetExecutingAssembly().Location)
    End Function


    Friend Shared Sub LogMessage(ByVal Message As String)

        Dim SolutionName As String = Assembly.GetExecutingAssembly.GetName.Name

        Try
            ' Datei öffen (Text anhängen)
            Dim oStream As IO.StreamWriter = System.IO.File.AppendText(ApplicationPath() & "\" & SolutionName & ".LOG")

            '' Datum und Uhrzeit autom. eintragen
            'oStream.WriteLine(Now)

            ' Message (Fehlermeldung) speicherrn
            oStream.WriteLine(DateTime.Now.ToString & "-" & Message & vbCrLf)

            ' Datei schließen
            oStream.Close()

        Catch ex As Exception

        End Try
    End Sub



    Public Shared ursUsername As String = ""
    Public Shared ursDomain As String = ""
    Public Shared ursPassword As String = ""

    Public Shared Sub SetUserData(ByVal UserName As String, ByVal Domain As String, ByVal Password As String)
        ursUsername = UserName
        ursDomain = Domain
        ursPassword = Password
    End Sub


    Public Shared Function Impersonate(ByVal objImpersonator As Impersonator) As Boolean
        Dim flag As Boolean = objImpersonator.ImpersonateValidUser(ursUsername, ursDomain, ursPassword)
        Return flag
    End Function

    Friend Shared Sub CopyFile(ByVal sourcePath As String, ByVal destinationPath As String)
        Try
            Dim objImpersonator As Impersonator = New Impersonator()
            If (Not FileManager.Impersonate(objImpersonator)) Then
                Throw New ApplicationException("share user not found.")
            Else
                If (File.Exists(destinationPath)) Then
                    File.Delete(destinationPath)
                End If


                File.Copy(sourcePath, destinationPath)
                objImpersonator.UndoImpersonation()
                Return
            End If
        Catch ex As Exception
            LogMessage("Filemanager-Copyfile - " & ex.Message & "   SourcePath: " & sourcePath & "  Destination: " & destinationPath)
        End Try
    End Sub


    Friend Shared Function CopyDirectory(ByVal sourcePath As String, ByVal destinationPath As String) As Boolean
        Try
            Dim objImpersonator As Impersonator = New Impersonator()
            If (Not FileManager.Impersonate(objImpersonator)) Then
                Throw New ApplicationException("share user not found.")
            Else

                If File.Exists(destinationPath) = False Then
                    CreateDirectoryWithoutDeleting(destinationPath)
                End If

                My.Computer.FileSystem.CopyDirectory(sourcePath, destinationPath)
                objImpersonator.UndoImpersonation()
                Return True
            End If
        Catch ex As Exception
            LogMessage("Filemanager-CopyDirectory - " & ex.Message)
            Return False
        End Try
    End Function

    Friend Shared Function CopyFilesWithMaxOLD(ByVal DaysReturn As Integer, ByVal sourcePath As String, ByVal destinationPath As String) As Boolean
        Try
            Dim objImpersonator As Impersonator = New Impersonator()
            If (Not FileManager.Impersonate(objImpersonator)) Then
                Throw New ApplicationException("share user not found.")
            Else

                If File.Exists(destinationPath) = False Then
                    CreateDirectoryWithoutDeleting(destinationPath)
                End If


                Dim Files = System.IO.Directory.GetFiles(sourcePath)

                For Each filename In Files
                    Dim Fi = New System.IO.FileInfo(filename)
                    If Fi.LastWriteTime > DateTime.Now.AddDays(DaysReturn) Then
                        'If Fi.CreationTime > DateTime.Now.AddDays(DaysReturn) Then
                        If File.Exists(destinationPath & Fi.Name) Then GoTo Vorhanden
                        File.Copy(sourcePath & Fi.Name, destinationPath & Fi.Name)
Vorhanden:
                    End If
                Next



                objImpersonator.UndoImpersonation()
                Return True
            End If
        Catch ex As Exception
            LogMessage("Filemanager-CopyFilesWithMaxOLD - " & ex.Message)
            Return False
        End Try
    End Function

    Friend Shared Sub DeleteDirectoryFiles(ByVal DirectoryPath As String)
        Try
            Dim objImpersonator As Impersonator = New Impersonator()
            If (Not FileManager.Impersonate(objImpersonator)) Then
                Throw New ApplicationException("share user not found.")
            Else
                Dim Files = System.IO.Directory.GetFiles(DirectoryPath)

                For Each Filename In Files
                    Dim FI = New System.IO.FileInfo(Filename)
                    FI.Delete()
                Next
                objImpersonator.UndoImpersonation()
                Return
            End If
        Catch ex As Exception
            LogMessage("Filemanager-DeleteDirectoryFiles - " & ex.Message)
        End Try
    End Sub


    Friend Shared Sub CreateDirectoryWithoutDeleting(ByVal filePath As String)
        Try
            Dim objImpersonator As Impersonator = New Impersonator()
            If (Not FileManager.Impersonate(objImpersonator)) Then
                Throw New ApplicationException("share user not found.")
            Else
                If (Directory.Exists(filePath)) Then

                Else
                    Directory.CreateDirectory(filePath)
                    objImpersonator.UndoImpersonation()
                End If

                Return
            End If
        Catch ex As Exception
            LogMessage("Filemanager-CreateDirectoryWithoutDeleting - " & ex.Message)
        End Try
    End Sub


    Friend Shared Sub CreateDirectoryWithDeleting(ByVal filePath As String)
        Try
            Dim objImpersonator As Impersonator = New Impersonator()
            If (Not FileManager.Impersonate(objImpersonator)) Then
                Throw New ApplicationException("share user not found.")
            Else
                If (Directory.Exists(filePath)) Then
                    Directory.Delete(filePath, True)
                End If
                Directory.CreateDirectory(filePath)
                objImpersonator.UndoImpersonation()
                Return
            End If
        Catch ex As Exception
            LogMessage("Filemanager-CreateDirectoryWithDeleting - " & ex.Message)
        End Try
    End Sub

    Friend Shared Sub CreateFile(ByVal filePath As String, ByVal fileBytes As Byte())
        Try
            Dim objImpersonator As Impersonator = New Impersonator()
            If (Not FileManager.Impersonate(objImpersonator)) Then
                Throw New ApplicationException("share user not found.")
            Else
                If (File.Exists(filePath)) Then
                    File.Delete(filePath)
                End If
                File.WriteAllBytes(filePath, fileBytes)
                objImpersonator.UndoImpersonation()
                Return
            End If
        Catch ex As Exception
            LogMessage("Filemanager-CreateFile - " & ex.Message)
        End Try
    End Sub


    Friend Shared Function ReadFileBytes(ByVal filePath As String) As Byte()
        Dim objImpersonator As Impersonator = New Impersonator()
        Dim fileBytes As Byte() = Nothing
        Dim numArray As Byte() = fileBytes

        Try

            If (Not FileManager.Impersonate(objImpersonator)) Then
                Throw New ApplicationException("share user not found.")
            Else
                If (File.Exists(filePath)) Then
                    fileBytes = File.ReadAllBytes(filePath)
                End If
                objImpersonator.UndoImpersonation()

                Return numArray
            End If
        Catch ex As Exception
            LogMessage("Filemanager-ReadFileBytes - " & ex.Message)
        End Try

        Return numArray

    End Function


End Class