using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            User user = new User();
            user.GetInfo();

            Details details = new Details();
            details.GetInfo();
        }
    }
}