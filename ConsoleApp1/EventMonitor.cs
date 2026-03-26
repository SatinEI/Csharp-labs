using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate void MetricEventHandler(MetricEventArgs e);
namespace ConsoleApp1
{
    public class EventMonitor
    {

        // Событие (Event) — это ключевой элемент паттерна Observer в C#
        public event MetricEventHandler? OnMetricExceeded;
        public void CheckMetric(string metricName, double value, double threshold)
        {
            Console.WriteLine($"[Monitor]: Checking {metricName} ({value} vs {threshold})");
            if (value > threshold)
            {
                
                OnMetricExceeded?.Invoke(new MetricEventArgs(eventType: metricName +
                "_Exceeded", data: eventData));
            }
        }
    }
}
