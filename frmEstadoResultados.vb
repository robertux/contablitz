
Public Partial Class frmEstadoResultados
	Dim fdatos As New FuenteDatos()
	Dim cuentasIngresos As New List(Of Cuenta)
	Dim cuentasGastos As New List(Of Cuenta)
	Dim cargando As Boolean
	dim utilidadNeta as Double
	
	Public Sub New()
		Me.InitializeComponent()
	End Sub
	
	''' <summary>
	''' Cierra el formulario
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub BtnCerrarClick(ByVal sender As Object, ByVal e As EventArgs)
		me.Close()
	End Sub
	
	''' <summary>
	''' Inicializa el formulario y sus controles
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub FrmEstadoResultadosLoad(ByVal sender As Object, ByVal e As EventArgs)
		Me.RellenarPeriodos()
		dim totalCuentas as List(Of Cuenta) = fdatos.GetCuentas()
		Me.cuentasIngresos = fdatos.GetTodasLasHijas("5.1.1")
		dim totalIngresos as Integer = me.cuentasIngresos.Count
		Me.cuentasGastos = fdatos.GetTodasLasHijas("4.1")		
		dim totalGastos as Integer = me.cuentasGastos.Count
	End Sub
	
	''' <summary>
	''' Rellena el combo box con los anios y los meses en los que existen movimientos
	''' </summary>
	Public Sub RellenarPeriodos()
		me.cargando = true
		Me.cmbPeriodos.Items.Clear()
		For Each anio as String In fdatos.GetPeriodos()
			me.cmbPeriodos.Items.Add(anio)
		Next
		
		Me.comboBox1.Items.Clear()
		Me.comboBox1.Items.Add("01 - Enero")
		Me.comboBox1.Items.Add("02 - Febrero")
		Me.comboBox1.Items.Add("03 - Marzo")
		Me.comboBox1.Items.Add("04 - Abril")
		Me.comboBox1.Items.Add("05 - Mayo")
		Me.comboBox1.Items.Add("06 - Junio")
		Me.comboBox1.Items.Add("07 - Julio")
		Me.comboBox1.Items.Add("08 - Agosto")
		Me.comboBox1.Items.Add("09 - Septiembre")
		Me.comboBox1.Items.Add("10 - Octubre")
		Me.comboBox1.Items.Add("11 - Noviembre")
		me.comboBox1.Items.Add("12 - Diciembre")
		me.comboBox1.SelectedIndex = 0
		
		me.cargando = false
		me.cmbPeriodos.SelectedIndex = me.cmbPeriodos.Items.Count - 1
	End Sub
	
	''' <summary>
	''' Rellena el grid con las utilidades y los costos de las cuentas referentes al periodo actual
	''' </summary>
	Private Sub RellenarGrid()		
		me.grdEstadoResultados.Rows.Clear()
		Dim EstiloResaltado As New DataGridViewCellStyle()
		EstiloResaltado.BackColor = Color.LightBlue
		Dim EstiloResaltado2 As New DataGridViewCellStyle()
		EstiloResaltado2.Font = New Font("Arial", 12, FontStyle.Bold)
		EstiloResaltado2.BackColor = Color.LightCoral
		Dim anio As Integer =CInt(me.cmbPeriodos.Text)
		dim mes as Integer = CInt(me.comboBox1.Text.Substring(0,2))
		Dim fechaIni As New DateTime(anio, mes, 1)		
		Dim fechaFin As New DateTime(anio, mes, DateTime.DaysInMonth(anio, mes))
		Dim cargos, abonos, totalIngresos, totalGastos, saldo, uNeta As Double
		dim rowIngresos, rowGastos as Integer
		
		Me.grdEstadoResultados.Rows.Add()
		Me.grdEstadoResultados.Rows(Me.grdEstadoResultados.Rows.Count-1).Cells("colCuenta").Value = "Ingresos:"
		rowIngresos = me.grdEstadoResultados.Rows(me.grdEstadoResultados.Rows.Count-1).Index
		For each celda As DataGridViewTextBoxCell In Me.grdEstadoResultados.Rows(Me.grdEstadoResultados.Rows.Count-1).Cells
			celda.Style = EstiloResaltado
		Next
		
		For Each cta As Cuenta In Me.cuentasIngresos
			cargos = fdatos.GetTotalFromCuenta(cta.Codigo, "cargo", anio, mes)
			abonos = fdatos.GetTotalFromCuenta(cta.Codigo, "abono", anio, mes)
			if(cargos <> 0.0 Or abonos <> 0.0) then
				Me.grdEstadoResultados.Rows.Add()
				Me.grdEstadoResultados.Rows(Me.grdEstadoResultados.Rows.Count-1).Cells("colCuenta").Value = cta.Codigo + " - " + cta.Nombre
				saldo = abonos - cargos
				totalIngresos += saldo
				Me.grdEstadoResultados.Rows(Me.grdEstadoResultados.Rows.Count-1).Cells("colParcial").Value = saldo
			end if
		Next
		me.grdEstadoResultados.Rows(rowIngresos).Cells("colTotal").Value = totalIngresos
		
		Me.grdEstadoResultados.Rows.Add()
		Me.grdEstadoResultados.Rows(Me.grdEstadoResultados.Rows.Count-1).Cells("colCuenta").Value = "Gastos:"
		rowGastos = me.grdEstadoResultados.Rows(me.grdEstadoResultados.Rows.Count-1).Index
		For each celda as DataGridViewTextBoxCell In Me.grdEstadoResultados.Rows(Me.grdEstadoResultados.Rows.Count-1).Cells
			celda.Style = EstiloResaltado
		Next
		
		For Each cta As Cuenta In Me.cuentasGastos
			cargos = fdatos.GetTotalFromCuenta(cta.Codigo, "cargo", anio, mes)
			abonos = fdatos.GetTotalFromCuenta(cta.Codigo, "abono", anio, mes)
			if(cargos <> 0.0 Or abonos <> 0.0) then
				Me.grdEstadoResultados.Rows.Add()
				Me.grdEstadoResultados.Rows(Me.grdEstadoResultados.Rows.Count-1).Cells("colCuenta").Value = cta.Codigo + " - " + cta.Nombre
				saldo = cargos - abonos
				totalGastos += saldo
				Me.grdEstadoResultados.Rows(Me.grdEstadoResultados.Rows.Count-1).Cells("colParcial").Value = saldo
			end if
		Next
		
		me.grdEstadoResultados.Rows(rowGastos).Cells("colTotal").Value = totalGastos
		
		Me.grdEstadoResultados.Rows.Add()
		uNeta = totalIngresos - totalGastos
		Me.grdEstadoResultados.Rows(Me.grdEstadoResultados.Rows.Count-1).Cells("colCuenta").Value = "Utilidad Neta: "
		Me.grdEstadoResultados.Rows(Me.grdEstadoResultados.Rows.Count-1).Cells("colTotal").Value = uNeta
		For Each celda As DataGridViewTextBoxCell In Me.grdEstadoResultados.Rows(Me.grdEstadoResultados.Rows.Count-1).Cells
			celda.Style = EstiloResaltado2
		Next
		
		Dim ctaCapital As Cuenta = fdatos.GetCuenta("3.1.1")
		Dim ctaRetiros As Cuenta = fdatos.GetCuenta("9.1.1")
		Dim cargosRetiros As Double = fdatos.GetTotalFromCuenta(ctaRetiros.Codigo, "cargo", anio, mes)
		Dim abonosRetiros As Double = fdatos.GetTotalFromCuenta(ctaRetiros.Codigo, "abono", anio, mes)
		dim saldoRetiros as Double = cargosRetiros - abonosRetiros
		Dim cargosCapital As Double = fdatos.GetTotalFromCuenta(ctaCapital.Codigo, "cargo", anio, mes)
		Dim abonosCapital As Double = fdatos.GetTotalFromCuenta(ctaCapital.Codigo, "abono", anio, mes)
		dim saldoCapital as Double = abonosCapital - cargosCapital
		Me.grdCapital.Rows.Clear()
		Me.grdCapital.Rows.Add()
		Me.grdCapital.Rows(Me.grdCapital.Rows.Count-1).Cells("colCuenta1").Value = ctaCapital.Codigo + " - " + ctaCapital.Nombre
		Me.grdCapital.Rows(Me.grdCapital.Rows.Count-1).Cells("colParcial1").Value = saldoCapital		
		me.grdCapital.Rows.Add()
		Me.grdCapital.Rows(Me.grdCapital.Rows.Count-1).Cells("colCuenta1").Value = "Utilidad Neta"
		Me.grdCapital.Rows(Me.grdCapital.Rows.Count-1).Cells("colParcial1").Value = uNeta
		Me.grdCapital.Rows.Add()
		Me.grdCapital.Rows(Me.grdCapital.Rows.Count-1).Cells("colTotal1").Value = saldoCapital + uNeta
		Me.grdCapital.Rows.Add()
		Me.grdCapital.Rows(Me.grdCapital.Rows.Count-1).Cells("colCuenta1").Value = ctaRetiros.Codigo + " - " + ctaRetiros.Nombre
		Me.grdCapital.Rows(Me.grdCapital.Rows.Count-1).Cells("colParcial1").Value = saldoRetiros
		Me.grdCapital.Rows.Add()
		Me.grdCapital.Rows(Me.grdCapital.Rows.Count-1).Cells("colTotal1").Value = (saldoCapital + uNeta) - saldoRetiros
		For Each celda As DataGridViewTextBoxCell In Me.grdCapital.Rows(Me.grdCapital.Rows.Count-1).Cells
			celda.Style = EstiloResaltado2
		Next
	End Sub
	
	''' <summary>
	''' Actualiza el grid en base al nuevo anio seleccionado
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub CmbPeriodosSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		if not (me.cargando) then
			Me.RellenarGrid()
		end if
	End Sub
	
	''' <summary>
	''' Actualiza el grid en base al nuevo mes seleccionado
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub ComboBox1SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		if not (me.cargando) then
			Me.RellenarGrid()
		end if
	End Sub
End Class
