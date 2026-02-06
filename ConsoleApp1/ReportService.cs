using ConsoleApp1;

namespace ConsoleApp1
{
    internal class ReportService
    {
        public static void GenerateEmployeeReport(Employee emp)
        {
            Console.WriteLine($"Employee Report:");
            Console.WriteLine($"  Name: {emp.name}");
            Console.WriteLine($"  Age: {emp.age}");
            Console.WriteLine($"  Salary: {emp.salary}"); // Прямой доступ к полю
        }

        public static void GenerateManagerReport(Manager mgr)
        {
            Console.WriteLine($"Manager Report:");
            Console.WriteLine($"  Name: {mgr.name}");
            Console.WriteLine($"  Department: {mgr.department}");
            Console.WriteLine($"  Team Size: {mgr.team.Count}"); // Прямой доступ к полю
        }
    }
}
