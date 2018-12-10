Imports System
Imports ConsoleTestCore.ModulesSpace.Module2
Imports ConsoleTestCore.Book
'Imports ConsoleTestCore.ModulesSpace





Module Program
    Sub Main(args As String())

        Dim num1 As Integer = AlgorithmTest.Factorial(5)

        Dim num2 As Integer = AlgorithmTest.Fibbonachi(5)

        AlgorithmTest.pi = 3.14159

        Console.WriteLine("����� ������ �������� ����� PI = {0}", AlgorithmTest.pi)



        Dim firstDay As days = ModulesSpace.days.sunday

        Dim b1 As Book = New Book("����� � ���", "�. �. �������", 1869)
        b1.GetInformation()

        '���������� ����������� �� ���������
        Dim b2 As Book = New Book()
        b2.GetInformation()

        Console.ReadLine()


        'Console.Write("������� ���� � �����: ")
        '������ � ���������� ������ ���� � �����
        'Dim path As String = Console.ReadLine()
        '�������� ����� �� �����, ��������� ������ Module2
        'Dim number As Integer = ModulesSpace.Module2.Read(path)
        'Console.WriteLine("��������� ����� {0} ����� {1}", number, Factorial(number))
        'Console.ReadLine()

        ' ��������� �������� ����� ������
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("������� ���� ������� (����� ��� �������):")
        Dim color As String = Console.ReadLine()
        If (color = "�����") Then
            Console.ForegroundColor = ConsoleColor.Blue
        ElseIf (color = "�������") Then
            Console.ForegroundColor = ConsoleColor.DarkGreen
        End If
        Console.WriteLine("������ ����: {0}", color)
        Console.ReadLine()




        Console.WriteLine("Hello World!")

        Dim x As Integer = 10
        Dim y As Integer = 20
        Console.WriteLine("X �� ���������� ������ = {0}", x)



        Dim p As Integer = Functon(x, y)
        Functon(y:=7, z:=4, x:=13)
        Console.WriteLine("X ����� ���������� ������ = {0}", x)
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
