Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Format(Now, "dd-MM-yyyy")
    End Sub
End Class