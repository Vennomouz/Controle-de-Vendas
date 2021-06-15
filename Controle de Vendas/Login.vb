Imports System.Drawing
Imports System.Drawing.Drawing2D
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

<<<<<<< HEAD
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim roundButtom As New Drawing2D.GraphicsPath
        'roundButtom.StartFigure()
        'roundButtom.AddArc(New Rectangle(0, 0, 167, 40), 360, 360)
        'roundButtom.CloseFigure()
        'btnEntrar.Region = New Region(roundButtom)
    End Sub
=======
    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover
        Label4.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold Or FontStyle.Underline)
        Label4.Size = New Size(149, 13)
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold)
        Label4.Size = New Size(149, 13)
    End Sub

>>>>>>> 613d87fb8dc6c5fe4190f886e185485b53a7e6d9
End Class
