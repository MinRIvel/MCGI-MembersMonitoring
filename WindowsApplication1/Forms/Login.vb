Imports System.ComponentModel
Public Class Login

    Public BGW As BackgroundWorker = New BackgroundWorker
    Dim username, password As String
    Private Sub Start_BGW()
        Try
            If BGW.IsBusy <> True Then
                OK.Enabled = False
                Cancel.Enabled = False
                UsernameTextBox.Enabled = False
                PasswordTextBox.Enabled = False
                Forgot_Lnk.Enabled = False
                LoadingPB2.Visible = True
                BGW.RunWorkerAsync()
            Else
                MessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace)
        End Try
    End Sub

    Sub reset_here()
        OK.Enabled = True
        Cancel.Enabled = True
        UsernameTextBox.Enabled = True
        UsernameTextBox.Clear()
        PasswordTextBox.Enabled = True
        PasswordTextBox.Clear()
        Login_Lbl.Visible = False
        LoadingPB2.Visible = False
        Forgot_Lnk.Enabled = True
        UsernameTextBox.Focus()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BGW.WorkerSupportsCancellation = True
        BGW.WorkerReportsProgress = True
        AddHandler BGW.DoWork, AddressOf BGW_DoWork
        AddHandler BGW.ProgressChanged, AddressOf BGW_ProgressChanged
        AddHandler BGW.RunWorkerCompleted, AddressOf BGW_RunWorkerCompleted
    End Sub

    Private Sub BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try

            Login_QUERY(username, password)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace)
        End Try
    End Sub

    Private Sub BGW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace)
        End Try
    End Sub

    Private Sub BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Try
            If e.Error IsNot Nothing Or e.Cancelled = True Then
                'If BackgroundWorker Then terminated due To Error
                reset_here()
            Else
                If sql_Transaction_result = "Committed" Then
                    If User_Id <> Nothing Then
                        Hide()
                        reset_here()
                        Homepage.Show()
                    Else
                        reset_here()
                        Login_Lbl.Visible = True
                        Login_Lbl.Text = "Login failed! Please Try again"
                    End If
                Else
                    MessageBox.Show(Me, "Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    reset_here()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace)
        End Try
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        username = Trim(UsernameTextBox.Text)
        password = Trim(PasswordTextBox.Text)
        If username = Nothing Then
            Login_Lbl.Visible = True
            Login_Lbl.Text = "Please enter username"
        ElseIf password = Nothing Then
            Login_Lbl.Visible = True
            Login_Lbl.Text = "Please enter password"
        Else
            Login_Lbl.Visible = False
            Start_BGW()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
