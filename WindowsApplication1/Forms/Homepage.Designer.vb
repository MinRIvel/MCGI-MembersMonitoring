<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Homepage
    Inherits Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homepage))
        Me.EP_Pnl = New System.Windows.Forms.Panel()
        Me.Body_Pnl = New System.Windows.Forms.Panel()
        Me.Homepage_Split = New System.Windows.Forms.SplitContainer()
        Me.Left_Pnl = New System.Windows.Forms.Panel()
        Me.Info_Pnl = New System.Windows.Forms.Panel()
        Me.Clear_Btn = New MetroFramework.Controls.MetroButton()
        Me.Save_Btn = New MetroFramework.Controls.MetroButton()
        Me.Cancel_Btn = New MetroFramework.Controls.MetroButton()
        Me.NagAkay_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.ID_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.BaptizedBy_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Lname_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Baptism_DTP = New MetroFramework.Controls.MetroDateTime()
        Me.Fname_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Skill_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Mname_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Work_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Address_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Contact_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Side_Pnl = New System.Windows.Forms.Panel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.DGV_Pnl = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DateTime_Lbl = New MetroFramework.Controls.MetroLabel()
        Me.Header_Lbl = New MetroFramework.Controls.MetroLabel()
        Me.Homepage_Cmenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Image_OPFD = New System.Windows.Forms.OpenFileDialog()
        Me.Homepage_Ttip = New MetroFramework.Components.MetroToolTip()
        Me.Homepage_Menu = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeUNPWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTime_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ChangePicture_Pnl = New System.Windows.Forms.Panel()
        Me.ChangePicBody_Pnl = New System.Windows.Forms.Panel()
        Me.ChangePictureHeader_Pnl = New System.Windows.Forms.Panel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.ChangePicAccept_Btn = New MetroFramework.Controls.MetroButton()
        Me.ChangePicExit_Btn = New MetroFramework.Controls.MetroButton()
        Me.Search_Pnl = New System.Windows.Forms.Panel()
        Me.Search_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.SearchHeader_Pnl = New System.Windows.Forms.Panel()
        Me.SearchPnlExit_Btn = New MetroFramework.Controls.MetroButton()
        Me.InputStatus_Pnl = New System.Windows.Forms.Panel()
        Me.IS_Split = New System.Windows.Forms.SplitContainer()
        Me.ISTop_Pnl = New System.Windows.Forms.Panel()
        Me.ISBot_Pnl = New System.Windows.Forms.Panel()
        Me.ISCancel_Btn = New MetroFramework.Controls.MetroButton()
        Me.SearchIS_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.ReportDate_DTP = New MetroFramework.Controls.MetroDateTime()
        Me.ISAdd_Btn = New MetroFramework.Controls.MetroButton()
        Me.ISReport_RTF = New System.Windows.Forms.RichTextBox()
        Me.InputStatusHdr_Pnl = New System.Windows.Forms.Panel()
        Me.ISHdr_Lbl = New MetroFramework.Controls.MetroLabel()
        Me.ISExit_Btn = New MetroFramework.Controls.MetroButton()
        Me.StatusReport_Cmenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ISEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ISDeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUser_Pnl = New System.Windows.Forms.Panel()
        Me.AddUserBdy_Pnl = New System.Windows.Forms.Panel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.UsrNickname_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.UsrMname_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.UsrFname_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.UsrLname_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.Usertype_Cbox = New System.Windows.Forms.ComboBox()
        Me.AddUserHdr_Pnl = New System.Windows.Forms.Panel()
        Me.AddUserAcpt_Btn = New MetroFramework.Controls.MetroButton()
        Me.AddUserHdr_Lbl = New MetroFramework.Controls.MetroLabel()
        Me.AddUserExit_Btn = New MetroFramework.Controls.MetroButton()
        Me.ChangeUNPW_Pnl = New System.Windows.Forms.Panel()
        Me.ChangeUNPWBdy_Pnl = New System.Windows.Forms.Panel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.OldPass_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.Password_Chk = New MetroFramework.Controls.MetroCheckBox()
        Me.Username_Chk = New MetroFramework.Controls.MetroCheckBox()
        Me.Retype_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Password_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Username_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.ChangeUNPWHdr_Pnl = New System.Windows.Forms.Panel()
        Me.ChangeUNPWAcpt_Btn = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.ChangeUNPWExit_Btn = New MetroFramework.Controls.MetroButton()
        Me.ChangePic_Pbox = New System.Windows.Forms.PictureBox()
        Me.Image_Pbox = New System.Windows.Forms.PictureBox()
        Me.Side_Btn = New MetroFramework.Controls.MetroButton()
        Me.LoadingPB2 = New System.Windows.Forms.PictureBox()
        Me.EP_Pnl.SuspendLayout()
        Me.Body_Pnl.SuspendLayout()
        CType(Me.Homepage_Split, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Homepage_Split.Panel1.SuspendLayout()
        Me.Homepage_Split.Panel2.SuspendLayout()
        Me.Homepage_Split.SuspendLayout()
        Me.Left_Pnl.SuspendLayout()
        Me.Info_Pnl.SuspendLayout()
        Me.Side_Pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Homepage_Cmenu.SuspendLayout()
        Me.Homepage_Menu.SuspendLayout()
        Me.ChangePicture_Pnl.SuspendLayout()
        Me.ChangePicBody_Pnl.SuspendLayout()
        Me.ChangePictureHeader_Pnl.SuspendLayout()
        Me.Search_Pnl.SuspendLayout()
        Me.SearchHeader_Pnl.SuspendLayout()
        Me.InputStatus_Pnl.SuspendLayout()
        CType(Me.IS_Split, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IS_Split.Panel1.SuspendLayout()
        Me.IS_Split.Panel2.SuspendLayout()
        Me.IS_Split.SuspendLayout()
        Me.ISBot_Pnl.SuspendLayout()
        Me.InputStatusHdr_Pnl.SuspendLayout()
        Me.StatusReport_Cmenu.SuspendLayout()
        Me.AddUser_Pnl.SuspendLayout()
        Me.AddUserBdy_Pnl.SuspendLayout()
        Me.AddUserHdr_Pnl.SuspendLayout()
        Me.ChangeUNPW_Pnl.SuspendLayout()
        Me.ChangeUNPWBdy_Pnl.SuspendLayout()
        Me.ChangeUNPWHdr_Pnl.SuspendLayout()
        CType(Me.ChangePic_Pbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image_Pbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadingPB2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EP_Pnl
        '
        Me.EP_Pnl.BackColor = System.Drawing.Color.White
        Me.EP_Pnl.Controls.Add(Me.Body_Pnl)
        Me.EP_Pnl.Controls.Add(Me.Panel6)
        Me.EP_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EP_Pnl.Location = New System.Drawing.Point(0, 24)
        Me.EP_Pnl.Name = "EP_Pnl"
        Me.EP_Pnl.Padding = New System.Windows.Forms.Padding(1)
        Me.EP_Pnl.Size = New System.Drawing.Size(1008, 587)
        Me.EP_Pnl.TabIndex = 12
        '
        'Body_Pnl
        '
        Me.Body_Pnl.BackColor = System.Drawing.SystemColors.Control
        Me.Body_Pnl.Controls.Add(Me.Homepage_Split)
        Me.Body_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Body_Pnl.Location = New System.Drawing.Point(1, 37)
        Me.Body_Pnl.Name = "Body_Pnl"
        Me.Body_Pnl.Padding = New System.Windows.Forms.Padding(3)
        Me.Body_Pnl.Size = New System.Drawing.Size(1006, 549)
        Me.Body_Pnl.TabIndex = 4
        '
        'Homepage_Split
        '
        Me.Homepage_Split.BackColor = System.Drawing.SystemColors.Control
        Me.Homepage_Split.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Homepage_Split.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Homepage_Split.Location = New System.Drawing.Point(3, 3)
        Me.Homepage_Split.Name = "Homepage_Split"
        '
        'Homepage_Split.Panel1
        '
        Me.Homepage_Split.Panel1.Controls.Add(Me.Left_Pnl)
        Me.Homepage_Split.Panel1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Homepage_Split.Panel1MinSize = 30
        '
        'Homepage_Split.Panel2
        '
        Me.Homepage_Split.Panel2.Controls.Add(Me.DGV_Pnl)
        Me.Homepage_Split.Size = New System.Drawing.Size(1000, 543)
        Me.Homepage_Split.SplitterDistance = 268
        Me.Homepage_Split.TabIndex = 4
        '
        'Left_Pnl
        '
        Me.Left_Pnl.BackColor = System.Drawing.Color.White
        Me.Left_Pnl.Controls.Add(Me.Info_Pnl)
        Me.Left_Pnl.Controls.Add(Me.Side_Pnl)
        Me.Left_Pnl.Controls.Add(Me.Panel1)
        Me.Left_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Left_Pnl.Location = New System.Drawing.Point(0, 3)
        Me.Left_Pnl.Name = "Left_Pnl"
        Me.Left_Pnl.Size = New System.Drawing.Size(268, 540)
        Me.Left_Pnl.TabIndex = 0
        '
        'Info_Pnl
        '
        Me.Info_Pnl.AutoScroll = True
        Me.Info_Pnl.Controls.Add(Me.Image_Pbox)
        Me.Info_Pnl.Controls.Add(Me.Clear_Btn)
        Me.Info_Pnl.Controls.Add(Me.Save_Btn)
        Me.Info_Pnl.Controls.Add(Me.Cancel_Btn)
        Me.Info_Pnl.Controls.Add(Me.NagAkay_Tbox)
        Me.Info_Pnl.Controls.Add(Me.ID_Tbox)
        Me.Info_Pnl.Controls.Add(Me.BaptizedBy_Tbox)
        Me.Info_Pnl.Controls.Add(Me.Lname_Tbox)
        Me.Info_Pnl.Controls.Add(Me.Baptism_DTP)
        Me.Info_Pnl.Controls.Add(Me.Fname_Tbox)
        Me.Info_Pnl.Controls.Add(Me.Skill_Tbox)
        Me.Info_Pnl.Controls.Add(Me.Mname_Tbox)
        Me.Info_Pnl.Controls.Add(Me.Work_Tbox)
        Me.Info_Pnl.Controls.Add(Me.Address_Tbox)
        Me.Info_Pnl.Controls.Add(Me.Contact_Tbox)
        Me.Info_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Info_Pnl.Location = New System.Drawing.Point(0, 35)
        Me.Info_Pnl.Name = "Info_Pnl"
        Me.Info_Pnl.Size = New System.Drawing.Size(238, 505)
        Me.Info_Pnl.TabIndex = 0
        '
        'Clear_Btn
        '
        Me.Clear_Btn.Location = New System.Drawing.Point(138, 69)
        Me.Clear_Btn.Name = "Clear_Btn"
        Me.Clear_Btn.Size = New System.Drawing.Size(65, 23)
        Me.Clear_Btn.TabIndex = 841
        Me.Clear_Btn.Text = "Clear"
        Me.Clear_Btn.UseSelectable = True
        '
        'Save_Btn
        '
        Me.Save_Btn.Location = New System.Drawing.Point(138, 98)
        Me.Save_Btn.Name = "Save_Btn"
        Me.Save_Btn.Size = New System.Drawing.Size(65, 23)
        Me.Save_Btn.Style = MetroFramework.MetroColorStyle.Black
        Me.Save_Btn.TabIndex = 840
        Me.Save_Btn.Text = "Save"
        Me.Save_Btn.UseSelectable = True
        Me.Save_Btn.UseStyleColors = True
        '
        'Cancel_Btn
        '
        Me.Cancel_Btn.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.Cancel_Btn.Location = New System.Drawing.Point(209, 98)
        Me.Cancel_Btn.Name = "Cancel_Btn"
        Me.Cancel_Btn.Size = New System.Drawing.Size(23, 23)
        Me.Cancel_Btn.TabIndex = 842
        Me.Cancel_Btn.Text = "X"
        Me.Cancel_Btn.UseSelectable = True
        '
        'NagAkay_Tbox
        '
        Me.NagAkay_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.NagAkay_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NagAkay_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.NagAkay_Tbox.CustomButton.Location = New System.Drawing.Point(196, 1)
        Me.NagAkay_Tbox.CustomButton.Name = ""
        Me.NagAkay_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.NagAkay_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.NagAkay_Tbox.CustomButton.TabIndex = 1
        Me.NagAkay_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.NagAkay_Tbox.CustomButton.UseSelectable = True
        Me.NagAkay_Tbox.CustomButton.Visible = False
        Me.NagAkay_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.NagAkay_Tbox.ForeColor = System.Drawing.Color.Black
        Me.NagAkay_Tbox.Lines = New String(-1) {}
        Me.NagAkay_Tbox.Location = New System.Drawing.Point(17, 459)
        Me.NagAkay_Tbox.MaxLength = 32767
        Me.NagAkay_Tbox.Name = "NagAkay_Tbox"
        Me.NagAkay_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NagAkay_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.NagAkay_Tbox.SelectedText = ""
        Me.NagAkay_Tbox.SelectionLength = 0
        Me.NagAkay_Tbox.SelectionStart = 0
        Me.NagAkay_Tbox.ShowClearButton = True
        Me.NagAkay_Tbox.Size = New System.Drawing.Size(222, 27)
        Me.NagAkay_Tbox.TabIndex = 839
        Me.NagAkay_Tbox.UseCustomForeColor = True
        Me.NagAkay_Tbox.UseSelectable = True
        Me.NagAkay_Tbox.WaterMark = "Nag-akay"
        Me.NagAkay_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.NagAkay_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ID_Tbox
        '
        Me.ID_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.ID_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_Tbox.CustomButton.Image = Nothing
        Me.ID_Tbox.CustomButton.Location = New System.Drawing.Point(196, 1)
        Me.ID_Tbox.CustomButton.Name = ""
        Me.ID_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.ID_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.ID_Tbox.CustomButton.TabIndex = 1
        Me.ID_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ID_Tbox.CustomButton.UseSelectable = True
        Me.ID_Tbox.CustomButton.Visible = False
        Me.ID_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.ID_Tbox.ForeColor = System.Drawing.Color.Black
        Me.ID_Tbox.Lines = New String(-1) {}
        Me.ID_Tbox.Location = New System.Drawing.Point(17, 127)
        Me.ID_Tbox.MaxLength = 32767
        Me.ID_Tbox.Name = "ID_Tbox"
        Me.ID_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ID_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ID_Tbox.SelectedText = ""
        Me.ID_Tbox.SelectionLength = 0
        Me.ID_Tbox.SelectionStart = 0
        Me.ID_Tbox.ShowClearButton = True
        Me.ID_Tbox.Size = New System.Drawing.Size(222, 27)
        Me.ID_Tbox.Style = MetroFramework.MetroColorStyle.Red
        Me.ID_Tbox.TabIndex = 829
        Me.ID_Tbox.UseCustomForeColor = True
        Me.ID_Tbox.UseSelectable = True
        Me.ID_Tbox.WaterMark = "ID Number"
        Me.ID_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ID_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BaptizedBy_Tbox
        '
        Me.BaptizedBy_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.BaptizedBy_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BaptizedBy_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.BaptizedBy_Tbox.CustomButton.Location = New System.Drawing.Point(196, 1)
        Me.BaptizedBy_Tbox.CustomButton.Name = ""
        Me.BaptizedBy_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.BaptizedBy_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.BaptizedBy_Tbox.CustomButton.TabIndex = 1
        Me.BaptizedBy_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.BaptizedBy_Tbox.CustomButton.UseSelectable = True
        Me.BaptizedBy_Tbox.CustomButton.Visible = False
        Me.BaptizedBy_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.BaptizedBy_Tbox.ForeColor = System.Drawing.Color.Black
        Me.BaptizedBy_Tbox.Lines = New String(-1) {}
        Me.BaptizedBy_Tbox.Location = New System.Drawing.Point(17, 426)
        Me.BaptizedBy_Tbox.MaxLength = 32767
        Me.BaptizedBy_Tbox.Name = "BaptizedBy_Tbox"
        Me.BaptizedBy_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BaptizedBy_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.BaptizedBy_Tbox.SelectedText = ""
        Me.BaptizedBy_Tbox.SelectionLength = 0
        Me.BaptizedBy_Tbox.SelectionStart = 0
        Me.BaptizedBy_Tbox.ShowClearButton = True
        Me.BaptizedBy_Tbox.Size = New System.Drawing.Size(222, 27)
        Me.BaptizedBy_Tbox.TabIndex = 838
        Me.BaptizedBy_Tbox.UseCustomForeColor = True
        Me.BaptizedBy_Tbox.UseSelectable = True
        Me.BaptizedBy_Tbox.WaterMark = "Baptized by"
        Me.BaptizedBy_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BaptizedBy_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Lname_Tbox
        '
        Me.Lname_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Lname_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lname_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.Lname_Tbox.CustomButton.Location = New System.Drawing.Point(196, 1)
        Me.Lname_Tbox.CustomButton.Name = ""
        Me.Lname_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Lname_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Lname_Tbox.CustomButton.TabIndex = 1
        Me.Lname_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Lname_Tbox.CustomButton.UseSelectable = True
        Me.Lname_Tbox.CustomButton.Visible = False
        Me.Lname_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Lname_Tbox.ForeColor = System.Drawing.Color.Black
        Me.Lname_Tbox.Lines = New String(-1) {}
        Me.Lname_Tbox.Location = New System.Drawing.Point(17, 160)
        Me.Lname_Tbox.MaxLength = 32767
        Me.Lname_Tbox.Name = "Lname_Tbox"
        Me.Lname_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Lname_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Lname_Tbox.SelectedText = ""
        Me.Lname_Tbox.SelectionLength = 0
        Me.Lname_Tbox.SelectionStart = 0
        Me.Lname_Tbox.ShowClearButton = True
        Me.Lname_Tbox.Size = New System.Drawing.Size(222, 27)
        Me.Lname_Tbox.Style = MetroFramework.MetroColorStyle.Red
        Me.Lname_Tbox.TabIndex = 830
        Me.Lname_Tbox.UseCustomForeColor = True
        Me.Lname_Tbox.UseSelectable = True
        Me.Lname_Tbox.WaterMark = "Last Name"
        Me.Lname_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Lname_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Baptism_DTP
        '
        Me.Baptism_DTP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Baptism_DTP.Location = New System.Drawing.Point(17, 391)
        Me.Baptism_DTP.MinimumSize = New System.Drawing.Size(0, 29)
        Me.Baptism_DTP.Name = "Baptism_DTP"
        Me.Baptism_DTP.Size = New System.Drawing.Size(222, 29)
        Me.Baptism_DTP.TabIndex = 837
        '
        'Fname_Tbox
        '
        Me.Fname_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Fname_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fname_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.Fname_Tbox.CustomButton.Location = New System.Drawing.Point(196, 1)
        Me.Fname_Tbox.CustomButton.Name = ""
        Me.Fname_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Fname_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Fname_Tbox.CustomButton.TabIndex = 1
        Me.Fname_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Fname_Tbox.CustomButton.UseSelectable = True
        Me.Fname_Tbox.CustomButton.Visible = False
        Me.Fname_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Fname_Tbox.ForeColor = System.Drawing.Color.Black
        Me.Fname_Tbox.Lines = New String(-1) {}
        Me.Fname_Tbox.Location = New System.Drawing.Point(17, 193)
        Me.Fname_Tbox.MaxLength = 32767
        Me.Fname_Tbox.Name = "Fname_Tbox"
        Me.Fname_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Fname_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Fname_Tbox.SelectedText = ""
        Me.Fname_Tbox.SelectionLength = 0
        Me.Fname_Tbox.SelectionStart = 0
        Me.Fname_Tbox.ShowClearButton = True
        Me.Fname_Tbox.Size = New System.Drawing.Size(222, 27)
        Me.Fname_Tbox.Style = MetroFramework.MetroColorStyle.Red
        Me.Fname_Tbox.TabIndex = 831
        Me.Fname_Tbox.UseCustomForeColor = True
        Me.Fname_Tbox.UseSelectable = True
        Me.Fname_Tbox.WaterMark = "First Name"
        Me.Fname_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Fname_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Skill_Tbox
        '
        Me.Skill_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Skill_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Skill_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.Skill_Tbox.CustomButton.Location = New System.Drawing.Point(196, 1)
        Me.Skill_Tbox.CustomButton.Name = ""
        Me.Skill_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Skill_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Skill_Tbox.CustomButton.TabIndex = 1
        Me.Skill_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Skill_Tbox.CustomButton.UseSelectable = True
        Me.Skill_Tbox.CustomButton.Visible = False
        Me.Skill_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Skill_Tbox.ForeColor = System.Drawing.Color.Black
        Me.Skill_Tbox.Lines = New String(-1) {}
        Me.Skill_Tbox.Location = New System.Drawing.Point(17, 358)
        Me.Skill_Tbox.MaxLength = 32767
        Me.Skill_Tbox.Name = "Skill_Tbox"
        Me.Skill_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Skill_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Skill_Tbox.SelectedText = ""
        Me.Skill_Tbox.SelectionLength = 0
        Me.Skill_Tbox.SelectionStart = 0
        Me.Skill_Tbox.ShowClearButton = True
        Me.Skill_Tbox.Size = New System.Drawing.Size(222, 27)
        Me.Skill_Tbox.TabIndex = 836
        Me.Skill_Tbox.UseCustomForeColor = True
        Me.Skill_Tbox.UseSelectable = True
        Me.Skill_Tbox.WaterMark = "Skill"
        Me.Skill_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Skill_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Mname_Tbox
        '
        Me.Mname_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Mname_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mname_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.Mname_Tbox.CustomButton.Location = New System.Drawing.Point(196, 1)
        Me.Mname_Tbox.CustomButton.Name = ""
        Me.Mname_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Mname_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Mname_Tbox.CustomButton.TabIndex = 1
        Me.Mname_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Mname_Tbox.CustomButton.UseSelectable = True
        Me.Mname_Tbox.CustomButton.Visible = False
        Me.Mname_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Mname_Tbox.ForeColor = System.Drawing.Color.Black
        Me.Mname_Tbox.Lines = New String(-1) {}
        Me.Mname_Tbox.Location = New System.Drawing.Point(17, 226)
        Me.Mname_Tbox.MaxLength = 32767
        Me.Mname_Tbox.Name = "Mname_Tbox"
        Me.Mname_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Mname_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Mname_Tbox.SelectedText = ""
        Me.Mname_Tbox.SelectionLength = 0
        Me.Mname_Tbox.SelectionStart = 0
        Me.Mname_Tbox.ShowClearButton = True
        Me.Mname_Tbox.Size = New System.Drawing.Size(222, 27)
        Me.Mname_Tbox.TabIndex = 832
        Me.Mname_Tbox.UseCustomForeColor = True
        Me.Mname_Tbox.UseSelectable = True
        Me.Mname_Tbox.WaterMark = "Middle Name"
        Me.Mname_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Mname_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Work_Tbox
        '
        Me.Work_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Work_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Work_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        Me.Work_Tbox.CustomButton.Location = New System.Drawing.Point(196, 1)
        Me.Work_Tbox.CustomButton.Name = ""
        Me.Work_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Work_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Work_Tbox.CustomButton.TabIndex = 1
        Me.Work_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Work_Tbox.CustomButton.UseSelectable = True
        Me.Work_Tbox.CustomButton.Visible = False
        Me.Work_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Work_Tbox.ForeColor = System.Drawing.Color.Black
        Me.Work_Tbox.Lines = New String(-1) {}
        Me.Work_Tbox.Location = New System.Drawing.Point(17, 325)
        Me.Work_Tbox.MaxLength = 32767
        Me.Work_Tbox.Name = "Work_Tbox"
        Me.Work_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Work_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Work_Tbox.SelectedText = ""
        Me.Work_Tbox.SelectionLength = 0
        Me.Work_Tbox.SelectionStart = 0
        Me.Work_Tbox.ShowClearButton = True
        Me.Work_Tbox.Size = New System.Drawing.Size(222, 27)
        Me.Work_Tbox.TabIndex = 835
        Me.Work_Tbox.UseCustomForeColor = True
        Me.Work_Tbox.UseSelectable = True
        Me.Work_Tbox.WaterMark = "Occupation"
        Me.Work_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Work_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Address_Tbox
        '
        Me.Address_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Address_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image7"), System.Drawing.Image)
        Me.Address_Tbox.CustomButton.Location = New System.Drawing.Point(196, 1)
        Me.Address_Tbox.CustomButton.Name = ""
        Me.Address_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Address_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Address_Tbox.CustomButton.TabIndex = 1
        Me.Address_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Address_Tbox.CustomButton.UseSelectable = True
        Me.Address_Tbox.CustomButton.Visible = False
        Me.Address_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Address_Tbox.ForeColor = System.Drawing.Color.Black
        Me.Address_Tbox.Lines = New String(-1) {}
        Me.Address_Tbox.Location = New System.Drawing.Point(17, 259)
        Me.Address_Tbox.MaxLength = 32767
        Me.Address_Tbox.Name = "Address_Tbox"
        Me.Address_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Address_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Address_Tbox.SelectedText = ""
        Me.Address_Tbox.SelectionLength = 0
        Me.Address_Tbox.SelectionStart = 0
        Me.Address_Tbox.ShowClearButton = True
        Me.Address_Tbox.Size = New System.Drawing.Size(222, 27)
        Me.Address_Tbox.Style = MetroFramework.MetroColorStyle.Red
        Me.Address_Tbox.TabIndex = 833
        Me.Address_Tbox.UseCustomForeColor = True
        Me.Address_Tbox.UseSelectable = True
        Me.Address_Tbox.WaterMark = "Address"
        Me.Address_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Address_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Contact_Tbox
        '
        Me.Contact_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Contact_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image8"), System.Drawing.Image)
        Me.Contact_Tbox.CustomButton.Location = New System.Drawing.Point(196, 1)
        Me.Contact_Tbox.CustomButton.Name = ""
        Me.Contact_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Contact_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Contact_Tbox.CustomButton.TabIndex = 1
        Me.Contact_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Contact_Tbox.CustomButton.UseSelectable = True
        Me.Contact_Tbox.CustomButton.Visible = False
        Me.Contact_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Contact_Tbox.ForeColor = System.Drawing.Color.Black
        Me.Contact_Tbox.Lines = New String(-1) {}
        Me.Contact_Tbox.Location = New System.Drawing.Point(17, 292)
        Me.Contact_Tbox.MaxLength = 32767
        Me.Contact_Tbox.Name = "Contact_Tbox"
        Me.Contact_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Contact_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Contact_Tbox.SelectedText = ""
        Me.Contact_Tbox.SelectionLength = 0
        Me.Contact_Tbox.SelectionStart = 0
        Me.Contact_Tbox.ShowClearButton = True
        Me.Contact_Tbox.Size = New System.Drawing.Size(222, 27)
        Me.Contact_Tbox.TabIndex = 834
        Me.Contact_Tbox.UseCustomForeColor = True
        Me.Contact_Tbox.UseSelectable = True
        Me.Contact_Tbox.WaterMark = "Contact Number"
        Me.Contact_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Contact_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Side_Pnl
        '
        Me.Side_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Side_Pnl.Controls.Add(Me.KryptonLabel1)
        Me.Side_Pnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.Side_Pnl.Location = New System.Drawing.Point(238, 35)
        Me.Side_Pnl.Name = "Side_Pnl"
        Me.Side_Pnl.Size = New System.Drawing.Size(30, 505)
        Me.Side_Pnl.TabIndex = 14
        Me.Side_Pnl.Visible = False
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl
        Me.KryptonLabel1.Location = New System.Drawing.Point(1, 163)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Orientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left
        Me.KryptonLabel1.Size = New System.Drawing.Size(28, 113)
        Me.KryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel1.StateNormal.ShortText.Color2 = System.Drawing.Color.Black
        Me.KryptonLabel1.StateNormal.ShortText.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Information"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Side_Btn)
        Me.Panel1.Controls.Add(Me.MetroLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 35)
        Me.Panel1.TabIndex = 13
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(5, 5)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(106, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Information"
        '
        'DGV_Pnl
        '
        Me.DGV_Pnl.BackColor = System.Drawing.Color.White
        Me.DGV_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Pnl.Location = New System.Drawing.Point(0, 0)
        Me.DGV_Pnl.Name = "DGV_Pnl"
        Me.DGV_Pnl.Size = New System.Drawing.Size(728, 543)
        Me.DGV_Pnl.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.DateTime_Lbl)
        Me.Panel6.Controls.Add(Me.Header_Lbl)
        Me.Panel6.Controls.Add(Me.LoadingPB2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(1, 1)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1006, 36)
        Me.Panel6.TabIndex = 1
        '
        'DateTime_Lbl
        '
        Me.DateTime_Lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTime_Lbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.DateTime_Lbl.Location = New System.Drawing.Point(506, 6)
        Me.DateTime_Lbl.Name = "DateTime_Lbl"
        Me.DateTime_Lbl.Size = New System.Drawing.Size(398, 25)
        Me.DateTime_Lbl.TabIndex = 626
        Me.DateTime_Lbl.Text = "Date and Time"
        Me.DateTime_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Header_Lbl
        '
        Me.Header_Lbl.AutoSize = True
        Me.Header_Lbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Header_Lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Header_Lbl.Location = New System.Drawing.Point(9, 6)
        Me.Header_Lbl.Name = "Header_Lbl"
        Me.Header_Lbl.Size = New System.Drawing.Size(123, 25)
        Me.Header_Lbl.TabIndex = 625
        Me.Header_Lbl.Text = "Welcome user"
        '
        'Homepage_Cmenu
        '
        Me.Homepage_Cmenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Homepage_Cmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ChangePictureToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.Homepage_Cmenu.Name = "Homepage_Cmenu"
        Me.Homepage_Cmenu.Size = New System.Drawing.Size(156, 114)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ChangePictureToolStripMenuItem
        '
        Me.ChangePictureToolStripMenuItem.Name = "ChangePictureToolStripMenuItem"
        Me.ChangePictureToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ChangePictureToolStripMenuItem.Text = "Change Picture"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ReportToolStripMenuItem.Text = "Status Report"
        '
        'InputToolStripMenuItem
        '
        Me.InputToolStripMenuItem.Name = "InputToolStripMenuItem"
        Me.InputToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InputToolStripMenuItem.Text = "Input"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'Image_OPFD
        '
        Me.Image_OPFD.Filter = "Image Files(*.JPG;*.JPEG;*.PNG;)|*.jpg;*.jpeg;*.png|All files(*.*)|*.*"
        Me.Image_OPFD.Title = "Select Image"
        '
        'Homepage_Ttip
        '
        Me.Homepage_Ttip.AutomaticDelay = 1
        Me.Homepage_Ttip.Style = MetroFramework.MetroColorStyle.Blue
        Me.Homepage_Ttip.StyleManager = Nothing
        Me.Homepage_Ttip.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'Homepage_Menu
        '
        Me.Homepage_Menu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Homepage_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AccountToolStripMenuItem, Me.AdminToolStripMenuItem})
        Me.Homepage_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Homepage_Menu.Name = "Homepage_Menu"
        Me.Homepage_Menu.Size = New System.Drawing.Size(1008, 24)
        Me.Homepage_Menu.TabIndex = 14
        Me.Homepage_Menu.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformationPanelToolStripMenuItem, Me.ReloadToolStripMenuItem, Me.BackupToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'InformationPanelToolStripMenuItem
        '
        Me.InformationPanelToolStripMenuItem.CheckOnClick = True
        Me.InformationPanelToolStripMenuItem.Name = "InformationPanelToolStripMenuItem"
        Me.InformationPanelToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.InformationPanelToolStripMenuItem.Text = "Information Panel"
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ReloadToolStripMenuItem.Text = "Reload (F5)"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.BackupToolStripMenuItem.Text = "Backup"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeUNPWToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.AccountToolStripMenuItem.Text = "Accounts"
        '
        'ChangeUNPWToolStripMenuItem
        '
        Me.ChangeUNPWToolStripMenuItem.Name = "ChangeUNPWToolStripMenuItem"
        Me.ChangeUNPWToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ChangeUNPWToolStripMenuItem.Text = "Change UN/PW"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'DateTime_Timer
        '
        Me.DateTime_Timer.Enabled = True
        Me.DateTime_Timer.Interval = 1000
        '
        'ChangePicture_Pnl
        '
        Me.ChangePicture_Pnl.BackColor = System.Drawing.Color.White
        Me.ChangePicture_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChangePicture_Pnl.Controls.Add(Me.ChangePicBody_Pnl)
        Me.ChangePicture_Pnl.Controls.Add(Me.ChangePictureHeader_Pnl)
        Me.ChangePicture_Pnl.Location = New System.Drawing.Point(350, 139)
        Me.ChangePicture_Pnl.MinimumSize = New System.Drawing.Size(270, 292)
        Me.ChangePicture_Pnl.Name = "ChangePicture_Pnl"
        Me.ChangePicture_Pnl.Size = New System.Drawing.Size(308, 333)
        Me.ChangePicture_Pnl.TabIndex = 19
        Me.ChangePicture_Pnl.Visible = False
        '
        'ChangePicBody_Pnl
        '
        Me.ChangePicBody_Pnl.Controls.Add(Me.ChangePic_Pbox)
        Me.ChangePicBody_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChangePicBody_Pnl.Location = New System.Drawing.Point(0, 25)
        Me.ChangePicBody_Pnl.Name = "ChangePicBody_Pnl"
        Me.ChangePicBody_Pnl.Padding = New System.Windows.Forms.Padding(3)
        Me.ChangePicBody_Pnl.Size = New System.Drawing.Size(306, 306)
        Me.ChangePicBody_Pnl.TabIndex = 4
        '
        'ChangePictureHeader_Pnl
        '
        Me.ChangePictureHeader_Pnl.BackColor = System.Drawing.Color.PowderBlue
        Me.ChangePictureHeader_Pnl.Controls.Add(Me.MetroLabel3)
        Me.ChangePictureHeader_Pnl.Controls.Add(Me.ChangePicAccept_Btn)
        Me.ChangePictureHeader_Pnl.Controls.Add(Me.ChangePicExit_Btn)
        Me.ChangePictureHeader_Pnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChangePictureHeader_Pnl.Location = New System.Drawing.Point(0, 0)
        Me.ChangePictureHeader_Pnl.Name = "ChangePictureHeader_Pnl"
        Me.ChangePictureHeader_Pnl.Size = New System.Drawing.Size(306, 25)
        Me.ChangePictureHeader_Pnl.TabIndex = 3
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(4, 3)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(102, 19)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Change Picture"
        Me.MetroLabel3.UseCustomBackColor = True
        '
        'ChangePicAccept_Btn
        '
        Me.ChangePicAccept_Btn.BackColor = System.Drawing.Color.Transparent
        Me.ChangePicAccept_Btn.Dock = System.Windows.Forms.DockStyle.Right
        Me.ChangePicAccept_Btn.ForeColor = System.Drawing.Color.Green
        Me.ChangePicAccept_Btn.Location = New System.Drawing.Point(244, 0)
        Me.ChangePicAccept_Btn.Name = "ChangePicAccept_Btn"
        Me.ChangePicAccept_Btn.Size = New System.Drawing.Size(31, 25)
        Me.ChangePicAccept_Btn.TabIndex = 2
        Me.ChangePicAccept_Btn.Text = "✔"
        Me.ChangePicAccept_Btn.UseCustomBackColor = True
        Me.ChangePicAccept_Btn.UseCustomForeColor = True
        Me.ChangePicAccept_Btn.UseSelectable = True
        '
        'ChangePicExit_Btn
        '
        Me.ChangePicExit_Btn.BackColor = System.Drawing.Color.Transparent
        Me.ChangePicExit_Btn.Dock = System.Windows.Forms.DockStyle.Right
        Me.ChangePicExit_Btn.Location = New System.Drawing.Point(275, 0)
        Me.ChangePicExit_Btn.Name = "ChangePicExit_Btn"
        Me.ChangePicExit_Btn.Size = New System.Drawing.Size(31, 25)
        Me.ChangePicExit_Btn.TabIndex = 0
        Me.ChangePicExit_Btn.Text = "X"
        Me.ChangePicExit_Btn.UseCustomBackColor = True
        Me.ChangePicExit_Btn.UseSelectable = True
        '
        'Search_Pnl
        '
        Me.Search_Pnl.BackColor = System.Drawing.Color.White
        Me.Search_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Search_Pnl.Controls.Add(Me.Search_Tbox)
        Me.Search_Pnl.Controls.Add(Me.SearchHeader_Pnl)
        Me.Search_Pnl.Location = New System.Drawing.Point(370, 262)
        Me.Search_Pnl.MaximumSize = New System.Drawing.Size(268, 86)
        Me.Search_Pnl.MinimumSize = New System.Drawing.Size(268, 86)
        Me.Search_Pnl.Name = "Search_Pnl"
        Me.Search_Pnl.Size = New System.Drawing.Size(268, 86)
        Me.Search_Pnl.TabIndex = 20
        Me.Search_Pnl.Visible = False
        '
        'Search_Tbox
        '
        '
        '
        '
        Me.Search_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image9"), System.Drawing.Image)
        Me.Search_Tbox.CustomButton.Location = New System.Drawing.Point(234, 1)
        Me.Search_Tbox.CustomButton.Name = ""
        Me.Search_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Search_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Search_Tbox.CustomButton.TabIndex = 1
        Me.Search_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Search_Tbox.CustomButton.UseSelectable = True
        Me.Search_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Search_Tbox.ForeColor = System.Drawing.Color.Black
        Me.Search_Tbox.Lines = New String(-1) {}
        Me.Search_Tbox.Location = New System.Drawing.Point(3, 36)
        Me.Search_Tbox.MaxLength = 32767
        Me.Search_Tbox.Name = "Search_Tbox"
        Me.Search_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Search_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Search_Tbox.SelectedText = ""
        Me.Search_Tbox.SelectionLength = 0
        Me.Search_Tbox.SelectionStart = 0
        Me.Search_Tbox.ShowButton = True
        Me.Search_Tbox.ShowClearButton = True
        Me.Search_Tbox.Size = New System.Drawing.Size(260, 27)
        Me.Search_Tbox.TabIndex = 830
        Me.Search_Tbox.UseSelectable = True
        Me.Search_Tbox.WaterMark = "Search here"
        Me.Search_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Search_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SearchHeader_Pnl
        '
        Me.SearchHeader_Pnl.BackColor = System.Drawing.Color.PowderBlue
        Me.SearchHeader_Pnl.Controls.Add(Me.SearchPnlExit_Btn)
        Me.SearchHeader_Pnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.SearchHeader_Pnl.Location = New System.Drawing.Point(0, 0)
        Me.SearchHeader_Pnl.Name = "SearchHeader_Pnl"
        Me.SearchHeader_Pnl.Size = New System.Drawing.Size(266, 25)
        Me.SearchHeader_Pnl.TabIndex = 3
        '
        'SearchPnlExit_Btn
        '
        Me.SearchPnlExit_Btn.BackColor = System.Drawing.Color.Transparent
        Me.SearchPnlExit_Btn.Dock = System.Windows.Forms.DockStyle.Right
        Me.SearchPnlExit_Btn.Location = New System.Drawing.Point(235, 0)
        Me.SearchPnlExit_Btn.Name = "SearchPnlExit_Btn"
        Me.SearchPnlExit_Btn.Size = New System.Drawing.Size(31, 25)
        Me.SearchPnlExit_Btn.TabIndex = 0
        Me.SearchPnlExit_Btn.Text = "X"
        Me.SearchPnlExit_Btn.UseCustomBackColor = True
        Me.SearchPnlExit_Btn.UseSelectable = True
        '
        'InputStatus_Pnl
        '
        Me.InputStatus_Pnl.BackColor = System.Drawing.Color.White
        Me.InputStatus_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputStatus_Pnl.Controls.Add(Me.IS_Split)
        Me.InputStatus_Pnl.Controls.Add(Me.InputStatusHdr_Pnl)
        Me.InputStatus_Pnl.Location = New System.Drawing.Point(41, 55)
        Me.InputStatus_Pnl.Name = "InputStatus_Pnl"
        Me.InputStatus_Pnl.Size = New System.Drawing.Size(926, 500)
        Me.InputStatus_Pnl.TabIndex = 21
        Me.InputStatus_Pnl.Visible = False
        '
        'IS_Split
        '
        Me.IS_Split.BackColor = System.Drawing.SystemColors.Control
        Me.IS_Split.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IS_Split.Location = New System.Drawing.Point(0, 25)
        Me.IS_Split.Name = "IS_Split"
        Me.IS_Split.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'IS_Split.Panel1
        '
        Me.IS_Split.Panel1.Controls.Add(Me.ISTop_Pnl)
        Me.IS_Split.Panel1.Padding = New System.Windows.Forms.Padding(3)
        '
        'IS_Split.Panel2
        '
        Me.IS_Split.Panel2.Controls.Add(Me.ISBot_Pnl)
        Me.IS_Split.Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.IS_Split.Size = New System.Drawing.Size(924, 473)
        Me.IS_Split.SplitterDistance = 262
        Me.IS_Split.SplitterWidth = 1
        Me.IS_Split.TabIndex = 0
        '
        'ISTop_Pnl
        '
        Me.ISTop_Pnl.BackColor = System.Drawing.Color.White
        Me.ISTop_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ISTop_Pnl.Location = New System.Drawing.Point(3, 3)
        Me.ISTop_Pnl.Name = "ISTop_Pnl"
        Me.ISTop_Pnl.Size = New System.Drawing.Size(918, 256)
        Me.ISTop_Pnl.TabIndex = 0
        '
        'ISBot_Pnl
        '
        Me.ISBot_Pnl.BackColor = System.Drawing.Color.White
        Me.ISBot_Pnl.Controls.Add(Me.ISCancel_Btn)
        Me.ISBot_Pnl.Controls.Add(Me.SearchIS_Tbox)
        Me.ISBot_Pnl.Controls.Add(Me.ReportDate_DTP)
        Me.ISBot_Pnl.Controls.Add(Me.ISAdd_Btn)
        Me.ISBot_Pnl.Controls.Add(Me.ISReport_RTF)
        Me.ISBot_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ISBot_Pnl.Location = New System.Drawing.Point(3, 3)
        Me.ISBot_Pnl.Name = "ISBot_Pnl"
        Me.ISBot_Pnl.Size = New System.Drawing.Size(918, 204)
        Me.ISBot_Pnl.TabIndex = 1
        '
        'ISCancel_Btn
        '
        Me.ISCancel_Btn.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.ISCancel_Btn.Location = New System.Drawing.Point(278, 11)
        Me.ISCancel_Btn.Name = "ISCancel_Btn"
        Me.ISCancel_Btn.Size = New System.Drawing.Size(23, 23)
        Me.ISCancel_Btn.TabIndex = 3
        Me.ISCancel_Btn.Text = "X"
        Me.ISCancel_Btn.UseSelectable = True
        '
        'SearchIS_Tbox
        '
        '
        '
        '
        Me.SearchIS_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchIS_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image10"), System.Drawing.Image)
        Me.SearchIS_Tbox.CustomButton.Location = New System.Drawing.Point(256, 1)
        Me.SearchIS_Tbox.CustomButton.Name = ""
        Me.SearchIS_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.SearchIS_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SearchIS_Tbox.CustomButton.TabIndex = 1
        Me.SearchIS_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SearchIS_Tbox.CustomButton.UseSelectable = True
        Me.SearchIS_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.SearchIS_Tbox.ForeColor = System.Drawing.Color.Black
        Me.SearchIS_Tbox.Lines = New String(-1) {}
        Me.SearchIS_Tbox.Location = New System.Drawing.Point(307, 5)
        Me.SearchIS_Tbox.MaxLength = 32767
        Me.SearchIS_Tbox.Name = "SearchIS_Tbox"
        Me.SearchIS_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchIS_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchIS_Tbox.SelectedText = ""
        Me.SearchIS_Tbox.SelectionLength = 0
        Me.SearchIS_Tbox.SelectionStart = 0
        Me.SearchIS_Tbox.ShowButton = True
        Me.SearchIS_Tbox.ShowClearButton = True
        Me.SearchIS_Tbox.Size = New System.Drawing.Size(282, 27)
        Me.SearchIS_Tbox.TabIndex = 4
        Me.SearchIS_Tbox.UseSelectable = True
        Me.SearchIS_Tbox.WaterMark = "Search keyword"
        Me.SearchIS_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SearchIS_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ReportDate_DTP
        '
        Me.ReportDate_DTP.Location = New System.Drawing.Point(3, 5)
        Me.ReportDate_DTP.MinimumSize = New System.Drawing.Size(0, 29)
        Me.ReportDate_DTP.Name = "ReportDate_DTP"
        Me.ReportDate_DTP.Size = New System.Drawing.Size(198, 29)
        Me.ReportDate_DTP.TabIndex = 1
        '
        'ISAdd_Btn
        '
        Me.ISAdd_Btn.Location = New System.Drawing.Point(207, 5)
        Me.ISAdd_Btn.Name = "ISAdd_Btn"
        Me.ISAdd_Btn.Size = New System.Drawing.Size(65, 29)
        Me.ISAdd_Btn.Style = MetroFramework.MetroColorStyle.Black
        Me.ISAdd_Btn.TabIndex = 2
        Me.ISAdd_Btn.Text = "Add"
        Me.ISAdd_Btn.UseSelectable = True
        Me.ISAdd_Btn.UseStyleColors = True
        '
        'ISReport_RTF
        '
        Me.ISReport_RTF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ISReport_RTF.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISReport_RTF.Location = New System.Drawing.Point(3, 38)
        Me.ISReport_RTF.Name = "ISReport_RTF"
        Me.ISReport_RTF.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.ISReport_RTF.Size = New System.Drawing.Size(912, 163)
        Me.ISReport_RTF.TabIndex = 0
        Me.ISReport_RTF.Text = ""
        '
        'InputStatusHdr_Pnl
        '
        Me.InputStatusHdr_Pnl.BackColor = System.Drawing.Color.PowderBlue
        Me.InputStatusHdr_Pnl.Controls.Add(Me.ISHdr_Lbl)
        Me.InputStatusHdr_Pnl.Controls.Add(Me.ISExit_Btn)
        Me.InputStatusHdr_Pnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.InputStatusHdr_Pnl.Location = New System.Drawing.Point(0, 0)
        Me.InputStatusHdr_Pnl.Name = "InputStatusHdr_Pnl"
        Me.InputStatusHdr_Pnl.Size = New System.Drawing.Size(924, 25)
        Me.InputStatusHdr_Pnl.TabIndex = 3
        '
        'ISHdr_Lbl
        '
        Me.ISHdr_Lbl.AutoSize = True
        Me.ISHdr_Lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.ISHdr_Lbl.Location = New System.Drawing.Point(4, 3)
        Me.ISHdr_Lbl.Name = "ISHdr_Lbl"
        Me.ISHdr_Lbl.Size = New System.Drawing.Size(129, 19)
        Me.ISHdr_Lbl.TabIndex = 4
        Me.ISHdr_Lbl.Text = "Input Status Report"
        Me.ISHdr_Lbl.UseCustomBackColor = True
        '
        'ISExit_Btn
        '
        Me.ISExit_Btn.BackColor = System.Drawing.Color.Transparent
        Me.ISExit_Btn.Dock = System.Windows.Forms.DockStyle.Right
        Me.ISExit_Btn.Location = New System.Drawing.Point(893, 0)
        Me.ISExit_Btn.Name = "ISExit_Btn"
        Me.ISExit_Btn.Size = New System.Drawing.Size(31, 25)
        Me.ISExit_Btn.TabIndex = 0
        Me.ISExit_Btn.Text = "X"
        Me.ISExit_Btn.UseCustomBackColor = True
        Me.ISExit_Btn.UseSelectable = True
        '
        'StatusReport_Cmenu
        '
        Me.StatusReport_Cmenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StatusReport_Cmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ISEditToolStripMenuItem, Me.ISDeleteToolStripMenuItem})
        Me.StatusReport_Cmenu.Name = "StatusReport_Cmenu"
        Me.StatusReport_Cmenu.Size = New System.Drawing.Size(108, 48)
        '
        'ISEditToolStripMenuItem
        '
        Me.ISEditToolStripMenuItem.Name = "ISEditToolStripMenuItem"
        Me.ISEditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ISEditToolStripMenuItem.Text = "Edit"
        '
        'ISDeleteToolStripMenuItem
        '
        Me.ISDeleteToolStripMenuItem.Name = "ISDeleteToolStripMenuItem"
        Me.ISDeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ISDeleteToolStripMenuItem.Text = "Delete"
        '
        'AddUser_Pnl
        '
        Me.AddUser_Pnl.BackColor = System.Drawing.Color.White
        Me.AddUser_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddUser_Pnl.Controls.Add(Me.AddUserBdy_Pnl)
        Me.AddUser_Pnl.Controls.Add(Me.AddUserHdr_Pnl)
        Me.AddUser_Pnl.Location = New System.Drawing.Point(354, 220)
        Me.AddUser_Pnl.Name = "AddUser_Pnl"
        Me.AddUser_Pnl.Size = New System.Drawing.Size(300, 201)
        Me.AddUser_Pnl.TabIndex = 22
        Me.AddUser_Pnl.Visible = False
        '
        'AddUserBdy_Pnl
        '
        Me.AddUserBdy_Pnl.Controls.Add(Me.MetroLabel8)
        Me.AddUserBdy_Pnl.Controls.Add(Me.UsrNickname_Tbox)
        Me.AddUserBdy_Pnl.Controls.Add(Me.MetroLabel7)
        Me.AddUserBdy_Pnl.Controls.Add(Me.UsrMname_Tbox)
        Me.AddUserBdy_Pnl.Controls.Add(Me.MetroLabel6)
        Me.AddUserBdy_Pnl.Controls.Add(Me.UsrFname_Tbox)
        Me.AddUserBdy_Pnl.Controls.Add(Me.MetroLabel5)
        Me.AddUserBdy_Pnl.Controls.Add(Me.UsrLname_Tbox)
        Me.AddUserBdy_Pnl.Controls.Add(Me.MetroLabel4)
        Me.AddUserBdy_Pnl.Controls.Add(Me.Usertype_Cbox)
        Me.AddUserBdy_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddUserBdy_Pnl.Location = New System.Drawing.Point(0, 25)
        Me.AddUserBdy_Pnl.Name = "AddUserBdy_Pnl"
        Me.AddUserBdy_Pnl.Padding = New System.Windows.Forms.Padding(3)
        Me.AddUserBdy_Pnl.Size = New System.Drawing.Size(298, 174)
        Me.AddUserBdy_Pnl.TabIndex = 4
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(20, 137)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel8.TabIndex = 12
        Me.MetroLabel8.Text = "Nickname:*"
        Me.MetroLabel8.UseCustomBackColor = True
        '
        'UsrNickname_Tbox
        '
        '
        '
        '
        Me.UsrNickname_Tbox.CustomButton.Image = Nothing
        Me.UsrNickname_Tbox.CustomButton.Location = New System.Drawing.Point(158, 1)
        Me.UsrNickname_Tbox.CustomButton.Name = ""
        Me.UsrNickname_Tbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.UsrNickname_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UsrNickname_Tbox.CustomButton.TabIndex = 1
        Me.UsrNickname_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UsrNickname_Tbox.CustomButton.UseSelectable = True
        Me.UsrNickname_Tbox.CustomButton.Visible = False
        Me.UsrNickname_Tbox.Lines = New String(-1) {}
        Me.UsrNickname_Tbox.Location = New System.Drawing.Point(103, 134)
        Me.UsrNickname_Tbox.MaxLength = 32767
        Me.UsrNickname_Tbox.Name = "UsrNickname_Tbox"
        Me.UsrNickname_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsrNickname_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UsrNickname_Tbox.SelectedText = ""
        Me.UsrNickname_Tbox.SelectionLength = 0
        Me.UsrNickname_Tbox.SelectionStart = 0
        Me.UsrNickname_Tbox.Size = New System.Drawing.Size(180, 23)
        Me.UsrNickname_Tbox.TabIndex = 11
        Me.UsrNickname_Tbox.Tag = "Req"
        Me.UsrNickname_Tbox.UseSelectable = True
        Me.UsrNickname_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UsrNickname_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.Location = New System.Drawing.Point(4, 108)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(94, 19)
        Me.MetroLabel7.TabIndex = 10
        Me.MetroLabel7.Text = "Middle Name:"
        Me.MetroLabel7.UseCustomBackColor = True
        '
        'UsrMname_Tbox
        '
        '
        '
        '
        Me.UsrMname_Tbox.CustomButton.Image = Nothing
        Me.UsrMname_Tbox.CustomButton.Location = New System.Drawing.Point(158, 1)
        Me.UsrMname_Tbox.CustomButton.Name = ""
        Me.UsrMname_Tbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.UsrMname_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UsrMname_Tbox.CustomButton.TabIndex = 1
        Me.UsrMname_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UsrMname_Tbox.CustomButton.UseSelectable = True
        Me.UsrMname_Tbox.CustomButton.Visible = False
        Me.UsrMname_Tbox.Lines = New String(-1) {}
        Me.UsrMname_Tbox.Location = New System.Drawing.Point(103, 105)
        Me.UsrMname_Tbox.MaxLength = 32767
        Me.UsrMname_Tbox.Name = "UsrMname_Tbox"
        Me.UsrMname_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsrMname_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UsrMname_Tbox.SelectedText = ""
        Me.UsrMname_Tbox.SelectionLength = 0
        Me.UsrMname_Tbox.SelectionStart = 0
        Me.UsrMname_Tbox.Size = New System.Drawing.Size(180, 23)
        Me.UsrMname_Tbox.TabIndex = 5
        Me.UsrMname_Tbox.UseSelectable = True
        Me.UsrMname_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UsrMname_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(14, 79)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel6.TabIndex = 8
        Me.MetroLabel6.Text = "First Name:*"
        Me.MetroLabel6.UseCustomBackColor = True
        '
        'UsrFname_Tbox
        '
        '
        '
        '
        Me.UsrFname_Tbox.CustomButton.Image = Nothing
        Me.UsrFname_Tbox.CustomButton.Location = New System.Drawing.Point(158, 1)
        Me.UsrFname_Tbox.CustomButton.Name = ""
        Me.UsrFname_Tbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.UsrFname_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UsrFname_Tbox.CustomButton.TabIndex = 1
        Me.UsrFname_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UsrFname_Tbox.CustomButton.UseSelectable = True
        Me.UsrFname_Tbox.CustomButton.Visible = False
        Me.UsrFname_Tbox.Lines = New String(-1) {}
        Me.UsrFname_Tbox.Location = New System.Drawing.Point(103, 76)
        Me.UsrFname_Tbox.MaxLength = 32767
        Me.UsrFname_Tbox.Name = "UsrFname_Tbox"
        Me.UsrFname_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsrFname_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UsrFname_Tbox.SelectedText = ""
        Me.UsrFname_Tbox.SelectionLength = 0
        Me.UsrFname_Tbox.SelectionStart = 0
        Me.UsrFname_Tbox.Size = New System.Drawing.Size(180, 23)
        Me.UsrFname_Tbox.TabIndex = 4
        Me.UsrFname_Tbox.Tag = "Req"
        Me.UsrFname_Tbox.UseSelectable = True
        Me.UsrFname_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UsrFname_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(15, 49)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel5.TabIndex = 6
        Me.MetroLabel5.Text = "Last Name:*"
        Me.MetroLabel5.UseCustomBackColor = True
        '
        'UsrLname_Tbox
        '
        '
        '
        '
        Me.UsrLname_Tbox.CustomButton.Image = Nothing
        Me.UsrLname_Tbox.CustomButton.Location = New System.Drawing.Point(158, 1)
        Me.UsrLname_Tbox.CustomButton.Name = ""
        Me.UsrLname_Tbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.UsrLname_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UsrLname_Tbox.CustomButton.TabIndex = 1
        Me.UsrLname_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UsrLname_Tbox.CustomButton.UseSelectable = True
        Me.UsrLname_Tbox.CustomButton.Visible = False
        Me.UsrLname_Tbox.Lines = New String(-1) {}
        Me.UsrLname_Tbox.Location = New System.Drawing.Point(103, 47)
        Me.UsrLname_Tbox.MaxLength = 32767
        Me.UsrLname_Tbox.Name = "UsrLname_Tbox"
        Me.UsrLname_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsrLname_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UsrLname_Tbox.SelectedText = ""
        Me.UsrLname_Tbox.SelectionLength = 0
        Me.UsrLname_Tbox.SelectionStart = 0
        Me.UsrLname_Tbox.Size = New System.Drawing.Size(180, 23)
        Me.UsrLname_Tbox.TabIndex = 3
        Me.UsrLname_Tbox.Tag = "Req"
        Me.UsrLname_Tbox.UseSelectable = True
        Me.UsrLname_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UsrLname_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(25, 20)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel4.TabIndex = 4
        Me.MetroLabel4.Text = "Usertype:*"
        Me.MetroLabel4.UseCustomBackColor = True
        '
        'Usertype_Cbox
        '
        Me.Usertype_Cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Usertype_Cbox.FormattingEnabled = True
        Me.Usertype_Cbox.Items.AddRange(New Object() {"Admin", "Encoder"})
        Me.Usertype_Cbox.Location = New System.Drawing.Point(103, 20)
        Me.Usertype_Cbox.Name = "Usertype_Cbox"
        Me.Usertype_Cbox.Size = New System.Drawing.Size(180, 21)
        Me.Usertype_Cbox.TabIndex = 2
        Me.Usertype_Cbox.Tag = "Req"
        '
        'AddUserHdr_Pnl
        '
        Me.AddUserHdr_Pnl.BackColor = System.Drawing.Color.PowderBlue
        Me.AddUserHdr_Pnl.Controls.Add(Me.AddUserAcpt_Btn)
        Me.AddUserHdr_Pnl.Controls.Add(Me.AddUserHdr_Lbl)
        Me.AddUserHdr_Pnl.Controls.Add(Me.AddUserExit_Btn)
        Me.AddUserHdr_Pnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddUserHdr_Pnl.Location = New System.Drawing.Point(0, 0)
        Me.AddUserHdr_Pnl.Name = "AddUserHdr_Pnl"
        Me.AddUserHdr_Pnl.Size = New System.Drawing.Size(298, 25)
        Me.AddUserHdr_Pnl.TabIndex = 3
        '
        'AddUserAcpt_Btn
        '
        Me.AddUserAcpt_Btn.BackColor = System.Drawing.Color.Transparent
        Me.AddUserAcpt_Btn.Dock = System.Windows.Forms.DockStyle.Right
        Me.AddUserAcpt_Btn.ForeColor = System.Drawing.Color.Green
        Me.AddUserAcpt_Btn.Location = New System.Drawing.Point(236, 0)
        Me.AddUserAcpt_Btn.Name = "AddUserAcpt_Btn"
        Me.AddUserAcpt_Btn.Size = New System.Drawing.Size(31, 25)
        Me.AddUserAcpt_Btn.TabIndex = 4
        Me.AddUserAcpt_Btn.Text = "✔"
        Me.AddUserAcpt_Btn.UseCustomBackColor = True
        Me.AddUserAcpt_Btn.UseCustomForeColor = True
        Me.AddUserAcpt_Btn.UseSelectable = True
        '
        'AddUserHdr_Lbl
        '
        Me.AddUserHdr_Lbl.AutoSize = True
        Me.AddUserHdr_Lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.AddUserHdr_Lbl.Location = New System.Drawing.Point(4, 3)
        Me.AddUserHdr_Lbl.Name = "AddUserHdr_Lbl"
        Me.AddUserHdr_Lbl.Size = New System.Drawing.Size(93, 19)
        Me.AddUserHdr_Lbl.TabIndex = 3
        Me.AddUserHdr_Lbl.Text = "Add new user"
        Me.AddUserHdr_Lbl.UseCustomBackColor = True
        '
        'AddUserExit_Btn
        '
        Me.AddUserExit_Btn.BackColor = System.Drawing.Color.Transparent
        Me.AddUserExit_Btn.Dock = System.Windows.Forms.DockStyle.Right
        Me.AddUserExit_Btn.Location = New System.Drawing.Point(267, 0)
        Me.AddUserExit_Btn.Name = "AddUserExit_Btn"
        Me.AddUserExit_Btn.Size = New System.Drawing.Size(31, 25)
        Me.AddUserExit_Btn.TabIndex = 0
        Me.AddUserExit_Btn.Text = "X"
        Me.AddUserExit_Btn.UseCustomBackColor = True
        Me.AddUserExit_Btn.UseSelectable = True
        '
        'ChangeUNPW_Pnl
        '
        Me.ChangeUNPW_Pnl.BackColor = System.Drawing.Color.White
        Me.ChangeUNPW_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChangeUNPW_Pnl.Controls.Add(Me.ChangeUNPWBdy_Pnl)
        Me.ChangeUNPW_Pnl.Controls.Add(Me.ChangeUNPWHdr_Pnl)
        Me.ChangeUNPW_Pnl.Location = New System.Drawing.Point(337, 238)
        Me.ChangeUNPW_Pnl.Name = "ChangeUNPW_Pnl"
        Me.ChangeUNPW_Pnl.Size = New System.Drawing.Size(334, 192)
        Me.ChangeUNPW_Pnl.TabIndex = 23
        Me.ChangeUNPW_Pnl.Visible = False
        '
        'ChangeUNPWBdy_Pnl
        '
        Me.ChangeUNPWBdy_Pnl.Controls.Add(Me.MetroLabel10)
        Me.ChangeUNPWBdy_Pnl.Controls.Add(Me.OldPass_Tbox)
        Me.ChangeUNPWBdy_Pnl.Controls.Add(Me.MetroLabel9)
        Me.ChangeUNPWBdy_Pnl.Controls.Add(Me.MetroLabel2)
        Me.ChangeUNPWBdy_Pnl.Controls.Add(Me.Password_Chk)
        Me.ChangeUNPWBdy_Pnl.Controls.Add(Me.Username_Chk)
        Me.ChangeUNPWBdy_Pnl.Controls.Add(Me.Retype_Tbox)
        Me.ChangeUNPWBdy_Pnl.Controls.Add(Me.Password_Tbox)
        Me.ChangeUNPWBdy_Pnl.Controls.Add(Me.Username_Tbox)
        Me.ChangeUNPWBdy_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChangeUNPWBdy_Pnl.Location = New System.Drawing.Point(0, 25)
        Me.ChangeUNPWBdy_Pnl.Name = "ChangeUNPWBdy_Pnl"
        Me.ChangeUNPWBdy_Pnl.Padding = New System.Windows.Forms.Padding(3)
        Me.ChangeUNPWBdy_Pnl.Size = New System.Drawing.Size(332, 165)
        Me.ChangeUNPWBdy_Pnl.TabIndex = 4
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel10.Location = New System.Drawing.Point(6, 121)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(146, 19)
        Me.MetroLabel10.TabIndex = 16
        Me.MetroLabel10.Text = "Confirm old password:"
        Me.MetroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroLabel10.UseCustomBackColor = True
        '
        'OldPass_Tbox
        '
        '
        '
        '
        Me.OldPass_Tbox.CustomButton.Image = Nothing
        Me.OldPass_Tbox.CustomButton.Location = New System.Drawing.Point(139, 1)
        Me.OldPass_Tbox.CustomButton.Name = ""
        Me.OldPass_Tbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.OldPass_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.OldPass_Tbox.CustomButton.TabIndex = 1
        Me.OldPass_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.OldPass_Tbox.CustomButton.UseSelectable = True
        Me.OldPass_Tbox.CustomButton.Visible = False
        Me.OldPass_Tbox.Lines = New String(-1) {}
        Me.OldPass_Tbox.Location = New System.Drawing.Point(158, 121)
        Me.OldPass_Tbox.MaxLength = 32767
        Me.OldPass_Tbox.Name = "OldPass_Tbox"
        Me.OldPass_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.OldPass_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.OldPass_Tbox.SelectedText = ""
        Me.OldPass_Tbox.SelectionLength = 0
        Me.OldPass_Tbox.SelectionStart = 0
        Me.OldPass_Tbox.Size = New System.Drawing.Size(161, 23)
        Me.OldPass_Tbox.TabIndex = 6
        Me.OldPass_Tbox.Tag = "Password_Chk"
        Me.OldPass_Tbox.UseSelectable = True
        Me.OldPass_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.OldPass_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel9.Location = New System.Drawing.Point(6, 96)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(321, 19)
        Me.MetroLabel9.TabIndex = 14
        Me.MetroLabel9.Text = "____________________________________________________"
        Me.MetroLabel9.UseCustomBackColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(11, 71)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(122, 19)
        Me.MetroLabel2.TabIndex = 13
        Me.MetroLabel2.Text = "Re-type password:"
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'Password_Chk
        '
        Me.Password_Chk.AutoSize = True
        Me.Password_Chk.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.Password_Chk.Location = New System.Drawing.Point(10, 43)
        Me.Password_Chk.Name = "Password_Chk"
        Me.Password_Chk.Size = New System.Drawing.Size(123, 19)
        Me.Password_Chk.TabIndex = 3
        Me.Password_Chk.Tag = ""
        Me.Password_Chk.Text = "New Password:*"
        Me.Password_Chk.UseSelectable = True
        '
        'Username_Chk
        '
        Me.Username_Chk.AutoSize = True
        Me.Username_Chk.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.Username_Chk.Location = New System.Drawing.Point(6, 15)
        Me.Username_Chk.Name = "Username_Chk"
        Me.Username_Chk.Size = New System.Drawing.Size(127, 19)
        Me.Username_Chk.TabIndex = 1
        Me.Username_Chk.Tag = ""
        Me.Username_Chk.Text = "New Username:*"
        Me.Username_Chk.UseSelectable = True
        '
        'Retype_Tbox
        '
        '
        '
        '
        Me.Retype_Tbox.CustomButton.Image = Nothing
        Me.Retype_Tbox.CustomButton.Location = New System.Drawing.Point(158, 1)
        Me.Retype_Tbox.CustomButton.Name = ""
        Me.Retype_Tbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Retype_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Retype_Tbox.CustomButton.TabIndex = 1
        Me.Retype_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Retype_Tbox.CustomButton.UseSelectable = True
        Me.Retype_Tbox.CustomButton.Visible = False
        Me.Retype_Tbox.Enabled = False
        Me.Retype_Tbox.Lines = New String(-1) {}
        Me.Retype_Tbox.Location = New System.Drawing.Point(139, 70)
        Me.Retype_Tbox.MaxLength = 32767
        Me.Retype_Tbox.Name = "Retype_Tbox"
        Me.Retype_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Retype_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Retype_Tbox.SelectedText = ""
        Me.Retype_Tbox.SelectionLength = 0
        Me.Retype_Tbox.SelectionStart = 0
        Me.Retype_Tbox.Size = New System.Drawing.Size(180, 23)
        Me.Retype_Tbox.TabIndex = 5
        Me.Retype_Tbox.Tag = "Password_Chk"
        Me.Retype_Tbox.UseSelectable = True
        Me.Retype_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Retype_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Password_Tbox
        '
        '
        '
        '
        Me.Password_Tbox.CustomButton.Image = Nothing
        Me.Password_Tbox.CustomButton.Location = New System.Drawing.Point(158, 1)
        Me.Password_Tbox.CustomButton.Name = ""
        Me.Password_Tbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Password_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Password_Tbox.CustomButton.TabIndex = 1
        Me.Password_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Password_Tbox.CustomButton.UseSelectable = True
        Me.Password_Tbox.CustomButton.Visible = False
        Me.Password_Tbox.Enabled = False
        Me.Password_Tbox.Lines = New String(-1) {}
        Me.Password_Tbox.Location = New System.Drawing.Point(139, 42)
        Me.Password_Tbox.MaxLength = 32767
        Me.Password_Tbox.Name = "Password_Tbox"
        Me.Password_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Password_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Password_Tbox.SelectedText = ""
        Me.Password_Tbox.SelectionLength = 0
        Me.Password_Tbox.SelectionStart = 0
        Me.Password_Tbox.Size = New System.Drawing.Size(180, 23)
        Me.Password_Tbox.TabIndex = 4
        Me.Password_Tbox.Tag = "Password_Chk"
        Me.Password_Tbox.UseSelectable = True
        Me.Password_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Password_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Username_Tbox
        '
        '
        '
        '
        Me.Username_Tbox.CustomButton.Image = Nothing
        Me.Username_Tbox.CustomButton.Location = New System.Drawing.Point(158, 1)
        Me.Username_Tbox.CustomButton.Name = ""
        Me.Username_Tbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Username_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Username_Tbox.CustomButton.TabIndex = 1
        Me.Username_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Username_Tbox.CustomButton.UseSelectable = True
        Me.Username_Tbox.CustomButton.Visible = False
        Me.Username_Tbox.Enabled = False
        Me.Username_Tbox.Lines = New String(-1) {}
        Me.Username_Tbox.Location = New System.Drawing.Point(139, 14)
        Me.Username_Tbox.MaxLength = 32767
        Me.Username_Tbox.Name = "Username_Tbox"
        Me.Username_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Username_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Username_Tbox.SelectedText = ""
        Me.Username_Tbox.SelectionLength = 0
        Me.Username_Tbox.SelectionStart = 0
        Me.Username_Tbox.Size = New System.Drawing.Size(180, 23)
        Me.Username_Tbox.TabIndex = 2
        Me.Username_Tbox.Tag = "Username_Chk"
        Me.Username_Tbox.UseSelectable = True
        Me.Username_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Username_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ChangeUNPWHdr_Pnl
        '
        Me.ChangeUNPWHdr_Pnl.BackColor = System.Drawing.Color.PowderBlue
        Me.ChangeUNPWHdr_Pnl.Controls.Add(Me.ChangeUNPWAcpt_Btn)
        Me.ChangeUNPWHdr_Pnl.Controls.Add(Me.MetroLabel14)
        Me.ChangeUNPWHdr_Pnl.Controls.Add(Me.ChangeUNPWExit_Btn)
        Me.ChangeUNPWHdr_Pnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChangeUNPWHdr_Pnl.Location = New System.Drawing.Point(0, 0)
        Me.ChangeUNPWHdr_Pnl.Name = "ChangeUNPWHdr_Pnl"
        Me.ChangeUNPWHdr_Pnl.Size = New System.Drawing.Size(332, 25)
        Me.ChangeUNPWHdr_Pnl.TabIndex = 3
        '
        'ChangeUNPWAcpt_Btn
        '
        Me.ChangeUNPWAcpt_Btn.BackColor = System.Drawing.Color.Transparent
        Me.ChangeUNPWAcpt_Btn.Dock = System.Windows.Forms.DockStyle.Right
        Me.ChangeUNPWAcpt_Btn.ForeColor = System.Drawing.Color.Green
        Me.ChangeUNPWAcpt_Btn.Location = New System.Drawing.Point(270, 0)
        Me.ChangeUNPWAcpt_Btn.Name = "ChangeUNPWAcpt_Btn"
        Me.ChangeUNPWAcpt_Btn.Size = New System.Drawing.Size(31, 25)
        Me.ChangeUNPWAcpt_Btn.TabIndex = 4
        Me.ChangeUNPWAcpt_Btn.Text = "✔"
        Me.ChangeUNPWAcpt_Btn.UseCustomBackColor = True
        Me.ChangeUNPWAcpt_Btn.UseCustomForeColor = True
        Me.ChangeUNPWAcpt_Btn.UseSelectable = True
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel14.Location = New System.Drawing.Point(4, 3)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(193, 19)
        Me.MetroLabel14.TabIndex = 3
        Me.MetroLabel14.Text = "Change Username / Password"
        Me.MetroLabel14.UseCustomBackColor = True
        '
        'ChangeUNPWExit_Btn
        '
        Me.ChangeUNPWExit_Btn.BackColor = System.Drawing.Color.Transparent
        Me.ChangeUNPWExit_Btn.Dock = System.Windows.Forms.DockStyle.Right
        Me.ChangeUNPWExit_Btn.Location = New System.Drawing.Point(301, 0)
        Me.ChangeUNPWExit_Btn.Name = "ChangeUNPWExit_Btn"
        Me.ChangeUNPWExit_Btn.Size = New System.Drawing.Size(31, 25)
        Me.ChangeUNPWExit_Btn.TabIndex = 0
        Me.ChangeUNPWExit_Btn.Text = "X"
        Me.ChangeUNPWExit_Btn.UseCustomBackColor = True
        Me.ChangeUNPWExit_Btn.UseSelectable = True
        '
        'ChangePic_Pbox
        '
        Me.ChangePic_Pbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChangePic_Pbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChangePic_Pbox.Location = New System.Drawing.Point(3, 3)
        Me.ChangePic_Pbox.Name = "ChangePic_Pbox"
        Me.ChangePic_Pbox.Size = New System.Drawing.Size(300, 300)
        Me.ChangePic_Pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ChangePic_Pbox.TabIndex = 5
        Me.ChangePic_Pbox.TabStop = False
        '
        'Image_Pbox
        '
        Me.Image_Pbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Image_Pbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Image_Pbox.Image = Global.WindowsApplication1.My.Resources.Resources.users
        Me.Image_Pbox.Location = New System.Drawing.Point(17, 6)
        Me.Image_Pbox.Name = "Image_Pbox"
        Me.Image_Pbox.Size = New System.Drawing.Size(115, 115)
        Me.Image_Pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image_Pbox.TabIndex = 0
        Me.Image_Pbox.TabStop = False
        '
        'Side_Btn
        '
        Me.Side_Btn.BackColor = System.Drawing.Color.Transparent
        Me.Side_Btn.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.icons8_double_left_30
        Me.Side_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Side_Btn.Dock = System.Windows.Forms.DockStyle.Right
        Me.Side_Btn.Location = New System.Drawing.Point(236, 0)
        Me.Side_Btn.Name = "Side_Btn"
        Me.Side_Btn.Size = New System.Drawing.Size(30, 33)
        Me.Side_Btn.TabIndex = 0
        Me.Side_Btn.UseCustomBackColor = True
        Me.Side_Btn.UseSelectable = True
        '
        'LoadingPB2
        '
        Me.LoadingPB2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPB2.Image = CType(resources.GetObject("LoadingPB2.Image"), System.Drawing.Image)
        Me.LoadingPB2.Location = New System.Drawing.Point(910, 5)
        Me.LoadingPB2.Name = "LoadingPB2"
        Me.LoadingPB2.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPB2.TabIndex = 624
        Me.LoadingPB2.TabStop = False
        Me.LoadingPB2.Visible = False
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 611)
        Me.Controls.Add(Me.InputStatus_Pnl)
        Me.Controls.Add(Me.ChangeUNPW_Pnl)
        Me.Controls.Add(Me.AddUser_Pnl)
        Me.Controls.Add(Me.Search_Pnl)
        Me.Controls.Add(Me.ChangePicture_Pnl)
        Me.Controls.Add(Me.EP_Pnl)
        Me.Controls.Add(Me.Homepage_Menu)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.Homepage_Menu
        Me.Name = "Homepage"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Members Monitoring"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.EP_Pnl.ResumeLayout(False)
        Me.Body_Pnl.ResumeLayout(False)
        Me.Homepage_Split.Panel1.ResumeLayout(False)
        Me.Homepage_Split.Panel2.ResumeLayout(False)
        CType(Me.Homepage_Split, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Homepage_Split.ResumeLayout(False)
        Me.Left_Pnl.ResumeLayout(False)
        Me.Info_Pnl.ResumeLayout(False)
        Me.Side_Pnl.ResumeLayout(False)
        Me.Side_Pnl.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Homepage_Cmenu.ResumeLayout(False)
        Me.Homepage_Menu.ResumeLayout(False)
        Me.Homepage_Menu.PerformLayout()
        Me.ChangePicture_Pnl.ResumeLayout(False)
        Me.ChangePicBody_Pnl.ResumeLayout(False)
        Me.ChangePictureHeader_Pnl.ResumeLayout(False)
        Me.ChangePictureHeader_Pnl.PerformLayout()
        Me.Search_Pnl.ResumeLayout(False)
        Me.SearchHeader_Pnl.ResumeLayout(False)
        Me.InputStatus_Pnl.ResumeLayout(False)
        Me.IS_Split.Panel1.ResumeLayout(False)
        Me.IS_Split.Panel2.ResumeLayout(False)
        CType(Me.IS_Split, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IS_Split.ResumeLayout(False)
        Me.ISBot_Pnl.ResumeLayout(False)
        Me.InputStatusHdr_Pnl.ResumeLayout(False)
        Me.InputStatusHdr_Pnl.PerformLayout()
        Me.StatusReport_Cmenu.ResumeLayout(False)
        Me.AddUser_Pnl.ResumeLayout(False)
        Me.AddUserBdy_Pnl.ResumeLayout(False)
        Me.AddUserBdy_Pnl.PerformLayout()
        Me.AddUserHdr_Pnl.ResumeLayout(False)
        Me.AddUserHdr_Pnl.PerformLayout()
        Me.ChangeUNPW_Pnl.ResumeLayout(False)
        Me.ChangeUNPWBdy_Pnl.ResumeLayout(False)
        Me.ChangeUNPWBdy_Pnl.PerformLayout()
        Me.ChangeUNPWHdr_Pnl.ResumeLayout(False)
        Me.ChangeUNPWHdr_Pnl.PerformLayout()
        CType(Me.ChangePic_Pbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image_Pbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadingPB2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EP_Pnl As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents LoadingPB2 As PictureBox
    Friend WithEvents Body_Pnl As Panel
    Friend WithEvents Homepage_Split As SplitContainer
    Friend WithEvents Left_Pnl As Panel
    Friend WithEvents DGV_Pnl As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Side_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents Side_Pnl As Panel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Public WithEvents Mname_Tbox As MetroFramework.Controls.MetroTextBox
    Public WithEvents Fname_Tbox As MetroFramework.Controls.MetroTextBox
    Public WithEvents Lname_Tbox As MetroFramework.Controls.MetroTextBox
    Public WithEvents ID_Tbox As MetroFramework.Controls.MetroTextBox
    Public WithEvents Address_Tbox As MetroFramework.Controls.MetroTextBox
    Public WithEvents Contact_Tbox As MetroFramework.Controls.MetroTextBox
    Public WithEvents Work_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Baptism_DTP As MetroFramework.Controls.MetroDateTime
    Public WithEvents Skill_Tbox As MetroFramework.Controls.MetroTextBox
    Public WithEvents BaptizedBy_Tbox As MetroFramework.Controls.MetroTextBox
    Public WithEvents NagAkay_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Image_Pbox As PictureBox
    Friend WithEvents Save_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents Homepage_Cmenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Image_OPFD As OpenFileDialog
    Friend WithEvents Homepage_Ttip As MetroFramework.Components.MetroToolTip
    Friend WithEvents Clear_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents Cancel_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents Homepage_Menu As MenuStrip
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Header_Lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents DateTime_Lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents DateTime_Timer As Timer
    Friend WithEvents ChangePictureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePicture_Pnl As Panel
    Friend WithEvents ChangePictureHeader_Pnl As Panel
    Friend WithEvents ChangePicExit_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents ChangePicAccept_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents ChangePicBody_Pnl As Panel
    Friend WithEvents ChangePic_Pbox As PictureBox
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Search_Pnl As Panel
    Public WithEvents Search_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents SearchHeader_Pnl As Panel
    Friend WithEvents SearchPnlExit_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents Info_Pnl As Panel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents InputStatus_Pnl As Panel
    Friend WithEvents InputStatusHdr_Pnl As Panel
    Friend WithEvents ISExit_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents InputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ISHdr_Lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents IS_Split As SplitContainer
    Friend WithEvents ISTop_Pnl As Panel
    Friend WithEvents ISBot_Pnl As Panel
    Friend WithEvents ISReport_RTF As RichTextBox
    Friend WithEvents ISAdd_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents ReportDate_DTP As MetroFramework.Controls.MetroDateTime
    Public WithEvents SearchIS_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ISCancel_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents StatusReport_Cmenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents ISEditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ISDeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformationPanelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddUser_Pnl As Panel
    Friend WithEvents AddUserBdy_Pnl As Panel
    Friend WithEvents AddUserHdr_Pnl As Panel
    Friend WithEvents AddUserHdr_Lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents AddUserExit_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents UsrMname_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents UsrFname_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents UsrLname_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Usertype_Cbox As ComboBox
    Friend WithEvents AddUserAcpt_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeUNPWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents UsrNickname_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ChangeUNPW_Pnl As Panel
    Friend WithEvents ChangeUNPWBdy_Pnl As Panel
    Friend WithEvents Retype_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Password_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Username_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ChangeUNPWHdr_Pnl As Panel
    Friend WithEvents ChangeUNPWAcpt_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ChangeUNPWExit_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents Username_Chk As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Password_Chk As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents OldPass_Tbox As MetroFramework.Controls.MetroTextBox
End Class
