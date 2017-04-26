﻿Public Class frmEmpleados
    Private Sub frmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.DataSetSistema.empleados)

    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        EmpleadosBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        EmpleadosBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        EmpleadosBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        EmpleadosBindingSource.MoveLast()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = EmpleadosBindingSource.Count + 1
        EmpleadosBindingSource.AddNew()
        txtIdEmpleado.Text = n
        txtNombre.Enabled = True
        txtDomicilio.Enabled = True
        txtColonia.Enabled = True
        txtCP.Enabled = True
        txtTelCasa.Enabled = True
        txtCelular.Enabled = True
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdInicio.Enabled = False
        cmdAnterior.Enabled = False
        cmdSiguiente.Enabled = False
        cmdUltimo.Enabled = False
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        txtNombre.Enabled = False
        txtDomicilio.Enabled = False
        txtColonia.Enabled = False
        txtCP.Enabled = False
        txtTelCasa.Enabled = False
        txtCelular.Enabled = False
        dgEmpleados.Refresh()
        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        cmdInicio.Enabled = True
        cmdAnterior.Enabled = True
        cmdSiguiente.Enabled = True
        cmdUltimo.Enabled = True
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        EmpleadosBindingSource.EndEdit()
        EmpleadosTableAdapter.Update(DataSetSistema.empleados)
        Me.Close()
    End Sub
End Class