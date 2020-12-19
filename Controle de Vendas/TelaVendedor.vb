Public Class TelaVendedor
    Dim metodos As New Metodos
    Public Sub New(ByRef name As String, ByRef user As String, ByRef pass As String)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        metodos.CarregaGrid(gridClientes, "SELECT * FROM CLIENTE")
        metodos.CarregaGrid(gridProdutos, "SELECT * FROM PRODUTOS")

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub gravarGridCli_Click(sender As Object, e As EventArgs) Handles gravarGridCli.Click
        metodos.CadastrarCliente(nomeCliente.Text, telCliente.Text)
        metodos.CarregaGrid(gridClientes, "SELECT * FROM CLIENTE")
    End Sub

    Private Sub gravarGridProd_Click(sender As Object, e As EventArgs) Handles gravarGridProd.Click
        metodos.CadastrarProduto(nomeProd.Text, marcaProd.Text, tipoProd.Text)
        metodos.CarregaGrid(gridProdutos, "SELECT * FROM PRODUTOS")
    End Sub
End Class