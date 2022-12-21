<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detail
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CardPictureBox = New System.Windows.Forms.PictureBox()
        Me.CardNameLabel = New System.Windows.Forms.Label()
        Me.CardRarityLabel = New System.Windows.Forms.Label()
        Me.CardKindLabel = New System.Windows.Forms.Label()
        Me.CardStatusLabel = New System.Windows.Forms.Label()
        Me.CartButton = New System.Windows.Forms.Button()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.CardRarityComboBox = New System.Windows.Forms.ComboBox()
        Me.CardKindComboBox = New System.Windows.Forms.ComboBox()
        Me.CardStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.CardNameTextBox = New System.Windows.Forms.TextBox()
        CType(Me.CardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CardPictureBox
        '
        Me.CardPictureBox.Location = New System.Drawing.Point(25, 30)
        Me.CardPictureBox.Name = "CardPictureBox"
        Me.CardPictureBox.Size = New System.Drawing.Size(203, 246)
        Me.CardPictureBox.TabIndex = 0
        Me.CardPictureBox.TabStop = False
        '
        'CardNameLabel
        '
        Me.CardNameLabel.AutoSize = True
        Me.CardNameLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CardNameLabel.Location = New System.Drawing.Point(250, 60)
        Me.CardNameLabel.Name = "CardNameLabel"
        Me.CardNameLabel.Size = New System.Drawing.Size(84, 27)
        Me.CardNameLabel.TabIndex = 1
        Me.CardNameLabel.Text = "カード名"
        '
        'CardRarityLabel
        '
        Me.CardRarityLabel.AutoSize = True
        Me.CardRarityLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CardRarityLabel.Location = New System.Drawing.Point(250, 115)
        Me.CardRarityLabel.Name = "CardRarityLabel"
        Me.CardRarityLabel.Size = New System.Drawing.Size(156, 27)
        Me.CardRarityLabel.TabIndex = 2
        Me.CardRarityLabel.Text = "カードレアリティ"
        '
        'CardKindLabel
        '
        Me.CardKindLabel.AutoSize = True
        Me.CardKindLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CardKindLabel.Location = New System.Drawing.Point(250, 170)
        Me.CardKindLabel.Name = "CardKindLabel"
        Me.CardKindLabel.Size = New System.Drawing.Size(102, 27)
        Me.CardKindLabel.TabIndex = 4
        Me.CardKindLabel.Text = "カード種類"
        '
        'CardStatusLabel
        '
        Me.CardStatusLabel.AutoSize = True
        Me.CardStatusLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CardStatusLabel.Location = New System.Drawing.Point(250, 225)
        Me.CardStatusLabel.Name = "CardStatusLabel"
        Me.CardStatusLabel.Size = New System.Drawing.Size(102, 27)
        Me.CardStatusLabel.TabIndex = 6
        Me.CardStatusLabel.Text = "カード状態"
        '
        'CartButton
        '
        Me.CartButton.Font = New System.Drawing.Font("メイリオ", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CartButton.Location = New System.Drawing.Point(244, 377)
        Me.CartButton.Name = "CartButton"
        Me.CartButton.Size = New System.Drawing.Size(206, 61)
        Me.CartButton.TabIndex = 7
        Me.CartButton.Text = "カートへ"
        Me.CartButton.UseVisualStyleBackColor = True
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Font = New System.Drawing.Font("メイリオ", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PriceLabel.Location = New System.Drawing.Point(97, 301)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(131, 54)
        Me.PriceLabel.TabIndex = 9
        Me.PriceLabel.Text = "金額："
        '
        'CardRarityComboBox
        '
        Me.CardRarityComboBox.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CardRarityComboBox.FormattingEnabled = True
        Me.CardRarityComboBox.Location = New System.Drawing.Point(420, 108)
        Me.CardRarityComboBox.Name = "CardRarityComboBox"
        Me.CardRarityComboBox.Size = New System.Drawing.Size(121, 35)
        Me.CardRarityComboBox.TabIndex = 11
        '
        'CardKindComboBox
        '
        Me.CardKindComboBox.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CardKindComboBox.FormattingEnabled = True
        Me.CardKindComboBox.Location = New System.Drawing.Point(420, 163)
        Me.CardKindComboBox.Name = "CardKindComboBox"
        Me.CardKindComboBox.Size = New System.Drawing.Size(121, 35)
        Me.CardKindComboBox.TabIndex = 12
        '
        'CardStatusComboBox
        '
        Me.CardStatusComboBox.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CardStatusComboBox.FormattingEnabled = True
        Me.CardStatusComboBox.Location = New System.Drawing.Point(420, 218)
        Me.CardStatusComboBox.Name = "CardStatusComboBox"
        Me.CardStatusComboBox.Size = New System.Drawing.Size(121, 35)
        Me.CardStatusComboBox.TabIndex = 13
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Font = New System.Drawing.Font("メイリオ", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PriceTextBox.Location = New System.Drawing.Point(244, 298)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(206, 61)
        Me.PriceTextBox.TabIndex = 14
        '
        'CardNameTextBox
        '
        Me.CardNameTextBox.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CardNameTextBox.Location = New System.Drawing.Point(420, 53)
        Me.CardNameTextBox.Name = "CardNameTextBox"
        Me.CardNameTextBox.Size = New System.Drawing.Size(237, 34)
        Me.CardNameTextBox.TabIndex = 15
        '
        'Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 450)
        Me.Controls.Add(Me.CardNameTextBox)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.CardStatusComboBox)
        Me.Controls.Add(Me.CardKindComboBox)
        Me.Controls.Add(Me.CardRarityComboBox)
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.CartButton)
        Me.Controls.Add(Me.CardStatusLabel)
        Me.Controls.Add(Me.CardKindLabel)
        Me.Controls.Add(Me.CardRarityLabel)
        Me.Controls.Add(Me.CardNameLabel)
        Me.Controls.Add(Me.CardPictureBox)
        Me.Name = "Detail"
        Me.Text = "カード詳細"
        CType(Me.CardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CardPictureBox As PictureBox
    Friend WithEvents CardNameLabel As Label
    Friend WithEvents CardRarityLabel As Label
    Friend WithEvents CardKindLabel As Label
    Friend WithEvents CardStatusLabel As Label
    Friend WithEvents CartButton As Button
    Friend WithEvents PriceLabel As Label
    Friend WithEvents CardRarityComboBox As ComboBox
    Friend WithEvents CardKindComboBox As ComboBox
    Friend WithEvents CardStatusComboBox As ComboBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents CardNameTextBox As TextBox
End Class
