using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company NSS = new Company("NSS", DateTime.Now);
            // Create three employees
            Employee Andy = new Employee();
            Andy.Firstname = "notAndy";
            Andy.lastname = "Colins";
            Andy.Title = "Web Dev";
            // Andy.StartDate = "";
            var date1 = new DateTime(2008, 3, 1);

            Console.WriteLine(date1.ToString("MM/dd/yyyy"));


            Employee Moe = new Employee();
            Moe.Firstname = "Moe";
            Moe.lastname = "Joe";

            Employee Brenda = new Employee();
            Brenda.Firstname = "Brenda";

            // Assign the employees to the company
            NSS.Employees.Add(Andy);
            NSS.Employees.Add(Moe);
            NSS.Employees.Add(Brenda);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            NSS.ListEmployee();
        }
    }
}

