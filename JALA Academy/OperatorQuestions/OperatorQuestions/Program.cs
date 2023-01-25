using System;

namespace OperatorQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1:
            Console.Write("Enter the value of a (number): ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of b (number): ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Press the operator you need; '+' for ADDITION, '-' for SUBTRACTION, '*' " +
                          "for MULTIPLICATION, '/' for DIVISION and '%' for MODULO: ");
            char operatorSelector = Convert.ToChar(Console.ReadLine());

            switch (operatorSelector)
            {
                case '+':
                {
                    Console.WriteLine($"Addition operator: {a + b}");
                    break;
                }
                case '-':
                {
                    Console.WriteLine($"Subtraction operator: {a - b}");
                    break;
                }
                case '*':
                {
                    Console.WriteLine($"Multiplication operator: {a * b}");
                    break;
                }
                case '/':
                {
                    Console.WriteLine($"Division operator: {a / b}");
                    break;
                }
                case '%':
                {
                    Console.WriteLine($"Modulo operator: {a % b}");
                    break;
                }
                default:
                    Console.WriteLine("Operator pressed is not included! Kindly check the options again...");
                    break;
            }

            //Question 2:
            Console.Write("Enter the value of x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"For 'x++', the value of 'x' is {x} xnd result is {x++}");
            Console.WriteLine($"For 'x--', the value of 'x' is {x} and result is {x--}");
            Console.WriteLine($"For '++x', the value of 'x' is {x} and result is {++x}");
            Console.WriteLine($"For '--x', the value of 'x' is {x} and result is {--x}");

            //Question 3:

            Console.Write("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Press the operator you need; '==' for 'Equal to Operator', '>' for 'Greater than Operator', '<' " +
                          "for 'Less than Operator', '>=' for 'Greater than or Equal to Operator', '<=' for 'Less than or Equal to Operator' and " +
                          "'!=' for 'Not equal to Operator': ");
            string operatorOption = Console.ReadLine();

            switch (operatorOption)
            {
                case "==":
                {
                    Console.WriteLine($"Equal to Operator: {firstNumber == secondNumber}");
                    break;
                }
                case ">":
                {
                    Console.WriteLine($"Greater than operator: {firstNumber > secondNumber}");
                    break;
                }
                case "<":
                {
                    Console.WriteLine($"Less than operator: {firstNumber < secondNumber}");
                    break;
                }
                case ">=":
                {
                    Console.WriteLine($"Greater than or Equal to operator: {firstNumber >= secondNumber}");
                    break;
                }
                case "<=":
                {
                    Console.WriteLine($"Less than or Equal to operator: {firstNumber <= secondNumber}");
                    break;
                }
                case "!=":
                {
                    Console.WriteLine($"Not Equal to operator: {firstNumber != secondNumber}");
                    break;
                }
                default:
                    Console.WriteLine("Operator pressed is not included! Kindly check the options again...");
                    break;
            }
        }
    }
}