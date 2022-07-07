<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SSTUserProfile = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SSTStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SSTtime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusTimer = New System.Windows.Forms.Timer(Me.components)
        Me.DashboardTSMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MngDataTSMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeesTSMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserPfTSMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreAppTSMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutTSMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SSTUserProfile, Me.SSTStatus, Me.ToolStripStatusLabel1, Me.SSTtime, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(280, 986)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1614, 34)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SSTUserProfile
        '
        Me.SSTUserProfile.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.SSTUserProfile.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.SSTUserProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.SSTUserProfile.Image = CType(resources.GetObject("SSTUserProfile.Image"), System.Drawing.Image)
        Me.SSTUserProfile.Name = "SSTUserProfile"
        Me.SSTUserProfile.Size = New System.Drawing.Size(77, 28)
        Me.SSTUserProfile.Text = "User"
        '
        'SSTStatus
        '
        Me.SSTStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSTStatus.Name = "SSTStatus"
        Me.SSTStatus.Size = New System.Drawing.Size(60, 42)
        Me.SSTStatus.Text = "Status"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(1367, 42)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'SSTtime
        '
        Me.SSTtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.SSTtime.Name = "SSTtime"
        Me.SSTtime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SSTtime.Size = New System.Drawing.Size(89, 28)
        Me.SSTtime.Text = "11:27 AM"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(17, 42)
        Me.ToolStripStatusLabel2.Text = "1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'StatusTimer
        '
        Me.StatusTimer.Enabled = True
        Me.StatusTimer.Interval = 15000
        '
        'DashboardTSMenuItem
        '
        Me.DashboardTSMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DashboardTSMenuItem.ForeColor = System.Drawing.Color.Black
        Me.DashboardTSMenuItem.Image = CType(resources.GetObject("DashboardTSMenuItem.Image"), System.Drawing.Image)
        Me.DashboardTSMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardTSMenuItem.Name = "DashboardTSMenuItem"
        Me.DashboardTSMenuItem.Padding = New System.Windows.Forms.Padding(20, 8, 6, 8)
        Me.DashboardTSMenuItem.Size = New System.Drawing.Size(274, 45)
        Me.DashboardTSMenuItem.Text = "  &Dashboard"
        Me.DashboardTSMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MngDataTSMenuItem
        '
        Me.MngDataTSMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeesTSMenuItem})
        Me.MngDataTSMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.MngDataTSMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MngDataTSMenuItem.Image = CType(resources.GetObject("MngDataTSMenuItem.Image"), System.Drawing.Image)
        Me.MngDataTSMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MngDataTSMenuItem.Name = "MngDataTSMenuItem"
        Me.MngDataTSMenuItem.Padding = New System.Windows.Forms.Padding(20, 8, 6, 8)
        Me.MngDataTSMenuItem.Size = New System.Drawing.Size(274, 45)
        Me.MngDataTSMenuItem.Text = "  &Manage Data"
        Me.MngDataTSMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmployeesTSMenuItem
        '
        Me.EmployeesTSMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.EmployeesTSMenuItem.Name = "EmployeesTSMenuItem"
        Me.EmployeesTSMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.EmployeesTSMenuItem.Text = "Employees"
        '
        'UserPfTSMenuItem
        '
        Me.UserPfTSMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.UserPfTSMenuItem.ForeColor = System.Drawing.Color.Black
        Me.UserPfTSMenuItem.Image = CType(resources.GetObject("UserPfTSMenuItem.Image"), System.Drawing.Image)
        Me.UserPfTSMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UserPfTSMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.UserPfTSMenuItem.Name = "UserPfTSMenuItem"
        Me.UserPfTSMenuItem.Padding = New System.Windows.Forms.Padding(20, 8, 6, 8)
        Me.UserPfTSMenuItem.Size = New System.Drawing.Size(274, 45)
        Me.UserPfTSMenuItem.Text = "  &User Profile"
        Me.UserPfTSMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PreAppTSMenuItem1
        '
        Me.PreAppTSMenuItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PreAppTSMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.PreAppTSMenuItem1.Image = CType(resources.GetObject("PreAppTSMenuItem1.Image"), System.Drawing.Image)
        Me.PreAppTSMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PreAppTSMenuItem1.Name = "PreAppTSMenuItem1"
        Me.PreAppTSMenuItem1.Padding = New System.Windows.Forms.Padding(20, 8, 6, 8)
        Me.PreAppTSMenuItem1.Size = New System.Drawing.Size(274, 45)
        Me.PreAppTSMenuItem1.Text = "  Attendance Record"
        Me.PreAppTSMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoutTSMenuItem
        '
        Me.LogoutTSMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LogoutTSMenuItem.ForeColor = System.Drawing.Color.Black
        Me.LogoutTSMenuItem.Image = CType(resources.GetObject("LogoutTSMenuItem.Image"), System.Drawing.Image)
        Me.LogoutTSMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutTSMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.LogoutTSMenuItem.Name = "LogoutTSMenuItem"
        Me.LogoutTSMenuItem.Padding = New System.Windows.Forms.Padding(20, 8, 6, 8)
        Me.LogoutTSMenuItem.Size = New System.Drawing.Size(274, 45)
        Me.LogoutTSMenuItem.Text = "  Log Out"
        Me.LogoutTSMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(274, 33)
        Me.ToolStripMenuItem2.Text = " "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(3)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardTSMenuItem, Me.MngDataTSMenuItem, Me.UserPfTSMenuItem, Me.PreAppTSMenuItem1, Me.LogoutTSMenuItem, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(280, 1020)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1894, 1020)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = " VISITOR MANAGEMENT SYSTEM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SSTStatus As ToolStripStatusLabel
    Friend WithEvents SSTtime As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SSTUserProfile As ToolStripStatusLabel
    Friend WithEvents StatusTimer As Timer
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents DashboardTSMenuItem As ToolStripMenuItem
    Friend WithEvents MngDataTSMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeesTSMenuItem As ToolStripMenuItem
    Friend WithEvents UserPfTSMenuItem As ToolStripMenuItem
    Friend WithEvents PreAppTSMenuItem1 As ToolStripMenuItem
    Friend WithEvents LogoutTSMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
