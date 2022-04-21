using BankingApp.Models;

namespace BankingApp.Adapter
{
    public interface INewStockCrawler
    {
        public StockData GetAllStockData();
    }
}