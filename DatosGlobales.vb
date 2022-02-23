Module DatosGlobales

    Public Structure RegistroVendedor
        Dim Codigo As Integer
        Dim Nombre As String
        Dim sueldo As Decimal
    End Structure
    Public Vendedor(100) As RegistroVendedor
    Public IND As Integer = 0

    Public ArchiCliente As String = "Cliente.txt"
    Public ADCliente As Integer = 1

    Public RegVend As RegistroVendedor
    Public Sub CargarVectorDesdeArchivo()
        Dim codigo As Integer = 0
        Dim nombre As String = ""
        Dim sueldo As Decimal = 0


        FileOpen(1, ArchiCliente, OpenMode.Input)

        While Not EOF(1)
            Input(1, codigo)
            Input(1, nombre)
            Input(1, sueldo)

            Vendedor(IND).Codigo = codigo
            Vendedor(IND).Nombre = nombre
            Vendedor(IND).sueldo = sueldo

            IND = IND + 1
        End While

        FileClose(1)
    End Sub

    Public Function BuscarCliente(Cod As Integer) As Boolean
        Dim respuesta As Boolean = False
        FileOpen(1, ArchiCliente, OpenMode.Input)

        While Not EOF(1)
            Input(1, RegVend.Codigo)
            Input(1, RegVend.Nombre)
            Input(1, RegVend.sueldo)

            If RegVend.Codigo = Cod Then
                respuesta = True
            End If
        End While

        FileClose(1)
        Return respuesta
    End Function
End Module
