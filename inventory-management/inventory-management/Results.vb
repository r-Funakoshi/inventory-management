Public Class Results
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ListView1.View = View.Details
        'ListView1.Columns.Add("a", 1, HorizontalAlignment.Left)

        Dim itemx As New ListViewItem
        'itemx.Text = "VB"
        'itemx.ImageIndex = 0

        'ListView1.Items.Add(itemx)



        'リストビューに追加するアイテム

        Dim wkItem As ListViewItem
        wkItem = New ListViewItem()

        wkItem.Text = "表示する名前WWWWWWWWWWWWWWWWWWWWWWWWWWW"
        '表示するアイコン
        wkItem.ImageIndex = 0
        wkItem.SubItems.Add("説明1")
        'wkItem.SubItems.Add("説明2")
        ListView1.Items.Add(wkItem)





    End Sub
End Class