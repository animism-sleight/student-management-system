' SchoolSystem.vb

Module SchoolSystem
    Sub Main()
        ' Create students
        Dim student1 As New Student(1, "Alice")
        Dim student2 As New Student(2, "Bob")

        ' Create courses
        Dim course1 As New Course(101, "Introduction to Programming")
        Dim course2 As New Course(102, "Database Management")

        ' Create enrollments
        Dim enrollment1 As New Enrollment(1001, student1, course1)
        Dim enrollment2 As New Enrollment(1002, student2, course2)

        ' Display information
        Console.WriteLine("Enrollment Information:")
        enrollment1.DisplayInfo()
        Console.WriteLine()
        enrollment2.DisplayInfo()
    End Sub
End Module
