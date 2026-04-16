using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PrintQueue : Colleague
    {
        private readonly Queue<Document> _queue = new Queue<Document>();

        public void EnqueueItem(Document document)
        {
            _queue.Enqueue(document);
            Mediator.Notify(this, "Enqueued", document);
        }

        public Document DequeueItem()
        {
            return _queue.Count > 0 ? _queue.Dequeue() : null;
        }

        public bool IsEmpty => _queue.Count == 0;
    }
}
