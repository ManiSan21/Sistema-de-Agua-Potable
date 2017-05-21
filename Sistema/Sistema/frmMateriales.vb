Public Class frmMateriales
    Private Sub frmMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.material' Puede moverla o quitarla según sea necesario.
        'Me.MaterialTableAdapter.Fill(Me.DataSetSistema.material)
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.material' Puede moverla o quitarla según sea necesario.
        Me.MaterialTableAdapter.Fill(Me.DataSetSistema.material)

    End Sub

    Private Sub Inicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        MaterialBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        MaterialBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        MaterialBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        MaterialBindingSource.MoveLast()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = MaterialBindingSource.Count + 1
        MaterialBindingSource.AddNew()
        txtIdMaterial.Text = n
        txtDescripcion.Enabled = True
        txtExistencias.Enabled = True
        txtMaximo.Enabled = True
        txtMinimo.Enabled = True
        txtCosto.Enabled = True
        cmbUnidad.Enabled = True
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdInicio.Enabled = False
        cmdAnterior.Enabled = False
        cmdSiguiente.Enabled = False
        cmdUltimo.Enabled = False
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        MaterialBindingSource.Current(7) = dtpUltimaFechaCompra.Value.Date
        txtDescripcion.Enabled = False
        txtExistencias.Enabled = False
        txtMaximo.Enabled = False
        txtMinimo.Enabled = False
        cmbUnidad.Enabled = False
        txtCosto.Enabled = False
        'MaterialBindingSource.Current(7) = dtpUltimaFechaCompra.Value.Date
        dgMateriales.Refresh()
        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        cmdInicio.Enabled = True
        cmdAnterior.Enabled = True
        cmdSiguiente.Enabled = True
        cmdUltimo.Enabled = True
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        MaterialBindingSource.EndEdit()
        MaterialTableAdapter.Update(DataSetSistema.material)
        Me.Close()
    End Sub

    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(numerosValidos, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(cadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtExistencias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExistencias.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(numerosValidos, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtIdMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdMaterial.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(numerosValidos, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtMaximo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaximo.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(numerosValidos, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtMinimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinimo.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(numerosValidos, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
End Class