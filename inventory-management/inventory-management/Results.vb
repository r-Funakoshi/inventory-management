Option Strict On

Imports System.Data.SQLite
Imports System.Drawing.Text
Imports System.Security.Cryptography.X509Certificates

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
    Public Function ListDisplay() As DataTable

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

        Dim imageDirectory = "C:\Users\risa-funakoshi\Documents\repos\inventory-management\images" ' 画像ディレクトリ
        Dim jpgFiles() =
        System.IO.Directory.GetFiles(imageDirectory, "*.jpg")

        Dim width = 120
        Dim height = 100

        'イメージリストのサイズを指定
        ImageList1.ImageSize = New Size(width, height)
        ResultListView.LargeImageList = ImageList1

        For i = 0 To jpgFiles.Length - 1
            Dim original = Bitmap.FromFile(jpgFiles(i))
            Dim thumbnail = CreateThumbnail(original, width, height)

            ImageList1.Images.Add(thumbnail)
            ResultListView.Items.Add(jpgFiles(i), i)

            original.Dispose()
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