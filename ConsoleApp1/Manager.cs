using ConsoleApp1;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Manager : Employee, IReportable
    {
        private string? _department;
        private readonly List<Employee> _team = new();
        public IReadOnlyList<Employee> Team => _team.AsReadOnly();

        public string? Department
        { get { return _department; } set { _department = value; } }


        public override void PrintInfo()
        {
            Console.WriteLine($"Manager: {name}, {age} years old, Department: {_department}");
        }

        internal void AssignTaskToEmployee(Employee emp, string task)
        {
            Console.WriteLine($"Assigning task '{task}' to {emp.name}");
        }
        public void AddTeamMember(Employee employee)
        {
            _team.Add(employee);
        }
        public override void GenerateReport()
        {
            Console.WriteLine($"Manager Report:");
            Console.WriteLine($"  Name: {name}");
            Console.WriteLine($"  Department: {Department}");
            Console.WriteLine($"  Team Size: {Team.Count}"); 
        }
        public override void ProcessSalary()
        {
            Console.WriteLine($"Processing salary for manager {name}: {salary}");
            salary += 2000;
        }
        public override void CalculateBonus()
        {
            bonus = salary * 0.2m;
            if (age > 5)
            {
                bonus +=500;
            }
            if (sertification == true)
            {
                bonus += 200;
            }
        }
    }
}
