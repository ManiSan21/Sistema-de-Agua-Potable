Public Class frmGastos
    Private Sub frmGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.gastos' Puede moverla o quitarla según sea necesario.
        Me.GastosTableAdapter.Fill(Me.DataSetSistema.gastos)

    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        GastosBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        GastosBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        GastosBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        GastosBindingSource.MoveLast()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = GastosBindingSource.Count + 1
        GastosBindingSource.AddNew()
        txtIdGasto.Text = n
        txtConcepto.Enabled = True
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdInicio.Enabled = False
        cmdAnterior.Enabled = False
        cmdSiguiente.Enabled = False
        cmdUltimo.Enabled = False
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        txtConcepto.Enabled = False
        dgGastos.Refresh()
        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        cmdInicio.Enabled = True
        cmdAnterior.Enabled = True
        cmdSiguiente.Enabled = True
        cmdUltimo.Enabled = True
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        GastosBindingSource.EndEdit()
        GastosTableAdapter.Update(DataSetSistema.gastos)
        Me.Close()
    End Sub

    Private Sub txtConcepto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConcepto.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(cadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtIdGasto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdGasto.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(numerosValidos, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
End Class