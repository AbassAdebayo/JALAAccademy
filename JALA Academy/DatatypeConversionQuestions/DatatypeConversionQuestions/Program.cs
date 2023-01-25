using System;

namespace DatatypeConversionQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1:
            int a = 50;
            long b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            
            //Question 2:
            double x = 34.89;
            int y = (int) x;
            Console.WriteLine("The value of 'y' is " + y);
            
            //Question 3:
            string c = "6736.87";
            float d = float.Parse(c);
            Console.WriteLine(d);

            int f = 567;
            double i = Convert.ToDouble(f);
            Console.WriteLine(i);

            //Question 4:
            int p = 5;
            string q = p.ToString();
            Console.WriteLine(q);

            float r = 45.009877f;
            string s = r.ToString();
            Console.WriteLine(s);
            bool t = true;
            string u = t.ToString();
            Console.WriteLine(u);
        }
    }
}