using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DoneState : IDocumentState
    {
        public void Print(Document document)
        {
            Console.WriteLine($"[FSM: Done] Документ '{document.Title}' уже напечатан. Повторная печать невозможна.");
        }

        public void AddToQueue(Document document)
        {
            Console.WriteLine($"[FSM: Done] Документ '{document.Title}' уже напечатан, добавление в очередь невозможно.");
        }

        public void CompletePrinting(Document document)
        {
            Console.WriteLine($"[FSM: Done] Документ уже в финальном состоянии Done.");
        }

        public void FailPrinting(Document document)
        {
            Console.WriteLine($"[FSM: Done] Документ уже напечатан, ошибка невозможна.");
        }

        public void Reset(Document document)
        {
            Console.WriteLine($"[FSM: Done] Документ уже напечатан, сброс невозможен.");
        }
    }
}
