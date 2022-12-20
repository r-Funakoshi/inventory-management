Option Strict On

Public Class Results
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim _imageDir = "C:\Users\risa-funakoshi\Documents\repos\inventory-management\images" ' 画像ディレクトリ
        Dim _jpgFiles() =
        System.IO.Directory.GetFiles(_imageDir, "*.jpg")

        Dim _width = 120
        Dim _height = 100

        ImageList1.ImageSize = New Size(_width, _height)
        ListView1.LargeImageList = ImageList1

        For i = 0 To _jpgFiles.Length - 1
            Dim _original = Bitmap.FromFile(_jpgFiles(i))
            Dim _thumbnail = createThumbnail(_original, _width, _height)

            ImageList1.Images.Add(_thumbnail)
            ListView1.Items.Add(_jpgFiles(i), i)

            _original.Dispose()
            _thumbnail.Dispose()
        Next

    End Sub

    Function createThumbnail(ByVal image As Image, ByVal _width As Integer, ByVal _height As Integer) As Image
        Dim _canvas As New Bitmap(_width, _height)

        Dim _draw = Graphics.FromImage(_canvas)

        Dim _fw = CType(_width, Double) / CType(image.Width, Double)
        Dim _fh = CType(_height, Double) / CType(image.Height, Double)
        Dim _scale = Math.Min(_fw, _fh)

        Dim _w2 = CType(image.Width * _scale, Integer)
        Dim _h2 = CType(image.Height * _scale, Integer)

        _draw.DrawImage(image, (_width - _w2) \ 2, (_height - _h2) \ 2, _w2, _h2)
        _draw.Dispose()

        Return _canvas
    End Function

End Class