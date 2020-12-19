Public Class TelaVendedor
    Public Sub New(ByRef name As String, ByRef user As String, ByRef pass As String)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        Label1.Text = name
        Label3.Text = user

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

End Class