using Microsoft.AspNetCore.Mvc;
using Stocksy.Stock.Services;

namespace Stock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockService _service;

        public StockController(IStockService service)
        {
            _service = service;
        }

        [HttpGet()]
        [HttpGet("get")]
        [HttpGet("ListStocks")]
        public async Task<IActionResult> ListStocks()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet("getStatic")]
        public IEnumerable<string> ListStocksStatic()
        {
            return new string[]
                { "AAA", "BBB", "CCC", "SPY" };
        }

        [HttpGet("json")]
        public IActionResult ListStocksAsJson()
        {
            return new JsonResult(new string[]
                { "DDD", "EEE", "FFF", "SPY" });
        }
    }
}