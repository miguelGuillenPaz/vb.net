Namespace BE
    Public Class ClienteBE
        Private _idCliente As String
        Private _razonSocial As String
        Private _ruc As String
        Private _direccion As String

        Public Property idCliente As String
            Get
                Return _idCliente
            End Get
            Set(value As String)
                _idCliente = value
            End Set
        End Property

        Public Property razonSocial As String
            Get
                Return _razonSocial
            End Get
            Set(value As String)
                _razonSocial = value
            End Set
        End Property

        Public Property ruc As String
            Get
                Return _ruc
            End Get
            Set(value As String)
                _ruc = value
            End Set
        End Property

        Public Property direccion As String
            Get
                Return _direccion
            End Get
            Set(value As String)
                _direccion = value
            End Set
        End Property





    End Class
End Namespace