Imports System.Data.OleDb
Imports System.IO
Imports ComponentFactory.Krypton.Toolkit
Module Queries
    Public Log_File As StreamWriter
    Public msconString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\mcgidb.accdb"
    Public msDataAdapter As OleDbDataAdapter
    Public msDataSet As New DataSet
    Public msBindingSource As BindingSource
    Public homepageDGV_BS As New BindingSource
    Public ReportDGV_BS As New BindingSource
    'Public transaction As OleDbTransaction
    Public sql_Transaction_result As String
    Public Max_ID As Integer
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
    Public Sub log_file_writer(ByVal Err_StackTrace As String)
        Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
        Log_File.WriteLine("Logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                           "Trace: " & Err_StackTrace & vbCrLf)
        Log_File.Close()
    End Sub
    Public Sub HOMEPAGE_QUERY(ByVal dsTbl_Command As String,
                              ByVal sqlQuery As String,
                              Optional SearchStr As String = Nothing,
                              Optional ID_Number As String = Nothing,
                              Optional Last_Name As String = Nothing,
                              Optional First_Name As String = Nothing,
                              Optional Middle_Name As String = Nothing,
                              Optional Address As String = Nothing,
                              Optional Contact_Number As String = Nothing,
                              Optional Occupation As String = Nothing,
                              Optional Skill As String = Nothing,
                              Optional Baptism_Date As Date = Nothing,
                              Optional Baptized_By As String = Nothing,
                              Optional Nagakay As String = Nothing,
                              Optional Image_Location As String = Nothing,
                              Optional A_id As Integer = 0)
        msDataAdapter = New OleDbDataAdapter
        msBindingSource = New BindingSource
        msDataSet = New DataSet
        If msDataSet.Tables.Contains(dsTbl_Command) Then
            msDataSet.Tables(dsTbl_Command).Clear()
        End If
        Using mscon As New OleDbConnection(msconString)
            mscon.Open()
            Using mscmd As OleDbCommand = mscon.CreateCommand()
                mscmd.Connection = mscon
                mscmd.CommandText = sqlQuery
                mscmd.CommandType = CommandType.Text
                If dsTbl_Command.Contains("Trans") = False And dsTbl_Command <> "Load_ReportDGV" Then
                    mscmd.Parameters.Add("@SearchStr", OleDbType.VarChar).Value = "%" & SearchStr & "%"

                ElseIf dsTbl_Command.Contains("Save") Then
                    mscmd.Parameters.Add("@Max_ID", OleDbType.Integer).Value = Max_ID + 1
                    mscmd.Parameters.Add("@Image_Location", OleDbType.VarChar).Value = Image_Location
                End If
                If dsTbl_Command <> "UpdatePictureTrans" And
                   dsTbl_Command.Contains("Delete") = False And
                   dsTbl_Command <> "Load_ReportDGV" Then
                    mscmd.Parameters.Add("@ID_Number", OleDbType.VarChar).Value = ID_Number
                    mscmd.Parameters.Add("@Last_Name", OleDbType.VarChar).Value = Last_Name
                    mscmd.Parameters.Add("@First_Name", OleDbType.VarChar).Value = First_Name
                    mscmd.Parameters.Add("@Middle_Name", OleDbType.VarChar).Value = Middle_Name
                    mscmd.Parameters.Add("@Address", OleDbType.VarChar).Value = Address
                    mscmd.Parameters.Add("@Contact_Number", OleDbType.VarChar).Value = Contact_Number
                    mscmd.Parameters.Add("@Occupation", OleDbType.VarChar).Value = Occupation
                    mscmd.Parameters.Add("@Skill", OleDbType.VarChar).Value = Skill
                    mscmd.Parameters.Add("@Baptism_Date", OleDbType.DBDate).Value = Baptism_Date.ToString("MMM. dd, yyyy")
                    mscmd.Parameters.Add("@Baptized_By", OleDbType.VarChar).Value = Baptized_By
                    mscmd.Parameters.Add("@Nagakay", OleDbType.VarChar).Value = Nagakay
                End If

                If dsTbl_Command = "UpdatePictureTrans" Then
                    mscmd.Parameters.Add("@Image_Location", OleDbType.VarChar).Value = Image_Location
                End If

                If dsTbl_Command.Contains("Update") Then
                    mscmd.Parameters.Add("@A_id", OleDbType.Integer).Value = A_id
                End If

                If dsTbl_Command = "Load_ReportDGV" Then
                    mscmd.Parameters.Add("@A_id_Ref", OleDbType.Integer).Value = A_id
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
    Public Sub Get_QUERY(ByVal sqlQuery As String)
        Using mscon As New OleDbConnection(msconString)
            mscon.Open()
            Using mscmd As OleDbCommand = mscon.CreateCommand()
                mscmd.Connection = mscon
                mscmd.CommandText = sqlQuery
                mscmd.CommandType = CommandType.Text
                Using msread As OleDbDataReader = mscmd.ExecuteReader
                    If msread.Read() Then
                        Max_ID = msread.Item(0)
                    Else
                        Max_ID = 0
                    End If
                End Using
            End Using
        End Using
    End Sub
End Module
