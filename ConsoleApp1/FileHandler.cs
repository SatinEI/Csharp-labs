using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FileHandler : EventHandlerBase
    {
        private readonly string _filePath;

        public FileHandler(IFormatStrategy strategy, string filePath) : base(strategy)
        {
            _filePath = filePath;
        }

        public override void SendMessage(string message)
        {
            System.IO.File.AppendAllText(_filePath, message + Environment.NewLine);
            Console.WriteLine($"[File Notification]: Message saved to {_filePath}");
        }
    }
}
