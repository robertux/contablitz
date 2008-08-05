'
' Created by SharpDevelop.
' User: _
' Date: 01/01/2001
' Time: 3:57
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class frmBalanceAjustado
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
		Me.label4 = New System.Windows.Forms.Label
		Me.cmbPeriodos = New System.Windows.Forms.ComboBox
		Me.label3 = New System.Windows.Forms.Label
		Me.btnCerrar = New System.Windows.Forms.Button
		Me.grdBalanceComprobacion = New System.Windows.Forms.DataGridView
		Me.colFolio = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colCuentas = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colCargo = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colAbono = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.label2 = New System.Windows.Forms.Label
		Me.label1 = New System.Windows.Forms.Label
		CType(Me.grdBalanceComprobacion,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'label4
		'
		Me.label4.AutoSize = true
		Me.label4.Location = New System.Drawing.Point(225, 64)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(167, 13)
		Me.label4.TabIndex = 13
		Me.label4.Text = "del 1 de Enero al 31 de Diciembre"
		'
		'cmbPeriodos
		'
		Me.cmbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbPeriodos.FormattingEnabled = true
		Me.cmbPeriodos.Location = New System.Drawing.Point(64, 61)
		Me.cmbPeriodos.Name = "cmbPeriodos"
		Me.cmbPeriodos.Size = New System.Drawing.Size(155, 21)
		Me.cmbPeriodos.TabIndex = 12
		AddHandler Me.cmbPeriodos.SelectedIndexChanged, AddressOf Me.CmbPeriodosSelectedIndexChanged
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Location = New System.Drawing.Point(12, 61)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(46, 13)
		Me.label3.TabIndex = 11
		Me.label3.Text = "Periodo:"
		'
		'btnCerrar
		'
		Me.btnCerrar.Location = New System.Drawing.Point(812, 399)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(108, 23)
		Me.btnCerrar.TabIndex = 10
		Me.btnCerrar.Text = "Cerrar"
		Me.btnCerrar.UseVisualStyleBackColor = true
		AddHandler Me.btnCerrar.Click, AddressOf Me.BtnCerrarClick
		'
		'grdBalanceComprobacion
		'
		Me.grdBalanceComprobacion.AllowUserToAddRows = false
		Me.grdBalanceComprobacion.AllowUserToDeleteRows = false
		Me.grdBalanceComprobacion.AllowUserToResizeColumns = false
		Me.grdBalanceComprobacion.AllowUserToResizeRows = false
		Me.grdBalanceComprobacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.grdBalanceComprobacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdBalanceComprobacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFolio, Me.colCuentas, Me.colCargo, Me.colAbono})
		Me.grdBalanceComprobacion.Location = New System.Drawing.Point(12, 98)
		Me.grdBalanceComprobacion.MultiSelect = false
		Me.grdBalanceComprobacion.Name = "grdBalanceComprobacion"
		Me.grdBalanceComprobacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.grdBalanceComprobacion.Size = New System.Drawing.Size(908, 295)
		Me.grdBalanceComprobacion.TabIndex = 9
		'
		'colFolio
		'
		Me.colFolio.HeaderText = "Folio"
		Me.colFolio.Name = "colFolio"
		Me.colFolio.ReadOnly = true
		Me.colFolio.Width = 54
		'
		'colCuentas
		'
		Me.colCuentas.HeaderText = "Cuentas"
		Me.colCuentas.Name = "colCuentas"
		Me.colCuentas.ReadOnly = true
		Me.colCuentas.Width = 71
		'
		'colCargo
		'
		Me.colCargo.HeaderText = "Cargos Ajustados"
		Me.colCargo.Name = "colCargo"
		Me.colCargo.Width = 105
		'
		'colAbono
		'
		Me.colAbono.HeaderText = "Abonos Ajustados"
		Me.colAbono.Name = "colAbono"
		Me.colAbono.Width = 107
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Location = New System.Drawing.Point(12, 38)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(175, 13)
		Me.label2.TabIndex = 8
		Me.label2.Text = "Balance de Comprobacion ajustado"
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.Location = New System.Drawing.Point(12, 15)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(117, 13)
		Me.label1.TabIndex = 7
		Me.label1.Text = "(nombre de la empresa)"
		'
		'frmBalanceAjustado
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(933, 438)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.cmbPeriodos)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.btnCerrar)
		Me.Controls.Add(Me.grdBalanceComprobacion)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "frmBalanceAjustado"
		Me.Text = "Contablitz - Balance  de Comprobacion Ajustado"
		AddHandler Load, AddressOf Me.FrmBalanceAjustadoLoad
		CType(Me.grdBalanceComprobacion,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private colAbono As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colCargo As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colCuentas As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colFolio As System.Windows.Forms.DataGridViewTextBoxColumn
	Private grdBalanceComprobacion As System.Windows.Forms.DataGridView
	Private btnCerrar As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private cmbPeriodos As System.Windows.Forms.ComboBox
	Private label4 As System.Windows.Forms.Label
End Class
