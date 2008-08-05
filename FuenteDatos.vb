imports System.Data
Imports System.Data.OleDb
imports System.Collections.Generic

Public Class FuenteDatos
	
	Private _conexion As OleDbConnection
	Private _comando As OleDbCommand
	private _cadenaConexion as String
	
	''' <summary>
	''' Crea una nueva instancia de la clase Fuente de Datos
	''' </summary>
	Public Sub New()
		me._cadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\contablitz.mdb"
		Me._conexion = New OleDbConnection(me._cadenaConexion)
		Me._comando = New OleDbCommand("",Me._conexion)
	End Sub
	
	''' <summary>
	''' Abre una nueva conexion a la base de datos
	''' </summary>
	''' <returns></returns>
	Public Function Conectar() as Boolean
		If (me._conexion.State <> ConnectionState.Open) Then
			Me._conexion.Open()
			return true
		end if
		return false
	End Function
	
	''' <summary>
	''' Cierra la conexion actual con la base de datos
	''' </summary>
	''' <returns></returns>
	Public Function Desconectar() As Boolean
		If (Me._conexion.State <> ConnectionState.Closed) Then
			Me._conexion.Close()
			return true
		End If
		return false
	End Function
	
	''' <summary>
	''' Obtiene todas las cuentas existentes en la base de datos
	''' </summary>
	''' <returns>Una lista con las cuentas encontradas</returns>
	Public Function GetCuentas() as List(Of Cuenta)
		Dim cuentas As New List(Of Cuenta)()
		dim lectorCuentas as OleDbDataReader
		Me.Conectar()
		Me._comando = new OleDbCommand("SELECT * FROM cuentas ORDER BY codigo", me._conexion)
		lectorCuentas = Me._comando.ExecuteReader()
		Do While (lectorCuentas.Read())
			dim desc as String = ""
			If(not lectorCuentas.IsDBNull(2)) Then
				desc = lectorCuentas(2)
			End If
			cuentas.Add(New Cuenta(lectorCuentas(0), lectorCuentas(1), desc))			
		Loop
		me.Desconectar()
		return cuentas
	End Function
			
	''' <summary>
	''' Devuelve una cuenta de la base de datos
	''' </summary>
	''' <param name="codigo">El codigo de la cuenta a buscar</param>
	''' <returns>La cuenta encontrada o Nada si no la encontro</returns>
	Public Function GetCuenta(ByVal codigo As String) As Cuenta
		Dim cuenta As Cuenta
		Dim lectorCuenta As OleDbDataReader		
		Me.Conectar()
		dim miComando as New OleDbCommand("SELECT * FROM cuentas WHERE codigo = '" + codigo + "' ORDER BY codigo", me._conexion)
		lectorCuenta = miComando.ExecuteReader()
		If(lectorCuenta.HasRows) Then
			lectorCuenta.Read()
			dim desc as String = ""
			If(not lectorCuenta.IsDBNull(2)) Then
				desc = lectorCuenta(2)
			End If
			cuenta = New Cuenta(lectorCuenta(0), lectorCuenta(1), desc)
			me.Desconectar()
			return cuenta
		End If
		me.Desconectar()
		return nothing
	End Function
	
	''' <summary>
	''' Agrega una nueva cuenta a la base de datos
	''' </summary>
	''' <param name="codCuenta">El codigo de la nueva cuenta</param>
	''' <param name="nombre">El nombre de la cuenta</param>
	''' <param name="descripcion">La descrpcion de la cuenta</param>
	Public Sub AgregarCuenta(ByVal codCuenta As String, ByVal nombre As String, ByVal descripcion As String)
		Me.Conectar()
		Me._comando = new OleDbCommand("INSERT INTO cuentas VALUES('" + codCuenta + "','" + nombre + "','" + descripcion + "')", me._conexion)
		Me._comando.ExecuteNonQuery()
		me.Desconectar()
	End Sub
	
	''' <summary>
	''' Modifica una cuenta existente en la base de datos
	''' </summary>
	''' <param name="codCuenta">El codigo de la cuenta existente</param>
	''' <param name="nombre">El nombre de la cuenta</param>
	''' <param name="descripcion">La descripcion de la cuenta</param>
	Public Sub ModificarCuenta(ByVal codCuenta As String, ByVal nombre As String, ByVal descripcion As String)
		Me.Conectar()		
		Me._comando = new OleDbCommand("UPDATE cuentas SET nombre='" + nombre + "', descripcion='" + descripcion + "' WHERE codigo='" + codCuenta + "'", me._conexion)
		Me._comando.ExecuteNonQuery()
		me.Desconectar()
	End Sub
	
	''' <summary>
	''' Elimina una cuenta de la base de datos
	''' </summary>
	''' <param name="codCuenta">El codigo de la cuenta a eliminar</param>
	Public Sub EliminarCuenta(ByVal codCuenta As String)
		Me.Conectar()
		Me._comando = new OleDbCommand("DELETE FROM cuentas WHERE codigo Like '" + codCuenta + "%'", me._conexion)
		Me._comando.ExecuteNonQuery()
		me.Desconectar()
	End Sub
	
	''' <summary>
	''' Devuelve una partida de la base de datos
	''' </summary>
	''' <param name="codPartida">El codigo de la partida a buscar</param>
	''' <returns>La partida encontrada o nada si no la encontro</returns>
	Public Function GetPartida(ByVal codPartida As String) As Partida
		Dim lectorPartida As OleDbDataReader
		dim partidaEncontrada as Partida
		Me.Conectar()
		Me._comando = new OleDbCommand("SELECT * FROM partidas WHERE codigo= '" + codPartida + "' ORDER BY codigo", me._conexion)
		lectorPartida = Me._comando.ExecuteReader()
		If(lectorPartida.HasRows) Then
			lectorPartida.Read()
			partidaEncontrada = New Partida(lectorPartida(0), lectorPartida(1), lectorPartida(2), lectorPartida(3), lectorPartida(4))
			me.Desconectar()
			return partidaEncontrada
		End If
		me.Desconectar()
		return nothing
	End Function
	
	''' <summary>
	''' Devuelve todas las partidas existentes en la base de datos en base a un periodo
	''' </summary>
	''' <param name="anio">El anio en el cual buscar partidas</param>
	''' <returns>Una lista con todas las partidas encontradas</returns>
	Public Function GetPartidas(byval anio as String) as List(Of Partida)
		Dim lectorPartida As OleDbDataReader
		Dim listapartidas As New List(Of Partida)()
		Dim fechaIni As New DateTime(CInt(anio), 1, 1)
		dim fechaFin as New DateTime(CInt(anio), 12, 31)
		Me.Conectar()
		Me._comando = new OleDbCommand("SELECT * FROM partidas WHERE fecha BETWEEN @fini AND @ffin ORDER BY codigo", me._conexion)
		me._comando.Parameters.Clear()
		me._comando.Parameters.Add(New OleDbParameter("@fini", fechaIni))
		me._comando.Parameters.Add(new OleDbParameter("@ffin", fechaFin))
		lectorPartida = Me._comando.ExecuteReader()
		Do While(lectorPartida.Read())
			listapartidas.Add(new Partida(lectorPartida(0), lectorPartida(1), lectorPartida(2), lectorPartida(3), lectorPartida(4)))
		Loop
		lectorPartida.Close()
		Me.Desconectar()
		return listapartidas
	End Function
	
	''' <summary>
	''' Elimina una partida de la base de datos
	''' </summary>
	''' <param name="codPartida">El codigo de la partida a eliminar</param>
	Public sub EliminarPartida(ByVal codPartida As String)
		me.Conectar()
		Me._comando = new OleDbCommand("DELETE FROM partidas WHERE codigo = '" + codPartida + "'", me._conexion)
		me._comando.ExecuteNonQuery()
		me.Desconectar()
	End Sub		
	
	''' <summary>
	''' Agrega una nueva partida a la base de datos
	''' </summary>
	''' <param name="codigo">El codigo de la nueva partida</param>
	''' <param name="nombre">El nombre de la partida</param>
	''' <param name="fecha">La fecha de la partida</param>
	''' <param name="motivo">El motivo de la partida</param>
	''' <param name="tipo">El tipo de la partida</param>
	Public sub AgregarPartida(ByVal codigo As String, ByVal nombre As String, ByVal fecha As DateTime, ByVal motivo As String, ByVal tipo As String)
		me.Conectar()
		Me._comando = new OleDbCommand("INSERT INTO partidas VALUES('" + codigo + "',' " + nombre + "', '" + fecha.ToShortDateString() + "' , '" + motivo + "', '" + tipo + "')", me._conexion)
		dim foo as String = me._comando.CommandText
		Me._comando.ExecuteNonQuery()
		me.Desconectar()
	End Sub
	
	''' <summary>
	''' Genera el codigo de una nueva partida
	''' </summary>
	''' <returns>El nuevo codigo para una partida</returns>
	Public Function GenerarCodigoPartida() As String
		Me.Conectar()
		Me._comando = new OleDbCommand("SELECT max(codigo) FROM partidas", me._conexion)
		return (CInt(me._comando.ExecuteScalar()) + 1).ToString().PadLeft(7,"0")
		me.Desconectar()
	End Function
	
	''' <summary>
	''' Elimina un movimiento de la base de datos
	''' </summary>
	''' <param name="codMov">El codigo del movimiento a eliminar</param>
	Public Sub EliminarMovimiento(ByVal codMov As String)
		Me.Conectar()
		Me._comando = new OleDbCommand("DELETE FROM movimientos WHERE codigo = '" + codMov + "'", me._conexion)
		me._comando.ExecuteNonQuery()
		me.Desconectar()
	End Sub
	
	''' <summary>
	''' Agrega un nuevo movimiento a la base de datos
	''' </summary>
	''' <param name="codigo">El codigo del nuevo movimiento</param>
	''' <param name="cuenta">El codigo de la cuenta asociada</param>
	''' <param name="monto">El monto</param>
	''' <param name="tipo">El tipo de movimiento</param>
	''' <param name="partida">El codigo de la partida asociada</param>
	Public Sub AgregarMovimiento(ByVal codigo As String, ByVal cuenta As String, ByVal monto As Double, tipo As String, partida As String)
		Dim cmd As String
		cmd = string.Format("INSERT INTO movimientos VALUES('{0}', '{1}', {2}, '{3}', '{4}')",codigo, cuenta, monto.ToString(), tipo, partida)
		Me.Conectar()
		Me._comando = New OleDbCommand(cmd, Me._conexion)
		me._comando.ExecuteNonQuery()
		me.Desconectar()
	End Sub
	
	''' <summary>
	''' Edita el monto de un movimiento existente
	''' </summary>
	''' <param name="codMov">El codigo del movimiento existente</param>
	''' <param name="nuevoMonto">El nuevo monto del movimiento</param>
	Public Sub EditMontoMovimiento(ByVal codMov As String, ByVal nuevoMonto As Double)
		Me.Conectar()
		Me._comando = New OleDbCommand("UPDATE movimientos set monto = " + nuevoMonto.ToString() + " WHERE codigo = '" + codMov + "'", Me._conexion)
		me._comando.ExecuteNonQuery()
		me.Desconectar()
	End Sub
	
	''' <summary>
	''' Genera un nuevo codigo para un movimiento
	''' </summary>
	''' <returns>El nuevo codigo generado</returns>
	Public Function GenerarCodigoMovimiento() As String
		Me.Conectar()
		Me._comando = new OleDbCommand("SELECT max(codigo) FROM movimientos", me._conexion)
		return (CInt(me._comando.ExecuteScalar()) + 1).ToString().PadLeft(7,"0")
		me.Desconectar()
	End Function	
	
	''' <summary>
	''' Devuelve todos los movimientos encontrados en la base de datos
	''' </summary>
	''' <returns>Una lista con todos los movimientos encontrados</returns>
	Public Function GetMovimientos() As List(Of Movimiento)
		Dim lectorMovimientos As OleDbDataReader
		Dim movimientos As New List(Of Movimiento)
		Me.Conectar()
		Me._comando = new OleDbCommand("SELECT * FROM movimientos ORDER BY codigo", me._conexion)
		lectorMovimientos = Me._comando.ExecuteReader()
		Do While(lectorMovimientos.Read())
			movimientos.Add(new Movimiento(lectorMovimientos(0), lectorMovimientos(1), lectorMovimientos(2), lectorMovimientos(3), lectorMovimientos(4)))
		Loop
		Me.Desconectar()
		return movimientos
	End Function		
	
	''' <summary>
	''' Devuelve todos los movimientos pertenecientes a una partida
	''' </summary>
	''' <param name="codPartida">El codigo de la partida</param>
	''' <returns>Una lista de movimientos relacionados con la partida</returns>
	Public Function GetMovimientos(ByVal codPartida As String) As List(Of Movimiento)
		Dim lectorMovimientos As OleDbDataReader
		Dim movimientos As New List(Of Movimiento)
		Me.Conectar()
		Me._comando = new OleDbCommand("SELECT * FROM movimientos WHERE partida='" + codPartida + "' ORDER BY codigo", me._conexion)
		lectorMovimientos = Me._comando.ExecuteReader()
		Do While(lectorMovimientos.Read())
			movimientos.Add(new Movimiento(lectorMovimientos(0), lectorMovimientos(1), lectorMovimientos(2), lectorMovimientos(3), lectorMovimientos(4)))
		Loop
		lectorMovimientos.Close()
		Me.Desconectar()
		return movimientos
	End Function

	''' <summary>
	''' Devuelve todas las cuentas que poseen movimientos asociados
	''' </summary>
	''' <returns>Una lista con las cuentas encontradas</returns>
	Public Function GetCuentasConMovimientos() As List(Of Cuenta)		
		Dim lectorMovimientos As OleDbDataReader
		Dim codCuentas As New List(Of String)
		Dim cuentas as New List(Of Cuenta)
		Me.Conectar()
		Me._comando = new OleDbCommand("SELECT cuenta FROM movimientos GROUP BY cuenta", me._conexion)
		lectorMovimientos = Me._comando.ExecuteReader()
		Do While(lectorMovimientos.Read())
            codCuentas.Add(lectorMovimientos(0).ToString())
		Loop
		Me.Desconectar()
		For Each codCta As String In codCuentas
			cuentas.Add(me.GetCuenta(codCta))
		Next		
		return cuentas
    End Function

	''' <summary>
	''' Devuelve todas las cuentas que poseen movimientos asociados, en base a un anio y a un tipo de partida
	''' </summary>
	''' <param name="anio">El anio en el cual buscar</param>
	''' <param name="tipoPartida">El tipo de partida a buscar</param>
	''' <returns>Una lista con todas las cuentas encontradas</returns>
	Public Function GetCuentasConMovimientos(ByVal anio As String, byval tipoPartida as String) As List(Of Cuenta)				
		Dim codPartidas As New List(Of String)
		dim codCuentas as New List(Of String)
		Dim fechaIni As New DateTime(CInt(anio), 1, 1)
		dim fechaFin as New DateTime(CInt(anio), 12, 31)
		Dim cuentas as New List(Of Cuenta)
		Me.Conectar()
		Dim cmdPartidas As String = "SELECT codigo FROM partidas WHERE fecha BETWEEN @fini AND @ffin AND tipo = '" + tipoPartida + "'"
		me._comando.CommandText = cmdPartidas
		me._comando.Parameters.Clear()
		me._comando.Parameters.Add(New OleDbParameter("@fini", fechaIni))
		me._comando.Parameters.Add(new OleDbParameter("@ffin", fechaFin))
		Dim lectorPartidas As OleDbDataReader = me._comando.ExecuteReader()		
		
		Do While(lectorPartidas.Read())
			codPartidas.Add(lectorPartidas(0).ToString())
		Loop
		lectorPartidas.Close()
		for each codPartida as String in codPartidas
			dim commTxt as String = "SELECT cuenta FROM movimientos WHERE partida = '"+ codPartida + "'"
			dim otroComando as New OleDbCommand(commTxt, me._conexion)
			otroComando.CommandText = commTxt
			Dim lectorMovimientos As OleDbDataReader = otroComando.ExecuteReader()
			Do While(lectorMovimientos.Read())
				codCuentas.Add(lectorMovimientos(0).ToString())				
			Loop
			lectorMovimientos.Close()
		Next
		For Each codCta As String In codCuentas
			cuentas.Add(me.GetCuenta(codCta))
		Next
		Me.Desconectar()
		return cuentas
	End Function
	
	''' <summary>
	''' Devuelve el monto total de una cuenta
	''' </summary>
	''' <param name="codCuenta">El codigo de la cuenta</param>
	''' <param name="tipo">El tipo de movimiento (cargo, abono)</param>
	''' <param name="anio">El anio en el cual buscar</param>
	''' <param name="tipoPartida">El tipo de partida (normal, ajuste)</param>
	''' <returns>El monto total encontrado</returns>
	Public Function GetTotalFromCuenta(ByVal codCuenta As String, ByVal tipo As String, byval anio as String, byval tipoPartida as String) as Double
		Me.Conectar()
		Dim otroComando As New OleDbCommand("SELECT codigo FROM partidas WHERE fecha BETWEEN @fini AND @ffin AND tipo = '" + tipoPartida + "'",Me._conexion)
		Dim codPartidas As New List(Of String)
		Dim fechaIni As New DateTime(CInt(anio), 1, 1)
		Dim fechaFin As New DateTime(CInt(anio), 12, 31)		
		dim suma as Double = 0.0
		otroComando.Parameters.Clear()
		otroComando.Parameters.Add(New OleDbParameter("@fini", fechaIni))
		otroComando.Parameters.Add(New OleDbParameter("@ffin", fechaFin))
		Dim lectorPartidas As OleDbDataReader = otroComando.ExecuteReader()
		do While (lectorPartidas.Read())
			codPartidas.Add(lectorPartidas(0).ToString())
		loop
		lectorPartidas.Close()
		for each codPartida as String in codPartidas
			Me._comando = new OleDbCommand("Select sum(monto) FROM movimientos WHERE cuenta='" + codCuenta + "' AND tipo='" + tipo + "' AND partida = '" + codPartida + "'", me._conexion)
			if not (typeof(me._comando.ExecuteScalar()) is System.DBNull) then
				suma += Me._comando.ExecuteScalar()
			end if
		next
		Me.Desconectar()
		return suma
	End Function
	
	''' <summary>
	''' Devuelve el monto total de una cuenta
	''' </summary>
	''' <param name="codCuenta">El codigo de la cuenta</param>
	''' <param name="tipo">El tipo de movimiento (cargo, abono)</param>
	''' <param name="anio">El anio en el cual buscar</param>
	''' <param name="mes">El mes en el cual buscar</param>
	''' <returns>El monto total encontrado</returns>
	Public Function GetTotalFromCuenta(ByVal codCuenta As String, ByVal tipo As String, byval anio as Integer, byval mes as Integer) as Double
		Me.Conectar()
		Dim otroComando As New OleDbCommand("SELECT codigo FROM partidas WHERE fecha BETWEEN @fini AND @ffin",Me._conexion)
		Dim codPartidas As New List(Of String)
		Dim fechaIni As New DateTime(anio, mes, 1)
		Dim fechaFin As New DateTime(anio, mes, DateTime.DaysInMonth(anio, mes))		
		dim suma as Double = 0.0
		otroComando.Parameters.Clear()
		otroComando.Parameters.Add(New OleDbParameter("@fini", fechaIni))
		otroComando.Parameters.Add(New OleDbParameter("@ffin", fechaFin))
		Dim lectorPartidas As OleDbDataReader = otroComando.ExecuteReader()
		do While (lectorPartidas.Read())
			codPartidas.Add(lectorPartidas(0).ToString())
		loop
		lectorPartidas.Close()
		for each codPartida as String in codPartidas
			Me._comando = new OleDbCommand("Select sum(monto) FROM movimientos WHERE cuenta='" + codCuenta + "' AND tipo='" + tipo + "' AND partida = '" + codPartida + "'", me._conexion)
			if not (typeof(me._comando.ExecuteScalar()) is System.DBNull) then
				suma += Me._comando.ExecuteScalar()
			end if
		next
		Me.Desconectar()
		return suma
	End Function	
	
	''' <summary>
	''' Devuelve todos los anios en los que existen movimientos
	''' </summary>
	''' <returns>Una lista conteniendo todos los anios encontrados</returns>
	Public Function GetPeriodos() As List(Of string)
		Dim lectorPeriodos As OleDbDataReader
		dim periodos as New List(Of string)		
		Me.Conectar()
		Me._comando.CommandText = ""
				Me._comando = new OleDbCommand("SELECT fecha FROM partidas GROUP BY fecha", me._conexion)
		lectorPeriodos = Me._comando.ExecuteReader()
		Do While(lectorPeriodos.Read())
			dim anio as String = CDate(lectorPeriodos(0)).Year.ToString()
			If Not(periodos.Contains(anio)) Then
				periodos.Add(anio)
			End If			
		Loop
		Me.Desconectar()
		return periodos
	End Function
	
	''' <summary>
	''' Devuelve todas las subcuentas de una cuenta
	''' </summary>
	''' <param name="codCuenta">El codigo de la cuenta a buscar</param>
	''' <returns>Una lista con todas las cuentas encontradas</returns>
	Public Function GetTodasLasHijas(ByVal codCuenta As String) as List(Of Cuenta)
		Dim cuentas As New List(Of Cuenta)
		dim lectorCuentas as OleDbDataReader
		Me._comando = New OleDbCommand("Select * FROM cuentas WHERE codigo Like '" + codCuenta + "%'",me._conexion)
		Me.Conectar()
		lectorCuentas = Me._comando.ExecuteReader()
		Do While (lectorCuentas.Read())
			dim desc as String = ""
			If(not lectorCuentas.IsDBNull(2)) Then
				desc = lectorCuentas(2)
			End If
			cuentas.Add(New Cuenta(lectorCuentas(0), lectorCuentas(1), desc))			
		Loop
		me.Desconectar()
		return cuentas
	End Function
	
End Class
