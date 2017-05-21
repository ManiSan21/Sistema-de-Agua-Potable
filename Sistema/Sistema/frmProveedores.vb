Public Class frmProveedores
    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.DataSetSistema.proveedor)

    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        ProveedorBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        ProveedorBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        ProveedorBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        ProveedorBindingSource.MoveLast()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = ProveedorBindingSource.Count + 1
        ProveedorBindingSource.AddNew()
        txtIdProveedor.Text = n
        txtNombre.Enabled = True
        txtDomicilio.Enabled = True
        txtColonia.Enabled = True
        txtEstado.Enabled = True
        txtCP.Enabled = True
        txtTelefono.Enabled = True
        txtEmail.Enabled = True
        cmdInicio.Enabled = True
        cmdSiguiente.Enabled = True
        cmdAnterior.Enabled = True
        cmdUltimo.Enabled = True
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        txtNombre.Enabled = False
        txtDomicilio.Enabled = False
        txtColonia.Enabled = False
        txtEstado.Enabled = False
        txtCP.Enabled = False
        txtTelefono.Enabled = False
        txtEmail.Enabled = False
        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        dgProveedores.Refresh()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        ProveedorBindingSource.EndEdit()
        ProveedorTableAdapter.Update(DataSetSistema.proveedor)
        Me.Close()
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

    Private Sub txtDomicilio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDomicilio.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(cadenaMixta, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        'e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(cadenaMixta, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstado.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(cadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtIdProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdProveedor.KeyPress
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

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(numerosValidos, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
End Class