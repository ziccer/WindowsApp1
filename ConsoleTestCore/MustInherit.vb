Namespace Abstract
    Public MustInherit Class Person

        Public Property FirstName() As String
        Public Property LastName() As String
        'Абстрактный метод
        Public MustOverride Sub Display()

        Public Sub New(fName As String, lName As String)
            FirstName = fName
            LastName = lName
        End Sub

    End Class

    Public Class Employee
        Inherits Person

        Public Property Bank As String

        Public Overrides Sub Display()
            Console.WriteLine(FirstName & " " & LastName & " works in " & Bank)
        End Sub

        Public Sub New(fName As String, lName As String, _bank As String)
            MyBase.New(fName, lName)
            Bank = _bank
        End Sub

    End Class

    Public Class Client
        Inherits Person
        Implements IAccount
        Dim _sum As Integer

        Dim _procentage As Integer
        Public Property Bank As String

        Public ReadOnly Property CurentSum As Integer Implements IAccount.CurentSum
            Get
                Return _sum
            End Get
        End Property

        Public ReadOnly Property Procentage As Integer Implements IAccount.Procentage
            Get
                Return _procentage
            End Get
        End Property

        Public Overrides Sub Display()
            Console.WriteLine(FirstName & " " & LastName & " has an account in bank" & Bank)
        End Sub

        Public Sub New(fName As String, lName As String, _bank As String, _sum As Integer)
            MyBase.New(fName, lName)
            Bank = _bank
            Me._sum = _sum
        End Sub

        Public Sub Put(sum As Integer) Implements IAccount.Put
            _sum += sum
        End Sub

        Public Sub Withdraw(sum As Integer) Implements IAccount.Withdraw
            If sum <= CurentSum Then
                _sum -= sum
            End If
        End Sub
    End Class

End Namespace
