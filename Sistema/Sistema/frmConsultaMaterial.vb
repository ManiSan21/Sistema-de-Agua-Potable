Imports System.Data.SqlClient
Public Class frmConsultaMaterial
    Dim conexion As New SqlConnection("Data Source = DESKTOP-B3IP6AD\MANI; Initial Catalog = 'SistemaAguaPotable'; Integrated Security = true")
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader

    Private Sub frmConsultaMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim idOrden As Integer
        Dim idProv As Integer
        Dim r As String
        Dim s As String
        Dim t As String
        idOrden = CInt(mskIdOrdenConsulta.Text)
        r = "Select compraMaterial.IdProveedor, compraMaterial.Factura, compraMaterial.Fecha From compraMaterial Where IdOrden=" & idOrden & ""

        comando.CommandText = r
        lector = comando.ExecuteReader

        While lector.Read
            mskIdProveedorConsulta.Text = lector(0)
            mskFacturaConsulta.Text = lector(1)
            txtFechaConsulta.Text = lector(2)
        End While
        lector.Close()
        idProv = CInt(mskIdProveedorConsulta.Text)
        s = "Select proveedor.Nombre From proveedor Where IdProveedor=" & idProv & ""
        comando.CommandText = s
        lector = comando.ExecuteReader
        While lector.Read
            mskProveedorConsulta.Text = lector(0)
        End While
        lector.Close()

        t = "Select detalleCompraMaterial.IdMaterial, material.Descripcion, detalleCompraMaterial.Cantidad, detalleCompraMaterial.Costo From detalleCompraMaterial INNER JOIN material ON detalleCompraMaterial.IdMaterial = material.IdMaterial Where IdOrden=" & idOrden & ""
        comando.CommandText = t
        lector = comando.ExecuteReader
        While lector.Read
            Dim cost As String = Replace(lector(3), ".", ",")
            dgvMaterialConsulta.Rows.Add(lector(0), lector(1), lector(2), cost, lector(2) * cost)
        End While
        lector.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()
        Me.Close()
    End Sub
End Class