using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ConsoleHandler : EventHandlerBase
    {
        public ConsoleHandler(IFormatStrategy strategy) : base(strategy) { }
        public override void SendMessage(string message)
        {
            Console.WriteLine($"[Console Notification]: {message}");
        }
    }
}
