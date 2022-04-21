using BankingApp.Adapter;
using BankingApp.Models;

namespace BankingApp.Decorator
{
    public class StockService : IStockService
    {
        private readonly INewStockCrawler _newStockCrawler;

        public StockService(INewStockCrawler newStockCrawler)
        {
            _newStockCrawler = newStockCrawler;
        }

        public StockData GetStockData()
        {
            Thread.Sleep(5000); // Simulates long running query
            return _newStockCrawler.GetAllStockData();
        }
    }
}