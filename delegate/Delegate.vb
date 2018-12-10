Public MustInherit Class Person

    Public Property FirstName() As String
    Public Property LastName() As String
    Public MustOverride Sub Display()

    Public Sub New(fName As String, lName As String)
        FirstName = fName
        LastName = lName
    End Sub

End Class

Public Class Client
    Inherits Person
    Implements IAccount

    'Переменная для хранения суммы
    Dim _sum As Integer
    'Переменная для хранения процента
    Dim _procentage As Integer
    'Объявляем делегат
    Public Delegate Sub AccountStateHandler(message As String)
    'Событие, возникающее при выводе денег
    Public Event Withdrowed As AccountStateHandler
    'Событие возникающее при добавление на счет
    Public Event Added(sum As Integer)
    'Создаем переменную делегата
    Dim del As AccountStateHandler
    Public Sub RegisterHandler(_del As AccountStateHandler)
        Dim mainDel As AccountStateHandler = System.Delegate.Combine(_del, del)
        del = CType(mainDel, AccountStateHandler)
    End Sub
    Public Sub UnregisterHandler(_del As AccountStateHandler)
        Dim mainDel As AccountStateHandler = System.Delegate.Remove(del, _del)
        del = CType(mainDel, AccountStateHandler)
    End Sub
    Public Property Bank As String

    'Текущая сумма на счете
    ReadOnly Property CurentSum() As Integer Implements IAccount.CurentSum
        Get
            Return _sum
        End Get
    End Property
    'Метод для добавления денег на счет
    Sub Put(sum As Integer) Implements IAccount.Put
        _sum += sum
        RaiseEvent Added(sum)
    End Sub
    'Метод для снятия денег со счета

    Sub Withdraw(sum As Integer) Implements IAccount.Withdraw
        If sum <= CurentSum Then
            _sum -= sum
            RaiseEvent Withdrowed("Сумма " & sum & " снята со счета")
        Else
            RaiseEvent Withdrowed("Недостаточно денег на счете")
            '    If del IsNot Nothing Then
            '        del("Сумма " & sum & " снята со счета")
            '    End If
            'Else
            '    If del IsNot Nothing Then
            '        del("Недостаточно денег на счете")
            '    End If
        End If
    End Sub
    'Процент начислений
    ReadOnly Property Procentage() As Integer Implements IAccount.Procentage
        Get
            Return _procentage
        End Get
    End Property

    Public Overrides Sub Display()
        Console.WriteLine(FirstName & " " & LastName & " has an account in bank " & Bank)
    End Sub

    Public Sub New(fName As String, lName As String, _bank As String, _sum As Integer)
        MyBase.New(fName, lName)
        Bank = _bank
        Me._sum = _sum
    End Sub

End Class

Public Interface IAccount
    ReadOnly Property CurentSum() As Integer
    Sub Put(sum As Integer)
    Sub Withdraw(sum As Integer)
    ReadOnly Property Procentage() As Integer
End Interface
