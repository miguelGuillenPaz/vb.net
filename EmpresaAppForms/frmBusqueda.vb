Imports EmpresaBL.BL
Imports EmpresaBE.BE

Public Class frmBusqueda
    Dim clsCliente As New ClienteBL
    Dim listaCliente As New List(Of ClienteBE)
    Dim _cliente As ClienteBE


    Public Property cliente As ClienteBE
        Get
            Return _cliente
        End Get
        Set(value As ClienteBE)
            _cliente = value
        End Set
    End Property


    Private Sub frmBusqueda_Load(sender As Object, e As EventArgs) Handles Me.Load


        Dim filtroCliente As New ClienteBE
        listaCliente = clsCliente.listarCliente(filtroCliente)

        dgvListaCliente.DataSource = listaCliente
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filtroBusquedaCliente As New ClienteBE

        filtroBusquedaCliente.idCliente = IIf(txtId.Text.Trim = "", Nothing, txtId.Text)
        filtroBusquedaCliente.razonSocial = IIf(txtRazonSocial.Text.Trim = "", Nothing, txtRazonSocial.Text)
        filtroBusquedaCliente.ruc = IIf(txtRuc.Text.Trim = "", Nothing, txtRuc.Text)
        filtroBusquedaCliente.direccion = IIf(txtDireccion.Text.Trim = "", Nothing, txtRuc.Text)

        listaCliente = clsCliente.listarCliente(filtroBusquedaCliente)

        dgvListaCliente.DataSource = listaCliente
    End Sub

    Private Sub dgvListaCliente_DoubleClick(sender As Object, e As EventArgs) Handles dgvListaCliente.DoubleClick
        Dim id As Integer = dgvListaCliente.Rows(dgvListaCliente.CurrentRow.Index).Cells("idCliente").Value

        Dim clienteSeleccionado As ClienteBE

        clienteSeleccionado = clsCliente.devuelveCliente(id)

        _cliente = clienteSeleccionado

        Me.Close()
    End Sub
End Class