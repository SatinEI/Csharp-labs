using ConsoleApp1;

namespace ConsoleApp1
{
    public class PayrollSystem
    {
        public void ProcessSalary(object employee)
        {
            if (employee is Employee emp)
            {
                Console.WriteLine($"Processing salary for employee {emp.name}: {emp.salary}");
                emp.salary += 1000;
            }
            else if (employee is Manager mgr)
            {
                Console.WriteLine($"Processing salary for manager {mgr.name}: {mgr.salary}");
                mgr.salary += 2000;
            }
            else
            {
                throw new ArgumentException("Unknown employee type");
            }
        }

        public decimal CalculateBonus(string employeeType, decimal baseSalary, int years, bool hasCertification)
        {
            decimal bonus = 0;

            if (employeeType == "Employee")
            {
                bonus = baseSalary * 0.1m;
            }
            else if (employeeType == "Manager")
            {
                bonus = baseSalary * 0.2m;
            }

            if (years > 5)
            {
                bonus += 500;
            }

            if (hasCertification)
            {
                bonus += 300;
            }

            return bonus;
        }
    }
}
