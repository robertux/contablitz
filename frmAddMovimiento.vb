Public Partial Class frmAddMovimiento
	private fdatos as New FuenteDatos()
	private codPtda as string
	
	''' <summary>
	''' Crea un nuevo formulario de Agregar movimiento en base al codigo de una partida existente
	''' </summary>
	''' <param name="codPartida">El codigo de la partida en la cual agregar el movimiento</param>
	Public Sub New(byval codPartida as String)
		Me.InitializeComponent()
		me.codPtda = codPartida
	End Sub
	
	''' <summary>
	''' Inicializa el formulario y sus controles
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub FrmAddMovimientoLoad(ByVal sender As Object, ByVal e As EventArgs)
		me.cmbTipo.SelectedIndex = 0
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
	''' Agrega el movimiento segun los datos de los controles
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub BtnAceptarClick(ByVal sender As Object, ByVal e As EventArgs)
		If(Me.txtCodCuenta.Text <> "") Then
			Dim nuevoCodigo As String = fdatos.GenerarCodigoMovimiento()
			fdatos.AgregarMovimiento(nuevoCodigo, me.txtCodCuenta.Text, me.nmcMonto.Value, me.cmbTipo.Text, me.codPtda)
		end if
		me.Close()
	End Sub
End Class
