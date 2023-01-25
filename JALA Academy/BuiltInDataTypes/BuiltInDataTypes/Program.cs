using System;

namespace BuiltInDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            int x = 5;
            Console.WriteLine(x);
            
            //Question 2
            bool checkIn = true;
            Console.WriteLine(checkIn);
            
            //Question 3
             float a = 0.1234f;
             decimal output = Convert.ToDecimal(a);
             Console.WriteLine(output);
             
             //Question 4
             Console.Write("Enter first number: ");
             int firstNumber = int.Parse((Console.ReadLine()));
             
             Console.Write("enter second number: ");
             int secondNumber = int.Parse((Console.ReadLine()));

             Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
             Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
             Console.WriteLine($"{firstNumber} ^ {secondNumber} = {firstNumber ^ secondNumber}");
             Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
             Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
             
             //Question 5
             Console.Write("Enter first letter: ");
             string firstLetter = Console.ReadLine();
             
             Console.Write("Enter second letter: ");
             string secondLetter = Console.ReadLine();
             
             Console.Write("Enter third letter: ");
             string thirdLetter = Console.ReadLine();
             
             Console.WriteLine(thirdLetter + "" + secondLetter +"" + firstLetter);
             
             //Question 6
             Console.Write("Input a value: ");
             char checkSymbol = char.Parse(Console.ReadLine());

             if (checkSymbol == 'a' || checkSymbol == 'e' || checkSymbol == 'o' || checkSymbol == 'i' || checkSymbol == 'u')
             {
                 Console.WriteLine("It's a lowercase vowel");
             }
             else if (checkSymbol >= '0' && checkSymbol <= '9')
             {
                 Console.WriteLine("It's a digit.");
             }
             else
             {
                 Console.Write("It's another symbol."); 
             }
                    

        }
    }
}