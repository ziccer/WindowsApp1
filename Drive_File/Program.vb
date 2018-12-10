Imports System
Imports System.IO



Module Program
    Sub Main(args As String())
        'DiskInfo()
        'Directory()
        'Removefile()
        'MoveTo()
        'Files()
        'FileStream()
        'StreamReaderTest()
        'StreamWriterTest()
        BinaryTest()
    End Sub

    Public Sub DiskInfo()
        Dim drive, diskC As DriveInfo()
        drive = DriveInfo.GetDrives()

        For Each item As DriveInfo In drive
            Console.WriteLine("Название {0}", item.Name)
            Console.WriteLine("Тип {0}", item.DriveType)
            If item.IsReady Then
                Console.WriteLine("Объем диска: {0}", item.TotalSize)
                Console.WriteLine("Свободное пространство: {0}", item.TotalFreeSpace)
                Console.WriteLine("Метка: {0}", item.VolumeLabel)
            End If
        Next
        Console.ReadLine()
    End Sub

    Public Sub Directory()
        Dim crDir As String = "d:\TestDir"
        Dim diskD As String = "d:\r"
        Dim test As String = "d:\TEST"
        Dim dir As New DirectoryInfo(test)
        If dir.Exists Then
        Else
            dir.Create()
        End If
        Dim d As DirectoryInfo() = dir.GetDirectories()
        For Each item As DirectoryInfo In d
            Console.WriteLine(item)
            Console.WriteLine("Название каталога: {0}", item.Name)
            Console.WriteLine("Полное название каталога: {0}", item.FullName)
            Console.WriteLine("Время создания каталога: {0}", item.CreationTime)
            Console.WriteLine("Корневой каталог: {0}", item.Root)

        Next
        Dim f As FileInfo() = dir.GetFiles()
        For Each item1 As FileInfo In f
            Console.WriteLine(item1)
        Next

        Console.ReadLine()
    End Sub
    Sub Removefile()
        Dim dir As String = "D:\TEST\1"
        Dim remDir As New DirectoryInfo(dir)
        remDir.Delete()

        Console.ReadLine()

    End Sub
    Sub MoveTo()
        Dim dir As String = "D:\TEST\Mertd"
        Dim newDir As String = "D:\TEST\tRe\Mertd"
        Dim remDirO As New DirectoryInfo(dir)
        Dim nemDirO As New DirectoryInfo(newDir)
        If remDirO.Exists AndAlso nemDirO.Exists = False Then
            remDirO.MoveTo(newDir)
        End If


        Console.ReadLine()

    End Sub
    Sub Files()
        Dim filePath As String = "D:\Demorpmware.csv.zip"
        Dim file As New FileInfo(filePath)
        If file.Exists Then
            Console.WriteLine("Имя файла: {0}", file.Name)
            Console.WriteLine("Время создания: {0}", file.CreationTime)
            Console.WriteLine("Размер: {0}", file.Length)
            Console.WriteLine("Дата последнего доступа к файлу: {0}", file.LastAccessTime)
        End If

        Console.ReadLine()

    End Sub
    Sub FileStream()
        'Console.WriteLine("Введите строку для записи в файл:")
        'Dim text As String = Console.ReadLine()
        'Using filesStream As New FileStream("d:\TEST\3.txt", FileMode.OpenOrCreate)
        '    Dim array As Byte() = System.Text.Encoding.Default.GetBytes(text)
        '    filesStream.Write(array, 0, array.Length)
        '    Console.WriteLine("Текст записан в файл")


        'End Using

        Using fstream As FileStream = File.OpenRead("d:\TEST\3.txt")
            'преобразуем строку в байты
            Dim array As Byte() = New Byte(fstream.Length) {}
            'чтение данных
            fstream.Read(array, 0, array.Length)
            'декодируем байты в строку
            Dim textFromFile As String = System.Text.Encoding.Default.GetString(array)
            Console.WriteLine("Текст из файла: {0}", textFromFile)
        End Using


        Console.ReadLine()

    End Sub
    Sub StreamReaderTest()
        Dim filePath As String = "D:\TEST\SCE Export_Test_LINQ.csv"
        Using str As New StreamReader(filePath, System.Text.Encoding.UTF8)
            Dim doc As String = str.ReadLine()
            While doc IsNot Nothing
                Console.WriteLine(doc)
                doc = str.ReadLine()
            End While
            'Dim separator As Char = ","
            'Dim array As String() = doc.Split(separator:=",")



        End Using
        Console.ReadLine()
    End Sub

    Sub StreamWriterTest()
        Dim readPath As String = "D:\TEST\SCE Export_Test_LINQ.csv"
        Dim writePath As String = "D:\TEST\SCE ExpTest.csv"
        Dim text As String
        Try

            Using reader As New StreamReader(readPath)
                text = reader.ReadToEnd()
            End Using


            Using writer As New StreamWriter(writePath, False, System.Text.Encoding.UTF8)
                writer.WriteLine(text)
            End Using

            Using writer As New StreamWriter(writePath, True, System.Text.Encoding.UTF8)
                writer.WriteLine("Дозапись")
                writer.Write(4.5)
            End Using

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadLine()
    End Sub

    Sub BinaryTest()

        Dim states As State() = New State(2) {}
        states(0) = New State("Россия", "Москва", 3756588, 145.5)
        states(1) = New State("Украина", "Киев", 603700, 55.4)
        states(2) = New State("Белорусь", "Минск", 207599, 9.4)


        Dim path As String = "D:\TEST\states.txt"

        Try
            ' создаем объект BinaryWriter
            Using writer As New BinaryWriter(File.Open(path, FileMode.OpenOrCreate))
                'записываем в файл значение каждого поля структуры
                For Each s As State In states
                    writer.Write(s.name)
                    writer.Write(s.capital)
                    writer.Write(s.area)
                    writer.Write(s.population)
                Next

            End Using

            'создаем объект BinaryReader
            Using reader As New BinaryReader(File.Open(path, FileMode.Open))
                'пока не достигнут конец файла
                'считываем каждое значение из файла
                While reader.PeekChar() > -1
                    Dim name As String = reader.ReadString()
                    Dim capital As String = reader.ReadString()
                    Dim area As Integer = reader.ReadInt32()
                    Dim population As Double = reader.ReadDouble()

                    Console.WriteLine("Страна: {0}  столица: {1}  площадь {2} кв. км   численность населения: {3} млн. чел.",
                        name, capital, area, population)
                End While

            End Using

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadLine()
    End Sub

    Structure State

        Public name As String
        Public capital As String
        Public area As Integer
        Public population As Double

        Sub New(name As String, capital As String, area As Integer, population As Double)
            Me.name = name
            Me.capital = capital
            Me.area = area
            Me.population = population
        End Sub
    End Structure

End Module
