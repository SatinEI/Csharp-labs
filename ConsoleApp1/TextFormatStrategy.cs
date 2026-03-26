using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TextFormatStrategy : IFormatStrategy

    {
        public string Format(string message, DateTime timestamp) =>
        $"[{timestamp:yyyy-MM-dd HH:mm:ss}] {message}";
    }

    // JSON стратегия
    public class JsonFormatStrategy : IFormatStrategy
    {
        public string Format(string message, DateTime timestamp) =>

        $"{{\"timestamp\":\"{timestamp:O}\",\"message\":\"{message}\"}}";
    }
}
