using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.StudentName = "Ayodeji";
            program.Id = 1;
            program.Age = 29;
            Console.WriteLine($"Details of the student\n............\nStudentId: {program.Id}\nStudentName: {program.StudentName}\nAge: {program.Age}");
        }
        
        protected string StudentName { get; set; }
        
        protected int Id { get; set; }
        protected int Age { get; set; }

        
    }
    
    
    
}