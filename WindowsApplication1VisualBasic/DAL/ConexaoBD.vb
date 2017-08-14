Imports System.Configuration

Public Class ConexaoBD
    Shared _connectionString As String
    Shared _providerName As String

    Shared Sub New()
        Try
            _connectionString = ConfigurationManager.ConnectionStrings("ConexaoBD").ConnectionString
            _providerName = ConfigurationManager.ConnectionStrings("ConexaoBD").ProviderName
        Catch ex As Exception
            Throw New Exception("Erro ao acessar a string de conexão")
        End Try
    End Sub
    Public Shared Function ConnectionString() As String
        Return _connectionString
    End Function
    Public Shared Function ProviderName() As String
        Return _providerName
    End Function
End Class
