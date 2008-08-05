Public Partial Class frmBalanceComprobacion
	Dim fdatos As FuenteDatos
	dim cuentasNormales as List(Of Cuenta)

	Public Sub New()
		Me.InitializeComponent()
	End Sub
	
	''' <summary>
	''' Iniializa el formulario y sus controles
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub FrmBalanceComprobacionLoad(ByVal sender As Object, ByVal e As EventArgs)
		Me.fdatos = New FuenteDatos()		
		me.RellenarPeriodos()
		'Me.RellenarGrid()
	End Sub
	
	''' <summary>
	''' Rellena el grid en base a los movimientos de las cuentas normales y de ajuste
	''' </summary>
	Private Sub RellenarGrid()
		Me.cuentasNormales = fdatos.GetCuentasConMovimientos(me.cmbPeriodos.Text, "normal")
		Me.grdBalanceComprobacion.Rows.Clear()
		Dim estiloResaltado As New DataGridViewCellStyle()
		dim estiloAjuste as New DataGridViewCellStyle()
		estiloResaltado.BackColor = Color.LightBlue
		estiloAjuste.BackColor = Color.LightBlue
		estiloResaltado.Font = New Font("Arial", 12, FontStyle.Bold)
		Dim counter As Integer = 0
		dim debe, haber, totalDebe, totalHaber, cargosAjuste, abonosAjuste, totalCargosAjuste, totalAbonosAjuste, saldo, totalDeudor, totalAcreedor as Double
        For Each cta As Cuenta In Me.cuentasNormales
            cargosAjuste = 0
            abonosAjuste = 0
            counter += 1
            Me.grdBalanceComprobacion.Rows.Add()
            Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count - 1).Cells("colFolio").Value = counter
            Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count - 1).Cells("colCuentas").Value = cta.Nombre
            debe = fdatos.GetTotalFromCuenta(cta.Codigo, "cargo", Me.cmbPeriodos.Text, "normal")
            totalDebe += debe
            Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count - 1).Cells("colDebe").Value = debe
            haber = fdatos.GetTotalFromCuenta(cta.Codigo, "abono", Me.cmbPeriodos.Text, "normal")
            totalHaber += haber
            Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count - 1).Cells("colHaber").Value = haber

            cargosAjuste = fdatos.GetTotalFromCuenta(cta.Codigo, "cargo", Me.cmbPeriodos.Text, "ajuste")
            totalCargosAjuste += cargosAjuste
            Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count - 1).Cells("colCargo").Value = cargosAjuste
            Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count - 1).Cells("colCargo").Style = estiloAjuste
            abonosAjuste = fdatos.GetTotalFromCuenta(cta.Codigo, "abono", Me.cmbPeriodos.Text, "ajuste")
            totalAbonosAjuste += abonosAjuste
            Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count - 1).Cells("colAbono").Value = abonosAjuste
            Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count - 1).Cells("colAbono").Style = estiloAjuste

            saldo = CDbl(Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count - 1).Cells("colDebe").Value) - CDbl(Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count - 1).Cells("colHaber").Value)
            If (saldo >= 0) Then
                totalDeudor += saldo
                Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count - 1).Cells("colDeudor").Value = saldo
            Else
                totalAcreedor += Math.Abs(saldo)
                Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count - 1).Cells("colAcreedor").Value = Math.Abs(saldo)
            End If
        Next
		Me.grdBalanceComprobacion.Rows.Add()
		Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count-1).Cells("colCuentas").Value = "Sumas Iguales"		
		Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count-1).Cells("colDebe").Value = totalDebe
		Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count-1).Cells("colHaber").Value = totalHaber
		Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count-1).Cells("colDeudor").Value = totalDeudor
		Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count-1).Cells("colAcreedor").Value = totalAcreedor
		Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count-1).Cells("colCargo").Value = totalCargosAjuste
		Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count-1).Cells("colAbono").Value = totalAbonosAjuste
		
		If(totalDebe <> totalHaber) Then
			estiloResaltado.BackColor = color.LightCoral
		End If
		me.grdBalanceComprobacion.Rows(me.grdBalanceComprobacion.Rows.Count-1).Cells("colFolio").Style = estiloResaltado
		Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count-1).Cells("colCuentas").Style = estiloResaltado
		Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count-1).Cells("colDebe").Style = estiloResaltado
		Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count-1).Cells("colHaber").Style = estiloResaltado
		Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count-1).Cells("colDeudor").Style = estiloResaltado
		Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count-1).Cells("colAcreedor").Style = estiloResaltado		
		Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count-1).Cells("colCargo").Style = estiloResaltado
		Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count-1).Cells("colAbono").Style = estiloResaltado
		
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
	''' Rellena el combo con los periodos en los que existen movimientos
	''' </summary>
	Public Sub RellenarPeriodos()
		Me.cmbPeriodos.Items.Clear()
		For Each anio as String In fdatos.GetPeriodos()
			me.cmbPeriodos.Items.Add(anio)
		Next	
		me.cmbPeriodos.SelectedIndex = me.cmbPeriodos.Items.Count - 1
	End Sub
	
	''' <summary>
	''' Actualiza el grid cuando se ha seleccionado un nuevo periodo
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub CmbPeriodosSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		me.RellenarGrid()
	End Sub
	
End Class
