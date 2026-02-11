using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class ProgramExample
    {
        static void Main(string[] args)
        {
            var customer = new Customer
            {
                name = "John",
                age = 30
            };

            var employee = new Employee
            {
                name = "Alice",
                age = 25,
                salary = 50000,
                position = "Developer"
            };

            var manager = new Manager
            {
                name = "Bob",
                age = 40,
                salary = 80000,
                Department = "IT"
            };
            List<Person> people_list = [];
            List<IReportable> reportables = new List<IReportable> { employee, manager };
            List<IPayroll> payrolls = new List<IPayroll> { employee, manager };
            people_list.Add(customer);
            people_list.Add(employee);
            people_list.Add(manager);
            foreach (var person in people_list)
            {
                person.PrintInfo();
            }
            manager.AddTeamMember(employee);
            employee.IncreaseSalary(5000);
            foreach(var p in payrolls)
            {
                p.ProcessSalary();
            }
            foreach (var p in reportables)
            {
                p.GenerateReport();
            }
        }
    }
}