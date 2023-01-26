using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 5:
            int nTerms = 5;
            Console.Write($"The even number of {nTerms} terms are: ");
            Console.WriteLine(String.Join(' ', PrintEvenNumberNTerms(nTerms)));
        }

        public static string PrintEvenNumberNTerms(int n)
        {
            string empty = string.Empty;
            string space = " ";
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    empty += i + space;
                }
            }

            return empty;
        }
    }
}