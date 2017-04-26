<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGastosRealizados
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mskIdGastoR = New System.Windows.Forms.MaskedTextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mskIdEmpleado = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mskDomicilioEmpleado = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mskTelefonoEmpleado = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbConceptoGasto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mskObservaciones = New System.Windows.Forms.MaskedTextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbConsultas = New System.Windows.Forms.GroupBox()
        Me.btnAceptarConsulta = New System.Windows.Forms.Button()
        Me.rbtTodos = New System.Windows.Forms.RadioButton()
        Me.cmbEmpleadoConsulta = New System.Windows.Forms.ComboBox()
        Me.cmbConceptoConsulta = New System.Windows.Forms.ComboBox()
        Me.dtpFechaConsulta = New System.Windows.Forms.DateTimePicker()
        Me.rbtEmpleadoConsulta = New System.Windows.Forms.RadioButton()
        Me.rbtConceptoConsulta = New System.Windows.Forms.RadioButton()
        Me.rbtFechaConsulta = New System.Windows.Forms.RadioButton()
        Me.dgvConsultas = New System.Windows.Forms.DataGridView()
        Me.clmIdGastoR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIdEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIdGasto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mskIdGasto = New System.Windows.Forms.MaskedTextBox()
        Me.gbEmpleado = New System.Windows.Forms.GroupBox()
        Me.gbGasto = New System.Windows.Forms.GroupBox()
        Me.mskImporte = New System.Windows.Forms.MaskedTextBox()
        Me.gbConsultas.SuspendLayout()
        CType(Me.dgvConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEmpleado.SuspendLayout()
        Me.gbGasto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IdGastoR:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha:"
        '
        'mskIdGastoR
        '
        Me.mskIdGastoR.Enabled = False
        Me.mskIdGastoR.Location = New System.Drawing.Point(106, 12)
        Me.mskIdGastoR.Mask = "0000000000"
        Me.mskIdGastoR.Name = "mskIdGastoR"
        Me.mskIdGastoR.Size = New System.Drawing.Size(71, 20)
        Me.mskIdGastoR.TabIndex = 2
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(89, 59)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 3
        Me.dtpFecha.Value = New Date(2017, 3, 15, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Empleado:"
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.Enabled = False
        Me.cmbEmpleado.FormattingEnabled = True
        Me.cmbEmpleado.Location = New System.Drawing.Point(120, 24)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(121, 21)
        Me.cmbEmpleado.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(247, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "IdEmpleado:"
        '
        'mskIdEmpleado
        '
        Me.mskIdEmpleado.Enabled = False
        Me.mskIdEmpleado.Location = New System.Drawing.Point(370, 24)
        Me.mskIdEmpleado.Mask = "0000000000"
        Me.mskIdEmpleado.Name = "mskIdEmpleado"
        Me.mskIdEmpleado.Size = New System.Drawing.Size(68, 20)
        Me.mskIdEmpleado.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Domicilio:"
        '
        'mskDomicilioEmpleado
        '
        Me.mskDomicilioEmpleado.Enabled = False
        Me.mskDomicilioEmpleado.Location = New System.Drawing.Point(110, 51)
        Me.mskDomicilioEmpleado.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
        Me.mskDomicilioEmpleado.Name = "mskDomicilioEmpleado"
        Me.mskDomicilioEmpleado.Size = New System.Drawing.Size(273, 20)
        Me.mskDomicilioEmpleado.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(389, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Teléfono:"
        '
        'mskTelefonoEmpleado
        '
        Me.mskTelefonoEmpleado.Enabled = False
        Me.mskTelefonoEmpleado.Location = New System.Drawing.Point(485, 50)
        Me.mskTelefonoEmpleado.Mask = "0000000000"
        Me.mskTelefonoEmpleado.Name = "mskTelefonoEmpleado"
        Me.mskTelefonoEmpleado.Size = New System.Drawing.Size(70, 20)
        Me.mskTelefonoEmpleado.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ConceptoGasto:"
        '
        'cmbConceptoGasto
        '
        Me.cmbConceptoGasto.Enabled = False
        Me.cmbConceptoGasto.FormattingEnabled = True
        Me.cmbConceptoGasto.Location = New System.Drawing.Point(156, 29)
        Me.cmbConceptoGasto.Name = "cmbConceptoGasto"
        Me.cmbConceptoGasto.Size = New System.Drawing.Size(121, 21)
        Me.cmbConceptoGasto.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(283, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 24)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "IdGasto:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 24)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Importe $:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(210, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 24)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Observaciones:"
        '
        'mskObservaciones
        '
        Me.mskObservaciones.Enabled = False
        Me.mskObservaciones.Location = New System.Drawing.Point(358, 56)
        Me.mskObservaciones.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
        Me.mskObservaciones.Name = "mskObservaciones"
        Me.mskObservaciones.Size = New System.Drawing.Size(200, 20)
        Me.mskObservaciones.TabIndex = 7
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(13, 347)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Location = New System.Drawing.Point(256, 347)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabar.TabIndex = 7
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(495, 347)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'gbConsultas
        '
        Me.gbConsultas.Controls.Add(Me.btnAceptarConsulta)
        Me.gbConsultas.Controls.Add(Me.rbtTodos)
        Me.gbConsultas.Controls.Add(Me.cmbEmpleadoConsulta)
        Me.gbConsultas.Controls.Add(Me.cmbConceptoConsulta)
        Me.gbConsultas.Controls.Add(Me.dtpFechaConsulta)
        Me.gbConsultas.Controls.Add(Me.rbtEmpleadoConsulta)
        Me.gbConsultas.Controls.Add(Me.rbtConceptoConsulta)
        Me.gbConsultas.Controls.Add(Me.rbtFechaConsulta)
        Me.gbConsultas.Location = New System.Drawing.Point(628, 10)
        Me.gbConsultas.Name = "gbConsultas"
        Me.gbConsultas.Size = New System.Drawing.Size(403, 141)
        Me.gbConsultas.TabIndex = 10
        Me.gbConsultas.TabStop = False
        Me.gbConsultas.Text = "Consultas:"
        '
        'btnAceptarConsulta
        '
        Me.btnAceptarConsulta.Location = New System.Drawing.Point(295, 96)
        Me.btnAceptarConsulta.Name = "btnAceptarConsulta"
        Me.btnAceptarConsulta.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarConsulta.TabIndex = 8
        Me.btnAceptarConsulta.Text = "Aceptar"
        Me.btnAceptarConsulta.UseVisualStyleBackColor = True
        '
        'rbtTodos
        '
        Me.rbtTodos.AutoSize = True
        Me.rbtTodos.Location = New System.Drawing.Point(342, 23)
        Me.rbtTodos.Name = "rbtTodos"
        Me.rbtTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbtTodos.TabIndex = 7
        Me.rbtTodos.TabStop = True
        Me.rbtTodos.Text = "Todos"
        Me.rbtTodos.UseVisualStyleBackColor = True
        '
        'cmbEmpleadoConsulta
        '
        Me.cmbEmpleadoConsulta.FormattingEnabled = True
        Me.cmbEmpleadoConsulta.Location = New System.Drawing.Point(95, 92)
        Me.cmbEmpleadoConsulta.Name = "cmbEmpleadoConsulta"
        Me.cmbEmpleadoConsulta.Size = New System.Drawing.Size(121, 21)
        Me.cmbEmpleadoConsulta.TabIndex = 6
        Me.cmbEmpleadoConsulta.Visible = False
        '
        'cmbConceptoConsulta
        '
        Me.cmbConceptoConsulta.FormattingEnabled = True
        Me.cmbConceptoConsulta.Location = New System.Drawing.Point(95, 52)
        Me.cmbConceptoConsulta.Name = "cmbConceptoConsulta"
        Me.cmbConceptoConsulta.Size = New System.Drawing.Size(121, 21)
        Me.cmbConceptoConsulta.TabIndex = 5
        Me.cmbConceptoConsulta.Visible = False
        '
        'dtpFechaConsulta
        '
        Me.dtpFechaConsulta.Location = New System.Drawing.Point(95, 19)
        Me.dtpFechaConsulta.Name = "dtpFechaConsulta"
        Me.dtpFechaConsulta.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaConsulta.TabIndex = 4
        Me.dtpFechaConsulta.Value = New Date(2017, 3, 15, 0, 0, 0, 0)
        Me.dtpFechaConsulta.Visible = False
        '
        'rbtEmpleadoConsulta
        '
        Me.rbtEmpleadoConsulta.AutoSize = True
        Me.rbtEmpleadoConsulta.Location = New System.Drawing.Point(6, 96)
        Me.rbtEmpleadoConsulta.Name = "rbtEmpleadoConsulta"
        Me.rbtEmpleadoConsulta.Size = New System.Drawing.Size(72, 17)
        Me.rbtEmpleadoConsulta.TabIndex = 3
        Me.rbtEmpleadoConsulta.TabStop = True
        Me.rbtEmpleadoConsulta.Text = "Empleado"
        Me.rbtEmpleadoConsulta.UseVisualStyleBackColor = True
        '
        'rbtConceptoConsulta
        '
        Me.rbtConceptoConsulta.AutoSize = True
        Me.rbtConceptoConsulta.Location = New System.Drawing.Point(6, 57)
        Me.rbtConceptoConsulta.Name = "rbtConceptoConsulta"
        Me.rbtConceptoConsulta.Size = New System.Drawing.Size(71, 17)
        Me.rbtConceptoConsulta.TabIndex = 2
        Me.rbtConceptoConsulta.TabStop = True
        Me.rbtConceptoConsulta.Text = "Concepto"
        Me.rbtConceptoConsulta.UseVisualStyleBackColor = True
        '
        'rbtFechaConsulta
        '
        Me.rbtFechaConsulta.AutoSize = True
        Me.rbtFechaConsulta.Location = New System.Drawing.Point(6, 19)
        Me.rbtFechaConsulta.Name = "rbtFechaConsulta"
        Me.rbtFechaConsulta.Size = New System.Drawing.Size(55, 17)
        Me.rbtFechaConsulta.TabIndex = 1
        Me.rbtFechaConsulta.TabStop = True
        Me.rbtFechaConsulta.Text = "Fecha"
        Me.rbtFechaConsulta.UseVisualStyleBackColor = True
        '
        'dgvConsultas
        '
        Me.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdGastoR, Me.clmIdEmpleado, Me.clmIdGasto, Me.clmFecha, Me.clmEmpleado, Me.clmConcepto, Me.clmImporte, Me.clmObservaciones})
        Me.dgvConsultas.Location = New System.Drawing.Point(628, 177)
        Me.dgvConsultas.Name = "dgvConsultas"
        Me.dgvConsultas.ReadOnly = True
        Me.dgvConsultas.Size = New System.Drawing.Size(403, 193)
        Me.dgvConsultas.TabIndex = 11
        '
        'clmIdGastoR
        '
        Me.clmIdGastoR.HeaderText = "IdGastoR"
        Me.clmIdGastoR.Name = "clmIdGastoR"
        Me.clmIdGastoR.ReadOnly = True
        '
        'clmIdEmpleado
        '
        Me.clmIdEmpleado.HeaderText = "IdEmpleado"
        Me.clmIdEmpleado.Name = "clmIdEmpleado"
        Me.clmIdEmpleado.ReadOnly = True
        '
        'clmIdGasto
        '
        Me.clmIdGasto.HeaderText = "IdGasto"
        Me.clmIdGasto.Name = "clmIdGasto"
        Me.clmIdGasto.ReadOnly = True
        '
        'clmFecha
        '
        Me.clmFecha.HeaderText = "Fecha"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        '
        'clmEmpleado
        '
        Me.clmEmpleado.HeaderText = "Empleado"
        Me.clmEmpleado.Name = "clmEmpleado"
        Me.clmEmpleado.ReadOnly = True
        '
        'clmConcepto
        '
        Me.clmConcepto.HeaderText = "Concepto"
        Me.clmConcepto.Name = "clmConcepto"
        Me.clmConcepto.ReadOnly = True
        Me.clmConcepto.Width = 200
        '
        'clmImporte
        '
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        '
        'clmObservaciones
        '
        Me.clmObservaciones.HeaderText = "Observaciones"
        Me.clmObservaciones.Name = "clmObservaciones"
        Me.clmObservaciones.ReadOnly = True
        Me.clmObservaciones.Width = 200
        '
        'mskIdGasto
        '
        Me.mskIdGasto.Enabled = False
        Me.mskIdGasto.Location = New System.Drawing.Point(367, 29)
        Me.mskIdGasto.Mask = "0000000000"
        Me.mskIdGasto.Name = "mskIdGasto"
        Me.mskIdGasto.Size = New System.Drawing.Size(100, 20)
        Me.mskIdGasto.TabIndex = 8
        '
        'gbEmpleado
        '
        Me.gbEmpleado.Controls.Add(Me.Label4)
        Me.gbEmpleado.Controls.Add(Me.Label3)
        Me.gbEmpleado.Controls.Add(Me.mskTelefonoEmpleado)
        Me.gbEmpleado.Controls.Add(Me.cmbEmpleado)
        Me.gbEmpleado.Controls.Add(Me.Label6)
        Me.gbEmpleado.Controls.Add(Me.mskDomicilioEmpleado)
        Me.gbEmpleado.Controls.Add(Me.Label5)
        Me.gbEmpleado.Controls.Add(Me.mskIdEmpleado)
        Me.gbEmpleado.Location = New System.Drawing.Point(21, 106)
        Me.gbEmpleado.Name = "gbEmpleado"
        Me.gbEmpleado.Size = New System.Drawing.Size(559, 100)
        Me.gbEmpleado.TabIndex = 12
        Me.gbEmpleado.TabStop = False
        Me.gbEmpleado.Text = "Empleado:"
        '
        'gbGasto
        '
        Me.gbGasto.Controls.Add(Me.mskImporte)
        Me.gbGasto.Controls.Add(Me.cmbConceptoGasto)
        Me.gbGasto.Controls.Add(Me.Label7)
        Me.gbGasto.Controls.Add(Me.mskObservaciones)
        Me.gbGasto.Controls.Add(Me.Label10)
        Me.gbGasto.Controls.Add(Me.Label8)
        Me.gbGasto.Controls.Add(Me.Label9)
        Me.gbGasto.Controls.Add(Me.mskIdGasto)
        Me.gbGasto.Location = New System.Drawing.Point(10, 224)
        Me.gbGasto.Name = "gbGasto"
        Me.gbGasto.Size = New System.Drawing.Size(570, 100)
        Me.gbGasto.TabIndex = 13
        Me.gbGasto.TabStop = False
        Me.gbGasto.Text = "Gasto:"
        '
        'mskImporte
        '
        Me.mskImporte.Culture = New System.Globalization.CultureInfo("es-MX")
        Me.mskImporte.Enabled = False
        Me.mskImporte.Location = New System.Drawing.Point(104, 58)
        Me.mskImporte.Mask = "000000.00"
        Me.mskImporte.Name = "mskImporte"
        Me.mskImporte.Size = New System.Drawing.Size(100, 20)
        Me.mskImporte.TabIndex = 9
        '
        'frmGastosRealizados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 388)
        Me.Controls.Add(Me.gbGasto)
        Me.Controls.Add(Me.gbEmpleado)
        Me.Controls.Add(Me.dgvConsultas)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.gbConsultas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.mskIdGastoR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGastosRealizados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GastosRealizados"
        Me.gbConsultas.ResumeLayout(False)
        Me.gbConsultas.PerformLayout()
        CType(Me.dgvConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEmpleado.ResumeLayout(False)
        Me.gbEmpleado.PerformLayout()
        Me.gbGasto.ResumeLayout(False)
        Me.gbGasto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mskIdGastoR As MaskedTextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbEmpleado As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mskIdEmpleado As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents mskDomicilioEmpleado As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents mskTelefonoEmpleado As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbConceptoGasto As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents mskObservaciones As MaskedTextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents gbConsultas As GroupBox
    Friend WithEvents dtpFechaConsulta As DateTimePicker
    Friend WithEvents rbtEmpleadoConsulta As RadioButton
    Friend WithEvents rbtConceptoConsulta As RadioButton
    Friend WithEvents rbtFechaConsulta As RadioButton
    Friend WithEvents cmbEmpleadoConsulta As ComboBox
    Friend WithEvents cmbConceptoConsulta As ComboBox
    Friend WithEvents dgvConsultas As DataGridView
    Friend WithEvents mskIdGasto As MaskedTextBox
    Friend WithEvents btnAceptarConsulta As Button
    Friend WithEvents rbtTodos As RadioButton
    Friend WithEvents gbEmpleado As GroupBox
    Friend WithEvents gbGasto As GroupBox
    Friend WithEvents clmIdGastoR As DataGridViewTextBoxColumn
    Friend WithEvents clmIdEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents clmIdGasto As DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As DataGridViewTextBoxColumn
    Friend WithEvents clmEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents clmConcepto As DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As DataGridViewTextBoxColumn
    Friend WithEvents clmObservaciones As DataGridViewTextBoxColumn
    Friend WithEvents mskImporte As MaskedTextBox
End Class
