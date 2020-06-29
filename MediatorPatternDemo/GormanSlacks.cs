using System;

namespace MediatorPatternDemo
{
    class GormanSlacks:Colleague
    {
        public GormanSlacks(Mediator mediator):base(mediator)
        {
            Console.WriteLine("Gorman Slacks singned up for exchange ");
        }
    }
}
