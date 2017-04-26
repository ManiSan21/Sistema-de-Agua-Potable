<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompraMaterial
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
        Me.mskIdOrden = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mskFactura = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbProveedores = New System.Windows.Forms.GroupBox()
        Me.mskTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mskDomicilio = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mskIdProveedor = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbMateriales = New System.Windows.Forms.GroupBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.txtCostoAnt = New System.Windows.Forms.TextBox()
        Me.txtUFC = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.mskCantidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.mskUnidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.mskMinimo = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.mskMaximo = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.mskExistencias = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mskIdMaterial = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbMaterial = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvCompraMaterial = New System.Windows.Forms.DataGridView()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.clmIdMat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbProveedores.SuspendLayout()
        Me.gbMateriales.SuspendLayout()
        CType(Me.dgvCompraMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mskIdOrden
        '
        Me.mskIdOrden.Enabled = False
        Me.mskIdOrden.Location = New System.Drawing.Point(842, 17)
        Me.mskIdOrden.Mask = "0000000000"
        Me.mskIdOrden.Name = "mskIdOrden"
        Me.mskIdOrden.Size = New System.Drawing.Size(80, 20)
        Me.mskIdOrden.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(772, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Orden"
        '
        'mskFactura
        '
        Me.mskFactura.Enabled = False
        Me.mskFactura.Location = New System.Drawing.Point(842, 56)
        Me.mskFactura.Mask = "0000000000"
        Me.mskFactura.Name = "mskFactura"
        Me.mskFactura.Size = New System.Drawing.Size(80, 20)
        Me.mskFactura.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(763, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Factura"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(742, 95)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 4
        Me.dtpFecha.Value = New Date(2017, 3, 28, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(672, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha"
        '
        'gbProveedores
        '
        Me.gbProveedores.Controls.Add(Me.mskTelefono)
        Me.gbProveedores.Controls.Add(Me.Label7)
        Me.gbProveedores.Controls.Add(Me.mskDomicilio)
        Me.gbProveedores.Controls.Add(Me.Label6)
        Me.gbProveedores.Controls.Add(Me.mskIdProveedor)
        Me.gbProveedores.Controls.Add(Me.Label5)
        Me.gbProveedores.Controls.Add(Me.cmbProveedor)
        Me.gbProveedores.Controls.Add(Me.Label4)
        Me.gbProveedores.Location = New System.Drawing.Point(12, 13)
        Me.gbProveedores.Name = "gbProveedores"
        Me.gbProveedores.Size = New System.Drawing.Size(620, 100)
        Me.gbProveedores.TabIndex = 6
        Me.gbProveedores.TabStop = False
        Me.gbProveedores.Text = "Proveedores:"
        '
        'mskTelefono
        '
        Me.mskTelefono.Enabled = False
        Me.mskTelefono.Location = New System.Drawing.Point(514, 62)
        Me.mskTelefono.Mask = "0000000000"
        Me.mskTelefono.Name = "mskTelefono"
        Me.mskTelefono.Size = New System.Drawing.Size(69, 20)
        Me.mskTelefono.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(415, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Teléfono"
        '
        'mskDomicilio
        '
        Me.mskDomicilio.Enabled = False
        Me.mskDomicilio.Location = New System.Drawing.Point(100, 62)
        Me.mskDomicilio.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
        Me.mskDomicilio.Name = "mskDomicilio"
        Me.mskDomicilio.Size = New System.Drawing.Size(309, 20)
        Me.mskDomicilio.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Domicilio"
        '
        'mskIdProveedor
        '
        Me.mskIdProveedor.Enabled = False
        Me.mskIdProveedor.Location = New System.Drawing.Point(404, 25)
        Me.mskIdProveedor.Mask = "0000000000"
        Me.mskIdProveedor.Name = "mskIdProveedor"
        Me.mskIdProveedor.Size = New System.Drawing.Size(69, 20)
        Me.mskIdProveedor.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(284, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "IdProveedor"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.Enabled = False
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(112, 22)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(121, 21)
        Me.cmbProveedor.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Proveedor"
        '
        'gbMateriales
        '
        Me.gbMateriales.Controls.Add(Me.txtCosto)
        Me.gbMateriales.Controls.Add(Me.txtCostoAnt)
        Me.gbMateriales.Controls.Add(Me.txtUFC)
        Me.gbMateriales.Controls.Add(Me.btnAceptar)
        Me.gbMateriales.Controls.Add(Me.Label17)
        Me.gbMateriales.Controls.Add(Me.mskCantidad)
        Me.gbMateriales.Controls.Add(Me.Label16)
        Me.gbMateriales.Controls.Add(Me.mskUnidad)
        Me.gbMateriales.Controls.Add(Me.Label15)
        Me.gbMateriales.Controls.Add(Me.mskMinimo)
        Me.gbMateriales.Controls.Add(Me.Label14)
        Me.gbMateriales.Controls.Add(Me.mskMaximo)
        Me.gbMateriales.Controls.Add(Me.Label13)
        Me.gbMateriales.Controls.Add(Me.mskExistencias)
        Me.gbMateriales.Controls.Add(Me.Label12)
        Me.gbMateriales.Controls.Add(Me.Label11)
        Me.gbMateriales.Controls.Add(Me.Label10)
        Me.gbMateriales.Controls.Add(Me.mskIdMaterial)
        Me.gbMateriales.Controls.Add(Me.Label9)
        Me.gbMateriales.Controls.Add(Me.cmbMaterial)
        Me.gbMateriales.Controls.Add(Me.Label8)
        Me.gbMateriales.Location = New System.Drawing.Point(12, 144)
        Me.gbMateriales.Name = "gbMateriales"
        Me.gbMateriales.Size = New System.Drawing.Size(892, 143)
        Me.gbMateriales.TabIndex = 7
        Me.gbMateriales.TabStop = False
        Me.gbMateriales.Text = "Materiales"
        '
        'txtCosto
        '
        Me.txtCosto.Enabled = False
        Me.txtCosto.Location = New System.Drawing.Point(280, 103)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(71, 20)
        Me.txtCosto.TabIndex = 23
        '
        'txtCostoAnt
        '
        Me.txtCostoAnt.Enabled = False
        Me.txtCostoAnt.Location = New System.Drawing.Point(518, 23)
        Me.txtCostoAnt.Name = "txtCostoAnt"
        Me.txtCostoAnt.Size = New System.Drawing.Size(65, 20)
        Me.txtCostoAnt.TabIndex = 22
        '
        'txtUFC
        '
        Me.txtUFC.Enabled = False
        Me.txtUFC.Location = New System.Drawing.Point(778, 23)
        Me.txtUFC.Name = "txtUFC"
        Me.txtUFC.Size = New System.Drawing.Size(100, 20)
        Me.txtUFC.TabIndex = 21
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Location = New System.Drawing.Point(471, 100)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 20
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(216, 103)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 24)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Costo"
        '
        'mskCantidad
        '
        Me.mskCantidad.Enabled = False
        Me.mskCantidad.Location = New System.Drawing.Point(112, 107)
        Me.mskCantidad.Mask = "0000000000"
        Me.mskCantidad.Name = "mskCantidad"
        Me.mskCantidad.Size = New System.Drawing.Size(75, 20)
        Me.mskCantidad.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 103)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 24)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Cantidad"
        '
        'mskUnidad
        '
        Me.mskUnidad.Enabled = False
        Me.mskUnidad.Location = New System.Drawing.Point(642, 61)
        Me.mskUnidad.Mask = "AAAAAAAAAAAAAAAAAAAA"
        Me.mskUnidad.Name = "mskUnidad"
        Me.mskUnidad.Size = New System.Drawing.Size(130, 20)
        Me.mskUnidad.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(564, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 24)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Unidad"
        '
        'mskMinimo
        '
        Me.mskMinimo.Enabled = False
        Me.mskMinimo.Location = New System.Drawing.Point(471, 61)
        Me.mskMinimo.Mask = "0000000000"
        Me.mskMinimo.Name = "mskMinimo"
        Me.mskMinimo.Size = New System.Drawing.Size(75, 20)
        Me.mskMinimo.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(393, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 24)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Mínimo"
        '
        'mskMaximo
        '
        Me.mskMaximo.Enabled = False
        Me.mskMaximo.Location = New System.Drawing.Point(299, 61)
        Me.mskMaximo.Mask = "0000000000"
        Me.mskMaximo.Name = "mskMaximo"
        Me.mskMaximo.Size = New System.Drawing.Size(75, 20)
        Me.mskMaximo.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(216, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 24)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Máximo"
        '
        'mskExistencias
        '
        Me.mskExistencias.Enabled = False
        Me.mskExistencias.Location = New System.Drawing.Point(118, 61)
        Me.mskExistencias.Mask = "0000000000"
        Me.mskExistencias.Name = "mskExistencias"
        Me.mskExistencias.Size = New System.Drawing.Size(75, 20)
        Me.mskExistencias.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 24)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Existencias"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(590, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(182, 24)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "ÚltimaFechaCompra"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(393, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 24)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Costo anterior"
        '
        'mskIdMaterial
        '
        Me.mskIdMaterial.Enabled = False
        Me.mskIdMaterial.Location = New System.Drawing.Point(312, 22)
        Me.mskIdMaterial.Mask = "0000000000"
        Me.mskIdMaterial.Name = "mskIdMaterial"
        Me.mskIdMaterial.Size = New System.Drawing.Size(75, 20)
        Me.mskIdMaterial.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(216, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 24)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "IdMaterial"
        '
        'cmbMaterial
        '
        Me.cmbMaterial.Enabled = False
        Me.cmbMaterial.FormattingEnabled = True
        Me.cmbMaterial.Location = New System.Drawing.Point(89, 22)
        Me.cmbMaterial.Name = "cmbMaterial"
        Me.cmbMaterial.Size = New System.Drawing.Size(121, 21)
        Me.cmbMaterial.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Material"
        '
        'dgvCompraMaterial
        '
        Me.dgvCompraMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompraMaterial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdMat, Me.clmMaterial, Me.clmCantidad, Me.clmCosto, Me.clmImporte})
        Me.dgvCompraMaterial.Location = New System.Drawing.Point(23, 293)
        Me.dgvCompraMaterial.Name = "dgvCompraMaterial"
        Me.dgvCompraMaterial.ReadOnly = True
        Me.dgvCompraMaterial.Size = New System.Drawing.Size(549, 150)
        Me.dgvCompraMaterial.TabIndex = 8
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(400, 455)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 24)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Subtotal"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(400, 488)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 24)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "IVA"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(400, 526)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 24)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Total"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(23, 455)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 25
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Location = New System.Drawing.Point(170, 455)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabar.TabIndex = 26
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(311, 455)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 27
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Location = New System.Drawing.Point(497, 455)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(75, 20)
        Me.txtSubtotal.TabIndex = 28
        '
        'txtIVA
        '
        Me.txtIVA.Enabled = False
        Me.txtIVA.Location = New System.Drawing.Point(497, 491)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(75, 20)
        Me.txtIVA.TabIndex = 29
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(495, 526)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(77, 20)
        Me.txtTotal.TabIndex = 30
        '
        'clmIdMat
        '
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmIdMat.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmIdMat.HeaderText = "IdMaterial"
        Me.clmIdMat.Name = "clmIdMat"
        Me.clmIdMat.ReadOnly = True
        '
        'clmMaterial
        '
        Me.clmMaterial.HeaderText = "Material"
        Me.clmMaterial.Name = "clmMaterial"
        Me.clmMaterial.ReadOnly = True
        '
        'clmCantidad
        '
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        Me.clmCantidad.ReadOnly = True
        '
        'clmCosto
        '
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmCosto.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmCosto.HeaderText = "Costo"
        Me.clmCosto.Name = "clmCosto"
        Me.clmCosto.ReadOnly = True
        '
        'clmImporte
        '
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        '
        'frmCompraMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 555)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtIVA)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dgvCompraMaterial)
        Me.Controls.Add(Me.gbMateriales)
        Me.Controls.Add(Me.gbProveedores)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mskFactura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mskIdOrden)
        Me.Name = "frmCompraMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra de Material"
        Me.gbProveedores.ResumeLayout(False)
        Me.gbProveedores.PerformLayout()
        Me.gbMateriales.ResumeLayout(False)
        Me.gbMateriales.PerformLayout()
        CType(Me.dgvCompraMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mskIdOrden As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents mskFactura As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents gbProveedores As GroupBox
    Friend WithEvents mskDomicilio As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents mskIdProveedor As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mskTelefono As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents gbMateriales As GroupBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents mskCantidad As MaskedTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents mskUnidad As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents mskMinimo As MaskedTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents mskMaximo As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents mskExistencias As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents mskIdMaterial As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbMaterial As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvCompraMaterial As DataGridView
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtUFC As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents txtCostoAnt As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents clmIdMat As DataGridViewTextBoxColumn
    Friend WithEvents clmMaterial As DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As DataGridViewTextBoxColumn
    Friend WithEvents clmCosto As DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As DataGridViewTextBoxColumn
End Class
