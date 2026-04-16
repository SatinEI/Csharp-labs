using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NewState : IDocumentState
    {
        public void Print(Document document)
        {
            document.Mediator.Notify(document, "RequestPrint", document);
        }

        public void AddToQueue(Document document)
        {
            document.Mediator.Notify(document, "AddToQueue", document);
        }

        public void CompletePrinting(Document document)
        {
            Console.WriteLine($"[FSM: New] Документ '{document.Title}' ещё не печатался.");
        }

        public void FailPrinting(Document document)
        {
            Console.WriteLine($"[FSM: New] Документ '{document.Title}' ещё не печатался, ошибка невозможна.");
        }

        public void Reset(Document document)
        {
            Console.WriteLine($"[FSM: New] Документ '{document.Title}' уже в состоянии New, сброс не требуется.");
        }
    }
}
