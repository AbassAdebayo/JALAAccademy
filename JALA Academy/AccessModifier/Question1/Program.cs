using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student student = new Student();
            student.StudentId = 100;
            student.StudentName = "Adewale";
            
           Console.WriteLine($"Details o f the student\n............\nStudentId: {student.StudentId}\nStudentName: {student.StudentName}");
            
        }
    }
}