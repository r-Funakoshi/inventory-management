Option Strict On

Public Class Search

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim search As New Results()

        search.ShowDialog(Me)
        search.Dispose()

    End Sub

End Class
