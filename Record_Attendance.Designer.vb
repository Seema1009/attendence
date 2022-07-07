<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Record_Attendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Record_Attendance))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkVisitor = New System.Windows.Forms.CheckBox()
        Me.chkEmployee = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbOther = New System.Windows.Forms.RadioButton()
        Me.rbToday = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dbgAttendance = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdASCII = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dbgAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(7, 7)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(343, 31)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "ATTENDANCE RECORD"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dtpTo)
        Me.GroupBox2.Controls.Add(Me.dtpFrom)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(282, 26)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(470, 93)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Date Range"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "From"
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(251, 53)
        Me.dtpTo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(169, 28)
        Me.dtpTo.TabIndex = 1
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(48, 53)
        Me.dtpFrom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(169, 28)
        Me.dtpFrom.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Me.chkVisitor)
        Me.GroupBox3.Controls.Add(Me.chkEmployee)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(793, 26)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(327, 93)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Selection for Attendance"
        '
        'chkVisitor
        '
        Me.chkVisitor.AutoSize = True
        Me.chkVisitor.Location = New System.Drawing.Point(194, 43)
        Me.chkVisitor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkVisitor.Name = "chkVisitor"
        Me.chkVisitor.Size = New System.Drawing.Size(83, 28)
        Me.chkVisitor.TabIndex = 1
        Me.chkVisitor.Text = "Visitor"
        Me.chkVisitor.UseVisualStyleBackColor = True
        '
        'chkEmployee
        '
        Me.chkEmployee.AutoSize = True
        Me.chkEmployee.Location = New System.Drawing.Point(20, 43)
        Me.chkEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkEmployee.Name = "chkEmployee"
        Me.chkEmployee.Size = New System.Drawing.Size(118, 28)
        Me.chkEmployee.TabIndex = 0
        Me.chkEmployee.Text = "Employee"
        Me.chkEmployee.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.rbOther)
        Me.GroupBox1.Controls.Add(Me.rbToday)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 26)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(238, 93)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date Selection"
        '
        'rbOther
        '
        Me.rbOther.AutoSize = True
        Me.rbOther.Location = New System.Drawing.Point(132, 42)
        Me.rbOther.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbOther.Name = "rbOther"
        Me.rbOther.Size = New System.Drawing.Size(78, 28)
        Me.rbOther.TabIndex = 1
        Me.rbOther.Text = "Other"
        Me.rbOther.UseVisualStyleBackColor = True
        '
        'rbToday
        '
        Me.rbToday.AutoSize = True
        Me.rbToday.Checked = True
        Me.rbToday.Location = New System.Drawing.Point(18, 42)
        Me.rbToday.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbToday.Name = "rbToday"
        Me.rbToday.Size = New System.Drawing.Size(84, 28)
        Me.rbToday.TabIndex = 0
        Me.rbToday.TabStop = True
        Me.rbToday.Text = "Today"
        Me.rbToday.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdLoad)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(13, 67)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(1302, 135)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'cmdLoad
        '
        Me.cmdLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.cmdLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdLoad.ForeColor = System.Drawing.Color.White
        Me.cmdLoad.Location = New System.Drawing.Point(1159, 58)
        Me.cmdLoad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(112, 38)
        Me.cmdLoad.TabIndex = 5
        Me.cmdLoad.Text = "Load"
        Me.cmdLoad.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dbgAttendance)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(14, 219)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(1589, 750)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Record Table.:"
        '
        'dbgAttendance
        '
        Me.dbgAttendance.AllowUserToAddRows = False
        Me.dbgAttendance.AllowUserToDeleteRows = False
        Me.dbgAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dbgAttendance.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dbgAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbgAttendance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dbgAttendance.Location = New System.Drawing.Point(3, 21)
        Me.dbgAttendance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dbgAttendance.Name = "dbgAttendance"
        Me.dbgAttendance.ReadOnly = True
        Me.dbgAttendance.RowHeadersWidth = 62
        Me.dbgAttendance.RowTemplate.Height = 28
        Me.dbgAttendance.Size = New System.Drawing.Size(1583, 727)
        Me.dbgAttendance.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(1558, 106)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 38)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(1409, 173)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(123, 28)
        Me.txtTotal.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1341, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 24)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Total: "
        '
        'cmdASCII
        '
        Me.cmdASCII.BackgroundImage = CType(resources.GetObject("cmdASCII.BackgroundImage"), System.Drawing.Image)
        Me.cmdASCII.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdASCII.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdASCII.Location = New System.Drawing.Point(1558, 164)
        Me.cmdASCII.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdASCII.Name = "cmdASCII"
        Me.cmdASCII.Size = New System.Drawing.Size(44, 38)
        Me.cmdASCII.TabIndex = 42
        Me.cmdASCII.UseVisualStyleBackColor = True
        '
        'Record_Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1630, 1020)
        Me.Controls.Add(Me.cmdASCII)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lblHeading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Record_Attendance"
        Me.Text = "Record_Attendance"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dbgAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkVisitor As CheckBox
    Friend WithEvents chkEmployee As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbOther As RadioButton
    Friend WithEvents rbToday As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmdLoad As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents dbgAttendance As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdASCII As Button
End Class
