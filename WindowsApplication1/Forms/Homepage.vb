Imports System.Data.OleDb
Imports System.ComponentModel
Public Class Homepage
    Dim sqlQuery As String
    Public BGW As BackgroundWorker = New BackgroundWorker
    Private TODO, TODO_MODE, SearchStr As String
    Private Sub reset_here()
        Body_Pnl.Enabled = True
        LoadingPB2.Visible = False
        ''COUNTER_TODO = 0
        sql_Transaction_result = Nothing
        TODO_MODE = Nothing
        'ObjectSender = Nothing
    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            WindowState = FormWindowState.Maximized
            BGW.WorkerSupportsCancellation = True
            BGW.WorkerReportsProgress = True
            AddHandler BGW.DoWork, AddressOf BGW_DoWork
            AddHandler BGW.ProgressChanged, AddressOf BGW_ProgressChanged
            AddHandler BGW.RunWorkerCompleted, AddressOf BGW_RunWorkerCompleted

            'sqlQuery = "Select  *
            '            From    Member_Information
            '            Where   Last_name like @SearchStr"
            'GET_QUERY("Get_MI", sqlQuery, "%b%")
            'KryptonDataGridView1.DataSource = msBindingSource
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case TODO
                Case "Load"
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BGW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim if_left As Boolean = True

    Private Sub Side_Btn_Click(sender As Object, e As EventArgs) Handles Side_Btn.Click
        If if_left = True Then
            if_left = False
            Side_Btn.BackgroundImage = My.Resources.icons8_double_right_30
            Side_Pnl.Visible = True
            Homepage_Split.SplitterDistance = 30
        ElseIf if_left = False Then
            if_left = True
            Side_Btn.BackgroundImage = My.Resources.icons8_double_left_30
            Side_Pnl.Visible = False
            Homepage_Split.SplitterDistance = 244
        End If
    End Sub

    Private Sub EP_Split_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles Homepage_Split.SplitterMoved
        If e.SplitX = 30 Then
            if_left = False
            Side_Btn.BackgroundImage = My.Resources.icons8_double_right_30
            Side_Pnl.Visible = True
        ElseIf e.SplitX > 30 Then
            if_left = True
            Side_Btn.BackgroundImage = My.Resources.icons8_double_left_30
            Side_Pnl.Visible = False
        End If

    End Sub
End Class
