﻿Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Imports ComponentFactory.Krypton.Toolkit
Imports System.ComponentModel
Imports MetroFramework

Public Class Homepage
    Dim Homepage_DGV As New KryptonDataGridView
    Public BGW As BackgroundWorker = New BackgroundWorker
    Private TODO, TODO_MODE, SearchStr, sqlQuery As String
    Dim ID_Number, Last_Name, First_Name, Middle_Name, Address, Contact_Number, Occupation, Skill,
        Baptized_By, Nagakay, Image_Location As String
    Dim Baptism_Date As Date
    Dim if_left As Boolean = True
    Private A_ID_list As ArrayList
    Private dgv_rowindex, A_id As Integer

    Private Sub reset_here()
        Body_Pnl.Enabled = True
        LoadingPB2.Visible = False
        sql_Transaction_result = Nothing
        TODO_MODE = Nothing
        Image_Location = ""
        Save_Btn.Style = MetroColorStyle.Black
        Save_Btn.Text = "Save"
        ID_Tbox.Style = MetroColorStyle.Red
        Lname_Tbox.Style = MetroColorStyle.Red
        Fname_Tbox.Style = MetroColorStyle.Red
        Address_Tbox.Style = MetroColorStyle.Red
        For Each ctrl In Left_Pnl.Controls
            If ctrl.GetType = GetType(Controls.MetroTextBox) Then
                ctrl.Clear()
            ElseIf ctrl.GetType = GetType(PictureBox) Then
                ctrl.Enabled = True
                ctrl.Image = WindowsApplication1.My.Resources.Resources.users
                ctrl.ImageLocation = Nothing
            End If
        Next
    End Sub
    Private Sub Start_BGW()
        Try
            If BGW.IsBusy <> True Then
                Body_Pnl.Enabled = False
                LoadingPB2.Visible = True
                BGW.RunWorkerAsync()
            Else
                MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace)
        End Try
    End Sub
    Sub right_arrows()
        if_left = False
        Side_Btn.BackgroundImage = My.Resources.icons8_double_right_30
        Side_Pnl.Visible = True
    End Sub
    Sub left_arrows()
        if_left = True
        Side_Btn.BackgroundImage = My.Resources.icons8_double_left_30
        Side_Pnl.Visible = False
    End Sub
    'Public Sub DrawString(ByVal sender As Object,
    '                      ByVal drawString As String,
    '                      ByVal senderWidth_X As Single,
    '                      ByVal senderHeight_Y As Single)
    '    Dim formGraphics As Graphics = sender.CreateGraphics()
    '    Dim drawFont As New Font("Arial", 10)
    '    Dim drawBrush As New SolidBrush(Color.Black)
    '    Dim drawFormat As New StringFormat
    '    formGraphics.DrawString(drawString, drawFont, drawBrush, senderWidth_X, senderHeight_Y, drawFormat)
    '    drawFont.Dispose()
    '    drawBrush.Dispose()
    '    formGraphics.Dispose()
    'End Sub
    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'WindowState = FormWindowState.Maximized
            DateTime_Lbl.Text = ""
            DateTime_Timer.Start()
            BGW.WorkerSupportsCancellation = True
            BGW.WorkerReportsProgress = True
            AddHandler BGW.DoWork, AddressOf BGW_DoWork
            AddHandler BGW.ProgressChanged, AddressOf BGW_ProgressChanged
            AddHandler BGW.RunWorkerCompleted, AddressOf BGW_RunWorkerCompleted

            Homepage_DGV.DataSource = homepageDGV_BS

            Directory.CreateDirectory(Application.StartupPath & "\Member_Images")
            Directory.CreateDirectory(Application.StartupPath & "\Report_Images")
            TODO = "LoadDGV"
            Start_BGW()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace)
        End Try
    End Sub

    Private Sub Clear_Btn_Click(sender As Object, e As EventArgs) Handles Clear_Btn.Click
        reset_here()
    End Sub

    Private Sub Cancel_Btn_Click(sender As Object, e As EventArgs) Handles Cancel_Btn.Click
        Save_Btn.Style = MetroColorStyle.Black
        Save_Btn.Text = "Save"
    End Sub

    Private Sub DateTime_Timer_Tick(sender As Object, e As EventArgs) Handles DateTime_Timer.Tick
        DateTime_Lbl.Text = Date.Now.ToString("MMMM dd, yyyy h:mm:ss tt")
    End Sub

    Private Sub Homepage_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged

    End Sub

    Private Sub Image_Pbox_Click(sender As Object, e As EventArgs) Handles Image_Pbox.Click
        Try
            If Image_OPFD.ShowDialog() = DialogResult.OK Then
                'Do things here, the path is stored in openFileDialog1.Filename
                'If no files were selected, openFileDialog1.Filename is ""  
                Image_Pbox.ImageLocation = Image_OPFD.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace)
        End Try
    End Sub

    Private Sub BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case TODO
                Case "LoadDGV"
                    sqlQuery = "Select   A_id
                                        ,ID_Number AS [ID NUMBER]
                                        ,Last_Name AS [LAST NAME]
                                        ,First_Name AS [FIRST NAME]
                                        ,Middle_Name AS [MIDDLE NAME]
                                        ,Address AS [ADDRESS]
                                        ,Contact_Number AS [CONTACT NUMBER]
                                        ,Occupation AS [OCCUPATION]
                                        ,Skill AS [SKILL]
                                        ,Baptism_Date AS [BAPTISM DATE]
                                        ,Baptized_By AS [BAPTIZED BY]
                                        ,Nagakay AS [NAG-AKAY]
                                        ,Image_Location
                                From    Member_Information
                                Where   (ID_Number Like @SearchStr
                                    or  Last_name like @SearchStr
                                    or  First_Name like @SearchStr
                                    or  Middle_Name like @SearchStr
                                    or  Address like @SearchStr
                                    or  Contact_Number like @SearchStr
                                    or  Occupation like @SearchStr
                                    or  Skill like @SearchStr
                                    or  Baptized_By like @SearchStr
                                    or  Nagakay like @SearchStr)
                                    and Row_Status = True
                                Order by A_id asc"
                    HOMEPAGE_QUERY(TODO, sqlQuery, SearchStr)
                    BGW.ReportProgress(0)

                Case "SaveTrans"
                    sqlQuery = "Insert into Member_Information  (A_id
                                                                ,Image_Location
                                                                ,ID_Number
                                                                ,Last_Name
                                                                ,First_Name
                                                                ,Middle_Name
                                                                ,Address
                                                                ,Contact_Number
                                                                ,Occupation
                                                                ,Skill
                                                                ,Baptism_Date
                                                                ,Baptized_By
                                                                ,Nagakay)
                                                        values  (@Max_ID
                                                                ,@Image_Location
                                                                ,@ID_Number
                                                                ,@Last_Name
                                                                ,@First_Name
                                                                ,@Middle_Name
                                                                ,@Address
                                                                ,@Contact_Number
                                                                ,@Occupation
                                                                ,@Skill
                                                                ,@Baptism_Date
                                                                ,@Baptized_By
                                                                ,@Nagakay)"
                    Dim sql2 As String = "SELECT iif(MAX(A_ID) is null,0,MAX(A_ID)) FROM Member_Information"
                    Get_QUERY(sql2)
                    HOMEPAGE_QUERY(TODO, sqlQuery,, ID_Number, Last_Name, First_Name, Middle_Name, Address, Contact_Number,
                                   Occupation, Skill, Baptism_Date, Baptized_By, Nagakay, Image_Location)

                Case "UpdateTrans"
                    sqlQuery = "Update  Member_Information
                                set      ID_Number      = @ID_Number
                                        ,Last_Name      = @Last_Name
                                        ,First_Name     = @First_Name
                                        ,Middle_Name    = @Middle_Name
                                        ,Address        = @Address
                                        ,Contact_Number = @Contact_Number
                                        ,Occupation     = @Occupation
                                        ,Skill          = @Skill
                                        ,Baptism_Date   = @Baptism_Date
                                        ,Baptized_By    = @Baptized_By
                                        ,Nagakay        = @Nagakay
                                where   A_id = @A_id"
                    HOMEPAGE_QUERY(TODO, sqlQuery,, ID_Number, Last_Name, First_Name, Middle_Name, Address, Contact_Number,
                                   Occupation, Skill, Baptism_Date, Baptized_By, Nagakay,, A_id)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace)
        End Try
    End Sub

    Private Sub BGW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Try
            Select Case TODO
                Case "LoadDGV"
                    If e.ProgressPercentage = 0 And (Not DGV_Pnl.Controls.Contains(Homepage_DGV)) Then
                        DGV_Properties(Homepage_DGV, "Homepage_DGV")
                        AddHandler Homepage_DGV.RowPostPaint, AddressOf DGV_RowPostPaint
                        AddHandler Homepage_DGV.CellMouseClick, AddressOf DGV_CellMouseClick
                        AddHandler Homepage_DGV.SelectionChanged, AddressOf DGV_SelectionChanged
                        DGV_Pnl.Controls.Add(Homepage_DGV)
                    End If
            End Select
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
                    Select Case TODO
                        Case "LoadDGV"
                            homepageDGV_BS.DataSource = msDataSet
                            homepageDGV_BS.DataMember = TODO
                            With Homepage_DGV
                                .DataSource = msBindingSource
                                .AllowUserToResizeColumns = False
                                .AllowUserToResizeRows = False
                                .Select()
                                .Columns("A_id").Visible = False
                                .Columns("Image_Location").Visible = False
                                .Columns("BAPTISM DATE").DefaultCellStyle.Format = "MMM. dd, yyyy"
                                .DefaultCellStyle.BackColor = Color.White
                                .RowsDefaultCellStyle.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
                                .MultiSelect = True
                                .ClearSelection()
                            End With
                            reset_here()
                            ID_Tbox.Focus()
                        Case "SaveTrans"
                            If Image_Pbox.ImageLocation <> Nothing Then
                                FileSystem.CopyFile(Image_Pbox.ImageLocation, Path.Combine(Application.StartupPath,
                                                                                           "Member_Images",
                                                                                           Image_Location), False)
                            End If
                            MetroMessageBox.Show(Me, "", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            TODO = "LoadDGV"
                            Start_BGW()

                        Case "UpdateTrans"
                            MetroMessageBox.Show(Me, "", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            TODO = "LoadDGV"
                            Start_BGW()
                    End Select
                Else
                    MetroMessageBox.Show(Me, "", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    reset_here()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace)
        End Try
    End Sub

    Private Sub DGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        rowpostpaint(sender, e)
    End Sub

    Private Sub DGV_SelectionChanged(sender As Object, e As EventArgs)
        Try
            Dim selectedItems As DataGridViewSelectedRowCollection = sender.SelectedRows
            A_ID_list = New ArrayList(selectedItems.Count)
            For Each selectedItem As DataGridViewRow In selectedItems
                A_ID_list.Add(selectedItem.Cells("A_id").Value.ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace)
        End Try
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            dgv_rowindex = e.RowIndex
            If e.Button = MouseButtons.Right Then
                If sender.SelectedRows.Count > 1 Then
                    EditToolStripMenuItem.Visible = False
                ElseIf sender.SelectedRows.Count = 1 Then
                    EditToolStripMenuItem.Visible = True
                End If
                Homepage_Cmenu.Show()
                Homepage_Cmenu.Location = New Point(MousePosition.X, MousePosition.Y)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace)
        End Try
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Try
            left_arrows()
            Homepage_Split.SplitterDistance = 260
            Save_Btn.Style = MetroColorStyle.Red
            Save_Btn.Text = "Update"
            Image_Pbox.Enabled = False
            With Homepage_DGV.Rows(dgv_rowindex)
                A_id = .Cells("A_id").Value
                ID_Tbox.Text = .Cells("ID NUMBER").Value.ToString
                Lname_Tbox.Text = .Cells("LAST NAME").Value.ToString
                Fname_Tbox.Text = .Cells("FIRST NAME").Value.ToString
                Mname_Tbox.Text = .Cells("MIDDLE NAME").Value.ToString
                Address_Tbox.Text = .Cells("ADDRESS").Value.ToString
                Contact_Tbox.Text = .Cells("CONTACT NUMBER").Value.ToString
                Work_Tbox.Text = .Cells("OCCUPATION").Value.ToString
                Skill_Tbox.Text = .Cells("SKILL").Value.ToString
                Baptism_DTP.Value = CDate(.Cells("BAPTISM DATE").Value.ToString)
                BaptizedBy_Tbox.Text = .Cells("BAPTIZED BY").Value.ToString
                NagAkay_Tbox.Text = .Cells("NAG-AKAY").Value.ToString
                Image_Pbox.ImageLocation = Application.StartupPath & "\Member_Images\" & .Cells("Image_Location").Value.ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace)
        End Try
    End Sub

    Private Sub Homepage_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            Save_Btn.PerformClick()
        End If
    End Sub

    Private Sub Save_Btn_Click(sender As Object, e As EventArgs) Handles Save_Btn.Click
        Try
            ID_Number = Trim(ID_Tbox.Text)
            Last_Name = Trim(Lname_Tbox.Text)
            First_Name = Trim(Fname_Tbox.Text)
            Middle_Name = Trim(Mname_Tbox.Text)
            Address = Trim(Address_Tbox.Text)
            Contact_Number = Trim(Contact_Tbox.Text)
            Occupation = Trim(Work_Tbox.Text)
            Skill = Trim(Skill_Tbox.Text)
            Baptism_Date = Baptism_DTP.Value
            Baptized_By = Trim(BaptizedBy_Tbox.Text)
            Nagakay = Trim(NagAkay_Tbox.Text)
            Image_Location = Image_Pbox.ImageLocation

            Dim red_occur As Integer = 0
            For Each ctrl In Left_Pnl.Controls
                If ctrl.GetType = GetType(Controls.MetroTextBox) AndAlso (ctrl.Style = MetroColorStyle.Red And ctrl.Text = Nothing) Then
                    red_occur += 1
                    ctrl.Focus()
                End If
            Next

            If red_occur >= 1 Then
                MetroMessageBox.Show(Me, "Please fill up all required fields", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf red_occur = 0 Then
                If Image_Location <> "" Then
                    Dim counter As ObjectModel.ReadOnlyCollection(Of String)
                    Dim Occurrences As Integer = 0
                    counter = My.Computer.FileSystem.GetFiles(Path.Combine(Application.StartupPath, "Member_Images"))
                    For Each File As String In counter
                        File = Path.GetFileName(File)
                        If File.Contains(ID_Number) Then
                            Occurrences = Occurrences + 1
                        End If
                    Next

                    If Occurrences >= 1 Then
                        Image_Location = ID_Number & "_" & Occurrences & Path.GetExtension(Image_Pbox.ImageLocation)
                    ElseIf Occurrences = 0 Then
                        Image_Location = ID_Number & Path.GetExtension(Image_Pbox.ImageLocation)
                    End If
                Else
                    Image_Location = "users.png"
                End If

                If Save_Btn.Text = "Save" Then
                    Dim sql2 As String = "SELECT * FROM Member_Information where ID_Number = '" & ID_Number & "'"
                    Get_QUERY(sql2)
                    If Max_ID <> 0 Then
                        MetroMessageBox.Show(Me, "ID number already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        TODO = "SaveTrans"
                        Start_BGW()
                    End If
                ElseIf Save_Btn.Text = "Update" Then
                    TODO = "UpdateTrans"
                    Start_BGW()
                End If

                End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace)
        End Try
    End Sub

    Private Sub Tbox_Validated(sender As Object, e As EventArgs) Handles ID_Tbox.Validated, Address_Tbox.Validated,
                                                                         Fname_Tbox.Validated, Lname_Tbox.Validated

        If sender.Text = Nothing Then
            Homepage_Ttip.Show("Required field", sender)
            sender.Style = MetroColorStyle.Red
        ElseIf sender.Text <> Nothing Then
            Homepage_Ttip.RemoveAll()
            sender.Style = MetroColorStyle.Default
        End If
    End Sub

    Private Sub Side_Btn_Click(sender As Object, e As EventArgs) Handles Side_Btn.Click
        If if_left = True Then
            right_arrows()
            Homepage_Split.SplitterDistance = 30
        ElseIf if_left = False Then
            left_arrows()
            Homepage_Split.SplitterDistance = 260
        End If
    End Sub

    Private Sub EP_Split_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles Homepage_Split.SplitterMoved
        If e.SplitX = 30 Then
            right_arrows()
        ElseIf e.SplitX > 30 Then
            left_arrows()
        End If

    End Sub

End Class
