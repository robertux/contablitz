
Public Partial Class frmCierres
	Dim fdatos As FuenteDatos
	dim cuentasNormales as List(Of Cuenta)
	
	Public Sub New()
		Me.InitializeComponent()
	End Sub
	
	''' <summary>
	''' Inicializa el formulario y sus controles
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub FrmCierresLoad(ByVal sender As Object, ByVal e As EventArgs)
		Me.fdatos = New FuenteDatos()
		Me.RellenarPeriodos()
		me.cmbValores.SelectedIndex = 0
	End Sub
	
	''' <summary>
	''' Rellena el combo box con todos los anios en los que existen movimientos
	''' </summary>
	Public Sub RellenarPeriodos()
		Me.cmbPeriodos.Items.Clear()
		For Each anio as String In fdatos.GetPeriodos()
			me.cmbPeriodos.Items.Add(anio)
		Next	
		me.cmbPeriodos.SelectedIndex = me.cmbPeriodos.Items.Count - 1
	End Sub
	
	''' <summary>
	''' Acutaliza el grid cada vez que se ha seleccionado un nuevo valor a mostrar
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub CmbValoresSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		me.RellenarGrid()
	End Sub
	
	''' <summary>
	''' Invoca a un metodo especifico para rellenar el grid en base al valor seleccionado en el combo box de valores
	''' </summary>
	Private Sub RellenarGrid()
		select case me.cmbValores.Text
			Case "Balance General":			
				Me.RellenarGridBalanceGen()
			Case "Balance de Comprobacion":
				Me.RellenarGridBalanceComp()
			Case "Balance de Ajustes":
				Me.RellenarGridBalanceAjustes()				
			Case "Balance Ajustado":
				Me.RellenarGridBalanceAjustado()
			Case "Estado de Resultados":
				Me.RellenarGridEstadoRes()	
		end select
	End Sub
	
	''' <summary>
	''' Rellena el grid con los totales anuales del balance general
	''' </summary>
	Private Sub RellenarGridBalanceGen()
				
		Me.grdBalanceComprobacion.Columns.Clear()
		Me.grdBalanceComprobacion.Columns.Add("colActivo", "Total Activo")
		Me.grdBalanceComprobacion.Columns.Add("colPasivo", "Total Pasivo")
		me.grdBalanceComprobacion.Columns.Add("colCapital", "Total Capital")
		
		Me.grdBalanceComprobacion.Rows.Clear()
		
		Dim totalActivo As Double = Me.GetTotalFromCuenta("1")
		Dim totalPasivo As Double = Me.GetTotalFromCuenta("2")
		dim totalCapital as Double = me.GetTotalFromCuenta("3")
		
		Me.grdBalanceComprobacion.Rows.Add()
		
		Me.grdBalanceComprobacion.Rows(0).Cells("colActivo").Value = Math.Abs(totalActivo)
		Me.grdBalanceComprobacion.Rows(0).Cells("colPasivo").Value = Math.Abs(totalPasivo)
		me.grdBalanceComprobacion.Rows(0).Cells("colCapital").Value = Math.Abs(totalCapital)
		
	End Sub
	
	''' <summary>
	''' Obtiene la suma de los movimientos realizados sobre una cuenta
	''' </summary>
	''' <param name="codCuenta">El codigo de la cuenta</param>
	''' <returns>El total de los movimientos de la cuenta</returns>
	Private Function GetTotalFromCuenta(ByVal codCuenta As String) as Double
		Dim ctaActivo As Cuenta = fdatos.GetCuenta(codCuenta)
		Dim hijasActivo As List(Of Cuenta) = fdatos.GetTodasLasHijas(ctaActivo.Codigo)
		Dim totalActivoCargoNormal As Double = fdatos.GetTotalFromCuenta(ctaActivo.Codigo, "Cargo", Me.cmbPeriodos.Text, "normal")
		Dim totalActivoAbonoNormal As Double = fdatos.GetTotalFromCuenta(ctaActivo.Codigo, "Abono", Me.cmbPeriodos.Text, "normal")
		Dim totalActivoCargoAjuste As Double = fdatos.GetTotalFromCuenta(ctaActivo.Codigo, "Cargo", Me.cmbPeriodos.Text, "ajuste")
		Dim totalActivoAbonoAjuste As Double = fdatos.GetTotalFromCuenta(ctaActivo.Codigo, "Abono", Me.cmbPeriodos.Text, "ajuste")
		dim totalActivo as Double = (totalActivoCargoNormal + totalActivoCargoAjuste) - (totalActivoAbonoNormal + totalActivoAbonoAjuste)

		For Each ctaHija As Cuenta In hijasActivo
			totalActivoCargoNormal = fdatos.GetTotalFromCuenta(ctaHija.Codigo, "Cargo", Me.cmbPeriodos.Text, "normal")
			totalActivoAbonoNormal = fdatos.GetTotalFromCuenta(ctaHija.Codigo, "Abono", Me.cmbPeriodos.Text, "normal")
			totalActivoCargoAjuste = fdatos.GetTotalFromCuenta(ctaHija.Codigo, "Cargo", Me.cmbPeriodos.Text, "ajuste")
			totalActivoAbonoAjuste = fdatos.GetTotalFromCuenta(ctaHija.Codigo, "Abono", Me.cmbPeriodos.Text, "ajuste")
			totalActivo += ((totalActivoCargoNormal + totalActivoCargoAjuste) - (totalActivoAbonoNormal + totalActivoAbonoAjuste))
		Next
		return totalActivo
	End Function
	
	''' <summary>
	''' Rellena el grid con los totales anuales del balance de comprobacion
	''' </summary>
	Private Sub RellenarGridBalanceComp()
		Me.cuentasNormales = fdatos.GetCuentasConMovimientos(Me.cmbPeriodos.Text, "normal")
		
		Me.grdBalanceComprobacion.Columns.Clear()
		Me.grdBalanceComprobacion.Columns.Add("colDeudor", "Total Deudor")
		Me.grdBalanceComprobacion.Columns.Add("colAcreedor", "Total Acreedor")
		
		Me.grdBalanceComprobacion.Rows.Clear()
		Dim counter As Integer = 0
		dim debe, haber, totalDebe, totalHaber as Double
        
        For Each cta As Cuenta In Me.cuentasNormales
            debe = fdatos.GetTotalFromCuenta(cta.Codigo, "cargo", Me.cmbPeriodos.Text, "normal")
            totalDebe += debe
            haber = fdatos.GetTotalFromCuenta(cta.Codigo, "abono", Me.cmbPeriodos.Text, "normal")
            totalHaber += haber

        Next
		Me.grdBalanceComprobacion.Rows.Add()
		Me.grdBalanceComprobacion.Rows(0).Cells("colDeudor").Value = totalDebe
		me.grdBalanceComprobacion.Rows(0).Cells("colAcreedor").Value = totalHaber
		
	End Sub
	
	''' <summary>
	''' Rellena el grid con los totales anuales del balance de ajustes
	''' </summary>
	Private Sub RellenarGridBalanceAjustes()
		Me.cuentasNormales = fdatos.GetCuentasConMovimientos(Me.cmbPeriodos.Text, "normal")
		
		Me.grdBalanceComprobacion.Columns.Clear()
		Me.grdBalanceComprobacion.Columns.Add("colDeudor", "Total Deudor")
		Me.grdBalanceComprobacion.Columns.Add("colAcreedor", "Total Acreedor")
		
		Me.grdBalanceComprobacion.Rows.Clear()
		Dim counter As Integer = 0
		dim debe, haber, totalDebe, totalHaber as Double
        
        For Each cta As Cuenta In Me.cuentasNormales
            debe = fdatos.GetTotalFromCuenta(cta.Codigo, "cargo", Me.cmbPeriodos.Text, "ajuste")
            totalDebe += debe
            haber = fdatos.GetTotalFromCuenta(cta.Codigo, "abono", Me.cmbPeriodos.Text, "ajuste")
            totalHaber += haber

        Next
		Me.grdBalanceComprobacion.Rows.Add()
		Me.grdBalanceComprobacion.Rows(0).Cells("colDeudor").Value = totalDebe
		me.grdBalanceComprobacion.Rows(0).Cells("colAcreedor").Value = totalHaber
		
	End Sub
	
	''' <summary>
	''' Rellena el grid con los totales anuales del balance ajustado
	''' </summary>
	Private Sub RellenarGridBalanceAjustado()
		Me.cuentasNormales = fdatos.GetCuentasConMovimientos(Me.cmbPeriodos.Text, "normal")
		
		Me.grdBalanceComprobacion.Columns.Clear()
		Me.grdBalanceComprobacion.Columns.Add("colDeudor", "Total Deudor")
		Me.grdBalanceComprobacion.Columns.Add("colAcreedor", "Total Acreedor")
		
		Me.grdBalanceComprobacion.Rows.Clear()
		Dim counter As Integer = 0
           Dim debe, haber, cargosAjuste, abonosAjuste, totalDeudor, totalAcreedor, debeAjustado, haberAjustado As Double
        
        For Each cta As Cuenta In Me.cuentasNormales
        	debeAjustado = 0
            haberAjustado = 0
            
            debe = fdatos.GetTotalFromCuenta(cta.Codigo, "cargo", Me.cmbPeriodos.Text, "normal")
            haber = fdatos.GetTotalFromCuenta(cta.Codigo, "abono", Me.cmbPeriodos.Text, "normal")

            cargosAjuste = fdatos.GetTotalFromCuenta(cta.Codigo, "cargo", Me.cmbPeriodos.Text, "ajuste")
            abonosAjuste = fdatos.GetTotalFromCuenta(cta.Codigo, "abono", Me.cmbPeriodos.Text, "ajuste")

		 If (cargosAjuste <> 0) Then
                If (debe <> 0) Then
                    debeAjustado = debe + cargosAjuste
                    haberAjustado = 0
                ElseIf (haber <> 0) Then
                    If (haber > cargosAjuste) Then
                        debeAjustado = haber - cargosAjuste
                        haberAjustado = 0
                    Else
                        haberAjustado = cargosAjuste - haber
                        debeAjustado = 0
                    End If
                Else
                    debeAjustado = cargosAjuste
                End If
            ElseIf (abonosAjuste <> 0) Then
                If (debe <> 0) Then
                    If (debe > abonosAjuste) Then
                        debeAjustado = debe - abonosAjuste
                        haberAjustado = 0
                    Else
                        haberAjustado = abonosAjuste - debe
                        debeAjustado = 0
                    End If
                ElseIf (haber <> 0) Then
                    haberAjustado = haber + abonosAjuste
                    debeAjustado = 0
                Else
                    haberAjustado = abonosAjuste
                End If
            End If

            If ((debeAjustado = 0) And (haberAjustado = 0)) Then
                If (debe <> 0) Then
                    debeAjustado = debe
                ElseIf (haber <> 0) Then
                    haberAjustado = haber
                End If
            End If
            
            totalDeudor += debeAjustado
            totalAcreedor += haberAjustado            

        Next
		Me.grdBalanceComprobacion.Rows.Add()
		Me.grdBalanceComprobacion.Rows(0).Cells("colDeudor").Value = totalDeudor
		me.grdBalanceComprobacion.Rows(0).Cells("colAcreedor").Value = totalAcreedor
		
	End Sub
	
	''' <summary>
	''' Rellena el grid con los totales anuales del estado de resultados
	''' </summary>
	Private Sub RellenarGridEstadoRes()
				
		Me.grdBalanceComprobacion.Columns.Clear()
		Me.grdBalanceComprobacion.Columns.Add("colTotal", "Utilidad Neta")
		me.grdBalanceComprobacion.Columns.Add("colVarCapital", "Variacion de Capital")
		
		Me.grdBalanceComprobacion.Rows.Clear()
		Dim cargos, abonos, totalIngresos, totalGastos, saldo, uNeta As Double
		Dim cuentasIngresos As List(Of Cuenta) = fdatos.GetTodasLasHijas("5.1.1")
		Dim cuentasGastos As List(Of Cuenta) = fdatos.GetTodasLasHijas("4.1")
		
		For Each cta As Cuenta In cuentasIngresos
			for mes as Integer = 1 to 12
				cargos = fdatos.GetTotalFromCuenta(cta.Codigo, "cargo", CInt(me.cmbPeriodos.Text), mes)
				abonos = fdatos.GetTotalFromCuenta(cta.Codigo, "abono", CInt(me.cmbPeriodos.Text), mes)
				if(cargos <> 0.0 Or abonos <> 0.0) then
					saldo = abonos - cargos
					totalIngresos += saldo
				End If
			next
		Next
		
		For Each cta As Cuenta In cuentasGastos
			for mes as Integer = 1 to 12
				cargos = fdatos.GetTotalFromCuenta(cta.Codigo, "cargo", CInt(me.cmbPeriodos.Text), mes)
				abonos = fdatos.GetTotalFromCuenta(cta.Codigo, "abono", CInt(me.cmbPeriodos.Text), mes)
				if(cargos <> 0.0 Or abonos <> 0.0) then
					saldo = cargos - abonos
					totalGastos += saldo
				End If
			next
		Next
		
		uNeta = totalIngresos - totalGastos

		Dim ctaCapital As Cuenta = fdatos.GetCuenta("3.1.1")
		Dim ctaRetiros As Cuenta = fdatos.GetCuenta("9.1.1")
		dim cargosRetiros, abonosRetiros, saldoRetiros, cargosCapital, abonosCapital, saldoCapital as Double
		
		for mes as Integer = 1 to 12
			 cargosRetiros = fdatos.GetTotalFromCuenta(ctaRetiros.Codigo, "cargo", CInt(me.cmbPeriodos.Text), mes)
			abonosRetiros = fdatos.GetTotalFromCuenta(ctaRetiros.Codigo, "abono", CInt(me.cmbPeriodos.Text), mes)
			saldoRetiros += cargosRetiros - abonosRetiros
			cargosCapital = fdatos.GetTotalFromCuenta(ctaCapital.Codigo, "cargo", CInt(me.cmbPeriodos.Text), mes)
			abonosCapital = fdatos.GetTotalFromCuenta(ctaCapital.Codigo, "abono", CInt(me.cmbPeriodos.Text), mes)
			saldoCapital += abonosCapital - cargosCapital
		next
		
		Me.grdBalanceComprobacion.Rows.Add()
		
		Me.grdBalanceComprobacion.Rows(0).Cells("colTotal").Value = uNeta
		me.grdBalanceComprobacion.Rows(0).Cells("colVarCapital").Value = (saldoCapital + uNeta) - saldoRetiros
		
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
	''' Actualiza el grid en base al nuevo anio seleccionado en el combo
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub CmbPeriodosSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		me.RellenarGrid()
	End Sub
End Class
