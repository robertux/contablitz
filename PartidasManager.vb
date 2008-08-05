
Public Class PartidasManager
	
	''' <summary>
	''' Devuelve la partida asociada con un movimiento
	''' </summary>
	''' <param name="codMovimiento">El codigo del movimiento</param>
	''' <returns>La partida encontrada o Nada si no la encontro</returns>
	public shared function GetPartidaFromMovimiento(ByVal codMovimiento As String) As Partida
		Dim fdatos As New FuenteDatos()
		Dim movs As List(Of Movimiento) = fdatos.GetMovimientos()
		For Each mov As Movimiento In movs
			If(mov.Codigo = codMovimiento) Then
				return fdatos.GetPartida(mov.Partida)
			End If			
		Next
		return nothing
	End Function
	
	''' <summary>
	''' Devuelve las partidas asociadas con una cuenta
	''' </summary>
	''' <param name="codCuenta">El codigo de la cuenta</param>
	''' <returns>Una lista con las partidas encontradas</returns>
	Public shared Function GetPartidasFromCuenta(ByVal codCuenta As String) as List(Of Partida)
		Dim fdatos As New FuenteDatos()
		Dim movs As List(Of Movimiento) = fdatos.GetMovimientos()
		dim partidas as New List(Of Partida)
		For Each mov  As Movimiento In movs
			If(mov.Cuenta = codCuenta) Then
				partidas.Add(fdatos.GetPartida(mov.Partida))
			End If
		Next
		return partidas
	End Function
	
	''' <summary>
	''' Devuelve un movimiento asociado con una partida y una cuenta especifica
	''' </summary>
	''' <param name="codPartida">El codigo de la partida</param>
	''' <param name="codCuenta">El codigo de la cuenta</param>
	''' <returns>El movimiento encontrado o Nada si no lo encontro</returns>
	Public Shared Function GetMovimientoFromPartida(ByVal codPartida As String, ByVal codCuenta As String) As Movimiento
		Dim fdatos As New FuenteDatos()
		Dim movs As List(Of Movimiento) = fdatos.GetMovimientos(codPartida)
		For Each mov As Movimiento In movs
			If(mov.Cuenta = codCuenta) Then
				return mov
			End If
		Next
		return nothing
	End Function
	
	''' <summary>
	''' Indica si una cuenta posee movimientos o no
	''' </summary>
	''' <param name="codCuenta">El codigo de la cuenta</param>
	''' <returns>Verdadero si la cuenta tiene movimientos o falso en caso contrario</returns>
	Public Shared Function TieneMovimientos(ByVal codCuenta As String) As Boolean
		Dim fdatos As New FuenteDatos()
		Dim movs As List(Of Movimiento) = fdatos.GetMovimientos()
		For Each mov  As Movimiento In movs
			If(mov.Cuenta = codCuenta) Then
				return true
			End If
		Next
		return false
	End Function
	
End Class
