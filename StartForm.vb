Public Class StartForm
    Private Sub StartForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        picLogo.Image = Image.FromFile("\\192.168.240.3\General Vendor Data\wilson\customer-Logo.png")
    End Sub

    Private Sub cmdLoginPg_Click(sender As Object, e As EventArgs) Handles cmdLoginPg.Click
        'Opening Login Form 
        Login.txtUsername.Text = ""
        Login.txtPassword.Text = ""
        Login.Show()
    End Sub
End Class