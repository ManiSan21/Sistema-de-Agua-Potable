<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportesFechas
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdCuentaReporte = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha Inicial:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Final:"
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Location = New System.Drawing.Point(156, 15)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha1.TabIndex = 3
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Location = New System.Drawing.Point(156, 63)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha2.TabIndex = 4
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(411, 13)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(134, 70)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "IdCuenta:"
        '
        'txtIdCuentaReporte
        '
        Me.txtIdCuentaReporte.Location = New System.Drawing.Point(110, 40)
        Me.txtIdCuentaReporte.Name = "txtIdCuentaReporte"
        Me.txtIdCuentaReporte.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCuentaReporte.TabIndex = 7
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(239, 102)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmReportesFechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 137)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtIdCuentaReporte)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dtpFecha2)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmReportesFechas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fechas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFecha1 As DateTimePicker
    Friend WithEvents dtpFecha2 As DateTimePicker
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdCuentaReporte As TextBox
    Friend WithEvents btnSalir As Button
End Class
