Public MustInherit Class Animal
    Public Property Breed() As String
    Sub New(breed As String)
        Me.Breed = breed
    End Sub
    Public Function speed(x As Double) As Double
        Return x * 1.5
    End Function

End Class