Public Class Cadastro
    Dim metodos As New Metodos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As New Usuario("", "", "")
        user.nome = nome.Text
        user.usuario = usuario.Text
        user.senha = senha.Text
        Dim pass2 As String = confirmarSenha.Text

        If user.senha = pass2 Then
            metodos.CadastrarUsuario(user)
            Login.Show()
            Me.Close()
        Else
            MessageBox.Show("As senhas não correspondem!")
        End If

    End Sub
End Class