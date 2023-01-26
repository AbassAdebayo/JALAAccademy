using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            myObj1.Name = "Toyota Camry";
            myObj1.Color = "Red";
            myObj1.MaxSpeed = "155 mph";
            myObj1.PrintInfo();

            Car myObj2 = new Car();
            myObj2.Name = "Ferrari";
            myObj2.Color = "ash";
            myObj2.MaxSpeed = "250 mph";
            myObj2.PrintInfo();
            
            Car myObj3 = new Car();
            myObj3.Name = "Tesla";
            myObj3.Color = "White";
            myObj3.MaxSpeed = "350 mph";
            myObj3.PrintInfo();
        }
    }
}