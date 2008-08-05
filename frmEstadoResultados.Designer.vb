'
' Created by SharpDevelop.
' User: _
' Date: 01/01/2001
' Time: 0:47
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class frmEstadoResultados
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
		Me.btnCerrar = New System.Windows.Forms.Button
		Me.cmbPeriodos = New System.Windows.Forms.ComboBox
		Me.label3 = New System.Windows.Forms.Label
		Me.label2 = New System.Windows.Forms.Label
		Me.label1 = New System.Windows.Forms.Label
		Me.comboBox1 = New System.Windows.Forms.ComboBox
		Me.label4 = New System.Windows.Forms.Label
		Me.grdEstadoResultados = New System.Windows.Forms.DataGridView
		Me.colCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colEspacio = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colParcial = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.grdCapital = New System.Windows.Forms.DataGridView
		Me.label5 = New System.Windows.Forms.Label
		Me.colCuenta1 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colEspacio1 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colParcial1 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colTotal1 = New System.Windows.Forms.DataGridViewTextBoxColumn
		CType(Me.grdEstadoResultados,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.grdCapital,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'btnCerrar
		'
		Me.btnCerrar.Location = New System.Drawing.Point(522, 517)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(120, 23)
		Me.btnCerrar.TabIndex = 0
		Me.btnCerrar.Text = "Cerrar"
		Me.btnCerrar.UseVisualStyleBackColor = true
		AddHandler Me.btnCerrar.Click, AddressOf Me.BtnCerrarClick
		'
		'cmbPeriodos
		'
		Me.cmbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbPeriodos.FormattingEnabled = true
		Me.cmbPeriodos.Location = New System.Drawing.Point(225, 55)
		Me.cmbPeriodos.Name = "cmbPeriodos"
		Me.cmbPeriodos.Size = New System.Drawing.Size(155, 21)
		Me.cmbPeriodos.TabIndex = 10
		AddHandler Me.cmbPeriodos.SelectedIndexChanged, AddressOf Me.CmbPeriodosSelectedIndexChanged
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Location = New System.Drawing.Point(12, 55)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(46, 13)
		Me.label3.TabIndex = 9
		Me.label3.Text = "Periodo:"
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Location = New System.Drawing.Point(12, 32)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(111, 13)
		Me.label2.TabIndex = 8
		Me.label2.Text = "Estado de Resultados"
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.Location = New System.Drawing.Point(12, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(117, 13)
		Me.label1.TabIndex = 7
		Me.label1.Text = "(nombre de la empresa)"
		'
		'comboBox1
		'
		Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBox1.FormattingEnabled = true
		Me.comboBox1.Location = New System.Drawing.Point(73, 55)
		Me.comboBox1.Name = "comboBox1"
		Me.comboBox1.Size = New System.Drawing.Size(121, 21)
		Me.comboBox1.TabIndex = 11
		AddHandler Me.comboBox1.SelectedIndexChanged, AddressOf Me.ComboBox1SelectedIndexChanged
		'
		'label4
		'
		Me.label4.AutoSize = true
		Me.label4.Location = New System.Drawing.Point(200, 58)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(19, 13)
		Me.label4.TabIndex = 12
		Me.label4.Text = "de"
		'
		'grdEstadoResultados
		'
		Me.grdEstadoResultados.AllowUserToAddRows = false
		Me.grdEstadoResultados.AllowUserToDeleteRows = false
		Me.grdEstadoResultados.AllowUserToResizeColumns = false
		Me.grdEstadoResultados.AllowUserToResizeRows = false
		Me.grdEstadoResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.grdEstadoResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdEstadoResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCuenta, Me.colEspacio, Me.colParcial, Me.colTotal})
		Me.grdEstadoResultados.Location = New System.Drawing.Point(12, 82)
		Me.grdEstadoResultados.MultiSelect = false
		Me.grdEstadoResultados.Name = "grdEstadoResultados"
		Me.grdEstadoResultados.ReadOnly = true
		Me.grdEstadoResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.grdEstadoResultados.Size = New System.Drawing.Size(630, 248)
		Me.grdEstadoResultados.TabIndex = 13
		'
		'colCuenta
		'
		Me.colCuenta.HeaderText = "Cuenta"
		Me.colCuenta.Name = "colCuenta"
		Me.colCuenta.ReadOnly = true
		Me.colCuenta.Width = 66
		'
		'colEspacio
		'
		Me.colEspacio.HeaderText = "_"
		Me.colEspacio.Name = "colEspacio"
		Me.colEspacio.ReadOnly = true
		Me.colEspacio.Width = 38
		'
		'colParcial
		'
		Me.colParcial.HeaderText = "Parcial"
		Me.colParcial.Name = "colParcial"
		Me.colParcial.ReadOnly = true
		Me.colParcial.Width = 64
		'
		'colTotal
		'
		Me.colTotal.HeaderText = "Total"
		Me.colTotal.Name = "colTotal"
		Me.colTotal.ReadOnly = true
		Me.colTotal.Width = 56
		'
		'grdCapital
		'
		Me.grdCapital.AllowUserToAddRows = false
		Me.grdCapital.AllowUserToDeleteRows = false
		Me.grdCapital.AllowUserToResizeColumns = false
		Me.grdCapital.AllowUserToResizeRows = false
		Me.grdCapital.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.grdCapital.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdCapital.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCuenta1, Me.colEspacio1, Me.colParcial1, Me.colTotal1})
		Me.grdCapital.Location = New System.Drawing.Point(12, 380)
		Me.grdCapital.MultiSelect = false
		Me.grdCapital.Name = "grdCapital"
		Me.grdCapital.ReadOnly = true
		Me.grdCapital.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.grdCapital.Size = New System.Drawing.Size(630, 131)
		Me.grdCapital.TabIndex = 14
		'
		'label5
		'
		Me.label5.AutoSize = true
		Me.label5.Location = New System.Drawing.Point(12, 355)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(101, 13)
		Me.label5.TabIndex = 15
		Me.label5.Text = "Variacion de Capital"
		'
		'colCuenta1
		'
		Me.colCuenta1.HeaderText = "Cuenta"
		Me.colCuenta1.Name = "colCuenta1"
		Me.colCuenta1.ReadOnly = true
		Me.colCuenta1.Width = 66
		'
		'colEspacio1
		'
		Me.colEspacio1.HeaderText = "_"
		Me.colEspacio1.Name = "colEspacio1"
		Me.colEspacio1.ReadOnly = true
		Me.colEspacio1.Width = 38
		'
		'colParcial1
		'
		Me.colParcial1.HeaderText = "Parcial"
		Me.colParcial1.Name = "colParcial1"
		Me.colParcial1.ReadOnly = true
		Me.colParcial1.Width = 64
		'
		'colTotal1
		'
		Me.colTotal1.HeaderText = "Total"
		Me.colTotal1.Name = "colTotal1"
		Me.colTotal1.ReadOnly = true
		Me.colTotal1.Width = 56
		'
		'frmEstadoResultados
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(660, 552)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.grdCapital)
		Me.Controls.Add(Me.grdEstadoResultados)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.comboBox1)
		Me.Controls.Add(Me.cmbPeriodos)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.btnCerrar)
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "frmEstadoResultados"
		Me.Text = "ContaBlitz - Estado de Resultados"
		AddHandler Load, AddressOf Me.FrmEstadoResultadosLoad
		CType(Me.grdEstadoResultados,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.grdCapital,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private colTotal1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colParcial1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colEspacio1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colCuenta1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Private label5 As System.Windows.Forms.Label
	Private grdCapital As System.Windows.Forms.DataGridView
	Private grdEstadoResultados As System.Windows.Forms.DataGridView
	Private colTotal As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colParcial As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colEspacio As System.Windows.Forms.DataGridViewTextBoxColumn
	Private colCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
	Private comboBox1 As System.Windows.Forms.ComboBox
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private cmbPeriodos As System.Windows.Forms.ComboBox
	Private label4 As System.Windows.Forms.Label
	Private btnCerrar As System.Windows.Forms.Button
End Class
