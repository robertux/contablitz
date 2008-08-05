Public Partial Class frmAddEditCuenta
	Private modoOperacion As String
	Private cuentas As List(Of Cuenta)
	Private codCuenta As String
	private fdatos as FuenteDatos
	
	Public Sub New()
		Me.InitializeComponent()
	End Sub
	
	''' <summary>
	''' Construye un nuevo formulario de agregar/editar cuentas en base a una cuenta especifica y una lista de cuenta
	''' </summary>
	''' <param name="modo">El modo de operacion (agregar o editar)</param>
	''' <param name="codCta">El codigo de la cuenta seleccionada como padre o hermana</param>
	''' <param name="ctas">La lista de todas las cuentas</param>
	Public Sub New(ByVal modo As String, byval codCta as String, byval ctas as List(Of Cuenta))
		Me.InitializeComponent()
		Me.modoOperacion = modo
		Me.cuentas = ctas
		Me.codCuenta = codCta
		me.fdatos = new FuenteDatos()
	End Sub
	
	''' <summary>
	''' Cierra el formulario
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub Button3Click(ByVal sender As Object, ByVal e As EventArgs)
		me.Close()
	End Sub
	
	''' <summary>
	''' Agrega/Edita la cuenta
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub Button1Click(ByVal sender As Object, ByVal e As EventArgs)
		If(Me.txtNombre.Text <> "") Then
			If(Me.modoOperacion = "Add") Then
				dim nuevoCodigo as String
				If(Me.cmbNivel.SelectedIndex = 0) Then 'mismo nivel
					Dim ctaPadre As Cuenta = CuentasManager.GetPadre(Me.codCuenta, Me.cuentas)
					nuevoCodigo = CuentasManager.GenerarCodigoCuenta(ctaPadre.Codigo, Me.cuentas)
				Else 'nivel inferior (sub cuenta)
					nuevoCodigo = CuentasManager.GenerarCodigoCuenta(Me.codCuenta, Me.cuentas)					
				End If
				msgbox("Codigo para la nueva cuenta: " + nuevoCodigo, MsgBoxStyle.OkOnly, "Agregar Cuentas")
				fdatos.AgregarCuenta(nuevoCodigo, me.txtNombre.Text, me.txtDescripcion.Text)
			Else 'modoOperacon = "Edit"
				fdatos.ModificarCuenta(me.codCuenta, me.txtNombre.Text, me.txtDescripcion.Text)
			End If
		End If		
		me.Close()
	End Sub
	
	''' <summary>
	''' Ejecuta operaciones de inicializacion del formulario y sus controles
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub FrmAddEditCuentaLoad(ByVal sender As Object, ByVal e As EventArgs)
		Me.cmbNivel.SelectedIndex = 0
		dim ctaSeleccionada as Cuenta = CuentasManager.BuscarCuenta(me.codCuenta, me.cuentas)
		Me.lblCuentaSeleccionada.Text = "Seleccionada: " + ctaSeleccionada.Codigo + "-" + ctaSeleccionada.Nombre
		If(Me.modoOperacion = "Edit") Then
			Me.lblNivel.Visible = False
			Me.cmbNivel.Visible = False
			Me.txtNombre.Text = ctaSeleccionada.Nombre
			Me.txtDescripcion.Text = ctaSeleccionada.Descripcion
		Else
			Me.txtNombre.Text = ""
			Me.txtDescripcion.Text = ""
			Me.txtNombre.Focus()
			If(CuentasManager.GetNivel(ctaSeleccionada.Codigo) = 5) Then
				Me.cmbNivel.Enabled = False				
			End If
		End If
	End Sub
End Class
