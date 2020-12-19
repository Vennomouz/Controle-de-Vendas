Imports MySql.Data.MySqlClient

Public Class Metodos

    Dim conexao As New Conexao
    Dim connect = conexao.Conectar()

    Public Sub CadastrarUsuario(ByVal name As String, ByVal user As String, ByVal pass As String)
        Dim sql As String = "INSERT INTO USUARIO (Nome, Usuario, Senha) VALUES (@name, @User, @Pass)"
        Dim objCmd As New MySqlCommand(sql, connect)
        objCmd.Parameters.AddWithValue("@name", name)
        objCmd.Parameters.AddWithValue("@User", user)
        objCmd.Parameters.AddWithValue("@Pass", pass)

        Try
            If System.Data.ConnectionState.Open Then
                connect.Close()
            End If
            connect.Open()
            objCmd.ExecuteNonQuery()

            MessageBox.Show("Dados gravados/Atualizados com sucesso")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            connect.Close()
        End Try

    End Sub

    Public Function Logar(ByVal user As String, ByVal pass As String)
        Dim sql As String = "SELECT * FROM USUARIO WHERE usuario = @user AND senha = @pass"
        Dim objCmd As New MySqlCommand(sql, connect)
        Dim reader As MySqlDataReader
        objCmd.Parameters.AddWithValue("@User", user)
        objCmd.Parameters.AddWithValue("@Pass", pass)
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

End Class
