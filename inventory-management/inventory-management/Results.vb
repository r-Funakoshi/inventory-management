Option Strict On

Imports System.Data.SQLite

Public Class ResultForm
    Public Property ConnectString As String = "Data Source = card_stock.db"

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
    ''' データベースのデータを取得
    ''' </summary>
    ''' <returns></returns>
    Public Function ListCards() As DataTable

        Dim dt As DataTable = New DataTable

        Using connection = New SQLiteConnection(ConnectString)
            connection.Open()

            Using cmd = New SQLiteCommand(connection)
                cmd.CommandText = "
SELECT 
  name
, image 
FROM card_stock
;"
                cmd.ExecuteNonQuery()
                ' DataAdapterの生成
                Dim da = New SQLiteDataAdapter(cmd)
                ' データベースからデータを取得
                da.Fill(dt)
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
        Dim connection = New Object
        Dim tableCards = ListCards()
        Dim cardCount = tableCards.Rows.Count

        'イメージリストのサイズを指定
        ResultImageList.ImageSize = New Size(width, height)
        ResultListView.LargeImageList = ResultImageList

        Dim imgconv As New ImageConverter()

        For i = 0 To cardCount - 1
            Dim cardName = CType(tableCards.Rows(i)(0), String)
            Dim img As Image = CType(imgconv.ConvertFrom(tableCards.Rows(i)(1)), Image)
            Dim thumbnail = CreateThumbnail(img, width, height)

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

End Class