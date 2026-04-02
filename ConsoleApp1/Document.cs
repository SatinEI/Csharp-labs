using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Document
    {
        IDocumentState State;
        // Метод для смены состояния
        public void SetState(IDocumentState state) => State = state;

        // Делегирование поведения текущему состоянию
        public void Print() => State.Print(this);
        public void AddToQueue() => State.AddToQueue(this);
        public void CompletePrinting() => State.CompletePrinting(this);
        public void FailPrinting(IMediator mediator) => State.FailPrinting(this);
        public void Reset() => State.Reset(this);
    }
}
