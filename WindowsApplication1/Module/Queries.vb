Imports System.Data.OleDb
Imports System.IO
Imports ComponentFactory.Krypton.Toolkit
Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.SqlClient
Module Queries
    Public Log_File As StreamWriter
    'Public msconString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\mcgidb.accdb"
    Public msconString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & Application.StartupPath & "\mcgi.mdf;Integrated Security=True"
    'Public msconString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kmdie\Documents\GitHub\WindowsApplication1\WindowsApplication1\mcgi.mdf;Integrated Security=True"
    Public transaction As SqlTransaction
    Public msDataAdapter As SqlDataAdapter
    Public msDataSet As New DataSet
    Public msBindingSource As BindingSource
    Public homepageDGV_BS As New BindingSource
    Public ReportDGV_BS As New BindingSource
    'Public transaction As OleDbTransaction
    Public sql_Transaction_result, UserNickname, User_type, Uname, Pword As String
    Public Max_ID, User_Id As Integer
    Public Sub DGV_Properties(ByVal DGV As KryptonDataGridView,
                              ByVal dgvName As String)
        With DGV
            .Name = dgvName
            .Dock = DockStyle.Fill
            .Select()
            .DefaultCellStyle.BackColor = Color.White
            .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AllowUserToOrderColumns = True
            .AllowUserToResizeColumns = True
            .AllowUserToResizeRows = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            '.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            '.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            .CausesValidation = True
            .ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText
            .PaletteMode = PaletteMode.Office2010Silver
            .ColumnHeadersHeight = 30
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            With .GridStyles
                .Style = DataGridViewStyle.List
                .StyleColumn = DataGridViewStyle.List
                .StyleDataCells = DataGridViewStyle.List
                .StyleRow = DataGridViewStyle.List
            End With
            .HideOuterBorders = True
            .ReadOnly = True
            .ScrollBars = ScrollBars.Both
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ShowCellErrors = True
            .ShowCellToolTips = True
            .ShowRowErrors = True
            .StandardTab = False
            .MultiSelect = True
            With .StateCommon
                .Background.Color1 = Color.White
                .Background.Color2 = Color.Transparent
                .DataCell.Content.Color1 = Color.Black
                .DataCell.Content.Color2 = Color.Transparent
                .DataCell.Content.ColorAngle = -1
                .DataCell.Content.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                .HeaderColumn.Back.Color1 = Color.FromArgb(11, 19, 36)
                .HeaderColumn.Back.Color2 = Color.FromArgb(11, 19, 36)
                .HeaderColumn.Back.ColorAngle = -1
                .HeaderColumn.Back.ColorStyle = PaletteColorStyle.Dashed
                .HeaderColumn.Border.Width = 0
                .HeaderColumn.Content.Color1 = Color.White
                .HeaderColumn.Content.Color2 = Color.Transparent
                .HeaderColumn.Content.Font = New Font("Segoe UI", 11.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
                .HeaderColumn.Content.Hint = PaletteTextHint.AntiAlias
            End With
        End With
    End Sub
    Public Sub rowpostpaint(ByVal sender As Object, ByVal e As DataGridViewRowPostPaintEventArgs)
        Dim grid As DataGridView = DirectCast(sender, DataGridView)
        e.PaintHeader(DataGridViewPaintParts.Background)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As New Font("Microsoft Sans Serif", 10.0!,
            FontStyle.Regular,
            GraphicsUnit.Point, CType(0, Byte))

        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Far
        centerFormat.LineAlignment = StringAlignment.Near

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)

        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub
    Public Sub log_file_writer(ByVal Err_StackTrace As String,
                               ByVal Err_Message As String)
        Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
        Log_File.WriteLine("Logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                           "Error Message: " & Err_Message & vbCrLf &
                           "Trace: " & Err_StackTrace & vbCrLf)
        Log_File.Close()
    End Sub
    Public Function Encrypt(clearText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function
    Public Function Decrypt(cipherText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function
    Public Function Checking_Query(ByVal Tblname As String) As Integer
        Dim true_counter As Integer = 0
        Using mscon As New SqlConnection(msconString)
            mscon.Open()
            Dim schema = mscon.GetSchema("Tables")
            For Each row As DataRow In schema.Rows
                If (row.Field(Of String)("TABLE_NAME")) = Tblname Then
                    true_counter += 1
                End If
            Next
            Return true_counter
        End Using
    End Function

    Public Sub Creation_Query(ByVal sqlQuery As String)
        Using mscon As New SqlConnection(msconString)
            mscon.Open()
            Using mscmd As SqlCommand = mscon.CreateCommand()
                mscmd.Connection = mscon
                mscmd.CommandText = sqlQuery
                mscmd.CommandType = CommandType.Text
                mscmd.ExecuteNonQuery()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub
    Public Sub mcgi_query(ByVal dsTbl_Command As String,
                              ByVal sqlQuery As String,
                              Optional SearchStr As String = "",
                              Optional ID_Number As String = "",
                              Optional Last_Name As String = "",
                              Optional First_Name As String = "",
                              Optional Middle_Name As String = "",
                              Optional Address As String = "",
                              Optional Contact_Number As String = "",
                              Optional Occupation As String = "",
                              Optional Skill As String = "",
                              Optional Baptism_Date As Date = Nothing,
                              Optional Baptized_By As String = "",
                              Optional Nagakay As String = "",
                              Optional Image_Location As String = "",
                              Optional A_id As Integer = 0,
                              Optional R_id As Integer = 0,
                              Optional U_id As Integer = 0,
                              Optional Usertype As String = "",
                              Optional Nickname As String = "",
                              Optional Uname As String = "",
                              Optional Pword As String = "")
        msDataAdapter = New SqlDataAdapter
        msBindingSource = New BindingSource
        msDataSet = New DataSet
        If msDataSet.Tables.Contains(dsTbl_Command) Then
            msDataSet.Tables(dsTbl_Command).Clear()
        End If
        Using mscon As New SqlConnection(msconString)
            mscon.Open()
            Using mscmd As SqlCommand = mscon.CreateCommand()
                transaction = mscon.BeginTransaction(IsolationLevel.RepeatableRead, dsTbl_Command)
                mscmd.Connection = mscon
                mscmd.Transaction = transaction
                mscmd.CommandText = "mcgi_stp"
                mscmd.CommandType = CommandType.StoredProcedure


                'If dsTbl_Command.Contains("Trans") = False And dsTbl_Command <> "Load_ReportDGV" Then

                'ElseIf dsTbl_Command.Contains("Save") Then
                'mscmd.Parameters.Add("@Image_Location", SqlDbType.VarChar).Value = Image_Location
                'End If
                'If dsTbl_Command <> "UpdatePictureTrans" And
                '   dsTbl_Command.Contains("Delete") = False And
                '   dsTbl_Command <> "Load_ReportDGV" Then
                mscmd.Parameters.Add("@todo", SqlDbType.VarChar).Value = dsTbl_Command
                mscmd.Parameters.Add("@SearchStr", SqlDbType.VarChar).Value = "%" & SearchStr & "%"
                mscmd.Parameters.Add("@ID_Number", SqlDbType.VarChar).Value = ID_Number
                mscmd.Parameters.Add("@Last_Name", SqlDbType.VarChar).Value = Last_Name
                mscmd.Parameters.Add("@First_Name", SqlDbType.VarChar).Value = First_Name
                mscmd.Parameters.Add("@Middle_Name", SqlDbType.VarChar).Value = Middle_Name
                mscmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address
                mscmd.Parameters.Add("@Contact_Number", SqlDbType.VarChar).Value = Contact_Number
                mscmd.Parameters.Add("@Occupation", SqlDbType.VarChar).Value = Occupation
                mscmd.Parameters.Add("@Skill", SqlDbType.VarChar).Value = Skill
                mscmd.Parameters.Add("@Baptism_Date", SqlDbType.Date).Value = Baptism_Date.ToString("MMM. dd, yyyy")
                mscmd.Parameters.Add("@Baptized_By", SqlDbType.VarChar).Value = Baptized_By
                mscmd.Parameters.Add("@Nagakay", SqlDbType.VarChar).Value = Nagakay
                mscmd.Parameters.Add("@Image_Location", SqlDbType.VarChar).Value = Image_Location
                mscmd.Parameters.Add("@Inputted_By", SqlDbType.VarChar).Value = UserNickname & " " & Now.Date.ToString("MMMM dd, yyyy")
                mscmd.Parameters.Add("@A_id", SqlDbType.Int).Value = A_id
                mscmd.Parameters.Add("@Max_ID", SqlDbType.Int).Value = Max_ID
                mscmd.Parameters.Add("@R_id", SqlDbType.Int).Value = R_id
                mscmd.Parameters.Add("@U_id", SqlDbType.Int).Value = U_id
                mscmd.Parameters.Add("@Usertype", SqlDbType.VarChar).Value = Usertype
                mscmd.Parameters.Add("@Nickname", SqlDbType.VarChar).Value = Nickname
                mscmd.Parameters.Add("@Uname", SqlDbType.VarChar).Value = Uname
                mscmd.Parameters.Add("@Pword", SqlDbType.VarChar).Value = Encrypt(Pword)
                transaction.Commit()
                'End If
                'If dsTbl_Command = "UpdatePictureTrans" Then
                'mscmd.Parameters.Add("@Inputted_By", SqlDbType.VarChar).Value = UserNickname & " " & Now.Date.ToString("MMMM dd, yyyy")
                'End If

                'If dsTbl_Command = "UpdateDeleteTrans" Then
                'mscmd.Parameters.Add("@Inputted_By", SqlDbType.VarChar).Value = UserNickname & " " & Now.Date.ToString("MMMM dd, yyyy")
                'End If

                'If dsTbl_Command.Contains("Update") Then
                '    mscmd.Parameters.Add("@A_id", SqlDbType.Int).Value = A_id
                'End If

                'If dsTbl_Command = "Load_ReportDGV" Then
                '    mscmd.Parameters.Add("@A_id", SqlDbType.Int).Value = A_id
                'End If

                If dsTbl_Command.Contains("Trans") = False Then
                    msDataAdapter.SelectCommand = mscmd
                    msDataAdapter.Fill(msDataSet, dsTbl_Command)
                    msBindingSource.DataSource = msDataSet
                    msBindingSource.DataMember = dsTbl_Command
                Else
                    mscmd.ExecuteNonQuery()
                End If
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub
    Public Sub ReportInfo_QUERY(ByVal dsTbl_Command As String,
                                ByVal sqlQuery As String,
                                Optional SearchStrIS As String = "",
                                Optional A_id As Integer = 0,
                                Optional Report_Status As String = "",
                                Optional R_id As Integer = 0,
                                Optional Report_Date As Date = Nothing)
        msDataAdapter = New SqlDataAdapter
        msBindingSource = New BindingSource
        msDataSet = New DataSet
        If msDataSet.Tables.Contains(dsTbl_Command) Then
            msDataSet.Tables(dsTbl_Command).Clear()
        End If
        Using mscon As New SqlConnection(msconString)
            mscon.Open()
            Using mscmd As SqlCommand = mscon.CreateCommand()
                mscmd.Connection = mscon
                mscmd.CommandText = sqlQuery
                mscmd.CommandType = CommandType.Text
                If dsTbl_Command.Contains("Trans") = False Then
                    mscmd.Parameters.Add("@SearchStrIS", SqlDbType.VarChar).Value = "%" & SearchStrIS & "%"
                End If

                If dsTbl_Command = "Load_ReportDGV" Then
                    mscmd.Parameters.Add("@A_id_Ref", SqlDbType.Int).Value = A_id
                End If

                If dsTbl_Command = "SaveISTrans" Then
                    mscmd.Parameters.Add("@R_id", SqlDbType.Int).Value = R_id + 1
                    mscmd.Parameters.Add("@A_id_Ref", SqlDbType.Int).Value = A_id
                    mscmd.Parameters.Add("@Report_Status", SqlDbType.VarChar).Value = Report_Status
                    mscmd.Parameters.Add("@Report_Date", SqlDbType.Date).Value = Report_Date.ToString("MMM. dd, yyyy")
                    mscmd.Parameters.Add("@Inputted_By", SqlDbType.VarChar).Value = UserNickname & vbCrLf & Now.Date.ToString("MMMM dd, yyyy")

                ElseIf dsTbl_Command = "UpdateISTrans" Then
                    mscmd.Parameters.Add("@A_id_Ref", SqlDbType.Int).Value = A_id
                    mscmd.Parameters.Add("@Report_Status", SqlDbType.VarChar).Value = Report_Status
                    mscmd.Parameters.Add("@Report_Date", SqlDbType.Date).Value = Report_Date.ToString("MMM. dd, yyyy")
                    mscmd.Parameters.Add("@Inputted_By", SqlDbType.VarChar).Value = UserNickname & vbCrLf & Now.Date.ToString("MMMM dd, yyyy")
                    mscmd.Parameters.Add("@R_id", SqlDbType.Int).Value = R_id

                ElseIf dsTbl_Command = "UpdateDeleteISTrans" Then
                    mscmd.Parameters.Add("@Inputted_By", SqlDbType.VarChar).Value = UserNickname & vbCrLf & Now.Date.ToString("MMMM dd, yyyy")
                    mscmd.Parameters.Add("@R_id", SqlDbType.Int).Value = R_id
                End If

                If dsTbl_Command.Contains("Trans") = False Then
                    msDataAdapter.SelectCommand = mscmd
                    msDataAdapter.Fill(msDataSet, dsTbl_Command)
                    msBindingSource.DataSource = msDataSet
                    msBindingSource.DataMember = dsTbl_Command
                Else
                    mscmd.ExecuteNonQuery()
                End If
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub
    Public Sub UserInfo_QUERY(ByVal dsTbl_Command As String,
                              ByVal sqlQuery As String,
                              Optional U_id As Integer = 0,
                              Optional Usertype As String = "",
                              Optional Lname As String = "",
                              Optional Fname As String = "",
                              Optional Mname As String = "",
                              Optional Nickname As String = "",
                              Optional Uname As String = "",
                              Optional Pword As String = "")
        msDataAdapter = New SqlDataAdapter
        msBindingSource = New BindingSource
        msDataSet = New DataSet
        If msDataSet.Tables.Contains(dsTbl_Command) Then
            msDataSet.Tables(dsTbl_Command).Clear()
        End If
        Using mscon As New SqlConnection(msconString)
            mscon.Open()
            Using mscmd As SqlCommand = mscon.CreateCommand()
                mscmd.Connection = mscon
                mscmd.CommandText = sqlQuery
                mscmd.CommandType = CommandType.Text

                If dsTbl_Command.Contains("Trans") = False Then
                    msDataAdapter.SelectCommand = mscmd
                    msDataAdapter.Fill(msDataSet, dsTbl_Command)
                    msBindingSource.DataSource = msDataSet
                    msBindingSource.DataMember = dsTbl_Command
                    sql_Transaction_result = "Committed"

                ElseIf dsTbl_Command = "SaveDefaultAdminTrans" Then
                    mscmd.Parameters.Add("@U_id", SqlDbType.Int).Value = U_id
                    mscmd.Parameters.Add("@Usertype", SqlDbType.VarChar).Value = Usertype
                    mscmd.Parameters.Add("@Last_Name", SqlDbType.VarChar).Value = Lname
                    mscmd.Parameters.Add("@First_Name", SqlDbType.VarChar).Value = Fname
                    mscmd.Parameters.Add("@Middle_Name", SqlDbType.VarChar).Value = Mname
                    mscmd.Parameters.Add("@Nickname", SqlDbType.VarChar).Value = Nickname
                    mscmd.Parameters.Add("@Uname", SqlDbType.VarChar).Value = Uname
                    mscmd.Parameters.Add("@Pword", SqlDbType.VarChar).Value = Encrypt(Pword)
                    mscmd.ExecuteNonQuery()
                    sql_Transaction_result = "Committed"

                ElseIf dsTbl_Command = "SaveUserTrans" Then
                    mscmd.Parameters.Add("@U_id", SqlDbType.Int).Value = U_id + 1
                    mscmd.Parameters.Add("@Usertype", SqlDbType.VarChar).Value = Usertype
                    mscmd.Parameters.Add("@Last_Name", SqlDbType.VarChar).Value = Lname
                    mscmd.Parameters.Add("@First_Name", SqlDbType.VarChar).Value = Fname
                    mscmd.Parameters.Add("@Middle_Name", SqlDbType.VarChar).Value = Mname
                    mscmd.Parameters.Add("@Nickname", SqlDbType.VarChar).Value = Nickname
                    mscmd.Parameters.Add("@Uname", SqlDbType.VarChar).Value = U_id + 1
                    mscmd.Parameters.Add("@Pword", SqlDbType.VarChar).Value = Encrypt(U_id + 1)
                    mscmd.ExecuteNonQuery()
                    sql_Transaction_result = "Committed"

                ElseIf dsTbl_Command = "ChangeUNPWTrans" Then
                    mscmd.Parameters.Add("@Uname", SqlDbType.VarChar).Value = Uname
                    mscmd.Parameters.Add("@Pword", SqlDbType.VarChar).Value = Encrypt(Pword)
                    mscmd.Parameters.Add("@U_id", SqlDbType.Int).Value = U_id
                    mscmd.ExecuteNonQuery()
                    sql_Transaction_result = "Committed"

                ElseIf dsTbl_Command = "ChangeUNTrans" Then
                    mscmd.Parameters.Add("@Uname", SqlDbType.VarChar).Value = Uname
                    mscmd.Parameters.Add("@U_id", SqlDbType.Int).Value = U_id
                    mscmd.ExecuteNonQuery()
                    sql_Transaction_result = "Committed"

                ElseIf dsTbl_Command = "ChangePWTrans" Then
                    mscmd.Parameters.Add("@Pword", SqlDbType.VarChar).Value = Encrypt(Pword)
                    mscmd.Parameters.Add("@U_id", SqlDbType.Int).Value = U_id
                    mscmd.ExecuteNonQuery()
                    sql_Transaction_result = "Committed"

                End If
            End Using
        End Using
    End Sub
    'Public Sub Login_QUERY(ByVal Username As String,
    '                       ByVal Password As String)
    '    Using mscon As New SqlConnection(msconString)
    '        mscon.Open()
    '        Using mscmd As SqlCommand = mscon.CreateCommand()
    '            mscmd.Connection = mscon
    '            mscmd.CommandText = "Select * from User_Information where Uname = @Uname and Pword = @Pword"
    '            mscmd.CommandType = CommandType.Text

    '            mscmd.Parameters.Add("@Uname", SqlDbType.VarChar).Value = Username
    '            mscmd.Parameters.Add("@Pword", SqlDbType.VarChar).Value = Encrypt(Password)
    '            Using msread As OleDbDataReader = mscmd.ExecuteReader
    '                msread.Read()
    '                If msread.HasRows Then
    '                    User_Id = msread.Item(0)
    '                    UserNickname = msread.Item("Nickname").ToString
    '                    User_type = msread.Item("Usertype").ToString
    '                    Uname = msread.Item("Uname").ToString
    '                    Pword = Decrypt(msread.Item("Pword").ToString)
    '                    sql_Transaction_result = "Committed"
    '                Else
    '                    User_Id = Nothing
    '                End If
    '            End Using
    '        End Using
    '    End Using
    'End Sub
    Public Sub Login_QUERY(ByVal Username As String,
                           ByVal Password As String)
        Using mscon As New SqlConnection(msconString)
            mscon.Open()
            Using mscmd As SqlCommand = mscon.CreateCommand()
                mscmd.Connection = mscon
                mscmd.CommandText = "login_stp"
                mscmd.CommandType = CommandType.StoredProcedure

                mscmd.Parameters.Add("@Uname", SqlDbType.VarChar).Value = Username
                mscmd.Parameters.Add("@Pword", SqlDbType.VarChar).Value = Encrypt(Password)
                Using msread As SqlDataReader = mscmd.ExecuteReader
                    msread.Read()
                    If msread.HasRows Then
                        User_Id = msread.Item(0)
                        UserNickname = msread.Item("Nickname").ToString
                        User_type = msread.Item("Usertype").ToString
                        Uname = msread.Item("Uname").ToString
                        Pword = Decrypt(msread.Item("Pword").ToString)
                        sql_Transaction_result = "Committed"
                    Else
                        User_Id = Nothing
                    End If
                End Using
            End Using
        End Using
    End Sub

    Public Sub PrintRPT_QUERY(ByVal ModeString As String,
                              ByVal sqlQuery As String,
                              Optional A_id As Integer = Nothing)
        msDataAdapter = New SqlDataAdapter
        Dim mcgi_ds As New mcgi_ds

        Using mscon As New SqlConnection(msconString)
            mscon.Open()
            Using mscmd As SqlCommand = mscon.CreateCommand()
                transaction = mscon.BeginTransaction(IsolationLevel.RepeatableRead, ModeString)
                mscmd.Connection = mscon
                mscmd.Transaction = transaction
                mscmd.CommandText = "report_stp"
                mscmd.CommandType = CommandType.StoredProcedure
                mscmd.Parameters.Add("@todo", SqlDbType.VarChar).Value = ModeString
                mscmd.Parameters.Add("@A_id", SqlDbType.Int).Value = A_id

                If ModeString = "Member_Info" Then
                    msDataAdapter.SelectCommand = mscmd
                    msDataAdapter.Fill(mcgi_ds.Member_Info)
                    Print_Report.Member_InfoBindingSource.DataSource = mcgi_ds.Member_Info.DefaultView
                ElseIf ModeString = "Report_Info" Then
                    msDataAdapter.SelectCommand = mscmd
                    msDataAdapter.Fill(mcgi_ds.Report_Info)
                    Print_Report.Report_InfoBindingSource.DataSource = mcgi_ds.Report_Info.DefaultView
                End If
                transaction.Commit()
            End Using
        End Using
    End Sub
    Public Sub Get_QUERY(ByVal sqlQuery As String)
        Using mscon As New SqlConnection(msconString)
            mscon.Open()
            Using mscmd As SqlCommand = mscon.CreateCommand()
                mscmd.Connection = mscon
                mscmd.CommandText = sqlQuery
                mscmd.CommandType = CommandType.Text
                Using msread As SqlDataReader = mscmd.ExecuteReader
                    If msread.Read() Then
                        Max_ID = msread.Item(0)
                    Else
                        Max_ID = 0
                    End If
                End Using
            End Using
        End Using
    End Sub
    Public Function TABLGETMaxID_STP2(ByVal TBL_NAME As String,
                                      ByVal COL_NAME As String,
                                      Optional StoredProcedureName As String = "A_GLOBAL_stp_GetMaxID") As Integer
        Using sqlcon As New SqlConnection(msconString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                sqlCommand.Connection = sqlcon
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.Add("@TBL_NAME", SqlDbType.VarChar).Value = TBL_NAME
                sqlCommand.Parameters.Add("@COL_NAME", SqlDbType.VarChar).Value = COL_NAME

                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    read.Read()
                    Return read.Item("MAXID")
                End Using

                sql_Transaction_result = "Committed"

            End Using
        End Using
    End Function

End Module
