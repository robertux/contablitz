'
' Created by SharpDevelop.
' User: _
' Date: 01/01/2001
' Time: 8:11
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class frmAddPartida
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
		Me.label2 = New System.Windows.Forms.Label
		Me.label3 = New System.Windows.Forms.Label
		Me.label4 = New System.Windows.Forms.Label
		Me.label5 = New System.Windows.Forms.Label
		Me.txtNombre = New System.Windows.Forms.TextBox
		Me.cmbFecha = New System.Windows.Forms.DateTimePicker
		Me.txtMotivo = New System.Windows.Forms.TextBox
		Me.cmbTipo = New System.Windows.Forms.ComboBox
		Me.btnAceptar = New System.Windows.Forms.Button
		Me.btnCancelar = New System.Windows.Forms.Button
		Me.SuspendLayout
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Location = New System.Drawing.Point(12, 27)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(47, 13)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Nombre:"
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Location = New System.Drawing.Point(12, 59)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(40, 13)
		Me.label3.TabIndex = 2
		Me.label3.Text = "Fecha:"
		'
		'label4
		'
		Me.label4.AutoSize = true
		Me.label4.Location = New System.Drawing.Point(12, 88)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(42, 13)
		Me.label4.TabIndex = 3
		Me.label4.Text = "Motivo:"
		'
		'label5
		'
		Me.label5.AutoSize = true
		Me.label5.Location = New System.Drawing.Point(12, 197)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(31, 13)
		Me.label5.TabIndex = 4
		Me.label5.Text = "Tipo:"
		'
		'txtNombre
		'
		Me.txtNombre.Location = New System.Drawing.Point(76, 24)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(200, 20)
		Me.txtNombre.TabIndex = 5
		'
		'cmbFecha
		'
		Me.cmbFecha.Location = New System.Drawing.Point(76, 55)
		Me.cmbFecha.Name = "cmbFecha"
		Me.cmbFecha.Size = New System.Drawing.Size(200, 20)
		Me.cmbFecha.TabIndex = 6
		'
		'txtMotivo
		'
		Me.txtMotivo.Location = New System.Drawing.Point(76, 85)
		Me.txtMotivo.Multiline = true
		Me.txtMotivo.Name = "txtMotivo"
		Me.txtMotivo.Size = New System.Drawing.Size(200, 94)
		Me.txtMotivo.TabIndex = 7
		'
		'cmbTipo
		'
		Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbTipo.FormattingEnabled = true
		Me.cmbTipo.Items.AddRange(New Object() {"Normal", "Ajuste"})
		Me.cmbTipo.Location = New System.Drawing.Point(76, 189)
		Me.cmbTipo.Name = "cmbTipo"
		Me.cmbTipo.Size = New System.Drawing.Size(200, 21)
		Me.cmbTipo.TabIndex = 8
		'
		'btnAceptar
		'
		Me.btnAceptar.Location = New System.Drawing.Point(334, 17)
		Me.btnAceptar.Name = "btnAceptar"
		Me.btnAceptar.Size = New System.Drawing.Size(121, 23)
		Me.btnAceptar.TabIndex = 9
		Me.btnAceptar.Text = "Aceptar"
		Me.btnAceptar.UseVisualStyleBackColor = true
		AddHandler Me.btnAceptar.Click, AddressOf Me.BtnAceptarClick
		'
		'btnCancelar
		'
		Me.btnCancelar.Location = New System.Drawing.Point(334, 55)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(121, 23)
		Me.btnCancelar.TabIndex = 10
		Me.btnCancelar.Text = "Cancelar"
		Me.btnCancelar.UseVisualStyleBackColor = true
		AddHandler Me.btnCancelar.Click, AddressOf Me.BtnCancelarClick
		'
		'frmAddPartida
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(467, 237)
		Me.ControlBox = false
		Me.Controls.Add(Me.btnCancelar)
		Me.Controls.Add(Me.btnAceptar)
		Me.Controls.Add(Me.cmbTipo)
		Me.Controls.Add(Me.txtMotivo)
		Me.Controls.Add(Me.cmbFecha)
		Me.Controls.Add(Me.txtNombre)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Name = "frmAddPartida"
		Me.Text = "frmAddPartida"
		AddHandler Load, AddressOf Me.FrmAddPartidaLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnCancelar As System.Windows.Forms.Button
	Private btnAceptar As System.Windows.Forms.Button
	Private cmbTipo As System.Windows.Forms.ComboBox
	Private txtMotivo As System.Windows.Forms.TextBox
	Private cmbFecha As System.Windows.Forms.DateTimePicker
	Private txtNombre As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
End Class
