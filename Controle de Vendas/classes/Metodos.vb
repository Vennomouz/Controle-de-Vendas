Imports MySql.Data.MySqlClient

Public Class Metodos

    Dim conexao As New Conexao
    Dim connect = conexao.Conectar()

    Public Sub CadastrarUsuario(ByVal user As Usuario)
        Dim sql As String = "INSERT INTO USUARIO (Nome, Usuario, Senha) VALUES (@name, @User, @Pass)"
        Dim objCmd As New MySqlCommand(sql, connect)
        objCmd.Parameters.AddWithValue("@name", user.nome)
        objCmd.Parameters.AddWithValue("@User", user.usuario)
        objCmd.Parameters.AddWithValue("@Pass", user.senha)

        Try
            If System.Data.ConnectionState.Open Then
                connect.Close()
            End If
            connect.Open()
            objCmd.ExecuteNonQuery()

            MessageBox.Show("Usuário cadastrado com sucesso!")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            connect.Close()
        End Try

    End Sub

    Public Sub CadastrarCliente(ByVal cliente As Cliente)
        Dim sql As String = "INSERT INTO CLIENTE (Nome, Tel) VALUES (@name, @tel)"
        Dim objCmd As New MySqlCommand(sql, connect)
        objCmd.Parameters.AddWithValue("@name", cliente.nome)
        objCmd.Parameters.AddWithValue("@tel", cliente.tel)

        Try
            If System.Data.ConnectionState.Open Then
                connect.Close()
            End If
            connect.Open()
            objCmd.ExecuteNonQuery()

            MessageBox.Show("Cliente cadastrado com sucesso!")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            connect.Close()
        End Try

    End Sub

    Public Sub CadastrarProduto(ByVal produto As Produto)
        Dim sql As String = "INSERT INTO PRODUTOS (Nome, Marca, Tipo) VALUES (@name, @marca, @tipo)"
        Dim objCmd As New MySqlCommand(sql, connect)
        objCmd.Parameters.AddWithValue("@name", produto.nome)
        objCmd.Parameters.AddWithValue("@marca", produto.marca)
        objCmd.Parameters.AddWithValue("@tipo", produto.tipo)

        Try
            If System.Data.ConnectionState.Open Then
                connect.Close()
            End If
            connect.Open()
            objCmd.ExecuteNonQuery()

            MessageBox.Show("Produto cadastrado com sucesso!")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            connect.Close()
        End Try

    End Sub

    Public Sub CadastrarPedido(ByVal pedido As Pedido)
        Dim sql As String = "INSERT INTO PEDIDOS (idcliente, nomecliente, telcliente, idproduto, nomeproduto, marcaproduto, tipoproduto) VALUES (@idcliente, @nomecliente, @telcliente, @idproduto, @nomeproduto, @marcaproduto, @tipoproduto)"
        Dim objCmd As New MySqlCommand(sql, connect)
        objCmd.Parameters.AddWithValue("@idcliente", pedido.idCliente)
        objCmd.Parameters.AddWithValue("@nomecliente", pedido.nomeCliente)
        objCmd.Parameters.AddWithValue("@telcliente", pedido.telCliente)
        objCmd.Parameters.AddWithValue("@idproduto", pedido.idProduto)
        objCmd.Parameters.AddWithValue("@nomeproduto", pedido.nomeProduto)
        objCmd.Parameters.AddWithValue("@marcaproduto", pedido.marcaProduto)
        objCmd.Parameters.AddWithValue("@tipoproduto", pedido.tipoProduto)

        Try
            If System.Data.ConnectionState.Open Then
                connect.Close()
            End If
            connect.Open()
            objCmd.ExecuteNonQuery()

            MessageBox.Show("Pedido realizado com sucesso!")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            connect.Close()
        End Try

    End Sub

    Public Function Logar(ByVal user As String, ByVal pass As String)
        Dim sql As String = "SELECT * FROM USUARIO WHERE usuario = @user AND senha = @pass"
        Dim objCmd As New MySqlCommand(sql, connect)
        objCmd.Parameters.AddWithValue("@User", user)
        objCmd.Parameters.AddWithValue("@Pass", pass)
        Dim reader As MySqlDataReader
        Dim usuario As New Usuario()

        'Dim bool As Boolean

        Try
            If System.Data.ConnectionState.Open Then
                connect.Close()
            End If
            connect.Open()
            reader = objCmd.ExecuteReader()
            If reader.Read Then
                usuario = New Usuario(reader.GetString("nome"), reader.GetString("usuario"), reader.GetString("senha"))
            End If
            'bool = reader.HasRows

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            connect.Close()
        End Try

        'Return bool
        Return usuario

    End Function

    Public Sub CarregaGrid(ByRef grid As DataGridView, ByVal sql As String)
        Cursor.Current = Cursors.AppStarting

        Try

            If ConnectionState.Open Then
                connect.Close()
            End If

            connect.Open()

            Dim cmd As MySqlCommand = New MySqlCommand(sql, connect)
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable

            da.Fill(dt)

            grid.DataSource = dt

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            grid.AutoSizeRowsMode = DataGridViewAutoSizeColumnsMode.AllCells

            With grid
                .DefaultCellStyle.BackColor = Color.White
                .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                .Font = New Font(grid.Font, FontStyle.Bold)
            End With

            With grid.ColumnHeadersDefaultCellStyle
                .Font = New Font(grid.Font, FontStyle.Bold)

            End With

            grid.ClearSelection()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            connect.Close()
        End Try
    End Sub

    Public Sub CarregaDadosCli(ByRef campo1 As TextBox, ByRef campo2 As TextBox, ByVal idCli As String)
        Dim sql As String = "SELECT nome as nomecli, tel as telcli FROM CLIENTE WHERE id = @idCli"
        Dim objCmd As New MySqlCommand(sql, connect)
        objCmd.Parameters.AddWithValue("@idCli", idCli)

        Try
            If System.Data.ConnectionState.Open Then
                connect.Close()
            End If
            connect.Open()

            Dim reader As MySqlDataReader
            reader = objCmd.ExecuteReader()
            'Dim controle As Control

            If reader.Read Then
                'For Each controle In tela.controls
                '    If TypeOf controle Is TextBox Then
                '        controle.Text = reader.GetString(controle.Name)
                '    End If
                'Next
                campo1.Text = reader.GetString(campo1.Name)
                campo2.Text = reader.GetString(campo2.Name)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            connect.Close()
        End Try

    End Sub

    Public Sub CarregaDadosProd(ByRef campo1 As TextBox, ByRef campo2 As TextBox, ByRef campo3 As TextBox, ByVal idProd As String)
        Dim sql As String = "SELECT nome as nomeprod, marca as marcaprod, tipo as tipoprod FROM Produtos WHERE id = @idProd"
        Dim objCmd As New MySqlCommand(sql, connect)
        objCmd.Parameters.AddWithValue("@idProd", idProd)

        Try
            If System.Data.ConnectionState.Open Then
                connect.Close()
            End If
            connect.Open()

            Dim reader As MySqlDataReader
            reader = objCmd.ExecuteReader()
            'Dim controle As Control

            If reader.Read Then
                'For Each controle In tela.controls
                '    If TypeOf controle Is TextBox Then
                '        controle.Text = reader.GetString(controle.Name)
                '    End If
                'Next
                campo1.Text = reader.GetString(campo1.Name)
                campo2.Text = reader.GetString(campo2.Name)
                campo3.Text = reader.GetString(campo3.Name)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            connect.Close()
        End Try

    End Sub
End Class
