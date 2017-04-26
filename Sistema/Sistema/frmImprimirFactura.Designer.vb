<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimirFactura
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
        Me.dtpFechaImpresion = New System.Windows.Forms.DateTimePicker()
        Me.txtSituacion = New System.Windows.Forms.TextBox()
        Me.txtDescuentoImpresion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCuotaFija = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRecargoImpresion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTARImpresion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtINFRAImpresion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtOtrosImpresion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotalImpresion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtNombreCuentaImpresion = New System.Windows.Forms.TextBox()
        Me.txtIdCuentaImpresion = New System.Windows.Forms.TextBox()
        Me.txtDomicilioImpresion = New System.Windows.Forms.TextBox()
        Me.txtMesInicialImpresion = New System.Windows.Forms.TextBox()
        Me.txtMesFinalImpresion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAñoPagoImpresion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'dtpFechaImpresion
        '
        Me.dtpFechaImpresion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaImpresion.Location = New System.Drawing.Point(13, 13)
        Me.dtpFechaImpresion.Name = "dtpFechaImpresion"
        Me.dtpFechaImpresion.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaImpresion.TabIndex = 0
        '
        'txtSituacion
        '
        Me.txtSituacion.Location = New System.Drawing.Point(473, 12)
        Me.txtSituacion.Name = "txtSituacion"
        Me.txtSituacion.ReadOnly = True
        Me.txtSituacion.Size = New System.Drawing.Size(242, 20)
        Me.txtSituacion.TabIndex = 1
        '
        'txtDescuentoImpresion
        '
        Me.txtDescuentoImpresion.Location = New System.Drawing.Point(473, 49)
        Me.txtDescuentoImpresion.Name = "txtDescuentoImpresion"
        Me.txtDescuentoImpresion.ReadOnly = True
        Me.txtDescuentoImpresion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuentoImpresion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(614, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Descuento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(614, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cuota Fija"
        '
        'txtCuotaFija
        '
        Me.txtCuotaFija.Location = New System.Drawing.Point(473, 90)
        Me.txtCuotaFija.Name = "txtCuotaFija"
        Me.txtCuotaFija.ReadOnly = True
        Me.txtCuotaFija.Size = New System.Drawing.Size(100, 20)
        Me.txtCuotaFija.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(614, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Recargo"
        '
        'txtRecargoImpresion
        '
        Me.txtRecargoImpresion.Location = New System.Drawing.Point(473, 131)
        Me.txtRecargoImpresion.Name = "txtRecargoImpresion"
        Me.txtRecargoImpresion.ReadOnly = True
        Me.txtRecargoImpresion.Size = New System.Drawing.Size(100, 20)
        Me.txtRecargoImpresion.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(614, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "TAR"
        '
        'txtTARImpresion
        '
        Me.txtTARImpresion.Location = New System.Drawing.Point(473, 173)
        Me.txtTARImpresion.Name = "txtTARImpresion"
        Me.txtTARImpresion.ReadOnly = True
        Me.txtTARImpresion.Size = New System.Drawing.Size(100, 20)
        Me.txtTARImpresion.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(614, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "INFRA"
        '
        'txtINFRAImpresion
        '
        Me.txtINFRAImpresion.Location = New System.Drawing.Point(473, 216)
        Me.txtINFRAImpresion.Name = "txtINFRAImpresion"
        Me.txtINFRAImpresion.ReadOnly = True
        Me.txtINFRAImpresion.Size = New System.Drawing.Size(100, 20)
        Me.txtINFRAImpresion.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(614, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 24)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Otros"
        '
        'txtOtrosImpresion
        '
        Me.txtOtrosImpresion.Location = New System.Drawing.Point(473, 257)
        Me.txtOtrosImpresion.Name = "txtOtrosImpresion"
        Me.txtOtrosImpresion.ReadOnly = True
        Me.txtOtrosImpresion.Size = New System.Drawing.Size(100, 20)
        Me.txtOtrosImpresion.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(614, 312)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 24)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Pesos"
        '
        'txtTotalImpresion
        '
        Me.txtTotalImpresion.Location = New System.Drawing.Point(473, 317)
        Me.txtTotalImpresion.Name = "txtTotalImpresion"
        Me.txtTotalImpresion.ReadOnly = True
        Me.txtTotalImpresion.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalImpresion.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(27, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(260, 24)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "USMAJAC MPIO DE SAYULA"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(312, 369)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 23
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtNombreCuentaImpresion
        '
        Me.txtNombreCuentaImpresion.Location = New System.Drawing.Point(31, 104)
        Me.txtNombreCuentaImpresion.Name = "txtNombreCuentaImpresion"
        Me.txtNombreCuentaImpresion.ReadOnly = True
        Me.txtNombreCuentaImpresion.Size = New System.Drawing.Size(242, 20)
        Me.txtNombreCuentaImpresion.TabIndex = 24
        '
        'txtIdCuentaImpresion
        '
        Me.txtIdCuentaImpresion.Location = New System.Drawing.Point(31, 144)
        Me.txtIdCuentaImpresion.Name = "txtIdCuentaImpresion"
        Me.txtIdCuentaImpresion.ReadOnly = True
        Me.txtIdCuentaImpresion.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCuentaImpresion.TabIndex = 25
        '
        'txtDomicilioImpresion
        '
        Me.txtDomicilioImpresion.Location = New System.Drawing.Point(31, 186)
        Me.txtDomicilioImpresion.Name = "txtDomicilioImpresion"
        Me.txtDomicilioImpresion.ReadOnly = True
        Me.txtDomicilioImpresion.Size = New System.Drawing.Size(207, 20)
        Me.txtDomicilioImpresion.TabIndex = 26
        '
        'txtMesInicialImpresion
        '
        Me.txtMesInicialImpresion.Location = New System.Drawing.Point(31, 238)
        Me.txtMesInicialImpresion.Name = "txtMesInicialImpresion"
        Me.txtMesInicialImpresion.ReadOnly = True
        Me.txtMesInicialImpresion.Size = New System.Drawing.Size(100, 20)
        Me.txtMesInicialImpresion.TabIndex = 27
        '
        'txtMesFinalImpresion
        '
        Me.txtMesFinalImpresion.Location = New System.Drawing.Point(166, 238)
        Me.txtMesFinalImpresion.Name = "txtMesFinalImpresion"
        Me.txtMesFinalImpresion.ReadOnly = True
        Me.txtMesFinalImpresion.Size = New System.Drawing.Size(100, 20)
        Me.txtMesFinalImpresion.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(137, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 24)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "A"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(272, 234)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 24)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "DEL"
        '
        'txtAñoPagoImpresion
        '
        Me.txtAñoPagoImpresion.Location = New System.Drawing.Point(324, 238)
        Me.txtAñoPagoImpresion.Name = "txtAñoPagoImpresion"
        Me.txtAñoPagoImpresion.ReadOnly = True
        Me.txtAñoPagoImpresion.Size = New System.Drawing.Size(100, 20)
        Me.txtAñoPagoImpresion.TabIndex = 31
        '
        'frmImprimirFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 404)
        Me.Controls.Add(Me.txtAñoPagoImpresion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtMesFinalImpresion)
        Me.Controls.Add(Me.txtMesInicialImpresion)
        Me.Controls.Add(Me.txtDomicilioImpresion)
        Me.Controls.Add(Me.txtIdCuentaImpresion)
        Me.Controls.Add(Me.txtNombreCuentaImpresion)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTotalImpresion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtOtrosImpresion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtINFRAImpresion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTARImpresion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRecargoImpresion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCuotaFija)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescuentoImpresion)
        Me.Controls.Add(Me.txtSituacion)
        Me.Controls.Add(Me.dtpFechaImpresion)
        Me.Name = "frmImprimirFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Factura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpFechaImpresion As DateTimePicker
    Friend WithEvents txtSituacion As TextBox
    Friend WithEvents txtDescuentoImpresion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCuotaFija As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRecargoImpresion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTARImpresion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtINFRAImpresion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtOtrosImpresion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotalImpresion As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtNombreCuentaImpresion As TextBox
    Friend WithEvents txtIdCuentaImpresion As TextBox
    Friend WithEvents txtDomicilioImpresion As TextBox
    Friend WithEvents txtMesInicialImpresion As TextBox
    Friend WithEvents txtMesFinalImpresion As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAñoPagoImpresion As TextBox
End Class
