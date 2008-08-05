
''' <summary>
''' Representa un registro de la tabla partidas
''' </summary>
Public Class Partida
	Private _codigo As String
	Private _nombre As String
	Private _fecha As Date
	Private _motivo As String
	private _tipo as String
	
	''' <summary>
	''' El codigo de la partida
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
	''' El nombre de la partida
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
	''' La fecha cuando se creo la partida
	''' </summary>
	Public Property Fecha As Date
		Get
			Return Me._fecha			
		End Get
		Set
			me._fecha = value
		End Set
	End Property
	
	''' <summary>
	''' El motivo por el cual se realiza la partida
	''' </summary>
	Public Property Motivo As String
		Get
			return me._motivo
		End Get
		Set
			me._motivo = value
		End Set
	End Property
	
	''' <summary>
	''' El tipo de partida (normal, ajuste)
	''' </summary>
	Public Property Tipo As String
		Get
			return me._tipo
		End Get
		Set
			me._tipo = value
		End Set
	End Property
	
	''' <summary>
	''' Crea una nueva instancia de la clase Partida
	''' </summary>
	''' <param name="cod">El codigo de la partida</param>
	''' <param name="nom">El nombre de la partida</param>
	''' <param name="fcha">La fecha en la que se creo la partida</param>
	''' <param name="motv">El motivo por el cual se creo la partida</param>
	''' <param name="tpo">El tipo de partida</param>
	Public Sub New(ByVal cod As String, ByVal nom As String, ByVal fcha As Date, ByVal motv As String, tpo as String)
		Me._codigo = cod
		Me._nombre = nom
		Me._fecha = fcha
		Me._motivo = motv
		me._tipo = tpo
	End Sub
End Class
