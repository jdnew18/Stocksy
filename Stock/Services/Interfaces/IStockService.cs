using Stocksy.Stock.ViewModels;

namespace Stocksy.Stock.Services
{
    public interface IStockService
    {
        public Task<IEnumerable<StockVM>> GetAll();
    }
}