Public Class Login
    Dim metodos As New Metodos
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        ' metodos.CadastrarUsuario()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        'Dim tela As Cadastro = New Cadastro
        'tela.Show()
        Cadastro.Show()
        Me.Hide()
    End Sub
End Class
