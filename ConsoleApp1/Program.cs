using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var monitor = new EventMonitor();

            var textStrategy = new TextFormatStrategy();
            var jsonStrategy = new JsonFormatStrategy();

            var consoleHandler = new ConsoleHandler(textStrategy);
            var fileHandler = new FileHandler(jsonStrategy, "metrics_log.json");

            monitor.OnMetricExceeded += (e) => consoleHandler.ProcessEvent(e);
            monitor.OnMetricExceeded += (e) => fileHandler.ProcessEvent(e);
            monitor.CheckMetric("CPU_Temperature", 85.5, 80.0);
            Console.WriteLine("\nChanging Strategy");
            consoleHandler.SetStrategy(jsonStrategy);
            monitor.CheckMetric("RAM_Usage", 92.0, 90.0);
            monitor.CheckMetric("Disk_Space", 45.0, 95.0);
            Console.ReadKey();
        }
    }
}
