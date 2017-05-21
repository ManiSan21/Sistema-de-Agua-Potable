Imports System.Data.SqlClient
Public Class frmPagos
    Dim conexion As New SqlConnection("Data Source = DESKTOP-B3IP6AD\MANI; Initial Catalog = 'SistemaAguaPotable'; Integrated Security = true")
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Dim mesInicial As Integer
    Dim mesFinal As Integer
    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        Dim r As String
        r = "Select * From cuentas"
        comando.CommandText = r
        lector = comando.ExecuteReader
        While lector.Read
            cmbNombreCuenta.Items.Add(lector(2))
        End While
        lector.Close()
        r = "Select * From situacion"
        comando.CommandText = r
        lector = comando.ExecuteReader
        While lector.Read
            cmbSituacion.Items.Add(lector(1))
        End While
        lector.Close()
        r = "Select * From tarifas"
        comando.CommandText = r
        lector = comando.ExecuteReader
        While lector.Read
            cmbAñoTarifa.Items.Add(lector(1))
        End While
        lector.Close()
        r = "Select * From servicios"
        comando.CommandText = r
        lector = comando.ExecuteReader
        While lector.Read
            cmbServicio.Items.Add(lector(1))
        End While
        lector.Close()
        r = "Select * From empleados"
        comando.CommandText = r
        lector = comando.ExecuteReader
        While lector.Read
            cmbEmpleado.Items.Add(lector(1))
        End While
        lector.Close()
        txtOtros.Text = "0"
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer
        comando.CommandText = "Select count (*) From pago"
        n = comando.ExecuteScalar + 1
        mskIdPago.Text = n
        txtFecha.Text = System.DateTime.Today
        cmbNombreCuenta.Enabled = True
        rbtAgua.Enabled = True
        rbtServicio.Enabled = True
        btnGrabar.Enabled = True
        btnImprimir.Enabled = True
        btnNuevo.Enabled = False
        'cmbEmpleado.Text = ""
        'cmbServicio.Text = ""
    End Sub

    Private Sub rbtAgua_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAgua.CheckedChanged
        If rbtAgua.Checked Then
            gbPagoAgua.Visible = True
            txtOtros.Enabled = True
        Else
            gbPagoAgua.Visible = False
            txtOtros.Enabled = False
        End If
    End Sub

    Private Sub rbtServicio_CheckedChanged(sender As Object, e As EventArgs) Handles rbtServicio.CheckedChanged
        If rbtServicio.Checked Then
            gbServicios.Visible = True
            txtOtros.Enabled = True
        Else
            gbServicios.Visible = False
            txtOtros.Enabled = False
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()
        cmbAñoTarifa.Items.Clear()
        cmbNombreCuenta.Items.Clear()
        cmbServicio.Items.Clear()
        cmbSituacion.Items.Clear()
        mskIdPago.Clear()
        txtFecha.Clear()
        mskIdCuenta.Clear()
        mskIdCalle.Clear()
        mskNumeroExterior.Clear()
        mskNumeroInterior.Clear()
        mskUltimoPagoAño.Clear()
        mskUltimoPagoMes.Clear()
        mskIdSituacion.Clear()
        txtDescuento.Clear()
        txtCF.Clear()
        txtRecargo.Clear()
        txtTAR.Clear()
        txtINFRA.Clear()
        txtCFFinal.Clear()
        txtRecargoFinal.Clear()
        txtTARFinal.Clear()
        txtINFRAFinal.Clear()
        txtDescuentoFinal.Clear()
        txtOtros.Clear()
        txtTotal.Clear()
        btnNuevo.Enabled = True
        btnGrabar.Enabled = False
        btnImprimir.Enabled = False
        Me.Close()
    End Sub

    Private Sub cmbNombreCuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNombreCuenta.SelectedIndexChanged
        Dim r As String
        r = "Select * From cuentas Where Nombre='" & cmbNombreCuenta.Text & "'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        lector.Read()
        mskIdCuenta.Text = lector(0)
        mskIdCalle.Text = lector(1)
        mskNumeroExterior.Text = lector(3)
        mskNumeroInterior.Text = lector(4)
        mskUltimoPagoAño.Text = Year(lector(6))
        mskUltimoPagoMes.Text = Month(lector(7))
        mesInicial = Month(lector(7))
        lector.Close()
        cmbMesInicial.Items.Clear()
        cmbMesFinal.Items.Clear()
    End Sub

    Private Sub cmbSituacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSituacion.SelectedIndexChanged
        Dim r As String
        r = "Select * From situacion Where Descripcion='" & cmbSituacion.Text & "'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        lector.Read()
        mskIdSituacion.Text = lector(0)
        txtDescuento.Text = lector(2)
        lector.Close()
    End Sub

    Private Sub cmbAñoTarifa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAñoTarifa.SelectedIndexChanged
        Dim r As String
        r = "Select * From tarifas Where Año='" & cmbAñoTarifa.Text & "'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        lector.Read()
        txtCF.Text = lector(2)
        txtRecargo.Text = lector(3)
        txtTAR.Text = lector(4)
        txtINFRA.Text = lector(5)
        lector.Close()

        Dim meses As String() = {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"}
        If mesInicial = 12 And CInt(cmbAñoTarifa.Text) <> Year(System.DateTime.Today) Then
            For x = mesInicial - 1 To mesInicial - 1
                cmbMesInicial.Items.Add(meses(x))
            Next
            For x = mesInicial - 1 To 11
                cmbMesFinal.Items.Add(meses(x))
            Next
        ElseIf mesInicial = 12 And CInt(cmbAñoTarifa.Text) = Year(System.DateTime.Today) Then
            mesInicial = 0
            For x = mesInicial To mesInicial
                cmbMesInicial.Items.Add(meses(x))
            Next
            For x = mesInicial To 11
                cmbMesFinal.Items.Add(meses(x))
            Next
            mesInicial += 1
        ElseIf CInt(cmbAñoTarifa.Text) <> Year(System.DateTime.Today) Then
            For x = mesInicial To mesInicial
                cmbMesInicial.Items.Add(meses(x))
            Next
            For x = mesInicial To 11
                cmbMesFinal.Items.Add(meses(x))
            Next
            mesInicial += 1
        Else
            For x = mesInicial To mesInicial
                cmbMesInicial.Items.Add(meses(x))
            Next
            For x = mesInicial To 11
                cmbMesFinal.Items.Add(meses(x))
            Next
            mesInicial += 1
        End If
    End Sub

    Private Sub cmbServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServicio.SelectedIndexChanged
        Dim r As String
        r = "Select * From servicios Where Descripcion='" & cmbServicio.Text & "'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        lector.Read()
        mskIdServicio.Text = lector(0)
        txtPrecio.Text = lector(2)
        lector.Close()
    End Sub

    Private Sub cmbMesInicial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMesInicial.SelectedIndexChanged

    End Sub

    Private Sub cmbMesFinal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMesFinal.SelectedIndexChanged
        Dim fechaSistema As Date = System.DateTime.Now
        If cmbMesFinal.Text = "ENERO" Then
            mesFinal = 1
        ElseIf cmbMesFinal.Text = "FEBRERO" Then
            mesFinal = 2
        ElseIf cmbMesFinal.Text = "MARZO" Then
            mesFinal = 3
        ElseIf cmbMesFinal.Text = "ABRIL" Then
            mesFinal = 4
        ElseIf cmbMesFinal.Text = "MAYO" Then
            mesFinal = 5
        ElseIf cmbMesFinal.Text = "JUNIO" Then
            mesFinal = 6
        ElseIf cmbMesFinal.Text = "JULIO" Then
            mesFinal = 7
        ElseIf cmbMesFinal.Text = "AGOSTO" Then
            mesFinal = 8
        ElseIf cmbMesFinal.Text = "SEPTIEMBRE" Then
            mesFinal = 9
        ElseIf cmbMesFinal.Text = "OCTUBRE" Then
            mesFinal = 10
        ElseIf cmbMesFinal.Text = "NOVIEMBRE" Then
            mesFinal = 11
        ElseIf cmbMesFinal.Text = "DICIEMBRE" Then
            mesFinal = 12
        End If
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim c0 As Integer
        Dim c1 As Integer
        Dim c2 As Date
        Dim c3 As String
        Dim c4 As Double
        Dim c5 As Double
        Dim otros As String
        Dim total As String
        Dim cf As Double
        Dim tar As Double
        Dim infra As Double
        Dim infraFin As String
        Dim tarFin As String
        Dim cfFin As String
        Dim rec As Double
        Dim des As Double
        Dim recargos As String
        Dim descuentos As String
        Dim fechaSistema As Date = System.DateTime.Now
        Dim fechaFinal As String = CStr(fechaSistema.Day) + "/" + CStr(mesFinal) + "/" + CStr(fechaSistema.Year)
        Dim fechaAño As String = CStr(fechaSistema.Day) + "/" + CStr(fechaSistema.Month) + "/" + cmbAñoTarifa.Text
        Dim r As String

        c0 = CInt(mskIdPago.Text)
        c1 = CInt(mskIdCuenta.Text)
        c2 = txtFecha.Text
        If rbtAgua.Checked Then
            c3 = "AGUA"
        ElseIf rbtServicio.Checked Then
            c3 = "SERVICIO"
        End If
        c4 = CDbl(txtOtros.Text)
        If rbtAgua.Checked Then
            c5 = CDbl(txtTotal.Text)
            rec = CDbl(txtRecargoFinal.Text)
            des = CDbl(txtDescuentoFinal.Text)
            cf = CDbl(txtCFFinal.Text)
            tar = CDbl(txtTARFinal.Text)
            infra = CDbl(txtINFRAFinal.Text)

            cfFin = Replace(cf, ",", ".")
            tarFin = Replace(tar, ",", ".")
            infraFin = Replace(infra, ",", ".")
            otros = Replace(c4, ",", ".")
            total = Replace(c5, ",", ".")
            recargos = Replace(rec, ",", ".")
            descuentos = Replace(des, ",", ".")

            r = "Insert Into pago(IdPago, IdCuenta, Fecha, Tipo, Otros, Total) values(" & c0 & "," & c1 & ",'" & c2 & "','" & c3 & "'," & otros & "," & total & ")"
            comando.CommandText = r
            comando.ExecuteNonQuery()

            r = "Insert Into agua(IdPago, IdSituacion, IdTarifa, MInicial, MFinal, Descuento, Recargo, CF, TAR, INFRA) values(" & c0 & "," & CInt(mskIdSituacion.Text) & "," & CInt(cmbAñoTarifa.Text) & ",'" & cmbMesInicial.Text & "','" & cmbMesFinal.Text & "'," & descuentos & "," & recargos & "," & cfFin & "," & tarFin & "," & infraFin & ")"
            comando.CommandText = r
            comando.ExecuteNonQuery()

            If mesInicial = 1 And mesFinal = 12 Then
                r = "Update cuentas Set UltimoPagoA='" & CDate(fechaAño) & "', UltimoPagoM='" & CDate(fechaFinal) & "' Where IdCuenta=" & c1 & ""
                comando.CommandText = r
                comando.ExecuteNonQuery()
            Else
                r = "Update cuentas Set UltimoPagoA='" & CDate(fechaAño) & "', UltimoPagoM='" & CDate(fechaFinal) & "' Where IdCuenta=" & c1 & ""
                comando.CommandText = r
                comando.ExecuteNonQuery()
            End If
        ElseIf rbtServicio.Checked Then
            Dim idServicio As Integer = CInt(mskIdServicio.Text)
            Dim idPago As Integer = CInt(mskIdPago.Text)
            Dim idEmpleado As Integer = CInt(mskIdEmpleado.Text)
            Dim precio As Double = CDbl(txtPrecio.Text)
            Dim precioFin As String
            btnCalcular.Enabled = False
            c4 = CDbl(txtOtros.Text)
            c5 = CDbl(txtPrecio.Text)
            otros = Replace(c4, ",", ".")
            total = Replace(c5, ",", ".")
            precioFin = Replace(precio, ",", ".")

            r = "Insert Into pago(IdPago, IdCuenta, Fecha, Tipo, Otros, Total) values(" & c0 & "," & c1 & ",'" & c2 & "','" & c3 & "'," & otros & "," & total & ")"
            comando.CommandText = r
            comando.ExecuteNonQuery()

            r = "Insert Into serviciosAtendidos(IdPago, IdServicio, IdEmpleado, Precio) values(" & idPago & "," & idServicio & "," & idEmpleado & "," & precioFin & ")"
            comando.CommandText = r
            comando.ExecuteNonQuery()
        End If


        mskIdPago.Clear()
        txtFecha.Clear()
        mskIdCuenta.Clear()
        mskIdCalle.Clear()
        mskNumeroExterior.Clear()
        mskNumeroInterior.Clear()
        mskUltimoPagoAño.Clear()
        mskUltimoPagoMes.Clear()
        mskIdSituacion.Clear()
        txtDescuento.Clear()
        txtCF.Clear()
        txtRecargo.Clear()
        txtTAR.Clear()
        txtINFRA.Clear()
        txtCFFinal.Clear()
        txtRecargoFinal.Clear()
        txtTARFinal.Clear()
        txtINFRAFinal.Clear()
        txtDescuentoFinal.Clear()
        txtOtros.Text = "0"
        txtTotal.Clear()
        mskIdServicio.Clear()
        txtPrecio.Clear()
        cmbNombreCuenta.Text = ""
        cmbSituacion.Text = ""
        cmbAñoTarifa.Text = ""
        cmbMesInicial.Text = ""
        cmbMesFinal.Text = ""
        'cmbEmpleado.Text = ""
        'cmbServicio.Text = ""
        cmbMesFinal.Items.Clear()
        cmbMesInicial.Items.Clear()
        btnCalcular.Enabled = True
        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        btnImprimir.Enabled = False
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim fechaSistema As Date = System.DateTime.Now
        Dim añoSistema As Integer
        Dim numMeses As Integer
        Dim descuento As Double
        Dim desCF As Double
        Dim desTAR As Double
        Dim desInfra As Double
        Dim cf As Double
        Dim recargo As Double
        Dim tar As Double
        Dim infra As Double

        añoSistema = Year(fechaSistema)

        For x = mesInicial To mesFinal
            numMeses += 1
        Next
        comando.CommandText = "Select * From tarifas Where Año='" & cmbAñoTarifa.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()

        If rbtAgua.Checked Then
            If cmbAñoTarifa.Text <> añoSistema Then
                cf = ((CDbl(txtCF.Text) / 12) * numMeses)
                recargo = (CDbl(txtRecargo.Text) / 12) * numMeses
                tar = (CDbl(txtTAR.Text) / 12) * numMeses
                infra = (CDbl(txtINFRA.Text) / 12) * numMeses

                txtDescuentoFinal.Text = "0"
                txtCFFinal.Text = cf
                txtRecargoFinal.Text = recargo
                txtTARFinal.Text = tar
                txtINFRAFinal.Text = infra

                txtTotal.Text = (cf + recargo + tar + infra + CDbl(txtOtros.Text))
                lector.Close()
            ElseIf cmbAñoTarifa.Text = añoSistema Then
                desCF = ((CDbl(txtCF.Text) / 12) * numMeses) * CDbl(txtDescuento.Text)
                desTAR = ((CDbl(txtTAR.Text) / 12) * numMeses) * CDbl(txtDescuento.Text)
                desInfra = ((CDbl(txtINFRA.Text) / 12) * numMeses) * CDbl(txtDescuento.Text)
                cf = ((CDbl(txtCF.Text) / 12) * numMeses) - desCF
                tar = ((CDbl(txtTAR.Text) / 12) * numMeses) - desTAR
                infra = ((CDbl(txtINFRA.Text) / 12) * numMeses) - desInfra
                descuento = desCF + desTAR + desInfra

                txtCFFinal.Text = cf
                txtRecargoFinal.Text = "0"
                txtTARFinal.Text = tar
                txtINFRAFinal.Text = infra
                txtDescuentoFinal.Text = descuento

                txtTotal.Text = (cf + tar + infra + CDbl(txtOtros.Text))
                lector.Close()
            End If
        ElseIf rbtServicio.Checked Then
            txtTotal.Text = CStr(CDbl(txtOtros.Text) + CDbl(txtPrecio.Text))
            lector.Close()
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

    End Sub

    Private Sub cmbEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpleado.SelectedIndexChanged
        If rbtServicio.Checked Then
            comando.CommandText = "Select * From empleados Where Nombre='" & cmbEmpleado.Text & "'"
            lector = comando.ExecuteReader()
            lector.Read()
            mskIdEmpleado.Text = lector(0)
            lector.Close()
        End If
    End Sub

    Private Sub txtOtros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOtros.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(numerosValidos, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(numerosValidos, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
End Class