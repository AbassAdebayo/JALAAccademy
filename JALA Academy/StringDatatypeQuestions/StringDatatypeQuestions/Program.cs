using System;
using System.Collections.Generic;
using System.Linq;

namespace StringDatatypeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            string word = "ABASS";

            string empty = "";

            if (!string.IsNullOrEmpty(word) && word.Length > 0)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    empty += word[i];
                }

                Console.WriteLine("The reversed word is " + empty);
            }

            //Question 2:
            string thisWord = "alatechnologies";

            int length = 1;
            foreach (var item in thisWord)
            {
                length++;
            }

            Console.WriteLine($"The length of \"{thisWord}\" is {length}");

            //Question 3:
            string stringWord = "INDIA";
            Console.WriteLine($"The length of {stringWord} is {stringWord.Length}");

            //Question 4:
            string sentence = "Sun Rises in the West";
            var replace = sentence.Replace("West", "East");
            Console.Write(replace);

            //Question 5:
            string upperCaseLetter = "LETTER";
            var convert = upperCaseLetter.ToLower();
            Console.Write(convert);

            //Question 6
            String str = "abracadabra";
            int[] charCount = new int[256];
            for (int i = 0; i < str.Length; i++)
            {
                charCount[str[i]]++;
            }
            
            int maxCount = -1;
            char character = ' ';
            for (int i = 0; i < str.Length; i++)
            {
                if (maxCount < charCount[str[i]])
                {
                    maxCount = charCount[str[i]];
                    character = str[i];
                    
                }
            }
            Console.WriteLine("The string is: " + str);
            Console.WriteLine("The highest occurring character in the above string is: " + character);
            Console.WriteLine("Number of times this character occurs: " + maxCount);
            
            //Question 7:
            char ch;
            int a, b;       
            Console.Write("Enter the string : ");
            string str2 = Console.ReadLine();
           
            char [] arr1 = str2.ToCharArray(0, str2.Length);

            for (a = 1; a < str2.Length; a++)
            {
                for (b = 0; b < str2.Length - a; b++)
                {
                    if (arr1[b] > arr1[b + 1])
                    {
                        ch = arr1[b];
                        arr1[b] = arr1[b + 1];
                        arr1[b + 1] = ch;
                    }
                }
            }
            Console.Write("After sorting the string appears like : \n");
            foreach (char c in arr1)
            {
                ch = c;
                Console.Write("{0} ", ch);
            }
            Console.ReadLine();
        }
    }
}