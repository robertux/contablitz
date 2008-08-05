
''' <summary>
''' Representa un registro de la tabla cuentas
''' </summary>
Public Class Cuenta	
	Private _codigo As String
	Private _nombre As String
	Private _descripcion As String

	
	''' <summary>
	''' El codigo de la cuenta
	''' </summary>
	Public Property Codigo As String
		Get
			return me._codigo
		End Get
		Set
			me._codigo = value
		End Set
	End Property
	
	''' <summary>
	''' El nombre de la cuenta
	''' </summary>
	Public Property Nombre As String
		Get
			return me._nombre
		End Get
		Set
			me._nombre = value
		End Set
	End Property
	
	''' <summary>
	''' La descripcion de la cuenta
	''' </summary>
	Public Property Descripcion As String
		Get
			return me._descripcion
		End Get
		Set
			me._descripcion = value
		End Set
	End Property
	
	''' <summary>
	''' Construye una nueva instancia de la clase cuenta
	''' </summary>
	''' <param name="cod">El codigo de la cuenta</param>
	''' <param name="nom">El nombre de la cuenta</param>
	''' <param name="desc">La descripcion de la cuenta</param>
	Public Sub New(ByVal cod As String, ByVal nom As String, ByVal desc As String)
		Me.Codigo = cod
		Me.Nombre = nom
		me.Descripcion = desc
	End Sub
End Class
