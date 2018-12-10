Imports System
Imports ClassTest.Animal

Namespace AnimalsLover



    Module Program
        Sub Main(args As String())
            'Dim cat1 = New Cat() With {.Breed = "Сиамский", .Name = "Рыжик"}
            Dim cat1 As New Cat("Рыжик", "сиамский")
            Dim cat2 As New Cat("Пуфик", "дворовой")
            cat1.EatMilk("Я люблю молоко", cat1.Name)
            cat2.EatMilk("Я люблю молоко", cat2.Name)
            Dim speed1 As Double = cat1.speed(10)
            Dim speed2 As Double = cat1.speed(4)
            Dim duck1 As Duck = New Duck()
            cat1.Info(speed1)
            cat2.Info(speed2)
            Console.ReadLine()


        End Sub
    End Module
End Namespace
