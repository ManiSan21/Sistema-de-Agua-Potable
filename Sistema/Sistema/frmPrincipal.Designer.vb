﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmiArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCatalogos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniCalles = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniCuentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniMateriales = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniGastos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniTarifas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniPozos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniServicios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniProveedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniSituacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiActividadDePozo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiGastosRealizados = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMaterial = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEntradaMat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiComprasMat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiConsultasMat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSalidaMat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSalidas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiConsultaSalida = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPagos = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDePagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiConsultaDePagos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReporteDeCuentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCuentasPorCalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReporteDeCalles = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReporteDeMaterialesConExistencia = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReporteDeEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReporteDeGastos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReporteDeTarifas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiReporteDePozos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeClientesMorososToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialDePagosPorCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeEntradaDeMaterialEnUnPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeSalidasDeMaterialEnUnPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelaciónDeGastosEnUnPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelaciónDePagosEnUnPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelaciónDeActividadDePozosEnUnPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiArchivo, Me.tsmiCatalogos, Me.MovimientosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(339, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmiArchivo
        '
        Me.tsmiArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniSalir})
        Me.tsmiArchivo.Name = "tsmiArchivo"
        Me.tsmiArchivo.Size = New System.Drawing.Size(60, 20)
        Me.tsmiArchivo.Text = "Archivo"
        '
        'mniSalir
        '
        Me.mniSalir.Name = "mniSalir"
        Me.mniSalir.Size = New System.Drawing.Size(96, 22)
        Me.mniSalir.Text = "Salir"
        '
        'tsmiCatalogos
        '
        Me.tsmiCatalogos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniCalles, Me.mniCuentas, Me.mniMateriales, Me.mniEmpleados, Me.mniGastos, Me.mniTarifas, Me.mniPozos, Me.mniServicios, Me.mniProveedores, Me.mniSituacion})
        Me.tsmiCatalogos.Name = "tsmiCatalogos"
        Me.tsmiCatalogos.Size = New System.Drawing.Size(72, 20)
        Me.tsmiCatalogos.Text = "Catalogos"
        '
        'mniCalles
        '
        Me.mniCalles.Name = "mniCalles"
        Me.mniCalles.Size = New System.Drawing.Size(139, 22)
        Me.mniCalles.Text = "Calles"
        '
        'mniCuentas
        '
        Me.mniCuentas.Name = "mniCuentas"
        Me.mniCuentas.Size = New System.Drawing.Size(139, 22)
        Me.mniCuentas.Text = "Cuentas"
        '
        'mniMateriales
        '
        Me.mniMateriales.Name = "mniMateriales"
        Me.mniMateriales.Size = New System.Drawing.Size(139, 22)
        Me.mniMateriales.Text = "Materiales"
        '
        'mniEmpleados
        '
        Me.mniEmpleados.Name = "mniEmpleados"
        Me.mniEmpleados.Size = New System.Drawing.Size(139, 22)
        Me.mniEmpleados.Text = "Empleados"
        '
        'mniGastos
        '
        Me.mniGastos.Name = "mniGastos"
        Me.mniGastos.Size = New System.Drawing.Size(139, 22)
        Me.mniGastos.Text = "Gastos"
        '
        'mniTarifas
        '
        Me.mniTarifas.Name = "mniTarifas"
        Me.mniTarifas.Size = New System.Drawing.Size(139, 22)
        Me.mniTarifas.Text = "Tarifas"
        '
        'mniPozos
        '
        Me.mniPozos.Name = "mniPozos"
        Me.mniPozos.Size = New System.Drawing.Size(139, 22)
        Me.mniPozos.Text = "Pozos"
        '
        'mniServicios
        '
        Me.mniServicios.Name = "mniServicios"
        Me.mniServicios.Size = New System.Drawing.Size(139, 22)
        Me.mniServicios.Text = "Servicios"
        '
        'mniProveedores
        '
        Me.mniProveedores.Name = "mniProveedores"
        Me.mniProveedores.Size = New System.Drawing.Size(139, 22)
        Me.mniProveedores.Text = "Proveedores"
        '
        'mniSituacion
        '
        Me.mniSituacion.Name = "mniSituacion"
        Me.mniSituacion.Size = New System.Drawing.Size(139, 22)
        Me.mniSituacion.Text = "Situación"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiActividadDePozo, Me.tsmiGastosRealizados, Me.tsmiMaterial, Me.tsmiPagos})
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'tsmiActividadDePozo
        '
        Me.tsmiActividadDePozo.Name = "tsmiActividadDePozo"
        Me.tsmiActividadDePozo.Size = New System.Drawing.Size(170, 22)
        Me.tsmiActividadDePozo.Text = "Actividad De Pozo"
        '
        'tsmiGastosRealizados
        '
        Me.tsmiGastosRealizados.Name = "tsmiGastosRealizados"
        Me.tsmiGastosRealizados.Size = New System.Drawing.Size(170, 22)
        Me.tsmiGastosRealizados.Text = "Gastos Realizados"
        '
        'tsmiMaterial
        '
        Me.tsmiMaterial.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiEntradaMat, Me.tsmiSalidaMat})
        Me.tsmiMaterial.Name = "tsmiMaterial"
        Me.tsmiMaterial.Size = New System.Drawing.Size(170, 22)
        Me.tsmiMaterial.Text = "Material"
        '
        'tsmiEntradaMat
        '
        Me.tsmiEntradaMat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiComprasMat, Me.tsmiConsultasMat})
        Me.tsmiEntradaMat.Name = "tsmiEntradaMat"
        Me.tsmiEntradaMat.Size = New System.Drawing.Size(114, 22)
        Me.tsmiEntradaMat.Text = "Entrada"
        '
        'tsmiComprasMat
        '
        Me.tsmiComprasMat.Name = "tsmiComprasMat"
        Me.tsmiComprasMat.Size = New System.Drawing.Size(126, 22)
        Me.tsmiComprasMat.Text = "Compras"
        '
        'tsmiConsultasMat
        '
        Me.tsmiConsultasMat.Name = "tsmiConsultasMat"
        Me.tsmiConsultasMat.Size = New System.Drawing.Size(126, 22)
        Me.tsmiConsultasMat.Text = "Consultas"
        '
        'tsmiSalidaMat
        '
        Me.tsmiSalidaMat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSalidas, Me.tsmiConsultaSalida})
        Me.tsmiSalidaMat.Name = "tsmiSalidaMat"
        Me.tsmiSalidaMat.Size = New System.Drawing.Size(114, 22)
        Me.tsmiSalidaMat.Text = "Salida"
        '
        'tsmiSalidas
        '
        Me.tsmiSalidas.Name = "tsmiSalidas"
        Me.tsmiSalidas.Size = New System.Drawing.Size(121, 22)
        Me.tsmiSalidas.Text = "Salidas"
        '
        'tsmiConsultaSalida
        '
        Me.tsmiConsultaSalida.Name = "tsmiConsultaSalida"
        Me.tsmiConsultaSalida.Size = New System.Drawing.Size(121, 22)
        Me.tsmiConsultaSalida.Text = "Consulta"
        '
        'tsmiPagos
        '
        Me.tsmiPagos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroDePagosToolStripMenuItem, Me.tsmiConsultaDePagos})
        Me.tsmiPagos.Name = "tsmiPagos"
        Me.tsmiPagos.Size = New System.Drawing.Size(170, 22)
        Me.tsmiPagos.Text = "Pagos"
        '
        'RegistroDePagosToolStripMenuItem
        '
        Me.RegistroDePagosToolStripMenuItem.Name = "RegistroDePagosToolStripMenuItem"
        Me.RegistroDePagosToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.RegistroDePagosToolStripMenuItem.Text = "Registro de pagos"
        '
        'tsmiConsultaDePagos
        '
        Me.tsmiConsultaDePagos.Name = "tsmiConsultaDePagos"
        Me.tsmiConsultaDePagos.Size = New System.Drawing.Size(172, 22)
        Me.tsmiConsultaDePagos.Text = "Consulta de pagos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiReporteDeCuentas, Me.tsmiCuentasPorCalle, Me.tsmiReporteDeCalles, Me.tsmiReporteDeMaterialesConExistencia, Me.tsmiReporteDeEmpleados, Me.tsmiReporteDeGastos, Me.tsmiReporteDeTarifas, Me.tsmiReporteDePozos, Me.ReporteDeProveedoresToolStripMenuItem, Me.ReporteDeClientesMorososToolStripMenuItem, Me.HistorialDePagosPorCuentaToolStripMenuItem, Me.ListadoDeServiciosToolStripMenuItem, Me.ReporteDeEntradaDeMaterialEnUnPeriodoToolStripMenuItem, Me.ReporteDeSalidasDeMaterialEnUnPeriodoToolStripMenuItem, Me.RelaciónDeGastosEnUnPeriodoToolStripMenuItem, Me.RelaciónDePagosEnUnPeriodoToolStripMenuItem, Me.RelaciónDeActividadDePozosEnUnPeriodoToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'tsmiReporteDeCuentas
        '
        Me.tsmiReporteDeCuentas.Name = "tsmiReporteDeCuentas"
        Me.tsmiReporteDeCuentas.Size = New System.Drawing.Size(317, 22)
        Me.tsmiReporteDeCuentas.Text = "Reporte de cuentas"
        '
        'tsmiCuentasPorCalle
        '
        Me.tsmiCuentasPorCalle.Name = "tsmiCuentasPorCalle"
        Me.tsmiCuentasPorCalle.Size = New System.Drawing.Size(317, 22)
        Me.tsmiCuentasPorCalle.Text = "Reporte de cuentas por calle"
        '
        'tsmiReporteDeCalles
        '
        Me.tsmiReporteDeCalles.Name = "tsmiReporteDeCalles"
        Me.tsmiReporteDeCalles.Size = New System.Drawing.Size(317, 22)
        Me.tsmiReporteDeCalles.Text = "Reporte de calles"
        '
        'tsmiReporteDeMaterialesConExistencia
        '
        Me.tsmiReporteDeMaterialesConExistencia.Name = "tsmiReporteDeMaterialesConExistencia"
        Me.tsmiReporteDeMaterialesConExistencia.Size = New System.Drawing.Size(317, 22)
        Me.tsmiReporteDeMaterialesConExistencia.Text = "Reporte de materiales con existencia"
        '
        'tsmiReporteDeEmpleados
        '
        Me.tsmiReporteDeEmpleados.Name = "tsmiReporteDeEmpleados"
        Me.tsmiReporteDeEmpleados.Size = New System.Drawing.Size(317, 22)
        Me.tsmiReporteDeEmpleados.Text = "Reporte de Empleados"
        '
        'tsmiReporteDeGastos
        '
        Me.tsmiReporteDeGastos.Name = "tsmiReporteDeGastos"
        Me.tsmiReporteDeGastos.Size = New System.Drawing.Size(317, 22)
        Me.tsmiReporteDeGastos.Text = "Reporte de Gastos"
        '
        'tsmiReporteDeTarifas
        '
        Me.tsmiReporteDeTarifas.Name = "tsmiReporteDeTarifas"
        Me.tsmiReporteDeTarifas.Size = New System.Drawing.Size(317, 22)
        Me.tsmiReporteDeTarifas.Text = "Reporte de Tarifas"
        '
        'tsmiReporteDePozos
        '
        Me.tsmiReporteDePozos.Name = "tsmiReporteDePozos"
        Me.tsmiReporteDePozos.Size = New System.Drawing.Size(317, 22)
        Me.tsmiReporteDePozos.Text = "Reporte de pozos"
        '
        'ReporteDeProveedoresToolStripMenuItem
        '
        Me.ReporteDeProveedoresToolStripMenuItem.Name = "ReporteDeProveedoresToolStripMenuItem"
        Me.ReporteDeProveedoresToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.ReporteDeProveedoresToolStripMenuItem.Text = "Reporte de proveedores"
        '
        'ReporteDeClientesMorososToolStripMenuItem
        '
        Me.ReporteDeClientesMorososToolStripMenuItem.Name = "ReporteDeClientesMorososToolStripMenuItem"
        Me.ReporteDeClientesMorososToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.ReporteDeClientesMorososToolStripMenuItem.Text = "Reporte de clientes morosos"
        '
        'HistorialDePagosPorCuentaToolStripMenuItem
        '
        Me.HistorialDePagosPorCuentaToolStripMenuItem.Name = "HistorialDePagosPorCuentaToolStripMenuItem"
        Me.HistorialDePagosPorCuentaToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.HistorialDePagosPorCuentaToolStripMenuItem.Text = "Historial de pagos por cliente"
        '
        'ListadoDeServiciosToolStripMenuItem
        '
        Me.ListadoDeServiciosToolStripMenuItem.Name = "ListadoDeServiciosToolStripMenuItem"
        Me.ListadoDeServiciosToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.ListadoDeServiciosToolStripMenuItem.Text = "Listado de servicios"
        '
        'ReporteDeEntradaDeMaterialEnUnPeriodoToolStripMenuItem
        '
        Me.ReporteDeEntradaDeMaterialEnUnPeriodoToolStripMenuItem.Name = "ReporteDeEntradaDeMaterialEnUnPeriodoToolStripMenuItem"
        Me.ReporteDeEntradaDeMaterialEnUnPeriodoToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.ReporteDeEntradaDeMaterialEnUnPeriodoToolStripMenuItem.Text = "Relación de entrada de material en un periodo"
        '
        'ReporteDeSalidasDeMaterialEnUnPeriodoToolStripMenuItem
        '
        Me.ReporteDeSalidasDeMaterialEnUnPeriodoToolStripMenuItem.Name = "ReporteDeSalidasDeMaterialEnUnPeriodoToolStripMenuItem"
        Me.ReporteDeSalidasDeMaterialEnUnPeriodoToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.ReporteDeSalidasDeMaterialEnUnPeriodoToolStripMenuItem.Text = "Relación de salidas de material en un periodo"
        '
        'RelaciónDeGastosEnUnPeriodoToolStripMenuItem
        '
        Me.RelaciónDeGastosEnUnPeriodoToolStripMenuItem.Name = "RelaciónDeGastosEnUnPeriodoToolStripMenuItem"
        Me.RelaciónDeGastosEnUnPeriodoToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.RelaciónDeGastosEnUnPeriodoToolStripMenuItem.Text = "Relación de gastos en un periodo"
        '
        'RelaciónDePagosEnUnPeriodoToolStripMenuItem
        '
        Me.RelaciónDePagosEnUnPeriodoToolStripMenuItem.Name = "RelaciónDePagosEnUnPeriodoToolStripMenuItem"
        Me.RelaciónDePagosEnUnPeriodoToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.RelaciónDePagosEnUnPeriodoToolStripMenuItem.Text = "Relación de pagos en un periodo"
        '
        'RelaciónDeActividadDePozosEnUnPeriodoToolStripMenuItem
        '
        Me.RelaciónDeActividadDePozosEnUnPeriodoToolStripMenuItem.Name = "RelaciónDeActividadDePozosEnUnPeriodoToolStripMenuItem"
        Me.RelaciónDeActividadDePozosEnUnPeriodoToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.RelaciónDeActividadDePozosEnUnPeriodoToolStripMenuItem.Text = "Relación de actividad de pozos en un periodo"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 290)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmPrincipal"
        Me.Text = "Formulario principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmiArchivo As ToolStripMenuItem
    Friend WithEvents mniSalir As ToolStripMenuItem
    Friend WithEvents tsmiCatalogos As ToolStripMenuItem
    Friend WithEvents mniCalles As ToolStripMenuItem
    Friend WithEvents mniCuentas As ToolStripMenuItem
    Friend WithEvents mniMateriales As ToolStripMenuItem
    Friend WithEvents mniEmpleados As ToolStripMenuItem
    Friend WithEvents mniGastos As ToolStripMenuItem
    Friend WithEvents mniTarifas As ToolStripMenuItem
    Friend WithEvents mniPozos As ToolStripMenuItem
    Friend WithEvents mniServicios As ToolStripMenuItem
    Friend WithEvents mniProveedores As ToolStripMenuItem
    Friend WithEvents mniSituacion As ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmiActividadDePozo As ToolStripMenuItem
    Friend WithEvents tsmiGastosRealizados As ToolStripMenuItem
    Friend WithEvents tsmiMaterial As ToolStripMenuItem
    Friend WithEvents tsmiEntradaMat As ToolStripMenuItem
    Friend WithEvents tsmiSalidaMat As ToolStripMenuItem
    Friend WithEvents tsmiComprasMat As ToolStripMenuItem
    Friend WithEvents tsmiConsultasMat As ToolStripMenuItem
    Friend WithEvents tsmiSalidas As ToolStripMenuItem
    Friend WithEvents tsmiConsultaSalida As ToolStripMenuItem
    Friend WithEvents tsmiPagos As ToolStripMenuItem
    Friend WithEvents RegistroDePagosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmiConsultaDePagos As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmiReporteDeCuentas As ToolStripMenuItem
    Friend WithEvents tsmiCuentasPorCalle As ToolStripMenuItem
    Friend WithEvents tsmiReporteDeCalles As ToolStripMenuItem
    Friend WithEvents tsmiReporteDeMaterialesConExistencia As ToolStripMenuItem
    Friend WithEvents tsmiReporteDeEmpleados As ToolStripMenuItem
    Friend WithEvents tsmiReporteDeGastos As ToolStripMenuItem
    Friend WithEvents tsmiReporteDeTarifas As ToolStripMenuItem
    Friend WithEvents tsmiReporteDePozos As ToolStripMenuItem
    Friend WithEvents ReporteDeProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeClientesMorososToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialDePagosPorCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeEntradaDeMaterialEnUnPeriodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeSalidasDeMaterialEnUnPeriodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelaciónDeGastosEnUnPeriodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelaciónDePagosEnUnPeriodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelaciónDeActividadDePozosEnUnPeriodoToolStripMenuItem As ToolStripMenuItem
End Class
