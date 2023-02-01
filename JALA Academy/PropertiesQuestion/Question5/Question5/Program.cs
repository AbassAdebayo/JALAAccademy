using System;

namespace Question5
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
            
            EmployeeModel model2 = new EmployeeModel();
            model2.EmpId = 1;
            model2.EmpName = "Ayodeji Akorede";
            model2.EmailId = "dejikconcepts2020@gmail.com";
            model2.Salary = 500000.6455448f;
            model2.IsEmployeeActive = true;
            
            Console.WriteLine($"Employee's details\n..............\nId: {model2.EmpId}\nName: {model2.EmpName}\n" +
                              $"EmailId: {model2.EmailId}\nSalary: #{model2.Salary}\nStatus: {model2.IsEmployeeActive}");
        }
    }
}