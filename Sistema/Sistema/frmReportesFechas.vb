Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmReportesFechas
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim f1 As String
        Dim f2 As String
        f1 = CStr(dtpFecha1.Value.Date)
        f2 = CStr(dtpFecha2.Value.Date)
        Dim conexion As New SqlConnection("Data Source=DESKTOP-B3IP6AD\MANI; Initial Catalog='SistemaAguaPotable'; Integrated Security=true")
        If banEntradaMat = True Then
            Dim cmd As New SqlCommand("REPORTEENTRADAMATERIALPERIODO", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.CommandText = "REPORTEENTRADAMATERIALPERIODO"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 As New SqlParameter("@FECHA1", SqlDbType.Date)
            Dim param2 As New SqlParameter("@FECHA2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(f1)
            param2.Value = CDate(f2)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", f1)
            Dim p2 As New ReportParameter("P2", f2)
            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Visual Studio 2015\Sistema2\Sistema\Sistema\Report11.rdlc"
            frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.ShowDialog()
            conexion.Close()
        ElseIf banSalidaMat = True Then
            Dim cmd As New SqlCommand("REPORTESALIDAMATERIALPERIODO", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.CommandText = "REPORTESALIDAMATERIALPERIODO"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 As New SqlParameter("@FECHA1", SqlDbType.Date)
            Dim param2 As New SqlParameter("@FECHA2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(f1)
            param2.Value = CDate(f2)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", f1)
            Dim p2 As New ReportParameter("P2", f2)
            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Visual Studio 2015\Sistema2\Sistema\Sistema\Report12.rdlc"
            frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.ShowDialog()
            conexion.Close()
        ElseIf banHistPagos = True Then
            Dim idCuenta As Integer = CInt(txtIdCuentaReporte.Text)
            Dim cmd As New SqlCommand("REPORTEHISTORIALPAGOSCLIENTE", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.CommandText = "REPORTEHISTORIALPAGOSCLIENTE"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 As New SqlParameter("@IDCUENTA", SqlDbType.Int)
            param1.Direction = ParameterDirection.Input
            param1.Value = idCuenta
            adaptador.SelectCommand.Parameters.Add(param1)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", idCuenta)
            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Visual Studio 2015\Sistema2\Sistema\Sistema\Report13.rdlc"
            frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1})
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.ShowDialog()
            conexion.Close()
        ElseIf banGastos = True Then
            Dim cmd As New SqlCommand("REPORTEGASTOSPERIODOS", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.CommandText = "REPORTEGASTOSPERIODOS"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 As New SqlParameter("@FECHA1", SqlDbType.Date)
            Dim param2 As New SqlParameter("@FECHA2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(f1)
            param2.Value = CDate(f2)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", f1)
            Dim p2 As New ReportParameter("P2", f2)
            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Visual Studio 2015\Sistema2\Sistema\Sistema\Report15.rdlc"
            frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.ShowDialog()
            conexion.Close()
        ElseIf banPagos = True Then
            Dim cmd As New SqlCommand("REPORTEPAGOSPERIODO", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.CommandText = "REPORTEPAGOSPERIODO"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 As New SqlParameter("@FECHA1", SqlDbType.Date)
            Dim param2 As New SqlParameter("@FECHA2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(f1)
            param2.Value = CDate(f2)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", f1)
            Dim p2 As New ReportParameter("P2", f2)
            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Visual Studio 2015\Sistema2\Sistema\Sistema\Report16.rdlc"
            frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.ShowDialog()
            conexion.Close()
        ElseIf banActPozos = True Then
            Dim cmd As New SqlCommand("REPORTEACTIVIDADPOZOSPERIODO", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.CommandText = "REPORTEACTIVIDADPOZOSPERIODO"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 As New SqlParameter("@FECHA1", SqlDbType.Date)
            Dim param2 As New SqlParameter("@FECHA2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(f1)
            param2.Value = CDate(f2)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", f1)
            Dim p2 As New ReportParameter("P2", f2)
            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Visual Studio 2015\Sistema2\Sistema\Sistema\Report17.rdlc"
            frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.ShowDialog()
            conexion.Close()
        ElseIf banServAt = True Then
            Dim cmd As New SqlCommand("REPORTESERVICIOSPERIODO", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter
            adaptador.SelectCommand = New SqlCommand
            adaptador.SelectCommand.Connection = conexion
            adaptador.SelectCommand.CommandText = "REPORTESERVICIOSPERIODO"
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 As New SqlParameter("@FECHA1", SqlDbType.Date)
            Dim param2 As New SqlParameter("@FECHA2", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(f1)
            param2.Value = CDate(f2)
            adaptador.SelectCommand.Parameters.Add(param1)
            adaptador.SelectCommand.Parameters.Add(param2)
            Dim dataset As New DataSet
            adaptador.Fill(dataset)
            dataset.DataSetName = "DataSet1"
            Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
            datasource.Name = "DataSet1"
            datasource.Value = dataset.Tables(0)
            Dim p1 As New ReportParameter("P1", f1)
            Dim p2 As New ReportParameter("P2", f2)
            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Visual Studio 2015\Sistema2\Sistema\Sistema\Report18.rdlc"
            frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.ShowDialog()
            conexion.Close()
        End If
    End Sub

    Private Sub frmReportesFechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If banHistPagos = True Then
            Label1.Visible = False
            Label2.Visible = False
            dtpFecha1.Visible = False
            dtpFecha2.Visible = False
            Label3.Visible = True
            txtIdCuentaReporte.Visible = True
        Else
            Label1.Visible = True
            Label2.Visible = True
            dtpFecha1.Visible = True
            dtpFecha2.Visible = True
            Label3.Visible = False
            txtIdCuentaReporte.Visible = False
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        banActPozos = False
        banClientesMor = False
        banEntradaMat = False
        banGastos = False
        banHistPagos = False
        banListServicios = False
        banPagos = False
        banSalidaMat = False
        Me.Close()
    End Sub
End Class