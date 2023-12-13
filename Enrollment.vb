' Enrollment.vb

Public Class Enrollment
    Public Property EnrollmentId As Integer
    Public Property Student As Student
    Public Property Course As Course

    Public Sub New(enrollmentId As Integer, student As Student, course As Course)
        Me.EnrollmentId = enrollmentId
        Me.Student = student
        Me.Course = course
    End Sub

    Public Sub DisplayInfo()
        Console.WriteLine($"Enrollment ID: {EnrollmentId}")
        Student.DisplayInfo()
        Course.DisplayInfo()
    End Sub
End Class
