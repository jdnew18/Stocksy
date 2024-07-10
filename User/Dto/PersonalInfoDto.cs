namespace Stocksy.User.Dto {
    public class PersonalInfoDto {
        public int Id { get; set; }

        public required int LoginInfoId { get; set; }

        public int PhoneNumber { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime CreatedDate { get; set;}

        public DateTime? UpdatedDate { get; set; }
    }
}