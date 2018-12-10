Public Class Pets
    Public Property Name() As String
    Public Property Age() As Integer
    Public Property Color() As ColorPets
    Sub foolingAround()
        Console.WriteLine("Я дурачусь")
    End Sub
    Sub New(Age As Integer, Color As ColorPets, Name As String)
        Me.Name = Name
        Me.Age = Age
        Me.Color = Color

    End Sub
    Sub New()

    End Sub



End Class
