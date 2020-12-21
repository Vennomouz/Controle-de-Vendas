Public Class Login
    Dim metodos As New Metodos
    Dim user As String
    Dim pass As String
    Dim objUser As Usuario
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        user = usuario.Text
        pass = senha.Text
        objUser = metodos.Logar(user, pass)

        If objUser.nome <> "" Then
            Dim tela As TelaVendedor = New TelaVendedor(objUser)
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
