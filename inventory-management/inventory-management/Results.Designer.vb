<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResultForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SortComboBox = New System.Windows.Forms.ComboBox()
        Me.ResultListView = New System.Windows.Forms.ListView()
        Me.ResultImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'SortComboBox
        '
        Me.SortComboBox.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SortComboBox.FormattingEnabled = True
        Me.SortComboBox.Location = New System.Drawing.Point(875, 12)
        Me.SortComboBox.Name = "SortComboBox"
        Me.SortComboBox.Size = New System.Drawing.Size(115, 35)
        Me.SortComboBox.TabIndex = 0
        '
        'ResultListView
        '
        Me.ResultListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ResultListView.HideSelection = False
        Me.ResultListView.HoverSelection = True
        Me.ResultListView.Location = New System.Drawing.Point(12, 56)
        Me.ResultListView.Name = "ResultListView"
        Me.ResultListView.Size = New System.Drawing.Size(978, 410)
        Me.ResultListView.TabIndex = 2
        Me.ResultListView.UseCompatibleStateImageBehavior = False
        '
        'ResultImageList
        '
        Me.ResultImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ResultImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.ResultImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'ResultForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 478)
        Me.Controls.Add(Me.ResultListView)
        Me.Controls.Add(Me.SortComboBox)
        Me.Name = "ResultForm"
        Me.ShowIcon = False
        Me.Text = "検索結果"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SortComboBox As ComboBox
    Friend WithEvents ResultListView As ListView
    Friend WithEvents ResultImageList As ImageList
End Class
