Imports System.Data.SqlClient
Public Class frmGastosRealizados
    Dim conexion As New SqlConnection("Data Source = DESKTOP-B3IP6AD\MANI; Initial Catalog = 'SistemaAguaPotable'; Integrated Security = true")
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Private Sub frmGastosRealizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando.CommandText = "Select * From empleados"
        lector = comando.ExecuteReader
        While lector.Read
            cmbEmpleado.Items.Add(lector(1))
            cmbEmpleadoConsulta.Items.Add(lector(1))
        End While
        lector.Close()

        comando.CommandText = "Select * From gastos"
        lector = comando.ExecuteReader
        While lector.Read
            cmbConceptoGasto.Items.Add(lector(1))
            cmbConceptoConsulta.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub rbtConceptoConsulta_CheckedChanged(sender As Object, e As EventArgs) Handles rbtConceptoConsulta.CheckedChanged
        If rbtConceptoConsulta.Checked Then
            cmbConceptoConsulta.Visible = True
        Else
            cmbConceptoConsulta.Visible = False
        End If

    End Sub

    Private Sub rbtEmpleadoConsulta_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEmpleadoConsulta.CheckedChanged
        If rbtEmpleadoConsulta.Checked Then
            cmbEmpleadoConsulta.Visible = True
        Else
            cmbEmpleadoConsulta.Visible = False
        End If
    End Sub

    Private Sub rbtFechaConsulta_CheckedChanged(sender As Object, e As EventArgs) Handles rbtFechaConsulta.CheckedChanged
        If rbtFechaConsulta.Checked Then
            dtpFechaConsulta.Visible = True
        Else
            dtpFechaConsulta.Visible = False
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        comando.CommandText = "Select count (*) From gastosRealizados"
        Dim n As Integer
        n = comando.ExecuteScalar + 1
        mskIdGastoR.Text = n
        dtpFecha.Enabled = True
        cmbEmpleado.Enabled = True
        mskIdEmpleado.Enabled = True
        mskDomicilioEmpleado.Enabled = True
        mskTelefonoEmpleado.Enabled = True
        cmbConceptoGasto.Enabled = True
        mskIdGasto.Enabled = True
        mskImporte.Enabled = True
        mskObservaciones.Enabled = True
        btnGrabar.Enabled = True
        btnNuevo.Enabled = False
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim c1 As Integer
        Dim c2 As Integer
        Dim c3 As Integer
        Dim c4 As Date
        Dim c5 As Double
        Dim c6 As String
        Dim r As String

        c1 = Val(mskIdGastoR.Text)
        c2 = Val(mskIdEmpleado.Text)
        c3 = Val(mskIdGasto.Text)
        c4 = dtpFecha.Value.Date
        c5 = CDbl(mskImporte.Text)
        c6 = mskObservaciones.Text

        r = "Insert into gastosRealizados (IdGastoR, IdEmpleado, IdGasto, Fecha, Importe, Observaciones) values(" & c1 & "," & c2 & "," & c3 & ",'" & c4 & "'," & c5 & ",'" & c6 & "')"
        comando.CommandText = r
        comando.ExecuteNonQuery()

        btnNuevo.Enabled = True
        btnGrabar.Enabled = False
        dtpFecha.Enabled = False
        cmbEmpleado.Enabled = False
        mskIdEmpleado.Enabled = False
        mskDomicilioEmpleado.Enabled = False
        mskTelefonoEmpleado.Enabled = False
        cmbConceptoGasto.Enabled = False
        mskIdGasto.Enabled = False
        mskImporte.Enabled = False
        mskObservaciones.Enabled = False

        'Limpia controles
        mskIdEmpleado.Text = " "
        mskDomicilioEmpleado.Text = " "
        mskTelefonoEmpleado.Text = " "
        cmbEmpleado.Text = " "
        cmbConceptoGasto.Text = " "
        mskIdGasto.Text = " "
        mskImporte.Text = " "
        mskObservaciones.Text = " "
    End Sub

    Private Sub cmbConceptoGasto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConceptoGasto.SelectedIndexChanged
        Dim r As String
        r = "Select * From gastos Where Concepto='" & cmbConceptoGasto.Text & "'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        lector.Read()
        mskIdGasto.Text = lector(0)
        lector.Close()
    End Sub

    Private Sub cmbEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpleado.SelectedIndexChanged
        Dim r As String
        r = "Select * From empleados Where Nombre='" & cmbEmpleado.Text & "'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        lector.Read()
        mskIdEmpleado.Text = lector(0)
        mskDomicilioEmpleado.Text = lector(2)
        mskTelefonoEmpleado.Text = lector(5)
        lector.Close()
    End Sub

    Private Sub btnAceptarConsulta_Click(sender As Object, e As EventArgs) Handles btnAceptarConsulta.Click
        Dim r As String
        If rbtTodos.Checked Then
            dgvConsultas.Rows.Clear()
            r = "Select gastosRealizados.IdGastoR, empleados.IdEmpleado, gastos.IdGasto,gastosRealizados.Fecha, empleados.Nombre, gastos.Concepto, gastosRealizados.Importe, gastosRealizados.Observaciones from gastosRealizados INNER JOIN empleados ON gastosRealizados.IdEmpleado = empleados.IdEmpleado INNER JOIN gastos ON gastosRealizados.IdGasto = gastos.IdGasto"
            comando.CommandText = r
            lector = comando.ExecuteReader
            While lector.Read
                dgvConsultas.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7))
            End While
            lector.Close()
        ElseIf rbtFechaConsulta.Checked Then
            dgvConsultas.Rows.Clear()
            r = "Select gastosRealizados.IdGastoR, empleados.IdEmpleado, gastos.IdGasto,gastosRealizados.Fecha, empleados.Nombre, gastos.Concepto, gastosRealizados.Importe, gastosRealizados.Observaciones from gastosRealizados INNER JOIN empleados ON gastosRealizados.IdEmpleado = empleados.IdEmpleado INNER JOIN gastos ON gastosRealizados.IdGasto = gastos.IdGasto Where Fecha='" & dtpFechaConsulta.Value.Date & "'"
            comando.CommandText = r
            lector = comando.ExecuteReader
            While lector.Read
                dgvConsultas.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7))
            End While
            lector.Close()
        ElseIf rbtConceptoConsulta.Checked Then
            dgvConsultas.Rows.Clear()
            r = "Select gastosRealizados.IdGastoR, empleados.IdEmpleado, gastos.IdGasto,gastosRealizados.Fecha, empleados.Nombre, gastos.Concepto, gastosRealizados.Importe, gastosRealizados.Observaciones from gastosRealizados INNER JOIN empleados ON gastosRealizados.IdEmpleado = empleados.IdEmpleado INNER JOIN gastos ON gastosRealizados.IdGasto = gastos.IdGasto Where Concepto='" & cmbConceptoConsulta.Text & "'"
            comando.CommandText = r
            lector = comando.ExecuteReader
            While lector.Read
                dgvConsultas.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7))
            End While
            lector.Close()
        ElseIf rbtEmpleadoConsulta.Checked Then
            dgvConsultas.Rows.Clear()
            r = "Select gastosRealizados.IdGastoR, empleados.IdEmpleado, gastos.IdGasto,gastosRealizados.Fecha, empleados.Nombre, gastos.Concepto, gastosRealizados.Importe, gastosRealizados.Observaciones from gastosRealizados INNER JOIN empleados ON gastosRealizados.IdEmpleado = empleados.IdEmpleado INNER JOIN gastos ON gastosRealizados.IdGasto = gastos.IdGasto Where Nombre='" & cmbEmpleadoConsulta.Text & "'"
            comando.CommandText = r
            lector = comando.ExecuteReader
            While lector.Read
                dgvConsultas.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7))
            End While
            lector.Close()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()
        Me.Close()
    End Sub
End Class