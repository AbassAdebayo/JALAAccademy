using System;
using System.Linq;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayValue = {"Adebayo", "Ayandele", "Gbadebo"}; 
            
            Console.Write("The Array values are: ");
            PrintArray(arrayValue);
        }

        public static string[] PrintArray(string [] arrayItems)
        {
            string [] arrayBucket = {};
            string space = " ";
            foreach (var item in arrayItems)
            {
                
                Console.Write(string.Join(' ', item + space));
                
            }

            return arrayBucket.ToArray();
        } 
    }
}