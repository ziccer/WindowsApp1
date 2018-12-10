Imports System.IO

Namespace ModulesSpace
    Module Module2

        Function Read(path As String) As Integer
            'Число, которое возвращаем из функции
            Dim number As Integer
            Try
                'Поток для считывания
                Dim sr As New StreamReader(path)
                'Считываем первый символ в файле
                number = Int32.Parse(sr.ReadLine())
                'Закрываем поток
                sr.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            'Возвращаем результат
            Return number
        End Function

        Enum days As Integer
            monday = 1
            tuesday
            wednesday
            thursday
            friday
            saturday
            sunday
        End Enum


    End Module
End Namespace

