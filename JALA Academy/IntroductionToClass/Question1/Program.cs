using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Abass", "Adebayo", "09014698926",
                "greatmoh007@gmail.com", 28);
            
            Console.Write($"FirstName: {employee.FirstName}\nLastName: {employee.LastName}\n" +
                          $"PhoneNumber: {employee.PhoneNumber}\nEmail: {employee.Email}\nAge: {employee.Age}");
        }
    }
}