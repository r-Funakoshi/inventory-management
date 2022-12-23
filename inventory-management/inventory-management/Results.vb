Option Strict On

Imports System.Data.SQLite
Imports System.Runtime.Remoting.Channels

Public Class ResultForm
    Public Property ConnectString As String = "Data Source = card_stock.db"
    Public Property CardIdList() As New List(Of Integer)

    'データ追加、削除用
    'Public Sub ExecuteNoneQuery(connectString As String, sql As String)
    '    'インスタンス生成
    '    Using connection = New SQLiteConnection(connectString)
    '        'DB接続
    '        connection.Open()
    '        'コマンドのインスタンス化
    '        Using cmd = New SQLiteCommand(connection)
    '            cmd.CommandText = sql
    '            cmd.ExecuteNonQuery()
    '        End Using
    '    End Using
    'End Sub

    ''' <summary>
    ''' 登録されている cardstock から名前と画像のデータを DataTable で取得
    ''' </summary>
    ''' <returns></returns>
    Public Function GetCards() As DataTable

        Dim dt = New DataTable

        Using connection = New SQLiteConnection(ConnectString)
            connection.Open()

            Using cmd = New SQLiteCommand(connection)
                cmd.CommandText = "
SELECT 
  id
, name
, status
, image
FROM card_stock
;"
                cmd.ExecuteNonQuery()
                ' DataAdapterの生成
                Dim dataAdapter = New SQLiteDataAdapter(cmd)
                ' データベースからデータを取得
                dataAdapter.Fill(dt)
            End Using
        End Using
        Return dt

    End Function

    ''' <summary>
    ''' 検索結果一覧表示画面 ロード時の処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim width = 120
        Dim height = 100
        'イメージリストのサイズを指定
        ResultImageList.ImageSize = New Size(width, height)
        ResultListView.LargeImageList = ResultImageList

        Dim imgconv As New ImageConverter()

        Dim tableCards = GetCards()

        Dim cardCount = tableCards.Rows.Count
        For i = 0 To cardCount - 1
            Dim cardName = CType(tableCards.Rows(i)("status"), String) + CType(tableCards.Rows(i)("name"), String)
            Dim img = CType(imgconv.ConvertFrom(tableCards.Rows(i)("image")), Image)
            Dim thumbnail = CreateThumbnail(img, width, height)
            CardIdList.Add(CType(tableCards.Rows(i)("id"), Integer))

            ResultImageList.Images.Add(thumbnail)
            ResultListView.Items.Add(cardName, i)

            img.Dispose()
            thumbnail.Dispose()
        Next

    End Sub


    ''' <summary>
    ''' 画像サイズを調整したサムネイル画像の作成を行う
    ''' </summary>
    ''' <param name="image"></param>
    ''' <param name="width"></param>
    ''' <param name="height"></param>
    ''' <returns></returns>
    Function CreateThumbnail(image As Image, width As Integer, height As Integer) As Image
        Dim canvas As New Bitmap(width, height)
        Dim draw = Graphics.FromImage(canvas)
        Dim downsizeWidth = CType(image.Width * (height / image.Height), Integer)
        Dim downsizeHeight = CType(image.Height * (height / image.Height), Integer)

        draw.DrawImage(image, (width - downsizeWidth) \ 2, (height - downsizeHeight) \ 2, downsizeWidth, downsizeHeight)
        draw.Dispose()

        Return canvas
    End Function

    ''' <summary>
    '''  ListView 内でクリックした場所の index 番号を integer 型で取得
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub test(sender As Object, e As EventArgs) Handles ResultListView.ItemActivate
        Dim lv = DirectCast(sender, ListView)

        Dim selectIndexNo = lv.FocusedItem.Index
        Dim id = CardIdList(selectIndexNo)

        Using connection = New SQLiteConnection(ConnectString)
            connection.Open()

            Using cmd = New SQLiteCommand(connection)
                cmd.CommandText = $"
SELECT 
  id
, name
, rarity
, status
, price
, kind
, stock
, image
FROM card_stock
WHERE id = {id}
;"

                ' DataAdapterの生成
                Dim dataAdapter = New SQLiteDataAdapter(cmd)
                Dim dt = New DataTable
                ' データベースからデータを取得
                dataAdapter.Fill(dt)

                Dim card = New CardStock With {
                    .Id = CInt(dt.Rows(0)("id")),
                    .Name = dt.Rows(0)("name").ToString(),
                    .Rarity = dt.Rows(0)("rarity").ToString(),
                    .Status = dt.Rows(0)("status").ToString(),
                    .Price = CInt(dt.Rows(0)("price")),
                    .Kind = dt.Rows(0)("kind").ToString(),
                    .Stock = CInt(dt.Rows(0)("stock")),
                    .Image = ConvertBLOBToImage(dt.Rows(0)("image"))
                }

                Dim detail As New Detail(card)
                detail.ShowDialog(Me)
                detail.Dispose()

            End Using
        End Using

    End Sub
    ''' <summary>
    ''' Image型からByte型へ変換する
    ''' </summary>
    ''' <param name="image"></param>
    ''' <returns></returns>
    Public Shared Function ConvertImageToByte(image As Image) As Byte()

        If image IsNot Nothing Then
            Dim converter As New ImageConverter()
            Dim imageByte As Byte() = CType(converter.ConvertTo(image, GetType(Byte())), Byte())
            Return imageByte
        End If

        Dim returnData As Byte() = Nothing
        Return returnData
    End Function

    ''' <summary>
    ''' BLOB型からImage型へ変換する
    ''' </summary>
    ''' <param name="imageObject"></param>
    ''' <returns></returns>
    Public Shared Function ConvertBLOBToImage(imageObject As Object) As Image
        Dim image As Image = Nothing

        ' オブジェクトの値がNULLでなければImage型へ変換する
        If Not DBNull.Value.Equals(imageObject) Then
            image = CType(New ImageConverter().ConvertFrom(imageObject), Image)
        End If

        Return image
    End Function

End Class