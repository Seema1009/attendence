<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.cmdLoginPg = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMain
        '
        Me.picMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picMain.Image = CType(resources.GetObject("picMain.Image"), System.Drawing.Image)
        Me.picMain.Location = New System.Drawing.Point(0, 0)
        Me.picMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(1898, 1024)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMain.TabIndex = 0
        Me.picMain.TabStop = False
        '
        'cmdLoginPg
        '
        Me.cmdLoginPg.BackColor = System.Drawing.Color.White
        Me.cmdLoginPg.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdLoginPg.FlatAppearance.BorderSize = 3
        Me.cmdLoginPg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.cmdLoginPg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdLoginPg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdLoginPg.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoginPg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.cmdLoginPg.Location = New System.Drawing.Point(1173, 636)
        Me.cmdLoginPg.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdLoginPg.Name = "cmdLoginPg"
        Me.cmdLoginPg.Size = New System.Drawing.Size(172, 47)
        Me.cmdLoginPg.TabIndex = 1
        Me.cmdLoginPg.Text = "LOGIN"
        Me.cmdLoginPg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdLoginPg.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.picLogo.Location = New System.Drawing.Point(1175, 420)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(170, 139)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 2
        Me.picLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1063, 964)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "©2022 AVLinq Solutions. All right reserved."
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.cmdLoginPg)
        Me.Controls.Add(Me.picMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "StartForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  ATTENDANCE SYSTEM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picMain As PictureBox
    Friend WithEvents cmdLoginPg As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents Label1 As Label
End Class
