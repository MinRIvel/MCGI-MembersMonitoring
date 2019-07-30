Imports System.ComponentModel
Public NotInheritable Class Splash
    Public BGW As BackgroundWorker = New BackgroundWorker
    Private Function CreateAccessDatabase(ByVal DatabaseFullPath As String) As Boolean
        Dim bAns As Boolean
        Dim cat As New ADOX.Catalog()
        Try
            Dim sCreateString As String
            sCreateString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & DatabaseFullPath
            cat.Create(sCreateString)
            bAns = True
        Catch Excep As Runtime.InteropServices.COMException
            bAns = False
        Finally
            cat = Nothing
        End Try
        Return bAns
    End Function

    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BGW.WorkerSupportsCancellation = True
        BGW.WorkerReportsProgress = True
        AddHandler BGW.DoWork, AddressOf BGW_DoWork
        AddHandler BGW.ProgressChanged, AddressOf BGW_ProgressChanged
        AddHandler BGW.RunWorkerCompleted, AddressOf BGW_RunWorkerCompleted

        Control.CheckForIllegalCrossThreadCalls = False

        BGW.RunWorkerAsync()
    End Sub
    Dim sqlquery As String
    Private Sub BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            For i = 0 To 100
                If i = 10 Then
                    If IO.File.Exists(Application.StartupPath & "\mcgidb.accdb") Then
                        Splash_Lbl.Text = "Checking tables."
                    Else
                        Splash_Lbl.Text = "Creating database."
                        CreateAccessDatabase(Application.StartupPath & "\mcgidb.accdb")
                        'code for creating tables
                        sqlquery = ""
                    End If
                End If
                Threading.Thread.Sleep(100)
                BGW.ReportProgress(i)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace)
        End Try
    End Sub

    Private Sub BGW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Try
            Splash_Progress.Value = e.ProgressPercentage
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace)
        End Try
    End Sub

    Private Sub BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Try
            If e.Error IsNot Nothing Or e.Cancelled = True Then
                'If BackgroundWorker Then terminated due To Error
                'reset_here()
            Else
                Login.Show()
                Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace)
        End Try
    End Sub
End Class
