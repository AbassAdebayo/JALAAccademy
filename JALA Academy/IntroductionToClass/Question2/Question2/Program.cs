using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Nasiroh", "Adeleke", "adelekenasiroh1994@gmail.com",
                "08010567899", "Omi-Adio");
            
            Person person2 = new Person("Nasiroh", "Adeleke", "adelekenasiroh1994@gmail.com",
                "08010567899", "Omi-Adio", 29, "Female");
            
            Console.WriteLine($"FirstName: {person1.FirstName}\nLastName: {person1.LastName}\nEmail: {person1.Email}\n" +
                              $"PhoneNumber: {person1.PhoneNumber}\nAddress: {person1.Address}\n________________________");
            
            
            Console.WriteLine($"FirstName: {person2.FirstName}\nLastName: {person2.LastName}\nEmail: {person2.Email}\n" +
                              $"PhoneNumber: {person2.PhoneNumber}\nAddress: {person2.Address}\nAge: {person2.Age}\n" +
                              $"Gender: {person2.Gender}");
        }
    }
}