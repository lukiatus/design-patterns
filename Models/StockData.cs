namespace BankingApp.Models
{
    public class StockData
    {
        public int Tesla { get; }
        public int SpaceX { get; }
        public int Twitter { get; }

        public StockData(int tesla, int spaceX, int twitter)
        {
            Tesla = tesla;
            SpaceX = spaceX;
            Twitter = twitter;
        }
    }
}