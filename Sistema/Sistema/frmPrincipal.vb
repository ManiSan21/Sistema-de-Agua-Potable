Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
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

    Private Sub tsmiReporteDeCuentas_Click(sender As Object, e As EventArgs) Handles tsmiReporteDeCuentas.Click
        Dim conexion As New SqlConnection("Data Source=DESKTOP-B3IP6AD\MANI; Initial Catalog='SistemaAguaPotable'; Integrated Security=true")
        Dim cmd As New SqlCommand("REPORTECUENTAS", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Visual Studio 2015\Sistema2\Sistema\Sistema\Report1.rdlc"
        frmReportes.ReportViewer1.RefreshReport()
        frmReportes.ShowDialog()
        conexion.Close()
    End Sub

    Private Sub tsmiReporteDeCalles_Click(sender As Object, e As EventArgs) Handles tsmiReporteDeCalles.Click
        Dim conexion As New SqlConnection("Data Source=DESKTOP-B3IP6AD\MANI; Initial Catalog='SistemaAguaPotable'; Integrated Security=true")
        Dim cmd As New SqlCommand("REPORTECALLES", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Visual Studio 2015\Sistema2\Sistema\Sistema\Report2.rdlc"
        frmReportes.ReportViewer1.RefreshReport()
        frmReportes.ShowDialog()
        conexion.Close()
    End Sub

    Private Sub tsmiReporteDeMaterialesConExistencia_Click(sender As Object, e As EventArgs) Handles tsmiReporteDeMaterialesConExistencia.Click
        Dim conexion As New SqlConnection("Data Source=DESKTOP-B3IP6AD\MANI; Initial Catalog='SistemaAguaPotable'; Integrated Security=true")
        Dim cmd As New SqlCommand("REPORTEMATERIALESCONEXISTENCIA", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Visual Studio 2015\Sistema2\Sistema\Sistema\Report3.rdlc"
        frmReportes.ReportViewer1.RefreshReport()
        frmReportes.ShowDialog()
        conexion.Close()
    End Sub

    Private Sub tsmiReporteDeEmpleados_Click(sender As Object, e As EventArgs) Handles tsmiReporteDeEmpleados.Click
        Dim conexion As New SqlConnection("Data Source=DESKTOP-B3IP6AD\MANI; Initial Catalog='SistemaAguaPotable'; Integrated Security=true")
        Dim cmd As New SqlCommand("REPORTEEMPLEADOS", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Visual Studio 2015\Sistema2\Sistema\Sistema\Report4.rdlc"
        frmReportes.ReportViewer1.RefreshReport()
        frmReportes.ShowDialog()
        conexion.Close()
    End Sub

    Private Sub tsmiReporteDeGastos_Click(sender As Object, e As EventArgs) Handles tsmiReporteDeGastos.Click
        Dim conexion As New SqlConnection("Data Source=DESKTOP-B3IP6AD\MANI; Initial Catalog='SistemaAguaPotable'; Integrated Security=true")
        Dim cmd As New SqlCommand("REPORTEGASTOS", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Visual Studio 2015\Sistema2\Sistema\Sistema\Report5.rdlc"
        frmReportes.ReportViewer1.RefreshReport()
        frmReportes.ShowDialog()
        conexion.Close()
    End Sub

    Private Sub tsmiReporteDeTarifas_Click(sender As Object, e As EventArgs) Handles tsmiReporteDeTarifas.Click
        Dim conexion As New SqlConnection("Data Source=DESKTOP-B3IP6AD\MANI; Initial Catalog='SistemaAguaPotable'; Integrated Security=true")
        Dim cmd As New SqlCommand("REPORTETARIFAS", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Visual Studio 2015\Sistema2\Sistema\Sistema\Report6.rdlc"
        frmReportes.ReportViewer1.RefreshReport()
        frmReportes.ShowDialog()
        conexion.Close()
    End Sub

    Private Sub tsmiReporteDePozos_Click(sender As Object, e As EventArgs) Handles tsmiReporteDePozos.Click
        Dim conexion As New SqlConnection("Data Source=DESKTOP-B3IP6AD\MANI; Initial Catalog='SistemaAguaPotable'; Integrated Security=true")
        Dim cmd As New SqlCommand("REPORTEPOZOS", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Visual Studio 2015\Sistema2\Sistema\Sistema\Report7.rdlc"
        frmReportes.ReportViewer1.RefreshReport()
        frmReportes.ShowDialog()
        conexion.Close()
    End Sub

    Private Sub tsmiCuentasPorCalle_Click(sender As Object, e As EventArgs) Handles tsmiCuentasPorCalle.Click
        Dim conexion As New SqlConnection("Data Source=DESKTOP-B3IP6AD\MANI; Initial Catalog='SistemaAguaPotable'; Integrated Security=true")
        Dim cmd As New SqlCommand("REPORTECUENTASPORCALLE", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Visual Studio 2015\Sistema2\Sistema\Sistema\Report8.rdlc"
        frmReportes.ReportViewer1.RefreshReport()
        frmReportes.ShowDialog()
        conexion.Close()
    End Sub
End Class
