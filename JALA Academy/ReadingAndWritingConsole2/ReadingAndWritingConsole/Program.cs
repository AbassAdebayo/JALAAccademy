using System;

namespace ReadingAndWritingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            string empName = "Abass";
            Console.WriteLine(empName);
                        
            //Question 2
            bool empID = false;
            Console.WriteLine(empID);
            
            //Question 3
            Console.Write("Enter your name: ");
            string myName = Console.ReadLine();
            Console.WriteLine(myName);
            
            //Question 4
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            
            Console.WriteLine("Hello " + firstName + " " + lastName);
            
            //Question 5
            Console.Write("Enter first number");
            int firstNumber = int.Parse(Console.ReadLine());
            
            Console.Write("Enter second number");
            int secondNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine(firstNumber + secondNumber);
            
            //Question 6
            Console.Write("Enter password");
            string password = Console.ReadLine();
            Console.WriteLine("Password: "+ password);
        }
    }
}