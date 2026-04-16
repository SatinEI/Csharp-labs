using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Colleague
    {
        private IMediator _mediator;

        public IMediator Mediator => _mediator;

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
