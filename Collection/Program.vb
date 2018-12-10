Imports System

Module Program
    Sub Main(args As String())
        Dim bool As Boolean = True

        Dim array As New ArrayList() From {1, 3, 56, 65, "oleg", 1.4, bool}
        Dim testar As New List(Of Integer) From {99, 53, 26, 6, 5}
        Dim star As New List(Of String) From {"fer", "53", "Getr- RR", "6", "nehr"}
        Dim linked As New LinkedList(Of Integer)()
        array.AddRange(testar)
        'array.AddRange(New List(Of String) From {"fer", "53", "Getr- RR", "6", "nehr"})
        'array.AddRange(New String() {"sf", "qweeqwe"})
        Dim o As Object = array.GetType()
        array.RemoveRange(2, 3)
        'array.Sort()
        array.Reverse()
        array.Remove(5)
        Dim num As Integer = star.BinarySearch("nehr")


        For Each item As Integer In array
            Console.WriteLine(item)


        Next

        Dim linkedPerson As New LinkedList(Of Person)()
        linkedPerson.AddFirst(New Person() With {.Age = 21, .Name = "Tom", .Sex = "Man"})
        linkedPerson.AddFirst(New Person() With {.Age = 31, .Name = "Scot", .Sex = "Man"})
        linkedPerson.AddFirst(New Person() With {.Age = 25, .Name = "Anny", .Sex = "Female"})
        For Each item2 As Person In linkedPerson
            Console.WriteLine(item2.Name)


        Next
        Dim people As New Queue(Of Person)()
        people.Enqueue(New Person() With {.Name = "Tom"})
        people.Enqueue(New Person() With {.Name = "Bill"})
        people.Enqueue(New Person() With {.Name = "John"})

        For Each p As Person In people
            Console.WriteLine(p.Name)

        Next

        Dim dictionary As New Dictionary(Of Integer, Person)()
        dictionary.Add(1, New Person() With {.Name = "Oleg", .Age = 35, .Sex = "male"})
        dictionary.Add(3, New Person() With {.Name = "Jho", .Age = 30, .Sex = "male"})
        dictionary.Add(4, New Person() With {.Name = "Annet", .Age = 51, .Sex = "female"})
        dictionary.Add(2, New Person() With {.Name = "Gleb", .Age = 13, .Sex = "male"})

        For Each p As KeyValuePair(Of Integer, Person) In dictionary
            Console.WriteLine("Key " + p.Key.ToString() + " Name " + p.Value.Name + " Age " + p.Value.Age.ToString() + " Sex " + p.Value.Sex)

        Next

        Console.ReadLine()
    End Sub
    Class Person
        Public Property Name() As String
        Public Property Age() As Integer
        Public Property Sex() As String
    End Class
End Module
