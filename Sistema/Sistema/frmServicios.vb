Public Class frmServicios
    Private Sub frmServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.DataSetSistema.servicios)

    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        ServiciosBindingSource.MoveFirst()
        txtIdServicio.Text = ServiciosBindingSource.Current(0)
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        ServiciosBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        ServiciosBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        ServiciosBindingSource.MoveLast()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = ServiciosBindingSource.Count + 1
        ServiciosBindingSource.AddNew()
        txtIdServicio.Text = n
        txtDescripcion.Enabled = True
        txtPrecio.Enabled = True
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdInicio.Enabled = False
        cmdAnterior.Enabled = False
        cmdSiguiente.Enabled = False
        cmdUltimo.Enabled = False
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        txtDescripcion.Enabled = False
        txtPrecio.Enabled = False
        asignar()
        dgServicios.Refresh()
        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        cmdInicio.Enabled = True
        cmdAnterior.Enabled = True
        cmdSiguiente.Enabled = True
        cmdUltimo.Enabled = True
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        ServiciosBindingSource.EndEdit()
        ServiciosTableAdapter.Update(DataSetSistema.servicios)
        Me.Close()
    End Sub

    Private Sub asignar()
        ServiciosBindingSource.Current(0) = txtIdServicio.Text
        ServiciosBindingSource.Current(1) = txtDescripcion.Text
        ServiciosBindingSource.Current(2) = txtPrecio.Text
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(cadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtIdServicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdServicio.KeyPress
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