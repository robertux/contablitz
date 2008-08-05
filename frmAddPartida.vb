
Public Partial Class frmAddPartida
	dim fdatos as New FuenteDatos()
	
	''' <summary>
	''' Crea una nueva instancia del formulario de agregar partidas
	''' </summary>
	Public Sub New()
		Me.InitializeComponent()
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
	''' Agrega la nueva partida en base a los datos de los controles del formulario
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub BtnAceptarClick(ByVal sender As Object, ByVal e As EventArgs)
		If(Me.txtNombre.Text <> "" And Me.txtMotivo.Text <> "") Then
			dim nuevoCodigo as String = fdatos.GenerarCodigoPartida()
			fdatos.AgregarPartida(nuevoCodigo, me.txtNombre.Text, me.cmbFecha.Value, me.txtMotivo.Text, me.cmbTipo.Text)
			Me.Close()
		end if
	End Sub
	
	''' <summary>
	''' Inicaliza el formulario y sus controles
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub FrmAddPartidaLoad(ByVal sender As Object, ByVal e As EventArgs)
		me.cmbTipo.SelectedIndex = 0
	End Sub
End Class
