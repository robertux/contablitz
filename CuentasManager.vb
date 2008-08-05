Public Class CuentasManager
	
	''' <summary>
	''' Devuelve la cuenta padre o la cuenta superior inmediata de una cuenta
	''' </summary>
	''' <param name="codCuenta">El codigo de la cuenta original</param>
	''' <param name="ctas">El arreglo de cuentas en el cual buscar la cuenta padre</param>
	''' <returns>La cuenta padre encontrada</returns>
	Public Shared Function GetPadre(ByVal codCuenta As String, ByVal ctas As List(Of Cuenta)) As Cuenta		
		If(codCuenta.Contains(".")) Then
			Dim codPadre As String
			codPadre = codCuenta.Substring(0, codCuenta.LastIndexOf("."))
			return CuentasManager.BuscarCuenta(codPadre, ctas)
		Else
			return CuentasManager.BuscarCuenta(codCuenta, ctas)
		End If	
	End Function
	
	''' <summary>
	''' Busca una cuenta dentro de una lista de cuentas
	''' </summary>
	''' <param name="codCuenta">El codigo de la cuenta a buscar</param>
	''' <param name="ctas">La lista de cuentas en la cual buscar</param>
	''' <returns>La cuenta encontrada o Nada si no la encontro</returns>
	Public Shared Function BuscarCuenta(ByVal codCuenta As String, ByVal ctas As List(Of Cuenta)) As Cuenta
		For Each cta As Cuenta In ctas
			If(cta.Codigo = codCuenta) Then
				return cta
			End If
		Next
		return nothing
	End Function
	
	''' <summary>
	''' Devuelve una lista conteniendo las cuentas hijas o subcuentas de una cuenta
	''' </summary>
	''' <param name="codCuenta">El codigo de la cuenta padre</param>
	''' <param name="ctas">La lista de cuentas en las cuales buscar</param>
	''' <returns>Una lista con las cuentas encontradas</returns>
	Public Shared Function GetHijas(ByVal codCuenta As String, ByVal ctas As List(Of Cuenta)) As List(Of Cuenta)
		Dim nivelPadre As Integer = CuentasManager.GetNivel(codCuenta)
		Dim nivelHijas As Integer = nivelPadre + 1
		Dim ctasHijas As New List(Of Cuenta)()
		For Each cta As Cuenta In ctas
			If(CuentasManager.GetNivel(cta.Codigo) = nivelHijas AND cta.Codigo.StartsWith(codCuenta)) Then
				ctasHijas.Add(cta)
			End If
		Next
		return ctasHijas
	End Function
	
	''' <summary>
	''' Devuelve el nivel al que una cuenta pertenece
	''' </summary>
	''' <param name="codCuenta">El codigo de la cuenta a buscar</param>
	''' <returns>El nivel al que la cuenta pertenece</returns>
	Public Shared Function GetNivel(ByVal codCuenta As String) As Integer
		If(codCuenta.Contains(".")) Then
			Dim nPuntos As Integer = 1
			For Each caracter As Char In codCuenta
				If(caracter = ".") Then
					nPuntos += 1
				End If
			Next
			return nPuntos
		Else
			return 1
		End If
		
	End Function
	
	''' <summary>
	''' Genera el codigo para una nueva cuenta
	''' </summary>
	''' <param name="codCuentaPadre">El codigo de la cuenta superior o cuenta padre</param>
	''' <param name="ctas">La lista de cuentas donde buscar las cuentas hijas del padre</param>
	''' <returns>El nuevo codigo generado en base a sus cuentas hermanas</returns>
	Public Shared Function GenerarCodigoCuenta(ByVal codCuentaPadre As String, ByVal ctas As List(Of Cuenta)) As String
		Dim ctasHijas As List(Of Cuenta) = CuentasManager.GetHijas(codCuentaPadre, ctas)
		Dim nuevoCodigo As String = codCuentaPadre
		Dim maxCodigoHijas As Integer = 0
		
		For Each cta As Cuenta In ctasHijas
			Dim codigoHija As Integer = int32.Parse(cta.Codigo.Substring(cta.Codigo.LastIndexOf(".")+1))
			If(codigoHija > maxCodigoHijas) Then
				maxCodigoHijas = codigoHija
			End If
		Next
		nuevoCodigo = nuevoCodigo + "." + (maxCodigoHijas + 1).ToString()
		return nuevoCodigo
	End Function
	
End Class
