using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticClass staticClass = new StaticClass();
            Console.WriteLine(staticClass.ChangeValue());
        }
    }
}