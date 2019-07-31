Imports Microsoft.Reporting.WinForms

Public Class Print_Report
    Public Image_Location As String
    Private Sub Print_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.PageWidth
        Dim parameter As New ReportParameter(“ImageLocation”, "File:\" & Image_Location)
        ReportViewer1.LocalReport.SetParameters(parameter)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class