using ConsoleApp1;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Manager : Employee
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
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));
            _team.Add(employee);
        }
    }
}
