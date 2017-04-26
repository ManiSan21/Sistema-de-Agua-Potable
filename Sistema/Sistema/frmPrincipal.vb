Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mniCalles_Click(sender As Object, e As EventArgs) Handles mniCalles.Click
        frmCalles.ShowDialog()
    End Sub

    Private Sub mniGastos_Click(sender As Object, e As EventArgs) Handles mniGastos.Click
        frmGastos.ShowDialog()
    End Sub

    Private Sub mniMateriales_Click(sender As Object, e As EventArgs) Handles mniMateriales.Click
        frmMateriales.ShowDialog()
    End Sub

    Private Sub mniPozos_Click(sender As Object, e As EventArgs) Handles mniPozos.Click
        frmPozo.ShowDialog()
    End Sub

    Private Sub mniServicios_Click(sender As Object, e As EventArgs) Handles mniServicios.Click
        frmServicios.ShowDialog()
    End Sub

    Private Sub mniEmpleados_Click(sender As Object, e As EventArgs) Handles mniEmpleados.Click
        frmEmpleados.ShowDialog()
    End Sub

    Private Sub mniSalir_Click(sender As Object, e As EventArgs) Handles mniSalir.Click
        End
    End Sub

    Private Sub mniCuentas_Click(sender As Object, e As EventArgs) Handles mniCuentas.Click
        frmCuentas.ShowDialog()
    End Sub

    Private Sub mniTarifas_Click(sender As Object, e As EventArgs) Handles mniTarifas.Click
        frmTarifas.ShowDialog()
    End Sub

    Private Sub mniProveedores_Click(sender As Object, e As EventArgs) Handles mniProveedores.Click
        frmProveedores.ShowDialog()
    End Sub

    Private Sub mniSituacion_Click(sender As Object, e As EventArgs) Handles mniSituacion.Click
        frmSituacion.ShowDialog()
    End Sub

    Private Sub tsmiActividadDePozo_Click(sender As Object, e As EventArgs) Handles tsmiActividadDePozo.Click
        frmActividadPozo.ShowDialog()
    End Sub

    Private Sub tsmiGastosRealizados_Click(sender As Object, e As EventArgs) Handles tsmiGastosRealizados.Click
        frmGastosRealizados.ShowDialog()
    End Sub

    Private Sub tsmiComprasMat_Click(sender As Object, e As EventArgs) Handles tsmiComprasMat.Click
        frmCompraMaterial.ShowDialog()
    End Sub

    Private Sub tsmiConsultasMat_Click(sender As Object, e As EventArgs) Handles tsmiConsultasMat.Click
        frmConsultaMaterial.ShowDialog()
    End Sub

    Private Sub tsmiSalidas_Click(sender As Object, e As EventArgs) Handles tsmiSalidas.Click
        frmSalidaMaterial.ShowDialog()
    End Sub

    Private Sub tsmiConsultaSalida_Click(sender As Object, e As EventArgs) Handles tsmiConsultaSalida.Click
        frmConsultaSalidaMat.ShowDialog()
    End Sub

    Private Sub tsmiPagos_Click(sender As Object, e As EventArgs) Handles tsmiPagos.Click
        'frmPagos.ShowDialog()
    End Sub

    Private Sub tsmiConsultaDePagos_Click(sender As Object, e As EventArgs) Handles tsmiConsultaDePagos.Click
        frmConsultaPagos.ShowDialog()
    End Sub

    Private Sub RegistroDePagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDePagosToolStripMenuItem.Click
        frmPagos.ShowDialog()
    End Sub
End Class
