namespace MediatorPatternDemo
{
    internal interface Mediator
    {
        public void SaleOffer(string stock, int shares, int collCode);
        public void BuyOffer(string stock, int shares, int collCode);
        public void AddColleague(Colleague colleague);
    }
}