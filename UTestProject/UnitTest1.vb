Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports EmpresaBL.BL
Imports EmpresaBE.BE

<TestClass()> Public Class UnitTest1

    <TestMethod()>
    Public Sub listarClente()
        Dim target As New ClienteBL  'TODO: Inicializar en un valor adecuado
        
        Dim expected As Boolean = True ' TODO: Inicializar en un valor adecuado
        Dim actual As List(Of ClienteBE)

        Dim clienteFiltro As New ClienteBE
        actual = target.listarCliente(clienteFiltro)
        Assert.AreEqual(expected, actual)
    End Sub

    <TestMethod()>
    Public Sub modificarCliente()
        Dim target As New ClienteBL

        Dim expected As Integer = 2
        Dim actual As ClienteBE = Nothing

        Dim clienteActualizar As New ClienteBE
        clienteActualizar.idCliente = 2
        clienteActualizar.razonSocial = "Mercado"

        actual = target.actualizarCliente(clienteActualizar)

        Assert.AreEqual(expected, actual.idCliente)
    End Sub
End Class