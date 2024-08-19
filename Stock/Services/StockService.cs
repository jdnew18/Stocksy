using Microsoft.EntityFrameworkCore;
using Stocksy.Stock.Models;
using Stocksy.Stock.ViewModels;

namespace Stocksy.Stock.Services
{
    public class StockService : IStockService
    {
        public readonly StockDbContext _context;

        public StockService(StockDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StockVM>> GetAll()
        {
            return (await _context.Stock.ToListAsync())
                .Select(s => new StockVM
                    {
                        Id = s.Id,
                        TickerSymbol = s.TickerSymbol,
                        CompanyName = s.CompanyName
                    });
        }
    }
}