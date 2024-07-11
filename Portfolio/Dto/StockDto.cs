namespace Stocksy.Portflio.Dto {
    public class StockDto {
        public int Id { get; set; }

        public int PortfolioId { get; set; }

        public double Price { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}