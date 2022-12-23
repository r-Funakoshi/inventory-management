Option Strict On

Public Class Detail
    Sub New(card As CardStock)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        CardNameTextBox.Text = card.Name
        CardRarityComboBox.Text = card.Rarity
        CardKindComboBox.Text = card.Kind
        CardStatusComboBox.Text = card.Status
        PriceTextBox.Text = card.Price.ToString("c")
        CardPictureBox.Image = card.Image

    End Sub
End Class