using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Document : Colleague
    {
        public string Title { get; private set; }
        private IDocumentState State { get; set; }

        public Document(string title)
        {
            Title = title;
            State = new NewState();
        }

        public void SetState(IDocumentState state) => State = state;

        public void Print() => State.Print(this);
        public void AddToQueue() => State.AddToQueue(this);
        public void CompletePrinting() => State.CompletePrinting(this);
        public void FailPrinting() => State.FailPrinting(this);
        public void Reset() => State.Reset(this);
    }
}
