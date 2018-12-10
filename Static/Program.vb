Imports System

Module Program
    Sub Main(args As String())
        Display()
        Display()
        Console.ReadLine()
    End Sub
    Private Sub Display()
        Static i As Integer = 6
        i += 1
        Console.WriteLine(i)
    End Sub


End Module
