Public Partial Class frmCatalogoCuentas
	Private fdatos As New FuenteDatos()
	private cuentas as New List(Of Cuenta)
	Public Sub New()
		Me.InitializeComponent()
	End Sub
	
	''' <summary>
	''' Inicaliza el formulario y sus controles
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub MainFormLoad(ByVal sender As Object, ByVal e As EventArgs)
		me.cuentas = fdatos.GetCuentas()
		Me.cmbNivel1.Items.Clear()					
		Me.cmbNivel2.Items.Clear()
		Me.cmbNivel3.Items.Clear()
		Me.cmbNivel4.Items.Clear()
		me.cmbNivel5.Items.Clear()
		For Each cta As Cuenta In me.cuentas
			if(not cta.Codigo.Contains(".")) then
				Me.cmbNivel1.Items.Add(cta.Codigo +"-"+ cta.Nombre)	
			end if
		Next
		If(Me.cmbNivel1.Items.Count > 0) Then
			me.cmbNivel1.Enabled = true
			Me.cmbNivel1.SelectedIndex = 0
			me.cmbNivel1.Focus()
		End If	
	End Sub	
	
	''' <summary>
	''' Obtiene el codigo de la cuenta mostrada en un combo box
	''' </summary>
	''' <param name="cmbBox"></param>
	''' <returns></returns>
	Private Function GetCodCuentaFromComboBox(ByVal cmbBox As ComboBox) As String
		Dim codCuenta As String = cmbBox.Text.Substring(0,cmbBox.Text.IndexOf("-"))
		return codCuenta
	End Function
	
	''' <summary>
	''' Obtiene el codigo de la cuenta seleccionada en base al nivel selecionado
	''' </summary>
	''' <returns></returns>
	Private Function GetCodCuentaSeleccionada() as String
		dim codCuentaSeleccionada as String 
		If(Me.lblNivelSeleccionado.Text.Contains("1")) Then
			codCuentaSeleccionada = Me.GetCodCuentaFromComboBox(Me.cmbNivel1)
		Else If (Me.lblNivelSeleccionado.Text.Contains("2")) Then
			codCuentaSeleccionada = Me.GetCodCuentaFromComboBox(Me.cmbNivel2)
		Else If (Me.lblNivelSeleccionado.Text.Contains("3")) then
			codCuentaSeleccionada = Me.GetCodCuentaFromComboBox(Me.cmbNivel3)
		Else If (Me.lblNivelSeleccionado.Text.Contains("4")) Then
			codCuentaSeleccionada = Me.GetCodCuentaFromComboBox(Me.cmbNivel4)
		Else
			codCuentaSeleccionada = me.GetCodCuentaFromComboBox(me.cmbNivel5)
		End If
		return codCuentaSeleccionada
	End Function
	
	''' <summary>
	''' Actualiza los datos de los demas controles en ase a la nueva cuenta seleccionada en el combo box del nivel 1
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub CmbNivel1SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
				Dim codCuenta As String = Me.GetCodCuentaFromComboBox(Me.cmbNivel1)
		Me.cmbNivel2.Items.Clear()		
		Dim subCtas As New List(Of Cuenta)()
		subCtas.AddRange(CuentasManager.GetHijas(codCuenta, me.cuentas))
		For Each cta1 As Cuenta In subCtas
			me.cmbNivel2.Items.Add(cta1.Codigo + "-" + cta1.Nombre)
		Next
		If(Me.cmbNivel2.Items.Count > 0) Then
			Me.cmbNivel2.Enabled = True			
			Me.cmbNivel2.SelectedIndex = 0
		Else
			Me.cmbNivel2.Enabled = False
			Me.cmbNivel3.Enabled = False
			Me.cmbNivel4.Enabled = False
			Me.cmbNivel5.Enabled = False			
		End If
		Dim cta As Cuenta = CuentasManager.BuscarCuenta(codCuenta, me.cuentas)
		Me.lblDescripcionCuenta.Text = cta.Descripcion
		Me.lblNivelSeleccionado.Text = "Nivel 1"		
		If(PartidasManager.TieneMovimientos(codCuenta)) Then
			Me.btnLibroDiario.Enabled = True
		Else
			me.btnLibroDiario.Enabled = False
		End If
	End Sub
	
	''' <summary>
	''' Actualiza los datos de los demas controles en ase a la nueva cuenta seleccionada en el combo box del nivel 2
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub CmbNivel2SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
				Dim codCuenta As String = me.GetCodCuentaFromComboBox(me.cmbNivel2)
		Me.cmbNivel3.Items.Clear()
		Dim subCtas As New List(Of Cuenta)()
		subCtas.AddRange(CuentasManager.GetHijas(codCuenta, me.cuentas))
		For Each cta2 As Cuenta In subCtas
			me.cmbNivel3.Items.Add(cta2.Codigo + "-" + cta2.Nombre)
		Next
		If(Me.cmbNivel3.Items.Count > 0) Then
			Me.cmbNivel3.Enabled = True			
			Me.cmbNivel3.SelectedIndex = 0
		Else
			Me.cmbNivel3.Enabled = False
			Me.cmbNivel4.Enabled = False
			Me.cmbNivel5.Enabled = False			
		End If
		Dim cta As Cuenta = CuentasManager.BuscarCuenta(codCuenta, me.cuentas)
		Me.lblDescripcionCuenta.Text = cta.Descripcion
		Me.lblNivelSeleccionado.Text = "Nivel 2"
		If(PartidasManager.TieneMovimientos(codCuenta)) Then
			Me.btnLibroDiario.Enabled = True
		Else
			me.btnLibroDiario.Enabled = False
		End If
	End Sub	
	
	''' <summary>
	''' Actualiza los datos de los demas controles en ase a la nueva cuenta seleccionada en el combo box del nivel 3
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub CmbNivel3SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim codCuenta As String = me.GetCodCuentaFromComboBox(me.cmbNivel3)				
		Me.cmbNivel4.Items.Clear()
		Dim subCtas As New List(Of Cuenta)()
		subCtas.AddRange(CuentasManager.GetHijas(codCuenta, Me.cuentas))
		For Each cta3 As Cuenta In subCtas
			me.cmbNivel4.Items.Add(cta3.Codigo + "-" + cta3.Nombre)
		Next
		If(Me.cmbNivel4.Items.Count > 0) Then
			Me.cmbNivel4.Enabled = True			
			Me.cmbNivel4.SelectedIndex = 0
		Else
			Me.cmbNivel4.Enabled = False
			Me.cmbNivel5.Enabled = False			
		End If
		Dim cta As Cuenta = CuentasManager.BuscarCuenta(codCuenta, me.cuentas)
		Me.lblDescripcionCuenta.Text = cta.Descripcion
		Me.lblNivelSeleccionado.Text = "Nivel 3"
		If(PartidasManager.TieneMovimientos(codCuenta)) Then
			Me.btnLibroDiario.Enabled = True
		Else
			me.btnLibroDiario.Enabled = False
		End If
	End Sub
	
	''' <summary>
	''' Actualiza los datos de los demas controles en ase a la nueva cuenta seleccionada en el combo box del nivel 4
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub CmbNivel4SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim codCuenta As String = me.GetCodCuentaFromComboBox(me.cmbNivel4)				
		Me.cmbNivel5.Items.Clear()
		Dim subCtas As New List(Of Cuenta)()
		subCtas.AddRange(CuentasManager.GetHijas(codCuenta, Me.cuentas))
		For Each cta4 As Cuenta In subCtas
			me.cmbNivel5.Items.Add(cta4.Codigo + "-" + cta4.Nombre)
		Next
		If(Me.cmbNivel5.Items.Count > 0) Then
			Me.cmbNivel5.Enabled = True			
			Me.cmbNivel5.SelectedIndex = 0
		Else
			Me.cmbNivel5.Enabled = False			
		End If
		Dim cta As Cuenta = CuentasManager.BuscarCuenta(codCuenta, me.cuentas)
		Me.lblDescripcionCuenta.Text = cta.Descripcion
		Me.lblNivelSeleccionado.Text = "Nivel 4"
		If(PartidasManager.TieneMovimientos(codCuenta)) Then
			Me.btnLibroDiario.Enabled = True
		Else
			me.btnLibroDiario.Enabled = False
		End If
	End Sub
	
	''' <summary>
	''' Actualiza los datos de los demas controles en ase a la nueva cuenta seleccionada en el combo box del nivel 5
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub CmbNivel5SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim codCuenta As String = Me.GetCodCuentaFromComboBox(Me.cmbNivel5)
		Dim cta As Cuenta = CuentasManager.BuscarCuenta(codCuenta, me.cuentas)
		Me.lblDescripcionCuenta.Text = cta.Descripcion
		Me.lblNivelSeleccionado.Text = "Nivel 5"		
		If(PartidasManager.TieneMovimientos(codCuenta)) Then
			Me.btnLibroDiario.Enabled = True
		Else
			me.btnLibroDiario.Enabled = False
		End If
	End Sub					
	
	''' <summary>
	''' Crea e invoca a una nueva instancia del formulario de agregar/editar cuentas, con el modo de operacion de agregar
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub BtnAddCuentaClick(ByVal sender As Object, ByVal e As EventArgs)
		dim codCtaSeleccionada as String = me.GetCodCuentaSeleccionada()
		Dim frmAddCta As New frmAddEditCuenta("Add",codCtaSeleccionada,me.cuentas)
		frmAddCta.ShowDialog(Me)
		Me.MainFormLoad(Me, New EventArgs())
		
	End Sub
	
	''' <summary>
	''' Crea e invoca a una nueva instancia del formulario de agregar/editar cuentas, con el modo de operacion de editar
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub BtnEditCuentaClick(ByVal sender As Object, ByVal e As EventArgs)
		dim codCtaSeleccionada as String = me.GetCodCuentaSeleccionada()
		Dim frmAddCta As New frmAddEditCuenta("Edit",codCtaSeleccionada,me.cuentas)
		frmAddCta.ShowDialog(Me)
		Me.MainFormLoad(Me, New EventArgs())
	End Sub
	
	''' <summary>
	''' Elimina una cuenta
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub BtnDelCuentaClick(ByVal sender As Object, ByVal e As EventArgs)
		dim codCtaSeleccionada as String = me.GetCodCuentaSeleccionada()
		If(msgbox("Esta seguro que desea eliminar esta cuenta y sus posibles sub cuentas?", MsgBoxStyle.YesNo,"Confirmacion de Borrado") = MsgBoxResult.Yes) Then
			fdatos.EliminarCuenta(codCtaSeleccionada)
			me.MainFormLoad(me, new EventArgs())
		End If
	End Sub
	
	''' <summary>
	''' Crea e invoca una nueva instancia del formulario de libro diario pasandole como parametro la cuenta seleccionada
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Sub BtnLibroDiarioClick(ByVal sender As Object, ByVal e As EventArgs)
		Dim codCtaSeleccionada As String = Me.GetCodCuentaSeleccionada()
		Dim frmLibDiario As New frmLibroDiario(codCtaSeleccionada)
		frmLibDiario.ShowDialog(Me)		
	End Sub
	
	Sub CmbNivel1Enter(ByVal sender As Object, ByVal e As EventArgs)
		me.CmbNivel1SelectedIndexChanged(me, new EventArgs())
	End Sub
	
	Sub CmbNivel2Enter(ByVal sender As Object, ByVal e As EventArgs)
		me.CmbNivel2SelectedIndexChanged(me, new EventArgs())
	End Sub
	
	Sub CmbNivel3Enter(ByVal sender As Object, ByVal e As EventArgs)
		me.CmbNivel3SelectedIndexChanged(me, new EventArgs())
	End Sub
	
	Sub CmbNivel4Enter(ByVal sender As Object, ByVal e As EventArgs)
		me.CmbNivel4SelectedIndexChanged(me, new EventArgs())
	End Sub
	
	Sub CmbNivel5Enter(ByVal sender As Object, ByVal e As EventArgs)
		me.CmbNivel5SelectedIndexChanged(me, new EventArgs())
	End Sub
End Class
