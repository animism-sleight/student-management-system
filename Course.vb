' Course.vb

Public Class Course
    Public Property CourseId As Integer
    Public Property Title As String

    Public Sub New(courseId As Integer, title As String)
        Me.CourseId = courseId
        Me.Title = title
    End Sub

    Public Sub DisplayInfo()
        Console.WriteLine($"Course ID: {CourseId}")
        Console.WriteLine($"Title: {Title}")
    End Sub
End Class
