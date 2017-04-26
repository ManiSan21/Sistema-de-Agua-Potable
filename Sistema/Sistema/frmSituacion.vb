Public Class frmSituacion
    Private Sub frmSituacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.situacion' Puede moverla o quitarla según sea necesario.
        Me.SituacionTableAdapter.Fill(Me.DataSetSistema.situacion)

    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        SituacionBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        SituacionBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        SituacionBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        SituacionBindingSource.MoveLast()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = SituacionBindingSource.Count + 1
        SituacionBindingSource.AddNew()
        txtIdSituación.Text = n
        txtDescripción.Enabled = True
        txtDescuento.Enabled = True
        cmdInicio.Enabled = True
        cmdSiguiente.Enabled = True
        cmdAnterior.Enabled = True
        cmdUltimo.Enabled = True
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        txtDescripción.Enabled = False
        txtDescuento.Enabled = False
        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        dgSituación.Refresh()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        SituacionBindingSource.EndEdit()
        SituacionTableAdapter.Update(DataSetSistema.situacion)
        Me.Close()
    End Sub
End Class