Option Strict On

Public Class Search

    ''' <summary>
    ''' 一覧画面を開く
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim search As New Results()

        search.ShowDialog(Me)
        search.Dispose()

    End Sub

End Class
