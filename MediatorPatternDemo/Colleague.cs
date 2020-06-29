
namespace MediatorPatternDemo
{
    abstract class Colleague
    {
        private int      _colleagueCode;
        private Mediator _mediator;
        
        public Colleague(Mediator mediator)
        {
            _mediator = mediator;
            _mediator.AddColleague(this);
        }

        public void SaleOffer(string stock, int shares)
        {
            _mediator.SaleOffer(stock, shares, _colleagueCode);
        }

        public void BuyOffer(string stock, int shares)
        {
            _mediator.BuyOffer(stock, shares, _colleagueCode);
        }

        public void SetCollCode(int collCode)
        {
            _colleagueCode = collCode;
        }
    }
}
