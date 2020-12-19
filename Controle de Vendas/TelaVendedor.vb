Public Class TelaVendedor
    Public Sub New(ByRef user As String, ByRef pass As String)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        Label1.Text = user
        Label3.Text = pass

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

End Class