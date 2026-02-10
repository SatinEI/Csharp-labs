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
            List<Person> people_list = new();
            people_list.Add(customer);
            people_list.Add(employee);
            people_list.Add(manager);
            foreach (var person in people_list)
            {
                person.PrintInfo();
            }
            manager.AddTeamMember(employee);
            employee.IncreaseSalary(5000);
            employee.ProcessSalary();
            manager.ProcessSalary();

            employee.GenerateReport();
            manager.GenerateReport();
        }
    }
}