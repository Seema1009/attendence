<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.grpVtotal = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVtotal = New System.Windows.Forms.Label()
        Me.btnVtotal = New System.Windows.Forms.Button()
        Me.cmdRefreshDB = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.picVtotal = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.grpVtotal.SuspendLayout()
        CType(Me.picVtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpVtotal
        '
        Me.grpVtotal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpVtotal.BackColor = System.Drawing.Color.Honeydew
        Me.grpVtotal.Controls.Add(Me.Label1)
        Me.grpVtotal.Controls.Add(Me.lblVtotal)
        Me.grpVtotal.Controls.Add(Me.btnVtotal)
        Me.grpVtotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpVtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpVtotal.ForeColor = System.Drawing.Color.White
        Me.grpVtotal.Location = New System.Drawing.Point(108, 121)
        Me.grpVtotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpVtotal.Name = "grpVtotal"
        Me.grpVtotal.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpVtotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpVtotal.Size = New System.Drawing.Size(345, 182)
        Me.grpVtotal.TabIndex = 11
        Me.grpVtotal.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(221, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Employees"
        '
        'lblVtotal
        '
        Me.lblVtotal.AutoSize = True
        Me.lblVtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold)
        Me.lblVtotal.ForeColor = System.Drawing.Color.Black
        Me.lblVtotal.Location = New System.Drawing.Point(242, 68)
        Me.lblVtotal.Name = "lblVtotal"
        Me.lblVtotal.Size = New System.Drawing.Size(97, 52)
        Me.lblVtotal.TabIndex = 10
        Me.lblVtotal.Text = "100"
        Me.lblVtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVtotal
        '
        Me.btnVtotal.BackColor = System.Drawing.Color.White
        Me.btnVtotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnVtotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnVtotal.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnVtotal.FlatAppearance.BorderSize = 2
        Me.btnVtotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnVtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVtotal.Location = New System.Drawing.Point(3, 149)
        Me.btnVtotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVtotal.Name = "btnVtotal"
        Me.btnVtotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnVtotal.Size = New System.Drawing.Size(339, 31)
        Me.btnVtotal.TabIndex = 3
        Me.btnVtotal.Text = "Show All" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnVtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVtotal.UseVisualStyleBackColor = False
        '
        'cmdRefreshDB
        '
        Me.cmdRefreshDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.cmdRefreshDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRefreshDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefreshDB.ForeColor = System.Drawing.Color.White
        Me.cmdRefreshDB.Location = New System.Drawing.Point(1448, 19)
        Me.cmdRefreshDB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdRefreshDB.Name = "cmdRefreshDB"
        Me.cmdRefreshDB.Size = New System.Drawing.Size(148, 42)
        Me.cmdRefreshDB.TabIndex = 15
        Me.cmdRefreshDB.Text = "Refresh"
        Me.cmdRefreshDB.UseVisualStyleBackColor = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(24, 18)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(309, 31)
        Me.lblHeading.TabIndex = 14
        Me.lblHeading.Text = "EMPLOYEE STATUS: "
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate.Location = New System.Drawing.Point(338, 18)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(101, 31)
        Me.lblDate.TabIndex = 17
        Me.lblDate.Text = "Label1"
        '
        'picVtotal
        '
        Me.picVtotal.Image = CType(resources.GetObject("picVtotal.Image"), System.Drawing.Image)
        Me.picVtotal.Location = New System.Drawing.Point(49, 113)
        Me.picVtotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picVtotal.Name = "picVtotal"
        Me.picVtotal.Size = New System.Drawing.Size(119, 88)
        Me.picVtotal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVtotal.TabIndex = 0
        Me.picVtotal.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(622, 113)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(680, 121)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(345, 182)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(249, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Present"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(242, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 52)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "100"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(3, 149)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(339, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Show All" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1197, 113)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 88)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox3.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(1252, 121)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox3.Size = New System.Drawing.Size(345, 182)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(255, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Absent"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(245, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 52)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "100"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(3, 149)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(339, 31)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Show All" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Chart1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Chart2, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(85, 337)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1477, 626)
        Me.TableLayoutPanel1.TabIndex = 24
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 2)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(732, 622)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Chart2
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Me.Chart2.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(741, 2)
        Me.Chart2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Chart2.Name = "Chart2"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(733, 622)
        Me.Chart2.TabIndex = 1
        Me.Chart2.Text = "Chart2"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1630, 1020)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.picVtotal)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.cmdRefreshDB)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.grpVtotal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.grpVtotal.ResumeLayout(False)
        Me.grpVtotal.PerformLayout()
        CType(Me.picVtotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpVtotal As GroupBox
    Friend WithEvents lblVtotal As Label
    Friend WithEvents cmdRefreshDB As Button
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVtotal As Button
    Friend WithEvents picVtotal As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
End Class
