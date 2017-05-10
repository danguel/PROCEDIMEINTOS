Module Ejercicio37
    Enum Operaciones
        suma = 1
        resta = 2
        multiplicaion = 3
        division = 4
    End Enum
    Sub main()
        Dim x, op, opm As Byte
        Dim num1, num2, num3, num4 As Double
        Do
            Console.WriteLine("ingrese una opcion para operar: 1-suma 2-resta 3-multiplicacion 4-division ")
            op = Console.ReadLine
            Console.WriteLine("ingrese de 2 a 4 numeros: ")
            num1 = Console.ReadLine
            num2 = Console.ReadLine
            num3 = Console.ReadLine
            num4 = Console.ReadLine
            opcion(op)
            opm = opcion(op)
            Console.WriteLine("El total de todo es de: " & operadores(opm, num1, num2, num3, num4))
            Console.WriteLine("desea salir del programa: 1-si 0-no")
            x = Console.ReadLine
        Loop Until x <> 0
        Console.WriteLine("resultado de la variable fuera de las opciones: " & suma(num1, num2, num3, num4))
        'Console.ReadKey()
    End Sub
    Private Function opcion(valor As Byte) As Byte
        If valor = Operaciones.suma Then
            Return 1
        ElseIf valor = Operaciones.resta Then
            Return 2
        ElseIf valor = Operaciones.multiplicaion Then
            Return 3
        ElseIf valor = Operaciones.division Then
            Return 4
        End If
        Return opcion
    End Function

    Private Function operadores(num0 As Byte, num1 As Integer, num2 As Integer) As Double
        If (num0 = 1) Then
            Return num1 + num2
        ElseIf (num0 = 2) Then
            Return num1 - num2
        ElseIf (num0 = 3) Then
            Return num1 * num2
        ElseIf (num0 = 4) Then
            Return num1 / num2
        End If
        Return operadores
    End Function

    Private Function operadores(num0 As Byte, num1 As Integer, num2 As Integer, num3 As Integer) As Double
        If (num0 = 1) Then
            Return num1 + num2 + num3
        ElseIf (num0 = 2) Then
            Return num1 - num2 - num3
        ElseIf (num0 = 3) Then
            Return num1 * num2 * num3
        ElseIf (num0 = 4) Then
            Return num1 / num2 / num3
        End If
        Return operadores
    End Function

    Private Function operadores(num0 As Byte, num1 As Integer, num2 As Integer, num3 As Integer, num4 As Integer) As Double
        If (num0 = 1) Then
            Return num1 + num2 + num3 + num4
        ElseIf (num0 = 2) Then
            Return num1 - num2 - num3 - num4
        ElseIf (num0 = 3) Then
            Return num1 * num2 * num3 * num4
        ElseIf (num0 = 4) Then
            Return num1 / num2 / num3 / num4
        End If
        Return operadores
    End Function


    Private Function suma(num1 As Integer, num2 As Integer) As Integer
        Return num1 + num2
    End Function
    Private Function suma(num1 As Integer, num2 As Integer, num3 As Integer) As Integer
        Return num1 + num2 + num3
    End Function
    Private Function suma(num1 As Integer, num2 As Integer, num3 As Integer, num4 As Integer) As Integer
        Return num1 + num2 + num3 + num4
    End Function

End Module
