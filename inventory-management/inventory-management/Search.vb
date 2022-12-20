Public Class Search
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New Results()

        f.ShowDialog(Me)
        f.Dispose()

    End Sub
End Class
