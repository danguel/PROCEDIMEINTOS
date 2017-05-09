Module Ejercicio33
    Sub main()
        Dim num As Integer
        Console.WriteLine("ingrese un numero: ")
        num = Console.ReadLine
        For x = 1 To 5 Step 1
            Console.WriteLine("La potencia elevelado de {0} a la {1} es de: {2} ", num, x + 1, potencia(num, x + 1))
        Next
        Console.ReadKey()
    End Sub
    Private Function potencia(numero As Integer, exponencial As Integer) As Integer
        Return numero ^ exponencial
    End Function
End Module
