namespace Stocksy.User.Dto {
    public class LoginInfoDto {
        public int Id { get; set; }

        public required string Email { get; set;}

        public string? Password { get; set; }

        public DateTime CreatedDate { get; set;}

        public DateTime? UpdatedDate { get; set; }
    }
}