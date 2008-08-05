Partial Class frmAddEditCuenta
	Inherits System.Windows.Forms.Form
	Private components As System.ComponentModel.IContainer
	
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	Private Sub InitializeComponent()
		Me.button3 = New System.Windows.Forms.Button
		Me.button1 = New System.Windows.Forms.Button
		Me.cmbNivel = New System.Windows.Forms.ComboBox
		Me.lblCuentaSeleccionada = New System.Windows.Forms.Label
		Me.lblNombre = New System.Windows.Forms.Label
		Me.txtNombre = New System.Windows.Forms.TextBox
		Me.lblNivel = New System.Windows.Forms.Label
		Me.lblDescripcion = New System.Windows.Forms.Label
		Me.txtDescripcion = New System.Windows.Forms.TextBox
		Me.SuspendLayout
		'
		'button3
		'
		Me.button3.Location = New System.Drawing.Point(297, 201)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(118, 28)
		Me.button3.TabIndex = 3
		Me.button3.Text = "Cancelar"
		Me.button3.UseVisualStyleBackColor = true
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(173, 201)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(118, 28)
		Me.button1.TabIndex = 3
		Me.button1.Text = "Aceptar"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'cmbNivel
		'
		Me.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbNivel.FormattingEnabled = true
		Me.cmbNivel.Items.AddRange(New Object() {"Mismo nivel", "Nivel inverior (sub cuenta)"})
		Me.cmbNivel.Location = New System.Drawing.Point(105, 44)
		Me.cmbNivel.Name = "cmbNivel"
		Me.cmbNivel.Size = New System.Drawing.Size(310, 21)
		Me.cmbNivel.TabIndex = 4
		'
		'lblCuentaSeleccionada
		'
		Me.lblCuentaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblCuentaSeleccionada.Location = New System.Drawing.Point(12, 9)
		Me.lblCuentaSeleccionada.Name = "lblCuentaSeleccionada"
		Me.lblCuentaSeleccionada.Size = New System.Drawing.Size(403, 23)
		Me.lblCuentaSeleccionada.TabIndex = 5
		Me.lblCuentaSeleccionada.Text = "Cuenta:"
		'
		'lblNombre
		'
		Me.lblNombre.Location = New System.Drawing.Point(15, 74)
		Me.lblNombre.Name = "lblNombre"
		Me.lblNombre.Size = New System.Drawing.Size(73, 23)
		Me.lblNombre.TabIndex = 6
		Me.lblNombre.Text = "Nombre:"
		'
		'txtNombre
		'
		Me.txtNombre.Location = New System.Drawing.Point(105, 71)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(310, 20)
		Me.txtNombre.TabIndex = 7
		'
		'lblNivel
		'
		Me.lblNivel.Location = New System.Drawing.Point(15, 47)
		Me.lblNivel.Name = "lblNivel"
		Me.lblNivel.Size = New System.Drawing.Size(73, 23)
		Me.lblNivel.TabIndex = 8
		Me.lblNivel.Text = "Nivel:"
		'
		'lblDescripcion
		'
		Me.lblDescripcion.Location = New System.Drawing.Point(15, 101)
		Me.lblDescripcion.Name = "lblDescripcion"
		Me.lblDescripcion.Size = New System.Drawing.Size(64, 23)
		Me.lblDescripcion.TabIndex = 9
		Me.lblDescripcion.Text = "Descripcion:"
		'
		'txtDescripcion
		'
		Me.txtDescripcion.Location = New System.Drawing.Point(105, 98)
		Me.txtDescripcion.Multiline = true
		Me.txtDescripcion.Name = "txtDescripcion"
		Me.txtDescripcion.Size = New System.Drawing.Size(310, 97)
		Me.txtDescripcion.TabIndex = 10
		'
		'frmAddEditCuenta
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(427, 241)
		Me.ControlBox = false
		Me.Controls.Add(Me.txtDescripcion)
		Me.Controls.Add(Me.lblDescripcion)
		Me.Controls.Add(Me.lblNivel)
		Me.Controls.Add(Me.txtNombre)
		Me.Controls.Add(Me.lblNombre)
		Me.Controls.Add(Me.lblCuentaSeleccionada)
		Me.Controls.Add(Me.cmbNivel)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.button3)
		Me.Name = "frmAddEditCuenta"
		Me.Text = "ContaBlitz - Catalogo de Cuentas - Agregar / Editar Cuenta"
		AddHandler Load, AddressOf Me.FrmAddEditCuentaLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private lblNombre As System.Windows.Forms.Label
	Private lblNivel As System.Windows.Forms.Label
	Private lblDescripcion As System.Windows.Forms.Label
	Private cmbNivel As System.Windows.Forms.ComboBox
	Private lblCuentaSeleccionada As System.Windows.Forms.Label
	Private txtNombre As System.Windows.Forms.TextBox
	Private txtDescripcion As System.Windows.Forms.TextBox
	Private button1 As System.Windows.Forms.Button
	Private button3 As System.Windows.Forms.Button
End Class
