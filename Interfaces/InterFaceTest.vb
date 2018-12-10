Imports Interfaces


Module InterFaceTest


    Sub Main(args As String())




        Console.ReadKey()

    End Sub

    Class Entity
        Implements Interfaces.IAnimal
        Implements IHuman
        Dim nameEntity As String
        Dim born As Short
        Dim ageHuman As Short
        Dim nameHuman As Short
        Public Property Name As String Implements IAnimal.Name
            Get
                Return nameEntity
            End Get
            Set(value As String)
                nameEntity = value
            End Set
        End Property

        Public ReadOnly Property BornYear As Short Implements IAnimal.BornYear
            Get
                Return born
            End Get
        End Property

        Public Property Age As Object Implements IHuman.Age
            Get
                Return ageHuman
            End Get
            Set(value As Object)
                ageHuman = value

            End Set
        End Property

        Private Property IHuman_Name As Object Implements IHuman.Name
            Get
                Return nameHuman
            End Get
            Set(value As Object)
                nameHuman = value
            End Set
        End Property

        Public Sub AnimalEat() Implements IAnimal.Eat
            Console.WriteLine("I am eating")
        End Sub
        Public Sub HumanEat() Implements IHuman.Eat
            Console.WriteLine("I am eating")
        End Sub

        Public Sub Hunting() Implements IAnimal.Hunting
            Console.WriteLine("I am hunting")
        End Sub

        Public Sub Sleep() Implements IHuman.Sleep
            Console.WriteLine("Human sleeping")
        End Sub
    End Class


End Module
