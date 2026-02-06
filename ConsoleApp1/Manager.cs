using ConsoleApp1;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Manager : Employee
    {
        private string? Department;
        private List<Employee> Team = new();

        public List<Employee> team
        { get { return Team; } set { team = value; } }

        public string? department
        { get { return Department; } set { Department = value; } }


        public override void PrintInfo()
        {
            Console.WriteLine($"Manager: {name}, {age} years old, Department: {department}");
        }

        public void AssignTaskToEmployee(Employee emp, string task)
        {
            Console.WriteLine($"Assigning task '{task}' to {emp.name}");
        }
    }
}
