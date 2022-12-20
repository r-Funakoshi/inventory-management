Option Strict On

Public Class CardStock
    Public Property Name() As String
    Public Property Status() As String
    Public Property Price() As Integer
    Public Property Stock() As Integer
    Public Property Image() As Image

End Class

Public Enum PokeRarity
    UltraRare
    SuperRare
    Uncommon
    Common
End Enum

Public Enum PokeKind
    モンスター
    トレーナー
    エネルギー
End Enum