Module Module1
    Dim cantidad As Integer
    Dim pesos As Double
    Sub Main()
        cantidad = 0
        pesos = 0
        Console.WriteLine("Introduce cantidad en dolares:")
        cantidad = Console.ReadLine()
        pesos = (cantidad * 20.21) / 1
        Console.WriteLine("La cantidad en pesos es:")
        Console.WriteLine(pesos)
        Console.ReadLine()
    End Sub

End Module
