using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassProgram _program = new ClassProgram();
            _program.ClassName = "Internal";
            
            Console.WriteLine("Class Name: "+ _program.ClassName);
        }

    }
    
}