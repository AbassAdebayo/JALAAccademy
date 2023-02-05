using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Program program = new Program();
            program.ClassName = "Program";
            
            Console.WriteLine("Class Name: " + program.ClassName);
        }
        
        private string ClassName { get; set; }
    }
    
    
}