namespace WebApi.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int Salary {get; set;}
        public string LoginName {get; set;}
        public string DisplayName {get; set;}
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool IsActive {get; set;}
        public string Country {get; set;}
        public string Address {get; set;}
        public string DateOfBirth {get; set;}
        public string File {get; set;}
    }
}