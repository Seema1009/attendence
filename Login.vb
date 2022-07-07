Imports System.Data.OleDb
Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New OleDbConnection(ConnStr)
        txtUsername.Focus()
    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        'Login Code
        If txtUsername.Text = "admin" And txtPassword.Text = "1234" Then
            Form1.Show()        ' User logins if found in database
            Form1.SSTStatus.Text = " login Success "
            Me.Hide()
            StartForm.Hide()
        Else
            MsgBox("Check Credentials")
        End If
    End Sub

    Private Sub chkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkPassword.CheckedChanged
        If chkPassword.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

End Class