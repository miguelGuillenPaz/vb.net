Imports EmpresaBE.BE

Namespace DL
    Public Interface ICliente
        Function insertarCliente(cliente As ClienteBE) As Boolean
        Function listarCliente(cliente As ClienteBE) As List(Of ClienteBE)
        Function actualizarCliente(cliente As ClienteBE) As ClienteBE
        Function eliminarCliente(id As Integer) As Boolean
        Function devuelveCliente(id As Integer) As ClienteBE
    End Interface
End Namespace