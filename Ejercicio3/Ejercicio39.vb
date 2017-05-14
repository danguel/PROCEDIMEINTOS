Module Ejercicio39
    Sub manin()
        Dim base, altura, lado As Double
        Console.WriteLine("ingrese la base: ")
        base = Console.ReadLine()
        Console.WriteLine("ingrese la altura: ")
        altura = Console.ReadLine()
        Console.WriteLine("ingrese la lado: ")
        lado = Console.ReadLine()
        Console.WriteLine("la superficie del cuadro es de: " & calculo(lado))
        Console.WriteLine("la superficie del rectangulo es de: " & calculo(base, altura))
        Console.WriteLine("la superficie del trapecio es de: " & calculo(base, altura, lado))
    End Sub

    Private Function calculo(numero As Double) As Double
        Return numero * numero
    End Function

    Private Function calculo(numero As Double, numero2 As Double) As Double
        Return numero * numero2
    End Function

    Private Function calculo(numero As Double, numero2 As Double, numero3 As Double) As Double
        Return ((numero + numero) / 2) * numero2
    End Function

End Module
