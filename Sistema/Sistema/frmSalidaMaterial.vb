Imports System.Data.SqlClient
Public Class frmSalidaMaterial
    Dim conexion As New SqlConnection("Data Source = DESKTOP-B3IP6AD\MANI; Initial Catalog = 'SistemaAguaPotable'; Integrated Security = true")
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader

    Private Sub frmSalidaMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando.CommandText = "Select * from empleados"
        lector = comando.ExecuteReader
        While lector.Read
            cmbEmpleado.Items.Add(lector(1))
        End While
        lector.Close()

        comando.CommandText = "Select * from calles"
        lector = comando.ExecuteReader
        While lector.Read
            cmbCalle.Items.Add(lector(1))
        End While
        lector.Close()

        comando.CommandText = "Select * from material"
        lector = comando.ExecuteReader
        While lector.Read
            cmbMaterial.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub cmbEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpleado.SelectedIndexChanged
        comando.CommandText = "Select * From empleados Where Nombre='" & cmbEmpleado.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        mskIdEmpleado.Text = lector(0)
        mskCelular.Text = lector(6)
        mskDomicilio.Text = lector(2)
        lector.Close()
    End Sub

    Private Sub cmbCalle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCalle.SelectedIndexChanged
        comando.CommandText = "Select * From calles Where Nombre='" & cmbCalle.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        mskIdCalle.Text = lector(0)
        mskTotalCasas.Text = lector(4)
        lector.Close()
    End Sub

    Private Sub cmbMaterial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMaterial.SelectedIndexChanged
        comando.CommandText = "Select * From material Where Descripcion='" & cmbMaterial.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        mskIdMaterial.Text = lector(0)
        mskExistencias.Text = lector(2)
        txtCosto.Text = lector(6)
        mskMaximo.Text = lector(3)
        mskMinimo.Text = lector(4)
        txtFechaMat.Text = lector(7)
        mskUnidadMedida.Text = lector(5)
        lector.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        comando.CommandText = "Select count (*) From salidasMaterial"
        Dim n As Integer
        n = comando.ExecuteScalar + 1
        mskIdSalida.Text = n
        mskConceptoSalida.Enabled = True
        cmbEmpleado.Enabled = True
        dtpFecha.Enabled = True
        cmbCalle.Enabled = True
        cmbMaterial.Enabled = True
        mskCantidad.Enabled = True
        btnAgregar.Enabled = True
        btnGrabar.Enabled = True
        btnNuevo.Enabled = False
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim c1 As Integer
        Dim c2 As Integer
        Dim c3 As Decimal
        Dim c4 As Double
        Dim idSalida As Integer
        Dim idEmpleado As Integer
        Dim idCalle As Integer
        Dim fecha As Date
        Dim concepto As String
        Dim subtotal As Double
        Dim r As String
        Dim s As String

        For x = 0 To dgvSalidaMat.Rows.Count - 2
            c1 = Val(mskIdSalida.Text)
            c2 = Val(dgvSalidaMat.Item(0, x).Value)
            c3 = CDec(dgvSalidaMat.Item(2, x).Value)
            c4 = CDbl(dgvSalidaMat.Item(3, x).Value)
        Next
        Dim cost As String = Replace(c4, ",", ".")
        r = "Insert Into detalleSalidasMaterial (IdSalida, IdMaterial, Cantidad,Costo) values(" & c1 & "," & c2 & "," & c3 & "," & cost & ")"
        MessageBox.Show(r)
        comando.CommandText = r
        comando.ExecuteNonQuery()

        r = "Update material Set Existencias = Existencias -" & c3 & "Where IdMaterial=" & Val(mskIdMaterial.Text) & ""
        comando.CommandText = r
        comando.ExecuteNonQuery()

        idSalida = Val(mskIdSalida.Text)
        idEmpleado = Val(mskIdEmpleado.Text)
        idCalle = Val(mskIdCalle.Text)
        fecha = dtpFecha.Value.Date
        concepto = mskConceptoSalida.Text
        subtotal = CDbl(txtSubtotal.Text)
        s = "Insert Into salidasMaterial (IdSalida, IdEmpleado, IdCalle, Fecha, Concepto, Subtotal) values(" & idSalida & "," & idEmpleado & "," & idCalle & ",'" & fecha & "','" & concepto & "','" & subtotal & "')"
        comando.CommandText = s
        comando.ExecuteNonQuery()

        mskConceptoSalida.Enabled = False
        cmbEmpleado.Enabled = False
        dtpFecha.Enabled = False
        mskIdEmpleado.Enabled = False
        mskCelular.Enabled = False
        mskDomicilio.Enabled = False
        cmbCalle.Enabled = False
        mskIdCalle.Enabled = False
        mskTotalCasas.Enabled = False
        cmbMaterial.Enabled = False
        mskIdMaterial.Enabled = False
        mskExistencias.Enabled = False
        txtCosto.Enabled = False
        mskMaximo.Enabled = False
        mskMinimo.Enabled = False
        txtFechaMat.Enabled = False
        mskUnidadMedida.Enabled = False
        mskCantidad.Enabled = False
        btnAgregar.Enabled = False
        txtSubtotal.Enabled = False
        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        mskConceptoSalida.Text = ""
        mskCantidad.Text = ""
        dgvSalidaMat.Rows.Clear()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim importe As Double
        Dim subtotal As Double

        importe = CDbl(mskCantidad.Text) * CDbl(txtCosto.Text)
        dgvSalidaMat.Rows.Add(mskIdMaterial.Text, cmbMaterial.Text, CDbl(mskCantidad.Text), CDbl(txtCosto.Text), importe)
        For x = 0 To dgvSalidaMat.Rows.Count - 1
            subtotal = CDbl(dgvSalidaMat.Rows(x).Cells(4).Value) + subtotal
            txtSubtotal.Text = CStr(subtotal)
        Next
        MessageBox.Show(subtotal)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()
        Me.Close()
    End Sub
End Class