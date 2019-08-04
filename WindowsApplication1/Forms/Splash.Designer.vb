<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Me.Splash_Progress = New MetroFramework.Controls.MetroProgressBar()
        Me.Splash_Lbl = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'Splash_Progress
        '
        Me.Splash_Progress.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splash_Progress.Location = New System.Drawing.Point(0, 106)
        Me.Splash_Progress.Name = "Splash_Progress"
        Me.Splash_Progress.Size = New System.Drawing.Size(496, 16)
        Me.Splash_Progress.Style = MetroFramework.MetroColorStyle.Silver
        Me.Splash_Progress.TabIndex = 0
        '
        'Splash_Lbl
        '
        Me.Splash_Lbl.BackColor = System.Drawing.Color.Transparent
        Me.Splash_Lbl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splash_Lbl.FontSize = MetroFramework.MetroLabelSize.Small
        Me.Splash_Lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Splash_Lbl.Location = New System.Drawing.Point(0, 92)
        Me.Splash_Lbl.Name = "Splash_Lbl"
        Me.Splash_Lbl.Size = New System.Drawing.Size(496, 14)
        Me.Splash_Lbl.TabIndex = 1
        Me.Splash_Lbl.Text = "Checking files."
        Me.Splash_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Splash_Lbl.UseCustomBackColor = True
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.website_mcgi
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(496, 122)
        Me.ControlBox = False
        Me.Controls.Add(Me.Splash_Lbl)
        Me.Controls.Add(Me.Splash_Progress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Splash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Splash_Progress As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents Splash_Lbl As MetroFramework.Controls.MetroLabel
End Class
