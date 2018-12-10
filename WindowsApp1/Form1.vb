Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Объявление переменной s, которой присваиваем весь текст в текстовом поле

        Dim s As String = TextBox1.Text

        If s = "" Or String.IsNullOrWhiteSpace(s) Then


            MessageBox.Show("Текст отсутствует")
        Else
            MessageBox.Show(s)
        End If
        TextBox1.Clear()
    End Sub








End Class
