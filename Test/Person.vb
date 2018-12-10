Public Class Person
    Public Property Name() As String
    Public Property Age() As Integer
    Public Property Sex() As String
    Public ReadOnly Property Yearborn() As Integer
    Public Property Pet() As Pets

    Sub New(name As String, age As Integer, sex As String)
        name = name
        sex = sex
        If age > 0 AndAlso age < 100 Then
            age = age
        Else
            age = 0
            Console.WriteLine("Возраст не может быть отрицательным")


        End If
    End Sub
    Sub New(name As String, age As Integer, pet As Pets)
        name = name
        pet = pet
        If age > 0 AndAlso age < 100 Then
            age = age
        Else
            age = 0
            Console.WriteLine("Возраст не может быть отрицательным")


        End If
    End Sub
    Sub New(age As Integer, name As String, pet As Pets)
        name = name
        pet = pet
        If age > 0 AndAlso age < 100 Then
            age = age
        Else
            age = 0
            Console.WriteLine("Возраст не может быть отрицательным")


        End If
    End Sub
    Sub New()
        Name = "Ivan"
        Age = 100
        Sex = "Male"
        Yearborn = 2000
        Pet = New Pets With {.Age = 10, .Color = ColorPets.white, .Name = "Dog"}
    End Sub

    Sub Run()
        Console.WriteLine("I am running")
    End Sub

    Sub Learn()
        Console.WriteLine("I am learning")
    End Sub

End Class
