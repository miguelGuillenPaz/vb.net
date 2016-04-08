Imports EmpresaBE.BE
Imports EmpresaBL.BL

Public Class frmGestionCliente
    Dim clsClienteBL As New ClienteBL
    Dim accion As String = "g"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If accion = "g" Then
            Dim nuevoCliente As New ClienteBE
            Dim respuesta As Boolean

            nuevoCliente.idCliente = txtId.Text
            nuevoCliente.razonSocial = txtRazonSocial.Text
            nuevoCliente.direccion = txtDireccion.Text
            nuevoCliente.ruc = txtRuc.Text

            respuesta = clsClienteBL.insertarCliente(nuevoCliente)

            If respuesta = True Then
                MsgBox("Registro exitoso")
            End If
        ElseIf accion = "m" Then
            Dim clienteModificar As New ClienteBE
            Dim clienteModificado As ClienteBE

            clienteModificar.idCliente = txtId.Text
            clienteModificar.razonSocial = txtRazonSocial.Text
            clienteModificar.ruc = txtRuc.Text
            clienteModificar.direccion = txtDireccion.Text

            clienteModificado = clsClienteBL.actualizarCliente(clienteModificar)

            If Not clienteModificado Is Nothing Then
                MsgBox("Cliente Modificado")
            End If
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frmBusqueda As New frmBusqueda

        frmBusqueda.ShowDialog()
        Dim clienteSeleccionado As ClienteBE = frmBusqueda.cliente

        If Not frmBusqueda.cliente Is Nothing Then
            txtId.Text = clienteSeleccionado.idCliente
            txtRazonSocial.Text = clienteSeleccionado.razonSocial
            txtRuc.Text = clienteSeleccionado.ruc
            txtDireccion.Text = clienteSeleccionado.direccion
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        accion = "m"
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        clsClienteBL.eliminarCliente(txtId.Text)

        MsgBox("Cliente eliminado de manera exitosa")
    End Sub
End Class