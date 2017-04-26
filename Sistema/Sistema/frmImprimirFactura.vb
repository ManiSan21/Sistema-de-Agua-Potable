Imports System.Data.SqlClient
Public Class frmImprimirFactura
    Dim conexion As New SqlConnection("Data Source = DESKTOP-B3IP6AD\MANI; Initial Catalog = 'SistemaAguaPotable'; Integrated Security = true")
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Private Sub frmImprimirFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        Dim pagos As New frmPagos
        Dim fechaSistema As Date = System.DateTime.Now
        Dim fechaAño As String = CStr(fechaSistema.Year)

        comando.CommandText = "Select * From calles Where IdCalle='" & pagos.mskIdCalle.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtNombreCuentaImpresion.Text = pagos.cmbNombreCuenta.Text
        txtIdCuentaImpresion.Text = pagos.mskIdCuenta.Text
        txtDomicilioImpresion.Text = lector(1) + " "
        lector.Close()
        comando.CommandText = "Select * From cuentas Where IdCuenta='" & pagos.mskIdCuenta.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtDomicilioImpresion.Text = txtDomicilioImpresion.Text + lector(3)
        lector.Close()
        comando.CommandText = "Select * From agua Where IdPago='" & pagos.mskIdPago.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtMesInicialImpresion.Text = lector(3)
        txtMesFinalImpresion.Text = lector(4)
        txtAñoPagoImpresion.Text = fechaAño
        txtSituacion.Text = pagos.cmbSituacion.Text
        txtDescuentoImpresion.Text = pagos.txtDescuentoFinal.Text
        txtRecargoImpresion.Text = pagos.txtRecargoFinal.Text
        txtTARImpresion.Text = pagos.txtTARFinal.Text
        txtINFRAImpresion.Text = pagos.txtINFRAFinal.Text
        txtOtrosImpresion.Text = pagos.txtOtros.Text
        txtTotalImpresion.Text = pagos.txtTotal.Text
        lector.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        conexion.Close()
    End Sub
End Class