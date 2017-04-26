<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalidaMaterial
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mskConceptoSalida = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mskIdSalida = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mskIdEmpleado = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mskCelular = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mskDomicilio = New System.Windows.Forms.MaskedTextBox()
        Me.gbCalles = New System.Windows.Forms.GroupBox()
        Me.mskTotalCasas = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mskIdCalle = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbCalle = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbMateriales = New System.Windows.Forms.GroupBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.mskCantidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.mskUnidadMedida = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFechaMat = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.mskMinimo = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.mskMaximo = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.mskExistencias = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.mskIdMaterial = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbMaterial = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.dgvSalidaMat = New System.Windows.Forms.DataGridView()
        Me.clmIdMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbCalles.SuspendLayout()
        Me.gbMateriales.SuspendLayout()
        CType(Me.dgvSalidaMat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Concepto Salida:"
        '
        'mskConceptoSalida
        '
        Me.mskConceptoSalida.Enabled = False
        Me.mskConceptoSalida.Location = New System.Drawing.Point(461, 12)
        Me.mskConceptoSalida.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
        Me.mskConceptoSalida.Name = "mskConceptoSalida"
        Me.mskConceptoSalida.Size = New System.Drawing.Size(310, 20)
        Me.mskConceptoSalida.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "IdSalida:"
        '
        'mskIdSalida
        '
        Me.mskIdSalida.Enabled = False
        Me.mskIdSalida.Location = New System.Drawing.Point(99, 12)
        Me.mskIdSalida.Mask = "0000000000"
        Me.mskIdSalida.Name = "mskIdSalida"
        Me.mskIdSalida.Size = New System.Drawing.Size(69, 20)
        Me.mskIdSalida.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Empleado:"
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.Enabled = False
        Me.cmbEmpleado.FormattingEnabled = True
        Me.cmbEmpleado.Location = New System.Drawing.Point(124, 65)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(121, 21)
        Me.cmbEmpleado.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(308, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(383, 65)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "IdEmpleado:"
        '
        'mskIdEmpleado
        '
        Me.mskIdEmpleado.Enabled = False
        Me.mskIdEmpleado.Location = New System.Drawing.Point(135, 106)
        Me.mskIdEmpleado.Mask = "0000000000"
        Me.mskIdEmpleado.Name = "mskIdEmpleado"
        Me.mskIdEmpleado.Size = New System.Drawing.Size(69, 20)
        Me.mskIdEmpleado.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(225, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Celular:"
        '
        'mskCelular
        '
        Me.mskCelular.Enabled = False
        Me.mskCelular.Location = New System.Drawing.Point(305, 106)
        Me.mskCelular.Mask = "0000000000"
        Me.mskCelular.Name = "mskCelular"
        Me.mskCelular.Size = New System.Drawing.Size(69, 20)
        Me.mskCelular.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(400, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Domicilio:"
        '
        'mskDomicilio
        '
        Me.mskDomicilio.Enabled = False
        Me.mskDomicilio.Location = New System.Drawing.Point(498, 110)
        Me.mskDomicilio.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
        Me.mskDomicilio.Name = "mskDomicilio"
        Me.mskDomicilio.Size = New System.Drawing.Size(311, 20)
        Me.mskDomicilio.TabIndex = 13
        '
        'gbCalles
        '
        Me.gbCalles.Controls.Add(Me.mskTotalCasas)
        Me.gbCalles.Controls.Add(Me.Label10)
        Me.gbCalles.Controls.Add(Me.mskIdCalle)
        Me.gbCalles.Controls.Add(Me.Label9)
        Me.gbCalles.Controls.Add(Me.cmbCalle)
        Me.gbCalles.Controls.Add(Me.Label8)
        Me.gbCalles.Location = New System.Drawing.Point(19, 154)
        Me.gbCalles.Name = "gbCalles"
        Me.gbCalles.Size = New System.Drawing.Size(582, 53)
        Me.gbCalles.TabIndex = 14
        Me.gbCalles.TabStop = False
        Me.gbCalles.Text = "Calles:"
        '
        'mskTotalCasas
        '
        Me.mskTotalCasas.Enabled = False
        Me.mskTotalCasas.Location = New System.Drawing.Point(499, 16)
        Me.mskTotalCasas.Mask = "0000000000"
        Me.mskTotalCasas.Name = "mskTotalCasas"
        Me.mskTotalCasas.Size = New System.Drawing.Size(69, 20)
        Me.mskTotalCasas.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(381, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 24)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Total Casas:"
        '
        'mskIdCalle
        '
        Me.mskIdCalle.Enabled = False
        Me.mskIdCalle.Location = New System.Drawing.Point(284, 16)
        Me.mskIdCalle.Mask = "0000000000"
        Me.mskIdCalle.Name = "mskIdCalle"
        Me.mskIdCalle.Size = New System.Drawing.Size(69, 20)
        Me.mskIdCalle.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(206, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 24)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "IdCalle:"
        '
        'cmbCalle
        '
        Me.cmbCalle.Enabled = False
        Me.cmbCalle.FormattingEnabled = True
        Me.cmbCalle.Location = New System.Drawing.Point(64, 16)
        Me.cmbCalle.Name = "cmbCalle"
        Me.cmbCalle.Size = New System.Drawing.Size(121, 21)
        Me.cmbCalle.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 24)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Calle:"
        '
        'gbMateriales
        '
        Me.gbMateriales.Controls.Add(Me.txtCosto)
        Me.gbMateriales.Controls.Add(Me.btnAgregar)
        Me.gbMateriales.Controls.Add(Me.mskCantidad)
        Me.gbMateriales.Controls.Add(Me.Label19)
        Me.gbMateriales.Controls.Add(Me.mskUnidadMedida)
        Me.gbMateriales.Controls.Add(Me.Label18)
        Me.gbMateriales.Controls.Add(Me.txtFechaMat)
        Me.gbMateriales.Controls.Add(Me.Label17)
        Me.gbMateriales.Controls.Add(Me.mskMinimo)
        Me.gbMateriales.Controls.Add(Me.Label16)
        Me.gbMateriales.Controls.Add(Me.mskMaximo)
        Me.gbMateriales.Controls.Add(Me.Label15)
        Me.gbMateriales.Controls.Add(Me.Label14)
        Me.gbMateriales.Controls.Add(Me.mskExistencias)
        Me.gbMateriales.Controls.Add(Me.Label13)
        Me.gbMateriales.Controls.Add(Me.mskIdMaterial)
        Me.gbMateriales.Controls.Add(Me.Label12)
        Me.gbMateriales.Controls.Add(Me.Label11)
        Me.gbMateriales.Controls.Add(Me.cmbMaterial)
        Me.gbMateriales.Location = New System.Drawing.Point(19, 223)
        Me.gbMateriales.Name = "gbMateriales"
        Me.gbMateriales.Size = New System.Drawing.Size(790, 139)
        Me.gbMateriales.TabIndex = 15
        Me.gbMateriales.TabStop = False
        Me.gbMateriales.Text = "Materiales"
        '
        'txtCosto
        '
        Me.txtCosto.Enabled = False
        Me.txtCosto.Location = New System.Drawing.Point(76, 58)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(100, 20)
        Me.txtCosto.TabIndex = 28
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Location = New System.Drawing.Point(554, 91)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 27
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'mskCantidad
        '
        Me.mskCantidad.Enabled = False
        Me.mskCantidad.Location = New System.Drawing.Point(432, 95)
        Me.mskCantidad.Mask = "0000000000"
        Me.mskCantidad.Name = "mskCantidad"
        Me.mskCantidad.Size = New System.Drawing.Size(69, 20)
        Me.mskCantidad.TabIndex = 26
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(337, 91)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 24)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Cantidad:"
        '
        'mskUnidadMedida
        '
        Me.mskUnidadMedida.Enabled = False
        Me.mskUnidadMedida.Location = New System.Drawing.Point(183, 94)
        Me.mskUnidadMedida.Mask = "AAAAAAAAAAAAAAAAAAAA"
        Me.mskUnidadMedida.Name = "mskUnidadMedida"
        Me.mskUnidadMedida.Size = New System.Drawing.Size(128, 20)
        Me.mskUnidadMedida.TabIndex = 24
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(170, 24)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Unidad de medida:"
        '
        'txtFechaMat
        '
        Me.txtFechaMat.Enabled = False
        Me.txtFechaMat.Location = New System.Drawing.Point(625, 51)
        Me.txtFechaMat.Name = "txtFechaMat"
        Me.txtFechaMat.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaMat.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(550, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 24)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Fecha:"
        '
        'mskMinimo
        '
        Me.mskMinimo.Enabled = False
        Me.mskMinimo.Location = New System.Drawing.Point(459, 55)
        Me.mskMinimo.Mask = "0000000000"
        Me.mskMinimo.Name = "mskMinimo"
        Me.mskMinimo.Size = New System.Drawing.Size(69, 20)
        Me.mskMinimo.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(371, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 24)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Mínimo:"
        '
        'mskMaximo
        '
        Me.mskMaximo.Enabled = False
        Me.mskMaximo.Location = New System.Drawing.Point(272, 55)
        Me.mskMaximo.Mask = "0000000000"
        Me.mskMaximo.Name = "mskMaximo"
        Me.mskMaximo.Size = New System.Drawing.Size(69, 20)
        Me.mskMaximo.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(184, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 24)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Máximo:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 24)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Costo:"
        '
        'mskExistencias
        '
        Me.mskExistencias.Enabled = False
        Me.mskExistencias.Location = New System.Drawing.Point(554, 22)
        Me.mskExistencias.Mask = "0000000000"
        Me.mskExistencias.Name = "mskExistencias"
        Me.mskExistencias.Size = New System.Drawing.Size(69, 20)
        Me.mskExistencias.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(438, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 24)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Existencias:"
        '
        'mskIdMaterial
        '
        Me.mskIdMaterial.Enabled = False
        Me.mskIdMaterial.Location = New System.Drawing.Point(341, 19)
        Me.mskIdMaterial.Mask = "0000000000"
        Me.mskIdMaterial.Name = "mskIdMaterial"
        Me.mskIdMaterial.Size = New System.Drawing.Size(69, 20)
        Me.mskIdMaterial.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(240, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 24)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "IdMaterial:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 24)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Material:"
        '
        'cmbMaterial
        '
        Me.cmbMaterial.Enabled = False
        Me.cmbMaterial.FormattingEnabled = True
        Me.cmbMaterial.Location = New System.Drawing.Point(92, 22)
        Me.cmbMaterial.Name = "cmbMaterial"
        Me.cmbMaterial.Size = New System.Drawing.Size(121, 21)
        Me.cmbMaterial.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(569, 364)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 24)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "Subtotal:"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Location = New System.Drawing.Point(657, 368)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 27
        '
        'dgvSalidaMat
        '
        Me.dgvSalidaMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalidaMat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdMaterial, Me.clmMaterial, Me.clmCantidad, Me.clmCosto, Me.clmImporte})
        Me.dgvSalidaMat.Location = New System.Drawing.Point(124, 394)
        Me.dgvSalidaMat.Name = "dgvSalidaMat"
        Me.dgvSalidaMat.ReadOnly = True
        Me.dgvSalidaMat.Size = New System.Drawing.Size(549, 150)
        Me.dgvSalidaMat.TabIndex = 28
        '
        'clmIdMaterial
        '
        Me.clmIdMaterial.HeaderText = "IdMaterial"
        Me.clmIdMaterial.Name = "clmIdMaterial"
        Me.clmIdMaterial.ReadOnly = True
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
        Me.clmCosto.HeaderText = "Costo"
        Me.clmCosto.Name = "clmCosto"
        Me.clmCosto.ReadOnly = True
        '
        'clmImporte
        '
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(124, 562)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 29
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Location = New System.Drawing.Point(360, 562)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabar.TabIndex = 30
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(598, 562)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmSalidaMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 597)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvSalidaMat)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.gbMateriales)
        Me.Controls.Add(Me.gbCalles)
        Me.Controls.Add(Me.mskDomicilio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mskCelular)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mskIdEmpleado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbEmpleado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mskIdSalida)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mskConceptoSalida)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSalidaMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salida de Material"
        Me.gbCalles.ResumeLayout(False)
        Me.gbCalles.PerformLayout()
        Me.gbMateriales.ResumeLayout(False)
        Me.gbMateriales.PerformLayout()
        CType(Me.dgvSalidaMat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents mskConceptoSalida As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mskIdSalida As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbEmpleado As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents mskIdEmpleado As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents mskCelular As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents mskDomicilio As MaskedTextBox
    Friend WithEvents gbCalles As GroupBox
    Friend WithEvents mskIdCalle As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbCalle As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents mskTotalCasas As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents gbMateriales As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbMaterial As ComboBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents mskCantidad As MaskedTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents mskUnidadMedida As MaskedTextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtFechaMat As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents mskMinimo As MaskedTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents mskMaximo As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents mskExistencias As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents mskIdMaterial As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents dgvSalidaMat As DataGridView
    Friend WithEvents clmIdMaterial As DataGridViewTextBoxColumn
    Friend WithEvents clmMaterial As DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As DataGridViewTextBoxColumn
    Friend WithEvents clmCosto As DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As DataGridViewTextBoxColumn
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtCosto As TextBox
End Class
