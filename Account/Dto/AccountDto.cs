namespace Stocksy.Account.Dto {
    public class AccountDto {
        public int Id { get; set; }

        public AccountType AccountType { get; set; }

        public int UserId { get; set; }

        public DateTime CreatedDate { get; set;}

        public DateTime? UpdatedDate { get; set;}
    }
}