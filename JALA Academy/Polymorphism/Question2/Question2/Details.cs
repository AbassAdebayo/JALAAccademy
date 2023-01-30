using System;

namespace Question2
{
    public class Details: User
    {
        public override void GetInfo()
        {
            Console.WriteLine("Derived class....");
        }
    }
}