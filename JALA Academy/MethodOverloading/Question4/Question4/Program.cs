using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 3;
            
            Console.WriteLine($"The divisor of {a} and {b} is {Division(a, b)}");

        }
        
        public static double Division(int x, int y)
        {
            return (double)x / y;
        }
    }
}