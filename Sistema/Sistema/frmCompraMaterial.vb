Imports System.Data.SqlClient
Public Class frmCompraMaterial
    Dim conexion As New SqlConnection("Data Source = DESKTOP-B3IP6AD\MANI; Initial Catalog = 'SistemaAguaPotable'; Integrated Security = true")
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Private Sub frmCompraMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando.CommandText = "Select * From proveedor"
        lector = comando.ExecuteReader
        While lector.Read
            cmbProveedor.Items.Add(lector(1))
        End While
        lector.Close()

        comando.CommandText = "Select * From material"
        lector = comando.ExecuteReader
        While lector.Read
            cmbMaterial.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub
    Private Sub cmbProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProveedor.SelectedIndexChanged
        Dim r As String
        r = "Select * From proveedor Where Nombre='" & cmbProveedor.Text & "'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        lector.Read()
        mskIdProveedor.Text = lector(0)
        mskDomicilio.Text = lector(2)
        mskTelefono.Text = lector(6)
        lector.Close()
    End Sub

    Private Sub cmbMaterial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMaterial.SelectedIndexChanged
        Dim r As String
        r = "Select * From material Where Descripcion='" & cmbMaterial.Text & "'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        lector.Read()
        mskIdMaterial.Text = lector(0)
        txtCostoAnt.Text = lector(6)
        txtUFC.Text = lector(7)
        mskExistencias.Text = lector(2)
        mskMaximo.Text = lector(3)
        mskMinimo.Text = lector(4)
        mskUnidad.Text = lector(5)
        lector.Close()
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim importe As Double = 0
        Dim subtotal As Double = 0
        Dim iva As Double = 0
        Dim total As Double = 0
        'Replace(txtCosto.Text, ",", ".")
        importe = CDbl(mskCantidad.Text) * CDbl(txtCosto.Text)
        dgvCompraMaterial.Rows.Add(mskIdMaterial.Text, cmbMaterial.Text, CDbl(mskCantidad.Text), CDbl(txtCosto.Text), importe)
        For x = 0 To dgvCompraMaterial.Rows.Count - 1
            subtotal = CDbl(dgvCompraMaterial.Rows(x).Cells(4).Value) + subtotal
            txtSubtotal.Text = CStr(subtotal)
        Next
        iva = subtotal * 0.16
        txtIVA.Text = CStr(iva)
        total = subtotal + iva
        txtTotal.Text = CStr(total)
        MessageBox.Show(total)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        comando.CommandText = "Select count (*) From compraMaterial"
        Dim n As Integer
        n = comando.ExecuteScalar + 1
        mskIdOrden.Text = n
        mskFactura.Enabled = True
        dtpFecha.Enabled = True
        cmbProveedor.Enabled = True
        cmbMaterial.Enabled = True
        mskCantidad.Enabled = True
        txtCosto.Enabled = True
        btnAceptar.Enabled = True
        txtSubtotal.Enabled = True
        txtIVA.Enabled = True
        txtTotal.Enabled = True
        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim c1 As Integer
        Dim c2 As Integer
        Dim c3 As Decimal
        Dim c4 As Double
        Dim r As String
        Dim idOrden As Integer
        Dim idProveedor As Integer
        Dim factura As Integer
        Dim fecha As Date
        Dim subtotal As Double
        Dim iva As Double
        Dim total As Double
        Dim s As String

        For x = 0 To dgvCompraMaterial.Rows.Count - 2
            c1 = Val(mskIdOrden.Text)
            c2 = Val(dgvCompraMaterial.Item(0, x).Value)
            c3 = CDec(dgvCompraMaterial.Item(2, x).Value)
            c4 = CDbl(dgvCompraMaterial.Item(3, x).Value)
        Next
        Dim cost As String = Replace(c4, ",", ".")
        r = "Insert Into detalleCompraMaterial (IdOrden, IdMaterial, Cantidad, Costo) values(" & c1 & "," & c2 & "," & c3 & "," & cost & ")"
        MessageBox.Show(r)
        comando.CommandText = r
        comando.ExecuteNonQuery()

        fecha = dtpFecha.Value.Date
        r = "Update material Set Existencias = Existencias + " & c3 & ", Costo =" & cost & ", UltimaFechaCompra ='" & fecha & "' Where IdMaterial=" & Val(mskIdMaterial.Text) & ""
        comando.CommandText = r
        comando.ExecuteNonQuery()

        idOrden = CInt(mskIdOrden.Text)
        idProveedor = CInt(mskIdProveedor.Text)
        factura = Val(mskFactura.Text)
        subtotal = CDbl(txtSubtotal.Text)
        iva = CDbl(txtIVA.Text)
        total = CDbl(txtTotal.Text)
        s = "Insert Into compraMaterial (IdOrden, IdProveedor, Factura, Fecha, Subtotal, Iva, Total) values(" & idOrden & "," & idProveedor & "," & factura & ",'" & fecha & "','" & subtotal & "','" & iva & "','" & total & "')"
        comando.CommandText = s
        comando.ExecuteNonQuery()

        mskFactura.Enabled = False
        dtpFecha.Enabled = False
        cmbProveedor.Enabled = False
        cmbMaterial.Enabled = False
        mskCantidad.Enabled = False
        txtCosto.Enabled = False
        btnAceptar.Enabled = False
        txtSubtotal.Enabled = False
        txtIVA.Enabled = False
        txtTotal.Enabled = False
        btnNuevo.Enabled = True
        btnGrabar.Enabled = False
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()
        Me.Close()
    End Sub
End Class