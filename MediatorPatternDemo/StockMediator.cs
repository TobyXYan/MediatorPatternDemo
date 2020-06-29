using System;
using System.Collections.Generic;

namespace MediatorPatternDemo
{
    class StockMediator : Mediator
    {
        private List<Colleague>  _colleagues;
        private List<StockOffer> _stockBuyOffers;
        private List<StockOffer> _stockSellOffers;
        private int _colleagueCodes = 0;

        public StockMediator()
        {
            _colleagues      = new List<Colleague>();
            _stockBuyOffers  = new List<StockOffer>();
            _stockSellOffers = new List<StockOffer>();
        }

        public void AddColleague(Colleague newColleague)
        {
            _colleagues.Add(newColleague);
            _colleagueCodes++;
            newColleague.SetCollCode(_colleagueCodes);
        }

        public void BuyOffer(string stock, int shares, int collCode)
        {
            var stockBought = false;
            foreach (var stockOffer in _stockSellOffers)
            {
                if (stockOffer.GetStockSymbol() == stock && stockOffer.GetStockShares() == shares)
                {
                    Console.WriteLine($"Shares of {stock} bought by colleague code {stockOffer.GetCollCode()}");
                    stockBought = true;
                    _stockSellOffers.Remove(stockOffer);
                    break;
                }
            }
            if (!stockBought)
            {
                Console.WriteLine($"{shares} shares of {stock} added to inventory");
                _stockBuyOffers.Add(new StockOffer(shares, stock, collCode));
            }
        }

        public void SaleOffer(string stock, int shares, int collCode)
        {
            var stockSold = false;
            foreach(var stockOffer in _stockBuyOffers)
            {
                if (stockOffer.GetStockSymbol() == stock && stockOffer.GetStockShares() == shares)
                {
                    Console.WriteLine($"Shares of {stock} sold to colleague code {stockOffer.GetCollCode()}");
                    stockSold = true;
                    _stockBuyOffers.Remove(stockOffer);
                    break;
                }
            }
            if (!stockSold)
            {
                Console.WriteLine($"{shares} shares of {stock} added to inventory");
                _stockSellOffers.Add(new StockOffer(shares, stock, collCode));
            }
        }

        public void GetStockOfferings()
        {
            Console.WriteLine("Stocks for Sale");
            foreach(var stockOffer in _stockSellOffers)
            {
                Console.WriteLine($"{stockOffer.GetStockShares()} of {stockOffer.GetStockSymbol()}");
            }
            Console.WriteLine("Stocks buy offers");
            foreach (var stockOffer in _stockBuyOffers)
            {
                Console.WriteLine($"{stockOffer.GetStockShares()} of {stockOffer.GetStockSymbol()}");
            }
        }

    }
}
