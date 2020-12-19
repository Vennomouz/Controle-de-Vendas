Imports MySql.Data.MySqlClient

Public Class Conexao

    Private host As String
    Private user As String
    Private pass As String
    Private banco As String
    Private conn As String

    Public Sub New()

        Me.host = "localhost"
        Me.user = "root"
        Me.pass = ""
        Me.banco = "loja"

        Me.conn = "server=" & host & "; user id=" & user & "; password=" & pass & "; database=" & banco & ";Convert Zero Datetime=True;Allow User Variables=True;Min Pool Size=0;Max Pool Size=30; Connection Timeout=99999;"

    End Sub
    Public Function Conectar()

        Dim connect As New MySqlConnection(Me.conn)
        Return connect

    End Function

End Class
