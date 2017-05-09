Module Ejercicio32
    Sub Main()
        Dim fecha As Date
        Dim dia As Integer

        Console.WriteLine("ingrese una fecha")
        fecha = Console.ReadLine
        Console.WriteLine("ingrese las cantidad de dias a sumar")
        dia = Console.ReadLine
        Console.WriteLine("La fecha es de: {0}", agregarDias(fecha, dia))
        Console.ReadKey()
    End Sub

    Private Function agregarDias(valor1 As Date, valor2 As Integer) As Date
        Return valor1.AddDays(valor2)
    End Function


End Module
