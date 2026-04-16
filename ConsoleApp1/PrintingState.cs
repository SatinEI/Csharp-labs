using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PrintingState : IDocumentState
    {
        public void Print(Document document)
        {
            Console.WriteLine($"[FSM: Printing] Документ '{document.Title}' уже печатается.");
        }

        public void AddToQueue(Document document)
        {
            Console.WriteLine($"[FSM: Printing] Нельзя добавить в очередь документ, который уже печатается.");
        }

        public void CompletePrinting(Document document)
        {
            document.SetState(new DoneState());
            Console.WriteLine($"[FSM: Printing -> Done] Печать документа '{document.Title}' успешно завершена.");
        }

        public void FailPrinting(Document document)
        {
            document.SetState(new ErrorState());
            Console.WriteLine($"[FSM: Printing -> Error] Ошибка при печати документа '{document.Title}'.");
        }

        public void Reset(Document document)
        {
            Console.WriteLine($"[FSM: Printing] Нельзя сбросить документ во время печати.");
        }
    }
}
