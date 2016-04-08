Imports System.Configuration

Public Class ConexionDL
    Private _cnx As String
    Private _provider As String

    Sub New()
        conexion()
        proveedor()
    End Sub


    Public Property cnx As String
        Get
            Return _cnx
        End Get
        Set(value As String)
            _cnx = value
        End Set
    End Property

    Public Property provider As String
        Get
            Return _provider
        End Get
        Set(value As String)
            _provider = value
        End Set
    End Property

    Public Sub conexion()
        _cnx = ConfigurationManager.ConnectionStrings("app").ConnectionString
    End Sub

    Private Sub proveedor()
        _provider = ConfigurationManager.ConnectionStrings("app").ProviderName

    End Sub
End Class
