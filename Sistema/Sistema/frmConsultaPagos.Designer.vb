﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaPagos
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
        Me.cmbConsultaTipoDePago = New System.Windows.Forms.ComboBox()
        Me.dgvConsultaPago = New System.Windows.Forms.DataGridView()
        Me.clmIdPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIdCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmOtros = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.cmbIdPagoConsulta = New System.Windows.Forms.ComboBox()
        Me.gbCuenta = New System.Windows.Forms.GroupBox()
        Me.mskNombreCuenta = New System.Windows.Forms.MaskedTextBox()
        Me.mskUltimoPagoMes = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mskUltimoPagoAño = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mskNumeroInterior = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mskNumeroExterior = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mskIdCalle = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mskIdCuenta = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbtIdPago = New System.Windows.Forms.RadioButton()
        Me.rbtTipoDePago = New System.Windows.Forms.RadioButton()
        Me.btnConsultar = New System.Windows.Forms.Button()
        CType(Me.dgvConsultaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCuenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbConsultaTipoDePago
        '
        Me.cmbConsultaTipoDePago.FormattingEnabled = True
        Me.cmbConsultaTipoDePago.Items.AddRange(New Object() {"AGUA", "SERVICIO"})
        Me.cmbConsultaTipoDePago.Location = New System.Drawing.Point(111, 51)
        Me.cmbConsultaTipoDePago.Name = "cmbConsultaTipoDePago"
        Me.cmbConsultaTipoDePago.Size = New System.Drawing.Size(121, 21)
        Me.cmbConsultaTipoDePago.TabIndex = 3
        Me.cmbConsultaTipoDePago.Visible = False
        '
        'dgvConsultaPago
        '
        Me.dgvConsultaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaPago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdPago, Me.clmIdCuenta, Me.clmFechaConsulta, Me.clmTipo, Me.clmOtros, Me.clmTotal})
        Me.dgvConsultaPago.Location = New System.Drawing.Point(47, 241)
        Me.dgvConsultaPago.Name = "dgvConsultaPago"
        Me.dgvConsultaPago.ReadOnly = True
        Me.dgvConsultaPago.Size = New System.Drawing.Size(644, 150)
        Me.dgvConsultaPago.TabIndex = 4
        '
        'clmIdPago
        '
        Me.clmIdPago.HeaderText = "IdPago"
        Me.clmIdPago.Name = "clmIdPago"
        Me.clmIdPago.ReadOnly = True
        '
        'clmIdCuenta
        '
        Me.clmIdCuenta.HeaderText = "IdCuenta"
        Me.clmIdCuenta.Name = "clmIdCuenta"
        Me.clmIdCuenta.ReadOnly = True
        '
        'clmFechaConsulta
        '
        Me.clmFechaConsulta.HeaderText = "Fecha"
        Me.clmFechaConsulta.Name = "clmFechaConsulta"
        Me.clmFechaConsulta.ReadOnly = True
        '
        'clmTipo
        '
        Me.clmTipo.HeaderText = "Tipo"
        Me.clmTipo.Name = "clmTipo"
        Me.clmTipo.ReadOnly = True
        '
        'clmOtros
        '
        Me.clmOtros.HeaderText = "Otros"
        Me.clmOtros.Name = "clmOtros"
        Me.clmOtros.ReadOnly = True
        '
        'clmTotal
        '
        Me.clmTotal.HeaderText = "Total"
        Me.clmTotal.Name = "clmTotal"
        Me.clmTotal.ReadOnly = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(308, 397)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'cmbIdPagoConsulta
        '
        Me.cmbIdPagoConsulta.FormattingEnabled = True
        Me.cmbIdPagoConsulta.Location = New System.Drawing.Point(81, 11)
        Me.cmbIdPagoConsulta.Name = "cmbIdPagoConsulta"
        Me.cmbIdPagoConsulta.Size = New System.Drawing.Size(121, 21)
        Me.cmbIdPagoConsulta.TabIndex = 6
        Me.cmbIdPagoConsulta.Visible = False
        '
        'gbCuenta
        '
        Me.gbCuenta.Controls.Add(Me.mskNombreCuenta)
        Me.gbCuenta.Controls.Add(Me.mskUltimoPagoMes)
        Me.gbCuenta.Controls.Add(Me.Label9)
        Me.gbCuenta.Controls.Add(Me.mskUltimoPagoAño)
        Me.gbCuenta.Controls.Add(Me.Label8)
        Me.gbCuenta.Controls.Add(Me.mskNumeroInterior)
        Me.gbCuenta.Controls.Add(Me.Label7)
        Me.gbCuenta.Controls.Add(Me.mskNumeroExterior)
        Me.gbCuenta.Controls.Add(Me.Label6)
        Me.gbCuenta.Controls.Add(Me.mskIdCalle)
        Me.gbCuenta.Controls.Add(Me.Label5)
        Me.gbCuenta.Controls.Add(Me.mskIdCuenta)
        Me.gbCuenta.Controls.Add(Me.Label4)
        Me.gbCuenta.Controls.Add(Me.Label3)
        Me.gbCuenta.Location = New System.Drawing.Point(16, 87)
        Me.gbCuenta.Name = "gbCuenta"
        Me.gbCuenta.Size = New System.Drawing.Size(700, 148)
        Me.gbCuenta.TabIndex = 7
        Me.gbCuenta.TabStop = False
        Me.gbCuenta.Text = "Cuentas"
        Me.gbCuenta.Visible = False
        '
        'mskNombreCuenta
        '
        Me.mskNombreCuenta.Location = New System.Drawing.Point(97, 30)
        Me.mskNombreCuenta.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
        Me.mskNombreCuenta.Name = "mskNombreCuenta"
        Me.mskNombreCuenta.Size = New System.Drawing.Size(312, 20)
        Me.mskNombreCuenta.TabIndex = 15
        '
        'mskUltimoPagoMes
        '
        Me.mskUltimoPagoMes.Enabled = False
        Me.mskUltimoPagoMes.Location = New System.Drawing.Point(625, 100)
        Me.mskUltimoPagoMes.Mask = "0000000000"
        Me.mskUltimoPagoMes.Name = "mskUltimoPagoMes"
        Me.mskUltimoPagoMes.Size = New System.Drawing.Size(69, 20)
        Me.mskUltimoPagoMes.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(472, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 24)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "ÚltimoPagoMes:"
        '
        'mskUltimoPagoAño
        '
        Me.mskUltimoPagoAño.Enabled = False
        Me.mskUltimoPagoAño.Location = New System.Drawing.Point(397, 104)
        Me.mskUltimoPagoAño.Mask = "0000000000"
        Me.mskUltimoPagoAño.Name = "mskUltimoPagoAño"
        Me.mskUltimoPagoAño.Size = New System.Drawing.Size(69, 20)
        Me.mskUltimoPagoAño.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(245, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 24)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "ÚltimoPagoAño:"
        '
        'mskNumeroInterior
        '
        Me.mskNumeroInterior.Enabled = False
        Me.mskNumeroInterior.Location = New System.Drawing.Point(161, 100)
        Me.mskNumeroInterior.Mask = "0000000000"
        Me.mskNumeroInterior.Name = "mskNumeroInterior"
        Me.mskNumeroInterior.Size = New System.Drawing.Size(69, 20)
        Me.mskNumeroInterior.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 24)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "NúmeroInterior:"
        '
        'mskNumeroExterior
        '
        Me.mskNumeroExterior.Enabled = False
        Me.mskNumeroExterior.Location = New System.Drawing.Point(511, 65)
        Me.mskNumeroExterior.Mask = "0000000000"
        Me.mskNumeroExterior.Name = "mskNumeroExterior"
        Me.mskNumeroExterior.Size = New System.Drawing.Size(69, 20)
        Me.mskNumeroExterior.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(356, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 24)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "NúmeroExterior:"
        '
        'mskIdCalle
        '
        Me.mskIdCalle.Enabled = False
        Me.mskIdCalle.Location = New System.Drawing.Point(264, 69)
        Me.mskIdCalle.Mask = "0000000000"
        Me.mskIdCalle.Name = "mskIdCalle"
        Me.mskIdCalle.Size = New System.Drawing.Size(69, 20)
        Me.mskIdCalle.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(186, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "IdCalle:"
        '
        'mskIdCuenta
        '
        Me.mskIdCuenta.Enabled = False
        Me.mskIdCuenta.Location = New System.Drawing.Point(102, 65)
        Me.mskIdCuenta.Mask = "0000000000"
        Me.mskIdCuenta.Name = "mskIdCuenta"
        Me.mskIdCuenta.Size = New System.Drawing.Size(69, 20)
        Me.mskIdCuenta.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "IdCuenta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre:"
        '
        'rbtIdPago
        '
        Me.rbtIdPago.AutoSize = True
        Me.rbtIdPago.Location = New System.Drawing.Point(16, 15)
        Me.rbtIdPago.Name = "rbtIdPago"
        Me.rbtIdPago.Size = New System.Drawing.Size(59, 17)
        Me.rbtIdPago.TabIndex = 8
        Me.rbtIdPago.TabStop = True
        Me.rbtIdPago.Text = "IdPago"
        Me.rbtIdPago.UseVisualStyleBackColor = True
        '
        'rbtTipoDePago
        '
        Me.rbtTipoDePago.AutoSize = True
        Me.rbtTipoDePago.Location = New System.Drawing.Point(16, 55)
        Me.rbtTipoDePago.Name = "rbtTipoDePago"
        Me.rbtTipoDePago.Size = New System.Drawing.Size(89, 17)
        Me.rbtTipoDePago.TabIndex = 9
        Me.rbtTipoDePago.TabStop = True
        Me.rbtTipoDePago.Text = "Tipo de Pago"
        Me.rbtTipoDePago.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(357, 49)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 10
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'frmConsultaPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 427)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.rbtTipoDePago)
        Me.Controls.Add(Me.rbtIdPago)
        Me.Controls.Add(Me.gbCuenta)
        Me.Controls.Add(Me.cmbIdPagoConsulta)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvConsultaPago)
        Me.Controls.Add(Me.cmbConsultaTipoDePago)
        Me.Name = "frmConsultaPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Pagos"
        CType(Me.dgvConsultaPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCuenta.ResumeLayout(False)
        Me.gbCuenta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbConsultaTipoDePago As ComboBox
    Friend WithEvents dgvConsultaPago As DataGridView
    Friend WithEvents clmIdPago As DataGridViewTextBoxColumn
    Friend WithEvents clmIdCuenta As DataGridViewTextBoxColumn
    Friend WithEvents clmFechaConsulta As DataGridViewTextBoxColumn
    Friend WithEvents clmTipo As DataGridViewTextBoxColumn
    Friend WithEvents clmOtros As DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
    Friend WithEvents cmbIdPagoConsulta As ComboBox
    Friend WithEvents gbCuenta As GroupBox
    Friend WithEvents mskUltimoPagoMes As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents mskUltimoPagoAño As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents mskNumeroInterior As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents mskNumeroExterior As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents mskIdCalle As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents mskIdCuenta As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rbtIdPago As RadioButton
    Friend WithEvents rbtTipoDePago As RadioButton
    Friend WithEvents btnConsultar As Button
    Friend WithEvents mskNombreCuenta As MaskedTextBox
End Class
