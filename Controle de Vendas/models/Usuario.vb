Public Class Usuario
    Public nome As String
    Public usuario As String
    Public senha As String

    Public Sub New(ByVal nome As String, ByVal usuario As String, ByVal senha As String)
        Me.nome = nome
        Me.usuario = usuario
        Me.senha = senha
    End Sub

End Class
