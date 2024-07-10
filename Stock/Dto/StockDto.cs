namespace Stocksy.Stock.Dto
{
    public class StockDto {
        public int Id { get; set; }

        public required string TickerSymbol  { get; set; }
        
        public required string CompanyName { get; set; }
    }
}