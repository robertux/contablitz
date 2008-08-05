
Public Partial Class frmPartidas
	Dim fdatos As New FuenteDatos()
	Dim partidas As List(Of Partida) 
	Dim movimientos As List(Of Movimiento)
	dim cargando, cargandoPartidas as Boolean
	
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
	''' Inicializa el formulario y sus contorles
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub FrmPartidasLoad(ByVal sender As Object, ByVal e As EventArgs)
		me.RellenarAnios()		
	End Sub
	
	''' <summary>
	''' Rellena el grid con todas las partidas existentes en el periodo seleccionado
	''' </summary>
	Public Sub CargarGridPartidas()
		me.cargandoPartidas = true
		Me.grdPartidas.Rows.Clear()
		me.partidas = fdatos.GetPartidas(Me.cmbAnios.Text)
		For Each ptda As Partida In partidas
			Me.grdPartidas.Rows.Add()
			Me.grdPartidas.Rows(Me.grdPartidas.Rows.Count-1).Cells("colNombre").Value = ptda.Nombre
			Me.grdPartidas.Rows(Me.grdPartidas.Rows.Count-1).Cells("colFecha").Value = ptda.Fecha.ToShortDateString()
			Me.grdPartidas.Rows(Me.grdPartidas.Rows.Count-1).Cells("colMotivo").Value = ptda.Motivo
			me.grdPartidas.Rows(me.grdPartidas.Rows.Count-1).Cells("colTipo").Value = ptda.Tipo
		Next
		me.cargandoPartidas = false
		if (me.grdPartidas.Rows.Count > 0) then
			Me.grdPartidas.CurrentCell = Me.grdPartidas.Rows(0).Cells(0)
			Me.CargarGridMovimientos(Me.partidas(Me.grdPartidas.CurrentCell.RowIndex).Codigo)			
		end if
	End Sub
	
	''' <summary>
	''' Rellena el grid de movimientos con todos los movimientos relacionados con la partida seleccionada en el grid de partidas
	''' </summary>
	''' <param name="codPartida">El codigo de la partida seleccionada</param>
	Public Sub CargarGridMovimientos(byval codPartida as String)
		me.grdMovimientos.Rows.Clear()
		Me.movimientos = fdatos.GetMovimientos(codPartida)
		For Each mov As Movimiento In Me.movimientos
			Me.grdMovimientos.Rows.Add()
			Me.grdMovimientos.Rows(Me.grdMovimientos.Rows.Count-1).Cells("colCuenta").Value = mov.Cuenta
			Me.grdMovimientos.Rows(Me.grdMovimientos.Rows.Count-1).Cells("colMonto").Value = mov.Monto
			Me.grdMovimientos.Rows(Me.grdMovimientos.Rows.Count-1).Cells("colTipoMov").Value = mov.Tipo
		Next
		if(me.grdMovimientos.Rows.Count > 0) then
			Me.grdMovimientos.CurrentCell = Me.grdMovimientos.Rows(0).Cells(0)
		end if
	End Sub
	
	''' <summary>
	''' Rellena el combo box con todos los periodos donde existan movimientos
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
	''' Actualiza el combo box de partidas en base al nuevo anio seleccionado
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub CmbAniosSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		if not (me.cargando) then
			Me.CargarGridPartidas()
		end if
	End Sub
	
	''' <summary>
	''' Actualiza el grid de movimientos en base a la nueva partida seleccionada
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub GrdPartidasSelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
		if not (me.cargandoPartidas) then
			Me.CargarGridMovimientos(Me.partidas(Me.grdPartidas.CurrentCell.RowIndex).Codigo)
		end if
	End Sub
	
	''' <summary>
	''' Elimina una partida
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub BtnEliminarPartidaClick(ByVal sender As Object, ByVal e As EventArgs)
		if not(me.grdPartidas.CurrentCell is Nothing) then
			If(msgbox("Esta usted seguro?", Microsoft.VisualBasic.MsgBoxStyle.YesNo, "Confirmacion") = Microsoft.VisualBasic.MsgBoxResult.Yes) Then
				fdatos.EliminarPartida(Me.partidas(Me.grdPartidas.CurrentCell.RowIndex).Codigo)
				me.RellenarAnios()
			End If		
		end if
	End Sub
	
	''' <summary>
	''' Crea e invoca una nueva instancia del formulario de agregar partidas
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub BtnAgregarPartidaClick(ByVal sender As Object, ByVal e As EventArgs)
		Dim fAddPtda As New frmAddPartida()
		fAddPtda.ShowDialog(Me)
		me.RellenarAnios()
	End Sub
	
	''' <summary>
	''' Elimina un movimiento
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub BtnEliminarMovimientoClick(ByVal sender As Object, ByVal e As EventArgs)
		if not(me.grdMovimientos.CurrentCell is Nothing) then
			If(msgbox("Esta usted seguro?", Microsoft.VisualBasic.MsgBoxStyle.YesNo, "Confirmacion") = Microsoft.VisualBasic.MsgBoxResult.Yes) Then
				fdatos.EliminarMovimiento(Me.movimientos(Me.grdMovimientos.CurrentCell.RowIndex).Codigo)
				Me.CargarGridMovimientos(Me.partidas(Me.grdPartidas.CurrentCell.RowIndex).Codigo)
			End If				
		end if
	End Sub
	
	''' <summary>
	''' Crea e invoca una nueva instancia del formulario de agregar movimientos
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub BtnAgregarMovimientoClick(ByVal sender As Object, ByVal e As EventArgs)
		Dim frmAddMov As New frmAddMovimiento(Me.partidas(Me.grdPartidas.CurrentCell.RowIndex).Codigo)
		frmAddMov.ShowDialog(Me)
		Me.CargarGridMovimientos(Me.partidas(Me.grdPartidas.CurrentCell.RowIndex).Codigo)
	End Sub
	
	''' <summary>
	''' Crea e invoca una nueva instancia del formulario de editar montos
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub BtnEditMontoClick(ByVal sender As Object, ByVal e As EventArgs)
		if not (me.grdMovimientos.CurrentCell is nothing) then
			Dim frmEditMonto As New frmEditMonto(me.movimientos(me.grdMovimientos.CurrentCell.RowIndex).Codigo, me.movimientos(me.grdMovimientos.CurrentCell.RowIndex).Monto)
			frmEditMonto.ShowDialog(me)
			Me.CargarGridMovimientos(Me.partidas(Me.grdPartidas.CurrentCell.RowIndex).Codigo)
		end if
	End Sub
End Class
