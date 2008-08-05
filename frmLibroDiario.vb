imports System.Math

Public Partial Class frmLibroDiario
	Dim codCuenta As String
	Dim fdatos As FuenteDatos
	Dim cuentas As List(Of Cuenta)
	Dim partidasDiario As List(Of Partida)
	Dim movimientos As List(Of Movimiento)
	dim cargando as Boolean
	
	Public Sub New()
		Me.InitializeComponent()
		me.fdatos = new FuenteDatos()
	End Sub
	
	Public Sub New(ByVal codCta As String)
		me.codCuenta = codCta
		Me.InitializeComponent()
		me.fdatos = new FuenteDatos()
	End Sub
	
	''' <summary>
	''' Inicializa el formulario y sus controles
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub FrmLibroDiarioLoad(ByVal sender As Object, ByVal e As EventArgs)				
		Me.RellenarCombo()
		If(Me.codCuenta = "") Then
			me.codCuenta = Me.cmbCuentas.Text.Substring(0,me.cmbCuentas.Text.IndexOf("-"))
		End If
		me.RellenarAnios()
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
	''' Rellena el combo con todas las cuentas que posean movimientos
	''' </summary>
	Private Sub RellenarCombo()
		Me.cuentas = fdatos.GetCuentasConMovimientos()		
		Me.cmbCuentas.Items.Clear()
		dim indexCtaSeleccionada as Integer = 0
		For Each cta As Cuenta In Me.cuentas			
			If(Me.codCuenta = cta.Codigo) Then
				indexCtaSeleccionada = Me.cmbCuentas.Items.Add(cta.Codigo + "-" + cta.Nombre)
			Else
				Me.cmbCuentas.Items.Add(cta.Codigo + "-" + cta.Nombre)
			End If
		Next
		me.cmbCuentas.SelectedIndex = indexCtaSeleccionada
	End Sub
	
	''' <summary>
	''' Rellena el grid con los movimientos relacionados con la cuenta seleccionada
	''' </summary>
	Private Sub RellenarGrid()
		Me.partidasDiario = PartidasManager.GetPartidasFromCuenta(Me.codCuenta)
		Me.grdLibroMayor.Rows.Clear()
		Dim tipoInicial As String = ""
		Dim EstiloResaltado As New DataGridViewCellStyle()
		EstiloResaltado.BackColor = Color.LightBlue
		Dim saldo As Double = 0.0
		Dim fechaIni As New DateTime(CInt(me.cmbAnios.Text), 1, 1)
		dim fechaFin as New DateTime(CInt(me.cmbAnios.Text), 12, 31)
		
		Me.grdLibroMayor.Rows.Add()
		Me.grdLibroMayor.Rows(Me.grdLibroMayor.Rows.Count-1).Cells("colDetalle").Value = "Comprobantes de Diario"
		For each celda As DataGridViewTextBoxCell In Me.grdLibroMayor.Rows(Me.grdLibroMayor.Rows.Count-1).Cells
			celda.Style = EstiloResaltado
		Next
		
		For Each ptda As Partida In Me.partidasDiario
			if((ptda.Fecha >= fechaIni and ptda.Fecha <= fechaFin) and ptda.Tipo = "normal") then
				Me.grdLibroMayor.Rows.Add()
				Me.grdLibroMayor.Rows(Me.grdLibroMayor.Rows.Count-1).Cells("colFecha").Value = ptda.Fecha.ToShortDateString()
				Me.grdLibroMayor.Rows(Me.grdLibroMayor.Rows.Count-1).Cells("colDetalle").Value = ptda.Motivo
				Dim mov As Movimiento = PartidasManager.GetMovimientoFromPartida(ptda.Codigo, Me.codCuenta)
				If(tipoInicial = "") Then
					tipoInicial = mov.Tipo
				End If
				If(mov.Tipo = "cargo") Then
					Me.grdLibroMayor.Rows(Me.grdLibroMayor.Rows.Count-1).Cells("colDebe").Value = mov.Monto
					saldo+= CDbl(Me.grdLibroMayor.Rows(Me.grdLibroMayor.Rows.Count-1).Cells("colDebe").Value)				
				Else
					Me.grdLibroMayor.Rows(Me.grdLibroMayor.Rows.Count-1).Cells("colHaber").Value = mov.Monto
					saldo-=CDbl(Me.grdLibroMayor.Rows(Me.grdLibroMayor.Rows.Count-1).Cells("colHaber").Value)
				end if
				Me.grdLibroMayor.Rows(Me.grdLibroMayor.Rows.Count-1).Cells("colSaldo").Value = saldo
			end if
		Next
		
		Me.grdLibroMayor.Rows.Add()
		Me.grdLibroMayor.Rows(Me.grdLibroMayor.Rows.Count-1).Cells("colDetalle").Value = "Comprobantes de Ajuste"
		For each celda as DataGridViewTextBoxCell In Me.grdLibroMayor.Rows(Me.grdLibroMayor.Rows.Count-1).Cells
			celda.Style = EstiloResaltado
		Next
		
		For Each ptda As Partida In Me.partidasDiario
			if((ptda.Fecha >= fechaIni and ptda.Fecha <= fechaFin) and ptda.Tipo = "ajuste") then
				Me.grdLibroMayor.Rows.Add()
				Me.grdLibroMayor.Rows(Me.grdLibroMayor.Rows.Count-1).Cells("colFecha").Value = ptda.Fecha.ToShortDateString()
				Me.grdLibroMayor.Rows(Me.grdLibroMayor.Rows.Count-1).Cells("colDetalle").Value = ptda.Motivo
				Dim mov As Movimiento = PartidasManager.GetMovimientoFromPartida(ptda.Codigo, Me.codCuenta)
				If(tipoInicial = "") Then
					tipoInicial = mov.Tipo
				End If
				If(mov.Tipo = "cargo") Then
					Me.grdLibroMayor.Rows(Me.grdLibroMayor.Rows.Count-1).Cells("colDebe").Value = mov.Monto
					saldo+= CDbl(Me.grdLibroMayor.Rows(Me.grdLibroMayor.Rows.Count-1).Cells("colDebe").Value)				
				Else
					Me.grdLibroMayor.Rows(Me.grdLibroMayor.Rows.Count-1).Cells("colHaber").Value = mov.Monto
					saldo-=CDbl(Me.grdLibroMayor.Rows(Me.grdLibroMayor.Rows.Count-1).Cells("colHaber").Value)
				end if
				Me.grdLibroMayor.Rows(Me.grdLibroMayor.Rows.Count-1).Cells("colSaldo").Value = saldo
			end if
		Next
		
	End Sub
	
	''' <summary>
	''' Actualiza el grid en base a la nueva cuenta seleccionada
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub CmbCuentasSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		if(me.grdLibroMayor.Rows.Count > 0) then
			Me.codCuenta = Me.cmbCuentas.Text.Substring(0,me.cmbCuentas.Text.IndexOf("-"))
			Me.RellenarGrid()
		End If	
	End Sub
	
	''' <summary>
	''' Rellena el combo box de periodos con todos los anios en los que existen movimientos
	''' </summary>
	Public Sub RellenarAnios()
		Me.cmbAnios.Items.Clear()
		me.cargando = true
		For Each anio as String In fdatos.GetPeriodos()
			me.cmbAnios.Items.Add(anio)
		Next	
		me.cargando = false
		me.cmbAnios.SelectedIndex = me.cmbAnios.Items.Count - 1
	End Sub
	
	''' <summary>
	''' Actualiza el grid en base al nuevo anio seleccionado
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub CmbAniosSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		If Not (Me.cargando) Then
			me.RellenarGrid()
		End If
	End Sub
End Class
