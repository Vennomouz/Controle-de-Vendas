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

    Public Sub CadastrarCliente(ByVal name As String, ByVal tel As String)
        Dim sql As String = "INSERT INTO CLIENTE (Nome, Tel) VALUES (@name, @tel)"
        Dim objCmd As New MySqlCommand(sql, connect)
        objCmd.Parameters.AddWithValue("@name", name)
        objCmd.Parameters.AddWithValue("@tel", tel)

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

    Public Sub CadastrarProduto(ByVal name As String, ByVal marca As String, ByVal tipo As String)
        Dim sql As String = "INSERT INTO PRODUTOS (Nome, Marca, Tipo) VALUES (@name, @marca, @tipo)"
        Dim objCmd As New MySqlCommand(sql, connect)
        objCmd.Parameters.AddWithValue("@name", name)
        objCmd.Parameters.AddWithValue("@marca", marca)
        objCmd.Parameters.AddWithValue("@tipo", tipo)

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

    Public Function Logar(ByVal user As String, ByVal pass As String)
        Dim sql As String = "SELECT * FROM USUARIO WHERE usuario = @user AND senha = @pass"
        Dim objCmd As New MySqlCommand(sql, connect)
        objCmd.Parameters.AddWithValue("@User", user)
        objCmd.Parameters.AddWithValue("@Pass", pass)
        Dim reader As MySqlDataReader
        Dim usuario As New Usuario("", "", "")

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

    Public Sub CarregaGrid(ByRef grid As DataGridView, ByRef sql As String)
        Cursor.Current = Cursors.AppStarting
        'Dim sql As String = "SELECT * FROM estagio." & tabela & ""

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

End Class
