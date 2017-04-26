<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarifas
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
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdTarifas = New System.Windows.Forms.TextBox()
        Me.TarifasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSistema = New Sistema.DataSetSistema()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.txtCF = New System.Windows.Forms.TextBox()
        Me.txtRecargos = New System.Windows.Forms.TextBox()
        Me.txtTAR = New System.Windows.Forms.TextBox()
        Me.txtINFRA = New System.Windows.Forms.TextBox()
        Me.dgTarifas = New System.Windows.Forms.DataGridView()
        Me.IdTarifaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AñoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecargosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INFRADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifasTableAdapter = New Sistema.DataSetSistemaTableAdapters.tarifasTableAdapter()
        CType(Me.TarifasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Location = New System.Drawing.Point(578, 12)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 17
        Me.cmdUltimo.Text = "Último"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(402, 12)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 16
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Location = New System.Drawing.Point(204, 12)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 15
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(45, 12)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 14
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(566, 407)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 20
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Location = New System.Drawing.Point(297, 407)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGrabar.TabIndex = 19
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(61, 407)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmdNuevo.TabIndex = 18
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "IdTarifas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(399, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 24)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Año:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 24)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "CF:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(370, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 24)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Recargos:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 24)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "TAR:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(370, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 24)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "INFRA:"
        '
        'txtIdTarifas
        '
        Me.txtIdTarifas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "IdTarifa", True))
        Me.txtIdTarifas.Enabled = False
        Me.txtIdTarifas.Location = New System.Drawing.Point(128, 66)
        Me.txtIdTarifas.Name = "txtIdTarifas"
        Me.txtIdTarifas.Size = New System.Drawing.Size(100, 20)
        Me.txtIdTarifas.TabIndex = 27
        '
        'TarifasBindingSource
        '
        Me.TarifasBindingSource.DataMember = "tarifas"
        Me.TarifasBindingSource.DataSource = Me.DataSetSistema
        '
        'DataSetSistema
        '
        Me.DataSetSistema.DataSetName = "DataSetSistema"
        Me.DataSetSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtAño
        '
        Me.txtAño.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "Año", True))
        Me.txtAño.Enabled = False
        Me.txtAño.Location = New System.Drawing.Point(481, 61)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(100, 20)
        Me.txtAño.TabIndex = 28
        '
        'txtCF
        '
        Me.txtCF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "CF", True))
        Me.txtCF.Enabled = False
        Me.txtCF.Location = New System.Drawing.Point(128, 119)
        Me.txtCF.Name = "txtCF"
        Me.txtCF.Size = New System.Drawing.Size(100, 20)
        Me.txtCF.TabIndex = 29
        '
        'txtRecargos
        '
        Me.txtRecargos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "Recargos", True))
        Me.txtRecargos.Enabled = False
        Me.txtRecargos.Location = New System.Drawing.Point(481, 121)
        Me.txtRecargos.Name = "txtRecargos"
        Me.txtRecargos.Size = New System.Drawing.Size(100, 20)
        Me.txtRecargos.TabIndex = 30
        '
        'txtTAR
        '
        Me.txtTAR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "TAR", True))
        Me.txtTAR.Enabled = False
        Me.txtTAR.Location = New System.Drawing.Point(128, 184)
        Me.txtTAR.Name = "txtTAR"
        Me.txtTAR.Size = New System.Drawing.Size(100, 20)
        Me.txtTAR.TabIndex = 31
        '
        'txtINFRA
        '
        Me.txtINFRA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "INFRA", True))
        Me.txtINFRA.Enabled = False
        Me.txtINFRA.Location = New System.Drawing.Point(481, 184)
        Me.txtINFRA.Name = "txtINFRA"
        Me.txtINFRA.Size = New System.Drawing.Size(100, 20)
        Me.txtINFRA.TabIndex = 32
        '
        'dgTarifas
        '
        Me.dgTarifas.AutoGenerateColumns = False
        Me.dgTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTarifas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTarifaDataGridViewTextBoxColumn, Me.AñoDataGridViewTextBoxColumn, Me.CFDataGridViewTextBoxColumn, Me.RecargosDataGridViewTextBoxColumn, Me.TARDataGridViewTextBoxColumn, Me.INFRADataGridViewTextBoxColumn})
        Me.dgTarifas.DataSource = Me.TarifasBindingSource
        Me.dgTarifas.Location = New System.Drawing.Point(27, 233)
        Me.dgTarifas.Name = "dgTarifas"
        Me.dgTarifas.ReadOnly = True
        Me.dgTarifas.Size = New System.Drawing.Size(644, 150)
        Me.dgTarifas.TabIndex = 33
        '
        'IdTarifaDataGridViewTextBoxColumn
        '
        Me.IdTarifaDataGridViewTextBoxColumn.DataPropertyName = "IdTarifa"
        Me.IdTarifaDataGridViewTextBoxColumn.HeaderText = "IdTarifa"
        Me.IdTarifaDataGridViewTextBoxColumn.Name = "IdTarifaDataGridViewTextBoxColumn"
        Me.IdTarifaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AñoDataGridViewTextBoxColumn
        '
        Me.AñoDataGridViewTextBoxColumn.DataPropertyName = "Año"
        Me.AñoDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.AñoDataGridViewTextBoxColumn.Name = "AñoDataGridViewTextBoxColumn"
        Me.AñoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CFDataGridViewTextBoxColumn
        '
        Me.CFDataGridViewTextBoxColumn.DataPropertyName = "CF"
        Me.CFDataGridViewTextBoxColumn.HeaderText = "CF"
        Me.CFDataGridViewTextBoxColumn.Name = "CFDataGridViewTextBoxColumn"
        Me.CFDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RecargosDataGridViewTextBoxColumn
        '
        Me.RecargosDataGridViewTextBoxColumn.DataPropertyName = "Recargos"
        Me.RecargosDataGridViewTextBoxColumn.HeaderText = "Recargos"
        Me.RecargosDataGridViewTextBoxColumn.Name = "RecargosDataGridViewTextBoxColumn"
        Me.RecargosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TARDataGridViewTextBoxColumn
        '
        Me.TARDataGridViewTextBoxColumn.DataPropertyName = "TAR"
        Me.TARDataGridViewTextBoxColumn.HeaderText = "TAR"
        Me.TARDataGridViewTextBoxColumn.Name = "TARDataGridViewTextBoxColumn"
        Me.TARDataGridViewTextBoxColumn.ReadOnly = True
        '
        'INFRADataGridViewTextBoxColumn
        '
        Me.INFRADataGridViewTextBoxColumn.DataPropertyName = "INFRA"
        Me.INFRADataGridViewTextBoxColumn.HeaderText = "INFRA"
        Me.INFRADataGridViewTextBoxColumn.Name = "INFRADataGridViewTextBoxColumn"
        Me.INFRADataGridViewTextBoxColumn.ReadOnly = True
        '
        'TarifasTableAdapter
        '
        Me.TarifasTableAdapter.ClearBeforeFill = True
        '
        'frmTarifas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 442)
        Me.Controls.Add(Me.dgTarifas)
        Me.Controls.Add(Me.txtINFRA)
        Me.Controls.Add(Me.txtTAR)
        Me.Controls.Add(Me.txtRecargos)
        Me.Controls.Add(Me.txtCF)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.txtIdTarifas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdInicio)
        Me.Name = "frmTarifas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarifas"
        CType(Me.TarifasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdUltimo As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents cmdInicio As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIdTarifas As TextBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents txtCF As TextBox
    Friend WithEvents txtRecargos As TextBox
    Friend WithEvents txtTAR As TextBox
    Friend WithEvents txtINFRA As TextBox
    Friend WithEvents dgTarifas As DataGridView
    Friend WithEvents DataSetSistema As DataSetSistema
    Friend WithEvents TarifasBindingSource As BindingSource
    Friend WithEvents TarifasTableAdapter As DataSetSistemaTableAdapters.tarifasTableAdapter
    Friend WithEvents IdTarifaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AñoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecargosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INFRADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
