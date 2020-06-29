using System;

namespace MediatorPatternDemo
{
     class JTPoorMan : Colleague
    {
        public JTPoorMan(Mediator mediator) : base(mediator)
        {
            Console.WriteLine("JTPoorMan singned up for exchange ");
        }
    }
}
