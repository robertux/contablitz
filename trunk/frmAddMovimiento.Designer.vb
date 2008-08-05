'
' Created by SharpDevelop.
' User: _
' Date: 01/01/2001
' Time: 9:16
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class frmAddMovimiento
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
		Me.label2 = New System.Windows.Forms.Label
		Me.label3 = New System.Windows.Forms.Label
		Me.txtCodCuenta = New System.Windows.Forms.TextBox
		Me.nmcMonto = New System.Windows.Forms.NumericUpDown
		Me.cmbTipo = New System.Windows.Forms.ComboBox
		Me.btnCancelar = New System.Windows.Forms.Button
		Me.btnAceptar = New System.Windows.Forms.Button
		CType(Me.nmcMonto,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.Location = New System.Drawing.Point(20, 23)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(106, 13)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Codigo de la Cuenta:"
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Location = New System.Drawing.Point(20, 50)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(40, 13)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Monto:"
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Location = New System.Drawing.Point(20, 77)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(31, 13)
		Me.label3.TabIndex = 2
		Me.label3.Text = "Tipo:"
		'
		'txtCodCuenta
		'
		Me.txtCodCuenta.Location = New System.Drawing.Point(132, 20)
		Me.txtCodCuenta.Name = "txtCodCuenta"
		Me.txtCodCuenta.Size = New System.Drawing.Size(166, 20)
		Me.txtCodCuenta.TabIndex = 3
		'
		'nmcMonto
		'
		Me.nmcMonto.DecimalPlaces = 2
		Me.nmcMonto.Location = New System.Drawing.Point(132, 48)
		Me.nmcMonto.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
		Me.nmcMonto.Name = "nmcMonto"
		Me.nmcMonto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.nmcMonto.Size = New System.Drawing.Size(166, 20)
		Me.nmcMonto.TabIndex = 4
		Me.nmcMonto.ThousandsSeparator = true
		Me.nmcMonto.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'cmbTipo
		'
		Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTipo.FormattingEnabled = true
		Me.cmbTipo.Items.AddRange(New Object() {"Cargo", "Abono"})
		Me.cmbTipo.Location = New System.Drawing.Point(132, 74)
		Me.cmbTipo.Name = "cmbTipo"
		Me.cmbTipo.Size = New System.Drawing.Size(166, 21)
		Me.cmbTipo.TabIndex = 5
		'
		'btnCancelar
		'
		Me.btnCancelar.Location = New System.Drawing.Point(352, 55)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(121, 23)
		Me.btnCancelar.TabIndex = 12
		Me.btnCancelar.Text = "Cancelar"
		Me.btnCancelar.UseVisualStyleBackColor = true
		AddHandler Me.btnCancelar.Click, AddressOf Me.BtnCancelarClick
		'
		'btnAceptar
		'
		Me.btnAceptar.Location = New System.Drawing.Point(352, 17)
		Me.btnAceptar.Name = "btnAceptar"
		Me.btnAceptar.Size = New System.Drawing.Size(121, 23)
		Me.btnAceptar.TabIndex = 11
		Me.btnAceptar.Text = "Aceptar"
		Me.btnAceptar.UseVisualStyleBackColor = true
		AddHandler Me.btnAceptar.Click, AddressOf Me.BtnAceptarClick
		'
		'frmAddMovimiento
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(499, 110)
		Me.ControlBox = false
		Me.Controls.Add(Me.btnCancelar)
		Me.Controls.Add(Me.btnAceptar)
		Me.Controls.Add(Me.cmbTipo)
		Me.Controls.Add(Me.nmcMonto)
		Me.Controls.Add(Me.txtCodCuenta)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Name = "frmAddMovimiento"
		Me.Text = "ContaBlitz - Agregar Movimiento"
		AddHandler Load, AddressOf Me.FrmAddMovimientoLoad
		CType(Me.nmcMonto,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnAceptar As System.Windows.Forms.Button
	Private btnCancelar As System.Windows.Forms.Button
	Private txtCodCuenta As System.Windows.Forms.TextBox
	Private nmcMonto As System.Windows.Forms.NumericUpDown
	Private cmbTipo As System.Windows.Forms.ComboBox
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
End Class
