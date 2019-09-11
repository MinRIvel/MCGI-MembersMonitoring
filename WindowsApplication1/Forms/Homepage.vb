Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Imports ComponentFactory.Krypton.Toolkit
Imports System.ComponentModel
Imports MetroFramework

Public Class Homepage
    Dim Homepage_DGV As New KryptonDataGridView
    Dim Report_DGV As New KryptonDataGridView
    Public BGW As BackgroundWorker = New BackgroundWorker
    Private TODO, TODO_MODE, SearchStr, sqlQuery, SearchISStr As String
    Dim ID_Number, Last_Name, First_Name, Middle_Name, Address, Contact_Number, Occupation, Skill,
        Baptized_By, Nagakay, Image_Location As String
    Dim Baptism_Date, Report_Date As Date
    Dim if_left As Boolean = True
    Private A_ID_list, R_id_list As ArrayList
    Private dgv_rowindex, ISdgv_rowindex, A_id, R_Id As Integer

    Private Sub reset_here()
        sqlQuery = ""
        Body_Pnl.Enabled = True
        Homepage_Menu.Enabled = True
        LoadingPB2.Visible = False
        sql_Transaction_result = Nothing
        TODO_MODE = Nothing
        ChangePicture_Pnl.Visible = False
        AddUser_Pnl.Visible = False
        Image_Location = ""
        Save_Btn.Style = MetroColorStyle.Black
        Save_Btn.Text = "Save"
        ISAdd_Btn.Style = MetroColorStyle.Black
        ISAdd_Btn.Text = "Add"
        ID_Tbox.Style = MetroColorStyle.Red
        Lname_Tbox.Style = MetroColorStyle.Red
        Fname_Tbox.Style = MetroColorStyle.Red
        Address_Tbox.Style = MetroColorStyle.Red
        ISReport_RTF.Clear()
        For Each ctrl In Info_Pnl.Controls
            If ctrl.GetType = GetType(Controls.MetroTextBox) Then
                ctrl.Clear()
            ElseIf ctrl.GetType = GetType(PictureBox) Then
                ctrl.Enabled = True
                ctrl.Image = WindowsApplication1.My.Resources.Resources.users
                ctrl.ImageLocation = Nothing
            End If
        Next
        For Each ctrl In AddUserBdy_Pnl.Controls
            If ctrl.GetType = GetType(Controls.MetroTextBox) Then
                ctrl.Clear()
            End If
        Next
    End Sub
    Private Sub Start_BGW()
        Try
            If BGW.IsBusy <> True Then
                Body_Pnl.Enabled = False
                Homepage_Menu.Enabled = False
                LoadingPB2.Visible = True
                BGW.RunWorkerAsync()
            Else
                MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace, ex.Message)
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
            Header_Lbl.Text = "Welcome " & UserNickname
            If User_type <> "Admin" Then
                AdminToolStripMenuItem.Visible = False
            End If
            'Homepage_Split.SplitterDistance = 0
            DateTime_Lbl.Text = ""
            DateTime_Timer.Start()
            BGW.WorkerSupportsCancellation = True
            BGW.WorkerReportsProgress = True
            AddHandler BGW.DoWork, AddressOf BGW_DoWork
            AddHandler BGW.ProgressChanged, AddressOf BGW_ProgressChanged
            AddHandler BGW.RunWorkerCompleted, AddressOf BGW_RunWorkerCompleted

            Homepage_DGV.DataSource = homepageDGV_BS
            Report_DGV.DataSource = ReportDGV_BS

            Directory.CreateDirectory(Application.StartupPath & "\Member_Images")
            'Directory.CreateDirectory(Application.StartupPath & "\BackupDBs")
            TODO = "LoadDGV"
            Start_BGW()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace, ex.Message)
        End Try
    End Sub

    Private Sub BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case TODO
                Case "LoadDGV"
                    'sqlQuery = "Select   A_id
                    '                    ,ID_Number AS [ID NUMBER]
                    '                    ,Last_Name AS [LAST NAME]
                    '                    ,First_Name AS [FIRST NAME]
                    '                    ,Middle_Name AS [MIDDLE NAME]
                    '                    ,Address AS [ADDRESS]
                    '                    ,Contact_Number AS [CONTACT NUMBER]
                    '                    ,Occupation AS [OCCUPATION]
                    '                    ,Skill AS [SKILL]
                    '                    ,Baptism_Date AS [BAPTISM DATE]
                    '                    ,Baptized_By AS [BAPTIZED BY]
                    '                    ,Nagakay AS [NAG-AKAY]
                    '                    ,Image_Location
                    '                    ,Inputted_By
                    '            From    Member_Information
                    '            Where   (ID_Number Like @SearchStr
                    '                or  Last_name like @SearchStr
                    '                or  First_Name like @SearchStr
                    '                or  Middle_Name like @SearchStr
                    '                or  Address like @SearchStr
                    '                or  Contact_Number like @SearchStr
                    '                or  Occupation like @SearchStr
                    '                or  Skill like @SearchStr
                    '                or  Baptized_By like @SearchStr
                    '                or  Nagakay like @SearchStr)
                    '                and Row_Status = True
                    '            Order by A_id asc"
                    mcgi_query(TODO, sqlQuery, SearchStr)
                    BGW.ReportProgress(0)

                Case "SaveTrans"
                    'sqlQuery = "Insert into Member_Information  (A_id
                    '                                            ,Image_Location
                    '                                            ,ID_Number
                    '                                            ,Last_Name
                    '                                            ,First_Name
                    '                                            ,Middle_Name
                    '                                            ,Address
                    '                                            ,Contact_Number
                    '                                            ,Occupation
                    '                                            ,Skill
                    '                                            ,Baptism_Date
                    '                                            ,Baptized_By
                    '                                            ,Nagakay
                    '                                            ,Inputted_By)
                    '                                    values  (@Max_ID
                    '                                            ,@Image_Location
                    '                                            ,@ID_Number
                    '                                            ,@Last_Name
                    '                                            ,@First_Name
                    '                                            ,@Middle_Name
                    '                                            ,@Address
                    '                                            ,@Contact_Number
                    '                                            ,@Occupation
                    '                                            ,@Skill
                    '                                            ,@Baptism_Date
                    '                                            ,@Baptized_By
                    '                                            ,@Nagakay
                    '                                            ,@Inputted_By)"
                    'Dim sql2 As String = "SELECT iif(MAX(A_ID) is null,0,MAX(A_ID)) FROM Member_Information"
                    Max_ID = TABLGETMaxID_STP2("Member_Information", "A_Id") + 1
                    'Get_QUERY(sql2)
                    mcgi_query(TODO, sqlQuery,, ID_Number, Last_Name, First_Name, Middle_Name, Address, Contact_Number,
                                   Occupation, Skill, Baptism_Date, Baptized_By, Nagakay, Image_Location)

                Case "UpdateTrans"
                    'sqlQuery = "Update  Member_Information
                    '            set      ID_Number      = @ID_Number
                    '                    ,Last_Name      = @Last_Name
                    '                    ,First_Name     = @First_Name
                    '                    ,Middle_Name    = @Middle_Name
                    '                    ,Address        = @Address
                    '                    ,Contact_Number = @Contact_Number
                    '                    ,Occupation     = @Occupation
                    '                    ,Skill          = @Skill
                    '                    ,Baptism_Date   = @Baptism_Date
                    '                    ,Baptized_By    = @Baptized_By
                    '                    ,Nagakay        = @Nagakay
                    '                    ,Inputted_By    = @Inputted_By
                    '            where   A_id = @A_id"
                    mcgi_query(TODO, sqlQuery,, ID_Number, Last_Name, First_Name, Middle_Name, Address, Contact_Number,
                                   Occupation, Skill, Baptism_Date, Baptized_By, Nagakay,, A_id)

                Case "UpdatePictureTrans"
                    'sqlQuery = "Update  Member_Information
                    '            set     Image_Location = @Image_Location
                    '                   ,Inputted_By    = @Inputted_By
                    '            where   A_id = @A_id"
                    mcgi_query(TODO, sqlQuery,,,,,,,,,,,,, Image_Location, A_id)

                Case "UpdateDeleteTrans"
                    'sqlQuery = "Update  Member_Information
                    '            set     Row_Status = False
                    '                   ,Inputted_By    = @Inputted_By
                    '            where   A_id = @A_id"
                    For i = 0 To A_ID_list.Count - 1
                        mcgi_query(TODO, sqlQuery,,,,,,,,,,,,,, A_ID_list(i))
                    Next

                Case "Load_ReportDGV"
                    'sqlQuery = "Select   R_Id
                    '                    ,A_id_Ref
                    '                    ,Format(CStr(Report_Date),""MMMM dd, yyyy"") + Chr(13) + Chr(10) +  Chr(13) + Chr(10) + Report_Status as [Report Status]
                    '                    ,Report_Date
                    '                    ,Report_Status
                    '                    ,[RI].Inputted_By
                    '            FROM    Member_Information [MI]
                    '            INNER JOIN  Report_Information [RI]
                    '            ON      [MI].A_Id = [RI].A_Id_Ref
                    '            Where   Row_Status = True
                    '                and Report_RowStatus = True
                    '                and Report_Status like @SearchStrIS
                    '                and A_id_Ref = @A_id_Ref
                    '            Order by Report_Date desc"
                    mcgi_query(TODO, sqlQuery, SearchStr,,,,,,,,,,,,, A_id)
                    'ReportInfo_QUERY(TODO, sqlQuery, SearchISStr, A_id)
                    BGW.ReportProgress(0)

                Case "SaveISTrans"
                    'sqlQuery = "Insert into Report_Information       (R_id
                    '                                                 ,A_Id_Ref
                    '                                                 ,Report_Status
                    '                                                 ,Report_Date
                    '                                                 ,Inputted_By)
                    '                                        VALUES   (@R_id
                    '                                                 ,@A_Id_Ref
                    '                                                 ,@Report_Status
                    '                                                 ,@Report_Date
                    '                                                 ,@Inputted_By)"
                    'Dim sql2 As String = "SELECT iif(MAX(R_Id) is null,0,MAX(R_Id)) FROM Report_Information"
                    Max_ID = TABLGETMaxID_STP2("Report_Information", "R_Id") + 1
                    'Get_QUERY(sql2)
                    'ReportInfo_QUERY(TODO, sqlQuery,, A_id, Report_Status, Max_ID, Report_Date)
                    mcgi_query(TODO, sqlQuery, SearchStr,,,,, Report_Status,,,, Report_Date,,,, A_id)

                Case "UpdateISTrans"
                    'sqlQuery = "Update  Report_Information
                    '            set     A_Id_Ref = @A_Id_Ref
                    '                   ,Report_Status = @Report_Status
                    '                   ,Report_Date = @Report_Date
                    '                   ,Inputted_By = @Inputted_By
                    '            where   R_id = @R_id"
                    'ReportInfo_QUERY(TODO, sqlQuery,, A_id, Report_Status, R_Id, Report_Date)
                    mcgi_query(TODO, sqlQuery,,,,,, Report_Status,,,, Report_Date,,,, A_id, R_Id)

                Case "UpdateDeleteISTrans"
                    'sqlQuery = "Update  Report_Information
                    '            set     Report_RowStatus = False
                    '                   ,Inputted_By = @Inputted_By
                    '            where   R_id = @R_id"
                    For i = 0 To R_id_list.Count - 1
                        mcgi_query(TODO, sqlQuery,,,,,,,,,,,,,,, R_id_list(i))
                        'ReportInfo_QUERY(TODO, sqlQuery,,,, R_id_list(i))
                    Next

                Case "GetUsertypes"
                    'sqlQuery = "Select distinct Usertype From User_Information"
                    'UserInfo_QUERY(TODO, sqlQuery)
                    mcgi_query(TODO, "")

                Case "SaveUserTrans"
                    'sqlQuery = "Insert into User_Information         (U_id
                    '                                                 ,Usertype
                    '                                                 ,Last_Name
                    '                                                 ,First_Name
                    '                                                 ,Middle_Name
                    '                                                 ,Nickname
                    '                                                 ,Uname
                    '                                                 ,Pword)
                    '                                        VALUES   (@U_id
                    '                                                 ,@Usertype
                    '                                                 ,@Last_Name
                    '                                                 ,@First_Name
                    '                                                 ,@Middle_Name
                    '                                                 ,@Nickname
                    '                                                 ,@Uname
                    '                                                 ,@Pword)"
                    'Dim sql2 As String = "SELECT iif(MAX(U_id) is null,0,MAX(U_id)) FROM User_Information"
                    Max_ID = TABLGETMaxID_STP2("User_Information", "U_Id") + 1
                    'Get_QUERY(sql2)
                    mcgi_query(TODO, sqlQuery,,, UsrLname, UsrFname, UsrMname,,,,,,,,,,,, Usertype, UsrNickname, Max_ID, Max_ID)
                    'UserInfo_QUERY(TODO, sqlQuery, Max_ID, Usertype, UsrLname, UsrFname, UsrMname, UsrNickname)

                Case "ChangeUNPWTrans"
                    'UserInfo_QUERY(TODO, sqlQuery, User_Id,,,,,, newUname, newPword)
                    mcgi_query(TODO, sqlQuery,,,,,,,,,,,,,,,, User_Id,,, newUname, newPword)
                Case "ChangeUNTrans"
                    'UserInfo_QUERY(TODO, sqlQuery, User_Id,,,,,, newUname)
                    mcgi_query(TODO, sqlQuery,,,,,,,,,,,,,,,, User_Id,,, newUname)
                Case "ChangePWTrans"
                    'UserInfo_QUERY(TODO, sqlQuery, User_Id,,,,,,, newPword)
                    mcgi_query(TODO, sqlQuery,,,,,,,,,,,,,,,, User_Id,,,, newPword)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace, ex.Message)
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
                Case "Load_ReportDGV"
                    If e.ProgressPercentage = 0 And (Not ISTop_Pnl.Controls.Contains(Report_DGV)) Then
                        DGV_Properties(Report_DGV, "Report_DGV")
                        AddHandler Report_DGV.RowPostPaint, AddressOf DGV_RowPostPaint
                        AddHandler Report_DGV.CellMouseClick, AddressOf DGV_CellMouseClick
                        AddHandler Report_DGV.SelectionChanged, AddressOf DGV_SelectionChanged
                        ISTop_Pnl.Controls.Add(Report_DGV)
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace, ex.Message)
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
                                .AllowUserToResizeColumns = False
                                .AllowUserToResizeRows = False
                                .Select()
                                .Columns("A_id").Visible = False
                                .Columns("Image_Location").Visible = False
                                .Columns("BAPTISM DATE").DefaultCellStyle.Format = "MMM. dd, yyyy"
                                .DefaultCellStyle.BackColor = Color.White
                                .RowsDefaultCellStyle.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                                .MultiSelect = True
                                .ClearSelection()
                            End With
                            reset_here()
                            ID_Tbox.Focus()

                        Case "Load_ReportDGV"
                            ReportDGV_BS.DataSource = msDataSet
                            ReportDGV_BS.DataMember = TODO
                            With Report_DGV
                                .AllowUserToResizeColumns = False
                                .AllowUserToResizeRows = False
                                .Select()
                                .DefaultCellStyle.WrapMode = DataGridViewTriState.True
                                .Columns("R_Id").Visible = False
                                .Columns("A_id_Ref").Visible = False
                                .Columns("Report_Date").Visible = False
                                .Columns("Report_Status").Visible = False
                                .DefaultCellStyle.BackColor = Color.White
                                .RowsDefaultCellStyle.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                                .Columns("Report Status").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
                                .MultiSelect = True
                                .ClearSelection()
                            End With
                            reset_here()

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

                        Case "UpdatePictureTrans"
                            If ChangePic_Pbox.ImageLocation <> Nothing Then
                                FileSystem.CopyFile(ChangePic_Pbox.ImageLocation, Path.Combine(Application.StartupPath,
                                                                                           "Member_Images",
                                                                                           Image_Location), False)
                            End If
                            MetroMessageBox.Show(Me, "", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            TODO = "LoadDGV"
                            Start_BGW()

                        Case "UpdateDeleteTrans"
                            MetroMessageBox.Show(Me, "", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            TODO = "LoadDGV"
                            Start_BGW()

                        Case "SaveISTrans"
                            MetroMessageBox.Show(Me, "", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            TODO = "Load_ReportDGV"
                            Start_BGW()

                        Case "UpdateISTrans"
                            MetroMessageBox.Show(Me, "", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            TODO = "Load_ReportDGV"
                            Start_BGW()

                        Case "UpdateDeleteISTrans"
                            MetroMessageBox.Show(Me, "", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            TODO = "Load_ReportDGV"
                            Start_BGW()

                        Case "SaveUserTrans"
                            MetroMessageBox.Show(Me, "Your new username and password is " & Max_ID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            reset_here()

                        Case "GetUsertypes"
                            Usertype_Cbox.DataSource = msDataSet.Tables(TODO)
                            Usertype_Cbox.DisplayMember = "Usertype"
                            LoadingPB2.Visible = False

                        Case "ChangeUNPWTrans"
                            MessageBox.Show(Me, "After clicking ok you'll have to relogin", "Logging out.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LogoutToolStripMenuItem.PerformClick()
                        Case "ChangeUNTrans"
                            MessageBox.Show(Me, "After clicking ok you'll have to relogin", "Logging out.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LogoutToolStripMenuItem.PerformClick()
                        Case "ChangePWTrans"
                            MessageBox.Show(Me, "After clicking ok you'll have to relogin", "Logging out.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LogoutToolStripMenuItem.PerformClick()
                    End Select
                Else
                    MetroMessageBox.Show(Me, "", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    reset_here()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace, ex.Message)
        End Try
    End Sub

    Private Sub ChangePicExit_Btn_Click(sender As Object, e As EventArgs) Handles ChangePicExit_Btn.Click
        ChangePicture_Pnl.Visible = False
    End Sub

    Private Sub Pbox_MouseClick(sender As Object, e As MouseEventArgs) Handles Image_Pbox.MouseClick, ChangePic_Pbox.MouseClick
        Try
            If e.Button = MouseButtons.Left Then
                If Image_OPFD.ShowDialog() = DialogResult.OK Then
                    'Do things here, the path is stored in openFileDialog1.Filename
                    'If no files were selected, openFileDialog1.Filename is ""  
                    sender.ImageLocation = Image_OPFD.FileName
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace, ex.Message)
        End Try
    End Sub

    Private Sub DGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        rowpostpaint(sender, e)
    End Sub

    Private Sub DGV_SelectionChanged(sender As Object, e As EventArgs)
        Try
            Dim selectedItems As DataGridViewSelectedRowCollection = sender.SelectedRows
            If sender Is Homepage_DGV Then
                A_ID_list = New ArrayList(selectedItems.Count)
                For Each selectedItem As DataGridViewRow In selectedItems
                    A_ID_list.Add(selectedItem.Cells("A_id").Value.ToString)
                Next

            ElseIf sender Is Report_DGV Then
                R_id_list = New ArrayList(selectedItems.Count)
                For Each selectedItem As DataGridViewRow In selectedItems
                    R_id_list.Add(selectedItem.Cells("R_id").Value.ToString)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace, ex.Message)
        End Try
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            If e.Button = MouseButtons.Right Then
                If sender Is Homepage_DGV Then
                    dgv_rowindex = e.RowIndex
                    Homepage_DGV.Rows(e.RowIndex).Selected = True
                    If sender.SelectedRows.Count > 1 Then
                        EditToolStripMenuItem.Visible = False
                        ChangePictureToolStripMenuItem.Visible = False
                        ReportToolStripMenuItem.Visible = False
                    ElseIf sender.SelectedRows.Count = 1 Then
                        EditToolStripMenuItem.Visible = True
                        ChangePictureToolStripMenuItem.Visible = True
                        ReportToolStripMenuItem.Visible = True
                    End If
                    Homepage_Cmenu.Show()
                    Homepage_Cmenu.Location = New Point(MousePosition.X, MousePosition.Y)

                ElseIf sender Is Report_DGV Then
                    ISdgv_rowindex = e.RowIndex
                    Report_DGV.Rows(e.RowIndex).Selected = True
                    If sender.SelectedRows.Count > 1 Then
                        ISEditToolStripMenuItem.Visible = False
                    ElseIf sender.SelectedRows.Count = 1 Then
                        ISEditToolStripMenuItem.Visible = True
                    End If
                    StatusReport_Cmenu.Show()
                    StatusReport_Cmenu.Location = New Point(MousePosition.X, MousePosition.Y)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace, ex.Message)
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
                ID_Number = .Cells("ID NUMBER").Value.ToString
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
            log_file_writer(ex.StackTrace, ex.Message)
        End Try
    End Sub

    Private Sub ChangePicAccept_Btn_Click(sender As Object, e As EventArgs) Handles ChangePicAccept_Btn.Click
        Try
            Image_Location = ChangePic_Pbox.ImageLocation
            Dim counter As ObjectModel.ReadOnlyCollection(Of String)
            Dim Occurrences As Integer = 0
            counter = My.Computer.FileSystem.GetFiles(Path.Combine(Application.StartupPath, "Member_Images"))
            For Each File As String In counter
                File = Path.GetFileName(File)
                File = File.Remove(File.IndexOf("."))
                If File = ID_Number Or File.Contains(ID_Number & "_") Then
                    Occurrences = Occurrences + 1
                End If
            Next

            If Occurrences >= 1 Then
                Image_Location = ID_Number & "_" & Occurrences & Path.GetExtension(ChangePic_Pbox.ImageLocation)
            ElseIf Occurrences = 0 Then
                Image_Location = ID_Number & Path.GetExtension(ChangePic_Pbox.ImageLocation)
            End If
            TODO = "UpdatePictureTrans"
            Start_BGW()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace, ex.Message)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If MetroMessageBox.Show(Me, "Are you sure you want to delete (" & A_ID_list.Count & ") item(s)?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            TODO = "UpdateDeleteTrans"
            Start_BGW()
        End If
    End Sub

    Private Sub Search_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles Search_Tbox.ButtonClick
        SearchStr = Trim(Search_Tbox.Text)
        TODO = "LoadDGV"
        Start_BGW()
    End Sub

    Private Sub SearchPnlExit_Btn_Click(sender As Object, e As EventArgs) Handles SearchPnlExit_Btn.Click
        Search_Pnl.Visible = False
    End Sub

    Private Sub Search_Tbox_KeyDown(sender As Object, e As KeyEventArgs) Handles Search_Tbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Search_Tbox.CustomButton.PerformClick()
        End If
    End Sub

    Private Sub InputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputToolStripMenuItem.Click
        InputStatus_Pnl.Visible = True
        With Homepage_DGV.Rows(dgv_rowindex)
            A_id = .Cells("A_id").Value
            ISHdr_Lbl.Text = .Cells("LAST NAME").Value.ToString & ", " & .Cells("FIRST NAME").Value.ToString & " " & .Cells("MIDDLE NAME").Value.ToString
        End With
        ISReport_RTF.Focus()
        SearchISStr = ""
        TODO = "Load_ReportDGV"
        Start_BGW()
    End Sub

    Private Sub SearchIS_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles SearchIS_Tbox.ButtonClick
        SearchISStr = Trim(SearchIS_Tbox.Text)
        TODO = "Load_ReportDGV"
        Start_BGW()
    End Sub

    Private Sub ISCancel_Btn_Click(sender As Object, e As EventArgs) Handles ISCancel_Btn.Click
        ISAdd_Btn.Style = MetroColorStyle.Black
        ISAdd_Btn.Text = "Add"
    End Sub

    Private Sub ISDeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ISDeleteToolStripMenuItem.Click
        If MetroMessageBox.Show(Me, "Are you sure you want to delete (" & R_id_list.Count & ") item(s)?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            TODO = "UpdateDeleteISTrans"
            Start_BGW()
        End If
    End Sub

    Private Sub ISReport_RTF_KeyDown(sender As Object, e As KeyEventArgs) Handles ISReport_RTF.KeyDown
        If e.Control And e.KeyCode = Keys.Enter Then
            ISAdd_Btn.PerformClick()
        End If
    End Sub

    Private Sub InformationPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationPanelToolStripMenuItem.Click
        If InformationPanelToolStripMenuItem.Checked = True Then
            left_arrows()
            Homepage_Split.SplitterDistance = 260
        ElseIf InformationPanelToolStripMenuItem.Checked = False Then
            right_arrows()
            Homepage_Split.SplitterDistance = 30
        End If
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        TODO = "LoadDGV"
        Start_BGW()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        AddUser_Pnl.Visible = True
        Body_Pnl.Enabled = False
        Homepage_Menu.Enabled = False

        'TODO = "GetUsertypes"
        'Start_BGW()
    End Sub

    Private Sub AddUserExit_Btn_Click(sender As Object, e As EventArgs) Handles AddUserExit_Btn.Click
        AddUser_Pnl.Visible = False
        Body_Pnl.Enabled = True
        Homepage_Menu.Enabled = True
    End Sub

    Private Sub AddUserAcpt_Btn_Click(sender As Object, e As EventArgs) Handles AddUserAcpt_Btn.Click
        Usertype = Trim(Usertype_Cbox.Text)
        UsrLname = Trim(UsrLname_Tbox.Text)
        UsrFname = Trim(UsrFname_Tbox.Text)
        UsrMname = Trim(UsrMname_Tbox.Text)
        UsrNickname = Trim(UsrNickname_Tbox.Text)

        Dim red_occur As Integer = 0
        For Each ctrl In AddUserBdy_Pnl.Controls
            If ctrl.Tag = "Req" And ctrl.Text = Nothing Then
                red_occur += 1
                ctrl.Focus()
            End If
        Next

        If red_occur >= 1 Then
            MetroMessageBox.Show(Me, "Please fill up all required fields", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf red_occur = 0 Then
            TODO = "SaveUserTrans"
            Start_BGW()
        End If
    End Sub

    Private Sub ISEditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ISEditToolStripMenuItem.Click
        Try
            ISAdd_Btn.Style = MetroColorStyle.Red
            ISAdd_Btn.Text = "Update"
            With Report_DGV.Rows(ISdgv_rowindex)
                R_Id = .Cells("R_Id").Value
                ISReport_RTF.Text = .Cells("Report_Status").Value
                ReportDate_DTP.Value = .Cells("Report_Date").Value
            End With
            ISReport_RTF.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace, ex.Message)
        End Try
    End Sub

    Private Sub SearchIS_Tbox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchIS_Tbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchIS_Tbox.CustomButton.PerformClick()
        End If
    End Sub

    Private Sub ChangeUNPWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeUNPWToolStripMenuItem.Click
        ChangeUNPW_Pnl.Visible = True
        Body_Pnl.Enabled = False
        Homepage_Menu.Enabled = False
    End Sub

    Private Sub ChangeUNPWExit_Btn_Click(sender As Object, e As EventArgs) Handles ChangeUNPWExit_Btn.Click
        ChangeUNPW_Pnl.Visible = False
        reset_here()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Login.UsernameTextBox.Focus()
        Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Login.Show()
        Login.UsernameTextBox.Focus()
        Close()
    End Sub

    Private Sub Homepage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Print_Report.Close()
        Login.Show()
        Login.UsernameTextBox.Focus()
    End Sub

    Private Sub Chk_CheckedChanged(sender As Object, e As EventArgs) Handles Username_Chk.CheckedChanged,
                                                                             Password_Chk.CheckedChanged
        If sender.Checked = True Then
            For Each ctrl In ChangeUNPWBdy_Pnl.Controls
                If ctrl.Tag = sender.Name Then
                    ctrl.Enabled = True
                    ctrl.Focus
                End If
            Next
        ElseIf sender.Checked = False Then
            For Each ctrl In ChangeUNPWBdy_Pnl.Controls
                If ctrl.Tag = sender.Name Then
                    ctrl.Enabled = False
                End If
            Next
        End If
    End Sub

    Dim newUname, newPword As String

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Try
            With Homepage_DGV.Rows(dgv_rowindex)
                Print_Report.Image_Location = Application.StartupPath & "\Member_Images\" & .Cells("Image_Location").Value.ToString
                'sqlQuery = "Select   ID_Number
                '                    ,Last_Name
                '                    ,First_Name
                '                    ,Middle_Name
                '                    ,Address
                '                    ,Contact_Number
                '                    ,Occupation
                '                    ,Skill
                '                    ,Baptism_Date
                '                    ,Baptized_By
                '                    ,Nagakay
                '                    ,Image_Location
                '        From    Member_Information
                '        Where   A_id = @A_id
                '            and Row_Status = True"
                PrintRPT_QUERY("Member_Info", sqlQuery, .Cells("A_id").Value)
                'mcgi_query("Member_Info", sqlQuery,,,,,,,,,,,,,, .Cells("A_id").Value)

                'sqlQuery = "Select   Report_Status
                '                    ,Report_Date
                '        From    Report_Information
                '        Where   A_Id_Ref = @A_id
                '            and Report_RowStatus = True"
                PrintRPT_QUERY("Report_Info", sqlQuery, .Cells("A_id").Value)
                'mcgi_query("Report_Info", sqlQuery,,,,,,,,,,,,,, .Cells("A_id").Value)

                Print_Report.Show()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace, ex.Message)
        End Try
    End Sub

    Private Sub ChangeUNPWAcpt_Btn_Click(sender As Object, e As EventArgs) Handles ChangeUNPWAcpt_Btn.Click
        If Username_Chk.Checked = True And Password_Chk.Checked = True Then
            sqlQuery = "update User_Information set Uname = @Uname, Pword = @Pword where U_id = @U_id"
            TODO = "ChangeUNPWTrans"

        ElseIf Username_Chk.Checked = True And Password_Chk.Checked = False Then
            sqlQuery = "update User_Information set Uname = @Uname where U_id = @U_id"
            TODO = "ChangeUNTrans"

        ElseIf Username_Chk.Checked = False And Password_Chk.Checked = True Then
            sqlQuery = "update User_Information set Pword = @Pword where U_id = @U_id"
            TODO = "ChangePWTrans"

        End If

        newUname = Trim(Username_Tbox.Text)
        newPword = Trim(Password_Tbox.Text)

        If Username_Chk.Checked = True Then
            Dim sql2 As String = "SELECT * FROM User_Information where Uname = '" & newUname & "'"
            Get_QUERY(sql2)
            If Max_ID <> 0 Then
                MetroMessageBox.Show(Me, "Username already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If OldPass_Tbox.Text = Pword Then
                    If Password_Chk.Checked = True Then
                        If Password_Tbox.Text = Retype_Tbox.Text Then
                            Start_BGW()
                        Else
                            MessageBox.Show(Me, "New password doesn't match", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        Start_BGW()
                    End If
                Else
                    MessageBox.Show(Me, "Incorrect old password", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If OldPass_Tbox.Text = Pword Then
                If Password_Chk.Checked = True Then
                    If Password_Tbox.Text = Retype_Tbox.Text Then
                        Start_BGW()
                    Else
                        MessageBox.Show(Me, "New password doesn't match", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    Start_BGW()
                End If
            Else
                MessageBox.Show(Me, "Incorrect old password", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub ISAdd_Btn_Click(sender As Object, e As EventArgs) Handles ISAdd_Btn.Click
        Report_Date = ReportDate_DTP.Value
        Report_Status = ISReport_RTF.Text

        If ISAdd_Btn.Text = "Add" Then
            TODO = "SaveISTrans"
            Start_BGW()

        ElseIf ISAdd_Btn.Text = "Update" Then
            TODO = "UpdateISTrans"
            Start_BGW()
        End If
    End Sub

    Private Sub ISExit_Btn_Click(sender As Object, e As EventArgs) Handles ISExit_Btn.Click
        InputStatus_Pnl.Visible = False
    End Sub

    Private Sub Homepage_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            Save_Btn.PerformClick()
        ElseIf e.Control And e.KeyCode = Keys.F Then
            Search_Pnl.Visible = True
        ElseIf e.Control And e.KeyCode = Keys.I And Homepage_DGV.SelectedRows.Count = 1 Then
            InputToolStripMenuItem.PerformClick()
        ElseIf e.KeyCode = Keys.F5 Then
            TODO = "LoadDGV"
            Start_BGW()
        End If
    End Sub

    Private Sub Save_Btn_Click(sender As Object, e As EventArgs) Handles Save_Btn.Click
        Try
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
            For Each ctrl In Info_Pnl.Controls
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
                    ID_Number = Trim(ID_Tbox.Text)
                    Dim sql2 As String = "SELECT * FROM Member_Information where ID_Number = '" & ID_Number & "'"
                    Get_QUERY(sql2)
                    If Max_ID <> 0 Then
                        MetroMessageBox.Show(Me, "ID number already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        TODO = "SaveTrans"
                        Start_BGW()
                    End If
                ElseIf Save_Btn.Text = "Update" Then
                    Dim sql2 As String = "SELECT * FROM Member_Information where ID_Number = '" & ID_Tbox.Text & "' and ID_Number <> '" & ID_Number & "'"
                    Get_QUERY(sql2)
                    If Max_ID <> 0 Then
                        MetroMessageBox.Show(Me, "ID number already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        ID_Number = Trim(ID_Tbox.Text)
                        TODO = "UpdateTrans"
                        Start_BGW()
                    End If
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace, ex.Message)
        End Try
    End Sub

    Private Sub Tbox_Validated(sender As Object, e As EventArgs) Handles ID_Tbox.Validated, Address_Tbox.Validated,
                                                                         Fname_Tbox.Validated, Lname_Tbox.Validated
        If sender.Text = Nothing Then
            Homepage_Ttip.Show("Required field", sender, 2000)
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

    Private Sub ChangePictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePictureToolStripMenuItem.Click
        Try
            ChangePicture_Pnl.Visible = True
            With Homepage_DGV.Rows(dgv_rowindex)
                A_id = .Cells("A_id").Value
                ID_Number = .Cells("ID NUMBER").Value.ToString
                ChangePic_Pbox.ImageLocation = Application.StartupPath & "\Member_Images\" & .Cells("Image_Location").Value.ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            log_file_writer(ex.StackTrace, ex.Message)
        End Try
    End Sub
    Private allowCoolMove As Boolean = False
    Private myCoolPoint As New Point
    Private Report_Status As String
    Private Usertype, UsrLname, UsrFname, UsrMname, UsrNickname As String

    Private Sub Header_Pnl_MouseDown(sender As Object, e As MouseEventArgs) Handles ChangePictureHeader_Pnl.MouseDown,
                                                                                    SearchHeader_Pnl.MouseDown,
                                                                                    InputStatusHdr_Pnl.MouseDown,
                                                                                    AddUserHdr_Pnl.MouseDown,
                                                                                    ChangeUNPWHdr_Pnl.MouseDown
        allowCoolMove = True
        myCoolPoint = New Point(e.X, e.Y)
    End Sub

    Private Sub Header_Pnl_MouseMove(sender As Object, e As MouseEventArgs) Handles ChangePictureHeader_Pnl.MouseMove,
                                                                                    SearchHeader_Pnl.MouseMove,
                                                                                    InputStatusHdr_Pnl.MouseMove,
                                                                                    AddUserHdr_Pnl.MouseMove,
                                                                                    ChangeUNPWHdr_Pnl.MouseMove
        If allowCoolMove = True Then
            Dim objectToMove As Object = Nothing
            If sender Is ChangePictureHeader_Pnl Then
                objectToMove = ChangePicture_Pnl
            ElseIf sender Is SearchHeader_Pnl Then
                objectToMove = Search_Pnl
            ElseIf sender Is InputStatusHdr_Pnl Then
                objectToMove = InputStatus_Pnl
            ElseIf sender Is AddUserHdr_Pnl Then
                objectToMove = AddUser_Pnl
            ElseIf sender Is ChangeUNPWHdr_Pnl Then
                objectToMove = ChangeUNPW_Pnl
            End If
            objectToMove.Location = New Point(objectToMove.Location.X + e.X - myCoolPoint.X, objectToMove.Location.Y + e.Y - myCoolPoint.Y)
        End If
    End Sub

    Private Sub Header_Pnl_MouseUp(sender As Object, e As MouseEventArgs) Handles ChangePictureHeader_Pnl.MouseUp,
                                                                                  SearchHeader_Pnl.MouseUp,
                                                                                  InputStatusHdr_Pnl.MouseUp,
                                                                                  AddUserHdr_Pnl.MouseUp,
                                                                                  ChangeUNPWHdr_Pnl.MouseUp
        allowCoolMove = False
    End Sub

    Private Sub Homepage_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        ChangePicture_Pnl.Location = New Point((Width - ChangePicture_Pnl.Width) / 2, (Height - ChangePicture_Pnl.Height) / 2)
        Search_Pnl.Location = New Point((Width - Search_Pnl.Width) / 2, (Height - Search_Pnl.Height) / 2)
        InputStatus_Pnl.Location = New Point((Width - InputStatus_Pnl.Width) / 2, (Height - InputStatus_Pnl.Height) / 2)
        AddUser_Pnl.Location = New Point((Width - AddUser_Pnl.Width) / 2, (Height - AddUser_Pnl.Height) / 2)
        ChangeUNPW_Pnl.Location = New Point((Width - ChangeUNPW_Pnl.Width) / 2, (Height - ChangeUNPW_Pnl.Height) / 2)
    End Sub

End Class
