Public Class frmCalles
    Private Sub frmCalles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.calles' Puede moverla o quitarla según sea necesario.
        Me.CallesTableAdapter.Fill(Me.DataSetSistema.calles)

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = CallesBindingSource.Count + 1
        CallesBindingSource.AddNew()
        txtIdCalle.Text = n
        txtNombre.Enabled = True
        txtColonia.Enabled = True
        txtCP.Enabled = True
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdInicio.Enabled = False
        cmdAnterior.Enabled = False
        cmdSiguiente.Enabled = False
        cmdUltimo.Enabled = False
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        txtNombre.Enabled = False
        txtColonia.Enabled = False
        txtCP.Enabled = False
        CallesBindingSource.Current(4) = 0
        dgCalles.Refresh()
        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        cmdInicio.Enabled = True
        cmdAnterior.Enabled = True
        cmdSiguiente.Enabled = True
        cmdUltimo.Enabled = True
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        CallesBindingSource.EndEdit()
        CallesTableAdapter.Update(DataSetSistema.calles)
        Me.Close()
    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        CallesBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        CallesBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        CallesBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        CallesBindingSource.MoveLast()
    End Sub

    Private Sub txtColonia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColonia.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(cadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(numerosValidos, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtIdCalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdCalle.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(numerosValidos, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(cadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
End Class