
namespace MediatorPatternDemo
{
    class StockOffer
    {
        private int     _stockShare    = 0;
        private int     _colleagueCode = 0;
        private string _stockSymbol    = "";

        public StockOffer(int numOfShares, string stock, int collCode)
        {
            _stockShare    = numOfShares;
            _stockSymbol   = stock;
            _colleagueCode = collCode;
        }

        public int GetStockShares()
        {
            return _stockShare;
        }

        public string GetStockSymbol()
        {
            return _stockSymbol;
        }

        public int GetCollCode()
        {
            return _colleagueCode;
        }
    }
}
