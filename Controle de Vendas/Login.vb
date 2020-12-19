Public Class Login
    Dim metodos As New Metodos
    Dim user As String
    Dim pass As String
    Dim bool As Boolean
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        user = usuario.Text
        pass = senha.Text
        bool = metodos.Logar(user, pass)
        If bool = True Then
            Dim tela As TelaVendedor = New TelaVendedor(user, pass)
            tela.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuário ou senha inválidos!")
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Cadastro.Show()
        Me.Hide()
    End Sub
End Class
