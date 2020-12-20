Public Class TelaVendedor
    Dim metodos As New Metodos
    Dim cli As New Cliente("", 0)
    Dim prod As New Produto("", "", "")
    Dim pedido As New Pedido(0, "", 0, 0, "", "", "")
    Public Sub New(ByRef name As String, ByRef user As String, ByRef pass As String)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        metodos.CarregaGrid(gridClientes, "SELECT * FROM CLIENTE")
        metodos.CarregaGrid(gridProdutos, "SELECT * FROM PRODUTOS")
        metodos.CarregaGrid(gridPedidos, "SELECT * FROM PEDIDOS")

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub gravarGridCli_Click(sender As Object, e As EventArgs) Handles gravarGridCli.Click
        cli.nome = nomeCliente.Text
        cli.tel = telCliente.Text
        metodos.CadastrarCliente(cli)
        metodos.CarregaGrid(gridClientes, "SELECT * FROM CLIENTE")
    End Sub

    Private Sub gravarGridProd_Click(sender As Object, e As EventArgs) Handles gravarGridProd.Click
        prod.nome = nomeProduto.Text
        prod.marca = marcaProduto.Text
        prod.tipo = tipoProduto.Text
        metodos.CadastrarProduto(prod)
        metodos.CarregaGrid(gridProdutos, "SELECT * FROM PRODUTOS")
    End Sub

    Private Sub idCli_TextChanged(sender As Object, e As EventArgs) Handles idCli.LostFocus
        metodos.CarregaDadosCli(nomeCli, telCli, idCli.Text)
    End Sub

    Private Sub idProd_TextChanged(sender As Object, e As EventArgs) Handles idProd.LostFocus
        metodos.CarregaDadosProd(nomeProd, marcaProd, tipoProd, idProd.Text)
    End Sub

    Private Sub gravarGridPed_Click(sender As Object, e As EventArgs) Handles gravarGridPed.Click
        pedido.idCliente = idCli.Text
        pedido.nomeCliente = nomeCli.Text
        pedido.telCliente = telCli.Text
        pedido.idProduto = idProd.Text
        pedido.nomeProduto = nomeProd.Text
        pedido.marcaProduto = marcaProd.Text
        pedido.tipoProduto = tipoProd.Text
        metodos.CadastrarPedido(pedido)
        metodos.CarregaGrid(gridPedidos, "SELECT * FROM PEDIDOS")
    End Sub
End Class