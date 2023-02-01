using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            EmployeeModel model = new EmployeeModel();
            model.EmpId = 1;
            model.EmpName = "Abass Adebayo";
            model.EmailId = "greatmoh007@gmail.com";
            model.Salary = 400000.6455448f;
            model.IsEmployeeActive = true;
            
            Console.WriteLine($"Employee's details\n..............\nId: {model.EmpId}\nName: {model.EmpName}\n" +
                              $"EmailId: {model.EmailId}\nSalary: {model.Salary}\nStatus: {model.IsEmployeeActive}");
        }
    }
}