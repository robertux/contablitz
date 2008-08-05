'
' Created by SharpDevelop.
' User: _
' Date: 01/01/2001
' Time: 3:50
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class frmBalanceComprobacion
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
		Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Me.label1 = New System.Windows.Forms.Label
		Me.label2 = New System.Windows.Forms.Label
		Me.grdBalanceComprobacion = New System.Windows.Forms.DataGridView
		Me.colFolio = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colCuentas = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colDebe = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colHaber = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colDeudor = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colAcreedor = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colCargo = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colAbono = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.btnCerrar = New System.Windows.Forms.Button
		Me.label3 = New System.Windows.Forms.Label
		Me.cmbPeriodos = New System.Windows.Forms.ComboBox
		Me.label4 = New System.Windows.Forms.Label
		CType(Me.grdBalanceComprobacion,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.Location = New System.Drawing.Point(12, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(117, 13)
		Me.label1.TabIndex = 0
		Me.label1.Text = "(nombre de la empresa)"
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Location = New System.Drawing.Point(12, 32)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(221, 13)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Balance de Comprobacion de sumas y saldos"
		'
		'grdBalanceComprobacion
		'
		Me.grdBalanceComprobacion.AllowUserToAddRows = false
		Me.grdBalanceComprobacion.AllowUserToDeleteRows = false
		Me.grdBalanceComprobacion.AllowUserToResizeColumns = false
		Me.grdBalanceComprobacion.AllowUserToResizeRows = false
		Me.grdBalanceComprobacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.grdBalanceComprobacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdBalanceComprobacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFolio, Me.colCuentas, Me.colDebe, Me.colHaber, Me.colDeudor, Me.colAcreedor, Me.colCargo, Me.colAbono})
		Me.grdBalanceComprobacion.Location = New System.Drawing.Point(12, 92)
		Me.grdBalanceComprobacion.MultiSelect = false
		Me.grdBalanceComprobacion.Name = "grdBalanceComprobacion"
		Me.grdBalanceComprobacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.grdBalanceComprobacion.Size = New System.Drawing.Size(908, 295)
		Me.grdBalanceComprobacion.TabIndex = 2
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
		'colDebe
		'
		dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
		Me.colDebe.DefaultCellStyle = dataGridViewCellStyle1
		Me.colDebe.HeaderText = "Debe"
		Me.colDebe.Name = "colDebe"
		Me.colDebe.ReadOnly = true
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
		'colDeudor
		'
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
		Me.colDeudor.DefaultCellStyle = dataGridViewCellStyle3
		Me.colDeudor.HeaderText = "Deudor"
		Me.colDeudor.Name = "colDeudor"
		Me.colDeudor.ReadOnly = true
		Me.colDeudor.Width = 67
		'
		'colAcreedor
		'
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
		Me.colAcreedor.DefaultCellStyle = dataGridViewCellStyle4
		Me.colAcreedor.HeaderText = "Acreedor"
		Me.colAcreedor.Name = "colAcreedor"
		Me.colAcreedor.ReadOnly = true
		Me.colAcreedor.Width = 75
		'
		'colCargo
		'
		Me.colCargo.HeaderText = "Cargos de Ajuste"
		Me.colCargo.Name = "colCargo"
		Me.colCargo.Width = 77
		'
		'colAbono
		'
		Me.colAbono.HeaderText = "Abonos de Ajuste"
		Me.colAbono.Name = "colAbono"
		Me.colAbono.Width = 79
		'
		'btnCerrar
		'
		Me.btnCerrar.Location = New System.Drawing.Point(812, 393)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(108, 23)
		Me.btnCerrar.TabIndex = 3
		Me.btnCerrar.Text = "Cerrar"
		Me.btnCerrar.UseVisualStyleBackColor = true
		AddHandler Me.btnCerrar.Click, AddressOf Me.BtnCerrarClick
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Location = New System.Drawing.Point(12, 55)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(46, 13)
		Me.label3.TabIndex = 4
		Me.label3.Text = "Periodo:"
		'
		'cmbPeriodos
		'
		Me.cmbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbPeriodos.FormattingEnabled = true
		Me.cmbPeriodos.Location = New System.Drawing.Point(64, 55)
		Me.cmbPeriodos.Name = "cmbPeriodos"
		Me.cmbPeriodos.Size = New System.Drawing.Size(155, 21)
		Me.cmbPeriodos.TabIndex = 5
		AddHandler Me.cmbPeriodos.SelectedIndexChanged, AddressOf Me.CmbPeriodosSelectedIndexChanged
		'
		'label4
		'
		Me.label4.AutoSize = true
		Me.label4.Location = New System.Drawing.Point(225, 58)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(167, 13)
		Me.label4.TabIndex = 6
		Me.label4.Text = "del 1 de Enero al 31 de Diciembre"
		'
		'frmBalanceComprobacion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(929, 446)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.cmbPeriodos)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.btnCerrar)
		Me.Controls.Add(Me.grdBalanceComprobacion)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "frmBalanceComprobacion"
		Me.Text = "ContaBlitz - BalanceComprobacion"
		AddHandler Load, AddressOf Me.FrmBalanceComprobacionLoad
		CType(Me.grdBalanceComprobacion,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private colAbono As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colCargo As System.Windows.Forms.DataGridViewTextBoxColumn
	Private cmbPeriodos As System.Windows.Forms.ComboBox
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private colAcreedor As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colDeudor As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colHaber As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colDebe As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colCuentas As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colFolio As System.Windows.Forms.DataGridViewTextBoxColumn
	Private grdBalanceComprobacion As System.Windows.Forms.DataGridView
	Private btnCerrar As System.Windows.Forms.Button
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
End Class
