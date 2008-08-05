Public Partial Class frmEditMonto
	Dim monto As Double
	Dim codMovimiento As String
	dim fdatos as New FuenteDatos()
	
	''' <summary>
	''' Crea una nueva instancia del formulario de editar montos en base a un codigo de movimiento y el monto actual
	''' </summary>
	''' <param name="codMov"></param>
	''' <param name="montoActual"></param>
	Public Sub New(byval codMov as String, byval montoActual as Double)
		Me.InitializeComponent()		
		Me.monto = montoActual
		Me.codMovimiento = codMov
	End Sub
	
	''' <summary>
	''' Cierra el formulario
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub BtnCancelarClick(ByVal sender As Object, ByVal e As EventArgs)
		me.Close()
	End Sub
	
	''' <summary>
	''' Guarda los cambios realizados al monto actual
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub BtnAceptarClick(ByVal sender As Object, ByVal e As EventArgs)
		me.fdatos.EditMontoMovimiento(me.codMovimiento, me.numericUpDown1.Value)
		me.Close()
	End Sub
	
	''' <summary>
	''' Inicializa el formulario y sus controles
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub FrmEditMontoLoad(ByVal sender As Object, ByVal e As EventArgs)
		me.numericUpDown1.Value = me.monto
	End Sub
End Class
