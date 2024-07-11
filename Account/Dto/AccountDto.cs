namespace Stocksy.Account.Dto {
    public class AccountDto {
        public int Id { get; set; }

        public int UserId { get; set; }

        public AccountType AccountType { get; set; }

        public double Amount { get; set; }

        public DateTime CreatedDate { get; set;}

        public DateTime? UpdatedDate { get; set;}
    }
}