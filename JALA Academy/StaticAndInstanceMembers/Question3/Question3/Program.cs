using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticClass staticClass = new StaticClass();
            var sum = staticClass.X + staticClass.Y;
            Console.WriteLine(sum);
            
        }
    }
}