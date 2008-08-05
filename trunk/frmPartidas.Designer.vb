'
' Created by SharpDevelop.
' User: _
' Date: 01/01/2001
' Time: 4:34
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class frmPartidas
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.label1 = New System.Windows.Forms.Label
		Me.grdPartidas = New System.Windows.Forms.DataGridView
		Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colMotivo = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colTipo = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.label2 = New System.Windows.Forms.Label
		Me.btnCerrar = New System.Windows.Forms.Button
		Me.btnAgregarPartida = New System.Windows.Forms.Button
		Me.btnEliminarPartida = New System.Windows.Forms.Button
		Me.btnAgregarMovimiento = New System.Windows.Forms.Button
		Me.btnEliminarMovimiento = New System.Windows.Forms.Button
		Me.btnEditMonto = New System.Windows.Forms.Button
		Me.grdMovimientos = New System.Windows.Forms.DataGridView
		Me.colCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colMonto = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colTipoMov = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.label3 = New System.Windows.Forms.Label
		Me.cmbAnios = New System.Windows.Forms.ComboBox
		CType(Me.grdPartidas,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.grdMovimientos,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(12, 64)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(58, 16)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Partidas"
		'
		'grdPartidas
		'
		Me.grdPartidas.AllowUserToAddRows = false
		Me.grdPartidas.AllowUserToDeleteRows = false
		Me.grdPartidas.AllowUserToResizeColumns = false
		Me.grdPartidas.AllowUserToResizeRows = false
		Me.grdPartidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
		Me.grdPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdPartidas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNombre, Me.colFecha, Me.colMotivo, Me.colTipo})
		Me.grdPartidas.Location = New System.Drawing.Point(12, 83)
		Me.grdPartidas.MultiSelect = false
		Me.grdPartidas.Name = "grdPartidas"
		Me.grdPartidas.ReadOnly = true
		Me.grdPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.grdPartidas.Size = New System.Drawing.Size(513, 150)
		Me.grdPartidas.TabIndex = 1
		AddHandler Me.grdPartidas.SelectionChanged, AddressOf Me.GrdPartidasSelectionChanged
		'
		'colNombre
		'
		Me.colNombre.HeaderText = "Nombre"
		Me.colNombre.Name = "colNombre"
		Me.colNombre.ReadOnly = true
		Me.colNombre.Width = 69
		'
		'colFecha
		'
		Me.colFecha.HeaderText = "Fecha"
		Me.colFecha.Name = "colFecha"
		Me.colFecha.ReadOnly = true
		Me.colFecha.Width = 62
		'
		'colMotivo
		'
		Me.colMotivo.HeaderText = "Motivo"
		Me.colMotivo.Name = "colMotivo"
		Me.colMotivo.ReadOnly = true
		Me.colMotivo.Width = 64
		'
		'colTipo
		'
		Me.colTipo.HeaderText = "Tipo"
		Me.colTipo.Name = "colTipo"
		Me.colTipo.ReadOnly = true
		Me.colTipo.Width = 53
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(12, 251)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(84, 16)
		Me.label2.TabIndex = 2
		Me.label2.Text = "Movimientos"
		'
		'btnCerrar
		'
		Me.btnCerrar.Location = New System.Drawing.Point(534, 430)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(108, 23)
		Me.btnCerrar.TabIndex = 11
		Me.btnCerrar.Text = "Cerrar"
		Me.btnCerrar.UseVisualStyleBackColor = true
		AddHandler Me.btnCerrar.Click, AddressOf Me.BtnCerrarClick
		'
		'btnAgregarPartida
		'
		Me.btnAgregarPartida.Location = New System.Drawing.Point(543, 83)
		Me.btnAgregarPartida.Name = "btnAgregarPartida"
		Me.btnAgregarPartida.Size = New System.Drawing.Size(99, 23)
		Me.btnAgregarPartida.TabIndex = 12
		Me.btnAgregarPartida.Text = "Agregar"
		Me.btnAgregarPartida.UseVisualStyleBackColor = true
		AddHandler Me.btnAgregarPartida.Click, AddressOf Me.BtnAgregarPartidaClick
		'
		'btnEliminarPartida
		'
		Me.btnEliminarPartida.Location = New System.Drawing.Point(543, 112)
		Me.btnEliminarPartida.Name = "btnEliminarPartida"
		Me.btnEliminarPartida.Size = New System.Drawing.Size(99, 23)
		Me.btnEliminarPartida.TabIndex = 13
		Me.btnEliminarPartida.Text = "Eliminar"
		Me.btnEliminarPartida.UseVisualStyleBackColor = true
		AddHandler Me.btnEliminarPartida.Click, AddressOf Me.BtnEliminarPartidaClick
		'
		'btnAgregarMovimiento
		'
		Me.btnAgregarMovimiento.Location = New System.Drawing.Point(543, 270)
		Me.btnAgregarMovimiento.Name = "btnAgregarMovimiento"
		Me.btnAgregarMovimiento.Size = New System.Drawing.Size(99, 23)
		Me.btnAgregarMovimiento.TabIndex = 14
		Me.btnAgregarMovimiento.Text = "Agregar"
		Me.btnAgregarMovimiento.UseVisualStyleBackColor = true
		AddHandler Me.btnAgregarMovimiento.Click, AddressOf Me.BtnAgregarMovimientoClick
		'
		'btnEliminarMovimiento
		'
		Me.btnEliminarMovimiento.Location = New System.Drawing.Point(543, 299)
		Me.btnEliminarMovimiento.Name = "btnEliminarMovimiento"
		Me.btnEliminarMovimiento.Size = New System.Drawing.Size(99, 23)
		Me.btnEliminarMovimiento.TabIndex = 15
		Me.btnEliminarMovimiento.Text = "Eliminar"
		Me.btnEliminarMovimiento.UseVisualStyleBackColor = true
		AddHandler Me.btnEliminarMovimiento.Click, AddressOf Me.BtnEliminarMovimientoClick
		'
		'btnEditMonto
		'
		Me.btnEditMonto.Location = New System.Drawing.Point(543, 328)
		Me.btnEditMonto.Name = "btnEditMonto"
		Me.btnEditMonto.Size = New System.Drawing.Size(99, 23)
		Me.btnEditMonto.TabIndex = 16
		Me.btnEditMonto.Text = "Editar Monto"
		Me.btnEditMonto.UseVisualStyleBackColor = true
		AddHandler Me.btnEditMonto.Click, AddressOf Me.BtnEditMontoClick
		'
		'grdMovimientos
		'
		Me.grdMovimientos.AllowUserToAddRows = false
		Me.grdMovimientos.AllowUserToDeleteRows = false
		Me.grdMovimientos.AllowUserToResizeColumns = false
		Me.grdMovimientos.AllowUserToResizeRows = false
		Me.grdMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
		Me.grdMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCuenta, Me.colMonto, Me.colTipoMov})
		Me.grdMovimientos.Location = New System.Drawing.Point(12, 270)
		Me.grdMovimientos.MultiSelect = false
		Me.grdMovimientos.Name = "grdMovimientos"
		Me.grdMovimientos.ReadOnly = true
		Me.grdMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.grdMovimientos.Size = New System.Drawing.Size(513, 150)
		Me.grdMovimientos.TabIndex = 17
		'
		'colCuenta
		'
		Me.colCuenta.HeaderText = "Cuenta"
		Me.colCuenta.Name = "colCuenta"
		Me.colCuenta.ReadOnly = true
		Me.colCuenta.Width = 66
		'
		'colMonto
		'
		Me.colMonto.HeaderText = "Monto"
		Me.colMonto.Name = "colMonto"
		Me.colMonto.ReadOnly = true
		Me.colMonto.Width = 62
		'
		'colTipoMov
		'
		Me.colTipoMov.HeaderText = "Tipo"
		Me.colTipoMov.Name = "colTipoMov"
		Me.colTipoMov.ReadOnly = true
		Me.colTipoMov.Width = 53
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Location = New System.Drawing.Point(12, 9)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(26, 13)
		Me.label3.TabIndex = 18
		Me.label3.Text = "Año"
		'
		'cmbAnios
		'
		Me.cmbAnios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbAnios.FormattingEnabled = true
		Me.cmbAnios.Location = New System.Drawing.Point(54, 6)
		Me.cmbAnios.Name = "cmbAnios"
		Me.cmbAnios.Size = New System.Drawing.Size(127, 21)
		Me.cmbAnios.TabIndex = 19
		AddHandler Me.cmbAnios.SelectedIndexChanged, AddressOf Me.CmbAniosSelectedIndexChanged
		'
		'frmPartidas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(654, 465)
		Me.Controls.Add(Me.cmbAnios)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.grdMovimientos)
		Me.Controls.Add(Me.btnEditMonto)
		Me.Controls.Add(Me.btnEliminarMovimiento)
		Me.Controls.Add(Me.btnAgregarMovimiento)
		Me.Controls.Add(Me.btnEliminarPartida)
		Me.Controls.Add(Me.btnAgregarPartida)
		Me.Controls.Add(Me.btnCerrar)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.grdPartidas)
		Me.Controls.Add(Me.label1)
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "frmPartidas"
		Me.Text = "ContaBlitz - Partidas"
		AddHandler Load, AddressOf Me.FrmPartidasLoad
		CType(Me.grdPartidas,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.grdMovimientos,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private colTipoMov As System.Windows.Forms.DataGridViewTextBoxColumn
	Private grdMovimientos As System.Windows.Forms.DataGridView
	Private cmbAnios As System.Windows.Forms.ComboBox
	Private label3 As System.Windows.Forms.Label
	Private colMonto As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colTipo As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colMotivo As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colFecha As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
	Private btnEditMonto As System.Windows.Forms.Button
	Private btnEliminarMovimiento As System.Windows.Forms.Button
	Private btnAgregarMovimiento As System.Windows.Forms.Button
	Private btnEliminarPartida As System.Windows.Forms.Button
	Private btnAgregarPartida As System.Windows.Forms.Button
	Private btnCerrar As System.Windows.Forms.Button
	Private label2 As System.Windows.Forms.Label
	Private grdPartidas As System.Windows.Forms.DataGridView
	Private label1 As System.Windows.Forms.Label
End Class
