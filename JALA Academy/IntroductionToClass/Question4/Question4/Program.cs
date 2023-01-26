using System;


namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.Name = "Toyota Camry";
            myObj.Color = "Red";
            myObj.MaxSpeed = "155 mph";
            myObj.PrintInfo();
        }
    }
}