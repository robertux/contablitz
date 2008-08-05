Partial Class frmCatalogoCuentas
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
		Me.cmbNivel1 = New System.Windows.Forms.ComboBox
		Me.cmbNivel2 = New System.Windows.Forms.ComboBox
		Me.cmbNivel3 = New System.Windows.Forms.ComboBox
		Me.cmbNivel4 = New System.Windows.Forms.ComboBox
		Me.cmbNivel5 = New System.Windows.Forms.ComboBox
		Me.groupBox1 = New System.Windows.Forms.GroupBox
		Me.lblNivelSeleccionado = New System.Windows.Forms.Label
		Me.lblDescripcionCuenta = New System.Windows.Forms.Label
		Me.btnAddCuenta = New System.Windows.Forms.Button
		Me.btnEditCuenta = New System.Windows.Forms.Button
		Me.btnDelCuenta = New System.Windows.Forms.Button
		Me.btnLibroDiario = New System.Windows.Forms.Button
		Me.groupBox1.SuspendLayout
		Me.SuspendLayout
		'
		'cmbNivel1
		'
		Me.cmbNivel1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbNivel1.Enabled = false
		Me.cmbNivel1.FormattingEnabled = true
		Me.cmbNivel1.Location = New System.Drawing.Point(12, 55)
		Me.cmbNivel1.Name = "cmbNivel1"
		Me.cmbNivel1.Size = New System.Drawing.Size(272, 21)
		Me.cmbNivel1.TabIndex = 0
		AddHandler Me.cmbNivel1.Enter, AddressOf Me.CmbNivel1Enter
		AddHandler Me.cmbNivel1.SelectedIndexChanged, AddressOf Me.CmbNivel1SelectedIndexChanged
		'
		'cmbNivel2
		'
		Me.cmbNivel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbNivel2.Enabled = false
		Me.cmbNivel2.FormattingEnabled = true
		Me.cmbNivel2.Location = New System.Drawing.Point(12, 101)
		Me.cmbNivel2.Name = "cmbNivel2"
		Me.cmbNivel2.Size = New System.Drawing.Size(272, 21)
		Me.cmbNivel2.TabIndex = 0
		AddHandler Me.cmbNivel2.Enter, AddressOf Me.CmbNivel2Enter
		AddHandler Me.cmbNivel2.SelectedIndexChanged, AddressOf Me.CmbNivel2SelectedIndexChanged
		'
		'cmbNivel3
		'
		Me.cmbNivel3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbNivel3.Enabled = false
		Me.cmbNivel3.FormattingEnabled = true
		Me.cmbNivel3.Location = New System.Drawing.Point(12, 147)
		Me.cmbNivel3.Name = "cmbNivel3"
		Me.cmbNivel3.Size = New System.Drawing.Size(272, 21)
		Me.cmbNivel3.TabIndex = 0
		AddHandler Me.cmbNivel3.Enter, AddressOf Me.CmbNivel3Enter
		AddHandler Me.cmbNivel3.SelectedIndexChanged, AddressOf Me.CmbNivel3SelectedIndexChanged
		'
		'cmbNivel4
		'
		Me.cmbNivel4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbNivel4.Enabled = false
		Me.cmbNivel4.FormattingEnabled = true
		Me.cmbNivel4.Location = New System.Drawing.Point(12, 196)
		Me.cmbNivel4.Name = "cmbNivel4"
		Me.cmbNivel4.Size = New System.Drawing.Size(272, 21)
		Me.cmbNivel4.TabIndex = 0
		AddHandler Me.cmbNivel4.Enter, AddressOf Me.CmbNivel4Enter
		AddHandler Me.cmbNivel4.SelectedIndexChanged, AddressOf Me.CmbNivel4SelectedIndexChanged
		'
		'cmbNivel5
		'
		Me.cmbNivel5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbNivel5.Enabled = false
		Me.cmbNivel5.FormattingEnabled = true
		Me.cmbNivel5.Location = New System.Drawing.Point(12, 242)
		Me.cmbNivel5.Name = "cmbNivel5"
		Me.cmbNivel5.Size = New System.Drawing.Size(272, 21)
		Me.cmbNivel5.TabIndex = 0
		AddHandler Me.cmbNivel5.Enter, AddressOf Me.CmbNivel5Enter
		AddHandler Me.cmbNivel5.SelectedIndexChanged, AddressOf Me.CmbNivel5SelectedIndexChanged
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.lblNivelSeleccionado)
		Me.groupBox1.Controls.Add(Me.lblDescripcionCuenta)
		Me.groupBox1.Location = New System.Drawing.Point(303, 36)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(328, 309)
		Me.groupBox1.TabIndex = 1
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Detalle"
		'
		'lblNivelSeleccionado
		'
		Me.lblNivelSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblNivelSeleccionado.Location = New System.Drawing.Point(18, 26)
		Me.lblNivelSeleccionado.Name = "lblNivelSeleccionado"
		Me.lblNivelSeleccionado.Size = New System.Drawing.Size(295, 23)
		Me.lblNivelSeleccionado.TabIndex = 1
		'
		'lblDescripcionCuenta
		'
		Me.lblDescripcionCuenta.Location = New System.Drawing.Point(16, 65)
		Me.lblDescripcionCuenta.Name = "lblDescripcionCuenta"
		Me.lblDescripcionCuenta.Size = New System.Drawing.Size(297, 223)
		Me.lblDescripcionCuenta.TabIndex = 0
		'
		'btnAddCuenta
		'
		Me.btnAddCuenta.Location = New System.Drawing.Point(264, 374)
		Me.btnAddCuenta.Name = "btnAddCuenta"
		Me.btnAddCuenta.Size = New System.Drawing.Size(118, 28)
		Me.btnAddCuenta.TabIndex = 2
		Me.btnAddCuenta.Text = "Agregar cuenta..."
		Me.btnAddCuenta.UseVisualStyleBackColor = true
		AddHandler Me.btnAddCuenta.Click, AddressOf Me.BtnAddCuentaClick
		'
		'btnEditCuenta
		'
		Me.btnEditCuenta.Location = New System.Drawing.Point(388, 374)
		Me.btnEditCuenta.Name = "btnEditCuenta"
		Me.btnEditCuenta.Size = New System.Drawing.Size(118, 28)
		Me.btnEditCuenta.TabIndex = 2
		Me.btnEditCuenta.Text = "Modificar cuenta..."
		Me.btnEditCuenta.UseVisualStyleBackColor = true
		AddHandler Me.btnEditCuenta.Click, AddressOf Me.BtnEditCuentaClick
		'
		'btnDelCuenta
		'
		Me.btnDelCuenta.Location = New System.Drawing.Point(512, 374)
		Me.btnDelCuenta.Name = "btnDelCuenta"
		Me.btnDelCuenta.Size = New System.Drawing.Size(118, 28)
		Me.btnDelCuenta.TabIndex = 2
		Me.btnDelCuenta.Text = "Eliminar cuenta..."
		Me.btnDelCuenta.UseVisualStyleBackColor = true
		AddHandler Me.btnDelCuenta.Click, AddressOf Me.BtnDelCuentaClick
		'
		'btnLibroDiario
		'
		Me.btnLibroDiario.Enabled = false
		Me.btnLibroDiario.Location = New System.Drawing.Point(264, 420)
		Me.btnLibroDiario.Name = "btnLibroDiario"
		Me.btnLibroDiario.Size = New System.Drawing.Size(118, 23)
		Me.btnLibroDiario.TabIndex = 3
		Me.btnLibroDiario.Text = "Libro Diario..."
		Me.btnLibroDiario.UseVisualStyleBackColor = true
		AddHandler Me.btnLibroDiario.Click, AddressOf Me.BtnLibroDiarioClick
		'
		'frmCatalogoCuentas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(643, 475)
		Me.Controls.Add(Me.btnLibroDiario)
		Me.Controls.Add(Me.btnDelCuenta)
		Me.Controls.Add(Me.btnEditCuenta)
		Me.Controls.Add(Me.btnAddCuenta)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.cmbNivel5)
		Me.Controls.Add(Me.cmbNivel4)
		Me.Controls.Add(Me.cmbNivel3)
		Me.Controls.Add(Me.cmbNivel2)
		Me.Controls.Add(Me.cmbNivel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "frmCatalogoCuentas"
		Me.Text = "ContaBlitz - Catalogo de Cuentas"
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.groupBox1.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private btnLibroDiario As System.Windows.Forms.Button
	Private btnAddCuenta As System.Windows.Forms.Button
	Private btnEditCuenta As System.Windows.Forms.Button
	Private btnDelCuenta As System.Windows.Forms.Button
	Private lblNivelSeleccionado As System.Windows.Forms.Label
	Private lblDescripcionCuenta As System.Windows.Forms.Label
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private cmbNivel1 As System.Windows.Forms.ComboBox
	Private cmbNivel2 As System.Windows.Forms.ComboBox
	Private cmbNivel3 As System.Windows.Forms.ComboBox
	Private cmbNivel4 As System.Windows.Forms.ComboBox
	Private cmbNivel5 As System.Windows.Forms.ComboBox
End Class
