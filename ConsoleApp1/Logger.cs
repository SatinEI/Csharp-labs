using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Logger : Colleague
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now:HH:mm:ss} - {message}");
        }
    }
}
