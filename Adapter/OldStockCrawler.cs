namespace BankingApp.Adapter
{
    public class OldStockCrawler : IOldStockCrawler
    {
        private readonly Random _rnd = new();

        public int GetTeslaStockData()
        {
            return _rnd.Next(100, 1000);
        }

        public int GetSpaceXStockData()
        {
            return _rnd.Next(100, 1000);
        }

        public int GetTwitterStockData()
        {
            return _rnd.Next(100, 1000);
        }
    }
}