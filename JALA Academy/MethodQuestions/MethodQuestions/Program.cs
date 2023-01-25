using System;

namespace MethodQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1:
            int a = 5;
            int b = 6;

            Console.WriteLine($"The sum of {a} and {b} is: " + PrintSum(a, b));
            Console.WriteLine($"The multiplication of {a} and {b} is: " + PrintMult(a, b));

        }
        
        public static int PrintSum(int a, int b)
        {
            return a + b;
        }
        
        public static int PrintMult(int x, int y)
        {
           return x * y;
           
        }
    }
    
   
}