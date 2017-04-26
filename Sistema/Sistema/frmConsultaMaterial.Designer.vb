<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaMaterial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mskIdOrdenConsulta = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mskIdProveedorConsulta = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskFacturaConsulta = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mskProveedorConsulta = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFechaConsulta = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvMaterialConsulta = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.clmIdMaterialConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMaterialConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidadConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCostoConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImporteConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvMaterialConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IdOrden"
        '
        'mskIdOrdenConsulta
        '
        Me.mskIdOrdenConsulta.Location = New System.Drawing.Point(98, 13)
        Me.mskIdOrdenConsulta.Mask = "0000000000"
        Me.mskIdOrdenConsulta.Name = "mskIdOrdenConsulta"
        Me.mskIdOrdenConsulta.Size = New System.Drawing.Size(71, 20)
        Me.mskIdOrdenConsulta.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "IdProveedor"
        '
        'mskIdProveedorConsulta
        '
        Me.mskIdProveedorConsulta.Enabled = False
        Me.mskIdProveedorConsulta.Location = New System.Drawing.Point(137, 82)
        Me.mskIdProveedorConsulta.Mask = "0000000000"
        Me.mskIdProveedorConsulta.Name = "mskIdProveedorConsulta"
        Me.mskIdProveedorConsulta.Size = New System.Drawing.Size(69, 20)
        Me.mskIdProveedorConsulta.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Factura"
        '
        'mskFacturaConsulta
        '
        Me.mskFacturaConsulta.Enabled = False
        Me.mskFacturaConsulta.Location = New System.Drawing.Point(99, 130)
        Me.mskFacturaConsulta.Mask = "0000000000"
        Me.mskFacturaConsulta.Name = "mskFacturaConsulta"
        Me.mskFacturaConsulta.Size = New System.Drawing.Size(71, 20)
        Me.mskFacturaConsulta.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(224, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Proveedor"
        '
        'mskProveedorConsulta
        '
        Me.mskProveedorConsulta.Enabled = False
        Me.mskProveedorConsulta.Location = New System.Drawing.Point(328, 12)
        Me.mskProveedorConsulta.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
        Me.mskProveedorConsulta.Name = "mskProveedorConsulta"
        Me.mskProveedorConsulta.Size = New System.Drawing.Size(316, 20)
        Me.mskProveedorConsulta.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(253, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha"
        '
        'txtFechaConsulta
        '
        Me.txtFechaConsulta.Enabled = False
        Me.txtFechaConsulta.Location = New System.Drawing.Point(328, 82)
        Me.txtFechaConsulta.Name = "txtFechaConsulta"
        Me.txtFechaConsulta.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaConsulta.TabIndex = 9
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(328, 127)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dgvMaterialConsulta
        '
        Me.dgvMaterialConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterialConsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdMaterialConsulta, Me.clmMaterialConsulta, Me.clmCantidadConsulta, Me.clmCostoConsulta, Me.clmImporteConsulta})
        Me.dgvMaterialConsulta.Location = New System.Drawing.Point(12, 191)
        Me.dgvMaterialConsulta.Name = "dgvMaterialConsulta"
        Me.dgvMaterialConsulta.ReadOnly = True
        Me.dgvMaterialConsulta.Size = New System.Drawing.Size(547, 150)
        Me.dgvMaterialConsulta.TabIndex = 11
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(279, 367)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'clmIdMaterialConsulta
        '
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmIdMaterialConsulta.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmIdMaterialConsulta.HeaderText = "IdMaterial"
        Me.clmIdMaterialConsulta.Name = "clmIdMaterialConsulta"
        Me.clmIdMaterialConsulta.ReadOnly = True
        '
        'clmMaterialConsulta
        '
        Me.clmMaterialConsulta.HeaderText = "Material"
        Me.clmMaterialConsulta.Name = "clmMaterialConsulta"
        Me.clmMaterialConsulta.ReadOnly = True
        '
        'clmCantidadConsulta
        '
        Me.clmCantidadConsulta.HeaderText = "Cantidad"
        Me.clmCantidadConsulta.Name = "clmCantidadConsulta"
        Me.clmCantidadConsulta.ReadOnly = True
        '
        'clmCostoConsulta
        '
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmCostoConsulta.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmCostoConsulta.HeaderText = "Costo"
        Me.clmCostoConsulta.Name = "clmCostoConsulta"
        Me.clmCostoConsulta.ReadOnly = True
        '
        'clmImporteConsulta
        '
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmImporteConsulta.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmImporteConsulta.HeaderText = "Importe"
        Me.clmImporteConsulta.Name = "clmImporteConsulta"
        Me.clmImporteConsulta.ReadOnly = True
        '
        'frmConsultaMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 402)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvMaterialConsulta)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtFechaConsulta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mskProveedorConsulta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mskFacturaConsulta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mskIdProveedorConsulta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mskIdOrdenConsulta)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmConsultaMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta deMaterial"
        CType(Me.dgvMaterialConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents mskIdOrdenConsulta As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mskIdProveedorConsulta As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mskFacturaConsulta As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mskProveedorConsulta As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFechaConsulta As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvMaterialConsulta As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents clmIdMaterialConsulta As DataGridViewTextBoxColumn
    Friend WithEvents clmMaterialConsulta As DataGridViewTextBoxColumn
    Friend WithEvents clmCantidadConsulta As DataGridViewTextBoxColumn
    Friend WithEvents clmCostoConsulta As DataGridViewTextBoxColumn
    Friend WithEvents clmImporteConsulta As DataGridViewTextBoxColumn
End Class
