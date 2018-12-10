Public Class Book

    'Название книги
    Dim name As String
    'Автор
    Dim author As String
    'Год издания
    Dim year As Integer

    Sub New(name As String, author As String, year As Integer)
        Me.name = name
        Me.author = author
        Me.year = year
    End Sub
    'Конструктор по умолчанию
    Sub New()
        name = "Евгений Онегин"
        author = "А. С. Пушкин"
        year = 1833
    End Sub
    Sub GetInformation()
        Console.WriteLine("Книга '{0}' (автор {1}) была издана в {2} году", name, author, year)
    End Sub

End Class
