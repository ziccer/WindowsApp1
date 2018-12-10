Imports System
Imports DelegateTest.Methods.TextMethods

Module Program
    Public Delegate Sub GetDayMessage()
    Public Delegate Function GetNumberMessage(x As Integer)
    Sub Main(args As String())

        Dim del As New GetDayMessage(AddressOf ErrorMessage)
        Dim led As New GetNumberMessage(AddressOf Square)
        Try


            Console.WriteLine("Enter number week day from 1 to 7")

            Dim num As Integer = CInt(Console.ReadLine())
            If (num > 8 OrElse num < 1) Then
                Throw New CheckValue()
            Else
                Select Case num
                    Case 1

                        del = New GetDayMessage(AddressOf Monday)
                        del.Invoke()
                    Case 2
                        del = New GetDayMessage(AddressOf Tuesday)
                        del.Invoke()
                    Case 3
                        del = New GetDayMessage(AddressOf Wensday)
                        del.Invoke()
                    Case 4
                        del = New GetDayMessage(AddressOf Thersday)
                        del.Invoke()
                    Case 5
                        del = New GetDayMessage(AddressOf Friday)
                        del.Invoke()
                    Case 6
                        del = New GetDayMessage(AddressOf Saturday)
                        del.Invoke()
                    Case 7
                        del = New GetDayMessage(AddressOf Sunday)
                        del.Invoke()
                    Case Else

                        'del.Invoke()

                End Select
            End If

            'Console.WriteLine(del)
            Console.WriteLine((Function(x, y) x * y)(3.5, 4.5))
            Square(4)

            Console.ReadLine()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.ReadLine()
        End Try

    End Sub
    Public Sub ErrorMessage()
        Console.WriteLine("Week day not found")
        Console.ReadLine()
    End Sub

    Public Class CheckValue
        Inherits Exception
        Sub New()
            MyBase.New("¬ведите число от 0 до 7 включительно")

        End Sub

    End Class

    Public Function Square(x As Integer)
        Return x * x
    End Function
End Module
