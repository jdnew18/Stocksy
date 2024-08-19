namespace Stocksy.Stock.ViewModels
{
    public class StockVM {
        public int Id { get; set; }

        public required string TickerSymbol  { get; set; }
        
        public required string CompanyName { get; set; }
    }
}