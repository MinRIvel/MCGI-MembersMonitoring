Imports System.ComponentModel
Imports System.Threading.Thread
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

        Label_status = "Checking files."
        BGW.RunWorkerAsync()
    End Sub
    Dim sqlquery, Label_status As String
    Dim chk_DB, chk_MItb, chk_RItb, chk_UItb As Boolean
    Private Sub BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            For i = 0 To 100
                If Label_status = "Checking files." And i = 10 Then
                    If IO.File.Exists(Application.StartupPath & "\mcgidb.accdb") = True Then
                        chk_DB = True
                    Else
                        CreateAccessDatabase(Application.StartupPath & "\mcgidb.accdb")
                        Label_status = "Checking tables."
                        chk_DB = False
                    End If
                End If

                If chk_DB = True And i = 20 Then
                    Label_status = "Checking tables."

                ElseIf chk_DB = False And i = 20 Then
                    Label_status = "Creating database."
                    CreateAccessDatabase(Application.StartupPath & "\mcgidb.accdb")

                End If

                If i = 30 Then
                    Label_status = "Checking Member_Information."
                End If

                If Label_status = "Checking Member_Information." And i = 40 Then
                    If Checking_Query("Member_Information") = 0 Then
                        chk_MItb = False
                    Else
                        chk_MItb = True
                    End If
                End If

                If chk_MItb = True And i = 50 Then
                    Label_status = "Checking Report_Information."
                ElseIf chk_MItb = False And i = 50 Then
                    Label_status = "Creating Member_Information."
                End If

                If Label_status = "Creating Member_Information." And i = 55 Then
                    sqlquery = "Create table Member_Information (A_id INTEGER PRIMARY KEY UNIQUE,
                                                                         ID_Number LONGTEXT UNIQUE,
                                                                         Last_Name TEXT,
                                                                         First_Name TEXT,
                                                                         Middle_Name TEXT,
                                                                         Address LONGTEXT,
                                                                         Contact_Number TEXT,
                                                                         Occupation TEXT,
                                                                         Skill TEXT,
                                                                         Baptism_Date DateTime,
                                                                         Baptized_By TEXT,
                                                                         Nagakay TEXT,
                                                                         Image_Location TEXT,
                                                                         Row_Status YesNo,
                                                                         Inputted_By TEXT)"
                    Creation_Query(sqlquery)
                    Label_status = "Checking Report_Information."
                End If

                If Label_status = "Checking Report_Information." And i = 60 Then
                    If Checking_Query("Report_Information") = 0 Then
                        chk_RItb = False
                    Else
                        chk_RItb = True
                    End If
                End If

                If chk_RItb = True And i = 65 Then
                    Label_status = "Checking User_Information."
                ElseIf chk_RItb = False And i = 65 Then
                    Label_status = "Creating Report_Information."
                End If

                If Label_status = "Creating Report_Information." And i = 70 Then
                    sqlquery = "Create table Report_Information (R_Id INTEGER PRIMARY KEY UNIQUE,
                                                                         A_Id_Ref INTEGER,
                                                                         Report_Status LONGTEXT,
                                                                         Report_Date DateTime,
                                                                         Report_RowStatus YesNo,
                                                                         Inputted_By TEXT)"
                    Creation_Query(sqlquery)
                    Label_status = "Checking User_Information."
                End If

                If Label_status = "Checking User_Information." And i = 75 Then
                    If Checking_Query("User_Information") = 0 Then
                        chk_UItb = False
                    Else
                        chk_UItb = True
                    End If
                End If

                If chk_UItb = True And i = 80 Then
                    Label_status = "Checking default admin user."
                ElseIf chk_UItb = False And i = 80 Then
                    Label_status = "Creating User_Information."
                End If

                If Label_status = "Creating User_Information." And i = 85 Then
                    sqlquery = "Create table User_Information   (U_id INTEGER PRIMARY KEY UNIQUE,
                                                                         Usertype TEXT,
                                                                         Last_Name TEXT,
                                                                         First_Name TEXT,
                                                                         Middle_Name TEXT,
                                                                         Nickname TEXT,
                                                                         Uname TEXT,
                                                                         Pword TEXT)"
                    Creation_Query(sqlquery)
                    Label_status = "Checking default admin user."
                End If

                If Label_status = "Checking default admin user." And i = 90 Then
                    sqlquery = "SELECT * FROM User_Information where U_id = 1"
                    Get_QUERY(sqlquery)
                End If

                If Max_ID = 0 And i = 95 Then
                    sqlquery = "Insert into User_Information         (U_id
                                                                             ,Usertype
                                                                             ,Last_Name
                                                                             ,First_Name
                                                                             ,Middle_Name
                                                                             ,Nickname
                                                                             ,Uname
                                                                             ,Pword)
                                                                    VALUES   (@U_id
                                                                             ,@Usertype
                                                                             ,@Last_Name
                                                                             ,@First_Name
                                                                             ,@Middle_Name
                                                                             ,@Nickname
                                                                             ,@Uname
                                                                             ,@Pword)"
                    UserInfo_QUERY("SaveDefaultAdminTrans", sqlquery, 1, "Admin", "Admin", "Admin", "Admin", "Admin", "admin", "admin")
                    Label_status = "Finished"

                ElseIf Max_ID <> 0 And i = 95 Then
                    Label_status = "Finished"

                End If
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
            Splash_Lbl.Text = Label_status
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
