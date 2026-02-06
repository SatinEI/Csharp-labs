using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Customer : Person
    {
        public override void PrintInfo()
        {
            Console.WriteLine($"Customer: {name}, {age} years old");
        }
    }
}
