
Public Partial Class frmBalanceAjustado
	Dim fdatos As FuenteDatos
	dim cuentasNormales as List(Of Cuenta)
	
	Public Sub New()
		Me.InitializeComponent()
	End Sub

	''' <summary>
	''' Inicaliza el formulario y sus controles
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub FrmBalanceAjustadoLoad(ByVal sender As Object, ByVal e As EventArgs)
		Me.fdatos = New FuenteDatos()		
		me.RellenarPeriodos()
		Me.RellenarGrid()
	End Sub	
	
	''' <summary>
	''' Rellena el grid en base a los movimientos de las cuentas ajustadas
	''' </summary>
	Private Sub RellenarGrid()
        Me.cuentasNormales = fdatos.GetCuentasConMovimientos(Me.cmbPeriodos.Text, "normal")
		Me.grdBalanceComprobacion.Rows.Clear()
		Dim estiloResaltado As New DataGridViewCellStyle()
		dim estiloAjuste as New DataGridViewCellStyle()
		estiloResaltado.BackColor = Color.LightBlue
		estiloAjuste.BackColor = Color.LightBlue
		estiloResaltado.Font = New Font("Arial", 12, FontStyle.Bold)
		Dim counter As Integer = 0
        Dim debe, haber, cargosAjuste, abonosAjuste, totalDeudor, totalAcreedor, debeAjustado, haberAjustado As Double
        For Each cta As Cuenta In Me.cuentasNormales
            debeAjustado = 0
            haberAjustado = 0
            counter += 1
            Me.grdBalanceComprobacion.Rows.Add()
            Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count - 1).Cells("colFolio").Value = counter
            Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count - 1).Cells("colCuentas").Value = cta.Nombre
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

            Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count - 1).Cells("colCargo").Value = debeAjustado
            totalDeudor += debeAjustado
            Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count - 1).Cells("colAbono").Value = haberAjustado
            totalAcreedor += haberAjustado

        Next
		Me.grdBalanceComprobacion.Rows.Add()
		Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count-1).Cells("colCuentas").Value = "Sumas Iguales"		
		Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count-1).Cells("colCargo").Value = totalDeudor
		Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count-1).Cells("colAbono").Value = totalAcreedor
		
		If(totalDeudor <> totalAcreedor) Then
			estiloResaltado.BackColor = color.LightCoral
		End If
		me.grdBalanceComprobacion.Rows(me.grdBalanceComprobacion.Rows.Count-1).Cells("colFolio").Style = estiloResaltado
		Me.grdBalanceComprobacion.Rows(Me.grdBalanceComprobacion.Rows.Count-1).Cells("colCuentas").Style = estiloResaltado
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
	''' Rellena el combo con todos los anios en los que existen movimientos
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
