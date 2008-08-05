'
' Created by SharpDevelop.
' User: _
' Date: 01/01/2001
' Time: 9:50
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class frmEditMonto
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
		Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
		Me.btnCancelar = New System.Windows.Forms.Button
		Me.btnAceptar = New System.Windows.Forms.Button
		CType(Me.numericUpDown1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.Location = New System.Drawing.Point(12, 32)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(40, 13)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Monto:"
		'
		'numericUpDown1
		'
		Me.numericUpDown1.DecimalPlaces = 2
		Me.numericUpDown1.Location = New System.Drawing.Point(58, 30)
		Me.numericUpDown1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
		Me.numericUpDown1.Name = "numericUpDown1"
		Me.numericUpDown1.Size = New System.Drawing.Size(153, 20)
		Me.numericUpDown1.TabIndex = 1
		Me.numericUpDown1.Tag = ""
		Me.numericUpDown1.ThousandsSeparator = true
		'
		'btnCancelar
		'
		Me.btnCancelar.Location = New System.Drawing.Point(253, 50)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(121, 23)
		Me.btnCancelar.TabIndex = 12
		Me.btnCancelar.Text = "Cancelar"
		Me.btnCancelar.UseVisualStyleBackColor = true
		AddHandler Me.btnCancelar.Click, AddressOf Me.BtnCancelarClick
		'
		'btnAceptar
		'
		Me.btnAceptar.Location = New System.Drawing.Point(253, 12)
		Me.btnAceptar.Name = "btnAceptar"
		Me.btnAceptar.Size = New System.Drawing.Size(121, 23)
		Me.btnAceptar.TabIndex = 11
		Me.btnAceptar.Text = "Aceptar"
		Me.btnAceptar.UseVisualStyleBackColor = true
		AddHandler Me.btnAceptar.Click, AddressOf Me.BtnAceptarClick
		'
		'frmEditMonto
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(383, 88)
		Me.ControlBox = false
		Me.Controls.Add(Me.btnCancelar)
		Me.Controls.Add(Me.btnAceptar)
		Me.Controls.Add(Me.numericUpDown1)
		Me.Controls.Add(Me.label1)
		Me.Name = "frmEditMonto"
		Me.Text = "ContaBlitz - Editar Monto"
		AddHandler Load, AddressOf Me.FrmEditMontoLoad
		CType(Me.numericUpDown1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnAceptar As System.Windows.Forms.Button
	Private btnCancelar As System.Windows.Forms.Button
	Private numericUpDown1 As System.Windows.Forms.NumericUpDown
	Private label1 As System.Windows.Forms.Label
End Class
