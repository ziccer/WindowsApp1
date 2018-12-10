Imports System

Module Program
    Private counter As Int16

    Sub Main(args As String())
        Dim Person1 As Person = New Person With {.Age = 4, .Name = "Alex", .Pet = New Pets With {.Name = "Tor", .Age = 2, .Color = ColorPets.grey}}
        Dim Person2 As Person = New Person With {.Age = -5, .Name = "Slon", .Pet = New Pets With {.Name = "Terik", .Age = 1, .Color = ColorPets.black}}
        Dim Person3 As Person = New Person

        Dim dic As New Dictionary(Of Integer, String) From {{12, "awrqwe"}, {13, "waefg"}, {14, "asdfg234"}}
        dic.Add(5, "asd")
        dic.Add(2, "dfsd")
        dic.Add(3, "234r")
        dic.Add(6, "cnhg")
        dic.Add(1, "ggsdfd")
        Dim sorted As Dictionary(Of Integer, String) = From item In dic
                                                       Order By item.Key
                                                       Select item.Value


        For Each item In sorted
            Console.WriteLine("Key " + item.Key.ToString + " Value " + item.Value)
        Next
        Console.ReadLine()





        Dim enum1 As ColorPets = ColorPets.orange
        Console.Write(enum1)
        Console.Write(enum1.ToString)
        Dim en As String = New ColorPets
        en = ColorPets.green.ToString

        'Console.ReadLine()

        Dim res = Summ(z:=9, x:=1, y:=5)
        Dim res2 = Summ(4, 6, 7, 1)

        Dim z As Double = If(res = 0, 0, res2 / res)


        Dim dateString As String = "12.07.2003"
        Dim dateFormat As String = "dd.MM.yyyy"
        Dim dateValue As Date

        dateValue = DateTime.ParseExact(dateString, dateFormat, Globalization.CultureInfo.InvariantCulture)



        Console.ReadLine()
    End Sub
#Region "example region"
    Public Sub ExampleSub()
        Static exampleStaticLocalVariable As Integer = 0
        Console.Write(exampleStaticLocalVariable.ToString)
        exampleStaticLocalVariable += 2
        Console.ReadLine()
    End Sub

#End Region

    ''' <summary> 
    ''' This function returns a sum of your x and y
    ''' </summary> 
    ''' <param name="Name">Your Name</param> 
    ''' <returns></returns> 
    ''' <remarks></remarks>
    Public Function Summ(x As Double, y As Double, Optional z As Double = 0, Optional r As Double = 0)

        Summ = If(x < 10, x + y + z + r, 0)


    End Function

End Module
