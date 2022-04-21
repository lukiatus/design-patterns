using BankingApp.Models;

namespace BankingApp.Adapter
{
    public class NewStockCrawler : INewStockCrawler
    {
        private readonly OldStockCrawler _oldStockCrawler = new();

        public StockData GetAllStockData()
        {
            var teslaData = _oldStockCrawler.GetTeslaStockData();
            var spaceXData = _oldStockCrawler.GetSpaceXStockData();
            var twitterData = _oldStockCrawler.GetTwitterStockData();

            return new StockData(teslaData, spaceXData, twitterData);
        }
    }
}