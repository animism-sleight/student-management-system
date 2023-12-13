' Student.vb

Public Class Student
    Public Property StudentId As Integer
    Public Property Name As String

    Public Sub New(studentId As Integer, name As String)
        Me.StudentId = studentId
        Me.Name = name
    End Sub

    Public Sub DisplayInfo()
        Console.WriteLine($"Student ID: {StudentId}")
        Console.WriteLine($"Name: {Name}")
    End Sub
End Class
