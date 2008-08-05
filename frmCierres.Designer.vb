'
' Created by SharpDevelop.
' User: _
' Date: 01/01/2001
' Time: 3:10
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class frmCierres
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
		Me.cmbPeriodos = New System.Windows.Forms.ComboBox
		Me.label3 = New System.Windows.Forms.Label
		Me.label4 = New System.Windows.Forms.Label
		Me.grdBalanceComprobacion = New System.Windows.Forms.DataGridView
		Me.colDebe = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colHaber = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.cmbValores = New System.Windows.Forms.ComboBox
		Me.label1 = New System.Windows.Forms.Label
		Me.btnCerrar = New System.Windows.Forms.Button
		CType(Me.grdBalanceComprobacion,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'cmbPeriodos
		'
		Me.cmbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbPeriodos.FormattingEnabled = true
		Me.cmbPeriodos.Location = New System.Drawing.Point(64, 70)
		Me.cmbPeriodos.Name = "cmbPeriodos"
		Me.cmbPeriodos.Size = New System.Drawing.Size(155, 21)
		Me.cmbPeriodos.TabIndex = 6
		AddHandler Me.cmbPeriodos.SelectedIndexChanged, AddressOf Me.CmbPeriodosSelectedIndexChanged
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Location = New System.Drawing.Point(12, 73)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(46, 13)
		Me.label3.TabIndex = 7
		Me.label3.Text = "Periodo:"
		'
		'label4
		'
		Me.label4.AutoSize = true
		Me.label4.Location = New System.Drawing.Point(225, 73)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(167, 13)
		Me.label4.TabIndex = 8
		Me.label4.Text = "del 1 de Enero al 31 de Diciembre"
		'
		'grdBalanceComprobacion
		'
		Me.grdBalanceComprobacion.AllowUserToAddRows = false
		Me.grdBalanceComprobacion.AllowUserToDeleteRows = false
		Me.grdBalanceComprobacion.AllowUserToResizeColumns = false
		Me.grdBalanceComprobacion.AllowUserToResizeRows = false
		Me.grdBalanceComprobacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.grdBalanceComprobacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdBalanceComprobacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDebe, Me.colHaber})
		Me.grdBalanceComprobacion.Location = New System.Drawing.Point(12, 110)
		Me.grdBalanceComprobacion.MultiSelect = false
		Me.grdBalanceComprobacion.Name = "grdBalanceComprobacion"
		Me.grdBalanceComprobacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.grdBalanceComprobacion.Size = New System.Drawing.Size(502, 186)
		Me.grdBalanceComprobacion.TabIndex = 9
		'
		'colDebe
		'
		Me.colDebe.HeaderText = "Debe"
		Me.colDebe.Name = "colDebe"
		Me.colDebe.Width = 58
		'
		'colHaber
		'
		Me.colHaber.HeaderText = "Haber"
		Me.colHaber.Name = "colHaber"
		Me.colHaber.Width = 61
		'
		'cmbValores
		'
		Me.cmbValores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbValores.FormattingEnabled = true
		Me.cmbValores.Items.AddRange(New Object() {"Balance General", "Balance de Comprobacion", "Balance de Ajustes", "Balance Ajustado", "Estado de Resultados"})
		Me.cmbValores.Location = New System.Drawing.Point(64, 31)
		Me.cmbValores.Name = "cmbValores"
		Me.cmbValores.Size = New System.Drawing.Size(155, 21)
		Me.cmbValores.TabIndex = 10
		AddHandler Me.cmbValores.SelectedIndexChanged, AddressOf Me.CmbValoresSelectedIndexChanged
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.Location = New System.Drawing.Point(12, 34)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(34, 13)
		Me.label1.TabIndex = 11
		Me.label1.Text = "Valor:"
		'
		'btnCerrar
		'
		Me.btnCerrar.Location = New System.Drawing.Point(406, 302)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(108, 23)
		Me.btnCerrar.TabIndex = 12
		Me.btnCerrar.Text = "Cerrar"
		Me.btnCerrar.UseVisualStyleBackColor = true
		AddHandler Me.btnCerrar.Click, AddressOf Me.BtnCerrarClick
		'
		'frmCierres
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(526, 337)
		Me.Controls.Add(Me.btnCerrar)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.cmbValores)
		Me.Controls.Add(Me.grdBalanceComprobacion)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.cmbPeriodos)
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "frmCierres"
		Me.Text = "ContaBlitz - Cierres"
		AddHandler Load, AddressOf Me.FrmCierresLoad
		CType(Me.grdBalanceComprobacion,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnCerrar As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
	Private cmbValores As System.Windows.Forms.ComboBox
	Private colHaber As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colDebe As System.Windows.Forms.DataGridViewTextBoxColumn
	Private grdBalanceComprobacion As System.Windows.Forms.DataGridView
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private cmbPeriodos As System.Windows.Forms.ComboBox
End Class
