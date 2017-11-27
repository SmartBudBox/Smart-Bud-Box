Imports System.IO
Imports System.Reflection

Namespace My

    ' Für MyApplication sind folgende Ereignisse verfügbar:
    ' 
    ' Startup: Wird beim Starten der Anwendung noch vor dem Erstellen des Startformulars ausgelöst.
    ' Shutdown: Wird nach dem Schließen aller Anwendungsformulare ausgelöst. Dieses Ereignis wird nicht ausgelöst, wenn die Anwendung nicht normal beendet wird.
    ' UnhandledException: Wird ausgelöst, wenn in der Anwendung ein Ausnahmefehler auftritt.
    ' StartupNextInstance: Wird beim Starten einer Einzelinstanzanwendung ausgelöst, wenn diese bereits aktiv ist. 
    ' NetworkAvailabilityChanged: Wird beim Herstellen oder Trennen der Netzwerkverbindung ausgelöst.
    Partial Friend Class MyApplication


        Friend Function ApplicationPath() As String
            Return _
            Path.GetDirectoryName([Assembly].GetExecutingAssembly().Location)
        End Function


        Private WithEvents Domaene As AppDomain = AppDomain.CurrentDomain

        Private Function Domaene_AssemblyResolve(ByVal sender As Object, ByVal args As System.ResolveEventArgs) As System.Reflection.Assembly Handles Domaene.AssemblyResolve
            If args.Name.Contains("Bunifu_UI_v1.5.3") Then
                Return System.Reflection.Assembly.Load(My.Resources.Bunifu_UI_v1_5_3)
            Else
                'Return Nothing
            End If

            If args.Name.Contains("ManagedWifi") Then
                Return System.Reflection.Assembly.Load(My.Resources.ManagedWifi)
            Else
                'Return Nothing
            End If

            'If args.Name.Contains("WinSCPnet") Then
            '    Return System.Reflection.Assembly.Load(My.Resources.WinSCPnet)
            'Else
            '    'Return Nothing
            'End If

            Return Nothing
        End Function


    End Class


End Namespace

