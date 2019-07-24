Imports System.Data.OleDb
Imports ComponentFactory.Krypton.Toolkit
Module Queries
    Public msconString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\mcgidb.accdb"
    Public msDataAdapter As OleDbDataAdapter
    Public msDataSet As New DataSet
    Public msBindingSource As BindingSource
    'Public transaction As OleDbTransaction
    Public sql_Transaction_result As String
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

    Public Sub HOMEPAGE_QUERY(ByVal dsTbl_Command As String,
                              ByVal sqlQuery As String,
                              Optional SearchStr As String = Nothing)
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
                mscmd.Parameters.Add("@SearchStr", OleDbType.VarChar).Value = "%" & SearchStr & "%"
                mscmd.ExecuteNonQuery()

                sql_Transaction_result = "Committed"

                If dsTbl_Command.Contains("Trans") = False Then
                    msDataAdapter.SelectCommand = mscmd
                    msDataAdapter.Fill(msDataSet, dsTbl_Command)
                    msBindingSource.DataSource = msDataSet
                    msBindingSource.DataMember = dsTbl_Command
                End If
            End Using
        End Using
    End Sub

End Module
