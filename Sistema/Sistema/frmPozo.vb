Public Class frmPozo
    Private Sub frmPozo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.pozos' Puede moverla o quitarla según sea necesario.
        Me.PozosTableAdapter.Fill(Me.DataSetSistema.pozos)
    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        PozosBindingSource.MoveFirst()
        txtIdPozo.Text = PozosBindingSource.Current(0)
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        PozosBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        PozosBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        PozosBindingSource.MoveLast()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = PozosBindingSource.Count + 1
        PozosBindingSource.AddNew()
        txtIdPozo.Text = n
        txtUbicacion.Enabled = True
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdInicio.Enabled = False
        cmdAnterior.Enabled = False
        cmdSiguiente.Enabled = False
        cmdUltimo.Enabled = False
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        txtUbicacion.Enabled = False
        PozosBindingSource.Current(0) = txtIdPozo.Text
        PozosBindingSource.Current(1) = txtUbicacion.Text
        dgPozo.Refresh()
        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        cmdInicio.Enabled = True
        cmdAnterior.Enabled = True
        cmdSiguiente.Enabled = True
        cmdUltimo.Enabled = True
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        PozosBindingSource.EndEdit()
        PozosTableAdapter.Update(DataSetSistema.pozos)
        Me.Close()
    End Sub
End Class