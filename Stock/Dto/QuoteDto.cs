namespace Stocksy.Stock.Dto {
    public class QuoteDto {
        public int Id { get; set;}

        public int StockId { get; set;}

        public double Value { get; set;}

        public DateTime Date { get; set; }
    }
}