Public Class frmCuentas
    Private Sub frmCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CallesTableAdapter.Fill(Me.DataSetSistema.calles)
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.cuentas' Puede moverla o quitarla según sea necesario.
        Me.CuentasTableAdapter.Fill(Me.DataSetSistema.cuentas)

    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        CuentasBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        CuentasBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        CuentasBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        CuentasBindingSource.MovePrevious()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        cmbIdCalle.Enabled = True
        txtNombre.Enabled = True
        txtNoExt.Enabled = True
        txtNoInt.Enabled = True
        dtpFechaAlta.Enabled = True
        dtpUltimoPagoA.Enabled = True
        dtpUltimoPagoM.Enabled = True
        Dim n As Integer
        n = CuentasBindingSource.Count + 1
        'CuentasBindingSource.AddNew()
        CuentasBindingSource.AddNew()
        txtIdCuenta.Text = n
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        cmbIdCalle.Enabled = False
        txtNombre.Enabled = False
        txtNoExt.Enabled = False
        txtNoInt.Enabled = False
        dtpFechaAlta.Enabled = False
        dtpUltimoPagoA.Enabled = False
        dtpUltimoPagoM.Enabled = False
        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        cmdInicio.Enabled = True
        cmdSiguiente.Enabled = True
        cmdAnterior.Enabled = True
        cmdUltimo.Enabled = True
        MsgBox(cmbIdCalle.SelectedValue)
        CuentasBindingSource.Current(1) = cmbIdCalle.SelectedValue
        CuentasBindingSource.Current(5) = dtpFechaAlta.Value.Date
        CuentasBindingSource.Current(6) = dtpUltimoPagoA.Value.Date
        CuentasBindingSource.Current(7) = dtpUltimoPagoM.Value.Date
        Dim num As Integer = cmbIdCalle.SelectedValue
        CallesBindingSource.MoveFirst()
        For x = 0 To CallesBindingSource.Count - 1
            If CallesBindingSource.Current(0) = num Then
                CallesBindingSource.Current(4) += 1
            End If
            CallesBindingSource.MoveNext()
        Next
        dgCuentas.Refresh()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        CuentasBindingSource.EndEdit()
        CallesBindingSource.EndEdit()
        CallesTableAdapter.Update(DataSetSistema.calles)
        CuentasTableAdapter.Update(DataSetSistema.cuentas)
        Me.Close()
    End Sub
End Class