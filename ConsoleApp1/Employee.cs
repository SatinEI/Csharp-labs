using ConsoleApp1;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Employee : Customer,IReportable,IPayroll
    {
        private decimal Salary;
        private string? Position;
        private decimal Bonus = 0;
        private bool Сertification = false;

        public decimal salary
        { get { return Salary; } set { Salary = value; } }

        public string? position
        { get { return Position; } set { Position = value; } }
        public decimal bonus
        { get { return Bonus; } set { Bonus = value; } }
        public bool сertification
        { get { return Сertification; } set { Сertification = value; } }

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
        void IReportable.GenerateReport()
        {
            Console.WriteLine($"Employee Report:");
            Console.WriteLine($"  Name: {name}");
            Console.WriteLine($"  Age: {age}");
            Console.WriteLine($"  Salary: {salary}");
        }
        void IPayroll.ProcessSalary()
        {
            Console.WriteLine($"Processing salary for employee {name}: {salary}");
            salary += 1000;
        }
        void IPayroll.CalculateBonus()
        {
            bonus = salary * 0.1m;
            if (age > 5)
            {
                bonus += 500;
            }
            if (сertification == true)
            {
                bonus += 200;
            }
        }
        public void GiveSertification()
        {
            сertification = true;
        }
    }
}