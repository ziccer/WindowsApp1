Public Class AlgorithmTest
    Public Shared pi As Double = 3.14

    Public Shared Function Factorial(x As Integer) As Integer
        If (x = 1) Then
            Return 1
        Else
            Return x * Factorial(x - 1)
        End If
    End Function

    Public Shared Function Fibbonachi(x As Integer) As Integer
        If x = 0 Then
            Return 1
        ElseIf x = 1 Then
            Return 1
        Else
            Return Fibbonachi(x - 1) + Fibbonachi(x - 2)
        End If
    End Function
End Class
