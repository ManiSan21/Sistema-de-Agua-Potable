<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuentas
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgCuentas = New System.Windows.Forms.DataGridView()
        Me.IdCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoExtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoIntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPagoADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPagoMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSistema = New Sistema.DataSetSistema()
        Me.txtIdCuenta = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNoExt = New System.Windows.Forms.TextBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.txtNoInt = New System.Windows.Forms.TextBox()
        Me.cmbIdCalle = New System.Windows.Forms.ComboBox()
        Me.CallesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CallesTableAdapter = New Sistema.DataSetSistemaTableAdapters.callesTableAdapter()
        Me.dtpFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.dtpUltimoPagoA = New System.Windows.Forms.DateTimePicker()
        Me.dtpUltimoPagoM = New System.Windows.Forms.DateTimePicker()
        Me.CuentasTableAdapter = New Sistema.DataSetSistemaTableAdapters.cuentasTableAdapter()
        CType(Me.dgCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CallesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IdCuenta:"
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Location = New System.Drawing.Point(571, 12)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 17
        Me.cmdUltimo.Text = "Último"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(395, 12)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 16
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Location = New System.Drawing.Point(197, 12)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 15
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(38, 12)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 14
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(307, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "IdCalle:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 24)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(419, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 24)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "NoExterior:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 24)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "NoInterior:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(307, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 24)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "FechaAlta:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 24)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "ÚltimoPagoAño:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(371, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 24)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "ÚltimoPagoM:"
        '
        'dgCuentas
        '
        Me.dgCuentas.AutoGenerateColumns = False
        Me.dgCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCuentaDataGridViewTextBoxColumn, Me.IdCalleDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.NoExtDataGridViewTextBoxColumn, Me.NoIntDataGridViewTextBoxColumn, Me.FechaAltaDataGridViewTextBoxColumn, Me.UltimoPagoADataGridViewTextBoxColumn, Me.UltimoPagoMDataGridViewTextBoxColumn})
        Me.dgCuentas.DataSource = Me.CuentasBindingSource
        Me.dgCuentas.Location = New System.Drawing.Point(16, 321)
        Me.dgCuentas.Name = "dgCuentas"
        Me.dgCuentas.ReadOnly = True
        Me.dgCuentas.Size = New System.Drawing.Size(847, 150)
        Me.dgCuentas.TabIndex = 25
        '
        'IdCuentaDataGridViewTextBoxColumn
        '
        Me.IdCuentaDataGridViewTextBoxColumn.DataPropertyName = "IdCuenta"
        Me.IdCuentaDataGridViewTextBoxColumn.HeaderText = "IdCuenta"
        Me.IdCuentaDataGridViewTextBoxColumn.Name = "IdCuentaDataGridViewTextBoxColumn"
        Me.IdCuentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdCalleDataGridViewTextBoxColumn
        '
        Me.IdCalleDataGridViewTextBoxColumn.DataPropertyName = "IdCalle"
        Me.IdCalleDataGridViewTextBoxColumn.HeaderText = "IdCalle"
        Me.IdCalleDataGridViewTextBoxColumn.Name = "IdCalleDataGridViewTextBoxColumn"
        Me.IdCalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoExtDataGridViewTextBoxColumn
        '
        Me.NoExtDataGridViewTextBoxColumn.DataPropertyName = "NoExt"
        Me.NoExtDataGridViewTextBoxColumn.HeaderText = "NoExt"
        Me.NoExtDataGridViewTextBoxColumn.Name = "NoExtDataGridViewTextBoxColumn"
        Me.NoExtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoIntDataGridViewTextBoxColumn
        '
        Me.NoIntDataGridViewTextBoxColumn.DataPropertyName = "NoInt"
        Me.NoIntDataGridViewTextBoxColumn.HeaderText = "NoInt"
        Me.NoIntDataGridViewTextBoxColumn.Name = "NoIntDataGridViewTextBoxColumn"
        Me.NoIntDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaAltaDataGridViewTextBoxColumn
        '
        Me.FechaAltaDataGridViewTextBoxColumn.DataPropertyName = "FechaAlta"
        Me.FechaAltaDataGridViewTextBoxColumn.HeaderText = "FechaAlta"
        Me.FechaAltaDataGridViewTextBoxColumn.Name = "FechaAltaDataGridViewTextBoxColumn"
        Me.FechaAltaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UltimoPagoADataGridViewTextBoxColumn
        '
        Me.UltimoPagoADataGridViewTextBoxColumn.DataPropertyName = "UltimoPagoA"
        Me.UltimoPagoADataGridViewTextBoxColumn.HeaderText = "UltimoPagoA"
        Me.UltimoPagoADataGridViewTextBoxColumn.Name = "UltimoPagoADataGridViewTextBoxColumn"
        Me.UltimoPagoADataGridViewTextBoxColumn.ReadOnly = True
        '
        'UltimoPagoMDataGridViewTextBoxColumn
        '
        Me.UltimoPagoMDataGridViewTextBoxColumn.DataPropertyName = "UltimoPagoM"
        Me.UltimoPagoMDataGridViewTextBoxColumn.HeaderText = "UltimoPagoM"
        Me.UltimoPagoMDataGridViewTextBoxColumn.Name = "UltimoPagoMDataGridViewTextBoxColumn"
        Me.UltimoPagoMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuentasBindingSource
        '
        Me.CuentasBindingSource.DataMember = "cuentas"
        Me.CuentasBindingSource.DataSource = Me.DataSetSistema
        '
        'DataSetSistema
        '
        Me.DataSetSistema.DataSetName = "DataSetSistema"
        Me.DataSetSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "IdCuenta", True))
        Me.txtIdCuenta.Enabled = False
        Me.txtIdCuenta.Location = New System.Drawing.Point(118, 75)
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCuenta.TabIndex = 26
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "Nombre", True))
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(118, 136)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(261, 20)
        Me.txtNombre.TabIndex = 28
        '
        'txtNoExt
        '
        Me.txtNoExt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "NoExt", True))
        Me.txtNoExt.Enabled = False
        Me.txtNoExt.Location = New System.Drawing.Point(546, 135)
        Me.txtNoExt.Name = "txtNoExt"
        Me.txtNoExt.Size = New System.Drawing.Size(100, 20)
        Me.txtNoExt.TabIndex = 29
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(763, 499)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 32
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Location = New System.Drawing.Point(432, 499)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGrabar.TabIndex = 31
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(56, 499)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmdNuevo.TabIndex = 30
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'txtNoInt
        '
        Me.txtNoInt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "NoInt", True))
        Me.txtNoInt.Enabled = False
        Me.txtNoInt.Location = New System.Drawing.Point(118, 196)
        Me.txtNoInt.Name = "txtNoInt"
        Me.txtNoInt.Size = New System.Drawing.Size(100, 20)
        Me.txtNoInt.TabIndex = 33
        '
        'cmbIdCalle
        '
        Me.cmbIdCalle.DataSource = Me.DataSetSistema
        Me.cmbIdCalle.DisplayMember = "calles.Nombre"
        Me.cmbIdCalle.Enabled = False
        Me.cmbIdCalle.FormattingEnabled = True
        Me.cmbIdCalle.Location = New System.Drawing.Point(395, 73)
        Me.cmbIdCalle.Name = "cmbIdCalle"
        Me.cmbIdCalle.Size = New System.Drawing.Size(121, 21)
        Me.cmbIdCalle.TabIndex = 37
        Me.cmbIdCalle.ValueMember = "calles.IdCalle"
        '
        'CallesBindingSource
        '
        Me.CallesBindingSource.DataMember = "calles"
        Me.CallesBindingSource.DataSource = Me.DataSetSistema
        '
        'CallesTableAdapter
        '
        Me.CallesTableAdapter.ClearBeforeFill = True
        '
        'dtpFechaAlta
        '
        Me.dtpFechaAlta.Enabled = False
        Me.dtpFechaAlta.Location = New System.Drawing.Point(423, 193)
        Me.dtpFechaAlta.Name = "dtpFechaAlta"
        Me.dtpFechaAlta.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaAlta.TabIndex = 38
        Me.dtpFechaAlta.Value = New Date(2017, 3, 1, 22, 32, 47, 0)
        '
        'dtpUltimoPagoA
        '
        Me.dtpUltimoPagoA.Enabled = False
        Me.dtpUltimoPagoA.Location = New System.Drawing.Point(165, 262)
        Me.dtpUltimoPagoA.Name = "dtpUltimoPagoA"
        Me.dtpUltimoPagoA.Size = New System.Drawing.Size(200, 20)
        Me.dtpUltimoPagoA.TabIndex = 39
        Me.dtpUltimoPagoA.Value = New Date(2017, 3, 1, 22, 32, 17, 0)
        '
        'dtpUltimoPagoM
        '
        Me.dtpUltimoPagoM.Enabled = False
        Me.dtpUltimoPagoM.Location = New System.Drawing.Point(505, 262)
        Me.dtpUltimoPagoM.Name = "dtpUltimoPagoM"
        Me.dtpUltimoPagoM.Size = New System.Drawing.Size(200, 20)
        Me.dtpUltimoPagoM.TabIndex = 40
        Me.dtpUltimoPagoM.Value = New Date(2017, 3, 1, 22, 32, 39, 0)
        '
        'CuentasTableAdapter
        '
        Me.CuentasTableAdapter.ClearBeforeFill = True
        '
        'frmCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 534)
        Me.Controls.Add(Me.dtpUltimoPagoM)
        Me.Controls.Add(Me.dtpUltimoPagoA)
        Me.Controls.Add(Me.dtpFechaAlta)
        Me.Controls.Add(Me.cmbIdCalle)
        Me.Controls.Add(Me.txtNoInt)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.txtNoExt)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIdCuenta)
        Me.Controls.Add(Me.dgCuentas)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas"
        CType(Me.dgCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CallesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmdUltimo As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents cmdInicio As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgCuentas As DataGridView
    Friend WithEvents txtIdCuenta As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtNoExt As TextBox
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents DataSetSistema As DataSetSistema
    Friend WithEvents txtNoInt As TextBox
    Friend WithEvents cmbIdCalle As ComboBox
    Friend WithEvents CallesBindingSource As BindingSource
    Friend WithEvents CallesTableAdapter As DataSetSistemaTableAdapters.callesTableAdapter
    Friend WithEvents dtpFechaAlta As DateTimePicker
    Friend WithEvents dtpUltimoPagoA As DateTimePicker
    Friend WithEvents dtpUltimoPagoM As DateTimePicker
    Friend WithEvents CuentasBindingSource As BindingSource
    Friend WithEvents CuentasTableAdapter As DataSetSistemaTableAdapters.cuentasTableAdapter
    Friend WithEvents IdCuentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoExtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoIntDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UltimoPagoADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UltimoPagoMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
