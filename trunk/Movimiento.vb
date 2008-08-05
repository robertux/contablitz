
''' <summary>
''' Representa un registro de la tabla de movimientos
''' </summary>
Public Class Movimiento
	Private _codigo As String
	Private _cuenta As String
	Private _monto As Double
	Private _tipo As String
	Private _partida As String
	
	''' <summary>
	''' El codigo del movimiento
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
	''' El codigo de la cuenta donde se realizo el movimiento
	''' </summary>
	Public Property Cuenta As String
		Get
			return me._cuenta
		End Get
		Set
			me._cuenta = value
		End Set
	End Property
	
	''' <summary>
	''' El monto
	''' </summary>
	Public Property Monto As Double
		Get
			return me._monto
		End Get
		Set
			me._monto = value
		End Set
	End Property
	
	''' <summary>
	''' El tipo de movimiento (cargo o abono)
	''' </summary>
	Public Property Tipo As String
		Get
			return me._tipo
		End Get
		Set
			If (value = "cargo" Or value = "abono") Then
				me._tipo = value
			End If
		End Set
	End Property
	
	''' <summary>
	''' El codigo de la partida donde se realizo el movimiento
	''' </summary>
	Public Property Partida As String
		Get
			return me._partida
		End Get
		Set
			me._partida = value
		End Set
	End Property
	
	''' <summary>
	''' Crea una nueva instancia de la clase Movimiento
	''' </summary>
	''' <param name="cod">El codigo del movimiento</param>
	''' <param name="cta">El codigo de la cuenta asociada</param>
	''' <param name="mto">El monto del movimiento</param>
	''' <param name="tpo">El tipo de movimiento</param>
	''' <param name="ptda">El codigo de la partida</param>
	Public Sub New(ByVal cod As String, ByVal cta As String, ByVal mto As Double, ByVal tpo As String, ByVal ptda As String)
		Me._codigo = cod
		Me._cuenta = cta
		Me._monto = mto
		Me._tipo = tpo
		me._partida = ptda
	End Sub
End Class
