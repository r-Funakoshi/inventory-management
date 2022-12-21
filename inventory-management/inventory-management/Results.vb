﻿Option Strict On

Public Class Results

    ''' <summary>
    ''' 検索結果一覧表示画面 ロード時の処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim imageDir = "C:\Users\risa-funakoshi\Documents\repos\inventory-management\images" ' 画像ディレクトリ
        Dim jpgFiles() =
        System.IO.Directory.GetFiles(imageDir, "*.jpg")

        Dim width = 120
        Dim height = 100

        ImageList1.ImageSize = New Size(width, height)
        ListView1.LargeImageList = ImageList1

        For i = 0 To jpgFiles.Length - 1
            Dim original = Bitmap.FromFile(jpgFiles(i))
            Dim thumbnail = createThumbnail(original, width, height)

            ImageList1.Images.Add(thumbnail)
            ListView1.Items.Add(jpgFiles(i), i)

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
    Function createThumbnail(image As Image, width As Integer, height As Integer) As Image
        Dim canvas As New Bitmap(width, height)
        Dim draw = Graphics.FromImage(canvas)
        Dim downsizeWidth = CType(image.Width * (height / image.Height), Integer)
        Dim downsizeHeight = CType(image.Height * (height / image.Height), Integer)

        draw.DrawImage(image, (width - downsizeWidth) \ 2, (height - downsizeHeight) \ 2, downsizeWidth, downsizeHeight)
        draw.Dispose()

        MessageBox.Show(CType(image.Width, String))
        MessageBox.Show(CType(height, String))
        MessageBox.Show(CType(image.Height, String))
        Return canvas
    End Function

End Class