Imports System
Imports ConsoleTestCore.ModulesSpace.Module2
Imports ConsoleTestCore.Book
'Imports ConsoleTestCore.ModulesSpace





Module Program
    Sub Main(args As String())

        Dim num1 As Integer = AlgorithmTest.Factorial(5)

        Dim num2 As Integer = AlgorithmTest.Fibbonachi(5)

        AlgorithmTest.pi = 3.14159

        Console.WriteLine("Более точное значение числа PI = {0}", AlgorithmTest.pi)



        Dim firstDay As days = ModulesSpace.days.sunday

        Dim b1 As Book = New Book("Война и мир", "Л. Н. Толстой", 1869)
        b1.GetInformation()

        'Используем конструктор по умолчанию
        Dim b2 As Book = New Book()
        b2.GetInformation()

        Console.ReadLine()


        'Console.Write("Введите путь к файлу: ")
        'Вводим с клавиатуры полный путь к файлу
        'Dim path As String = Console.ReadLine()
        'Получаем число из файла, используя модуль Module2
        'Dim number As Integer = ModulesSpace.Module2.Read(path)
        'Console.WriteLine("Факториал числа {0} равен {1}", number, Factorial(number))
        'Console.ReadLine()

        ' установка красного цвета шрифта
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Введите цвет консоли (синий или зеленый):")
        Dim color As String = Console.ReadLine()
        If (color = "синий") Then
            Console.ForegroundColor = ConsoleColor.Blue
        ElseIf (color = "зеленый") Then
            Console.ForegroundColor = ConsoleColor.DarkGreen
        End If
        Console.WriteLine("Выбран цвет: {0}", color)
        Console.ReadLine()




        Console.WriteLine("Hello World!")

        Dim x As Integer = 10
        Dim y As Integer = 20
        Console.WriteLine("X до выполнения метода = {0}", x)



        Dim p As Integer = Functon(x, y)
        Functon(y:=7, z:=4, x:=13)
        Console.WriteLine("X после выполнения метода = {0}", x)
        Dim st As StringText = New StringText()

        Dim test As Integer = st.Test(4, 8)
        Dim resEnum = EnumTest(3, 6, days.sunday)
        Console.WriteLine("Test Enum = {0}", resEnum)
        Console.ReadLine()
    End Sub

    Function Functon(ByVal x As Integer, ByVal y As Integer, Optional s As Int32 = 0, Optional z As Integer = 5) As Integer
        x = (x + y) / z
        Console.WriteLine(x)
        Return x

    End Function
    Function Factorial(x As Integer) As Integer
        If (x = 1) Then
            Return 1
        Else
            Return x * Factorial(x - 1)
        End If
    End Function

    Function EnumTest(x As Integer, y As Integer, day As ModulesSpace.Module2.days) As Integer
        Dim count As Integer = x * y + day

        Return count
    End Function


End Module
