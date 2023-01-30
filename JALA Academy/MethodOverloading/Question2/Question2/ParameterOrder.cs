using System;

namespace Question2
{
    public class ParameterOrder
    {
        public void Order(int a, string b, int c)
        {
            Console.WriteLine($"The values of a, b and c are : {a}, {b} and {c} respectively...");
        }
        
        public void Order(int c, int b, int a)
        {
            Console.WriteLine($"The values of a, b and c are : {a}, {b} and {c} respectively...");
        }
    
    }
}