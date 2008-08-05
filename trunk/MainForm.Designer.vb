'
' Created by SharpDevelop.
' User: _
' Date: 01/01/2001
' Time: 2:23
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
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
		Me.button1 = New System.Windows.Forms.Button
		Me.button2 = New System.Windows.Forms.Button
		Me.button3 = New System.Windows.Forms.Button
		Me.button4 = New System.Windows.Forms.Button
		Me.button5 = New System.Windows.Forms.Button
		Me.button6 = New System.Windows.Forms.Button
		Me.button7 = New System.Windows.Forms.Button
		Me.SuspendLayout
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(12, 22)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(170, 23)
		Me.button1.TabIndex = 0
		Me.button1.Text = "Catalogo de cuentas"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(12, 65)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(170, 23)
		Me.button2.TabIndex = 1
		Me.button2.Text = "Libro diario mayor"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'button3
		'
		Me.button3.Location = New System.Drawing.Point(12, 109)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(170, 23)
		Me.button3.TabIndex = 2
		Me.button3.Text = "Balance de comprobacion"
		Me.button3.UseVisualStyleBackColor = true
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'button4
		'
		Me.button4.Location = New System.Drawing.Point(12, 153)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(170, 23)
		Me.button4.TabIndex = 3
		Me.button4.Text = "Balance ajustado"
		Me.button4.UseVisualStyleBackColor = true
		AddHandler Me.button4.Click, AddressOf Me.Button4Click
		'
		'button5
		'
		Me.button5.Location = New System.Drawing.Point(12, 240)
		Me.button5.Name = "button5"
		Me.button5.Size = New System.Drawing.Size(170, 23)
		Me.button5.TabIndex = 4
		Me.button5.Text = "Partidas"
		Me.button5.UseVisualStyleBackColor = true
		AddHandler Me.button5.Click, AddressOf Me.Button5Click
		'
		'button6
		'
		Me.button6.Location = New System.Drawing.Point(12, 196)
		Me.button6.Name = "button6"
		Me.button6.Size = New System.Drawing.Size(170, 23)
		Me.button6.TabIndex = 5
		Me.button6.Text = "Estado de Resultados"
		Me.button6.UseVisualStyleBackColor = true
		AddHandler Me.button6.Click, AddressOf Me.Button6Click
		'
		'button7
		'
		Me.button7.Location = New System.Drawing.Point(220, 22)
		Me.button7.Name = "button7"
		Me.button7.Size = New System.Drawing.Size(170, 23)
		Me.button7.TabIndex = 6
		Me.button7.Text = "Cierres"
		Me.button7.UseVisualStyleBackColor = true
		AddHandler Me.button7.Click, AddressOf Me.Button7Click
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(534, 314)
		Me.Controls.Add(Me.button7)
		Me.Controls.Add(Me.button6)
		Me.Controls.Add(Me.button5)
		Me.Controls.Add(Me.button4)
		Me.Controls.Add(Me.button3)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.button1)
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "MainForm"
		Me.Text = "ContaBlitz"
		Me.ResumeLayout(false)
	End Sub
	Private button7 As System.Windows.Forms.Button
	Private button6 As System.Windows.Forms.Button
	Private button5 As System.Windows.Forms.Button
	Private button4 As System.Windows.Forms.Button
	Private button3 As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
End Class
