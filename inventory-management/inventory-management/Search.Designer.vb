<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search
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
        Me.GameSelectLabel = New System.Windows.Forms.Label()
        Me.CardNameLabel = New System.Windows.Forms.Label()
        Me.CardNameTextBox = New System.Windows.Forms.TextBox()
        Me.GameSelectComboBox = New System.Windows.Forms.ComboBox()
        Me.RarityLabel = New System.Windows.Forms.Label()
        Me.UltraRareCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuperRareCheckBox = New System.Windows.Forms.CheckBox()
        Me.UncommonCheckBox = New System.Windows.Forms.CheckBox()
        Me.CommonCheckBox = New System.Windows.Forms.CheckBox()
        Me.KindLabel = New System.Windows.Forms.Label()
        Me.MonsterCheckBox = New System.Windows.Forms.CheckBox()
        Me.TrainerCheckBox = New System.Windows.Forms.CheckBox()
        Me.EnergyCheckBox = New System.Windows.Forms.CheckBox()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.BeautyProductsCheckBox = New System.Windows.Forms.CheckBox()
        Me.UsedCheckBox = New System.Windows.Forms.CheckBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CartButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GameSelectLabel
        '
        Me.GameSelectLabel.AutoSize = True
        Me.GameSelectLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GameSelectLabel.Location = New System.Drawing.Point(35, 30)
        Me.GameSelectLabel.Name = "GameSelectLabel"
        Me.GameSelectLabel.Size = New System.Drawing.Size(102, 27)
        Me.GameSelectLabel.TabIndex = 0
        Me.GameSelectLabel.Text = "ゲーム選択"
        '
        'CardNameLabel
        '
        Me.CardNameLabel.AutoSize = True
        Me.CardNameLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CardNameLabel.Location = New System.Drawing.Point(35, 85)
        Me.CardNameLabel.Name = "CardNameLabel"
        Me.CardNameLabel.Size = New System.Drawing.Size(84, 27)
        Me.CardNameLabel.TabIndex = 1
        Me.CardNameLabel.Text = "カード名"
        '
        'CardNameTextBox
        '
        Me.CardNameTextBox.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CardNameTextBox.Location = New System.Drawing.Point(155, 77)
        Me.CardNameTextBox.Name = "CardNameTextBox"
        Me.CardNameTextBox.Size = New System.Drawing.Size(331, 34)
        Me.CardNameTextBox.TabIndex = 2
        '
        'GameSelectComboBox
        '
        Me.GameSelectComboBox.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GameSelectComboBox.FormattingEnabled = True
        Me.GameSelectComboBox.Location = New System.Drawing.Point(155, 22)
        Me.GameSelectComboBox.Name = "GameSelectComboBox"
        Me.GameSelectComboBox.Size = New System.Drawing.Size(333, 35)
        Me.GameSelectComboBox.TabIndex = 3
        '
        'RarityLabel
        '
        Me.RarityLabel.AutoSize = True
        Me.RarityLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RarityLabel.Location = New System.Drawing.Point(35, 140)
        Me.RarityLabel.Name = "RarityLabel"
        Me.RarityLabel.Size = New System.Drawing.Size(102, 27)
        Me.RarityLabel.TabIndex = 4
        Me.RarityLabel.Text = "レアリティ"
        '
        'UltraRareCheckBox
        '
        Me.UltraRareCheckBox.AutoSize = True
        Me.UltraRareCheckBox.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.UltraRareCheckBox.Location = New System.Drawing.Point(155, 140)
        Me.UltraRareCheckBox.Name = "UltraRareCheckBox"
        Me.UltraRareCheckBox.Size = New System.Drawing.Size(63, 31)
        Me.UltraRareCheckBox.TabIndex = 5
        Me.UltraRareCheckBox.Text = "UR"
        Me.UltraRareCheckBox.UseVisualStyleBackColor = True
        '
        'SuperRareCheckBox
        '
        Me.SuperRareCheckBox.AutoSize = True
        Me.SuperRareCheckBox.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SuperRareCheckBox.Location = New System.Drawing.Point(300, 140)
        Me.SuperRareCheckBox.Name = "SuperRareCheckBox"
        Me.SuperRareCheckBox.Size = New System.Drawing.Size(61, 31)
        Me.SuperRareCheckBox.TabIndex = 6
        Me.SuperRareCheckBox.Text = "SR"
        Me.SuperRareCheckBox.UseVisualStyleBackColor = True
        '
        'UncommonCheckBox
        '
        Me.UncommonCheckBox.AutoSize = True
        Me.UncommonCheckBox.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.UncommonCheckBox.Location = New System.Drawing.Point(445, 140)
        Me.UncommonCheckBox.Name = "UncommonCheckBox"
        Me.UncommonCheckBox.Size = New System.Drawing.Size(63, 31)
        Me.UncommonCheckBox.TabIndex = 7
        Me.UncommonCheckBox.Text = "UC"
        Me.UncommonCheckBox.UseVisualStyleBackColor = True
        '
        'CommonCheckBox
        '
        Me.CommonCheckBox.AutoSize = True
        Me.CommonCheckBox.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CommonCheckBox.Location = New System.Drawing.Point(600, 140)
        Me.CommonCheckBox.Name = "CommonCheckBox"
        Me.CommonCheckBox.Size = New System.Drawing.Size(50, 31)
        Me.CommonCheckBox.TabIndex = 8
        Me.CommonCheckBox.Text = "C"
        Me.CommonCheckBox.UseVisualStyleBackColor = True
        '
        'KindLabel
        '
        Me.KindLabel.AutoSize = True
        Me.KindLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.KindLabel.Location = New System.Drawing.Point(35, 195)
        Me.KindLabel.Name = "KindLabel"
        Me.KindLabel.Size = New System.Drawing.Size(48, 27)
        Me.KindLabel.TabIndex = 9
        Me.KindLabel.Text = "種類"
        '
        'MonsterCheckBox
        '
        Me.MonsterCheckBox.AutoSize = True
        Me.MonsterCheckBox.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MonsterCheckBox.Location = New System.Drawing.Point(155, 195)
        Me.MonsterCheckBox.Name = "MonsterCheckBox"
        Me.MonsterCheckBox.Size = New System.Drawing.Size(128, 31)
        Me.MonsterCheckBox.TabIndex = 10
        Me.MonsterCheckBox.Text = "モンスター"
        Me.MonsterCheckBox.UseVisualStyleBackColor = True
        '
        'TrainerCheckBox
        '
        Me.TrainerCheckBox.AutoSize = True
        Me.TrainerCheckBox.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TrainerCheckBox.Location = New System.Drawing.Point(300, 195)
        Me.TrainerCheckBox.Name = "TrainerCheckBox"
        Me.TrainerCheckBox.Size = New System.Drawing.Size(128, 31)
        Me.TrainerCheckBox.TabIndex = 11
        Me.TrainerCheckBox.Text = "トレーナー"
        Me.TrainerCheckBox.UseVisualStyleBackColor = True
        '
        'EnergyCheckBox
        '
        Me.EnergyCheckBox.AutoSize = True
        Me.EnergyCheckBox.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.EnergyCheckBox.Location = New System.Drawing.Point(445, 195)
        Me.EnergyCheckBox.Name = "EnergyCheckBox"
        Me.EnergyCheckBox.Size = New System.Drawing.Size(128, 31)
        Me.EnergyCheckBox.TabIndex = 12
        Me.EnergyCheckBox.Text = "エネルギー"
        Me.EnergyCheckBox.UseVisualStyleBackColor = True
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.StatusLabel.Location = New System.Drawing.Point(35, 250)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(48, 27)
        Me.StatusLabel.TabIndex = 13
        Me.StatusLabel.Text = "状態"
        '
        'BeautyProductsCheckBox
        '
        Me.BeautyProductsCheckBox.AutoSize = True
        Me.BeautyProductsCheckBox.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BeautyProductsCheckBox.Location = New System.Drawing.Point(155, 250)
        Me.BeautyProductsCheckBox.Name = "BeautyProductsCheckBox"
        Me.BeautyProductsCheckBox.Size = New System.Drawing.Size(74, 31)
        Me.BeautyProductsCheckBox.TabIndex = 14
        Me.BeautyProductsCheckBox.Text = "美品"
        Me.BeautyProductsCheckBox.UseVisualStyleBackColor = True
        '
        'UsedCheckBox
        '
        Me.UsedCheckBox.AutoSize = True
        Me.UsedCheckBox.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.UsedCheckBox.Location = New System.Drawing.Point(300, 250)
        Me.UsedCheckBox.Name = "UsedCheckBox"
        Me.UsedCheckBox.Size = New System.Drawing.Size(74, 31)
        Me.UsedCheckBox.TabIndex = 15
        Me.UsedCheckBox.Text = "中古"
        Me.UsedCheckBox.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(285, 298)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(136, 65)
        Me.SearchButton.TabIndex = 16
        Me.SearchButton.Text = "検索"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(600, 310)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(93, 47)
        Me.ClearButton.TabIndex = 17
        Me.ClearButton.Text = "クリア"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CartButton
        '
        Me.CartButton.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CartButton.Location = New System.Drawing.Point(600, 22)
        Me.CartButton.Name = "CartButton"
        Me.CartButton.Size = New System.Drawing.Size(86, 39)
        Me.CartButton.TabIndex = 18
        Me.CartButton.Text = "カート"
        Me.CartButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.EditButton.Location = New System.Drawing.Point(500, 22)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(86, 36)
        Me.EditButton.TabIndex = 19
        Me.EditButton.Text = "編集"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 380)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.CartButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.UsedCheckBox)
        Me.Controls.Add(Me.BeautyProductsCheckBox)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.EnergyCheckBox)
        Me.Controls.Add(Me.TrainerCheckBox)
        Me.Controls.Add(Me.MonsterCheckBox)
        Me.Controls.Add(Me.KindLabel)
        Me.Controls.Add(Me.CommonCheckBox)
        Me.Controls.Add(Me.UncommonCheckBox)
        Me.Controls.Add(Me.SuperRareCheckBox)
        Me.Controls.Add(Me.UltraRareCheckBox)
        Me.Controls.Add(Me.RarityLabel)
        Me.Controls.Add(Me.GameSelectComboBox)
        Me.Controls.Add(Me.CardNameTextBox)
        Me.Controls.Add(Me.CardNameLabel)
        Me.Controls.Add(Me.GameSelectLabel)
        Me.Name = "Search"
        Me.Text = "カード検索"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GameSelectLabel As Label
    Friend WithEvents CardNameLabel As Label
    Friend WithEvents CardNameTextBox As TextBox
    Friend WithEvents GameSelectComboBox As ComboBox
    Friend WithEvents RarityLabel As Label
    Friend WithEvents UltraRareCheckBox As CheckBox
    Friend WithEvents SuperRareCheckBox As CheckBox
    Friend WithEvents UncommonCheckBox As CheckBox
    Friend WithEvents CommonCheckBox As CheckBox
    Friend WithEvents KindLabel As Label
    Friend WithEvents MonsterCheckBox As CheckBox
    Friend WithEvents TrainerCheckBox As CheckBox
    Friend WithEvents EnergyCheckBox As CheckBox
    Friend WithEvents StatusLabel As Label
    Friend WithEvents BeautyProductsCheckBox As CheckBox
    Friend WithEvents UsedCheckBox As CheckBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents CartButton As Button
    Friend WithEvents EditButton As Button
End Class
