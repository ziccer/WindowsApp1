Imports System

Module Program
    Sub Main(args As String())

        Dim emp As New Employee()

        Console.WriteLine("Hello World!")
        Dim empl As New Employee("Ivan", "Tereev", "Fujitsu")
        'empl.FirstName = "Oleg"
        'empl.LastName = "Berezin"

        empl.DisplayFirstName()
        empl.Display()
        Console.ReadLine()


    End Sub

    Public Class Person
        Dim _firstName As String
        Dim _lastName As String
        Public Property FirstName() As String
            Get
                Return _firstName
            End Get
            Set(value As String)
                _firstName = value
            End Set
        End Property

        Public Property LastName() As String
            Get
                Return _lastName
            End Get
            Set(value As String)
                _lastName = value
            End Set
        End Property
        Public Sub New()

        End Sub
        Public Sub New(firstName As String, lastName As String)
            Me._firstName = firstName
            Me._lastName = lastName
        End Sub

        Public Property Year As Integer





        Public Sub Display()
            Console.WriteLine(FirstName & " " & LastName & " " & Year)
        End Sub
    End Class
    Public Class Employee
        Inherits Person
        Public Property Company As String

        Public Sub New(fName As String, lName As String, comp As String)
            MyBase.New(fName, lName)
            Company = comp
        End Sub


        Public Sub New()

        End Sub
        Public Shadows Sub Display()
            Console.WriteLine(FirstName & " " & LastName & " " & Company)
        End Sub
        Public Sub DisplayFirstName()
            Console.WriteLine(Year)
        End Sub

    End Class

End Module
