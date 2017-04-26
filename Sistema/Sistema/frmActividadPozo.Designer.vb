<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmActividadPozo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mskIdActividad = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbPozo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskIdPozo = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mskHora = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mskLectura = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mskObservaciones = New System.Windows.Forms.MaskedTextBox()
        Me.dgvActividadPozo = New System.Windows.Forms.DataGridView()
        Me.clmIdActividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPozo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIdPozo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmLectura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.DataSetSistema = New Sistema.DataSetSistema()
        CType(Me.dgvActividadPozo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(387, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IdActividad:"
        '
        'mskIdActividad
        '
        Me.mskIdActividad.Enabled = False
        Me.mskIdActividad.Location = New System.Drawing.Point(514, 51)
        Me.mskIdActividad.Mask = "0000000000"
        Me.mskIdActividad.Name = "mskIdActividad"
        Me.mskIdActividad.Size = New System.Drawing.Size(68, 20)
        Me.mskIdActividad.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pozo:"
        '
        'cmbPozo
        '
        Me.cmbPozo.Enabled = False
        Me.cmbPozo.FormattingEnabled = True
        Me.cmbPozo.Location = New System.Drawing.Point(87, 113)
        Me.cmbPozo.Name = "cmbPozo"
        Me.cmbPozo.Size = New System.Drawing.Size(121, 21)
        Me.cmbPozo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(340, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "IdPozo:"
        '
        'mskIdPozo
        '
        Me.mskIdPozo.Enabled = False
        Me.mskIdPozo.Location = New System.Drawing.Point(449, 113)
        Me.mskIdPozo.Mask = "0000000000"
        Me.mskIdPozo.Name = "mskIdPozo"
        Me.mskIdPozo.Size = New System.Drawing.Size(69, 20)
        Me.mskIdPozo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(98, 177)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(307, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Hora:"
        '
        'mskHora
        '
        Me.mskHora.Enabled = False
        Me.mskHora.Location = New System.Drawing.Point(369, 175)
        Me.mskHora.Mask = "00:00"
        Me.mskHora.Name = "mskHora"
        Me.mskHora.Size = New System.Drawing.Size(44, 20)
        Me.mskHora.TabIndex = 9
        Me.mskHora.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Lectura:"
        '
        'mskLectura
        '
        Me.mskLectura.Enabled = False
        Me.mskLectura.Location = New System.Drawing.Point(111, 258)
        Me.mskLectura.Mask = "00000000"
        Me.mskLectura.Name = "mskLectura"
        Me.mskLectura.Size = New System.Drawing.Size(60, 20)
        Me.mskLectura.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(253, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Observaciones:"
        '
        'mskObservaciones
        '
        Me.mskObservaciones.Enabled = False
        Me.mskObservaciones.Location = New System.Drawing.Point(405, 258)
        Me.mskObservaciones.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
        Me.mskObservaciones.Name = "mskObservaciones"
        Me.mskObservaciones.Size = New System.Drawing.Size(248, 20)
        Me.mskObservaciones.TabIndex = 13
        '
        'dgvActividadPozo
        '
        Me.dgvActividadPozo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActividadPozo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdActividad, Me.clmPozo, Me.clmIdPozo, Me.clmFecha, Me.clmHora, Me.clmLectura, Me.clmObservaciones})
        Me.dgvActividadPozo.Location = New System.Drawing.Point(17, 296)
        Me.dgvActividadPozo.Name = "dgvActividadPozo"
        Me.dgvActividadPozo.ReadOnly = True
        Me.dgvActividadPozo.Size = New System.Drawing.Size(637, 176)
        Me.dgvActividadPozo.TabIndex = 14
        '
        'clmIdActividad
        '
        Me.clmIdActividad.HeaderText = "IdActividad"
        Me.clmIdActividad.Name = "clmIdActividad"
        Me.clmIdActividad.ReadOnly = True
        '
        'clmPozo
        '
        Me.clmPozo.HeaderText = "Pozo"
        Me.clmPozo.Name = "clmPozo"
        Me.clmPozo.ReadOnly = True
        '
        'clmIdPozo
        '
        Me.clmIdPozo.HeaderText = "IdPozo"
        Me.clmIdPozo.Name = "clmIdPozo"
        Me.clmIdPozo.ReadOnly = True
        '
        'clmFecha
        '
        Me.clmFecha.HeaderText = "Fecha"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        '
        'clmHora
        '
        Me.clmHora.HeaderText = "Hora"
        Me.clmHora.Name = "clmHora"
        Me.clmHora.ReadOnly = True
        '
        'clmLectura
        '
        Me.clmLectura.HeaderText = "Lectura"
        Me.clmLectura.Name = "clmLectura"
        Me.clmLectura.ReadOnly = True
        '
        'clmObservaciones
        '
        Me.clmObservaciones.HeaderText = "Observaciones"
        Me.clmObservaciones.Name = "clmObservaciones"
        Me.clmObservaciones.ReadOnly = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(17, 497)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 15
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Location = New System.Drawing.Point(301, 497)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabar.TabIndex = 16
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(579, 497)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'DataSetSistema
        '
        Me.DataSetSistema.DataSetName = "DataSetSistema"
        Me.DataSetSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmActividadPozo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 532)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvActividadPozo)
        Me.Controls.Add(Me.mskObservaciones)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mskLectura)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mskHora)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mskIdPozo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbPozo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mskIdActividad)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmActividadPozo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ActividadPozo"
        CType(Me.dgvActividadPozo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents mskIdActividad As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbPozo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mskIdPozo As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents mskHora As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents mskLectura As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents mskObservaciones As MaskedTextBox
    Friend WithEvents dgvActividadPozo As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents DataSetSistema As DataSetSistema
    Friend WithEvents clmIdActividad As DataGridViewTextBoxColumn
    Friend WithEvents clmPozo As DataGridViewTextBoxColumn
    Friend WithEvents clmIdPozo As DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As DataGridViewTextBoxColumn
    Friend WithEvents clmHora As DataGridViewTextBoxColumn
    Friend WithEvents clmLectura As DataGridViewTextBoxColumn
    Friend WithEvents clmObservaciones As DataGridViewTextBoxColumn
End Class
