Module Ejercicio31
    Sub Main()
        fecha_actual()
        Console.WriteLine("La fecha actual es : {0}", fechaActual)
        Console.ReadKey()
    End Sub
    Sub fecha_actual()
        Console.WriteLine("La fecha actual es : {0}", Date.Now)
    End Sub
    Private Function fechaActual() As Date
        Return Date.Now
    End Function
End Module
