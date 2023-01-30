using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyMethod method = new MyMethod();

            Console.WriteLine($"My name is {method.Check("Abass", "Adebayo")} and my age is {method.Check(28)}");
        }
    }
}