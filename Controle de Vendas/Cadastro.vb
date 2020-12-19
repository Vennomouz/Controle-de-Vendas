Public Class Cadastro
    Dim metodos As New Metodos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = nome.Text
        Dim user As String = usuario.Text
        Dim pass As String = senha.Text
        Dim pass2 As String = confirmarSenha.Text

        If pass = pass2 Then
            metodos.CadastrarUsuario(name, user, pass)
            Login.Show()
            Me.Close()
        Else
            MessageBox.Show("As senhas não correspondem!")
        End If

    End Sub
End Class