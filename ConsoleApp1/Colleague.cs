using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Colleague
    {
        protected IMediator Mediator;
        // Метод для инъекции посредника
        public void SetMediator(IMediator mediator)
        {
            Mediator = mediator;
        }
    }
}
