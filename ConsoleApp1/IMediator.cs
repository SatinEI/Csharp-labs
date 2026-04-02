using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IMediator
    {
        // Коллеги вызывают этот метод, чтобы передать событие посреднику
        void Notify(Colleague sender, string ev, Document document = null);
    }
}
