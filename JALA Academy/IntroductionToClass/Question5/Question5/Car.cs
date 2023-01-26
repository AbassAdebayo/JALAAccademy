using System;

namespace Question5
{
    public class Car
    {
        private string name;
        
        private string color;

        private string maxSpeed;
        
        
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        
        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }
        
        public string MaxSpeed
        {
            get
            {
                return maxSpeed;
            }

            set
            {
                maxSpeed = value;
            }
        }
        


        public void PrintInfo()
        {
            Console.WriteLine($"The details of the Car:\n__________\nName: {name}\nColor: {color}\nModel: {maxSpeed}");
        }
    }
    
}