<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusqueda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvListaCliente = New System.Windows.Forms.DataGridView()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblRUC = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        CType(Me.dgvListaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListaCliente
        '
        Me.dgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaCliente.Location = New System.Drawing.Point(48, 145)
        Me.dgvListaCliente.Name = "dgvListaCliente"
        Me.dgvListaCliente.Size = New System.Drawing.Size(384, 145)
        Me.dgvListaCliente.TabIndex = 0
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(45, 33)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(16, 13)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "Id"
        '
        'lblRUC
        '
        Me.lblRUC.AutoSize = True
        Me.lblRUC.Location = New System.Drawing.Point(45, 60)
        Me.lblRUC.Name = "lblRUC"
        Me.lblRUC.Size = New System.Drawing.Size(30, 13)
        Me.lblRUC.TabIndex = 2
        Me.lblRUC.Text = "RUC"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(45, 87)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 3
        Me.lblDireccion.Text = "Dirección"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(127, 25)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 4
        '
        'txtRuc
        '
        Me.txtRuc.Location = New System.Drawing.Point(127, 54)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(100, 20)
        Me.txtRuc.TabIndex = 5
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(127, 83)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(274, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(127, 114)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(100, 20)
        Me.txtRazonSocial.TabIndex = 9
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Location = New System.Drawing.Point(45, 118)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(70, 13)
        Me.lblRazonSocial.TabIndex = 8
        Me.lblRazonSocial.Text = "Razón Social"
        '
        'frmBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 319)
        Me.Controls.Add(Me.txtRazonSocial)
        Me.Controls.Add(Me.lblRazonSocial)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtRuc)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblRUC)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.dgvListaCliente)
        Me.Name = "frmBusqueda"
        Me.Text = "frmBusqueda"
        CType(Me.dgvListaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvListaCliente As DataGridView
    Friend WithEvents lblId As Label
    Friend WithEvents lblRUC As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtRuc As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents lblRazonSocial As Label
End Class
