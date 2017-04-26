Public Class frmTarifas
    Private Sub frmTarifas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.tarifas' Puede moverla o quitarla según sea necesario.
        Me.TarifasTableAdapter.Fill(Me.DataSetSistema.tarifas)
    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        TarifasBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        TarifasBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        TarifasBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        TarifasBindingSource.MoveLast()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = TarifasBindingSource.Count + 1
        TarifasBindingSource.AddNew()
        txtIdTarifas.Text = n
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        txtAño.Enabled = True
        txtCF.Enabled = True
        txtRecargos.Enabled = True
        txtTAR.Enabled = True
        txtINFRA.Enabled = True
        cmdInicio.Enabled = True
        cmdSiguiente.Enabled = True
        cmdAnterior.Enabled = True
        cmdUltimo.Enabled = True
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        txtAño.Enabled = False
        txtCF.Enabled = False
        txtRecargos.Enabled = False
        txtTAR.Enabled = False
        txtINFRA.Enabled = False
        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False
        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        dgTarifas.Refresh()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        TarifasBindingSource.EndEdit()
        TarifasTableAdapter.Update(DataSetSistema.tarifas)
        Me.Close()
    End Sub
End Class