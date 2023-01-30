using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = StaticClass.firstNumber + StaticClass.secondNumber;
            Console.WriteLine($"The sum of {StaticClass.firstNumber} and {StaticClass.secondNumber} = {sum}");
        }
    }
}