Option Strict On
Imports System.Data.SQLite

Public Class Detail
    Private Card As CardStock
    Public Property ConnectString As String = "Data Source = card_stock.db"

    Sub New(card As CardStock)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        Me.Card = card
        CardNameTextBox.Text = card.Name
        CardRarityComboBox.Text = card.Rarity
        CardKindComboBox.Text = card.Kind
        CardStatusComboBox.Text = card.Status
        PriceTextBox.Text = card.Price.ToString("c")
        CardPictureBox.Image = card.Image

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        'メッセージボックスを表示する 
        Dim result As DialogResult = MessageBox.Show("カードを削除しますか？",
                                                     "削除",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Exclamation,
                                                     MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            Using connection = New SQLiteConnection(ConnectString)
                connection.Open()

                Using command = New SQLiteCommand(connection)
                    command.CommandText = $"
DELETE
FROM card_stock
WHERE id = {Card.Id}
;"
                    command.ExecuteNonQuery()

                End Using
            End Using
            Me.Close()
        End If
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim result As DialogResult = MessageBox.Show("カードを編集しますか？",
                                                     "編集",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Exclamation,
                                                     MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            Using connection = New SQLiteConnection(ConnectString)
                connection.Open()

                Using command = New SQLiteCommand(connection)

                    command.CommandText = $"
UPDATE card_stock
SET
  name = @name
, rarity = @rarity
, status = @status
, price = @price
, kind = @kind
, image = @image
WHERE id = {Card.Id}
;"

                    command.Parameters.Add(New SQLiteParameter("@name", CardNameTextBox.Text))
                    command.Parameters.Add(New SQLiteParameter("@rarity", CardRarityComboBox.Text))
                    command.Parameters.Add(New SQLiteParameter("@status", CardStatusComboBox.Text))
                    command.Parameters.Add(New SQLiteParameter("@price", PriceTextBox.Text))
                    command.Parameters.Add(New SQLiteParameter("@kind", CardKindComboBox.Text))
                    command.Parameters.Add(New SQLiteParameter("@image", ResultForm.ConvertImageToByte(CardPictureBox.Image)))

                    command.ExecuteNonQuery()

                End Using
            End Using
            Me.Close()
        End If
    End Sub

End Class