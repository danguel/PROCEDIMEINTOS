Module Ejercicio35
    Sub main()
        Dim radio As Integer
        Dim altura As Integer
        Do
            Console.WriteLine("Ingrese el radio de la base ")
            radio = Console.ReadLine
        Loop Until valida(radio)
        Do
            Console.WriteLine("Ingrese la altura del cilindro")
            altura = Console.ReadLine
        Loop Until valida(altura)
        Console.WriteLine("El volumen del cilindro es :{0}", volumen(radio, altura))
        Console.ReadKey()
    End Sub
    Private Function valida(N As Integer) As Boolean
        If N > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function volumen(rad As Integer, alt As Integer) As Double
        Return (Math.PI * (rad ^ 2)) * alt
    End Function
End Module
