Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine((Function(r As String)
                               Return r + " WTF"
                           End Function)("Message"))
        Dim x As Integer = (Function(z As Integer, r As Integer)
                                Return z * r
                            End Function)(3, 4)

        Console.WriteLine(x)

        Console.WriteLine(Add(x, 3))
        Console.ReadLine()

    End Sub
    Public Function Add(x As Integer, y As Integer) As Integer
        Dim res As Integer = (x * x) + (y * y)
        Return res
    End Function
End Module
