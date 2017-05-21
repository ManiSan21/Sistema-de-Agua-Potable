<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagos
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
        Me.mskIdPago = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.gbCuenta = New System.Windows.Forms.GroupBox()
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
        Me.cmbNombreCuenta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbTipoPago = New System.Windows.Forms.GroupBox()
        Me.rbtServicio = New System.Windows.Forms.RadioButton()
        Me.rbtAgua = New System.Windows.Forms.RadioButton()
        Me.gbPagoAgua = New System.Windows.Forms.GroupBox()
        Me.txtDescuentoFinal = New System.Windows.Forms.TextBox()
        Me.txtINFRAFinal = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtTARFinal = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtRecargoFinal = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCFFinal = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbMesFinal = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbMesInicial = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtINFRA = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTAR = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtRecargo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCF = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbAñoTarifa = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mskIdSituacion = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbSituacion = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gbServicios = New System.Windows.Forms.GroupBox()
        Me.mskIdEmpleado = New System.Windows.Forms.MaskedTextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.mskIdServicio = New System.Windows.Forms.MaskedTextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmbServicio = New System.Windows.Forms.ComboBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtOtros = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.gbCuenta.SuspendLayout()
        Me.gbTipoPago.SuspendLayout()
        Me.gbPagoAgua.SuspendLayout()
        Me.gbServicios.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(764, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IdPago:"
        '
        'mskIdPago
        '
        Me.mskIdPago.Enabled = False
        Me.mskIdPago.Location = New System.Drawing.Point(844, 12)
        Me.mskIdPago.Mask = "0000000000"
        Me.mskIdPago.Name = "mskIdPago"
        Me.mskIdPago.Size = New System.Drawing.Size(69, 20)
        Me.mskIdPago.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(764, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha:"
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(839, 50)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(97, 20)
        Me.txtFecha.TabIndex = 3
        '
        'gbCuenta
        '
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
        Me.gbCuenta.Controls.Add(Me.cmbNombreCuenta)
        Me.gbCuenta.Controls.Add(Me.Label3)
        Me.gbCuenta.Location = New System.Drawing.Point(13, 9)
        Me.gbCuenta.Name = "gbCuenta"
        Me.gbCuenta.Size = New System.Drawing.Size(700, 148)
        Me.gbCuenta.TabIndex = 4
        Me.gbCuenta.TabStop = False
        Me.gbCuenta.Text = "Cuentas"
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
        'cmbNombreCuenta
        '
        Me.cmbNombreCuenta.Enabled = False
        Me.cmbNombreCuenta.FormattingEnabled = True
        Me.cmbNombreCuenta.Location = New System.Drawing.Point(96, 30)
        Me.cmbNombreCuenta.Name = "cmbNombreCuenta"
        Me.cmbNombreCuenta.Size = New System.Drawing.Size(121, 21)
        Me.cmbNombreCuenta.TabIndex = 2
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
        'gbTipoPago
        '
        Me.gbTipoPago.Controls.Add(Me.rbtServicio)
        Me.gbTipoPago.Controls.Add(Me.rbtAgua)
        Me.gbTipoPago.Location = New System.Drawing.Point(13, 163)
        Me.gbTipoPago.Name = "gbTipoPago"
        Me.gbTipoPago.Size = New System.Drawing.Size(96, 70)
        Me.gbTipoPago.TabIndex = 5
        Me.gbTipoPago.TabStop = False
        Me.gbTipoPago.Text = "Tipo de pago"
        '
        'rbtServicio
        '
        Me.rbtServicio.AutoSize = True
        Me.rbtServicio.Enabled = False
        Me.rbtServicio.Location = New System.Drawing.Point(7, 44)
        Me.rbtServicio.Name = "rbtServicio"
        Me.rbtServicio.Size = New System.Drawing.Size(63, 17)
        Me.rbtServicio.TabIndex = 1
        Me.rbtServicio.TabStop = True
        Me.rbtServicio.Text = "Servicio"
        Me.rbtServicio.UseVisualStyleBackColor = True
        '
        'rbtAgua
        '
        Me.rbtAgua.AutoSize = True
        Me.rbtAgua.Enabled = False
        Me.rbtAgua.Location = New System.Drawing.Point(7, 20)
        Me.rbtAgua.Name = "rbtAgua"
        Me.rbtAgua.Size = New System.Drawing.Size(50, 17)
        Me.rbtAgua.TabIndex = 0
        Me.rbtAgua.TabStop = True
        Me.rbtAgua.Text = "Agua"
        Me.rbtAgua.UseVisualStyleBackColor = True
        '
        'gbPagoAgua
        '
        Me.gbPagoAgua.Controls.Add(Me.txtDescuentoFinal)
        Me.gbPagoAgua.Controls.Add(Me.txtINFRAFinal)
        Me.gbPagoAgua.Controls.Add(Me.Label24)
        Me.gbPagoAgua.Controls.Add(Me.Label20)
        Me.gbPagoAgua.Controls.Add(Me.txtTARFinal)
        Me.gbPagoAgua.Controls.Add(Me.Label21)
        Me.gbPagoAgua.Controls.Add(Me.txtRecargoFinal)
        Me.gbPagoAgua.Controls.Add(Me.Label22)
        Me.gbPagoAgua.Controls.Add(Me.txtCFFinal)
        Me.gbPagoAgua.Controls.Add(Me.Label23)
        Me.gbPagoAgua.Controls.Add(Me.cmbMesFinal)
        Me.gbPagoAgua.Controls.Add(Me.Label19)
        Me.gbPagoAgua.Controls.Add(Me.cmbMesInicial)
        Me.gbPagoAgua.Controls.Add(Me.Label18)
        Me.gbPagoAgua.Controls.Add(Me.txtINFRA)
        Me.gbPagoAgua.Controls.Add(Me.Label17)
        Me.gbPagoAgua.Controls.Add(Me.txtTAR)
        Me.gbPagoAgua.Controls.Add(Me.Label16)
        Me.gbPagoAgua.Controls.Add(Me.txtRecargo)
        Me.gbPagoAgua.Controls.Add(Me.Label15)
        Me.gbPagoAgua.Controls.Add(Me.txtCF)
        Me.gbPagoAgua.Controls.Add(Me.Label14)
        Me.gbPagoAgua.Controls.Add(Me.cmbAñoTarifa)
        Me.gbPagoAgua.Controls.Add(Me.Label13)
        Me.gbPagoAgua.Controls.Add(Me.txtDescuento)
        Me.gbPagoAgua.Controls.Add(Me.Label12)
        Me.gbPagoAgua.Controls.Add(Me.mskIdSituacion)
        Me.gbPagoAgua.Controls.Add(Me.Label11)
        Me.gbPagoAgua.Controls.Add(Me.cmbSituacion)
        Me.gbPagoAgua.Controls.Add(Me.Label10)
        Me.gbPagoAgua.Location = New System.Drawing.Point(13, 239)
        Me.gbPagoAgua.Name = "gbPagoAgua"
        Me.gbPagoAgua.Size = New System.Drawing.Size(935, 180)
        Me.gbPagoAgua.TabIndex = 6
        Me.gbPagoAgua.TabStop = False
        Me.gbPagoAgua.Text = "Agua"
        Me.gbPagoAgua.Visible = False
        '
        'txtDescuentoFinal
        '
        Me.txtDescuentoFinal.Enabled = False
        Me.txtDescuentoFinal.Location = New System.Drawing.Point(826, 124)
        Me.txtDescuentoFinal.Name = "txtDescuentoFinal"
        Me.txtDescuentoFinal.Size = New System.Drawing.Size(97, 20)
        Me.txtDescuentoFinal.TabIndex = 32
        '
        'txtINFRAFinal
        '
        Me.txtINFRAFinal.Enabled = False
        Me.txtINFRAFinal.Location = New System.Drawing.Point(598, 124)
        Me.txtINFRAFinal.Name = "txtINFRAFinal"
        Me.txtINFRAFinal.Size = New System.Drawing.Size(97, 20)
        Me.txtINFRAFinal.TabIndex = 30
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(714, 122)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(106, 24)
        Me.Label24.TabIndex = 31
        Me.Label24.Text = "Descuento:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(521, 122)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 24)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "INFRA:"
        '
        'txtTARFinal
        '
        Me.txtTARFinal.Enabled = False
        Me.txtTARFinal.Location = New System.Drawing.Point(418, 124)
        Me.txtTARFinal.Name = "txtTARFinal"
        Me.txtTARFinal.Size = New System.Drawing.Size(97, 20)
        Me.txtTARFinal.TabIndex = 28
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(360, 124)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 24)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "TAR:"
        '
        'txtRecargoFinal
        '
        Me.txtRecargoFinal.Enabled = False
        Me.txtRecargoFinal.Location = New System.Drawing.Point(257, 126)
        Me.txtRecargoFinal.Name = "txtRecargoFinal"
        Me.txtRecargoFinal.Size = New System.Drawing.Size(97, 20)
        Me.txtRecargoFinal.TabIndex = 26
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(164, 124)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(87, 24)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "Recargo:"
        '
        'txtCFFinal
        '
        Me.txtCFFinal.Enabled = False
        Me.txtCFFinal.Location = New System.Drawing.Point(61, 126)
        Me.txtCFFinal.Name = "txtCFFinal"
        Me.txtCFFinal.Size = New System.Drawing.Size(97, 20)
        Me.txtCFFinal.TabIndex = 24
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(15, 126)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 24)
        Me.Label23.TabIndex = 23
        Me.Label23.Text = "CF:"
        '
        'cmbMesFinal
        '
        Me.cmbMesFinal.FormattingEnabled = True
        Me.cmbMesFinal.Location = New System.Drawing.Point(340, 86)
        Me.cmbMesFinal.Name = "cmbMesFinal"
        Me.cmbMesFinal.Size = New System.Drawing.Size(121, 21)
        Me.cmbMesFinal.TabIndex = 22
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(245, 86)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 24)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Mes final:"
        '
        'cmbMesInicial
        '
        Me.cmbMesInicial.FormattingEnabled = True
        Me.cmbMesInicial.Location = New System.Drawing.Point(109, 89)
        Me.cmbMesInicial.Name = "cmbMesInicial"
        Me.cmbMesInicial.Size = New System.Drawing.Size(121, 21)
        Me.cmbMesInicial.TabIndex = 20
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 89)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 24)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Mes inicial:"
        '
        'txtINFRA
        '
        Me.txtINFRA.Enabled = False
        Me.txtINFRA.Location = New System.Drawing.Point(828, 50)
        Me.txtINFRA.Name = "txtINFRA"
        Me.txtINFRA.Size = New System.Drawing.Size(97, 20)
        Me.txtINFRA.TabIndex = 18
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(751, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 24)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "INFRA:"
        '
        'txtTAR
        '
        Me.txtTAR.Enabled = False
        Me.txtTAR.Location = New System.Drawing.Point(648, 50)
        Me.txtTAR.Name = "txtTAR"
        Me.txtTAR.Size = New System.Drawing.Size(97, 20)
        Me.txtTAR.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(590, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 24)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "TAR:"
        '
        'txtRecargo
        '
        Me.txtRecargo.Enabled = False
        Me.txtRecargo.Location = New System.Drawing.Point(487, 52)
        Me.txtRecargo.Name = "txtRecargo"
        Me.txtRecargo.Size = New System.Drawing.Size(97, 20)
        Me.txtRecargo.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(394, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 24)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Recargo:"
        '
        'txtCF
        '
        Me.txtCF.Enabled = False
        Me.txtCF.Location = New System.Drawing.Point(291, 52)
        Me.txtCF.Name = "txtCF"
        Me.txtCF.Size = New System.Drawing.Size(97, 20)
        Me.txtCF.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(245, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 24)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "CF:"
        '
        'cmbAñoTarifa
        '
        Me.cmbAñoTarifa.FormattingEnabled = True
        Me.cmbAñoTarifa.Location = New System.Drawing.Point(104, 55)
        Me.cmbAñoTarifa.Name = "cmbAñoTarifa"
        Me.cmbAñoTarifa.Size = New System.Drawing.Size(121, 21)
        Me.cmbAñoTarifa.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 24)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "AñoTarifa:"
        '
        'txtDescuento
        '
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Location = New System.Drawing.Point(557, 16)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(97, 20)
        Me.txtDescuento.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(445, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 24)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Descuento:"
        '
        'mskIdSituacion
        '
        Me.mskIdSituacion.Enabled = False
        Me.mskIdSituacion.Location = New System.Drawing.Point(358, 17)
        Me.mskIdSituacion.Mask = "0000000000"
        Me.mskIdSituacion.Name = "mskIdSituacion"
        Me.mskIdSituacion.Size = New System.Drawing.Size(69, 20)
        Me.mskIdSituacion.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(245, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 24)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "IdSituación:"
        '
        'cmbSituacion
        '
        Me.cmbSituacion.FormattingEnabled = True
        Me.cmbSituacion.Location = New System.Drawing.Point(104, 16)
        Me.cmbSituacion.Name = "cmbSituacion"
        Me.cmbSituacion.Size = New System.Drawing.Size(121, 21)
        Me.cmbSituacion.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 24)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Situación:"
        '
        'gbServicios
        '
        Me.gbServicios.Controls.Add(Me.mskIdEmpleado)
        Me.gbServicios.Controls.Add(Me.Label31)
        Me.gbServicios.Controls.Add(Me.Label30)
        Me.gbServicios.Controls.Add(Me.cmbEmpleado)
        Me.gbServicios.Controls.Add(Me.txtPrecio)
        Me.gbServicios.Controls.Add(Me.Label27)
        Me.gbServicios.Controls.Add(Me.mskIdServicio)
        Me.gbServicios.Controls.Add(Me.Label26)
        Me.gbServicios.Controls.Add(Me.Label25)
        Me.gbServicios.Controls.Add(Me.cmbServicio)
        Me.gbServicios.Location = New System.Drawing.Point(181, 160)
        Me.gbServicios.Name = "gbServicios"
        Me.gbServicios.Size = New System.Drawing.Size(477, 125)
        Me.gbServicios.TabIndex = 33
        Me.gbServicios.TabStop = False
        Me.gbServicios.Text = "Servicios"
        Me.gbServicios.Visible = False
        '
        'mskIdEmpleado
        '
        Me.mskIdEmpleado.Enabled = False
        Me.mskIdEmpleado.Location = New System.Drawing.Point(397, 20)
        Me.mskIdEmpleado.Mask = "0000000000"
        Me.mskIdEmpleado.Name = "mskIdEmpleado"
        Me.mskIdEmpleado.Size = New System.Drawing.Size(68, 20)
        Me.mskIdEmpleado.TabIndex = 24
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(266, 19)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(117, 24)
        Me.Label31.TabIndex = 23
        Me.Label31.Text = "IdEmpleado:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(6, 20)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(102, 24)
        Me.Label30.TabIndex = 22
        Me.Label30.Text = "Empleado:"
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.FormattingEnabled = True
        Me.cmbEmpleado.Location = New System.Drawing.Point(115, 23)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(121, 21)
        Me.cmbEmpleado.TabIndex = 21
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(89, 88)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(97, 20)
        Me.txtPrecio.TabIndex = 20
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(4, 84)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(69, 24)
        Me.Label27.TabIndex = 19
        Me.Label27.Text = "Precio:"
        '
        'mskIdServicio
        '
        Me.mskIdServicio.Enabled = False
        Me.mskIdServicio.Location = New System.Drawing.Point(341, 54)
        Me.mskIdServicio.Mask = "0000000000"
        Me.mskIdServicio.Name = "mskIdServicio"
        Me.mskIdServicio.Size = New System.Drawing.Size(68, 20)
        Me.mskIdServicio.TabIndex = 18
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(238, 53)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(97, 24)
        Me.Label26.TabIndex = 17
        Me.Label26.Text = "IdServicio:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(4, 53)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(82, 24)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "Servicio:"
        '
        'cmbServicio
        '
        Me.cmbServicio.FormattingEnabled = True
        Me.cmbServicio.Location = New System.Drawing.Point(92, 53)
        Me.cmbServicio.Name = "cmbServicio"
        Me.cmbServicio.Size = New System.Drawing.Size(121, 21)
        Me.cmbServicio.TabIndex = 0
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(37, 486)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Location = New System.Drawing.Point(249, 486)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabar.TabIndex = 8
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.Location = New System.Drawing.Point(489, 486)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 9
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(758, 486)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtOtros
        '
        Me.txtOtros.Enabled = False
        Me.txtOtros.Location = New System.Drawing.Point(96, 430)
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.Size = New System.Drawing.Size(97, 20)
        Me.txtOtros.TabIndex = 28
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(20, 430)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(70, 24)
        Me.Label28.TabIndex = 27
        Me.Label28.Text = "Otros$:"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(377, 430)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(97, 20)
        Me.txtTotal.TabIndex = 30
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(315, 428)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(56, 24)
        Me.Label29.TabIndex = 29
        Me.Label29.Text = "Total:"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(545, 430)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 33
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.PrintToFile = True
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 532)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.gbServicios)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txtOtros)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.gbPagoAgua)
        Me.Controls.Add(Me.gbTipoPago)
        Me.Controls.Add(Me.gbCuenta)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mskIdPago)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos"
        Me.gbCuenta.ResumeLayout(False)
        Me.gbCuenta.PerformLayout()
        Me.gbTipoPago.ResumeLayout(False)
        Me.gbTipoPago.PerformLayout()
        Me.gbPagoAgua.ResumeLayout(False)
        Me.gbPagoAgua.PerformLayout()
        Me.gbServicios.ResumeLayout(False)
        Me.gbServicios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents mskIdPago As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents gbCuenta As GroupBox
    Friend WithEvents cmbNombreCuenta As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mskIdCuenta As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mskIdCalle As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents mskNumeroExterior As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents mskNumeroInterior As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents mskUltimoPagoMes As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents mskUltimoPagoAño As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents gbTipoPago As GroupBox
    Friend WithEvents rbtServicio As RadioButton
    Friend WithEvents rbtAgua As RadioButton
    Friend WithEvents gbPagoAgua As GroupBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents mskIdSituacion As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbSituacion As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCF As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbAñoTarifa As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTAR As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtRecargo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtINFRAFinal As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtTARFinal As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtRecargoFinal As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtCFFinal As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents cmbMesFinal As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbMesInicial As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtINFRA As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents gbServicios As GroupBox
    Friend WithEvents Label25 As Label
    Friend WithEvents cmbServicio As ComboBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents mskIdServicio As MaskedTextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtOtros As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtDescuentoFinal As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents cmbEmpleado As ComboBox
    Friend WithEvents mskIdEmpleado As MaskedTextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
