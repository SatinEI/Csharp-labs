namespace ConsoleApp1
{
    internal class ProgramExample
    {
        /// ДАННЫЙ КОД НЕ ЗАПУСТИТСЯ, ЭТО ПРИМЕР ИСПОЛЬЗОВАНИЯ КЛАССОВ ИЗ БИБЛИОТЕКИ OOP_Fundamentals_Library
        /// СКОПИРУЙТЕ ЕГО В МЕТОД MAIN ОСНОВОГО ПРОЕКТА ДЛЯ ПРОВЕРКИ РАБОТЫ
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
                department = "IT"
            };

            manager.team.Add(employee);

            employee.salary = 55000;

            customer.PrintInfo();
            employee.PrintInfo();
            manager.PrintInfo();

            var payroll = new PayrollSystem();
            payroll.ProcessSalary(employee);
            payroll.ProcessSalary(manager);

            ReportService.GenerateEmployeeReport(employee);
            ReportService.GenerateManagerReport(manager);
        }
    }
}