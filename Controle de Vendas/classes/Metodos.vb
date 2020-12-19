Imports MySql.Data.MySqlClient

Public Class Metodos

    Dim conexao As New Conexao
    Dim connect = conexao.Conectar()

    Public Sub CadastrarUsuario(ByVal user As String, ByVal pass As String)
        Dim sql As String = "INSERT INTO USUARIO (Usuario, Senha) VALUES (@User, @Pass)"
        Dim objCmd As New MySqlCommand(sql, connect)
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
End Class
