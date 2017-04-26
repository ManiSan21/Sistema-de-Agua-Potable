Imports System.Data.SqlClient
Public Class frmConsultaPagos
    Dim conexion As New SqlConnection("Data Source = DESKTOP-B3IP6AD\MANI; Initial Catalog = 'SistemaAguaPotable'; Integrated Security = true")
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Private Sub frmConsultaPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando.CommandText = "Select * From pago"
        lector = comando.ExecuteReader
        While lector.Read
            cmbIdPagoConsulta.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub rbtIdPago_CheckedChanged(sender As Object, e As EventArgs) Handles rbtIdPago.CheckedChanged
        If rbtIdPago.Checked Then
            gbCuenta.Visible = True
            cmbIdPagoConsulta.Visible = True
        Else
            gbCuenta.Visible = False
            cmbIdPagoConsulta.Visible = False
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        mskIdCuenta.Clear()
        mskNombreCuenta.Clear()
        mskIdCalle.Clear()
        mskNumeroExterior.Clear()
        mskNumeroInterior.Clear()
        mskUltimoPagoAño.Clear()
        mskUltimoPagoMes.Clear()
        dgvConsultaPago.Rows.Clear()
        conexion.Close()
        Me.Close()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim r As String
        Dim idCuenta As Integer
        Dim otros As String
        Dim total As String
        If rbtIdPago.Checked Then
            dgvConsultaPago.Rows.Clear()
            r = "Select * From pago Where IdPago=" & CInt(cmbIdPagoConsulta.Text) & ""
            comando.CommandText = r
            lector = comando.ExecuteReader
            lector.Read()
            idCuenta = lector(1)
            lector.Close()

            r = "Select cuentas.IdCuenta, cuentas.IdCalle, cuentas.Nombre, cuentas.NoExt, cuentas.NoInt, cuentas.UltimoPagoA, cuentas.UltimoPagoM From cuentas Where IdCuenta=" & idCuenta & ""
            comando.CommandText = r
            lector = comando.ExecuteReader
            lector.Read()
            mskIdCuenta.Text = lector(0)
            mskIdCalle.Text = lector(1)
            mskNombreCuenta.Text = lector(2)
            mskNumeroExterior.Text = lector(3)
            mskNumeroInterior.Text = lector(4)
            mskUltimoPagoAño.Text = lector(5)
            mskUltimoPagoMes.Text = lector(6)
            lector.Close()

            r = "Select pago.IdPago, pago.IdCuenta, pago.Fecha, pago.Tipo, pago.Otros, pago.Total From pago Where IdPago=" & CInt(cmbIdPagoConsulta.Text) & ""
            comando.CommandText = r
            lector = comando.ExecuteReader
            While lector.Read
                otros = Replace(lector(4), ".", ",")
                total = Replace(lector(5), ".", ",")
                dgvConsultaPago.Rows.Add(lector(0), lector(1), lector(2), lector(3), otros, total)
            End While
            lector.Close()
        ElseIf rbtTipoDePago.Checked Then
            dgvConsultaPago.Rows.Clear()
            r = "Select pago.IdPago, pago.IdCuenta, pago.Fecha, pago.Tipo, pago.Otros, pago.Total From pago Where Tipo='" & cmbConsultaTipoDePago.Text & "'"
            comando.CommandText = r
            lector = comando.ExecuteReader
            While lector.Read
                otros = Replace(lector(4), ".", ",")
                total = Replace(lector(5), ".", ",")
                dgvConsultaPago.Rows.Add(lector(0), lector(1), lector(2), lector(3), otros, total)
            End While
            lector.Close()
        End If
    End Sub

    Private Sub rbtTipoDePago_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTipoDePago.CheckedChanged
        If rbtTipoDePago.Checked Then
            cmbConsultaTipoDePago.Visible = True
        Else
            cmbConsultaTipoDePago.Visible = False
        End If
    End Sub
End Class