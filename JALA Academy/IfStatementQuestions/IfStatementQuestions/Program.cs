using System;

namespace IfStatementQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1:
            Console.Write("Enter number to be checked: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
              Console.WriteLine($"{number} is a positive number.");   
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is a negative number.");
            }
            else
            {
                Console.WriteLine($"{number} is neither a positive nor negative number.");
            }
            
            //Question 2:
            Console.Write("Enter a year you wish to check if it's leap year or not (e.g 1992): ");
            int leapYearCheck = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(leapYearCheck % 400 == 0 && leapYearCheck % 100 ==0 ? $"{leapYearCheck} is a leap year" : $"{leapYearCheck} " +
                $"is not a leap year");
            
            //Question 3:
            
            Console.Write("Enter a letter to check if it's vowel or consonant: ");
            string alphabetCheck = (Console.ReadLine());

           if(alphabetCheck.ToLower() == "a" || alphabetCheck.ToLower() == "e" || alphabetCheck.ToLower() == "i"
            || alphabetCheck.ToLower() == "u")
            {
                Console.WriteLine("the alphabet is a Vowel");
            }
           else if (alphabetCheck.ToLower() == "b" || alphabetCheck.ToLower() == "c" || alphabetCheck.ToLower() == "d"
           || alphabetCheck.ToLower() == "f" || alphabetCheck.ToLower() == "g" || alphabetCheck.ToLower() == "h" ||
           alphabetCheck.ToLower() == "j" || alphabetCheck.ToLower() == "k" || alphabetCheck.ToLower() == "l"
           || alphabetCheck.ToLower() == "m" || alphabetCheck.ToLower() == "n" || alphabetCheck.ToLower() == "p"
           || alphabetCheck.ToLower() == "q" || alphabetCheck.ToLower() == "r" || alphabetCheck.ToLower() == "s"
           || alphabetCheck.ToLower() == "t" || alphabetCheck.ToLower() == "v" || alphabetCheck.ToLower() == "w"
           || alphabetCheck.ToLower() == "x" || alphabetCheck.ToLower() == "y" || alphabetCheck.ToLower() == "z")
           {
               Console.WriteLine("the alphabet is a Consonant");
           }
            


        }
    }
}