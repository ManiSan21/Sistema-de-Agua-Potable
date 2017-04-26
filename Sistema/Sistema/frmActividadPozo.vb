Imports System.Data.SqlClient
Public Class frmActividadPozo
    Dim conexion As New SqlConnection("Data Source = DESKTOP-B3IP6AD\MANI; Initial Catalog = 'SistemaAguaPotable'; Integrated Security = true")
    Private Sub frmActividadPozo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        Dim comando As New SqlCommand("Select * From pozos", conexion)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        While lector.Read
            cmbPozo.Items.Add(lector(1))
        End While
        lector.Close()

        comando.CommandText = "Select actividadPozo.IdActividad, pozos.Ubicacion, actividadPozo.IdPozo, actividadPozo.Fecha, actividadPozo.Hora, actividadPozo.Lectura, actividadPozo.Observaciones From actividadPozo Inner Join pozos on actividadPozo.IdPozo = pozos.IdPozo"
        lector = comando.ExecuteReader
        While lector.Read
            dgvActividadPozo.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
        End While
        lector.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim comando As New SqlCommand("Select count (*) From actividadPozo", conexion)
        Dim n As Integer
        n = comando.ExecuteScalar + 1
        mskIdActividad.Text = n
        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
        cmbPozo.Enabled = True
        mskIdPozo.Enabled = True
        dtpFecha.Enabled = True
        mskHora.Enabled = True
        mskLectura.Enabled = True
        mskObservaciones.Enabled = True
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        btnNuevo.Enabled = True
        btnGrabar.Enabled = False
        Dim c1 As Integer
        Dim c2 As Integer
        Dim c3 As Date
        Dim c4 As String
        Dim c5 As Integer
        Dim c6 As String
        Dim r As String

        c1 = Val(mskIdActividad.Text)
        c2 = Val(mskIdPozo.Text)
        c3 = dtpFecha.Value.Date
        c4 = mskHora.Text
        c5 = Val(mskLectura.Text)
        c6 = mskObservaciones.Text

        r = "Insert into actividadPozo (IdActividad, IdPozo, Fecha, Hora, Lectura, Observaciones) values(" & c1 & "," & c2 & ",'" & c3 & "','" & c4 & "','" & c5 & "','" & c6 & "')"

        Dim comando As New SqlCommand(r, conexion)
        comando.ExecuteNonQuery()
        btnNuevo.Enabled = True
        btnGrabar.Enabled = False
        cmbPozo.Enabled = False
        mskIdPozo.Enabled = False
        dtpFecha.Enabled = False
        mskHora.Enabled = False
        mskLectura.Enabled = False
        mskObservaciones.Enabled = False
    End Sub

    Private Sub cmbPozo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPozo.SelectedIndexChanged
        Dim r As String
        r = "Select * From pozos Where Ubicacion='" & cmbPozo.Text & "'"
        Dim comando As New SqlCommand(r, conexion)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        lector.Read()
        mskIdPozo.Text = lector(0)
        lector.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()
        Me.Close()
    End Sub
End Class