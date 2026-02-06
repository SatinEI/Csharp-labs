using ConsoleApp1;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Employee : Customer
    {
        private decimal Salary;
        private string? Position;

        public decimal salary
        { get { return Salary; } set { Salary = value; } }

        public string? position
        { get { return Position; } set { Position = value; } }

        public override void PrintInfo()
        {
            Console.WriteLine($"Employee: {name}, {age} years old");
        }

        public void IncreaseSalary(decimal amount)
        {
            salary += amount;
        }

        public void ProcessPayroll()
        {
            Console.WriteLine($"Processing payroll for {name}: {salary}");
        }
    }
}