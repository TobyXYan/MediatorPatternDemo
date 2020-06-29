using System;

namespace MediatorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StockMediator nyse  = new StockMediator();
            GormanSlacks broker = new GormanSlacks(nyse);
            JTPoorMan   broker2 = new JTPoorMan(nyse);

            broker.SaleOffer("MSFT",100);
            broker.SaleOffer("GOOG", 50);
            broker2.BuyOffer("MSFT", 100);
            broker2.SaleOffer("NGR", 10);
            broker.BuyOffer("NGR",10);

            nyse.GetStockOfferings();
            Console.ReadLine();
        }
    }
}
