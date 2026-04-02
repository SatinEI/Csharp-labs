using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NewState : IDocumentState
    {
        public void Print(Document document) => Console.WriteLine("[FSM: Error] Печать невозможна из - за ошибки.Сначала сбросьте документ(Reset).");

        public void AddToQueue(Document document) => Console.WriteLine("[FSM: Error] Нельзя добавить в очередь из-за ошибки.Сначала сбросьте документ.");

        public void CompletePrinting(Document document) => Console.WriteLine("[FSM: Error] Ошибка не устранена.");

        public void FailPrinting(Document document) => Console.WriteLine("[FSM:Error] Документ уже в состоянии ошибки.");

        public void Reset(Document document)
        {
            Console.WriteLine("[FSM:Error] Новый документ нельзя сбросить");
        }
    }
}
