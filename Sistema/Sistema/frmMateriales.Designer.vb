<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMateriales
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIdMaterial = New System.Windows.Forms.TextBox()
        Me.MaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSistema = New Sistema.DataSetSistema()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtExistencias = New System.Windows.Forms.TextBox()
        Me.txtMaximo = New System.Windows.Forms.TextBox()
        Me.txtMinimo = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.dtpUltimaFechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.dgMateriales = New System.Windows.Forms.DataGridView()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.MaterialTableAdapter = New Sistema.DataSetSistemaTableAdapters.materialTableAdapter()
        Me.cmbUnidad = New System.Windows.Forms.ComboBox()
        Me.IdMaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaximoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinimoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimaFechaCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(12, 12)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 0
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Location = New System.Drawing.Point(181, 12)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 1
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(395, 12)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 2
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Location = New System.Drawing.Point(593, 12)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 3
        Me.cmdUltimo.Text = "Último"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "IdMaterial:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(307, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Existencias:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(307, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Máximo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Mínimo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(307, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 24)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Unidad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 24)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Costo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(275, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 24)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "ÚltimaFechaCompra:"
        '
        'txtIdMaterial
        '
        Me.txtIdMaterial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "IdMaterial", True))
        Me.txtIdMaterial.Enabled = False
        Me.txtIdMaterial.Location = New System.Drawing.Point(121, 63)
        Me.txtIdMaterial.Name = "txtIdMaterial"
        Me.txtIdMaterial.Size = New System.Drawing.Size(100, 20)
        Me.txtIdMaterial.TabIndex = 12
        '
        'MaterialBindingSource
        '
        Me.MaterialBindingSource.DataMember = "material"
        Me.MaterialBindingSource.DataSource = Me.DataSetSistema
        '
        'DataSetSistema
        '
        Me.DataSetSistema.DataSetName = "DataSetSistema"
        Me.DataSetSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "Descripcion", True))
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(428, 63)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(240, 20)
        Me.txtDescripcion.TabIndex = 13
        '
        'txtExistencias
        '
        Me.txtExistencias.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "Existencias", True))
        Me.txtExistencias.Enabled = False
        Me.txtExistencias.Location = New System.Drawing.Point(121, 115)
        Me.txtExistencias.Name = "txtExistencias"
        Me.txtExistencias.Size = New System.Drawing.Size(100, 20)
        Me.txtExistencias.TabIndex = 14
        '
        'txtMaximo
        '
        Me.txtMaximo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "Maximo", True))
        Me.txtMaximo.Enabled = False
        Me.txtMaximo.Location = New System.Drawing.Point(428, 114)
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.Size = New System.Drawing.Size(100, 20)
        Me.txtMaximo.TabIndex = 15
        '
        'txtMinimo
        '
        Me.txtMinimo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "Minimo", True))
        Me.txtMinimo.Enabled = False
        Me.txtMinimo.Location = New System.Drawing.Point(121, 159)
        Me.txtMinimo.Name = "txtMinimo"
        Me.txtMinimo.Size = New System.Drawing.Size(100, 20)
        Me.txtMinimo.TabIndex = 16
        '
        'txtCosto
        '
        Me.txtCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "Costo", True))
        Me.txtCosto.Enabled = False
        Me.txtCosto.Location = New System.Drawing.Point(121, 213)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(100, 20)
        Me.txtCosto.TabIndex = 18
        '
        'dtpUltimaFechaCompra
        '
        Me.dtpUltimaFechaCompra.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MaterialBindingSource, "UltimaFechaCompra", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.dtpUltimaFechaCompra.Location = New System.Drawing.Point(468, 213)
        Me.dtpUltimaFechaCompra.Name = "dtpUltimaFechaCompra"
        Me.dtpUltimaFechaCompra.Size = New System.Drawing.Size(200, 20)
        Me.dtpUltimaFechaCompra.TabIndex = 19
        '
        'dgMateriales
        '
        Me.dgMateriales.AutoGenerateColumns = False
        Me.dgMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMateriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMaterialDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ExistenciasDataGridViewTextBoxColumn, Me.MaximoDataGridViewTextBoxColumn, Me.MinimoDataGridViewTextBoxColumn, Me.UnidadDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.UltimaFechaCompraDataGridViewTextBoxColumn})
        Me.dgMateriales.DataSource = Me.MaterialBindingSource
        Me.dgMateriales.Location = New System.Drawing.Point(15, 256)
        Me.dgMateriales.Name = "dgMateriales"
        Me.dgMateriales.ReadOnly = True
        Me.dgMateriales.Size = New System.Drawing.Size(653, 150)
        Me.dgMateriales.TabIndex = 20
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(15, 426)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmdNuevo.TabIndex = 21
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Location = New System.Drawing.Point(303, 426)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGrabar.TabIndex = 22
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(593, 426)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 23
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'MaterialTableAdapter
        '
        Me.MaterialTableAdapter.ClearBeforeFill = True
        '
        'cmbUnidad
        '
        Me.cmbUnidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialBindingSource, "Unidad", True))
        Me.cmbUnidad.Enabled = False
        Me.cmbUnidad.FormattingEnabled = True
        Me.cmbUnidad.Items.AddRange(New Object() {"PZ", "MT", "KILOS", "GRAMOS"})
        Me.cmbUnidad.Location = New System.Drawing.Point(428, 160)
        Me.cmbUnidad.Name = "cmbUnidad"
        Me.cmbUnidad.Size = New System.Drawing.Size(121, 21)
        Me.cmbUnidad.TabIndex = 24
        '
        'IdMaterialDataGridViewTextBoxColumn
        '
        Me.IdMaterialDataGridViewTextBoxColumn.DataPropertyName = "IdMaterial"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.IdMaterialDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.IdMaterialDataGridViewTextBoxColumn.HeaderText = "IdMaterial"
        Me.IdMaterialDataGridViewTextBoxColumn.Name = "IdMaterialDataGridViewTextBoxColumn"
        Me.IdMaterialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExistenciasDataGridViewTextBoxColumn
        '
        Me.ExistenciasDataGridViewTextBoxColumn.DataPropertyName = "Existencias"
        Me.ExistenciasDataGridViewTextBoxColumn.HeaderText = "Existencias"
        Me.ExistenciasDataGridViewTextBoxColumn.Name = "ExistenciasDataGridViewTextBoxColumn"
        Me.ExistenciasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaximoDataGridViewTextBoxColumn
        '
        Me.MaximoDataGridViewTextBoxColumn.DataPropertyName = "Maximo"
        Me.MaximoDataGridViewTextBoxColumn.HeaderText = "Maximo"
        Me.MaximoDataGridViewTextBoxColumn.Name = "MaximoDataGridViewTextBoxColumn"
        Me.MaximoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MinimoDataGridViewTextBoxColumn
        '
        Me.MinimoDataGridViewTextBoxColumn.DataPropertyName = "Minimo"
        Me.MinimoDataGridViewTextBoxColumn.HeaderText = "Minimo"
        Me.MinimoDataGridViewTextBoxColumn.Name = "MinimoDataGridViewTextBoxColumn"
        Me.MinimoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnidadDataGridViewTextBoxColumn
        '
        Me.UnidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.HeaderText = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.Name = "UnidadDataGridViewTextBoxColumn"
        Me.UnidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "Costo"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.CostoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UltimaFechaCompraDataGridViewTextBoxColumn
        '
        Me.UltimaFechaCompraDataGridViewTextBoxColumn.DataPropertyName = "UltimaFechaCompra"
        Me.UltimaFechaCompraDataGridViewTextBoxColumn.HeaderText = "UltimaFechaCompra"
        Me.UltimaFechaCompraDataGridViewTextBoxColumn.Name = "UltimaFechaCompraDataGridViewTextBoxColumn"
        Me.UltimaFechaCompraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 474)
        Me.Controls.Add(Me.cmbUnidad)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.dgMateriales)
        Me.Controls.Add(Me.dtpUltimaFechaCompra)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.txtMinimo)
        Me.Controls.Add(Me.txtMaximo)
        Me.Controls.Add(Me.txtExistencias)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtIdMaterial)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdInicio)
        Me.Name = "frmMateriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Materiales"
        CType(Me.MaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdInicio As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdUltimo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIdMaterial As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtExistencias As TextBox
    Friend WithEvents txtMaximo As TextBox
    Friend WithEvents txtMinimo As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents dtpUltimaFechaCompra As DateTimePicker
    Friend WithEvents dgMateriales As DataGridView
    Friend WithEvents DataSetSistema As DataSetSistema
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents MaterialBindingSource As BindingSource
    Friend WithEvents MaterialTableAdapter As DataSetSistemaTableAdapters.materialTableAdapter
    Friend WithEvents cmbUnidad As ComboBox
    Friend WithEvents IdMaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaximoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinimoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UltimaFechaCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
