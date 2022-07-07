
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor
        'Standardization
        Call Init_Content(MenuStrip1)

        'Loading the container with the Dashboard Screen
        Dim dbd As New Dashboard
        dbd.MdiParent = Me
        dbd.Dock = DockStyle.Fill
        dbd.Show()
        User_ID = Login.txtUsername.Text
        SSTUserProfile.Text = User_ID

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub DashboardTSMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardTSMenuItem.Click
        'Opening the dashboard Screen 
        Dim dbd As New Dashboard
        dbd.MdiParent = Me
        dbd.Dock = DockStyle.Fill
        dbd.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutTSMenuItem.Click
        'User Logout Code
        StartForm.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Timer in the status strip
        SSTtime.Text = Format(Now(), "hh:mm tt")
    End Sub

    Private Sub StatusTimer_Tick(sender As Object, e As EventArgs) Handles StatusTimer.Tick
        SSTStatus.Text = ""
    End Sub

    Private Sub PreAppTSMenuItem1_Click(sender As Object, e As EventArgs) Handles PreAppTSMenuItem1.Click
        'Opening the Attendance Record 
        Dim dbAttend As New Record_Attendance
        dbAttend.MdiParent = Me
        dbAttend.Dock = DockStyle.Fill
        dbAttend.Show()
    End Sub
End Class
