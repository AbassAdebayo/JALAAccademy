using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 5, b = 50, c = 7, d = 9;
            AddMethod method = new AddMethod();
            
            
            Console.WriteLine($"The sum of {a} + {b} {c} is {method.AddNumbers(a, b, c)}");
            Console.WriteLine($"The sum of {a} + {b} + {c} + {d} is {method.AddNumbers(a, b, c, d)}");
        }
    }
}