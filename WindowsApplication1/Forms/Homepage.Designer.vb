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
        Me.Side_Pnl = New System.Windows.Forms.Panel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Side_Btn = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Save_Btn = New MetroFramework.Controls.MetroButton()
        Me.NagAkay_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.BaptizedBy_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Baptism_DTP = New MetroFramework.Controls.MetroDateTime()
        Me.Skill_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Work_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Contact_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Address_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Mname_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Fname_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Lname_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.ID_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Image_Pbox = New System.Windows.Forms.PictureBox()
        Me.Cancel_Btn = New MetroFramework.Controls.MetroButton()
        Me.Clear_Btn = New MetroFramework.Controls.MetroButton()
        Me.DGV_Pnl = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.LoadingPB2 = New System.Windows.Forms.PictureBox()
        Me.Homepage_Cmenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Image_OPFD = New System.Windows.Forms.OpenFileDialog()
        Me.Homepage_Ttip = New MetroFramework.Components.MetroToolTip()
        Me.Homepage_Menu = New System.Windows.Forms.MenuStrip()
        Me.MembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTime_Lbl = New MetroFramework.Controls.MetroLabel()
        Me.DateTime_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.EP_Pnl.SuspendLayout()
        Me.Body_Pnl.SuspendLayout()
        CType(Me.Homepage_Split, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Homepage_Split.Panel1.SuspendLayout()
        Me.Homepage_Split.Panel2.SuspendLayout()
        Me.Homepage_Split.SuspendLayout()
        Me.Left_Pnl.SuspendLayout()
        Me.Side_Pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Image_Pbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.LoadingPB2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Homepage_Cmenu.SuspendLayout()
        Me.Homepage_Menu.SuspendLayout()
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
        Me.EP_Pnl.Size = New System.Drawing.Size(1008, 576)
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
        Me.Body_Pnl.Size = New System.Drawing.Size(1006, 538)
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
        Me.Homepage_Split.Size = New System.Drawing.Size(1000, 532)
        Me.Homepage_Split.SplitterDistance = 260
        Me.Homepage_Split.TabIndex = 4
        '
        'Left_Pnl
        '
        Me.Left_Pnl.BackColor = System.Drawing.Color.White
        Me.Left_Pnl.Controls.Add(Me.Side_Pnl)
        Me.Left_Pnl.Controls.Add(Me.Panel1)
        Me.Left_Pnl.Controls.Add(Me.Save_Btn)
        Me.Left_Pnl.Controls.Add(Me.NagAkay_Tbox)
        Me.Left_Pnl.Controls.Add(Me.BaptizedBy_Tbox)
        Me.Left_Pnl.Controls.Add(Me.Baptism_DTP)
        Me.Left_Pnl.Controls.Add(Me.Skill_Tbox)
        Me.Left_Pnl.Controls.Add(Me.Work_Tbox)
        Me.Left_Pnl.Controls.Add(Me.Contact_Tbox)
        Me.Left_Pnl.Controls.Add(Me.Address_Tbox)
        Me.Left_Pnl.Controls.Add(Me.Mname_Tbox)
        Me.Left_Pnl.Controls.Add(Me.Fname_Tbox)
        Me.Left_Pnl.Controls.Add(Me.Lname_Tbox)
        Me.Left_Pnl.Controls.Add(Me.ID_Tbox)
        Me.Left_Pnl.Controls.Add(Me.Image_Pbox)
        Me.Left_Pnl.Controls.Add(Me.Cancel_Btn)
        Me.Left_Pnl.Controls.Add(Me.Clear_Btn)
        Me.Left_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Left_Pnl.Location = New System.Drawing.Point(0, 3)
        Me.Left_Pnl.Name = "Left_Pnl"
        Me.Left_Pnl.Size = New System.Drawing.Size(260, 529)
        Me.Left_Pnl.TabIndex = 0
        '
        'Side_Pnl
        '
        Me.Side_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Side_Pnl.Controls.Add(Me.KryptonLabel1)
        Me.Side_Pnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.Side_Pnl.Location = New System.Drawing.Point(230, 35)
        Me.Side_Pnl.Name = "Side_Pnl"
        Me.Side_Pnl.Size = New System.Drawing.Size(30, 494)
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
        Me.Panel1.Size = New System.Drawing.Size(260, 35)
        Me.Panel1.TabIndex = 13
        '
        'Side_Btn
        '
        Me.Side_Btn.BackColor = System.Drawing.Color.Transparent
        Me.Side_Btn.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.icons8_double_left_30
        Me.Side_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Side_Btn.Dock = System.Windows.Forms.DockStyle.Right
        Me.Side_Btn.Location = New System.Drawing.Point(228, 0)
        Me.Side_Btn.Name = "Side_Btn"
        Me.Side_Btn.Size = New System.Drawing.Size(30, 33)
        Me.Side_Btn.TabIndex = 0
        Me.Side_Btn.UseCustomBackColor = True
        Me.Side_Btn.UseSelectable = True
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
        'Save_Btn
        '
        Me.Save_Btn.Location = New System.Drawing.Point(127, 133)
        Me.Save_Btn.Name = "Save_Btn"
        Me.Save_Btn.Size = New System.Drawing.Size(65, 23)
        Me.Save_Btn.Style = MetroFramework.MetroColorStyle.Black
        Me.Save_Btn.TabIndex = 840
        Me.Save_Btn.Text = "Save"
        Me.Save_Btn.UseSelectable = True
        Me.Save_Btn.UseStyleColors = True
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
        Me.NagAkay_Tbox.CustomButton.Location = New System.Drawing.Point(192, 1)
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
        Me.NagAkay_Tbox.Location = New System.Drawing.Point(6, 494)
        Me.NagAkay_Tbox.MaxLength = 32767
        Me.NagAkay_Tbox.Name = "NagAkay_Tbox"
        Me.NagAkay_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NagAkay_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.NagAkay_Tbox.SelectedText = ""
        Me.NagAkay_Tbox.SelectionLength = 0
        Me.NagAkay_Tbox.SelectionStart = 0
        Me.NagAkay_Tbox.ShowClearButton = True
        Me.NagAkay_Tbox.Size = New System.Drawing.Size(218, 27)
        Me.NagAkay_Tbox.TabIndex = 839
        Me.NagAkay_Tbox.UseCustomForeColor = True
        Me.NagAkay_Tbox.UseSelectable = True
        Me.NagAkay_Tbox.WaterMark = "Nag-akay"
        Me.NagAkay_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.NagAkay_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BaptizedBy_Tbox.CustomButton.Location = New System.Drawing.Point(192, 1)
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
        Me.BaptizedBy_Tbox.Location = New System.Drawing.Point(6, 461)
        Me.BaptizedBy_Tbox.MaxLength = 32767
        Me.BaptizedBy_Tbox.Name = "BaptizedBy_Tbox"
        Me.BaptizedBy_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BaptizedBy_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.BaptizedBy_Tbox.SelectedText = ""
        Me.BaptizedBy_Tbox.SelectionLength = 0
        Me.BaptizedBy_Tbox.SelectionStart = 0
        Me.BaptizedBy_Tbox.ShowClearButton = True
        Me.BaptizedBy_Tbox.Size = New System.Drawing.Size(218, 27)
        Me.BaptizedBy_Tbox.TabIndex = 838
        Me.BaptizedBy_Tbox.UseCustomForeColor = True
        Me.BaptizedBy_Tbox.UseSelectable = True
        Me.BaptizedBy_Tbox.WaterMark = "Baptized by"
        Me.BaptizedBy_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BaptizedBy_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Baptism_DTP
        '
        Me.Baptism_DTP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Baptism_DTP.Location = New System.Drawing.Point(6, 426)
        Me.Baptism_DTP.MinimumSize = New System.Drawing.Size(0, 29)
        Me.Baptism_DTP.Name = "Baptism_DTP"
        Me.Baptism_DTP.Size = New System.Drawing.Size(218, 29)
        Me.Baptism_DTP.TabIndex = 837
        '
        'Skill_Tbox
        '
        Me.Skill_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Skill_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Skill_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.Skill_Tbox.CustomButton.Location = New System.Drawing.Point(192, 1)
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
        Me.Skill_Tbox.Location = New System.Drawing.Point(6, 393)
        Me.Skill_Tbox.MaxLength = 32767
        Me.Skill_Tbox.Name = "Skill_Tbox"
        Me.Skill_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Skill_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Skill_Tbox.SelectedText = ""
        Me.Skill_Tbox.SelectionLength = 0
        Me.Skill_Tbox.SelectionStart = 0
        Me.Skill_Tbox.ShowClearButton = True
        Me.Skill_Tbox.Size = New System.Drawing.Size(218, 27)
        Me.Skill_Tbox.TabIndex = 836
        Me.Skill_Tbox.UseCustomForeColor = True
        Me.Skill_Tbox.UseSelectable = True
        Me.Skill_Tbox.WaterMark = "Skill"
        Me.Skill_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Skill_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Work_Tbox
        '
        Me.Work_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Work_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Work_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.Work_Tbox.CustomButton.Location = New System.Drawing.Point(192, 1)
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
        Me.Work_Tbox.Location = New System.Drawing.Point(6, 360)
        Me.Work_Tbox.MaxLength = 32767
        Me.Work_Tbox.Name = "Work_Tbox"
        Me.Work_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Work_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Work_Tbox.SelectedText = ""
        Me.Work_Tbox.SelectionLength = 0
        Me.Work_Tbox.SelectionStart = 0
        Me.Work_Tbox.ShowClearButton = True
        Me.Work_Tbox.Size = New System.Drawing.Size(218, 27)
        Me.Work_Tbox.TabIndex = 835
        Me.Work_Tbox.UseCustomForeColor = True
        Me.Work_Tbox.UseSelectable = True
        Me.Work_Tbox.WaterMark = "Occupation"
        Me.Work_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Work_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Contact_Tbox
        '
        Me.Contact_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Contact_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.Contact_Tbox.CustomButton.Location = New System.Drawing.Point(192, 1)
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
        Me.Contact_Tbox.Location = New System.Drawing.Point(6, 327)
        Me.Contact_Tbox.MaxLength = 32767
        Me.Contact_Tbox.Name = "Contact_Tbox"
        Me.Contact_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Contact_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Contact_Tbox.SelectedText = ""
        Me.Contact_Tbox.SelectionLength = 0
        Me.Contact_Tbox.SelectionStart = 0
        Me.Contact_Tbox.ShowClearButton = True
        Me.Contact_Tbox.Size = New System.Drawing.Size(218, 27)
        Me.Contact_Tbox.TabIndex = 834
        Me.Contact_Tbox.UseCustomForeColor = True
        Me.Contact_Tbox.UseSelectable = True
        Me.Contact_Tbox.WaterMark = "Contact Number"
        Me.Contact_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Contact_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Address_Tbox
        '
        Me.Address_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Address_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.Address_Tbox.CustomButton.Location = New System.Drawing.Point(192, 1)
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
        Me.Address_Tbox.Location = New System.Drawing.Point(6, 294)
        Me.Address_Tbox.MaxLength = 32767
        Me.Address_Tbox.Name = "Address_Tbox"
        Me.Address_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Address_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Address_Tbox.SelectedText = ""
        Me.Address_Tbox.SelectionLength = 0
        Me.Address_Tbox.SelectionStart = 0
        Me.Address_Tbox.ShowClearButton = True
        Me.Address_Tbox.Size = New System.Drawing.Size(218, 27)
        Me.Address_Tbox.Style = MetroFramework.MetroColorStyle.Red
        Me.Address_Tbox.TabIndex = 833
        Me.Address_Tbox.UseCustomForeColor = True
        Me.Address_Tbox.UseSelectable = True
        Me.Address_Tbox.WaterMark = "Address"
        Me.Address_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Address_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Mname_Tbox
        '
        Me.Mname_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Mname_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mname_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        Me.Mname_Tbox.CustomButton.Location = New System.Drawing.Point(192, 1)
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
        Me.Mname_Tbox.Location = New System.Drawing.Point(6, 261)
        Me.Mname_Tbox.MaxLength = 32767
        Me.Mname_Tbox.Name = "Mname_Tbox"
        Me.Mname_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Mname_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Mname_Tbox.SelectedText = ""
        Me.Mname_Tbox.SelectionLength = 0
        Me.Mname_Tbox.SelectionStart = 0
        Me.Mname_Tbox.ShowClearButton = True
        Me.Mname_Tbox.Size = New System.Drawing.Size(218, 27)
        Me.Mname_Tbox.TabIndex = 832
        Me.Mname_Tbox.UseCustomForeColor = True
        Me.Mname_Tbox.UseSelectable = True
        Me.Mname_Tbox.WaterMark = "Middle Name"
        Me.Mname_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Mname_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Fname_Tbox
        '
        Me.Fname_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Fname_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fname_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image7"), System.Drawing.Image)
        Me.Fname_Tbox.CustomButton.Location = New System.Drawing.Point(192, 1)
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
        Me.Fname_Tbox.Location = New System.Drawing.Point(6, 228)
        Me.Fname_Tbox.MaxLength = 32767
        Me.Fname_Tbox.Name = "Fname_Tbox"
        Me.Fname_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Fname_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Fname_Tbox.SelectedText = ""
        Me.Fname_Tbox.SelectionLength = 0
        Me.Fname_Tbox.SelectionStart = 0
        Me.Fname_Tbox.ShowClearButton = True
        Me.Fname_Tbox.Size = New System.Drawing.Size(218, 27)
        Me.Fname_Tbox.Style = MetroFramework.MetroColorStyle.Red
        Me.Fname_Tbox.TabIndex = 831
        Me.Fname_Tbox.UseCustomForeColor = True
        Me.Fname_Tbox.UseSelectable = True
        Me.Fname_Tbox.WaterMark = "First Name"
        Me.Fname_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Fname_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Lname_Tbox
        '
        Me.Lname_Tbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Lname_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lname_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image8"), System.Drawing.Image)
        Me.Lname_Tbox.CustomButton.Location = New System.Drawing.Point(192, 1)
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
        Me.Lname_Tbox.Location = New System.Drawing.Point(6, 195)
        Me.Lname_Tbox.MaxLength = 32767
        Me.Lname_Tbox.Name = "Lname_Tbox"
        Me.Lname_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Lname_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Lname_Tbox.SelectedText = ""
        Me.Lname_Tbox.SelectionLength = 0
        Me.Lname_Tbox.SelectionStart = 0
        Me.Lname_Tbox.ShowClearButton = True
        Me.Lname_Tbox.Size = New System.Drawing.Size(218, 27)
        Me.Lname_Tbox.Style = MetroFramework.MetroColorStyle.Red
        Me.Lname_Tbox.TabIndex = 830
        Me.Lname_Tbox.UseCustomForeColor = True
        Me.Lname_Tbox.UseSelectable = True
        Me.Lname_Tbox.WaterMark = "Last Name"
        Me.Lname_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Lname_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ID_Tbox.CustomButton.Location = New System.Drawing.Point(192, 1)
        Me.ID_Tbox.CustomButton.Name = ""
        Me.ID_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.ID_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.ID_Tbox.CustomButton.TabIndex = 1
        Me.ID_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ID_Tbox.CustomButton.UseSelectable = True
        Me.ID_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.ID_Tbox.ForeColor = System.Drawing.Color.Black
        Me.ID_Tbox.Lines = New String(-1) {}
        Me.ID_Tbox.Location = New System.Drawing.Point(6, 162)
        Me.ID_Tbox.MaxLength = 32767
        Me.ID_Tbox.Name = "ID_Tbox"
        Me.ID_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ID_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ID_Tbox.SelectedText = ""
        Me.ID_Tbox.SelectionLength = 0
        Me.ID_Tbox.SelectionStart = 0
        Me.ID_Tbox.ShowClearButton = True
        Me.ID_Tbox.Size = New System.Drawing.Size(218, 27)
        Me.ID_Tbox.Style = MetroFramework.MetroColorStyle.Red
        Me.ID_Tbox.TabIndex = 829
        Me.ID_Tbox.UseCustomForeColor = True
        Me.ID_Tbox.UseSelectable = True
        Me.ID_Tbox.WaterMark = "ID Number"
        Me.ID_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ID_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Image_Pbox
        '
        Me.Image_Pbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Image_Pbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Image_Pbox.Image = Global.WindowsApplication1.My.Resources.Resources.users
        Me.Image_Pbox.Location = New System.Drawing.Point(6, 41)
        Me.Image_Pbox.Name = "Image_Pbox"
        Me.Image_Pbox.Size = New System.Drawing.Size(115, 115)
        Me.Image_Pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image_Pbox.TabIndex = 0
        Me.Image_Pbox.TabStop = False
        '
        'Cancel_Btn
        '
        Me.Cancel_Btn.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.Cancel_Btn.Location = New System.Drawing.Point(198, 133)
        Me.Cancel_Btn.Name = "Cancel_Btn"
        Me.Cancel_Btn.Size = New System.Drawing.Size(23, 23)
        Me.Cancel_Btn.TabIndex = 842
        Me.Cancel_Btn.Text = "X"
        Me.Cancel_Btn.UseSelectable = True
        '
        'Clear_Btn
        '
        Me.Clear_Btn.Location = New System.Drawing.Point(127, 104)
        Me.Clear_Btn.Name = "Clear_Btn"
        Me.Clear_Btn.Size = New System.Drawing.Size(65, 23)
        Me.Clear_Btn.TabIndex = 841
        Me.Clear_Btn.Text = "Clear"
        Me.Clear_Btn.UseSelectable = True
        '
        'DGV_Pnl
        '
        Me.DGV_Pnl.BackColor = System.Drawing.Color.White
        Me.DGV_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Pnl.Location = New System.Drawing.Point(0, 0)
        Me.DGV_Pnl.Name = "DGV_Pnl"
        Me.DGV_Pnl.Size = New System.Drawing.Size(736, 532)
        Me.DGV_Pnl.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.DateTime_Lbl)
        Me.Panel6.Controls.Add(Me.MetroLabel2)
        Me.Panel6.Controls.Add(Me.LoadingPB2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(1, 1)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1006, 36)
        Me.Panel6.TabIndex = 1
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(9, 6)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(123, 25)
        Me.MetroLabel2.TabIndex = 625
        Me.MetroLabel2.Text = "Welcome user"
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
        'Homepage_Cmenu
        '
        Me.Homepage_Cmenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Homepage_Cmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.Homepage_Cmenu.Name = "Homepage_Cmenu"
        Me.Homepage_Cmenu.Size = New System.Drawing.Size(108, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Image_OPFD
        '
        Me.Image_OPFD.Filter = "Image Files(*.JPG;*.JPEG;*.PNG;)|*.jpg;*.jpeg;*.png|All files(*.*)|*.*"
        Me.Image_OPFD.Title = "Select Image"
        '
        'Homepage_Ttip
        '
        Me.Homepage_Ttip.AutomaticDelay = 100
        Me.Homepage_Ttip.Style = MetroFramework.MetroColorStyle.Blue
        Me.Homepage_Ttip.StyleManager = Nothing
        Me.Homepage_Ttip.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'Homepage_Menu
        '
        Me.Homepage_Menu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Homepage_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MembersToolStripMenuItem})
        Me.Homepage_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Homepage_Menu.Name = "Homepage_Menu"
        Me.Homepage_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.Homepage_Menu.Size = New System.Drawing.Size(1008, 24)
        Me.Homepage_Menu.TabIndex = 14
        Me.Homepage_Menu.Text = "MenuStrip1"
        '
        'MembersToolStripMenuItem
        '
        Me.MembersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem})
        Me.MembersToolStripMenuItem.Name = "MembersToolStripMenuItem"
        Me.MembersToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MembersToolStripMenuItem.Text = "Admin"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AddToolStripMenuItem.Text = "Add User"
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
        'DateTime_Timer
        '
        Me.DateTime_Timer.Enabled = True
        Me.DateTime_Timer.Interval = 1000
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 600)
        Me.Controls.Add(Me.EP_Pnl)
        Me.Controls.Add(Me.Homepage_Menu)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.Homepage_Menu
        Me.Name = "Homepage"
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
        Me.Side_Pnl.ResumeLayout(False)
        Me.Side_Pnl.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Image_Pbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.LoadingPB2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Homepage_Cmenu.ResumeLayout(False)
        Me.Homepage_Menu.ResumeLayout(False)
        Me.Homepage_Menu.PerformLayout()
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
    Friend WithEvents MembersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DateTime_Lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents DateTime_Timer As Timer
End Class
