namespace Stocksy.Portflio.Dto {
    public class PortfolioDto {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int AccountId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}