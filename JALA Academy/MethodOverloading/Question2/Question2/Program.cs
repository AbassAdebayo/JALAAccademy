using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 5, x = 7, c = 9;
            string b = "dog";
            
            ParameterOrder order = new ParameterOrder();
            order.Order(a, x, c);
            order.Order(a, b, c);
        }
    }
}