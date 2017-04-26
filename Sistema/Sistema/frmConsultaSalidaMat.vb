Imports System.Data.SqlClient
Public Class frmConsultaSalidaMat
    Dim conexion As New SqlConnection("Data Source = DESKTOP-B3IP6AD\MANI; Initial Catalog = 'SistemaAguaPotable'; Integrated Security = true")
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader

    Private Sub frmConsultaSalidaMat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando.CommandText = "Select * From empleados"
        lector = comando.ExecuteReader
        While lector.Read
            cmbEmpleado.Items.Add(lector(1))
        End While
        lector.Close()
        comando.CommandText = "Select * From salidasMaterial"
        lector = comando.ExecuteReader
        While lector.Read
            cmbIdSalida.Items.Add(lector(0))
        End While
        lector.Close()
        comando.CommandText = "Select * From calles"
        lector = comando.ExecuteReader
        While lector.Read
            cmbCalle.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim r As String
        Dim idSalida As Integer
        If rbtTodos.Checked Then
            dgvConsultaSalidasMat.Rows.Clear()
            r = "Select salidasMaterial.IdSalida, empleados.Nombre, calles.Nombre, salidasMaterial.Fecha, salidasMaterial.Concepto, salidasMaterial.Subtotal, material.IdMaterial, material.Descripcion, detalleSalidasMaterial.Cantidad, detalleSalidasMaterial.Costo From salidasMaterial INNER JOIN empleados ON salidasMaterial.IdEmpleado = empleados.IdEmpleado INNER JOIN calles ON salidasMaterial.IdCalle = calles.IdCalle INNER JOIN detalleSalidasMaterial On salidasMaterial.IdSalida = detalleSalidasMaterial.IdSalida INNER JOIN material ON detalleSalidasMaterial.IdMaterial = material.IdMaterial"
            comando.CommandText = r
            lector = comando.ExecuteReader
            While lector.Read
                Dim subto As String = Replace(lector(5), ".", ",")
                Dim cost As String = Replace(lector(9), ".", ",")
                dgvConsultaSalidasMat.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), subto, lector(6), lector(7), lector(8), cost, lector(8) * cost)
            End While
            lector.Close()
        ElseIf rbtIdSalida.Checked Then
            dgvConsultaSalidasMat.Rows.Clear()
            r = "Select salidasMaterial.IdSalida, empleados.Nombre, calles.Nombre, salidasMaterial.Fecha, salidasMaterial.Concepto, salidasMaterial.Subtotal From salidasMaterial INNER JOIN empleados ON salidasMaterial.IdEmpleado = empleados.IdEmpleado INNER JOIN calles ON salidasMaterial.IdCalle = calles.IdCalle Where salidasMaterial.IdSalida=" & cmbIdSalida.Text & ""
            comando.CommandText = r
            lector = comando.ExecuteReader
            While lector.Read
                'Dim subto As String = Replace(lector(5), ".", ",")
                idSalida = lector(0)
                Dim subtotal As String = Replace(lector(5), ".", ",")
                'dgvConsultaSalidasMat.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), subto, lector(6), lector(7), lector(8), cost, lector(8) * cost)
                mskIdSalida.Text = idSalida
                mskEmpleado.Text = lector(1)
                mskCalle.Text = lector(2)
                txtFecha.Text = lector(3)
                mskConcepto.Text = lector(4)
                txtSubtotal.Text = subtotal
            End While
            lector.Close()
            r = "Select detalleSalidasMaterial.IdSalida, detalleSalidasMaterial.IdMaterial, material.Descripcion, detalleSalidasMaterial.Cantidad, detalleSalidasMaterial.Costo From detalleSalidasMaterial INNER JOIN material ON detalleSalidasMaterial.IdMaterial = material.IdMaterial Where IdSalida=" & idSalida & ""
            comando.CommandText = r
            lector = comando.ExecuteReader
            While lector.Read
                Dim cost As String = Replace(lector(4), ".", ",")
                dgvDetalleSalidaMat.Rows.Add(lector(0), lector(2), lector(3), cost, lector(3) * cost)
            End While
            lector.Close()
        ElseIf rbtEmpleado.Checked Then
            dgvConsultaSalidasMat.Rows.Clear()
            r = "Select salidasMaterial.IdSalida, empleados.Nombre, calles.Nombre, salidasMaterial.Fecha, salidasMaterial.Concepto, salidasMaterial.Subtotal, material.IdMaterial, material.Descripcion, detalleSalidasMaterial.Cantidad, detalleSalidasMaterial.Costo From salidasMaterial INNER JOIN empleados ON salidasMaterial.IdEmpleado = empleados.IdEmpleado INNER JOIN calles ON salidasMaterial.IdCalle = calles.IdCalle INNER JOIN detalleSalidasMaterial On salidasMaterial.IdSalida = detalleSalidasMaterial.IdSalida INNER JOIN material ON detalleSalidasMaterial.IdMaterial = material.IdMaterial Where empleados.Nombre='" & cmbEmpleado.Text & "'"
            comando.CommandText = r
            lector = comando.ExecuteReader
            While lector.Read
                Dim subto As String = Replace(lector(5), ".", ",")
                Dim cost As String = Replace(lector(9), ".", ",")
                dgvConsultaSalidasMat.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), subto, lector(6), lector(7), lector(8), cost, lector(8) * cost)
            End While
            lector.Close()
        ElseIf rbtCalle.Checked Then
            dgvConsultaSalidasMat.Rows.Clear()
            r = "Select salidasMaterial.IdSalida, empleados.Nombre, calles.Nombre, salidasMaterial.Fecha, salidasMaterial.Concepto, salidasMaterial.Subtotal, material.IdMaterial, material.Descripcion, detalleSalidasMaterial.Cantidad, detalleSalidasMaterial.Costo From salidasMaterial INNER JOIN empleados ON salidasMaterial.IdEmpleado = empleados.IdEmpleado INNER JOIN calles ON salidasMaterial.IdCalle = calles.IdCalle INNER JOIN detalleSalidasMaterial On salidasMaterial.IdSalida = detalleSalidasMaterial.IdSalida INNER JOIN material ON detalleSalidasMaterial.IdMaterial = material.IdMaterial Where calles.Nombre='" & cmbCalle.Text & "'"
            comando.CommandText = r
            lector = comando.ExecuteReader
            While lector.Read
                Dim subto As String = Replace(lector(5), ".", ",")
                Dim cost As String = Replace(lector(9), ".", ",")
                dgvConsultaSalidasMat.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), subto, lector(6), lector(7), lector(8), cost, lector(8) * cost)
            End While
            lector.Close()
        ElseIf rbtPeriodo.Checked Then
            dgvConsultaSalidasMat.Rows.Clear()
            r = "Select salidasMaterial.IdSalida, empleados.Nombre, calles.Nombre, salidasMaterial.Fecha, salidasMaterial.Concepto, salidasMaterial.Subtotal, material.IdMaterial, material.Descripcion, detalleSalidasMaterial.Cantidad, detalleSalidasMaterial.Costo From salidasMaterial INNER JOIN empleados ON salidasMaterial.IdEmpleado = empleados.IdEmpleado INNER JOIN calles ON salidasMaterial.IdCalle = calles.IdCalle INNER JOIN detalleSalidasMaterial On salidasMaterial.IdSalida = detalleSalidasMaterial.IdSalida INNER JOIN material ON detalleSalidasMaterial.IdMaterial = material.IdMaterial Where Fecha>='" & dtpFechaInicial.Value.Date & "' AND Fecha<='" & dtpFechaFinal.Value.Date & "'"
            comando.CommandText = r
            lector = comando.ExecuteReader
            While lector.Read
                Dim subto As String = Replace(lector(5), ".", ",")
                Dim cost As String = Replace(lector(9), ".", ",")
                dgvConsultaSalidasMat.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), subto, lector(6), lector(7), lector(8), cost, lector(8) * cost)
            End While
            lector.Close()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()
        Me.Close()
    End Sub

    Private Sub rbtCalle_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCalle.CheckedChanged
        If rbtCalle.Checked Then
            cmbCalle.Visible = True
            dgvConsultaSalidasMat.Visible = True
        Else
            cmbCalle.Visible = False
            dgvConsultaSalidasMat.Visible = False
        End If
    End Sub

    Private Sub rbtEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEmpleado.CheckedChanged
        If rbtEmpleado.Checked Then
            cmbEmpleado.Visible = True
            dgvConsultaSalidasMat.Visible = True
        Else
            cmbEmpleado.Visible = False
            dgvConsultaSalidasMat.Visible = False
        End If
    End Sub

    Private Sub rbtIdSalida_CheckedChanged(sender As Object, e As EventArgs) Handles rbtIdSalida.CheckedChanged
        If rbtIdSalida.Checked Then
            cmbIdSalida.Visible = True
            dgvDetalleSalidaMat.Visible = True
        Else
            cmbIdSalida.Visible = False
            dgvDetalleSalidaMat.Visible = False
            dgvConsultaSalidasMat.Visible = False
        End If
    End Sub

    Private Sub rbtPeriodo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPeriodo.CheckedChanged
        If rbtPeriodo.Checked Then
            lblFechaIni.Visible = True
            lblFechaFin.Visible = True
            dtpFechaInicial.Visible = True
            dtpFechaFinal.Visible = True
            dgvConsultaSalidasMat.Visible = True
        Else
            lblFechaIni.Visible = False
            lblFechaFin.Visible = False
            dtpFechaInicial.Visible = False
            dtpFechaFinal.Visible = False
            dgvConsultaSalidasMat.Visible = False
        End If
    End Sub
End Class