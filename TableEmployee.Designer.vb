<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TableEmployee))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxEmp = New System.Windows.Forms.ComboBox()
        Me.chkInactive = New System.Windows.Forms.CheckBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dbgEmp = New System.Windows.Forms.DataGridView()
        Me.cmdExcel = New System.Windows.Forms.Button()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dbgEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(8, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(315, 38)
        Me.lblHeading.TabIndex = 7
        Me.lblHeading.Text = "Employees Database"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxEmp)
        Me.GroupBox1.Controls.Add(Me.chkInactive)
        Me.GroupBox1.Controls.Add(Me.chkActive)
        Me.GroupBox1.Controls.Add(Me.cmdSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1146, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 131)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Employee"
        '
        'cbxEmp
        '
        Me.cbxEmp.FormattingEnabled = True
        Me.cbxEmp.Location = New System.Drawing.Point(6, 81)
        Me.cbxEmp.Name = "cbxEmp"
        Me.cbxEmp.Size = New System.Drawing.Size(256, 35)
        Me.cbxEmp.TabIndex = 4
        '
        'chkInactive
        '
        Me.chkInactive.Location = New System.Drawing.Point(156, 33)
        Me.chkInactive.Name = "chkInactive"
        Me.chkInactive.Size = New System.Drawing.Size(127, 31)
        Me.chkInactive.TabIndex = 2
        Me.chkInactive.Text = "Inactive"
        Me.chkInactive.UseVisualStyleBackColor = True
        '
        'chkActive
        '
        Me.chkActive.Location = New System.Drawing.Point(14, 33)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(123, 31)
        Me.chkActive.TabIndex = 0
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.cmdSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.ForeColor = System.Drawing.Color.White
        Me.cmdSearch.Location = New System.Drawing.Point(278, 77)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(136, 41)
        Me.cmdSearch.TabIndex = 1
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dbgEmp)
        Me.GroupBox2.Font = New System.Drawing.Font("Roboto", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(1636, 791)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employees Details"
        '
        'dbgEmp
        '
        Me.dbgEmp.AllowUserToAddRows = False
        Me.dbgEmp.AllowUserToDeleteRows = False
        Me.dbgEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dbgEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbgEmp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dbgEmp.Location = New System.Drawing.Point(3, 30)
        Me.dbgEmp.Name = "dbgEmp"
        Me.dbgEmp.ReadOnly = True
        Me.dbgEmp.RowHeadersWidth = 62
        Me.dbgEmp.RowTemplate.Height = 28
        Me.dbgEmp.Size = New System.Drawing.Size(1630, 758)
        Me.dbgEmp.TabIndex = 13
        '
        'cmdExcel
        '
        Me.cmdExcel.BackColor = System.Drawing.SystemColors.Window
        Me.cmdExcel.BackgroundImage = CType(resources.GetObject("cmdExcel.BackgroundImage"), System.Drawing.Image)
        Me.cmdExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdExcel.FlatAppearance.BorderSize = 0
        Me.cmdExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExcel.Location = New System.Drawing.Point(1588, 115)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(49, 50)
        Me.cmdExcel.TabIndex = 13
        Me.cmdExcel.UseVisualStyleBackColor = False
        '
        'cmdLoad
        '
        Me.cmdLoad.AutoSize = True
        Me.cmdLoad.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdLoad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLoad.Font = New System.Drawing.Font("Roboto", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoad.ForeColor = System.Drawing.Color.White
        Me.cmdLoad.Location = New System.Drawing.Point(369, 103)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLoad.Size = New System.Drawing.Size(100, 50)
        Me.cmdLoad.TabIndex = 27
        Me.cmdLoad.Text = "Load"
        Me.cmdLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdLoad.UseVisualStyleBackColor = False
        '
        'cmdAdd
        '
        Me.cmdAdd.AutoSize = True
        Me.cmdAdd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.Font = New System.Drawing.Font("Roboto", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.ForeColor = System.Drawing.Color.White
        Me.cmdAdd.Location = New System.Drawing.Point(15, 103)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAdd.Size = New System.Drawing.Size(100, 50)
        Me.cmdAdd.TabIndex = 24
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.AutoSize = True
        Me.cmdDelete.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Font = New System.Drawing.Font("Roboto", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.ForeColor = System.Drawing.Color.White
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDelete.Location = New System.Drawing.Point(251, 103)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDelete.Size = New System.Drawing.Size(100, 50)
        Me.cmdDelete.TabIndex = 26
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdEdit
        '
        Me.cmdEdit.AutoSize = True
        Me.cmdEdit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEdit.Font = New System.Drawing.Font("Roboto", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.ForeColor = System.Drawing.Color.White
        Me.cmdEdit.Location = New System.Drawing.Point(133, 103)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEdit.Size = New System.Drawing.Size(100, 50)
        Me.cmdEdit.TabIndex = 25
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'TableEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1660, 980)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdExcel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TableEmployee"
        Me.Text = "Employee Database"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dbgEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdSearch As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dbgEmp As DataGridView
    Friend WithEvents chkInactive As CheckBox
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents cmdExcel As Button
    Friend WithEvents cbxEmp As ComboBox
    Friend WithEvents cmdLoad As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdEdit As Button
End Class
