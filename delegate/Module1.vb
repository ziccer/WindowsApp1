Module Module1
    Sub Main()
        'Создаем нового клиента
        Dim client1 As New Client("John", "Thompson", "City Bank", 200)
        'Добавляем в делегат ссылку на метод Show_Message

        client1.RegisterHandler(New Client.AccountStateHandler(AddressOf Show_Message))
        client1.RegisterHandler(New Client.AccountStateHandler(AddressOf Color_Message))
        'Два раза подряд пытаемся снять деньги
        client1.Withdraw(100)
        client1.Withdraw(150)
        'Удаляем делегат
        client1.UnregisterHandler(New Client.AccountStateHandler(AddressOf Color_Message))
        client1.Withdraw(50)

        Console.ReadLine()
    End Sub

    Private Sub Show_Message(message As String)
        Console.WriteLine(message)
    End Sub
    Private Sub Color_Message(message As String)
        'Установаливаем красный цвет символов
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(message)
        'Сбрасываем настрйоки цвета
        Console.ResetColor()
    End Sub
End Module
