
Partial Class frmLibroDiario
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
		Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Me.lblCuentaSeleccionada = New System.Windows.Forms.Label
		Me.grdLibroMayor = New System.Windows.Forms.DataGridView
		Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colDebe = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colHaber = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.btnCerrar = New System.Windows.Forms.Button
		Me.cmbCuentas = New System.Windows.Forms.ComboBox
		Me.cmbAnios = New System.Windows.Forms.ComboBox
		Me.label3 = New System.Windows.Forms.Label
		CType(Me.grdLibroMayor,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'lblCuentaSeleccionada
		'
		Me.lblCuentaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblCuentaSeleccionada.Location = New System.Drawing.Point(12, 9)
		Me.lblCuentaSeleccionada.Name = "lblCuentaSeleccionada"
		Me.lblCuentaSeleccionada.Size = New System.Drawing.Size(73, 23)
		Me.lblCuentaSeleccionada.TabIndex = 6
		Me.lblCuentaSeleccionada.Text = "Cuenta:"
		'
		'grdLibroMayor
		'
		Me.grdLibroMayor.AllowUserToAddRows = false
		Me.grdLibroMayor.AllowUserToDeleteRows = false
		Me.grdLibroMayor.AllowUserToResizeColumns = false
		Me.grdLibroMayor.AllowUserToResizeRows = false
		Me.grdLibroMayor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.grdLibroMayor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdLibroMayor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFecha, Me.colDetalle, Me.colDebe, Me.colHaber, Me.colSaldo})
		Me.grdLibroMayor.Location = New System.Drawing.Point(12, 96)
		Me.grdLibroMayor.MultiSelect = false
		Me.grdLibroMayor.Name = "grdLibroMayor"
		Me.grdLibroMayor.ReadOnly = true
		Me.grdLibroMayor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.grdLibroMayor.Size = New System.Drawing.Size(810, 347)
		Me.grdLibroMayor.TabIndex = 7
		'
		'colFecha
		'
		Me.colFecha.HeaderText = "Fecha"
		Me.colFecha.Name = "colFecha"
		Me.colFecha.ReadOnly = true
		Me.colFecha.Width = 62
		'
		'colDetalle
		'
		Me.colDetalle.HeaderText = "Detalle"
		Me.colDetalle.Name = "colDetalle"
		Me.colDetalle.ReadOnly = true
		Me.colDetalle.Width = 65
		'
		'colDebe
		'
		dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
		Me.colDebe.DefaultCellStyle = dataGridViewCellStyle1
		Me.colDebe.HeaderText = "Debe"
		Me.colDebe.Name = "colDebe"
		Me.colDebe.ReadOnly = true
		Me.colDebe.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.colDebe.Width = 58
		'
		'colHaber
		'
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
		Me.colHaber.DefaultCellStyle = dataGridViewCellStyle2
		Me.colHaber.HeaderText = "Haber"
		Me.colHaber.Name = "colHaber"
		Me.colHaber.ReadOnly = true
		Me.colHaber.Width = 61
		'
		'colSaldo
		'
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
		Me.colSaldo.DefaultCellStyle = dataGridViewCellStyle3
		Me.colSaldo.HeaderText = "Saldo"
		Me.colSaldo.Name = "colSaldo"
		Me.colSaldo.ReadOnly = true
		Me.colSaldo.Width = 59
		'
		'btnCerrar
		'
		Me.btnCerrar.Location = New System.Drawing.Point(717, 449)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(105, 23)
		Me.btnCerrar.TabIndex = 8
		Me.btnCerrar.Text = "Cerrar"
		Me.btnCerrar.UseVisualStyleBackColor = true
		AddHandler Me.btnCerrar.Click, AddressOf Me.BtnCerrarClick
		'
		'cmbCuentas
		'
		Me.cmbCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbCuentas.FormattingEnabled = true
		Me.cmbCuentas.Location = New System.Drawing.Point(91, 8)
		Me.cmbCuentas.Name = "cmbCuentas"
		Me.cmbCuentas.Size = New System.Drawing.Size(395, 21)
		Me.cmbCuentas.TabIndex = 9
		AddHandler Me.cmbCuentas.SelectedIndexChanged, AddressOf Me.CmbCuentasSelectedIndexChanged
		'
		'cmbAnios
		'
		Me.cmbAnios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbAnios.FormattingEnabled = true
		Me.cmbAnios.Location = New System.Drawing.Point(91, 44)
		Me.cmbAnios.Name = "cmbAnios"
		Me.cmbAnios.Size = New System.Drawing.Size(127, 21)
		Me.cmbAnios.TabIndex = 21
		AddHandler Me.cmbAnios.SelectedIndexChanged, AddressOf Me.CmbAniosSelectedIndexChanged
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Location = New System.Drawing.Point(49, 47)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(26, 13)
		Me.label3.TabIndex = 20
		Me.label3.Text = "Año"
		'
		'frmLibroDiario
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(834, 480)
		Me.Controls.Add(Me.cmbAnios)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.cmbCuentas)
		Me.Controls.Add(Me.btnCerrar)
		Me.Controls.Add(Me.grdLibroMayor)
		Me.Controls.Add(Me.lblCuentaSeleccionada)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "frmLibroDiario"
		Me.Text = "ContaBlitz - Libro Diario Mayor"
		AddHandler Load, AddressOf Me.FrmLibroDiarioLoad
		CType(Me.grdLibroMayor,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label3 As System.Windows.Forms.Label
	Private cmbAnios As System.Windows.Forms.ComboBox
	Private cmbCuentas As System.Windows.Forms.ComboBox
	Private colSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colHaber As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colDebe As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colFecha As System.Windows.Forms.DataGridViewTextBoxColumn
	Private btnCerrar As System.Windows.Forms.Button
	Private grdLibroMayor As System.Windows.Forms.DataGridView
	Private lblCuentaSeleccionada As System.Windows.Forms.Label
	
End Class
