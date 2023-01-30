using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 7, c = 10;
            
            Console.WriteLine($"The sum of {a}, {b}, and {c} is {Sum(a, b, c)}");

        }
        
        public static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
    }
    
    
}