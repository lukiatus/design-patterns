namespace BankingApp.Adapter
{
    public interface IOldStockCrawler
    {
        int GetSpaceXStockData();
        int GetTeslaStockData();
        int GetTwitterStockData();
    }
}