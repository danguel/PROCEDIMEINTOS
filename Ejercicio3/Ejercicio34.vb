Module Ejercicio34
    Sub main()

        Dim a As Integer
        Dim b As Integer
        a = leerLado("Ingrese a: ")
        b = leerLado("Ingrese b: ")
        Console.WriteLine("El cuadrado de la hipotenusa es {0}", hipotenusa(a, b))
        Console.ReadKey()
    End Sub

    Private Function leerLado(mensaje As String) As Short
        Dim valor As Short
        Do
            Console.WriteLine(mensaje)
            valor = Console.ReadLine
        Loop Until valido(valor)
        Return valor
    End Function

    Private Function valido(valor As Integer) As Boolean
        If valor > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function hipotenusa(A As Integer, B As Integer) As Integer
        Return Math.Sqrt((A ^ 2) + (B ^ 2))
    End Function
End Module
