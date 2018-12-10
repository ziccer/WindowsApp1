Imports ClassTest



Public Class Cat
    Inherits Animal
    Implements IMammal


    Dim _name As String
    Public Property Name As String Implements IMammal.Name
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value

        End Set
    End Property
    Sub New(name As String, breed As String)
        MyBase.New(breed)
        _name = name
    End Sub
    Public Sub EatMilk(X As String, n As String) Implements IMammal.EatMilk
        Console.WriteLine(X + " потому что я " + Breed + " котенок :) " + n)

    End Sub
    Public Sub Info(x As Double)
        Console.WriteLine("Скорость кота " + x.ToString())
    End Sub
End Class
