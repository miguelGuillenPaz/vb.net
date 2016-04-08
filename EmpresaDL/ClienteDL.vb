Imports System.Data.Sql
Imports System.Data.SqlClient
Imports EmpresaBE.BE



Namespace DL

    Public Class ClienteDL
        Implements ICliente

        Public Function actualizarCliente(cliente As ClienteBE) As ClienteBE Implements ICliente.actualizarCliente
            Dim retorno As ClienteBE = Nothing

            Dim conexion As New ConexionDL

            Try

                Using con As New SqlConnection(conexion.cnx)
                    Using cmd As SqlCommand = con.CreateCommand
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.CommandText = "USP_ACTUALIZAR_CLIENTE"

                        cmd.Parameters.Add("@idCliente", SqlDbType.Int).Value = IIf(IsNothing(cliente.idCliente) = True, System.DBNull.Value, cliente.idCliente)
                        cmd.Parameters.Add("@ruc", SqlDbType.VarChar).Value = IIf(IsNothing(cliente.ruc) = True, System.DBNull.Value, cliente.ruc)
                        cmd.Parameters.Add("@razonSocial", SqlDbType.VarChar).Value = IIf(IsNothing(cliente.razonSocial) = True, System.DBNull.Value, cliente.razonSocial)
                        cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = IIf(IsNothing(cliente.direccion) = True, System.DBNull.Value, cliente.direccion)

                        con.Open()

                        cmd.ExecuteScalar()

                        retorno = devuelveCliente(cliente.idCliente)
                    End Using
                End Using

                Return retorno
            Catch ex As Exception
                Throw
            End Try

        End Function

        Public Function devuelveCliente(id As Integer) As ClienteBE Implements ICliente.devuelveCliente
            Dim retorno As ClienteBE = Nothing
            Dim conexion As New ConexionDL

            Try

                Using con As New SqlConnection(conexion.cnx)
                    Using cmd As SqlCommand = con.CreateCommand
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = "select idCliente, razonsocial, ruc, direccion from tb_cliente where idCliente = @idCliente"

                        cmd.Parameters.Add("@idCliente", SqlDbType.Int).Value = id

                        con.Open()
                        Dim sqlDr As SqlDataReader = cmd.ExecuteReader

                        While sqlDr.Read
                            Dim objCliente As New ClienteBE

                            objCliente.idCliente = sqlDr.Item("idCliente")
                            objCliente.ruc = sqlDr.Item("ruc")
                            objCliente.razonSocial = sqlDr.Item("razonsocial")
                            objCliente.direccion = sqlDr.Item("direccion")

                            retorno = objCliente
                        End While
                    End Using
                End Using

                Return retorno

            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function eliminarCliente(id As Integer) As Boolean Implements ICliente.eliminarCliente
            Dim retorno As Boolean = False
            Dim conexion As New ConexionDL

            Try

                Using con As New SqlConnection(conexion.cnx)
                    Using cmd As SqlCommand = con.CreateCommand
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = "delete from tb_cliente where idCliente =@idCliente"

                        cmd.Parameters.Add("@idCliente", SqlDbType.Int).Value = id

                        con.Open()
                        cmd.ExecuteScalar()
                        retorno = True
                    End Using
                End Using

                Return retorno

            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function insertarCliente(cliente As ClienteBE) As Boolean Implements ICliente.insertarCliente
            Dim retorno As Boolean = False

            'Cadena de conexión
            Dim conexion As New ConexionDL
            Dim cnx As String = conexion.cnx

            Try
                'Conexión DAO
                Using con As New SqlConnection(cnx)
                    Using cmd As SqlCommand = con.CreateCommand
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.CommandText = "USP_INSERTAR_CLIENTE"

                        cmd.Parameters.Add("@razonSocial", SqlDbType.VarChar).Value = cliente.razonSocial
                        cmd.Parameters.Add("@ruc", SqlDbType.VarChar).Value = cliente.ruc
                        cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = cliente.direccion

                        con.Open()
                        cmd.ExecuteScalar()
                        retorno = True

                    End Using
                End Using
                Return retorno
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function listarCliente(clienteFiltro As ClienteBE) As List(Of ClienteBE) Implements ICliente.listarCliente
            Dim retorno As New List(Of ClienteBE)

            Dim conexion As New ConexionDL
            Dim strConn As String = conexion.cnx

            Try
                Using cnx As New SqlConnection(strConn)
                    Using cmd As SqlCommand = cnx.CreateCommand
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.CommandText = "USP_LISTAR_CLIENTE"

                        cmd.Parameters.Add("@idCliente", SqlDbType.VarChar).Value = IIf(IsNothing(clienteFiltro.idCliente), System.DBNull.Value, clienteFiltro.idCliente)
                        cmd.Parameters.Add("@razonSocial", SqlDbType.VarChar).Value = IIf(IsNothing(clienteFiltro.razonSocial), System.DBNull.Value, clienteFiltro.razonSocial)
                        cmd.Parameters.Add("@ruc", SqlDbType.VarChar).Value = IIf(IsNothing(clienteFiltro.ruc), System.DBNull.Value, clienteFiltro.ruc)

                        cnx.Open()

                        Dim dr As SqlDataReader = Nothing
                        dr = cmd.ExecuteReader

                        While dr.Read
                            Dim cliente As New ClienteBE
                            cliente.idCliente = dr.Item("idCliente")
                            cliente.razonSocial = dr.Item("razonSocial")
                            cliente.ruc = dr.Item("ruc")
                            cliente.direccion = dr.Item("direccion")

                            retorno.Add(cliente)
                        End While
                        dr.Close()


                    End Using
                End Using
                Return retorno
            Catch ex As Exception
                Throw
            End Try
        End Function
    End Class
End Namespace