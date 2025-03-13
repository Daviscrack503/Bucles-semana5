Public Class Ejemplosbucles
    Public Function buclefor(ByVal limite As Integer)
        For i = 1 To limite
            Console.WriteLine(i)
        Next

    End Function

    Public Function bucleforeach()
        Dim miArray As Integer() = {10, 20, 30, 40, 50}
        Dim elemento As Integer


        For Each elemento In miArray
            Debug.Print("Valor: " & elemento)

            Console.WriteLine(elemento)
        Next

    End Function

    Public Function bucleWileLoop()
        Dim x As Integer
        x = 1
        Do While x <= 5
            Debug.Print("Valor de x: " & x)
            x = x + 1
            Console.WriteLine(x)
        Loop


    End Function


    Public Function UnitlLoop()
        Dim y As Integer
        y = 1
        Do Until y > 5
            Debug.Print("Valor de y: " & y)
            y = y + 1

            Console.WriteLine(y)
        Loop


    End Function

    Public Function DoloopWhile()
        Dim z As Integer
        z = 1
        Do
            Debug.Print("Valor de z: " & z)
            z = z + 1


        Loop While z <= 5
        Console.WriteLine(z)
    End Function

    Public Function DoLoopUnitl()
        Dim w As Integer
        w = 1
        Do
            Debug.Print("Valor de w: " & w)
            w = w + 1

        Loop Until w > 5
        Console.WriteLine(w)
    End Function

End Class
