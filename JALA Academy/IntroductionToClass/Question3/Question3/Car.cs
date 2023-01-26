using System;

namespace Question3
{
    public class Car
    {
        private string maker;

        private string model;

        private int year;

        public string Maker
        {
            get
            {
                return maker;
            }

            set
            {
                maker = value;
            }
        }
        
        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }
        


        public void PrintInfo()
        {
            Console.WriteLine($"The details of the car: __________\nMaker: {maker}\nModel: {model}\n" +
                              $"Year: {year}");
        }
    }
    
}