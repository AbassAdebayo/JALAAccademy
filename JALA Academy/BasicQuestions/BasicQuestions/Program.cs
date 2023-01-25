using System;

namespace BasicQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            int empID;
            
            //Question 2
            string empName;
            
            //Question 3
            empID = 5;
            Console.WriteLine(empID);
            
            //Question 4
            empName = "Puja";
            Console.WriteLine(empID);
            
            //Question 5
            Console.Write("enter a number to check: ");
            int number = int.Parse(Console.ReadLine());

            if(number % 2 != 0)
            {
                Console.WriteLine("The number is an odd number");
            }
            else
            {
                Console.WriteLine("The number is an even number");
            }
            
            //Question 6
            Console.WriteLine("The first number to swap: ");
            int firstNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("The second number to swap: ");
            int secondNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine(secondNumber +","+ firstNumber);
        }
    }
}