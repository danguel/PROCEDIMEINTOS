Module Ejercicio36
    Sub main()
        Dim opcion As Boolean

        Do
            Dim numero As Single
            leerNumero(numero)
            Console.WriteLine("Desea ingresar otro numero: 0-no 1-si ")
            opcion = Console.ReadLine()
        Loop Until opcion = False

    End Sub

    Private Sub leerNumero(numero As Single)
        Dim num As Integer
        Do
            Console.WriteLine("ingrese un numero: ")
            num = Console.ReadLine
        Loop Until num > 0
        calculoNumero(num)
    End Sub

    Private Sub calculoNumero(numero As Single)
        Dim contenedor As Integer
        For i = 1 To numero Step 1
            contenedor = contenedor + (i ^ 2)
        Next
        Console.WriteLine("la suma de todos los numeros ^ 2 desde 1 hasta {0} es de: " & contenedor & vbCrLf, numero)
    End Sub


End Module
