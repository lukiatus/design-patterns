using BankingApp.Models;
using Microsoft.Extensions.Caching.Memory;

namespace BankingApp.Decorator
{
    public class CachedStockService : IStockService
    {
        private readonly IStockService _decoratedService;
        private readonly IMemoryCache _memoryCache;

        public CachedStockService(IStockService decoratedService, IMemoryCache memoryCache)
        {
            _decoratedService = decoratedService;
            _memoryCache = memoryCache;
        }

        public StockData GetStockData()
        {
            var stockData = _memoryCache.GetOrCreate<StockData>("CacheKey", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(10);

                return _decoratedService.GetStockData();
            });

            return stockData;
        }
    }
}