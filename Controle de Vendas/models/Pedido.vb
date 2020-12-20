Public Class Pedido
    Public idCliente As Integer
    Public nomeCliente As String
    Public telCliente As Int64
    Public idProduto As Integer
    Public nomeProduto As String
    Public marcaProduto As String
    Public tipoProduto As String

    Public Sub New(ByVal idCliente As Integer, ByVal nomecliente As String, ByVal telCliente As Int64, ByVal idProduto As Integer, ByVal nomeProduto As String, ByVal marcaProduto As String, ByVal tipoProduto As String)
        Me.idCliente = idCliente
        Me.nomeCliente = nomecliente
        Me.telCliente = telCliente
        Me.idProduto = idProduto
        Me.nomeProduto = nomeProduto
        Me.marcaProduto = marcaProduto
        Me.tipoProduto = tipoProduto
    End Sub
End Class
