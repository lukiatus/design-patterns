using BankingApp.Decorator;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BankingApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockController : ControllerBase
    {
        private readonly CachedStockService _cachedStockService;
        private readonly StockService _stockService;

        public StockController(StockService stockService, CachedStockService cachedStockService)
        {
            _cachedStockService = cachedStockService;
            _stockService = stockService;
        }

        [SwaggerOperation(Summary = "Get stock data using CACHED service")]
        [HttpGet("cached")]
        public IActionResult GetStockDataUsingCachedService()
        {
            var stockData = _cachedStockService.GetStockData();
            return Ok(stockData);
        }

        [SwaggerOperation(Summary = "Get stock data using original service")]
        [HttpGet("original")]
        public IActionResult GetStockDataUsingOriginalService()
        {
            var stockData = _stockService.GetStockData();
            return Ok(stockData);
        }
    }
}