Public Partial Class MainForm
	Public Sub New()
		Me.InitializeComponent()
	End Sub
	
	Sub Button1Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim catCuentas As New frmCatalogoCuentas()
		catCuentas.ShowDialog(me)
	End Sub
	
	Sub Button2Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim libDiario As New frmLibroDiario()
		libDiario.ShowDialog(me)
	End Sub
	
	Sub Button3Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim balComp As New frmBalanceComprobacion()
		balComp.ShowDialog(me)
	End Sub
	
	Sub Button4Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim balAjust As New frmBalanceAjustado()
		balAjust.ShowDialog(me)
	End Sub
	
	Sub Button5Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim part As New frmPartidas()
		part.ShowDialog(me)
	End Sub
	
	Sub Button6Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim fRes As New frmEstadoResultados()
		fRes.ShowDialog(me)
	End Sub
	
	Sub Button7Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim frmCierres As New frmCierres()
		frmCierres.ShowDialog(me)
	End Sub
End Class
