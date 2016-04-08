Imports EmpresaBE.BE
Imports EmpresaDL.DL
Imports System.Transactions

Namespace BL

    Public Class ClienteBL
        Public Function insertarCliente(cliente As ClienteBE) As Boolean
            Dim retorno As Boolean = False

            Try
                Using tran As New TransactionScope
                    Dim iCliente As ICliente
                    iCliente = New ClienteDL

                    retorno = iCliente.insertarCliente(cliente)

                    tran.Complete()
                End Using

                Return retorno
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function listarCliente(cliente As ClienteBE) As List(Of ClienteBE)
            Dim retorno As List(Of ClienteBE) = Nothing

            Try


                Using tran As New TransactionScope
                    Dim clsCliente As ICliente

                    clsCliente = New ClienteDL

                    retorno = clsCliente.listarCliente(cliente)

                    tran.Complete()

                End Using
            Catch ex As Exception
                Throw
            End Try
            Return retorno
        End Function

        Public Function actualizarCliente(clienteActualizar As ClienteBE) As ClienteBE
            Dim retorno As ClienteBE

            Try
                Using ts As New TransactionScope
                    Dim iCliente As ICliente

                    iCliente = New ClienteDL

                    retorno = iCliente.actualizarCliente(clienteActualizar)
                    ts.Complete()

                End Using
                Return retorno
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function devuelveCliente(id As Integer) As ClienteBE
            Dim retorno As ClienteBE

            Try
                Dim iCliente As ICliente

                iCliente = New ClienteDL

                retorno = iCliente.devuelveCliente(id)
            Catch ex As Exception
                Throw
            End Try
            Return retorno
        End Function

        Public Function eliminarCliente(id As Integer) As Boolean
            Dim retorno As Boolean = False

            Try
                Dim iCliente As ICliente
                iCliente = New ClienteDL

                retorno = iCliente.eliminarCliente(id)

                Return retorno
            Catch ex As Exception
                Throw
            End Try
        End Function
    End Class

End Namespace