<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblcopyright = New System.Windows.Forms.Label()
        Me.chkPassword = New System.Windows.Forms.CheckBox()
        Me.lblChangePswd = New System.Windows.Forms.Label()
        Me.cmdLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblcopyright)
        Me.GroupBox1.Controls.Add(Me.chkPassword)
        Me.GroupBox1.Controls.Add(Me.lblChangePswd)
        Me.GroupBox1.Controls.Add(Me.cmdLogin)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1024, 572)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(455, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 34)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "SIGN IN"
        '
        'lblcopyright
        '
        Me.lblcopyright.AutoSize = True
        Me.lblcopyright.Font = New System.Drawing.Font("Roboto", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcopyright.ForeColor = System.Drawing.Color.White
        Me.lblcopyright.Location = New System.Drawing.Point(356, 526)
        Me.lblcopyright.Name = "lblcopyright"
        Me.lblcopyright.Size = New System.Drawing.Size(312, 19)
        Me.lblcopyright.TabIndex = 52
        Me.lblcopyright.Text = "©2022 AVLinq Solutions. All right reserved." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'chkPassword
        '
        Me.chkPassword.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkPassword.BackColor = System.Drawing.Color.White
        Me.chkPassword.BackgroundImage = CType(resources.GetObject("chkPassword.BackgroundImage"), System.Drawing.Image)
        Me.chkPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkPassword.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.chkPassword.FlatAppearance.BorderSize = 0
        Me.chkPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkPassword.Location = New System.Drawing.Point(626, 308)
        Me.chkPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkPassword.Name = "chkPassword"
        Me.chkPassword.Size = New System.Drawing.Size(22, 20)
        Me.chkPassword.TabIndex = 51
        Me.chkPassword.UseVisualStyleBackColor = False
        '
        'lblChangePswd
        '
        Me.lblChangePswd.AutoSize = True
        Me.lblChangePswd.BackColor = System.Drawing.Color.Transparent
        Me.lblChangePswd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblChangePswd.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangePswd.ForeColor = System.Drawing.Color.White
        Me.lblChangePswd.Location = New System.Drawing.Point(489, 345)
        Me.lblChangePswd.Name = "lblChangePswd"
        Me.lblChangePswd.Size = New System.Drawing.Size(171, 24)
        Me.lblChangePswd.TabIndex = 50
        Me.lblChangePswd.Text = "Change Password"
        '
        'cmdLogin
        '
        Me.cmdLogin.BackColor = System.Drawing.Color.Transparent
        Me.cmdLogin.FlatAppearance.BorderSize = 3
        Me.cmdLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogin.Font = New System.Drawing.Font("Roboto", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogin.ForeColor = System.Drawing.Color.Transparent
        Me.cmdLogin.Location = New System.Drawing.Point(419, 408)
        Me.cmdLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(187, 43)
        Me.cmdLogin.TabIndex = 47
        Me.cmdLogin.Text = "LOGIN"
        Me.cmdLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.txtPassword.Location = New System.Drawing.Point(367, 301)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(290, 34)
        Me.txtPassword.TabIndex = 46
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Roboto", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(364, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 27)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Roboto", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(367, 217)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(290, 34)
        Me.txtUsername.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Roboto", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(366, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 27)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Username:"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 572)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User_Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblcopyright As Label
    Friend WithEvents chkPassword As CheckBox
    Friend WithEvents lblChangePswd As Label
    Friend WithEvents cmdLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
