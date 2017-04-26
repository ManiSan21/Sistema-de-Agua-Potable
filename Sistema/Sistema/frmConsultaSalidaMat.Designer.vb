<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaSalidaMat
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.rbtIdSalida = New System.Windows.Forms.RadioButton()
        Me.rbtEmpleado = New System.Windows.Forms.RadioButton()
        Me.rbtCalle = New System.Windows.Forms.RadioButton()
        Me.rbtPeriodo = New System.Windows.Forms.RadioButton()
        Me.cmbIdSalida = New System.Windows.Forms.ComboBox()
        Me.cmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.cmbCalle = New System.Windows.Forms.ComboBox()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaIni = New System.Windows.Forms.Label()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.rbtTodos = New System.Windows.Forms.RadioButton()
        Me.dgvConsultaSalidasMat = New System.Windows.Forms.DataGridView()
        Me.clmIdSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDetalleIdMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDetalleMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDetalleCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDetalleCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDetalleImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mskIdSalida = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskEmpleado = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mskCalle = New System.Windows.Forms.MaskedTextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mskConcepto = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.dgvDetalleSalidaMat = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.clmDetIdSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDetMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDetCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDetCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDetImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvConsultaSalidasMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleSalidaMat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Salida Material"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(293, 51)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 14
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(537, 706)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'rbtIdSalida
        '
        Me.rbtIdSalida.AutoSize = True
        Me.rbtIdSalida.Location = New System.Drawing.Point(29, 13)
        Me.rbtIdSalida.Name = "rbtIdSalida"
        Me.rbtIdSalida.Size = New System.Drawing.Size(63, 17)
        Me.rbtIdSalida.TabIndex = 17
        Me.rbtIdSalida.TabStop = True
        Me.rbtIdSalida.Text = "IdSalida"
        Me.rbtIdSalida.UseVisualStyleBackColor = True
        '
        'rbtEmpleado
        '
        Me.rbtEmpleado.AutoSize = True
        Me.rbtEmpleado.Location = New System.Drawing.Point(29, 57)
        Me.rbtEmpleado.Name = "rbtEmpleado"
        Me.rbtEmpleado.Size = New System.Drawing.Size(72, 17)
        Me.rbtEmpleado.TabIndex = 18
        Me.rbtEmpleado.TabStop = True
        Me.rbtEmpleado.Text = "Empleado"
        Me.rbtEmpleado.UseVisualStyleBackColor = True
        '
        'rbtCalle
        '
        Me.rbtCalle.AutoSize = True
        Me.rbtCalle.Location = New System.Drawing.Point(29, 93)
        Me.rbtCalle.Name = "rbtCalle"
        Me.rbtCalle.Size = New System.Drawing.Size(48, 17)
        Me.rbtCalle.TabIndex = 19
        Me.rbtCalle.TabStop = True
        Me.rbtCalle.Text = "Calle"
        Me.rbtCalle.UseVisualStyleBackColor = True
        '
        'rbtPeriodo
        '
        Me.rbtPeriodo.AutoSize = True
        Me.rbtPeriodo.Location = New System.Drawing.Point(29, 128)
        Me.rbtPeriodo.Name = "rbtPeriodo"
        Me.rbtPeriodo.Size = New System.Drawing.Size(61, 17)
        Me.rbtPeriodo.TabIndex = 20
        Me.rbtPeriodo.TabStop = True
        Me.rbtPeriodo.Text = "Periodo"
        Me.rbtPeriodo.UseVisualStyleBackColor = True
        '
        'cmbIdSalida
        '
        Me.cmbIdSalida.FormattingEnabled = True
        Me.cmbIdSalida.Location = New System.Drawing.Point(109, 9)
        Me.cmbIdSalida.Name = "cmbIdSalida"
        Me.cmbIdSalida.Size = New System.Drawing.Size(121, 21)
        Me.cmbIdSalida.TabIndex = 21
        Me.cmbIdSalida.Visible = False
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.FormattingEnabled = True
        Me.cmbEmpleado.Location = New System.Drawing.Point(109, 53)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(121, 21)
        Me.cmbEmpleado.TabIndex = 22
        Me.cmbEmpleado.Visible = False
        '
        'cmbCalle
        '
        Me.cmbCalle.FormattingEnabled = True
        Me.cmbCalle.Location = New System.Drawing.Point(109, 89)
        Me.cmbCalle.Name = "cmbCalle"
        Me.cmbCalle.Size = New System.Drawing.Size(121, 21)
        Me.cmbCalle.TabIndex = 23
        Me.cmbCalle.Visible = False
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Location = New System.Drawing.Point(227, 124)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaInicial.TabIndex = 24
        Me.dtpFechaInicial.Visible = False
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Location = New System.Drawing.Point(547, 124)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaFinal.TabIndex = 25
        Me.dtpFechaFinal.Visible = False
        '
        'lblFechaIni
        '
        Me.lblFechaIni.AutoSize = True
        Me.lblFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIni.Location = New System.Drawing.Point(115, 124)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(98, 20)
        Me.lblFechaIni.TabIndex = 26
        Me.lblFechaIni.Text = "Fecha Inicial"
        Me.lblFechaIni.Visible = False
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFin.Location = New System.Drawing.Point(443, 124)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(92, 20)
        Me.lblFechaFin.TabIndex = 27
        Me.lblFechaFin.Text = "Fecha Final"
        Me.lblFechaFin.Visible = False
        '
        'rbtTodos
        '
        Me.rbtTodos.AutoSize = True
        Me.rbtTodos.Location = New System.Drawing.Point(305, 13)
        Me.rbtTodos.Name = "rbtTodos"
        Me.rbtTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbtTodos.TabIndex = 28
        Me.rbtTodos.TabStop = True
        Me.rbtTodos.Text = "Todos"
        Me.rbtTodos.UseVisualStyleBackColor = True
        '
        'dgvConsultaSalidasMat
        '
        Me.dgvConsultaSalidasMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaSalidasMat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdSalida, Me.clmEmpleado, Me.clmCalle, Me.clmFecha, Me.clmConcepto, Me.clmSubtotal, Me.clmDetalleIdMaterial, Me.clmDetalleMaterial, Me.clmDetalleCantidad, Me.clmDetalleCosto, Me.clmDetalleImporte})
        Me.dgvConsultaSalidasMat.Location = New System.Drawing.Point(12, 334)
        Me.dgvConsultaSalidasMat.Name = "dgvConsultaSalidasMat"
        Me.dgvConsultaSalidasMat.Size = New System.Drawing.Size(1151, 150)
        Me.dgvConsultaSalidasMat.TabIndex = 31
        Me.dgvConsultaSalidasMat.Visible = False
        '
        'clmIdSalida
        '
        Me.clmIdSalida.HeaderText = "IdSalida"
        Me.clmIdSalida.Name = "clmIdSalida"
        '
        'clmEmpleado
        '
        Me.clmEmpleado.HeaderText = "Empleado"
        Me.clmEmpleado.Name = "clmEmpleado"
        '
        'clmCalle
        '
        Me.clmCalle.HeaderText = "Calle"
        Me.clmCalle.Name = "clmCalle"
        '
        'clmFecha
        '
        Me.clmFecha.HeaderText = "Fecha"
        Me.clmFecha.Name = "clmFecha"
        '
        'clmConcepto
        '
        Me.clmConcepto.HeaderText = "Concepto"
        Me.clmConcepto.Name = "clmConcepto"
        '
        'clmSubtotal
        '
        Me.clmSubtotal.HeaderText = "Subtotal"
        Me.clmSubtotal.Name = "clmSubtotal"
        '
        'clmDetalleIdMaterial
        '
        Me.clmDetalleIdMaterial.HeaderText = "IdMaterial"
        Me.clmDetalleIdMaterial.Name = "clmDetalleIdMaterial"
        '
        'clmDetalleMaterial
        '
        Me.clmDetalleMaterial.HeaderText = "Material"
        Me.clmDetalleMaterial.Name = "clmDetalleMaterial"
        '
        'clmDetalleCantidad
        '
        Me.clmDetalleCantidad.HeaderText = "Cantidad"
        Me.clmDetalleCantidad.Name = "clmDetalleCantidad"
        '
        'clmDetalleCosto
        '
        Me.clmDetalleCosto.HeaderText = "Costo"
        Me.clmDetalleCosto.Name = "clmDetalleCosto"
        '
        'clmDetalleImporte
        '
        Me.clmDetalleImporte.HeaderText = "Importe"
        Me.clmDetalleImporte.Name = "clmDetalleImporte"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 24)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "IdSalida"
        '
        'mskIdSalida
        '
        Me.mskIdSalida.Enabled = False
        Me.mskIdSalida.Location = New System.Drawing.Point(109, 181)
        Me.mskIdSalida.Mask = "0000000000"
        Me.mskIdSalida.Name = "mskIdSalida"
        Me.mskIdSalida.Size = New System.Drawing.Size(69, 20)
        Me.mskIdSalida.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(223, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 24)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Empleado"
        '
        'mskEmpleado
        '
        Me.mskEmpleado.Enabled = False
        Me.mskEmpleado.Location = New System.Drawing.Point(327, 180)
        Me.mskEmpleado.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL"
        Me.mskEmpleado.Name = "mskEmpleado"
        Me.mskEmpleado.Size = New System.Drawing.Size(310, 20)
        Me.mskEmpleado.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 24)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Calle"
        '
        'mskCalle
        '
        Me.mskCalle.Enabled = False
        Me.mskCalle.Location = New System.Drawing.Point(109, 232)
        Me.mskCalle.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL"
        Me.mskCalle.Name = "mskCalle"
        Me.mskCalle.Size = New System.Drawing.Size(310, 20)
        Me.mskCalle.TabIndex = 37
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(537, 231)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(464, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 24)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Fecha"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 24)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Concepto"
        '
        'mskConcepto
        '
        Me.mskConcepto.Enabled = False
        Me.mskConcepto.Location = New System.Drawing.Point(127, 271)
        Me.mskConcepto.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL"
        Me.mskConcepto.Name = "mskConcepto"
        Me.mskConcepto.Size = New System.Drawing.Size(310, 20)
        Me.mskConcepto.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(464, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 24)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Subtotal"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Location = New System.Drawing.Point(547, 267)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 43
        '
        'dgvDetalleSalidaMat
        '
        Me.dgvDetalleSalidaMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleSalidaMat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmDetIdSalida, Me.clmDetMaterial, Me.clmDetCantidad, Me.clmDetCosto, Me.clmDetImporte})
        Me.dgvDetalleSalidaMat.Location = New System.Drawing.Point(33, 535)
        Me.dgvDetalleSalidaMat.Name = "dgvDetalleSalidaMat"
        Me.dgvDetalleSalidaMat.Size = New System.Drawing.Size(549, 150)
        Me.dgvDetalleSalidaMat.TabIndex = 44
        Me.dgvDetalleSalidaMat.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 503)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 24)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Detalle"
        '
        'clmDetIdSalida
        '
        Me.clmDetIdSalida.HeaderText = "IdSalida"
        Me.clmDetIdSalida.Name = "clmDetIdSalida"
        '
        'clmDetMaterial
        '
        Me.clmDetMaterial.HeaderText = "Material"
        Me.clmDetMaterial.Name = "clmDetMaterial"
        '
        'clmDetCantidad
        '
        Me.clmDetCantidad.HeaderText = "Cantidad"
        Me.clmDetCantidad.Name = "clmDetCantidad"
        '
        'clmDetCosto
        '
        Me.clmDetCosto.HeaderText = "Costo"
        Me.clmDetCosto.Name = "clmDetCosto"
        '
        'clmDetImporte
        '
        Me.clmDetImporte.HeaderText = "Importe"
        Me.clmDetImporte.Name = "clmDetImporte"
        '
        'frmConsultaSalidaMat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 741)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvDetalleSalidaMat)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mskConcepto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.mskCalle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mskEmpleado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mskIdSalida)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvConsultaSalidasMat)
        Me.Controls.Add(Me.rbtTodos)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.lblFechaIni)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicial)
        Me.Controls.Add(Me.cmbCalle)
        Me.Controls.Add(Me.cmbEmpleado)
        Me.Controls.Add(Me.cmbIdSalida)
        Me.Controls.Add(Me.rbtPeriodo)
        Me.Controls.Add(Me.rbtCalle)
        Me.Controls.Add(Me.rbtEmpleado)
        Me.Controls.Add(Me.rbtIdSalida)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmConsultaSalidaMat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Salidas de Material"
        CType(Me.dgvConsultaSalidasMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleSalidaMat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents rbtIdSalida As RadioButton
    Friend WithEvents rbtEmpleado As RadioButton
    Friend WithEvents rbtCalle As RadioButton
    Friend WithEvents rbtPeriodo As RadioButton
    Friend WithEvents cmbIdSalida As ComboBox
    Friend WithEvents cmbEmpleado As ComboBox
    Friend WithEvents cmbCalle As ComboBox
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents lblFechaIni As Label
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents rbtTodos As RadioButton
    Friend WithEvents dgvConsultaSalidasMat As DataGridView
    Friend WithEvents clmIdSalida As DataGridViewTextBoxColumn
    Friend WithEvents clmEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents clmCalle As DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As DataGridViewTextBoxColumn
    Friend WithEvents clmConcepto As DataGridViewTextBoxColumn
    Friend WithEvents clmSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents clmDetalleIdMaterial As DataGridViewTextBoxColumn
    Friend WithEvents clmDetalleMaterial As DataGridViewTextBoxColumn
    Friend WithEvents clmDetalleCantidad As DataGridViewTextBoxColumn
    Friend WithEvents clmDetalleCosto As DataGridViewTextBoxColumn
    Friend WithEvents clmDetalleImporte As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents mskIdSalida As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mskEmpleado As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mskCalle As MaskedTextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents mskConcepto As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents dgvDetalleSalidaMat As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents clmDetIdSalida As DataGridViewTextBoxColumn
    Friend WithEvents clmDetMaterial As DataGridViewTextBoxColumn
    Friend WithEvents clmDetCantidad As DataGridViewTextBoxColumn
    Friend WithEvents clmDetCosto As DataGridViewTextBoxColumn
    Friend WithEvents clmDetImporte As DataGridViewTextBoxColumn
End Class
