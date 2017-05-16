Module Ejercicio37_arreglo_en_clase_
    Enum Operaciones
        suma = 1
        resta = 2
        multiplicacion = 3
        division = 4
    End Enum

    Sub main()
        Dim decision As Operaciones
        Console.WriteLine("Operacion a realizar(1-suma|2-resta|3-mult.|4-div.): ")
        decision = Console.ReadLine
        Console.WriteLine("El resultado es: " & calcular(decision, 1, 2))
        Console.WriteLine("El resultado es: " & calcular(decision, 1, 2, 3))
        Console.WriteLine("El resultado es: " & calcular(decision, 1, 2, 3, 4))
        Console.WriteLine("El resultado es: " & calcular(1, 2))
        Console.WriteLine("El resultado es: " & calcular(1, 2, 3))
        Console.WriteLine("El resultado es: " & calcular(1, 2, 3, 4))
        Console.ReadKey()

    End Sub

    Private Function calcular(decision As Operaciones, ByVal num1 As Single, ByVal num2 As Single) As Single
        Select Case decision
            Case Operaciones.suma
                Return num1 + num2
            Case Operaciones.resta
                Return num1 - num2
            Case Operaciones.multiplicacion
                Return num1 * num2
            Case Else
                Return num1 / num2
        End Select
    End Function
    Private Function calcular(decision As Operaciones, ByVal num1 As Single, ByVal num2 As Single, ByVal num3 As Single) As Single
        Return calcular(decision, calcular(decision, num1, num2), num3)
    End Function

    Private Function calcular(decision As Operaciones, ByVal num1 As Single, ByVal num2 As Single, ByVal num3 As Single, ByVal num4 As Single) As Single
        Return calcular(decision, calcular(decision, num1, num2, num3), num4)
    End Function
    Private Function calcular(ByVal num1 As Single, ByVal num2 As Single) As Single
        Return calcular(Operaciones.suma, num1, num2)
    End Function
    Private Function calcular(ByVal num1 As Single, ByVal num2 As Single, ByVal num3 As Single) As Single
        Return calcular(Operaciones.suma, num1, num2, num3)
    End Function
    Private Function calcular(ByVal num1 As Single, ByVal num2 As Single, ByVal num3 As Single, ByVal num4 As Single) As Single
        Return calcular(Operaciones.suma, num1, num2, num3, num4)
    End Function
End Module
