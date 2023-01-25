using System;
using System.Linq;

namespace ForAndForEachLoopQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1:
            Console.Write("Enter number of natural terms do you want: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string empty = "";
            int sum = 0;
            for (int i = number; i > 0; i--)
            {
                empty += i;
                sum += i;
            }
            Console.Write($"The first {number} natural number is: ");
            Console.WriteLine(String.Join(' ', empty.Reverse()));
            Console.WriteLine($"The Sum of Natural Number upto {number} terms: {sum}");
            
            //Question 2:
            Console.Write("Enter number of odd natural terms do you want: ");
            int nTerms = Convert.ToInt32(Console.ReadLine());

            string emptyBucket = string.Empty;
            string space = " ";
            int sumBucket = 0;
            for (int i = 0; i <= nTerms; i++)
            {
                if (i % 2 != 0 )
                {
                    emptyBucket += i + space;
                    sumBucket += i;
                }
                
            }
            
            Console.Write($"The odd natural number are: ");
            Console.WriteLine(String.Join(' ', emptyBucket));
            Console.WriteLine($"The Sum of the odd Natural Number upto {nTerms} terms: {sumBucket}");
            
            //Question 3:

            string[] arrayWords =
            {
                "J", "a", "l", "a", "T", "e", "c", "h", "n", "o", "l", "o", "g", "i" ,
                "e", "s"
            };

            string emptyArray = "";
            string store = "";
            for(int i = 0; i < arrayWords.Length; i++)
            {
                emptyArray += arrayWords[i];
            }
            Console.Write("Array printing using for loop: ");
            Console.WriteLine(string.Join(' ', emptyArray));

            foreach (var item in arrayWords)
            {
                store += item;
            }
            Console.Write("Array printing using forEach loop: ");
            Console.WriteLine(String.Join(' ', store));
        }
    }
}